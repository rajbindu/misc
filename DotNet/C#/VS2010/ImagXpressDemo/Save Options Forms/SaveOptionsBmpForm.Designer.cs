namespace ImagXpressDemo
{
    partial class SaveOptionsBmpForm
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
            this.CompressionComboBox = new System.Windows.Forms.ComboBox();
            this.CompressionLabel = new System.Windows.Forms.Label();
            this.BmpGroupBox = new System.Windows.Forms.GroupBox();
            this.BmpGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.TabIndex = 2;
            // 
            // CancelOptionsButton
            // 
            this.CancelOptionsButton.TabIndex = 1;
            // 
            // CompressionComboBox
            // 
            this.CompressionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompressionComboBox.FormattingEnabled = true;
            this.CompressionComboBox.Items.AddRange(new object[] {
            "None",
            "Run Length Encoding"});
            this.CompressionComboBox.Location = new System.Drawing.Point(97, 13);
            this.CompressionComboBox.Name = "CompressionComboBox";
            this.CompressionComboBox.Size = new System.Drawing.Size(138, 21);
            this.CompressionComboBox.TabIndex = 1;
            // 
            // CompressionLabel
            // 
            this.CompressionLabel.AutoSize = true;
            this.CompressionLabel.Location = new System.Drawing.Point(21, 16);
            this.CompressionLabel.Name = "CompressionLabel";
            this.CompressionLabel.Size = new System.Drawing.Size(70, 13);
            this.CompressionLabel.TabIndex = 0;
            this.CompressionLabel.Text = "Compression:";
            // 
            // BmpGroupBox
            // 
            this.BmpGroupBox.Controls.Add(this.CompressionLabel);
            this.BmpGroupBox.Controls.Add(this.CompressionComboBox);
            this.BmpGroupBox.Location = new System.Drawing.Point(12, 12);
            this.BmpGroupBox.Name = "BmpGroupBox";
            this.BmpGroupBox.Size = new System.Drawing.Size(246, 43);
            this.BmpGroupBox.TabIndex = 0;
            this.BmpGroupBox.TabStop = false;
            this.BmpGroupBox.Text = "BMP";
            // 
            // SaveOptionsBmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 68);
            this.Controls.Add(this.BmpGroupBox);
            this.Name = "SaveOptionsBmpForm";
            this.Text = "Save Options - BMP";
            this.Load += new System.EventHandler(this.SaveOptionsBmpForm_Load);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.Controls.SetChildIndex(this.BmpGroupBox, 0);
            this.BmpGroupBox.ResumeLayout(false);
            this.BmpGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CompressionComboBox;
        private System.Windows.Forms.Label CompressionLabel;
        private System.Windows.Forms.GroupBox BmpGroupBox;
    }
}