namespace ImagXpressDemo
{
    partial class TwainScanForm
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
            if (twainDevice != null)
            {
                twainDevice.Scanned -= twainDevice_Scanned;

                twainDevice.Dispose();
                twainDevice = null;
            }            
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
            this.NegotiateButton = new System.Windows.Forms.Button();
            this.UserInterfaceCheckBox = new System.Windows.Forms.CheckBox();
            this.DsmGroupBox = new System.Windows.Forms.GroupBox();
            this.VersionInUseLabel = new System.Windows.Forms.Label();
            this.DsmLabel = new System.Windows.Forms.Label();
            this.DsmInUseTextBox = new System.Windows.Forms.TextBox();
            this.DsmComboBox = new System.Windows.Forms.ComboBox();
            this.CapabilitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CurrentValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.CapabilitiesLabel = new System.Windows.Forms.Label();
            this.CurrentValueLabel = new System.Windows.Forms.Label();
            this.DefaultValueTextBox = new System.Windows.Forms.TextBox();
            this.CapabilitiesComboBox = new System.Windows.Forms.ComboBox();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.DefaultValueLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValuesLabel = new System.Windows.Forms.Label();
            this.MinimumLabel = new System.Windows.Forms.Label();
            this.MaximumLabel = new System.Windows.Forms.Label();
            this.MaximumTextBox = new System.Windows.Forms.TextBox();
            this.MinimumTextBox = new System.Windows.Forms.TextBox();
            this.StepLabel = new System.Windows.Forms.Label();
            this.StepTextBox = new System.Windows.Forms.TextBox();
            this.DsmGroupBox.SuspendLayout();
            this.CapabilitiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcquireButton
            // 
            this.AcquireButton.TabIndex = 6;
            this.AcquireButton.Click += new System.EventHandler(this.AcquireButton_Click);
            // 
            // SelectSourceButton
            // 
            this.SelectSourceButton.Click += new System.EventHandler(this.SelectSourceButton_Click);
            // 
            // AcceptImageButton
            // 
            this.AcceptImageButton.TabIndex = 11;
            // 
            // imageXView1
            // 
            this.imageXView1.TabIndex = 2;
            // 
            // PreviousButton
            // 
            this.PreviousButton.TabIndex = 7;
            // 
            // NextButton
            // 
            this.NextButton.TabIndex = 8;
            // 
            // CancelScanButton
            // 
            this.CancelScanButton.TabIndex = 12;
            // 
            // PageLabel
            // 
            this.PageLabel.TabIndex = 9;
            // 
            // PageTextBox
            // 
            this.PageTextBox.TabIndex = 10;
            // 
            // NegotiateButton
            // 
            this.NegotiateButton.Enabled = false;
            this.NegotiateButton.Location = new System.Drawing.Point(9, 157);
            this.NegotiateButton.Name = "NegotiateButton";
            this.NegotiateButton.Size = new System.Drawing.Size(128, 23);
            this.NegotiateButton.TabIndex = 4;
            this.NegotiateButton.Text = "Negotiate Capabilities";
            this.NegotiateButton.UseVisualStyleBackColor = true;
            this.NegotiateButton.Click += new System.EventHandler(this.NegotiateButton_Click);
            // 
            // UserInterfaceCheckBox
            // 
            this.UserInterfaceCheckBox.AutoSize = true;
            this.UserInterfaceCheckBox.Location = new System.Drawing.Point(130, 22);
            this.UserInterfaceCheckBox.Name = "UserInterfaceCheckBox";
            this.UserInterfaceCheckBox.Size = new System.Drawing.Size(144, 17);
            this.UserInterfaceCheckBox.TabIndex = 1;
            this.UserInterfaceCheckBox.Text = "Display Scanner Settings";
            this.UserInterfaceCheckBox.UseVisualStyleBackColor = true;
            this.UserInterfaceCheckBox.CheckedChanged += new System.EventHandler(this.UserInterfaceCheckBox_CheckedChanged);
            // 
            // DsmGroupBox
            // 
            this.DsmGroupBox.Controls.Add(this.VersionInUseLabel);
            this.DsmGroupBox.Controls.Add(this.DsmLabel);
            this.DsmGroupBox.Controls.Add(this.DsmInUseTextBox);
            this.DsmGroupBox.Controls.Add(this.DsmComboBox);
            this.DsmGroupBox.Location = new System.Drawing.Point(9, 47);
            this.DsmGroupBox.Name = "DsmGroupBox";
            this.DsmGroupBox.Size = new System.Drawing.Size(183, 104);
            this.DsmGroupBox.TabIndex = 3;
            this.DsmGroupBox.TabStop = false;
            this.DsmGroupBox.Text = "TWAIN Data Source Manager";
            // 
            // VersionInUseLabel
            // 
            this.VersionInUseLabel.AutoSize = true;
            this.VersionInUseLabel.Location = new System.Drawing.Point(16, 61);
            this.VersionInUseLabel.Name = "VersionInUseLabel";
            this.VersionInUseLabel.Size = new System.Drawing.Size(79, 13);
            this.VersionInUseLabel.TabIndex = 2;
            this.VersionInUseLabel.Text = "Version In Use:";
            // 
            // DsmLabel
            // 
            this.DsmLabel.AutoSize = true;
            this.DsmLabel.Location = new System.Drawing.Point(16, 16);
            this.DsmLabel.Name = "DsmLabel";
            this.DsmLabel.Size = new System.Drawing.Size(45, 13);
            this.DsmLabel.TabIndex = 0;
            this.DsmLabel.Text = "Version:";
            // 
            // DsmInUseTextBox
            // 
            this.DsmInUseTextBox.Location = new System.Drawing.Point(19, 77);
            this.DsmInUseTextBox.Name = "DsmInUseTextBox";
            this.DsmInUseTextBox.ReadOnly = true;
            this.DsmInUseTextBox.Size = new System.Drawing.Size(126, 20);
            this.DsmInUseTextBox.TabIndex = 3;
            // 
            // DsmComboBox
            // 
            this.DsmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DsmComboBox.FormattingEnabled = true;
            this.DsmComboBox.Items.AddRange(new object[] {
            "Latest Available",
            "Version 1",
            "Version 2"});
            this.DsmComboBox.Location = new System.Drawing.Point(17, 35);
            this.DsmComboBox.Name = "DsmComboBox";
            this.DsmComboBox.Size = new System.Drawing.Size(128, 21);
            this.DsmComboBox.TabIndex = 1;
            this.DsmComboBox.SelectedIndexChanged += new System.EventHandler(this.DsmComboBox_SelectedIndexChanged);
            // 
            // CapabilitiesGroupBox
            // 
            this.CapabilitiesGroupBox.Controls.Add(this.UpdateButton);
            this.CapabilitiesGroupBox.Controls.Add(this.CurrentValueTextBox);
            this.CapabilitiesGroupBox.Controls.Add(this.ValuesListBox);
            this.CapabilitiesGroupBox.Controls.Add(this.CapabilitiesLabel);
            this.CapabilitiesGroupBox.Controls.Add(this.CurrentValueLabel);
            this.CapabilitiesGroupBox.Controls.Add(this.DefaultValueTextBox);
            this.CapabilitiesGroupBox.Controls.Add(this.CapabilitiesComboBox);
            this.CapabilitiesGroupBox.Controls.Add(this.ValueTextBox);
            this.CapabilitiesGroupBox.Controls.Add(this.DefaultValueLabel);
            this.CapabilitiesGroupBox.Controls.Add(this.ValueLabel);
            this.CapabilitiesGroupBox.Controls.Add(this.ValuesLabel);
            this.CapabilitiesGroupBox.Controls.Add(this.MinimumLabel);
            this.CapabilitiesGroupBox.Controls.Add(this.MaximumLabel);
            this.CapabilitiesGroupBox.Controls.Add(this.MaximumTextBox);
            this.CapabilitiesGroupBox.Controls.Add(this.MinimumTextBox);
            this.CapabilitiesGroupBox.Controls.Add(this.StepLabel);
            this.CapabilitiesGroupBox.Controls.Add(this.StepTextBox);
            this.CapabilitiesGroupBox.Location = new System.Drawing.Point(9, 186);
            this.CapabilitiesGroupBox.Name = "CapabilitiesGroupBox";
            this.CapabilitiesGroupBox.Size = new System.Drawing.Size(262, 271);
            this.CapabilitiesGroupBox.TabIndex = 5;
            this.CapabilitiesGroupBox.TabStop = false;
            this.CapabilitiesGroupBox.Text = "Source Capabilities";
            this.CapabilitiesGroupBox.Visible = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(131, 238);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CurrentValueTextBox
            // 
            this.CurrentValueTextBox.Location = new System.Drawing.Point(16, 125);
            this.CurrentValueTextBox.Name = "CurrentValueTextBox";
            this.CurrentValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurrentValueTextBox.TabIndex = 8;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(16, 166);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(100, 95);
            this.ValuesListBox.TabIndex = 11;
            // 
            // CapabilitiesLabel
            // 
            this.CapabilitiesLabel.AutoSize = true;
            this.CapabilitiesLabel.Location = new System.Drawing.Point(16, 16);
            this.CapabilitiesLabel.Name = "CapabilitiesLabel";
            this.CapabilitiesLabel.Size = new System.Drawing.Size(55, 13);
            this.CapabilitiesLabel.TabIndex = 0;
            this.CapabilitiesLabel.Text = "Capability:";
            // 
            // CurrentValueLabel
            // 
            this.CurrentValueLabel.AutoSize = true;
            this.CurrentValueLabel.Location = new System.Drawing.Point(16, 108);
            this.CurrentValueLabel.Name = "CurrentValueLabel";
            this.CurrentValueLabel.Size = new System.Drawing.Size(74, 13);
            this.CurrentValueLabel.TabIndex = 6;
            this.CurrentValueLabel.Text = "Current Value:";
            // 
            // DefaultValueTextBox
            // 
            this.DefaultValueTextBox.Location = new System.Drawing.Point(132, 166);
            this.DefaultValueTextBox.Name = "DefaultValueTextBox";
            this.DefaultValueTextBox.ReadOnly = true;
            this.DefaultValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.DefaultValueTextBox.TabIndex = 13;
            // 
            // CapabilitiesComboBox
            // 
            this.CapabilitiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CapabilitiesComboBox.FormattingEnabled = true;
            this.CapabilitiesComboBox.Location = new System.Drawing.Point(16, 32);
            this.CapabilitiesComboBox.Name = "CapabilitiesComboBox";
            this.CapabilitiesComboBox.Size = new System.Drawing.Size(216, 21);
            this.CapabilitiesComboBox.TabIndex = 1;
            this.CapabilitiesComboBox.SelectedIndexChanged += new System.EventHandler(this.CapabilitiesComboBox_SelectedIndexChanged);
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(16, 84);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.ValueTextBox.TabIndex = 3;
            // 
            // DefaultValueLabel
            // 
            this.DefaultValueLabel.AutoSize = true;
            this.DefaultValueLabel.Location = new System.Drawing.Point(132, 149);
            this.DefaultValueLabel.Name = "DefaultValueLabel";
            this.DefaultValueLabel.Size = new System.Drawing.Size(74, 13);
            this.DefaultValueLabel.TabIndex = 12;
            this.DefaultValueLabel.Text = "Default Value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(16, 67);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(37, 13);
            this.ValueLabel.TabIndex = 2;
            this.ValueLabel.Text = "Value:";
            // 
            // ValuesLabel
            // 
            this.ValuesLabel.AutoSize = true;
            this.ValuesLabel.Location = new System.Drawing.Point(16, 149);
            this.ValuesLabel.Name = "ValuesLabel";
            this.ValuesLabel.Size = new System.Drawing.Size(42, 13);
            this.ValuesLabel.TabIndex = 10;
            this.ValuesLabel.Text = "Values:";
            // 
            // MinimumLabel
            // 
            this.MinimumLabel.AutoSize = true;
            this.MinimumLabel.Location = new System.Drawing.Point(132, 67);
            this.MinimumLabel.Name = "MinimumLabel";
            this.MinimumLabel.Size = new System.Drawing.Size(51, 13);
            this.MinimumLabel.TabIndex = 4;
            this.MinimumLabel.Text = "Minimum:";
            // 
            // MaximumLabel
            // 
            this.MaximumLabel.AutoSize = true;
            this.MaximumLabel.Location = new System.Drawing.Point(132, 108);
            this.MaximumLabel.Name = "MaximumLabel";
            this.MaximumLabel.Size = new System.Drawing.Size(54, 13);
            this.MaximumLabel.TabIndex = 7;
            this.MaximumLabel.Text = "Maximum:";
            // 
            // MaximumTextBox
            // 
            this.MaximumTextBox.Location = new System.Drawing.Point(132, 125);
            this.MaximumTextBox.Name = "MaximumTextBox";
            this.MaximumTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaximumTextBox.TabIndex = 9;
            // 
            // MinimumTextBox
            // 
            this.MinimumTextBox.Location = new System.Drawing.Point(132, 84);
            this.MinimumTextBox.Name = "MinimumTextBox";
            this.MinimumTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinimumTextBox.TabIndex = 5;
            // 
            // StepLabel
            // 
            this.StepLabel.AutoSize = true;
            this.StepLabel.Location = new System.Drawing.Point(132, 190);
            this.StepLabel.Name = "StepLabel";
            this.StepLabel.Size = new System.Drawing.Size(32, 13);
            this.StepLabel.TabIndex = 14;
            this.StepLabel.Text = "Step:";
            // 
            // StepTextBox
            // 
            this.StepTextBox.Location = new System.Drawing.Point(132, 206);
            this.StepTextBox.Name = "StepTextBox";
            this.StepTextBox.Size = new System.Drawing.Size(100, 20);
            this.StepTextBox.TabIndex = 15;
            // 
            // TwainScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 545);
            this.Controls.Add(this.NegotiateButton);
            this.Controls.Add(this.UserInterfaceCheckBox);
            this.Controls.Add(this.DsmGroupBox);
            this.Controls.Add(this.CapabilitiesGroupBox);
            this.Name = "TwainScanForm";
            this.Text = "TWAIN Scan";
            this.Load += new System.EventHandler(this.TwainScanForm_Load);
            this.Controls.SetChildIndex(this.PageLabel, 0);
            this.Controls.SetChildIndex(this.CancelScanButton, 0);
            this.Controls.SetChildIndex(this.NextButton, 0);
            this.Controls.SetChildIndex(this.PreviousButton, 0);
            this.Controls.SetChildIndex(this.imageXView1, 0);
            this.Controls.SetChildIndex(this.AcceptImageButton, 0);
            this.Controls.SetChildIndex(this.PageTextBox, 0);
            this.Controls.SetChildIndex(this.SelectSourceButton, 0);
            this.Controls.SetChildIndex(this.AcquireButton, 0);
            this.Controls.SetChildIndex(this.CapabilitiesGroupBox, 0);
            this.Controls.SetChildIndex(this.DsmGroupBox, 0);
            this.Controls.SetChildIndex(this.UserInterfaceCheckBox, 0);
            this.Controls.SetChildIndex(this.NegotiateButton, 0);
            this.DsmGroupBox.ResumeLayout(false);
            this.DsmGroupBox.PerformLayout();
            this.CapabilitiesGroupBox.ResumeLayout(false);
            this.CapabilitiesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NegotiateButton;
        private System.Windows.Forms.CheckBox UserInterfaceCheckBox;
        private System.Windows.Forms.GroupBox DsmGroupBox;
        private System.Windows.Forms.Label VersionInUseLabel;
        private System.Windows.Forms.Label DsmLabel;
        private System.Windows.Forms.TextBox DsmInUseTextBox;
        private System.Windows.Forms.ComboBox DsmComboBox;
        private System.Windows.Forms.GroupBox CapabilitiesGroupBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox CurrentValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label CapabilitiesLabel;
        private System.Windows.Forms.Label CurrentValueLabel;
        private System.Windows.Forms.TextBox DefaultValueTextBox;
        private System.Windows.Forms.ComboBox CapabilitiesComboBox;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Label DefaultValueLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label ValuesLabel;
        private System.Windows.Forms.Label MinimumLabel;
        private System.Windows.Forms.Label MaximumLabel;
        private System.Windows.Forms.TextBox MaximumTextBox;
        private System.Windows.Forms.TextBox MinimumTextBox;
        private System.Windows.Forms.Label StepLabel;
        private System.Windows.Forms.TextBox StepTextBox;
    }
}