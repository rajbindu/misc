namespace ImagXpressDemo
{
    partial class OpenOptionsJpegForm
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
            this.CositedCheckBox = new System.Windows.Forms.CheckBox();
            this.EnhancedCheckBox = new System.Windows.Forms.CheckBox();
            this.JpegGroupBox = new System.Windows.Forms.GroupBox();
            this.ThumbnailSizeLabel = new System.Windows.Forms.Label();
            this.ThumbnailSizeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).BeginInit();
            this.JpegGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.TabIndex = 10;
            // 
            // CancelOptionsButton
            // 
            this.CancelOptionsButton.TabIndex = 11;
            // 
            // RotationComboBox
            // 
            this.RotationComboBox.TabIndex = 6;
            // 
            // RotationLabel
            // 
            this.RotationLabel.TabIndex = 5;
            // 
            // ImageOffsetNumericUpDown
            // 
            this.ImageOffsetNumericUpDown.TabIndex = 8;
            // 
            // CositedCheckBox
            // 
            this.CositedCheckBox.AutoSize = true;
            this.CositedCheckBox.Location = new System.Drawing.Point(21, 19);
            this.CositedCheckBox.Name = "CositedCheckBox";
            this.CositedCheckBox.Size = new System.Drawing.Size(61, 17);
            this.CositedCheckBox.TabIndex = 0;
            this.CositedCheckBox.Text = "Cosited";
            this.CositedCheckBox.UseVisualStyleBackColor = true;
            // 
            // EnhancedCheckBox
            // 
            this.EnhancedCheckBox.AutoSize = true;
            this.EnhancedCheckBox.Location = new System.Drawing.Point(86, 19);
            this.EnhancedCheckBox.Name = "EnhancedCheckBox";
            this.EnhancedCheckBox.Size = new System.Drawing.Size(75, 17);
            this.EnhancedCheckBox.TabIndex = 1;
            this.EnhancedCheckBox.Text = "Enhanced";
            this.EnhancedCheckBox.UseVisualStyleBackColor = true;
            // 
            // JpegGroupBox
            // 
            this.JpegGroupBox.Controls.Add(this.ThumbnailSizeLabel);
            this.JpegGroupBox.Controls.Add(this.ThumbnailSizeComboBox);
            this.JpegGroupBox.Controls.Add(this.CositedCheckBox);
            this.JpegGroupBox.Controls.Add(this.EnhancedCheckBox);
            this.JpegGroupBox.Location = new System.Drawing.Point(9, 204);
            this.JpegGroupBox.Name = "JpegGroupBox";
            this.JpegGroupBox.Size = new System.Drawing.Size(371, 49);
            this.JpegGroupBox.TabIndex = 9;
            this.JpegGroupBox.TabStop = false;
            this.JpegGroupBox.Text = "JPEG";
            // 
            // ThumbnailSizeLabel
            // 
            this.ThumbnailSizeLabel.AutoSize = true;
            this.ThumbnailSizeLabel.Location = new System.Drawing.Point(165, 21);
            this.ThumbnailSizeLabel.Name = "ThumbnailSizeLabel";
            this.ThumbnailSizeLabel.Size = new System.Drawing.Size(82, 13);
            this.ThumbnailSizeLabel.TabIndex = 2;
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
            this.ThumbnailSizeComboBox.Location = new System.Drawing.Point(251, 17);
            this.ThumbnailSizeComboBox.Name = "ThumbnailSizeComboBox";
            this.ThumbnailSizeComboBox.Size = new System.Drawing.Size(107, 21);
            this.ThumbnailSizeComboBox.TabIndex = 3;
            // 
            // OpenOptionsJpegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 262);
            this.Controls.Add(this.JpegGroupBox);
            this.Name = "OpenOptionsJpegForm";
            this.Text = "Open Options - JPEG";
            this.Load += new System.EventHandler(this.OpenOptionsJpegForm_Load);
            this.Controls.SetChildIndex(this.RotationLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetNumericUpDown, 0);
            this.Controls.SetChildIndex(this.RotationComboBox, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.JpegGroupBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).EndInit();
            this.JpegGroupBox.ResumeLayout(false);
            this.JpegGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CositedCheckBox;
        private System.Windows.Forms.CheckBox EnhancedCheckBox;
        private System.Windows.Forms.GroupBox JpegGroupBox;
        private System.Windows.Forms.Label ThumbnailSizeLabel;
        private System.Windows.Forms.ComboBox ThumbnailSizeComboBox;
    }
}