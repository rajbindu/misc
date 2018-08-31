namespace ImagXpressDemo
{
    partial class DeskewForm
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
            this.DeskewGroupBox = new System.Windows.Forms.GroupBox();
            this.PadColorComboBox = new System.Windows.Forms.ComboBox();
            this.QualityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinimumConfidenceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinimumAngleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.MaintainOriginalizSizeCheckBox = new System.Windows.Forms.CheckBox();
            this.QualityLabel = new System.Windows.Forms.Label();
            this.MinimumConfidenceLabel = new System.Windows.Forms.Label();
            this.MinimumAngleLabel = new System.Windows.Forms.Label();
            this.ResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.VariationValueLabel = new System.Windows.Forms.Label();
            this.VariationLabel = new System.Windows.Forms.Label();
            this.ConfidenceValueLabel = new System.Windows.Forms.Label();
            this.ConfidenceLabel = new System.Windows.Forms.Label();
            this.RotationAngleValueLabel = new System.Windows.Forms.Label();
            this.ImageWasModifiedLabel = new System.Windows.Forms.Label();
            this.ImageWasModifiedValueLabel = new System.Windows.Forms.Label();
            this.RotationAngleLabel = new System.Windows.Forms.Label();
            this.DeskewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QualityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumConfidenceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumAngleNumericUpDown)).BeginInit();
            this.ResultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(374, 607);
            this.PreviewButton.TabIndex = 5;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(14, 607);
            this.OKButton.TabIndex = 4;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(654, 607);
            this.CancelProcessingButton.TabIndex = 6;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.TabIndex = 7;
            // 
            // DeskewGroupBox
            // 
            this.DeskewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeskewGroupBox.Controls.Add(this.PadColorComboBox);
            this.DeskewGroupBox.Controls.Add(this.QualityNumericUpDown);
            this.DeskewGroupBox.Controls.Add(this.MinimumConfidenceNumericUpDown);
            this.DeskewGroupBox.Controls.Add(this.MinimumAngleNumericUpDown);
            this.DeskewGroupBox.Controls.Add(this.label4);
            this.DeskewGroupBox.Controls.Add(this.MaintainOriginalizSizeCheckBox);
            this.DeskewGroupBox.Controls.Add(this.QualityLabel);
            this.DeskewGroupBox.Controls.Add(this.MinimumConfidenceLabel);
            this.DeskewGroupBox.Controls.Add(this.MinimumAngleLabel);
            this.DeskewGroupBox.Location = new System.Drawing.Point(12, 433);
            this.DeskewGroupBox.Name = "DeskewGroupBox";
            this.DeskewGroupBox.Size = new System.Drawing.Size(268, 162);
            this.DeskewGroupBox.TabIndex = 2;
            this.DeskewGroupBox.TabStop = false;
            this.DeskewGroupBox.Text = "Deskew";
            // 
            // PadColorComboBox
            // 
            this.PadColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PadColorComboBox.FormattingEnabled = true;
            this.PadColorComboBox.Items.AddRange(new object[] {
            "Black",
            "White"});
            this.PadColorComboBox.Location = new System.Drawing.Point(132, 134);
            this.PadColorComboBox.Name = "PadColorComboBox";
            this.PadColorComboBox.Size = new System.Drawing.Size(120, 21);
            this.PadColorComboBox.TabIndex = 8;
            // 
            // QualityNumericUpDown
            // 
            this.QualityNumericUpDown.Location = new System.Drawing.Point(132, 76);
            this.QualityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QualityNumericUpDown.Name = "QualityNumericUpDown";
            this.QualityNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.QualityNumericUpDown.TabIndex = 5;
            this.QualityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MinimumConfidenceNumericUpDown
            // 
            this.MinimumConfidenceNumericUpDown.Location = new System.Drawing.Point(132, 44);
            this.MinimumConfidenceNumericUpDown.Name = "MinimumConfidenceNumericUpDown";
            this.MinimumConfidenceNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.MinimumConfidenceNumericUpDown.TabIndex = 3;
            // 
            // MinimumAngleNumericUpDown
            // 
            this.MinimumAngleNumericUpDown.Location = new System.Drawing.Point(132, 12);
            this.MinimumAngleNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MinimumAngleNumericUpDown.Name = "MinimumAngleNumericUpDown";
            this.MinimumAngleNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.MinimumAngleNumericUpDown.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pad Color:";
            // 
            // MaintainOriginalizSizeCheckBox
            // 
            this.MaintainOriginalizSizeCheckBox.AutoSize = true;
            this.MaintainOriginalizSizeCheckBox.Location = new System.Drawing.Point(132, 108);
            this.MaintainOriginalizSizeCheckBox.Name = "MaintainOriginalizSizeCheckBox";
            this.MaintainOriginalizSizeCheckBox.Size = new System.Drawing.Size(127, 17);
            this.MaintainOriginalizSizeCheckBox.TabIndex = 6;
            this.MaintainOriginalizSizeCheckBox.Text = "Maintain Original Size";
            this.MaintainOriginalizSizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // QualityLabel
            // 
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.Location = new System.Drawing.Point(21, 80);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(42, 13);
            this.QualityLabel.TabIndex = 4;
            this.QualityLabel.Text = "Quality:";
            // 
            // MinimumConfidenceLabel
            // 
            this.MinimumConfidenceLabel.AutoSize = true;
            this.MinimumConfidenceLabel.Location = new System.Drawing.Point(18, 48);
            this.MinimumConfidenceLabel.Name = "MinimumConfidenceLabel";
            this.MinimumConfidenceLabel.Size = new System.Drawing.Size(108, 13);
            this.MinimumConfidenceLabel.TabIndex = 2;
            this.MinimumConfidenceLabel.Text = "Minimum Confidence:";
            // 
            // MinimumAngleLabel
            // 
            this.MinimumAngleLabel.AutoSize = true;
            this.MinimumAngleLabel.Location = new System.Drawing.Point(18, 16);
            this.MinimumAngleLabel.Name = "MinimumAngleLabel";
            this.MinimumAngleLabel.Size = new System.Drawing.Size(81, 13);
            this.MinimumAngleLabel.TabIndex = 0;
            this.MinimumAngleLabel.Text = "Minimum Angle:";
            // 
            // ResultsGroupBox
            // 
            this.ResultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultsGroupBox.Controls.Add(this.VariationValueLabel);
            this.ResultsGroupBox.Controls.Add(this.VariationLabel);
            this.ResultsGroupBox.Controls.Add(this.ConfidenceValueLabel);
            this.ResultsGroupBox.Controls.Add(this.ConfidenceLabel);
            this.ResultsGroupBox.Controls.Add(this.RotationAngleValueLabel);
            this.ResultsGroupBox.Controls.Add(this.ImageWasModifiedLabel);
            this.ResultsGroupBox.Controls.Add(this.ImageWasModifiedValueLabel);
            this.ResultsGroupBox.Controls.Add(this.RotationAngleLabel);
            this.ResultsGroupBox.Location = new System.Drawing.Point(286, 476);
            this.ResultsGroupBox.Name = "ResultsGroupBox";
            this.ResultsGroupBox.Size = new System.Drawing.Size(159, 119);
            this.ResultsGroupBox.TabIndex = 3;
            this.ResultsGroupBox.TabStop = false;
            this.ResultsGroupBox.Text = "Results";
            this.ResultsGroupBox.Visible = false;
            // 
            // VariationValueLabel
            // 
            this.VariationValueLabel.AutoSize = true;
            this.VariationValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VariationValueLabel.Location = new System.Drawing.Point(116, 92);
            this.VariationValueLabel.Name = "VariationValueLabel";
            this.VariationValueLabel.Size = new System.Drawing.Size(2, 15);
            this.VariationValueLabel.TabIndex = 7;
            // 
            // VariationLabel
            // 
            this.VariationLabel.AutoSize = true;
            this.VariationLabel.Location = new System.Drawing.Point(6, 94);
            this.VariationLabel.Name = "VariationLabel";
            this.VariationLabel.Size = new System.Drawing.Size(51, 13);
            this.VariationLabel.TabIndex = 6;
            this.VariationLabel.Text = "Variation:";
            // 
            // ConfidenceValueLabel
            // 
            this.ConfidenceValueLabel.AutoSize = true;
            this.ConfidenceValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ConfidenceValueLabel.Location = new System.Drawing.Point(116, 70);
            this.ConfidenceValueLabel.Name = "ConfidenceValueLabel";
            this.ConfidenceValueLabel.Size = new System.Drawing.Size(2, 15);
            this.ConfidenceValueLabel.TabIndex = 5;
            // 
            // ConfidenceLabel
            // 
            this.ConfidenceLabel.AutoSize = true;
            this.ConfidenceLabel.Location = new System.Drawing.Point(6, 70);
            this.ConfidenceLabel.Name = "ConfidenceLabel";
            this.ConfidenceLabel.Size = new System.Drawing.Size(64, 13);
            this.ConfidenceLabel.TabIndex = 4;
            this.ConfidenceLabel.Text = "Confidence:";
            // 
            // RotationAngleValueLabel
            // 
            this.RotationAngleValueLabel.AutoSize = true;
            this.RotationAngleValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RotationAngleValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotationAngleValueLabel.Location = new System.Drawing.Point(116, 46);
            this.RotationAngleValueLabel.Name = "RotationAngleValueLabel";
            this.RotationAngleValueLabel.Size = new System.Drawing.Size(2, 15);
            this.RotationAngleValueLabel.TabIndex = 3;
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
            this.ImageWasModifiedValueLabel.Location = new System.Drawing.Point(116, 22);
            this.ImageWasModifiedValueLabel.Name = "ImageWasModifiedValueLabel";
            this.ImageWasModifiedValueLabel.Size = new System.Drawing.Size(2, 15);
            this.ImageWasModifiedValueLabel.TabIndex = 1;
            // 
            // RotationAngleLabel
            // 
            this.RotationAngleLabel.AutoSize = true;
            this.RotationAngleLabel.Location = new System.Drawing.Point(6, 46);
            this.RotationAngleLabel.Name = "RotationAngleLabel";
            this.RotationAngleLabel.Size = new System.Drawing.Size(80, 13);
            this.RotationAngleLabel.TabIndex = 2;
            this.RotationAngleLabel.Text = "Rotation Angle:";
            // 
            // DeskewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 642);
            this.Controls.Add(this.ResultsGroupBox);
            this.Controls.Add(this.DeskewGroupBox);
            this.Name = "DeskewForm";
            this.Text = "Deskew";
            this.Controls.SetChildIndex(this.DeskewGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.Controls.SetChildIndex(this.ResultsGroupBox, 0);
            this.DeskewGroupBox.ResumeLayout(false);
            this.DeskewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QualityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumConfidenceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumAngleNumericUpDown)).EndInit();
            this.ResultsGroupBox.ResumeLayout(false);
            this.ResultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DeskewGroupBox;
        private System.Windows.Forms.NumericUpDown QualityNumericUpDown;
        private System.Windows.Forms.NumericUpDown MinimumConfidenceNumericUpDown;
        private System.Windows.Forms.NumericUpDown MinimumAngleNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox MaintainOriginalizSizeCheckBox;
        private System.Windows.Forms.Label QualityLabel;
        private System.Windows.Forms.Label MinimumConfidenceLabel;
        private System.Windows.Forms.Label MinimumAngleLabel;
        private System.Windows.Forms.GroupBox ResultsGroupBox;
        private System.Windows.Forms.Label RotationAngleValueLabel;
        private System.Windows.Forms.Label ImageWasModifiedLabel;
        private System.Windows.Forms.Label ImageWasModifiedValueLabel;
        private System.Windows.Forms.Label RotationAngleLabel;
        private System.Windows.Forms.Label ConfidenceLabel;
        private System.Windows.Forms.Label ConfidenceValueLabel;
        private System.Windows.Forms.Label VariationValueLabel;
        private System.Windows.Forms.Label VariationLabel;
        private System.Windows.Forms.ComboBox PadColorComboBox;
    }
}