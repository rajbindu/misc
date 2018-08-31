namespace ImagXpressDemo
{
    partial class SaveOptionsExifForm
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
            this.ExifGroupBox = new System.Windows.Forms.GroupBox();
            this.ThumbnailSizeLabel = new System.Windows.Forms.Label();
            this.ThumbnailSizeComboBox = new System.Windows.Forms.ComboBox();
            this.ExifGroupBox.SuspendLayout();
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
            // ExifGroupBox
            // 
            this.ExifGroupBox.Controls.Add(this.ThumbnailSizeLabel);
            this.ExifGroupBox.Controls.Add(this.ThumbnailSizeComboBox);
            this.ExifGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ExifGroupBox.Name = "ExifGroupBox";
            this.ExifGroupBox.Size = new System.Drawing.Size(224, 50);
            this.ExifGroupBox.TabIndex = 0;
            this.ExifGroupBox.TabStop = false;
            this.ExifGroupBox.Text = "EXIF";
            // 
            // ThumbnailSizeLabel
            // 
            this.ThumbnailSizeLabel.AutoSize = true;
            this.ThumbnailSizeLabel.Location = new System.Drawing.Point(9, 22);
            this.ThumbnailSizeLabel.Name = "ThumbnailSizeLabel";
            this.ThumbnailSizeLabel.Size = new System.Drawing.Size(82, 13);
            this.ThumbnailSizeLabel.TabIndex = 0;
            this.ThumbnailSizeLabel.Text = "Thumbnail Size:";
            // 
            // ThumbnailSizeComboBox
            // 
            this.ThumbnailSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThumbnailSizeComboBox.FormattingEnabled = true;
            this.ThumbnailSizeComboBox.Items.AddRange(new object[] {
            "No Thumbnail",
            "1/4",
            "1/16",
            "1/64"});
            this.ThumbnailSizeComboBox.Location = new System.Drawing.Point(95, 19);
            this.ThumbnailSizeComboBox.Name = "ThumbnailSizeComboBox";
            this.ThumbnailSizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ThumbnailSizeComboBox.TabIndex = 1;
            // 
            // SaveOptionsExifForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 73);
            this.Controls.Add(this.ExifGroupBox);
            this.Name = "SaveOptionsExifForm";
            this.Text = "Save Options - EXIF";
            this.Load += new System.EventHandler(this.SaveOptionsExifForm_Load);
            this.Controls.SetChildIndex(this.ExifGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.ExifGroupBox.ResumeLayout(false);
            this.ExifGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ExifGroupBox;
        private System.Windows.Forms.ComboBox ThumbnailSizeComboBox;
        private System.Windows.Forms.Label ThumbnailSizeLabel;
    }
}