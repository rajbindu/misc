namespace ImagXpressDemo
{
    partial class LineRemovalForm
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
            this.LineRemovalGroupBox = new System.Windows.Forms.GroupBox();
            this.MaximumCharacterRepairSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaximumGapNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinimumAspectRatioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaximumThicknessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinimumLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaximumCharacterRepairSizeLabel = new System.Windows.Forms.Label();
            this.MinimumAspectRatioLabel = new System.Windows.Forms.Label();
            this.MaximumGapLabel = new System.Windows.Forms.Label();
            this.MaximumThicknessLabel = new System.Windows.Forms.Label();
            this.MinimumLengthLabel = new System.Windows.Forms.Label();
            this.ResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.CountOfLinesFoundValueLabel = new System.Windows.Forms.Label();
            this.ImageWasModifiedLabel = new System.Windows.Forms.Label();
            this.ImageWasModifiedValueLabel = new System.Windows.Forms.Label();
            this.CountOfLinesFoundLabel = new System.Windows.Forms.Label();
            this.LineRemovalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumCharacterRepairSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumGapNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumAspectRatioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumThicknessNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumLengthNumericUpDown)).BeginInit();
            this.ResultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(372, 637);
            this.PreviewButton.TabIndex = 5;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 637);
            this.OKButton.TabIndex = 4;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(652, 637);
            this.CancelProcessingButton.TabIndex = 6;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.TabIndex = 7;
            // 
            // LineRemovalGroupBox
            // 
            this.LineRemovalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LineRemovalGroupBox.Controls.Add(this.MaximumCharacterRepairSizeNumericUpDown);
            this.LineRemovalGroupBox.Controls.Add(this.MaximumGapNumericUpDown);
            this.LineRemovalGroupBox.Controls.Add(this.MinimumAspectRatioNumericUpDown);
            this.LineRemovalGroupBox.Controls.Add(this.MaximumThicknessNumericUpDown);
            this.LineRemovalGroupBox.Controls.Add(this.MinimumLengthNumericUpDown);
            this.LineRemovalGroupBox.Controls.Add(this.MaximumCharacterRepairSizeLabel);
            this.LineRemovalGroupBox.Controls.Add(this.MinimumAspectRatioLabel);
            this.LineRemovalGroupBox.Controls.Add(this.MaximumGapLabel);
            this.LineRemovalGroupBox.Controls.Add(this.MaximumThicknessLabel);
            this.LineRemovalGroupBox.Controls.Add(this.MinimumLengthLabel);
            this.LineRemovalGroupBox.Location = new System.Drawing.Point(12, 433);
            this.LineRemovalGroupBox.Name = "LineRemovalGroupBox";
            this.LineRemovalGroupBox.Size = new System.Drawing.Size(276, 186);
            this.LineRemovalGroupBox.TabIndex = 2;
            this.LineRemovalGroupBox.TabStop = false;
            this.LineRemovalGroupBox.Text = "Line Removal";
            // 
            // MaximumCharacterRepairSizeNumericUpDown
            // 
            this.MaximumCharacterRepairSizeNumericUpDown.Location = new System.Drawing.Point(191, 155);
            this.MaximumCharacterRepairSizeNumericUpDown.Name = "MaximumCharacterRepairSizeNumericUpDown";
            this.MaximumCharacterRepairSizeNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.MaximumCharacterRepairSizeNumericUpDown.TabIndex = 9;
            this.MaximumCharacterRepairSizeNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // MaximumGapNumericUpDown
            // 
            this.MaximumGapNumericUpDown.Location = new System.Drawing.Point(191, 122);
            this.MaximumGapNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.MaximumGapNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaximumGapNumericUpDown.Name = "MaximumGapNumericUpDown";
            this.MaximumGapNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.MaximumGapNumericUpDown.TabIndex = 7;
            this.MaximumGapNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MinimumAspectRatioNumericUpDown
            // 
            this.MinimumAspectRatioNumericUpDown.Location = new System.Drawing.Point(191, 89);
            this.MinimumAspectRatioNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MinimumAspectRatioNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinimumAspectRatioNumericUpDown.Name = "MinimumAspectRatioNumericUpDown";
            this.MinimumAspectRatioNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.MinimumAspectRatioNumericUpDown.TabIndex = 5;
            this.MinimumAspectRatioNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // MaximumThicknessNumericUpDown
            // 
            this.MaximumThicknessNumericUpDown.Location = new System.Drawing.Point(191, 56);
            this.MaximumThicknessNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MaximumThicknessNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaximumThicknessNumericUpDown.Name = "MaximumThicknessNumericUpDown";
            this.MaximumThicknessNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.MaximumThicknessNumericUpDown.TabIndex = 3;
            this.MaximumThicknessNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // MinimumLengthNumericUpDown
            // 
            this.MinimumLengthNumericUpDown.Location = new System.Drawing.Point(191, 23);
            this.MinimumLengthNumericUpDown.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.MinimumLengthNumericUpDown.Minimum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.MinimumLengthNumericUpDown.Name = "MinimumLengthNumericUpDown";
            this.MinimumLengthNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.MinimumLengthNumericUpDown.TabIndex = 1;
            this.MinimumLengthNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // MaximumCharacterRepairSizeLabel
            // 
            this.MaximumCharacterRepairSizeLabel.AutoSize = true;
            this.MaximumCharacterRepairSizeLabel.Location = new System.Drawing.Point(19, 159);
            this.MaximumCharacterRepairSizeLabel.Name = "MaximumCharacterRepairSizeLabel";
            this.MaximumCharacterRepairSizeLabel.Size = new System.Drawing.Size(160, 13);
            this.MaximumCharacterRepairSizeLabel.TabIndex = 8;
            this.MaximumCharacterRepairSizeLabel.Text = "Maximum Character Repair Size:";
            // 
            // MinimumAspectRatioLabel
            // 
            this.MinimumAspectRatioLabel.AutoSize = true;
            this.MinimumAspectRatioLabel.Location = new System.Drawing.Point(19, 93);
            this.MinimumAspectRatioLabel.Name = "MinimumAspectRatioLabel";
            this.MinimumAspectRatioLabel.Size = new System.Drawing.Size(115, 13);
            this.MinimumAspectRatioLabel.TabIndex = 4;
            this.MinimumAspectRatioLabel.Text = "Minimum Apsect Ratio:";
            // 
            // MaximumGapLabel
            // 
            this.MaximumGapLabel.AutoSize = true;
            this.MaximumGapLabel.Location = new System.Drawing.Point(19, 126);
            this.MaximumGapLabel.Name = "MaximumGapLabel";
            this.MaximumGapLabel.Size = new System.Drawing.Size(77, 13);
            this.MaximumGapLabel.TabIndex = 6;
            this.MaximumGapLabel.Text = "Maximum Gap:";
            // 
            // MaximumThicknessLabel
            // 
            this.MaximumThicknessLabel.AutoSize = true;
            this.MaximumThicknessLabel.Location = new System.Drawing.Point(19, 60);
            this.MaximumThicknessLabel.Name = "MaximumThicknessLabel";
            this.MaximumThicknessLabel.Size = new System.Drawing.Size(106, 13);
            this.MaximumThicknessLabel.TabIndex = 2;
            this.MaximumThicknessLabel.Text = "Maximum Thickness:";
            // 
            // MinimumLengthLabel
            // 
            this.MinimumLengthLabel.AutoSize = true;
            this.MinimumLengthLabel.Location = new System.Drawing.Point(19, 27);
            this.MinimumLengthLabel.Name = "MinimumLengthLabel";
            this.MinimumLengthLabel.Size = new System.Drawing.Size(87, 13);
            this.MinimumLengthLabel.TabIndex = 0;
            this.MinimumLengthLabel.Text = "Minimum Length:";
            // 
            // ResultsGroupBox
            // 
            this.ResultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultsGroupBox.Controls.Add(this.CountOfLinesFoundValueLabel);
            this.ResultsGroupBox.Controls.Add(this.ImageWasModifiedLabel);
            this.ResultsGroupBox.Controls.Add(this.ImageWasModifiedValueLabel);
            this.ResultsGroupBox.Controls.Add(this.CountOfLinesFoundLabel);
            this.ResultsGroupBox.Location = new System.Drawing.Point(294, 534);
            this.ResultsGroupBox.Name = "ResultsGroupBox";
            this.ResultsGroupBox.Size = new System.Drawing.Size(159, 85);
            this.ResultsGroupBox.TabIndex = 3;
            this.ResultsGroupBox.TabStop = false;
            this.ResultsGroupBox.Text = "Results";
            this.ResultsGroupBox.Visible = false;
            // 
            // CountOfLinesFoundValueLabel
            // 
            this.CountOfLinesFoundValueLabel.AutoSize = true;
            this.CountOfLinesFoundValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CountOfLinesFoundValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountOfLinesFoundValueLabel.Location = new System.Drawing.Point(124, 55);
            this.CountOfLinesFoundValueLabel.Name = "CountOfLinesFoundValueLabel";
            this.CountOfLinesFoundValueLabel.Size = new System.Drawing.Size(2, 15);
            this.CountOfLinesFoundValueLabel.TabIndex = 3;
            // 
            // ImageWasModifiedLabel
            // 
            this.ImageWasModifiedLabel.AutoSize = true;
            this.ImageWasModifiedLabel.Location = new System.Drawing.Point(6, 22);
            this.ImageWasModifiedLabel.Name = "ImageWasModifiedLabel";
            this.ImageWasModifiedLabel.Size = new System.Drawing.Size(104, 13);
            this.ImageWasModifiedLabel.TabIndex = 0;
            this.ImageWasModifiedLabel.Text = "Image was Modified:";
            // 
            // ImageWasModifiedValueLabel
            // 
            this.ImageWasModifiedValueLabel.AutoSize = true;
            this.ImageWasModifiedValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImageWasModifiedValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageWasModifiedValueLabel.Location = new System.Drawing.Point(125, 22);
            this.ImageWasModifiedValueLabel.Name = "ImageWasModifiedValueLabel";
            this.ImageWasModifiedValueLabel.Size = new System.Drawing.Size(2, 15);
            this.ImageWasModifiedValueLabel.TabIndex = 1;
            // 
            // CountOfLinesFoundLabel
            // 
            this.CountOfLinesFoundLabel.AutoSize = true;
            this.CountOfLinesFoundLabel.Location = new System.Drawing.Point(6, 55);
            this.CountOfLinesFoundLabel.Name = "CountOfLinesFoundLabel";
            this.CountOfLinesFoundLabel.Size = new System.Drawing.Size(111, 13);
            this.CountOfLinesFoundLabel.TabIndex = 2;
            this.CountOfLinesFoundLabel.Text = "Count of Lines Found:";
            // 
            // LineRemovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 672);
            this.Controls.Add(this.ResultsGroupBox);
            this.Controls.Add(this.LineRemovalGroupBox);
            this.Name = "LineRemovalForm";
            this.Text = "Line Removal";
            this.Controls.SetChildIndex(this.LineRemovalGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.Controls.SetChildIndex(this.ResultsGroupBox, 0);
            this.LineRemovalGroupBox.ResumeLayout(false);
            this.LineRemovalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumCharacterRepairSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumGapNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumAspectRatioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumThicknessNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumLengthNumericUpDown)).EndInit();
            this.ResultsGroupBox.ResumeLayout(false);
            this.ResultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LineRemovalGroupBox;
        private System.Windows.Forms.Label MaximumThicknessLabel;
        private System.Windows.Forms.Label MinimumLengthLabel;
        private System.Windows.Forms.NumericUpDown MaximumCharacterRepairSizeNumericUpDown;
        private System.Windows.Forms.NumericUpDown MaximumGapNumericUpDown;
        private System.Windows.Forms.NumericUpDown MinimumAspectRatioNumericUpDown;
        private System.Windows.Forms.NumericUpDown MaximumThicknessNumericUpDown;
        private System.Windows.Forms.NumericUpDown MinimumLengthNumericUpDown;
        private System.Windows.Forms.Label MaximumCharacterRepairSizeLabel;
        private System.Windows.Forms.Label MinimumAspectRatioLabel;
        private System.Windows.Forms.Label MaximumGapLabel;
        private System.Windows.Forms.GroupBox ResultsGroupBox;
        private System.Windows.Forms.Label CountOfLinesFoundValueLabel;
        private System.Windows.Forms.Label ImageWasModifiedLabel;
        private System.Windows.Forms.Label ImageWasModifiedValueLabel;
        private System.Windows.Forms.Label CountOfLinesFoundLabel;
    }
}