namespace ImagXpressDemo
{
    partial class DoubleIntensityAndSelectionForm
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
            this.DoubleIntensityAndSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectionComboBox = new System.Windows.Forms.ComboBox();
            this.IntensityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Intensity2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Intensity2Label = new System.Windows.Forms.Label();
            this.IntensityLabel = new System.Windows.Forms.Label();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.ResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.CountOfSpecksFoundValueLabel = new System.Windows.Forms.Label();
            this.ImageWasModifiedLabel = new System.Windows.Forms.Label();
            this.ImageWasModifiedValueLabel = new System.Windows.Forms.Label();
            this.CountOfSpecksFoundLabel = new System.Windows.Forms.Label();
            this.DoubleIntensityAndSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intensity2NumericUpDown)).BeginInit();
            this.ResultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(371, 559);
            this.PreviewButton.TabIndex = 6;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(11, 559);
            this.OKButton.TabIndex = 5;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(651, 559);
            this.CancelProcessingButton.TabIndex = 7;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.TabIndex = 0;
            // 
            // DoubleIntensityAndSelectionGroupBox
            // 
            this.DoubleIntensityAndSelectionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DoubleIntensityAndSelectionGroupBox.Controls.Add(this.SelectionComboBox);
            this.DoubleIntensityAndSelectionGroupBox.Controls.Add(this.IntensityNumericUpDown);
            this.DoubleIntensityAndSelectionGroupBox.Controls.Add(this.Intensity2NumericUpDown);
            this.DoubleIntensityAndSelectionGroupBox.Controls.Add(this.Intensity2Label);
            this.DoubleIntensityAndSelectionGroupBox.Controls.Add(this.IntensityLabel);
            this.DoubleIntensityAndSelectionGroupBox.Controls.Add(this.SelectionLabel);
            this.DoubleIntensityAndSelectionGroupBox.Location = new System.Drawing.Point(13, 433);
            this.DoubleIntensityAndSelectionGroupBox.Name = "DoubleIntensityAndSelectionGroupBox";
            this.DoubleIntensityAndSelectionGroupBox.Size = new System.Drawing.Size(191, 113);
            this.DoubleIntensityAndSelectionGroupBox.TabIndex = 3;
            this.DoubleIntensityAndSelectionGroupBox.TabStop = false;
            // 
            // SelectionComboBox
            // 
            this.SelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectionComboBox.FormattingEnabled = true;
            this.SelectionComboBox.Location = new System.Drawing.Point(92, 18);
            this.SelectionComboBox.Name = "SelectionComboBox";
            this.SelectionComboBox.Size = new System.Drawing.Size(76, 21);
            this.SelectionComboBox.TabIndex = 1;
            // 
            // IntensityNumericUpDown
            // 
            this.IntensityNumericUpDown.Location = new System.Drawing.Point(92, 49);
            this.IntensityNumericUpDown.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.IntensityNumericUpDown.Name = "IntensityNumericUpDown";
            this.IntensityNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.IntensityNumericUpDown.TabIndex = 3;
            // 
            // Intensity2NumericUpDown
            // 
            this.Intensity2NumericUpDown.Location = new System.Drawing.Point(92, 80);
            this.Intensity2NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Intensity2NumericUpDown.Name = "Intensity2NumericUpDown";
            this.Intensity2NumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.Intensity2NumericUpDown.TabIndex = 5;
            this.Intensity2NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Intensity2Label
            // 
            this.Intensity2Label.AutoSize = true;
            this.Intensity2Label.Location = new System.Drawing.Point(19, 84);
            this.Intensity2Label.Name = "Intensity2Label";
            this.Intensity2Label.Size = new System.Drawing.Size(49, 13);
            this.Intensity2Label.TabIndex = 4;
            this.Intensity2Label.Text = "Intensity:";
            // 
            // IntensityLabel
            // 
            this.IntensityLabel.AutoSize = true;
            this.IntensityLabel.Location = new System.Drawing.Point(19, 53);
            this.IntensityLabel.Name = "IntensityLabel";
            this.IntensityLabel.Size = new System.Drawing.Size(49, 13);
            this.IntensityLabel.TabIndex = 2;
            this.IntensityLabel.Text = "Intensity:";
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Location = new System.Drawing.Point(19, 22);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(54, 13);
            this.SelectionLabel.TabIndex = 0;
            this.SelectionLabel.Text = "Selection:";
            // 
            // ResultsGroupBox
            // 
            this.ResultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultsGroupBox.Controls.Add(this.CountOfSpecksFoundValueLabel);
            this.ResultsGroupBox.Controls.Add(this.ImageWasModifiedLabel);
            this.ResultsGroupBox.Controls.Add(this.ImageWasModifiedValueLabel);
            this.ResultsGroupBox.Controls.Add(this.CountOfSpecksFoundLabel);
            this.ResultsGroupBox.Location = new System.Drawing.Point(219, 433);
            this.ResultsGroupBox.Name = "ResultsGroupBox";
            this.ResultsGroupBox.Size = new System.Drawing.Size(163, 85);
            this.ResultsGroupBox.TabIndex = 4;
            this.ResultsGroupBox.TabStop = false;
            this.ResultsGroupBox.Text = "Results";
            this.ResultsGroupBox.Visible = false;
            // 
            // CountOfSpecksFoundValueLabel
            // 
            this.CountOfSpecksFoundValueLabel.AutoSize = true;
            this.CountOfSpecksFoundValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CountOfSpecksFoundValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountOfSpecksFoundValueLabel.Location = new System.Drawing.Point(133, 55);
            this.CountOfSpecksFoundValueLabel.Name = "CountOfSpecksFoundValueLabel";
            this.CountOfSpecksFoundValueLabel.Size = new System.Drawing.Size(2, 15);
            this.CountOfSpecksFoundValueLabel.TabIndex = 3;
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
            this.ImageWasModifiedValueLabel.Location = new System.Drawing.Point(134, 22);
            this.ImageWasModifiedValueLabel.Name = "ImageWasModifiedValueLabel";
            this.ImageWasModifiedValueLabel.Size = new System.Drawing.Size(2, 15);
            this.ImageWasModifiedValueLabel.TabIndex = 1;
            // 
            // CountOfSpecksFoundLabel
            // 
            this.CountOfSpecksFoundLabel.AutoSize = true;
            this.CountOfSpecksFoundLabel.Location = new System.Drawing.Point(6, 55);
            this.CountOfSpecksFoundLabel.Name = "CountOfSpecksFoundLabel";
            this.CountOfSpecksFoundLabel.Size = new System.Drawing.Size(122, 13);
            this.CountOfSpecksFoundLabel.TabIndex = 2;
            this.CountOfSpecksFoundLabel.Text = "Count of Specks Found:";
            // 
            // DoubleIntensityAndSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 594);
            this.Controls.Add(this.ResultsGroupBox);
            this.Controls.Add(this.DoubleIntensityAndSelectionGroupBox);
            this.Name = "DoubleIntensityAndSelectionForm";
            this.Text = "";
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.Controls.SetChildIndex(this.DoubleIntensityAndSelectionGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.ResultsGroupBox, 0);
            this.DoubleIntensityAndSelectionGroupBox.ResumeLayout(false);
            this.DoubleIntensityAndSelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intensity2NumericUpDown)).EndInit();
            this.ResultsGroupBox.ResumeLayout(false);
            this.ResultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DoubleIntensityAndSelectionGroupBox;
        private System.Windows.Forms.ComboBox SelectionComboBox;
        private System.Windows.Forms.NumericUpDown IntensityNumericUpDown;
        private System.Windows.Forms.NumericUpDown Intensity2NumericUpDown;
        private System.Windows.Forms.Label Intensity2Label;
        private System.Windows.Forms.Label IntensityLabel;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.GroupBox ResultsGroupBox;
        private System.Windows.Forms.Label CountOfSpecksFoundValueLabel;
        private System.Windows.Forms.Label ImageWasModifiedLabel;
        private System.Windows.Forms.Label ImageWasModifiedValueLabel;
        private System.Windows.Forms.Label CountOfSpecksFoundLabel;
    }
}