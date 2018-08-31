namespace ImagXpressDemo
{
    partial class SaveOptionsJpegXRForm
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
            this.JpegXrGroupBox = new System.Windows.Forms.GroupBox();
            this.QuantizationLabel = new System.Windows.Forms.Label();
            this.QuantizationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FrequencyOrderingCheckBox = new System.Windows.Forms.CheckBox();
            this.ChromaSubSamplingComboBox = new System.Windows.Forms.ComboBox();
            this.ChromaSubSamplingLabel = new System.Windows.Forms.Label();
            this.JpegXrGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantizationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.TabIndex = 1;
            // 
            // CancelOptionsButton
            // 
            this.CancelOptionsButton.TabIndex = 2;
            // 
            // JpegXrGroupBox
            // 
            this.JpegXrGroupBox.Controls.Add(this.QuantizationLabel);
            this.JpegXrGroupBox.Controls.Add(this.QuantizationNumericUpDown);
            this.JpegXrGroupBox.Controls.Add(this.FrequencyOrderingCheckBox);
            this.JpegXrGroupBox.Controls.Add(this.ChromaSubSamplingComboBox);
            this.JpegXrGroupBox.Controls.Add(this.ChromaSubSamplingLabel);
            this.JpegXrGroupBox.Location = new System.Drawing.Point(12, 12);
            this.JpegXrGroupBox.Name = "JpegXrGroupBox";
            this.JpegXrGroupBox.Size = new System.Drawing.Size(346, 80);
            this.JpegXrGroupBox.TabIndex = 0;
            this.JpegXrGroupBox.TabStop = false;
            this.JpegXrGroupBox.Text = "JPEG XR";
            // 
            // QuantizationLabel
            // 
            this.QuantizationLabel.AutoSize = true;
            this.QuantizationLabel.Location = new System.Drawing.Point(16, 49);
            this.QuantizationLabel.Name = "QuantizationLabel";
            this.QuantizationLabel.Size = new System.Drawing.Size(69, 13);
            this.QuantizationLabel.TabIndex = 2;
            this.QuantizationLabel.Text = "Quantization:";
            // 
            // QuantizationNumericUpDown
            // 
            this.QuantizationNumericUpDown.Location = new System.Drawing.Point(127, 48);
            this.QuantizationNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.QuantizationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantizationNumericUpDown.Name = "QuantizationNumericUpDown";
            this.QuantizationNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.QuantizationNumericUpDown.TabIndex = 3;
            this.QuantizationNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrequencyOrderingCheckBox
            // 
            this.FrequencyOrderingCheckBox.AutoSize = true;
            this.FrequencyOrderingCheckBox.Location = new System.Drawing.Point(192, 48);
            this.FrequencyOrderingCheckBox.Name = "FrequencyOrderingCheckBox";
            this.FrequencyOrderingCheckBox.Size = new System.Drawing.Size(119, 17);
            this.FrequencyOrderingCheckBox.TabIndex = 4;
            this.FrequencyOrderingCheckBox.Text = "Frequency Ordering";
            this.FrequencyOrderingCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChromaSubSamplingComboBox
            // 
            this.ChromaSubSamplingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChromaSubSamplingComboBox.FormattingEnabled = true;
            this.ChromaSubSamplingComboBox.Items.AddRange(new object[] {
            "No Color (4:0:0)",
            "2 to 1 Vertical (4:2:0)",
            "2 to 1 Horizontal (4:2:2)",
            "No Subsampling (4:4:4)"});
            this.ChromaSubSamplingComboBox.Location = new System.Drawing.Point(127, 18);
            this.ChromaSubSamplingComboBox.Name = "ChromaSubSamplingComboBox";
            this.ChromaSubSamplingComboBox.Size = new System.Drawing.Size(178, 21);
            this.ChromaSubSamplingComboBox.TabIndex = 1;
            // 
            // ChromaSubSamplingLabel
            // 
            this.ChromaSubSamplingLabel.AutoSize = true;
            this.ChromaSubSamplingLabel.Location = new System.Drawing.Point(16, 21);
            this.ChromaSubSamplingLabel.Name = "ChromaSubSamplingLabel";
            this.ChromaSubSamplingLabel.Size = new System.Drawing.Size(111, 13);
            this.ChromaSubSamplingLabel.TabIndex = 0;
            this.ChromaSubSamplingLabel.Text = "Chroma SubSampling:";
            // 
            // SaveOptionsJpegXRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 106);
            this.Controls.Add(this.JpegXrGroupBox);
            this.Name = "SaveOptionsJpegXRForm";
            this.Text = "Save Options - JPEG XR";
            this.Load += new System.EventHandler(this.SaveOptionsJpegXRForm_Load);
            this.Controls.SetChildIndex(this.JpegXrGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.JpegXrGroupBox.ResumeLayout(false);
            this.JpegXrGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantizationNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox JpegXrGroupBox;
        private System.Windows.Forms.Label QuantizationLabel;
        private System.Windows.Forms.NumericUpDown QuantizationNumericUpDown;
        private System.Windows.Forms.CheckBox FrequencyOrderingCheckBox;
        private System.Windows.Forms.ComboBox ChromaSubSamplingComboBox;
        private System.Windows.Forms.Label ChromaSubSamplingLabel;
    }
}