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
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            acBoostEnableTemperature.Text = Properties.Settings.Default.EnableTempAC.ToString();
            acBoostDisableTemperature.Text = Properties.Settings.Default.DisableTempAC.ToString();
            dcBoostEnableTemperature.Text = Properties.Settings.Default.EnableTempDC.ToString();
            dcBoostDisableTemperature.Text = Properties.Settings.Default.DisableTempDC.ToString();
            acEnabledCheckBox.Checked = Properties.Settings.Default.EnabledAC;
            dcEnabledCheckBox.Checked = Properties.Settings.Default.EnabledDC;
            refreshRateNumeric.Value = Properties.Settings.Default.RefreshRate;
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

        private void acEnabledCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            acBoostEnableTemperature.Enabled = acEnabledCheckBox.Checked;
            acBoostDisableTemperature.Enabled = acEnabledCheckBox.Checked;
        }

        private void dcEnabledCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            dcBoostEnableTemperature.Enabled = dcEnabledCheckBox.Checked;
            dcBoostDisableTemperature.Enabled = dcEnabledCheckBox.Checked;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EnableTempAC = float.Parse(acBoostEnableTemperature.Text);
            Properties.Settings.Default.DisableTempAC = float.Parse(acBoostDisableTemperature.Text);
            Properties.Settings.Default.EnableTempDC = float.Parse(dcBoostEnableTemperature.Text);
            Properties.Settings.Default.DisableTempDC = float.Parse(dcBoostDisableTemperature.Text);
            Properties.Settings.Default.EnabledAC = acEnabledCheckBox.Checked;
            Properties.Settings.Default.EnabledDC = dcEnabledCheckBox.Checked;
            Properties.Settings.Default.RefreshRate = refreshRateNumeric.Value;
        }
    }
}
