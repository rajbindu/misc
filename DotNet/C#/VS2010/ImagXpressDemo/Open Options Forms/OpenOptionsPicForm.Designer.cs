namespace ImagXpressDemo
{
    partial class OpenOptionsPicForm
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
            this.PicGroupBox = new System.Windows.Forms.GroupBox();
            this.ThumbnailSizeLabel = new System.Windows.Forms.Label();
            this.ThumbnailSizeComboBox = new System.Windows.Forms.ComboBox();
            this.PicPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PicPasswordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).BeginInit();
            this.PicGroupBox.SuspendLayout();
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
            // PicGroupBox
            // 
            this.PicGroupBox.Controls.Add(this.ThumbnailSizeLabel);
            this.PicGroupBox.Controls.Add(this.ThumbnailSizeComboBox);
            this.PicGroupBox.Controls.Add(this.PicPasswordTextBox);
            this.PicGroupBox.Controls.Add(this.PicPasswordLabel);
            this.PicGroupBox.Location = new System.Drawing.Point(9, 200);
            this.PicGroupBox.Name = "PicGroupBox";
            this.PicGroupBox.Size = new System.Drawing.Size(450, 49);
            this.PicGroupBox.TabIndex = 9;
            this.PicGroupBox.TabStop = false;
            this.PicGroupBox.Text = "PIC";
            // 
            // ThumbnailSizeLabel
            // 
            this.ThumbnailSizeLabel.AutoSize = true;
            this.ThumbnailSizeLabel.Location = new System.Drawing.Point(239, 22);
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
            this.ThumbnailSizeComboBox.Location = new System.Drawing.Point(327, 18);
            this.ThumbnailSizeComboBox.Name = "ThumbnailSizeComboBox";
            this.ThumbnailSizeComboBox.Size = new System.Drawing.Size(107, 21);
            this.ThumbnailSizeComboBox.TabIndex = 3;
            // 
            // PicPasswordTextBox
            // 
            this.PicPasswordTextBox.Location = new System.Drawing.Point(111, 18);
            this.PicPasswordTextBox.Name = "PicPasswordTextBox";
            this.PicPasswordTextBox.Size = new System.Drawing.Size(105, 20);
            this.PicPasswordTextBox.TabIndex = 1;
            // 
            // PicPasswordLabel
            // 
            this.PicPasswordLabel.AutoSize = true;
            this.PicPasswordLabel.Location = new System.Drawing.Point(21, 22);
            this.PicPasswordLabel.Name = "PicPasswordLabel";
            this.PicPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PicPasswordLabel.TabIndex = 0;
            this.PicPasswordLabel.Text = "Password:";
            // 
            // OpenOptionsPicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 257);
            this.Controls.Add(this.PicGroupBox);
            this.Name = "OpenOptionsPicForm";
            this.Text = "Open Options - PIC";
            this.Load += new System.EventHandler(this.OpenOptionsPicForm_Load);
            this.Controls.SetChildIndex(this.RotationLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetNumericUpDown, 0);
            this.Controls.SetChildIndex(this.PicGroupBox, 0);
            this.Controls.SetChildIndex(this.RotationComboBox, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).EndInit();
            this.PicGroupBox.ResumeLayout(false);
            this.PicGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PicGroupBox;
        private System.Windows.Forms.TextBox PicPasswordTextBox;
        private System.Windows.Forms.Label PicPasswordLabel;
        private System.Windows.Forms.Label ThumbnailSizeLabel;
        private System.Windows.Forms.ComboBox ThumbnailSizeComboBox;
    }
}