using OpenHardwareMonitor.Hardware;
using PowerCfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g14boost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            if (Properties.Settings.Default.EnabledAC || Properties.Settings.Default.EnabledDC)
            {
                PowerCfg.PowerCfgBroker.SetAttribute("sub_processor", "perfboostmode", "attrib_hide", false);
                tempCheckTimer.Interval = (int)Properties.Settings.Default.RefreshRate;
                tempCheckTimer.Enabled = true;
                mainTrayIcon.Text = "Enabled G14 temp aware boost";
            } else
            {
                tempCheckTimer.Enabled = false;
                mainTrayIcon.Text = "Disabled G14 temp aware boost";
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            form.Opacity = 0;
            form.ShowInTaskbar = false;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new System.Drawing.Point(-2000, -2000);
            form.Size = new System.Drawing.Size(1, 1);
            LoadData();
            if (Properties.Settings.Default.FirstTime)
            {
                DialogResult result = MessageBox.Show("G14Boost enables and disables boost on your CPU, and it will edit your power configuration. The author is not responsible for any damages this program may cause. G14Boost cannot continue unless you agree. Do you agree?", "G14Boost Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                {
                    Application.Exit();
                } else
                {
                    Properties.Settings.Default.FirstTime = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void settingsStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            var res = settingsForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                Properties.Settings.Default.Save();
                LoadData();
            }
            settingsForm.Dispose();
        }

        private void tempCheckTimer_Tick(object sender, EventArgs e)
        {
            // Get CPU temp
            float? cpuTemp = null;
            UpdateVisitor updateVisitor = new UpdateVisitor();
            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;
            computer.Accept(updateVisitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                            cpuTemp = computer.Hardware[i].Sensors[j].Value;
                    }
                }
            }
            computer.Close();
            if (cpuTemp != null)
            {
                // Get current settings
                PowerCfg.QueryValue? qv = PowerCfg.PowerCfgBroker.Query("scheme_current", "sub_processor", "perfboostmode");
                if (qv == null || (qv.Value.SubGroups.Count < 1) || (qv.Value.SubGroups[0].Settings.Count < 1)) return;
                PowerCfg.QuerySetting perfBoostMode = qv.Value.SubGroups[0].Settings[0];
                int efficientEnabled = Array.FindIndex(perfBoostMode.PossibleSettings, setting => setting.FriendlyName == "Efficient Enabled");
                int curACValue = perfBoostMode.ACSetting;
                int curDCValue = perfBoostMode.DCSetting;

                float? enableTemp = null, disableTemp = null;
                bool ac = false, dc = false;
                if (!Utility.IsRunningOnBattery() && Properties.Settings.Default.EnabledAC)
                {
                    enableTemp = Properties.Settings.Default.EnableTempAC;
                    disableTemp = Properties.Settings.Default.DisableTempAC;
                    ac = true;
                } else if (Utility.IsRunningOnBattery() && Properties.Settings.Default.EnabledDC)
                {
                    enableTemp = Properties.Settings.Default.EnableTempDC;
                    disableTemp = Properties.Settings.Default.DisableTempDC;
                    dc = true;
                }
                if (Properties.Settings.Default.EnabledAC || Properties.Settings.Default.EnabledDC)
                {
                    // For now this is only enabled if either AC/DC is enabled
                    if ((cpuTemp > Properties.Settings.Default.OverTemp) && efficientEnabled != -1)
                    {
                        // Putting the power policy into Efficient Enabled seems to knock it out of the aggressive boost state
                        if (ac)
                            PowerCfg.PowerCfgBroker.SetValueIndex(PowerCfg.ValueIndex.AC, "scheme_current", "sub_processor", "perfboostmode", efficientEnabled.ToString());
                        if (dc)
                            PowerCfg.PowerCfgBroker.SetValueIndex(PowerCfg.ValueIndex.DC, "scheme_current", "sub_processor", "perfboostmode", efficientEnabled.ToString());
                        mainTrayIcon.Text = $"WARNING Temp over limit: {cpuTemp.ToString()}c";
                        return;
                    }
                }
                bool boostEnabled = false;
                if (cpuTemp <= enableTemp)
                {
                    if (ac && (curACValue != Properties.Settings.Default.EnabledValueAC))
                        PowerCfg.PowerCfgBroker.SetValueIndex(PowerCfg.ValueIndex.AC, "scheme_current", "sub_processor", "perfboostmode", Properties.Settings.Default.EnabledValueAC.ToString());
                    if (dc && (curACValue != Properties.Settings.Default.EnabledValueDC))
                        PowerCfg.PowerCfgBroker.SetValueIndex(PowerCfg.ValueIndex.DC, "scheme_current", "sub_processor", "perfboostmode", Properties.Settings.Default.EnabledValueDC.ToString());
                    boostEnabled = true;
                }
                else if (cpuTemp >= disableTemp)
                {
                    if (ac && (curACValue != Properties.Settings.Default.DisabledValueAC))
                        PowerCfg.PowerCfgBroker.SetValueIndex(PowerCfg.ValueIndex.AC, "scheme_current", "sub_processor", "perfboostmode", Properties.Settings.Default.DisabledValueAC.ToString());
                    if (dc && (curACValue != Properties.Settings.Default.DisabledValueDC))
                        PowerCfg.PowerCfgBroker.SetValueIndex(PowerCfg.ValueIndex.DC, "scheme_current", "sub_processor", "perfboostmode", Properties.Settings.Default.DisabledValueDC.ToString());
                    boostEnabled = false;
                }
                if (boostEnabled)
                {
                    mainTrayIcon.Text = $"Boost Enabled, Temp: {cpuTemp.ToString()}c";
                } else
                {
                    mainTrayIcon.Text = $"Boost Disabled, Temp: {cpuTemp.ToString()}c";

                }
            }
        }

    }
}
