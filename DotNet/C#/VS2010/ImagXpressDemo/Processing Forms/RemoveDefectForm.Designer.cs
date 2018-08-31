namespace ImagXpressDemo
{
    partial class RemoveDefectForm
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
            if (imageXView1 != null)
            {
                this.imageXView1.MouseDown -= imageXView1_MouseDown;
                this.imageXView1.MouseMove -= imageXView1_MouseMove;
                this.imageXView1.MouseUp -= imageXView1_MouseUp;
            }
            if (notateXpress != null)
            {
                notateXpress.AnnotationAdded -= annotationAdded;
                notateXpress.ClientDisconnect();

                notateXpress.Dispose();
                notateXpress = null;
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
            this.RemoveDefectGroupBox = new System.Windows.Forms.GroupBox();
            this.EndingPointYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EndingPointYLabel = new System.Windows.Forms.Label();
            this.EndingPointXLabel = new System.Windows.Forms.Label();
            this.EndingPointXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EndingPointLabel = new System.Windows.Forms.Label();
            this.StartingPointYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StartingPointYLabel = new System.Windows.Forms.Label();
            this.StartingPointXLabel = new System.Windows.Forms.Label();
            this.StartingPointXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StartingPointLabel = new System.Windows.Forms.Label();
            this.ThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DefectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SmoothingAdjustmentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FilterAdjustmentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LineWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DefectTypeLabel = new System.Windows.Forms.Label();
            this.SmoothingAdjustmentLabel = new System.Windows.Forms.Label();
            this.FilterAdjustmentLabel = new System.Windows.Forms.Label();
            this.ThresholdLabel = new System.Windows.Forms.Label();
            this.LineWidthLabel = new System.Windows.Forms.Label();
            this.MouseLabel = new System.Windows.Forms.Label();
            this.RemoveDefectGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndingPointYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndingPointXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingPointYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingPointXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothingAdjustmentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterAdjustmentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineWidthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(373, 637);
            this.PreviewButton.TabIndex = 6;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(13, 637);
            this.OKButton.TabIndex = 5;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(653, 637);
            this.CancelProcessingButton.TabIndex = 7;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.TabIndex = 0;
            // 
            // RemoveDefectGroupBox
            // 
            this.RemoveDefectGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveDefectGroupBox.Controls.Add(this.EndingPointYNumericUpDown);
            this.RemoveDefectGroupBox.Controls.Add(this.EndingPointYLabel);
            this.RemoveDefectGroupBox.Controls.Add(this.EndingPointXLabel);
            this.RemoveDefectGroupBox.Controls.Add(this.EndingPointXNumericUpDown);
            this.RemoveDefectGroupBox.Controls.Add(this.EndingPointLabel);
            this.RemoveDefectGroupBox.Controls.Add(this.StartingPointYNumericUpDown);
            this.RemoveDefectGroupBox.Controls.Add(this.StartingPointYLabel);
            this.RemoveDefectGroupBox.Controls.Add(this.StartingPointXLabel);
            this.RemoveDefectGroupBox.Controls.Add(this.StartingPointXNumericUpDown);
            this.RemoveDefectGroupBox.Controls.Add(this.StartingPointLabel);
            this.RemoveDefectGroupBox.Controls.Add(this.ThresholdNumericUpDown);
            this.RemoveDefectGroupBox.Controls.Add(this.DefectTypeComboBox);
            this.RemoveDefectGroupBox.Controls.Add(this.SmoothingAdjustmentNumericUpDown);
            this.RemoveDefectGroupBox.Controls.Add(this.FilterAdjustmentNumericUpDown);
            this.RemoveDefectGroupBox.Controls.Add(this.LineWidthNumericUpDown);
            this.RemoveDefectGroupBox.Controls.Add(this.DefectTypeLabel);
            this.RemoveDefectGroupBox.Controls.Add(this.SmoothingAdjustmentLabel);
            this.RemoveDefectGroupBox.Controls.Add(this.FilterAdjustmentLabel);
            this.RemoveDefectGroupBox.Controls.Add(this.ThresholdLabel);
            this.RemoveDefectGroupBox.Controls.Add(this.LineWidthLabel);
            this.RemoveDefectGroupBox.Location = new System.Drawing.Point(171, 433);
            this.RemoveDefectGroupBox.Name = "RemoveDefectGroupBox";
            this.RemoveDefectGroupBox.Size = new System.Drawing.Size(530, 198);
            this.RemoveDefectGroupBox.TabIndex = 4;
            this.RemoveDefectGroupBox.TabStop = false;
            // 
            // EndingPointYNumericUpDown
            // 
            this.EndingPointYNumericUpDown.Location = new System.Drawing.Point(474, 45);
            this.EndingPointYNumericUpDown.Name = "EndingPointYNumericUpDown";
            this.EndingPointYNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.EndingPointYNumericUpDown.TabIndex = 9;
            this.EndingPointYNumericUpDown.ValueChanged += new System.EventHandler(this.EndingPointYNumericUpDown_ValueChanged);
            // 
            // EndingPointYLabel
            // 
            this.EndingPointYLabel.AutoSize = true;
            this.EndingPointYLabel.Location = new System.Drawing.Point(451, 49);
            this.EndingPointYLabel.Name = "EndingPointYLabel";
            this.EndingPointYLabel.Size = new System.Drawing.Size(17, 13);
            this.EndingPointYLabel.TabIndex = 8;
            this.EndingPointYLabel.Text = "Y:";
            // 
            // EndingPointXLabel
            // 
            this.EndingPointXLabel.AutoSize = true;
            this.EndingPointXLabel.Location = new System.Drawing.Point(351, 49);
            this.EndingPointXLabel.Name = "EndingPointXLabel";
            this.EndingPointXLabel.Size = new System.Drawing.Size(17, 13);
            this.EndingPointXLabel.TabIndex = 6;
            this.EndingPointXLabel.Text = "X:";
            // 
            // EndingPointXNumericUpDown
            // 
            this.EndingPointXNumericUpDown.Location = new System.Drawing.Point(385, 45);
            this.EndingPointXNumericUpDown.Name = "EndingPointXNumericUpDown";
            this.EndingPointXNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.EndingPointXNumericUpDown.TabIndex = 7;
            this.EndingPointXNumericUpDown.ValueChanged += new System.EventHandler(this.EndingPointXNumericUpDown_ValueChanged);
            // 
            // EndingPointLabel
            // 
            this.EndingPointLabel.AutoSize = true;
            this.EndingPointLabel.Location = new System.Drawing.Point(262, 49);
            this.EndingPointLabel.Name = "EndingPointLabel";
            this.EndingPointLabel.Size = new System.Drawing.Size(70, 13);
            this.EndingPointLabel.TabIndex = 5;
            this.EndingPointLabel.Text = "Ending Point:";
            // 
            // StartingPointYNumericUpDown
            // 
            this.StartingPointYNumericUpDown.Location = new System.Drawing.Point(474, 18);
            this.StartingPointYNumericUpDown.Name = "StartingPointYNumericUpDown";
            this.StartingPointYNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.StartingPointYNumericUpDown.TabIndex = 4;
            this.StartingPointYNumericUpDown.ValueChanged += new System.EventHandler(this.StartingPointYNumericUpDown_ValueChanged);
            // 
            // StartingPointYLabel
            // 
            this.StartingPointYLabel.AutoSize = true;
            this.StartingPointYLabel.Location = new System.Drawing.Point(451, 22);
            this.StartingPointYLabel.Name = "StartingPointYLabel";
            this.StartingPointYLabel.Size = new System.Drawing.Size(17, 13);
            this.StartingPointYLabel.TabIndex = 3;
            this.StartingPointYLabel.Text = "Y:";
            // 
            // StartingPointXLabel
            // 
            this.StartingPointXLabel.AutoSize = true;
            this.StartingPointXLabel.Location = new System.Drawing.Point(351, 22);
            this.StartingPointXLabel.Name = "StartingPointXLabel";
            this.StartingPointXLabel.Size = new System.Drawing.Size(17, 13);
            this.StartingPointXLabel.TabIndex = 1;
            this.StartingPointXLabel.Text = "X:";
            // 
            // StartingPointXNumericUpDown
            // 
            this.StartingPointXNumericUpDown.Location = new System.Drawing.Point(385, 18);
            this.StartingPointXNumericUpDown.Name = "StartingPointXNumericUpDown";
            this.StartingPointXNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.StartingPointXNumericUpDown.TabIndex = 2;
            this.StartingPointXNumericUpDown.ValueChanged += new System.EventHandler(this.StartingPointXNumericUpDown_ValueChanged);
            // 
            // StartingPointLabel
            // 
            this.StartingPointLabel.AutoSize = true;
            this.StartingPointLabel.Location = new System.Drawing.Point(262, 22);
            this.StartingPointLabel.Name = "StartingPointLabel";
            this.StartingPointLabel.Size = new System.Drawing.Size(73, 13);
            this.StartingPointLabel.TabIndex = 0;
            this.StartingPointLabel.Text = "Starting Point:";
            // 
            // ThresholdNumericUpDown
            // 
            this.ThresholdNumericUpDown.Location = new System.Drawing.Point(140, 96);
            this.ThresholdNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ThresholdNumericUpDown.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.ThresholdNumericUpDown.Name = "ThresholdNumericUpDown";
            this.ThresholdNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.ThresholdNumericUpDown.TabIndex = 13;
            // 
            // DefectTypeComboBox
            // 
            this.DefectTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DefectTypeComboBox.FormattingEnabled = true;
            this.DefectTypeComboBox.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.DefectTypeComboBox.Location = new System.Drawing.Point(140, 168);
            this.DefectTypeComboBox.Name = "DefectTypeComboBox";
            this.DefectTypeComboBox.Size = new System.Drawing.Size(97, 21);
            this.DefectTypeComboBox.TabIndex = 19;
            // 
            // SmoothingAdjustmentNumericUpDown
            // 
            this.SmoothingAdjustmentNumericUpDown.Location = new System.Drawing.Point(140, 144);
            this.SmoothingAdjustmentNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.SmoothingAdjustmentNumericUpDown.Name = "SmoothingAdjustmentNumericUpDown";
            this.SmoothingAdjustmentNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.SmoothingAdjustmentNumericUpDown.TabIndex = 17;
            // 
            // FilterAdjustmentNumericUpDown
            // 
            this.FilterAdjustmentNumericUpDown.Location = new System.Drawing.Point(140, 120);
            this.FilterAdjustmentNumericUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.FilterAdjustmentNumericUpDown.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            -2147483648});
            this.FilterAdjustmentNumericUpDown.Name = "FilterAdjustmentNumericUpDown";
            this.FilterAdjustmentNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.FilterAdjustmentNumericUpDown.TabIndex = 15;
            // 
            // LineWidthNumericUpDown
            // 
            this.LineWidthNumericUpDown.Location = new System.Drawing.Point(385, 72);
            this.LineWidthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LineWidthNumericUpDown.Name = "LineWidthNumericUpDown";
            this.LineWidthNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.LineWidthNumericUpDown.TabIndex = 11;
            this.LineWidthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LineWidthNumericUpDown.ValueChanged += new System.EventHandler(this.LineWidthNumericUpDown_ValueChanged);
            // 
            // DefectTypeLabel
            // 
            this.DefectTypeLabel.AutoSize = true;
            this.DefectTypeLabel.Location = new System.Drawing.Point(17, 172);
            this.DefectTypeLabel.Name = "DefectTypeLabel";
            this.DefectTypeLabel.Size = new System.Drawing.Size(34, 13);
            this.DefectTypeLabel.TabIndex = 18;
            this.DefectTypeLabel.Text = "Type:";
            // 
            // SmoothingAdjustmentLabel
            // 
            this.SmoothingAdjustmentLabel.AutoSize = true;
            this.SmoothingAdjustmentLabel.Location = new System.Drawing.Point(17, 148);
            this.SmoothingAdjustmentLabel.Name = "SmoothingAdjustmentLabel";
            this.SmoothingAdjustmentLabel.Size = new System.Drawing.Size(115, 13);
            this.SmoothingAdjustmentLabel.TabIndex = 16;
            this.SmoothingAdjustmentLabel.Text = "Smoothing Adjustment:";
            // 
            // FilterAdjustmentLabel
            // 
            this.FilterAdjustmentLabel.AutoSize = true;
            this.FilterAdjustmentLabel.Location = new System.Drawing.Point(17, 124);
            this.FilterAdjustmentLabel.Name = "FilterAdjustmentLabel";
            this.FilterAdjustmentLabel.Size = new System.Drawing.Size(87, 13);
            this.FilterAdjustmentLabel.TabIndex = 14;
            this.FilterAdjustmentLabel.Text = "Filter Adjustment:";
            // 
            // ThresholdLabel
            // 
            this.ThresholdLabel.AutoSize = true;
            this.ThresholdLabel.Location = new System.Drawing.Point(17, 100);
            this.ThresholdLabel.Name = "ThresholdLabel";
            this.ThresholdLabel.Size = new System.Drawing.Size(57, 13);
            this.ThresholdLabel.TabIndex = 12;
            this.ThresholdLabel.Text = "Threshold:";
            // 
            // LineWidthLabel
            // 
            this.LineWidthLabel.AutoSize = true;
            this.LineWidthLabel.Location = new System.Drawing.Point(262, 76);
            this.LineWidthLabel.Name = "LineWidthLabel";
            this.LineWidthLabel.Size = new System.Drawing.Size(61, 13);
            this.LineWidthLabel.TabIndex = 10;
            this.LineWidthLabel.Text = "Line Width:";
            // 
            // MouseLabel
            // 
            this.MouseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MouseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MouseLabel.Location = new System.Drawing.Point(13, 440);
            this.MouseLabel.Name = "MouseLabel";
            this.MouseLabel.Size = new System.Drawing.Size(152, 55);
            this.MouseLabel.TabIndex = 2;
            // 
            // RemoveDefectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 665);
            this.Controls.Add(this.MouseLabel);
            this.Controls.Add(this.RemoveDefectGroupBox);
            this.Name = "RemoveDefectForm";
            this.Text = "";
            this.Load += new System.EventHandler(this.RemoveDefectForm_Load);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.Controls.SetChildIndex(this.RemoveDefectGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.MouseLabel, 0);
            this.RemoveDefectGroupBox.ResumeLayout(false);
            this.RemoveDefectGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndingPointYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndingPointXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingPointYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingPointXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothingAdjustmentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterAdjustmentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineWidthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RemoveDefectGroupBox;
        private System.Windows.Forms.NumericUpDown ThresholdNumericUpDown;
        private System.Windows.Forms.ComboBox DefectTypeComboBox;
        private System.Windows.Forms.NumericUpDown SmoothingAdjustmentNumericUpDown;
        private System.Windows.Forms.NumericUpDown FilterAdjustmentNumericUpDown;
        private System.Windows.Forms.NumericUpDown LineWidthNumericUpDown;
        private System.Windows.Forms.Label DefectTypeLabel;
        private System.Windows.Forms.Label SmoothingAdjustmentLabel;
        private System.Windows.Forms.Label FilterAdjustmentLabel;
        private System.Windows.Forms.Label ThresholdLabel;
        private System.Windows.Forms.Label LineWidthLabel;
        private System.Windows.Forms.NumericUpDown EndingPointYNumericUpDown;
        private System.Windows.Forms.Label EndingPointYLabel;
        private System.Windows.Forms.Label EndingPointXLabel;
        private System.Windows.Forms.NumericUpDown EndingPointXNumericUpDown;
        private System.Windows.Forms.Label EndingPointLabel;
        private System.Windows.Forms.NumericUpDown StartingPointYNumericUpDown;
        private System.Windows.Forms.Label StartingPointYLabel;
        private System.Windows.Forms.Label StartingPointXLabel;
        private System.Windows.Forms.NumericUpDown StartingPointXNumericUpDown;
        private System.Windows.Forms.Label StartingPointLabel;
        private System.Windows.Forms.Label MouseLabel;
    }
}