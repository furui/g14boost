namespace g14boost
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.acGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.acBoostEnableTemperature = new System.Windows.Forms.TextBox();
            this.acBoostDisableTemperature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.acEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dcGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dcBoostEnableTemperature = new System.Windows.Forms.TextBox();
            this.dcBoostDisableTemperature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dcEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.refreshRateNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.overTemp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.acGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.dcGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRateNumeric)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // acGroupBox
            // 
            this.acGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.acGroupBox.Controls.Add(this.acEnabledCheckBox);
            this.acGroupBox.Location = new System.Drawing.Point(16, 15);
            this.acGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acGroupBox.Name = "acGroupBox";
            this.acGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acGroupBox.Size = new System.Drawing.Size(300, 161);
            this.acGroupBox.TabIndex = 0;
            this.acGroupBox.TabStop = false;
            this.acGroupBox.Text = "On AC Adapter";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.61972F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.38028F));
            this.tableLayoutPanel1.Controls.Add(this.acBoostEnableTemperature, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.acBoostDisableTemperature, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 52);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.79518F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.20482F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 91);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // acBoostEnableTemperature
            // 
            this.acBoostEnableTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.acBoostEnableTemperature.Location = new System.Drawing.Point(4, 11);
            this.acBoostEnableTemperature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acBoostEnableTemperature.Name = "acBoostEnableTemperature";
            this.acBoostEnableTemperature.Size = new System.Drawing.Size(96, 22);
            this.acBoostEnableTemperature.TabIndex = 0;
            this.acBoostEnableTemperature.TextChanged += new System.EventHandler(this.acBoostEnableTemperature_TextChanged);
            // 
            // acBoostDisableTemperature
            // 
            this.acBoostDisableTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.acBoostDisableTemperature.Location = new System.Drawing.Point(4, 56);
            this.acBoostDisableTemperature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acBoostDisableTemperature.Name = "acBoostDisableTemperature";
            this.acBoostDisableTemperature.Size = new System.Drawing.Size(96, 22);
            this.acBoostDisableTemperature.TabIndex = 2;
            this.acBoostDisableTemperature.TextChanged += new System.EventHandler(this.acBoostDisableTemperature_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Boost enable temperature";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boost disable temperature";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // acEnabledCheckBox
            // 
            this.acEnabledCheckBox.AutoSize = true;
            this.acEnabledCheckBox.Location = new System.Drawing.Point(205, 23);
            this.acEnabledCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acEnabledCheckBox.Name = "acEnabledCheckBox";
            this.acEnabledCheckBox.Size = new System.Drawing.Size(82, 21);
            this.acEnabledCheckBox.TabIndex = 1;
            this.acEnabledCheckBox.Text = "Enabled";
            this.acEnabledCheckBox.UseVisualStyleBackColor = true;
            this.acEnabledCheckBox.CheckStateChanged += new System.EventHandler(this.acEnabledCheckBox_CheckStateChanged);
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(423, 247);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(531, 247);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dcGroupBox
            // 
            this.dcGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.dcGroupBox.Controls.Add(this.dcEnabledCheckBox);
            this.dcGroupBox.Location = new System.Drawing.Point(324, 15);
            this.dcGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dcGroupBox.Name = "dcGroupBox";
            this.dcGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dcGroupBox.Size = new System.Drawing.Size(300, 161);
            this.dcGroupBox.TabIndex = 2;
            this.dcGroupBox.TabStop = false;
            this.dcGroupBox.Text = "On DC Power";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.61972F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.38028F));
            this.tableLayoutPanel2.Controls.Add(this.dcBoostEnableTemperature, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dcBoostDisableTemperature, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 52);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.79518F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.20482F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(284, 91);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dcBoostEnableTemperature
            // 
            this.dcBoostEnableTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dcBoostEnableTemperature.Location = new System.Drawing.Point(4, 11);
            this.dcBoostEnableTemperature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dcBoostEnableTemperature.Name = "dcBoostEnableTemperature";
            this.dcBoostEnableTemperature.Size = new System.Drawing.Size(96, 22);
            this.dcBoostEnableTemperature.TabIndex = 0;
            this.dcBoostEnableTemperature.TextChanged += new System.EventHandler(this.dcBoostEnableTemperature_TextChanged);
            // 
            // dcBoostDisableTemperature
            // 
            this.dcBoostDisableTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dcBoostDisableTemperature.Location = new System.Drawing.Point(4, 56);
            this.dcBoostDisableTemperature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dcBoostDisableTemperature.Name = "dcBoostDisableTemperature";
            this.dcBoostDisableTemperature.Size = new System.Drawing.Size(96, 22);
            this.dcBoostDisableTemperature.TabIndex = 2;
            this.dcBoostDisableTemperature.TextChanged += new System.EventHandler(this.dcBoostDisableTemperature_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Boost enable temperature";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Boost disable temperature";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dcEnabledCheckBox
            // 
            this.dcEnabledCheckBox.AutoSize = true;
            this.dcEnabledCheckBox.Location = new System.Drawing.Point(205, 23);
            this.dcEnabledCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dcEnabledCheckBox.Name = "dcEnabledCheckBox";
            this.dcEnabledCheckBox.Size = new System.Drawing.Size(82, 21);
            this.dcEnabledCheckBox.TabIndex = 1;
            this.dcEnabledCheckBox.Text = "Enabled";
            this.dcEnabledCheckBox.UseVisualStyleBackColor = true;
            this.dcEnabledCheckBox.CheckStateChanged += new System.EventHandler(this.dcEnabledCheckBox_CheckStateChanged);
            // 
            // refreshRateNumeric
            // 
            this.refreshRateNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshRateNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.refreshRateNumeric.Location = new System.Drawing.Point(4, 11);
            this.refreshRateNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refreshRateNumeric.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.refreshRateNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.refreshRateNumeric.Name = "refreshRateNumeric";
            this.refreshRateNumeric.Size = new System.Drawing.Size(96, 22);
            this.refreshRateNumeric.TabIndex = 3;
            this.refreshRateNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Refresh rate (ms)";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.61972F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.38028F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.overTemp, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.refreshRateNumeric, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(16, 184);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.79518F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.20482F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(284, 91);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // overTemp
            // 
            this.overTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.overTemp.Location = new System.Drawing.Point(4, 56);
            this.overTemp.Margin = new System.Windows.Forms.Padding(4);
            this.overTemp.Name = "overTemp";
            this.overTemp.Size = new System.Drawing.Size(96, 22);
            this.overTemp.TabIndex = 6;
            this.overTemp.TextChanged += new System.EventHandler(this.overTemp_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Over temp protection";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 290);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.dcGroupBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.acGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.acGroupBox.ResumeLayout(false);
            this.acGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.dcGroupBox.ResumeLayout(false);
            this.dcGroupBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRateNumeric)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox acGroupBox;
        private System.Windows.Forms.CheckBox acEnabledCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox acBoostEnableTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox acBoostDisableTemperature;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox dcGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox dcBoostEnableTemperature;
        private System.Windows.Forms.TextBox dcBoostDisableTemperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox dcEnabledCheckBox;
        private System.Windows.Forms.NumericUpDown refreshRateNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox overTemp;
    }
}