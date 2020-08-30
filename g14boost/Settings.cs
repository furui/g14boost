﻿using System;
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
            ToolTip acBoostEnableTemperatureToolTip = new ToolTip();
            ToolTip acBoostDisableTemperatureToolTip = new ToolTip();
            ToolTip dcBoostEnableTemperatureToolTip = new ToolTip();
            ToolTip dcBoostDisableTemperatureToolTip = new ToolTip();
            ToolTip overTempToolTip = new ToolTip();
            ToolTip acEnabledCheckBoxToolTip = new ToolTip();
            ToolTip dcEnabledCheckBoxToolTip = new ToolTip();
            ToolTip refreshRateNumericToolTip = new ToolTip();
            acBoostEnableTemperatureToolTip.SetToolTip(acBoostEnableTemperature, "When CPU temperature falls below this threshold, boost is enabled.");
            acBoostDisableTemperatureToolTip.SetToolTip(acBoostDisableTemperature, "When CPU temperature rises above this threshold, boost is disabled.");
            dcBoostEnableTemperatureToolTip.SetToolTip(dcBoostEnableTemperature, "When CPU temperature falls below this threshold, boost is enabled.");
            dcBoostDisableTemperatureToolTip.SetToolTip(dcBoostDisableTemperature, "When CPU temperature rises above this threshold, boost is disabled.");
            overTempToolTip.SetToolTip(overTemp, "When CPU temperature rises above this threshold, kick in over temperature protection.");
            acEnabledCheckBoxToolTip.SetToolTip(acEnabledCheckBox, "Check to enable boost control when on AC power.");
            dcEnabledCheckBoxToolTip.SetToolTip(dcEnabledCheckBox, "Check to enable boost control when on battery power.");
            refreshRateNumericToolTip.SetToolTip(refreshRateNumeric, "Specify how often to poll for CPU temperature changes.");

            acBoostEnableTemperature.Text = Properties.Settings.Default.EnableTempAC.ToString();
            acBoostDisableTemperature.Text = Properties.Settings.Default.DisableTempAC.ToString();
            dcBoostEnableTemperature.Text = Properties.Settings.Default.EnableTempDC.ToString();
            dcBoostDisableTemperature.Text = Properties.Settings.Default.DisableTempDC.ToString();
            overTemp.Text = Properties.Settings.Default.OverTemp.ToString();
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
            Properties.Settings.Default.OverTemp = float.Parse(overTemp.Text);
            Properties.Settings.Default.EnabledAC = acEnabledCheckBox.Checked;
            Properties.Settings.Default.EnabledDC = dcEnabledCheckBox.Checked;
            Properties.Settings.Default.RefreshRate = refreshRateNumeric.Value;
        }

    }
}
