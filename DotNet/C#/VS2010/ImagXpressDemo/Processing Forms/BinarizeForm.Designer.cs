namespace ImagXpressDemo
{
    partial class BinarizeForm
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
            this.BinarizeGroupBox = new System.Windows.Forms.GroupBox();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.ModeComboBox = new System.Windows.Forms.ComboBox();
            this.BlurLabel = new System.Windows.Forms.Label();
            this.BlurComboBox = new System.Windows.Forms.ComboBox();
            this.LceFactorLabel = new System.Windows.Forms.Label();
            this.EccentricityLabel = new System.Windows.Forms.Label();
            this.GridPitchLabel = new System.Windows.Forms.Label();
            this.GridAngleLabel = new System.Windows.Forms.Label();
            this.HighThresholdLabel = new System.Windows.Forms.Label();
            this.LowThresholdLabel = new System.Windows.Forms.Label();
            this.LceFactorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EccentricityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GridPitchNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GridAngleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HighThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LowThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BinarizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LceFactorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EccentricityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPitchNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAngleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowThresholdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(373, 601);
            this.PreviewButton.TabIndex = 4;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(15, 601);
            this.OKButton.TabIndex = 3;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(650, 601);
            this.CancelProcessingButton.TabIndex = 5;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.TabIndex = 6;
            // 
            // BinarizeGroupBox
            // 
            this.BinarizeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BinarizeGroupBox.Controls.Add(this.ModeLabel);
            this.BinarizeGroupBox.Controls.Add(this.ModeComboBox);
            this.BinarizeGroupBox.Controls.Add(this.BlurLabel);
            this.BinarizeGroupBox.Controls.Add(this.BlurComboBox);
            this.BinarizeGroupBox.Controls.Add(this.LceFactorLabel);
            this.BinarizeGroupBox.Controls.Add(this.EccentricityLabel);
            this.BinarizeGroupBox.Controls.Add(this.GridPitchLabel);
            this.BinarizeGroupBox.Controls.Add(this.GridAngleLabel);
            this.BinarizeGroupBox.Controls.Add(this.HighThresholdLabel);
            this.BinarizeGroupBox.Controls.Add(this.LowThresholdLabel);
            this.BinarizeGroupBox.Controls.Add(this.LceFactorNumericUpDown);
            this.BinarizeGroupBox.Controls.Add(this.EccentricityNumericUpDown);
            this.BinarizeGroupBox.Controls.Add(this.GridPitchNumericUpDown);
            this.BinarizeGroupBox.Controls.Add(this.GridAngleNumericUpDown);
            this.BinarizeGroupBox.Controls.Add(this.HighThresholdNumericUpDown);
            this.BinarizeGroupBox.Controls.Add(this.LowThresholdNumericUpDown);
            this.BinarizeGroupBox.Location = new System.Drawing.Point(15, 433);
            this.BinarizeGroupBox.Name = "BinarizeGroupBox";
            this.BinarizeGroupBox.Size = new System.Drawing.Size(298, 161);
            this.BinarizeGroupBox.TabIndex = 2;
            this.BinarizeGroupBox.TabStop = false;
            this.BinarizeGroupBox.Text = "Binarize";
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(26, 28);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(37, 13);
            this.ModeLabel.TabIndex = 0;
            this.ModeLabel.Text = "Mode:";
            // 
            // ModeComboBox
            // 
            this.ModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeComboBox.FormattingEnabled = true;
            this.ModeComboBox.Items.AddRange(new object[] {
            "Quick Text",
            "Photo Halftone",
            "Gray"});
            this.ModeComboBox.Location = new System.Drawing.Point(122, 24);
            this.ModeComboBox.Name = "ModeComboBox";
            this.ModeComboBox.Size = new System.Drawing.Size(113, 21);
            this.ModeComboBox.TabIndex = 1;
            this.ModeComboBox.SelectedIndexChanged += new System.EventHandler(this.ModeComboBox_SelectedIndexChanged);
            // 
            // BlurLabel
            // 
            this.BlurLabel.AutoSize = true;
            this.BlurLabel.Location = new System.Drawing.Point(26, 133);
            this.BlurLabel.Name = "BlurLabel";
            this.BlurLabel.Size = new System.Drawing.Size(28, 13);
            this.BlurLabel.TabIndex = 14;
            this.BlurLabel.Text = "Blur:";
            // 
            // BlurComboBox
            // 
            this.BlurComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BlurComboBox.FormattingEnabled = true;
            this.BlurComboBox.Items.AddRange(new object[] {
            "No Blur",
            "Gaussian",
            "Smart"});
            this.BlurComboBox.Location = new System.Drawing.Point(122, 129);
            this.BlurComboBox.Name = "BlurComboBox";
            this.BlurComboBox.Size = new System.Drawing.Size(113, 21);
            this.BlurComboBox.TabIndex = 15;
            // 
            // LceFactorLabel
            // 
            this.LceFactorLabel.AutoSize = true;
            this.LceFactorLabel.Location = new System.Drawing.Point(26, 107);
            this.LceFactorLabel.Name = "LceFactorLabel";
            this.LceFactorLabel.Size = new System.Drawing.Size(63, 13);
            this.LceFactorLabel.TabIndex = 10;
            this.LceFactorLabel.Text = "LCE Factor:";
            // 
            // EccentricityLabel
            // 
            this.EccentricityLabel.AutoSize = true;
            this.EccentricityLabel.Location = new System.Drawing.Point(173, 107);
            this.EccentricityLabel.Name = "EccentricityLabel";
            this.EccentricityLabel.Size = new System.Drawing.Size(65, 13);
            this.EccentricityLabel.TabIndex = 12;
            this.EccentricityLabel.Text = "Eccentricity:";
            // 
            // GridPitchLabel
            // 
            this.GridPitchLabel.AutoSize = true;
            this.GridPitchLabel.Location = new System.Drawing.Point(173, 81);
            this.GridPitchLabel.Name = "GridPitchLabel";
            this.GridPitchLabel.Size = new System.Drawing.Size(56, 13);
            this.GridPitchLabel.TabIndex = 8;
            this.GridPitchLabel.Text = "Grid Pitch:";
            // 
            // GridAngleLabel
            // 
            this.GridAngleLabel.AutoSize = true;
            this.GridAngleLabel.Location = new System.Drawing.Point(173, 55);
            this.GridAngleLabel.Name = "GridAngleLabel";
            this.GridAngleLabel.Size = new System.Drawing.Size(59, 13);
            this.GridAngleLabel.TabIndex = 4;
            this.GridAngleLabel.Text = "Grid Angle:";
            // 
            // HighThresholdLabel
            // 
            this.HighThresholdLabel.AutoSize = true;
            this.HighThresholdLabel.Location = new System.Drawing.Point(26, 81);
            this.HighThresholdLabel.Name = "HighThresholdLabel";
            this.HighThresholdLabel.Size = new System.Drawing.Size(82, 13);
            this.HighThresholdLabel.TabIndex = 6;
            this.HighThresholdLabel.Text = "High Threshold:";
            // 
            // LowThresholdLabel
            // 
            this.LowThresholdLabel.AutoSize = true;
            this.LowThresholdLabel.Location = new System.Drawing.Point(26, 55);
            this.LowThresholdLabel.Name = "LowThresholdLabel";
            this.LowThresholdLabel.Size = new System.Drawing.Size(80, 13);
            this.LowThresholdLabel.TabIndex = 2;
            this.LowThresholdLabel.Text = "Low Threshold:";
            // 
            // LceFactorNumericUpDown
            // 
            this.LceFactorNumericUpDown.Location = new System.Drawing.Point(122, 103);
            this.LceFactorNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LceFactorNumericUpDown.Name = "LceFactorNumericUpDown";
            this.LceFactorNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.LceFactorNumericUpDown.TabIndex = 11;
            this.LceFactorNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EccentricityNumericUpDown
            // 
            this.EccentricityNumericUpDown.Location = new System.Drawing.Point(244, 103);
            this.EccentricityNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.EccentricityNumericUpDown.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.EccentricityNumericUpDown.Name = "EccentricityNumericUpDown";
            this.EccentricityNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.EccentricityNumericUpDown.TabIndex = 13;
            // 
            // GridPitchNumericUpDown
            // 
            this.GridPitchNumericUpDown.Location = new System.Drawing.Point(244, 77);
            this.GridPitchNumericUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.GridPitchNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GridPitchNumericUpDown.Name = "GridPitchNumericUpDown";
            this.GridPitchNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.GridPitchNumericUpDown.TabIndex = 9;
            this.GridPitchNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GridAngleNumericUpDown
            // 
            this.GridAngleNumericUpDown.Location = new System.Drawing.Point(244, 51);
            this.GridAngleNumericUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.GridAngleNumericUpDown.Name = "GridAngleNumericUpDown";
            this.GridAngleNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.GridAngleNumericUpDown.TabIndex = 5;
            // 
            // HighThresholdNumericUpDown
            // 
            this.HighThresholdNumericUpDown.Location = new System.Drawing.Point(122, 77);
            this.HighThresholdNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.HighThresholdNumericUpDown.Name = "HighThresholdNumericUpDown";
            this.HighThresholdNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.HighThresholdNumericUpDown.TabIndex = 7;
            this.HighThresholdNumericUpDown.ValueChanged += new System.EventHandler(this.HighThresholdNumericUpDown_ValueChanged);
            // 
            // LowThresholdNumericUpDown
            // 
            this.LowThresholdNumericUpDown.Location = new System.Drawing.Point(122, 51);
            this.LowThresholdNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LowThresholdNumericUpDown.Name = "LowThresholdNumericUpDown";
            this.LowThresholdNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.LowThresholdNumericUpDown.TabIndex = 3;
            this.LowThresholdNumericUpDown.ValueChanged += new System.EventHandler(this.LowThresholdNumericUpDown_ValueChanged);
            // 
            // BinarizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 631);
            this.Controls.Add(this.BinarizeGroupBox);
            this.Name = "BinarizeForm";
            this.Text = "Binarize";
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.BinarizeGroupBox, 0);
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.BinarizeGroupBox.ResumeLayout(false);
            this.BinarizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LceFactorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EccentricityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPitchNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAngleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowThresholdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BinarizeGroupBox;
        private System.Windows.Forms.Label LceFactorLabel;
        private System.Windows.Forms.Label EccentricityLabel;
        private System.Windows.Forms.Label GridPitchLabel;
        private System.Windows.Forms.Label GridAngleLabel;
        private System.Windows.Forms.Label HighThresholdLabel;
        private System.Windows.Forms.Label LowThresholdLabel;
        private System.Windows.Forms.NumericUpDown LceFactorNumericUpDown;
        private System.Windows.Forms.NumericUpDown EccentricityNumericUpDown;
        private System.Windows.Forms.NumericUpDown GridPitchNumericUpDown;
        private System.Windows.Forms.NumericUpDown GridAngleNumericUpDown;
        private System.Windows.Forms.NumericUpDown HighThresholdNumericUpDown;
        private System.Windows.Forms.NumericUpDown LowThresholdNumericUpDown;
        private System.Windows.Forms.Label BlurLabel;
        private System.Windows.Forms.ComboBox BlurComboBox;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.ComboBox ModeComboBox;
    }
}