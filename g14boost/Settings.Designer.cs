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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.acBoostEnableName = new System.Windows.Forms.ComboBox();
            this.acBoostEnableTemperature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.acBoostDisableTemperature = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.acBoostDisableName = new System.Windows.Forms.ComboBox();
            this.acEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dcGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.dcBoostDisableName = new System.Windows.Forms.ComboBox();
            this.dcBoostEnableTemperature = new System.Windows.Forms.TextBox();
            this.dcBoostDisableTemperature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dcBoostEnableName = new System.Windows.Forms.ComboBox();
            this.dcEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.refreshRateNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.overTemp = new System.Windows.Forms.TextBox();
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
            this.acGroupBox.Location = new System.Drawing.Point(12, 12);
            this.acGroupBox.Name = "acGroupBox";
            this.acGroupBox.Size = new System.Drawing.Size(302, 208);
            this.acGroupBox.TabIndex = 0;
            this.acGroupBox.TabStop = false;
            this.acGroupBox.Text = "On AC Adapter";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.61972F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.38028F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.acBoostEnableName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.acBoostEnableTemperature, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.acBoostDisableTemperature, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.acBoostDisableName, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 148);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Disable mode";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Enable mode";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // acBoostEnableName
            // 
            this.acBoostEnableName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.acBoostEnableName.DisplayMember = "Text";
            this.acBoostEnableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acBoostEnableName.FormattingEnabled = true;
            this.acBoostEnableName.Location = new System.Drawing.Point(2, 45);
            this.acBoostEnableName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acBoostEnableName.Name = "acBoostEnableName";
            this.acBoostEnableName.Size = new System.Drawing.Size(102, 21);
            this.acBoostEnableName.TabIndex = 2;
            this.acBoostEnableName.ValueMember = "ID";
            // 
            // acBoostEnableTemperature
            // 
            this.acBoostEnableTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.acBoostEnableTemperature.Location = new System.Drawing.Point(3, 8);
            this.acBoostEnableTemperature.Name = "acBoostEnableTemperature";
            this.acBoostEnableTemperature.Size = new System.Drawing.Size(100, 20);
            this.acBoostEnableTemperature.TabIndex = 1;
            this.acBoostEnableTemperature.TextChanged += new System.EventHandler(this.acBoostEnableTemperature_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Boost enable temperature";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // acBoostDisableTemperature
            // 
            this.acBoostDisableTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.acBoostDisableTemperature.Location = new System.Drawing.Point(3, 82);
            this.acBoostDisableTemperature.Name = "acBoostDisableTemperature";
            this.acBoostDisableTemperature.Size = new System.Drawing.Size(100, 20);
            this.acBoostDisableTemperature.TabIndex = 3;
            this.acBoostDisableTemperature.TextChanged += new System.EventHandler(this.acBoostDisableTemperature_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boost disable temperature";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // acBoostDisableName
            // 
            this.acBoostDisableName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.acBoostDisableName.DisplayMember = "Text";
            this.acBoostDisableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acBoostDisableName.FormattingEnabled = true;
            this.acBoostDisableName.Location = new System.Drawing.Point(2, 119);
            this.acBoostDisableName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acBoostDisableName.Name = "acBoostDisableName";
            this.acBoostDisableName.Size = new System.Drawing.Size(102, 21);
            this.acBoostDisableName.TabIndex = 4;
            this.acBoostDisableName.ValueMember = "ID";
            // 
            // acEnabledCheckBox
            // 
            this.acEnabledCheckBox.AutoSize = true;
            this.acEnabledCheckBox.Location = new System.Drawing.Point(231, 19);
            this.acEnabledCheckBox.Name = "acEnabledCheckBox";
            this.acEnabledCheckBox.Size = new System.Drawing.Size(65, 17);
            this.acEnabledCheckBox.TabIndex = 1;
            this.acEnabledCheckBox.Text = "Enabled";
            this.acEnabledCheckBox.UseVisualStyleBackColor = true;
            this.acEnabledCheckBox.CheckStateChanged += new System.EventHandler(this.acEnabledCheckBox_CheckStateChanged);
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(472, 278);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(553, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dcGroupBox
            // 
            this.dcGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.dcGroupBox.Controls.Add(this.dcEnabledCheckBox);
            this.dcGroupBox.Location = new System.Drawing.Point(335, 12);
            this.dcGroupBox.Name = "dcGroupBox";
            this.dcGroupBox.Size = new System.Drawing.Size(302, 208);
            this.dcGroupBox.TabIndex = 2;
            this.dcGroupBox.TabStop = false;
            this.dcGroupBox.Text = "On DC Power";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.61972F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.38028F));
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dcBoostDisableName, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dcBoostEnableTemperature, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dcBoostDisableTemperature, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dcBoostEnableName, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 42);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(290, 148);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Disable mode";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dcBoostDisableName
            // 
            this.dcBoostDisableName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dcBoostDisableName.DisplayMember = "Text";
            this.dcBoostDisableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dcBoostDisableName.FormattingEnabled = true;
            this.dcBoostDisableName.Location = new System.Drawing.Point(2, 119);
            this.dcBoostDisableName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dcBoostDisableName.Name = "dcBoostDisableName";
            this.dcBoostDisableName.Size = new System.Drawing.Size(102, 21);
            this.dcBoostDisableName.TabIndex = 9;
            this.dcBoostDisableName.ValueMember = "ID";
            // 
            // dcBoostEnableTemperature
            // 
            this.dcBoostEnableTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dcBoostEnableTemperature.Location = new System.Drawing.Point(3, 8);
            this.dcBoostEnableTemperature.Name = "dcBoostEnableTemperature";
            this.dcBoostEnableTemperature.Size = new System.Drawing.Size(100, 20);
            this.dcBoostEnableTemperature.TabIndex = 6;
            this.dcBoostEnableTemperature.TextChanged += new System.EventHandler(this.dcBoostEnableTemperature_TextChanged);
            // 
            // dcBoostDisableTemperature
            // 
            this.dcBoostDisableTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dcBoostDisableTemperature.Location = new System.Drawing.Point(3, 82);
            this.dcBoostDisableTemperature.Name = "dcBoostDisableTemperature";
            this.dcBoostDisableTemperature.Size = new System.Drawing.Size(100, 20);
            this.dcBoostDisableTemperature.TabIndex = 8;
            this.dcBoostDisableTemperature.TextChanged += new System.EventHandler(this.dcBoostDisableTemperature_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Boost enable temperature";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Boost disable temperature";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Enable mode";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dcBoostEnableName
            // 
            this.dcBoostEnableName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dcBoostEnableName.DisplayMember = "Text";
            this.dcBoostEnableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dcBoostEnableName.FormattingEnabled = true;
            this.dcBoostEnableName.Location = new System.Drawing.Point(2, 45);
            this.dcBoostEnableName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dcBoostEnableName.Name = "dcBoostEnableName";
            this.dcBoostEnableName.Size = new System.Drawing.Size(102, 21);
            this.dcBoostEnableName.TabIndex = 7;
            this.dcBoostEnableName.ValueMember = "ID";
            // 
            // dcEnabledCheckBox
            // 
            this.dcEnabledCheckBox.AutoSize = true;
            this.dcEnabledCheckBox.Location = new System.Drawing.Point(231, 19);
            this.dcEnabledCheckBox.Name = "dcEnabledCheckBox";
            this.dcEnabledCheckBox.Size = new System.Drawing.Size(65, 17);
            this.dcEnabledCheckBox.TabIndex = 5;
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
            this.refreshRateNumeric.Location = new System.Drawing.Point(3, 8);
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
            this.refreshRateNumeric.Size = new System.Drawing.Size(72, 20);
            this.refreshRateNumeric.TabIndex = 10;
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
            this.label5.Location = new System.Drawing.Point(81, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(18, 227);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.79518F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.20482F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(213, 74);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Over temp protection";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // overTemp
            // 
            this.overTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.overTemp.Location = new System.Drawing.Point(3, 45);
            this.overTemp.Name = "overTemp";
            this.overTemp.Size = new System.Drawing.Size(72, 20);
            this.overTemp.TabIndex = 11;
            this.overTemp.TextChanged += new System.EventHandler(this.overTemp_TextChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 320);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.dcGroupBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.acGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox acBoostEnableName;
        private System.Windows.Forms.ComboBox acBoostDisableName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox dcBoostDisableName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox dcBoostEnableName;
    }
}