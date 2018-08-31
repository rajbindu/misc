namespace ImagXpressDemo
{
    partial class ImageInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageInfoForm));
            this.OkButton = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.PhysicalDimensionsLabel = new System.Windows.Forms.Label();
            this.BitsPerPixelLabel = new System.Windows.Forms.Label();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.DecompressedSizeLabel = new System.Windows.Forms.Label();
            this.CompressionRatioLabel = new System.Windows.Forms.Label();
            this.ImageInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.CompressionRatioValueTextBox = new System.Windows.Forms.TextBox();
            this.PageNumberLabel = new System.Windows.Forms.Label();
            this.DecompresedSizeValueTextBox = new System.Windows.Forms.TextBox();
            this.ResolutionUnitComboBox = new System.Windows.Forms.ComboBox();
            this.FileSizeValueTextBox = new System.Windows.Forms.TextBox();
            this.FileSizeLabel = new System.Windows.Forms.Label();
            this.FormatValueTextBox = new System.Windows.Forms.TextBox();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.BitsPerPixelValueTextBox = new System.Windows.Forms.TextBox();
            this.ResolutionValueTextBox = new System.Windows.Forms.TextBox();
            this.PhysicalDimensionsValueTextBox = new System.Windows.Forms.TextBox();
            this.HeightValueTextBox = new System.Windows.Forms.TextBox();
            this.WidthValueTextBox = new System.Windows.Forms.TextBox();
            this.PageNumberValueTextBox = new System.Windows.Forms.TextBox();
            this.FileNameValueTextBox = new System.Windows.Forms.TextBox();
            this.ImageInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(5, 406);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(16, 21);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FileNameLabel.TabIndex = 0;
            this.FileNameLabel.Text = "File Name:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(16, 87);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 4;
            this.WidthLabel.Text = "Width:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(16, 118);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 6;
            this.HeightLabel.Text = "Height:";
            // 
            // PhysicalDimensionsLabel
            // 
            this.PhysicalDimensionsLabel.AutoSize = true;
            this.PhysicalDimensionsLabel.Location = new System.Drawing.Point(16, 149);
            this.PhysicalDimensionsLabel.Name = "PhysicalDimensionsLabel";
            this.PhysicalDimensionsLabel.Size = new System.Drawing.Size(106, 13);
            this.PhysicalDimensionsLabel.TabIndex = 8;
            this.PhysicalDimensionsLabel.Text = "Physical Dimensions:";
            // 
            // BitsPerPixelLabel
            // 
            this.BitsPerPixelLabel.AutoSize = true;
            this.BitsPerPixelLabel.Location = new System.Drawing.Point(16, 232);
            this.BitsPerPixelLabel.Name = "BitsPerPixelLabel";
            this.BitsPerPixelLabel.Size = new System.Drawing.Size(71, 13);
            this.BitsPerPixelLabel.TabIndex = 13;
            this.BitsPerPixelLabel.Text = "Bits Per Pixel:";
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Location = new System.Drawing.Point(16, 263);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(42, 13);
            this.FormatLabel.TabIndex = 15;
            this.FormatLabel.Text = "Format:";
            // 
            // DecompressedSizeLabel
            // 
            this.DecompressedSizeLabel.AutoSize = true;
            this.DecompressedSizeLabel.Location = new System.Drawing.Point(16, 325);
            this.DecompressedSizeLabel.Name = "DecompressedSizeLabel";
            this.DecompressedSizeLabel.Size = new System.Drawing.Size(136, 13);
            this.DecompressedSizeLabel.TabIndex = 19;
            this.DecompressedSizeLabel.Text = "Decompressed Image Size:";
            // 
            // CompressionRatioLabel
            // 
            this.CompressionRatioLabel.AutoSize = true;
            this.CompressionRatioLabel.Location = new System.Drawing.Point(16, 356);
            this.CompressionRatioLabel.Name = "CompressionRatioLabel";
            this.CompressionRatioLabel.Size = new System.Drawing.Size(98, 13);
            this.CompressionRatioLabel.TabIndex = 21;
            this.CompressionRatioLabel.Text = "Compression Ratio:";
            // 
            // ImageInfoGroupBox
            // 
            this.ImageInfoGroupBox.Controls.Add(this.CompressionRatioValueTextBox);
            this.ImageInfoGroupBox.Controls.Add(this.PageNumberLabel);
            this.ImageInfoGroupBox.Controls.Add(this.DecompresedSizeValueTextBox);
            this.ImageInfoGroupBox.Controls.Add(this.ResolutionUnitComboBox);
            this.ImageInfoGroupBox.Controls.Add(this.FileSizeValueTextBox);
            this.ImageInfoGroupBox.Controls.Add(this.FileSizeLabel);
            this.ImageInfoGroupBox.Controls.Add(this.FormatValueTextBox);
            this.ImageInfoGroupBox.Controls.Add(this.ResolutionLabel);
            this.ImageInfoGroupBox.Controls.Add(this.BitsPerPixelValueTextBox);
            this.ImageInfoGroupBox.Controls.Add(this.CompressionRatioLabel);
            this.ImageInfoGroupBox.Controls.Add(this.ResolutionValueTextBox);
            this.ImageInfoGroupBox.Controls.Add(this.DecompressedSizeLabel);
            this.ImageInfoGroupBox.Controls.Add(this.PhysicalDimensionsValueTextBox);
            this.ImageInfoGroupBox.Controls.Add(this.FormatLabel);
            this.ImageInfoGroupBox.Controls.Add(this.HeightValueTextBox);
            this.ImageInfoGroupBox.Controls.Add(this.BitsPerPixelLabel);
            this.ImageInfoGroupBox.Controls.Add(this.WidthValueTextBox);
            this.ImageInfoGroupBox.Controls.Add(this.PhysicalDimensionsLabel);
            this.ImageInfoGroupBox.Controls.Add(this.PageNumberValueTextBox);
            this.ImageInfoGroupBox.Controls.Add(this.HeightLabel);
            this.ImageInfoGroupBox.Controls.Add(this.FileNameValueTextBox);
            this.ImageInfoGroupBox.Controls.Add(this.WidthLabel);
            this.ImageInfoGroupBox.Controls.Add(this.FileNameLabel);
            this.ImageInfoGroupBox.Location = new System.Drawing.Point(7, 15);
            this.ImageInfoGroupBox.Name = "ImageInfoGroupBox";
            this.ImageInfoGroupBox.Size = new System.Drawing.Size(457, 385);
            this.ImageInfoGroupBox.TabIndex = 0;
            this.ImageInfoGroupBox.TabStop = false;
            // 
            // CompressionRatioValueTextBox
            // 
            this.CompressionRatioValueTextBox.Location = new System.Drawing.Point(159, 355);
            this.CompressionRatioValueTextBox.Name = "CompressionRatioValueTextBox";
            this.CompressionRatioValueTextBox.ReadOnly = true;
            this.CompressionRatioValueTextBox.Size = new System.Drawing.Size(292, 20);
            this.CompressionRatioValueTextBox.TabIndex = 22;
            // 
            // PageNumberLabel
            // 
            this.PageNumberLabel.AutoSize = true;
            this.PageNumberLabel.Location = new System.Drawing.Point(16, 56);
            this.PageNumberLabel.Name = "PageNumberLabel";
            this.PageNumberLabel.Size = new System.Drawing.Size(75, 13);
            this.PageNumberLabel.TabIndex = 2;
            this.PageNumberLabel.Text = "Page Number:";
            // 
            // DecompresedSizeValueTextBox
            // 
            this.DecompresedSizeValueTextBox.Location = new System.Drawing.Point(159, 322);
            this.DecompresedSizeValueTextBox.Name = "DecompresedSizeValueTextBox";
            this.DecompresedSizeValueTextBox.ReadOnly = true;
            this.DecompresedSizeValueTextBox.Size = new System.Drawing.Size(292, 20);
            this.DecompresedSizeValueTextBox.TabIndex = 20;
            // 
            // ResolutionUnitComboBox
            // 
            this.ResolutionUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionUnitComboBox.FormattingEnabled = true;
            this.ResolutionUnitComboBox.Items.AddRange(new object[] {
            "Inch",
            "Centimeter",
            "Meter"});
            this.ResolutionUnitComboBox.Location = new System.Drawing.Point(19, 196);
            this.ResolutionUnitComboBox.Name = "ResolutionUnitComboBox";
            this.ResolutionUnitComboBox.Size = new System.Drawing.Size(95, 21);
            this.ResolutionUnitComboBox.TabIndex = 12;
            this.ResolutionUnitComboBox.SelectedIndexChanged += new System.EventHandler(this.ResolutionUnitComboBox_SelectedIndexChanged);
            // 
            // FileSizeValueTextBox
            // 
            this.FileSizeValueTextBox.Location = new System.Drawing.Point(159, 291);
            this.FileSizeValueTextBox.Name = "FileSizeValueTextBox";
            this.FileSizeValueTextBox.ReadOnly = true;
            this.FileSizeValueTextBox.Size = new System.Drawing.Size(292, 20);
            this.FileSizeValueTextBox.TabIndex = 18;
            // 
            // FileSizeLabel
            // 
            this.FileSizeLabel.AutoSize = true;
            this.FileSizeLabel.Location = new System.Drawing.Point(16, 294);
            this.FileSizeLabel.Name = "FileSizeLabel";
            this.FileSizeLabel.Size = new System.Drawing.Size(49, 13);
            this.FileSizeLabel.TabIndex = 17;
            this.FileSizeLabel.Text = "File Size:";
            // 
            // FormatValueTextBox
            // 
            this.FormatValueTextBox.Location = new System.Drawing.Point(159, 260);
            this.FormatValueTextBox.Name = "FormatValueTextBox";
            this.FormatValueTextBox.ReadOnly = true;
            this.FormatValueTextBox.Size = new System.Drawing.Size(292, 20);
            this.FormatValueTextBox.TabIndex = 16;
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(16, 180);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(60, 13);
            this.ResolutionLabel.TabIndex = 10;
            this.ResolutionLabel.Text = "Resolution:";
            // 
            // BitsPerPixelValueTextBox
            // 
            this.BitsPerPixelValueTextBox.Location = new System.Drawing.Point(159, 227);
            this.BitsPerPixelValueTextBox.Name = "BitsPerPixelValueTextBox";
            this.BitsPerPixelValueTextBox.ReadOnly = true;
            this.BitsPerPixelValueTextBox.Size = new System.Drawing.Size(292, 20);
            this.BitsPerPixelValueTextBox.TabIndex = 14;
            // 
            // ResolutionValueTextBox
            // 
            this.ResolutionValueTextBox.Location = new System.Drawing.Point(159, 177);
            this.ResolutionValueTextBox.Name = "ResolutionValueTextBox";
            this.ResolutionValueTextBox.ReadOnly = true;
            this.ResolutionValueTextBox.Size = new System.Drawing.Size(292, 20);
            this.ResolutionValueTextBox.TabIndex = 11;
            // 
            // PhysicalDimensionsValueTextBox
            // 
            this.PhysicalDimensionsValueTextBox.Location = new System.Drawing.Point(159, 146);
            this.PhysicalDimensionsValueTextBox.Name = "PhysicalDimensionsValueTextBox";
            this.PhysicalDimensionsValueTextBox.ReadOnly = true;
            this.PhysicalDimensionsValueTextBox.Size = new System.Drawing.Size(292, 20);
            this.PhysicalDimensionsValueTextBox.TabIndex = 9;
            // 
            // HeightValueTextBox
            // 
            this.HeightValueTextBox.Location = new System.Drawing.Point(159, 113);
            this.HeightValueTextBox.Name = "HeightValueTextBox";
            this.HeightValueTextBox.ReadOnly = true;
            this.HeightValueTextBox.Size = new System.Drawing.Size(292, 20);
            this.HeightValueTextBox.TabIndex = 7;
            // 
            // WidthValueTextBox
            // 
            this.WidthValueTextBox.Location = new System.Drawing.Point(159, 82);
            this.WidthValueTextBox.Name = "WidthValueTextBox";
            this.WidthValueTextBox.ReadOnly = true;
            this.WidthValueTextBox.Size = new System.Drawing.Size(292, 20);
            this.WidthValueTextBox.TabIndex = 5;
            // 
            // PageNumberValueTextBox
            // 
            this.PageNumberValueTextBox.Location = new System.Drawing.Point(159, 51);
            this.PageNumberValueTextBox.Name = "PageNumberValueTextBox";
            this.PageNumberValueTextBox.ReadOnly = true;
            this.PageNumberValueTextBox.Size = new System.Drawing.Size(292, 20);
            this.PageNumberValueTextBox.TabIndex = 3;
            // 
            // FileNameValueTextBox
            // 
            this.FileNameValueTextBox.Location = new System.Drawing.Point(159, 18);
            this.FileNameValueTextBox.Name = "FileNameValueTextBox";
            this.FileNameValueTextBox.ReadOnly = true;
            this.FileNameValueTextBox.Size = new System.Drawing.Size(292, 20);
            this.FileNameValueTextBox.TabIndex = 1;
            // 
            // ImageInfoForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 436);
            this.Controls.Add(this.ImageInfoGroupBox);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImageInfoForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Information";
            this.Load += new System.EventHandler(this.ImageInfoForm_Load);
            this.ImageInfoGroupBox.ResumeLayout(false);
            this.ImageInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label PhysicalDimensionsLabel;
        private System.Windows.Forms.Label BitsPerPixelLabel;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.Label DecompressedSizeLabel;
        private System.Windows.Forms.Label CompressionRatioLabel;
        private System.Windows.Forms.GroupBox ImageInfoGroupBox;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.Label FileSizeLabel;
        private System.Windows.Forms.ComboBox ResolutionUnitComboBox;
        private System.Windows.Forms.Label PageNumberLabel;
        private System.Windows.Forms.TextBox CompressionRatioValueTextBox;
        private System.Windows.Forms.TextBox DecompresedSizeValueTextBox;
        private System.Windows.Forms.TextBox FileSizeValueTextBox;
        private System.Windows.Forms.TextBox FormatValueTextBox;
        private System.Windows.Forms.TextBox BitsPerPixelValueTextBox;
        private System.Windows.Forms.TextBox ResolutionValueTextBox;
        private System.Windows.Forms.TextBox PhysicalDimensionsValueTextBox;
        private System.Windows.Forms.TextBox HeightValueTextBox;
        private System.Windows.Forms.TextBox WidthValueTextBox;
        private System.Windows.Forms.TextBox PageNumberValueTextBox;
        private System.Windows.Forms.TextBox FileNameValueTextBox;
    }
}