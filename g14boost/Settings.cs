using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g14boost
{
    public partial class Settings : Form
    {
        class ComboItem
        {
            public int ID { get; set; }
            public string Text { get; set; }
        }

        public Settings()
        {
            InitializeComponent();
        }


        private void Settings_Load(object sender, EventArgs e)
        {
            // Setup tool tips
            ToolTip acBoostEnableTemperatureToolTip = new ToolTip();
            ToolTip acBoostDisableTemperatureToolTip = new ToolTip();
            ToolTip dcBoostEnableTemperatureToolTip = new ToolTip();
            ToolTip dcBoostDisableTemperatureToolTip = new ToolTip();
            ToolTip overTempToolTip = new ToolTip();
            ToolTip acEnabledCheckBoxToolTip = new ToolTip();
            ToolTip dcEnabledCheckBoxToolTip = new ToolTip();
            ToolTip refreshRateNumericToolTip = new ToolTip();
            ToolTip acBoostEnableNameToolTip = new ToolTip();
            ToolTip acBoostDisableNameToolTip = new ToolTip();
            ToolTip dcBoostEnableNameToolTip = new ToolTip();
            ToolTip dcBoostDisableNameToolTip = new ToolTip();
            acBoostEnableTemperatureToolTip.SetToolTip(acBoostEnableTemperature, "When CPU temperature falls below this threshold, boost is enabled.");
            acBoostDisableTemperatureToolTip.SetToolTip(acBoostDisableTemperature, "When CPU temperature rises above this threshold, boost is disabled.");
            dcBoostEnableTemperatureToolTip.SetToolTip(dcBoostEnableTemperature, "When CPU temperature falls below this threshold, boost is enabled.");
            dcBoostDisableTemperatureToolTip.SetToolTip(dcBoostDisableTemperature, "When CPU temperature rises above this threshold, boost is disabled.");
            overTempToolTip.SetToolTip(overTemp, "When CPU temperature rises above this threshold, kick in over temperature protection.");
            acEnabledCheckBoxToolTip.SetToolTip(acEnabledCheckBox, "Check to enable boost control when on AC power.");
            dcEnabledCheckBoxToolTip.SetToolTip(dcEnabledCheckBox, "Check to enable boost control when on battery power.");
            refreshRateNumericToolTip.SetToolTip(refreshRateNumeric, "Specify how often to poll for CPU temperature changes.");
            acBoostEnableNameToolTip.SetToolTip(acBoostEnableName, "Which policy to use when threshold is met. If unsure, select Enabled.");
            acBoostDisableNameToolTip.SetToolTip(acBoostDisableName, "Which policy to use when threshold is met. If unsure, select Disabled.");
            dcBoostEnableNameToolTip.SetToolTip(dcBoostEnableName, "Which policy to use when threshold is met. If unsure, select Disabled.");
            dcBoostDisableNameToolTip.SetToolTip(dcBoostDisableName, "Which policy to use when threshold is met. If unsure, select Disabled.");

            //  Load settings
            acBoostEnableTemperature.Text = Properties.Settings.Default.EnableTempAC.ToString();
            acBoostDisableTemperature.Text = Properties.Settings.Default.DisableTempAC.ToString();
            dcBoostEnableTemperature.Text = Properties.Settings.Default.EnableTempDC.ToString();
            dcBoostDisableTemperature.Text = Properties.Settings.Default.DisableTempDC.ToString();
            overTemp.Text = Properties.Settings.Default.OverTemp.ToString();
            acEnabledCheckBox.Checked = Properties.Settings.Default.EnabledAC;
            dcEnabledCheckBox.Checked = Properties.Settings.Default.EnabledDC;
            refreshRateNumeric.Value = Properties.Settings.Default.RefreshRate;

            // Get current settings to populate combo boxes
            PowerCfg.QueryValue? qv = PowerCfg.PowerCfgBroker.Query("scheme_current", "sub_processor", "perfboostmode");
            if (qv == null || (qv.Value.SubGroups.Count < 1) || (qv.Value.SubGroups[0].Settings.Count < 1)) return;
            PowerCfg.QueryPossibleSetting[] possibleSettings = qv.Value.SubGroups[0].Settings[0].PossibleSettings;
            var comboItems = Enumerable.Range(0, possibleSettings.Length).Select(i => new ComboItem { ID = i, Text = possibleSettings[i].FriendlyName }).ToArray();
            acBoostEnableName.DataSource = comboItems.Clone();
            acBoostDisableName.DataSource = comboItems.Clone();
            dcBoostEnableName.DataSource = comboItems.Clone();
            dcBoostDisableName.DataSource = comboItems.Clone();
            string enabledNameAC = Properties.Settings.Default.EnabledNameAC;
            string disabledNameAC = Properties.Settings.Default.DisabledNameAC;
            string enabledNameDC = Properties.Settings.Default.EnabledNameDC;
            string disabledNameDC = Properties.Settings.Default.DisabledNameDC;
            acBoostEnableName.SelectedIndex = Array.FindIndex(possibleSettings, setting => setting.FriendlyName.Equals(enabledNameAC));
            acBoostDisableName.SelectedIndex = Array.FindIndex(possibleSettings, setting => setting.FriendlyName.Equals(disabledNameAC));
            dcBoostEnableName.SelectedIndex = Array.FindIndex(possibleSettings, setting => setting.FriendlyName.Equals(enabledNameDC));
            dcBoostDisableName.SelectedIndex = Array.FindIndex(possibleSettings, setting => setting.FriendlyName.Equals(disabledNameDC));

            acEnabledCheckBox_CheckStateChanged(this, new EventArgs());
            dcEnabledCheckBox_CheckStateChanged(this, new EventArgs());
            this.Visible = true;
        }

        string acBoostEnableTemperaturePreviousInput = "";
        private void acBoostEnableTemperature_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex("^-{0,1}\\d+\\.{0,1}\\d*$");
            Match m = r.Match(acBoostEnableTemperature.Text);
            if (m.Success || acBoostEnableTemperature.Text == "")
            {
                acBoostEnableTemperaturePreviousInput = acBoostEnableTemperature.Text;
            }
            else
            {
                acBoostEnableTemperature.Text = acBoostEnableTemperaturePreviousInput;
            }
        }

        string acBoostDisableTemperaturePreviousInput = "";
        private void acBoostDisableTemperature_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex("^-{0,1}\\d+\\.{0,1}\\d*$");
            Match m = r.Match(acBoostDisableTemperature.Text);
            if (m.Success || acBoostDisableTemperature.Text == "")
            {
                acBoostDisableTemperaturePreviousInput = acBoostDisableTemperature.Text;
            }
            else
            {
                acBoostDisableTemperature.Text = acBoostDisableTemperaturePreviousInput;
            }
        }

        string dcBoostEnableTemperaturePreviousInput = "";
        private void dcBoostEnableTemperature_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex("^-{0,1}\\d+\\.{0,1}\\d*$");
            Match m = r.Match(dcBoostEnableTemperature.Text);
            if (m.Success || dcBoostEnableTemperature.Text == "")
            {
                dcBoostEnableTemperaturePreviousInput = dcBoostEnableTemperature.Text;
            }
            else
            {
                dcBoostEnableTemperature.Text = dcBoostEnableTemperaturePreviousInput;
            }
        }

        string dcBoostDisableTemperaturePreviousInput = "";
        private void dcBoostDisableTemperature_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex("^-{0,1}\\d+\\.{0,1}\\d*$");
            Match m = r.Match(dcBoostDisableTemperature.Text);
            if (m.Success || dcBoostDisableTemperature.Text == "")
            {
                dcBoostDisableTemperaturePreviousInput = dcBoostDisableTemperature.Text;
            }
            else
            {
                dcBoostDisableTemperature.Text = dcBoostDisableTemperaturePreviousInput;
            }
        }

        string overTempPreviousInput = "";
        private void overTemp_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex("^-{0,1}\\d+\\.{0,1}\\d*$");
            Match m = r.Match(overTemp.Text);
            if (m.Success || overTemp.Text == "")
            {
                overTempPreviousInput = overTemp.Text;
            }
            else
            {
                overTemp.Text = overTempPreviousInput;
            }
        }

        private void acEnabledCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            acBoostEnableTemperature.Enabled = acEnabledCheckBox.Checked;
            acBoostDisableTemperature.Enabled = acEnabledCheckBox.Checked;
            acBoostEnableName.Enabled = acEnabledCheckBox.Checked;
            acBoostDisableName.Enabled = acEnabledCheckBox.Checked;
        }

        private void dcEnabledCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            dcBoostEnableTemperature.Enabled = dcEnabledCheckBox.Checked;
            dcBoostDisableTemperature.Enabled = dcEnabledCheckBox.Checked;
            dcBoostEnableName.Enabled = dcEnabledCheckBox.Checked;
            dcBoostDisableName.Enabled = dcEnabledCheckBox.Checked;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Save settings
            Properties.Settings.Default.EnableTempAC = float.Parse(acBoostEnableTemperature.Text);
            Properties.Settings.Default.DisableTempAC = float.Parse(acBoostDisableTemperature.Text);
            Properties.Settings.Default.EnableTempDC = float.Parse(dcBoostEnableTemperature.Text);
            Properties.Settings.Default.DisableTempDC = float.Parse(dcBoostDisableTemperature.Text);
            Properties.Settings.Default.OverTemp = float.Parse(overTemp.Text);
            Properties.Settings.Default.EnabledAC = acEnabledCheckBox.Checked;
            Properties.Settings.Default.EnabledDC = dcEnabledCheckBox.Checked;
            Properties.Settings.Default.RefreshRate = refreshRateNumeric.Value;
            if (acBoostEnableName.SelectedIndex > -1) Properties.Settings.Default.EnabledNameAC = acBoostEnableName.Text;
            if (acBoostDisableName.SelectedIndex > -1) Properties.Settings.Default.DisabledNameAC = acBoostDisableName.Text;
            if (dcBoostEnableName.SelectedIndex > -1) Properties.Settings.Default.EnabledNameDC = dcBoostEnableName.Text;
            if (dcBoostDisableName.SelectedIndex > -1) Properties.Settings.Default.DisabledNameDC = dcBoostDisableName.Text;
        }

    }
}
