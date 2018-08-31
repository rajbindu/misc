namespace ImagXpressDemo
{
    partial class SaveOptionsJbig2Form
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
            this.Jbig2GroupBox = new System.Windows.Forms.GroupBox();
            this.LoosenessCompressionLabel = new System.Windows.Forms.Label();
            this.FileOrganizationLabel = new System.Windows.Forms.Label();
            this.EncodeModeCompressionLabel = new System.Windows.Forms.Label();
            this.InvertedRegionCheckBox = new System.Windows.Forms.CheckBox();
            this.EncodeModeCompressionComboBox = new System.Windows.Forms.ComboBox();
            this.FileOrganizationComboBox = new System.Windows.Forms.ComboBox();
            this.LoosenessCompresionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Jbig2GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoosenessCompresionNumericUpDown)).BeginInit();
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
            // Jbig2GroupBox
            // 
            this.Jbig2GroupBox.Controls.Add(this.LoosenessCompressionLabel);
            this.Jbig2GroupBox.Controls.Add(this.FileOrganizationLabel);
            this.Jbig2GroupBox.Controls.Add(this.EncodeModeCompressionLabel);
            this.Jbig2GroupBox.Controls.Add(this.InvertedRegionCheckBox);
            this.Jbig2GroupBox.Controls.Add(this.EncodeModeCompressionComboBox);
            this.Jbig2GroupBox.Controls.Add(this.FileOrganizationComboBox);
            this.Jbig2GroupBox.Controls.Add(this.LoosenessCompresionNumericUpDown);
            this.Jbig2GroupBox.Location = new System.Drawing.Point(12, 12);
            this.Jbig2GroupBox.Name = "Jbig2GroupBox";
            this.Jbig2GroupBox.Size = new System.Drawing.Size(345, 127);
            this.Jbig2GroupBox.TabIndex = 0;
            this.Jbig2GroupBox.TabStop = false;
            this.Jbig2GroupBox.Text = "JBIG2";
            // 
            // LoosenessCompressionLabel
            // 
            this.LoosenessCompressionLabel.AutoSize = true;
            this.LoosenessCompressionLabel.Location = new System.Drawing.Point(8, 96);
            this.LoosenessCompressionLabel.Name = "LoosenessCompressionLabel";
            this.LoosenessCompressionLabel.Size = new System.Drawing.Size(124, 13);
            this.LoosenessCompressionLabel.TabIndex = 4;
            this.LoosenessCompressionLabel.Text = "Looseness Compression:";
            // 
            // FileOrganizationLabel
            // 
            this.FileOrganizationLabel.AutoSize = true;
            this.FileOrganizationLabel.Location = new System.Drawing.Point(8, 59);
            this.FileOrganizationLabel.Name = "FileOrganizationLabel";
            this.FileOrganizationLabel.Size = new System.Drawing.Size(88, 13);
            this.FileOrganizationLabel.TabIndex = 2;
            this.FileOrganizationLabel.Text = "File Organization:";
            // 
            // EncodeModeCompressionLabel
            // 
            this.EncodeModeCompressionLabel.AutoSize = true;
            this.EncodeModeCompressionLabel.Location = new System.Drawing.Point(6, 22);
            this.EncodeModeCompressionLabel.Name = "EncodeModeCompressionLabel";
            this.EncodeModeCompressionLabel.Size = new System.Drawing.Size(140, 13);
            this.EncodeModeCompressionLabel.TabIndex = 0;
            this.EncodeModeCompressionLabel.Text = "Encode Mode Compression:";
            // 
            // InvertedRegionCheckBox
            // 
            this.InvertedRegionCheckBox.AutoSize = true;
            this.InvertedRegionCheckBox.Location = new System.Drawing.Point(241, 97);
            this.InvertedRegionCheckBox.Name = "InvertedRegionCheckBox";
            this.InvertedRegionCheckBox.Size = new System.Drawing.Size(102, 17);
            this.InvertedRegionCheckBox.TabIndex = 6;
            this.InvertedRegionCheckBox.Text = "Inverted Region";
            this.InvertedRegionCheckBox.UseVisualStyleBackColor = true;
            // 
            // EncodeModeCompressionComboBox
            // 
            this.EncodeModeCompressionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodeModeCompressionComboBox.FormattingEnabled = true;
            this.EncodeModeCompressionComboBox.Items.AddRange(new object[] {
            "Auto Detect",
            "Lossless Generic MQ",
            "Lossless Generic Mmr",
            "Lossless Text Mq",
            "Lossless Text Mmr",
            "Lossless Text SpmMq",
            "Lossless Text SpmMmr",
            "Lossy Text Mq",
            "Lossy Text Mmr",
            "Lossy Halftone Mq",
            "Lossy Halftone Mmr"});
            this.EncodeModeCompressionComboBox.Location = new System.Drawing.Point(154, 19);
            this.EncodeModeCompressionComboBox.Name = "EncodeModeCompressionComboBox";
            this.EncodeModeCompressionComboBox.Size = new System.Drawing.Size(135, 21);
            this.EncodeModeCompressionComboBox.TabIndex = 1;
            // 
            // FileOrganizationComboBox
            // 
            this.FileOrganizationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FileOrganizationComboBox.FormattingEnabled = true;
            this.FileOrganizationComboBox.Items.AddRange(new object[] {
            "Default",
            "Sequential",
            "Random Access"});
            this.FileOrganizationComboBox.Location = new System.Drawing.Point(154, 56);
            this.FileOrganizationComboBox.Name = "FileOrganizationComboBox";
            this.FileOrganizationComboBox.Size = new System.Drawing.Size(135, 21);
            this.FileOrganizationComboBox.TabIndex = 3;
            // 
            // LoosenessCompresionNumericUpDown
            // 
            this.LoosenessCompresionNumericUpDown.Location = new System.Drawing.Point(154, 94);
            this.LoosenessCompresionNumericUpDown.Name = "LoosenessCompresionNumericUpDown";
            this.LoosenessCompresionNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.LoosenessCompresionNumericUpDown.TabIndex = 5;
            // 
            // SaveOptionsJbig2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 150);
            this.Controls.Add(this.Jbig2GroupBox);
            this.Name = "SaveOptionsJbig2Form";
            this.Text = "Save Options - JBIG2";
            this.Load += new System.EventHandler(this.SaveOptionsJbig2Form_Load);
            this.Controls.SetChildIndex(this.Jbig2GroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.Jbig2GroupBox.ResumeLayout(false);
            this.Jbig2GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoosenessCompresionNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Jbig2GroupBox;
        private System.Windows.Forms.Label LoosenessCompressionLabel;
        private System.Windows.Forms.Label FileOrganizationLabel;
        private System.Windows.Forms.Label EncodeModeCompressionLabel;
        private System.Windows.Forms.CheckBox InvertedRegionCheckBox;
        private System.Windows.Forms.ComboBox EncodeModeCompressionComboBox;
        private System.Windows.Forms.ComboBox FileOrganizationComboBox;
        private System.Windows.Forms.NumericUpDown LoosenessCompresionNumericUpDown;
    }
}