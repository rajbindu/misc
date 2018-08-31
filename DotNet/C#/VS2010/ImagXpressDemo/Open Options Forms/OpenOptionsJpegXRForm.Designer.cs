namespace ImagXpressDemo
{
    partial class OpenOptionsJpegXRForm
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
            this.PostProcessingFilterComboBox = new System.Windows.Forms.ComboBox();
            this.PostProcessingFilterLabel = new System.Windows.Forms.Label();
            this.JpegXrGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).BeginInit();
            this.JpegXrGroupBox.SuspendLayout();
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
            // PostProcessingFilterComboBox
            // 
            this.PostProcessingFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostProcessingFilterComboBox.FormattingEnabled = true;
            this.PostProcessingFilterComboBox.Items.AddRange(new object[] {
            "None",
            "Light",
            "Medium",
            "Strong",
            "Very Strong"});
            this.PostProcessingFilterComboBox.Location = new System.Drawing.Point(136, 16);
            this.PostProcessingFilterComboBox.Name = "PostProcessingFilterComboBox";
            this.PostProcessingFilterComboBox.Size = new System.Drawing.Size(121, 21);
            this.PostProcessingFilterComboBox.TabIndex = 1;
            // 
            // PostProcessingFilterLabel
            // 
            this.PostProcessingFilterLabel.AutoSize = true;
            this.PostProcessingFilterLabel.Location = new System.Drawing.Point(19, 19);
            this.PostProcessingFilterLabel.Name = "PostProcessingFilterLabel";
            this.PostProcessingFilterLabel.Size = new System.Drawing.Size(111, 13);
            this.PostProcessingFilterLabel.TabIndex = 0;
            this.PostProcessingFilterLabel.Text = "Post Processing Filter:";
            // 
            // JpegXrGroupBox
            // 
            this.JpegXrGroupBox.Controls.Add(this.PostProcessingFilterLabel);
            this.JpegXrGroupBox.Controls.Add(this.PostProcessingFilterComboBox);
            this.JpegXrGroupBox.Location = new System.Drawing.Point(9, 200);
            this.JpegXrGroupBox.Name = "JpegXrGroupBox";
            this.JpegXrGroupBox.Size = new System.Drawing.Size(274, 46);
            this.JpegXrGroupBox.TabIndex = 9;
            this.JpegXrGroupBox.TabStop = false;
            this.JpegXrGroupBox.Text = "JPEG XR";
            // 
            // OpenOptionsJpegXRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 249);
            this.Controls.Add(this.JpegXrGroupBox);
            this.Name = "OpenOptionsJpegXRForm";
            this.Text = "Open Options - JPEG XR";
            this.Load += new System.EventHandler(this.OpenOptionsJpegXRForm_Load);
            this.Controls.SetChildIndex(this.RotationLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetNumericUpDown, 0);
            this.Controls.SetChildIndex(this.RotationComboBox, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.JpegXrGroupBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).EndInit();
            this.JpegXrGroupBox.ResumeLayout(false);
            this.JpegXrGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PostProcessingFilterComboBox;
        private System.Windows.Forms.Label PostProcessingFilterLabel;
        private System.Windows.Forms.GroupBox JpegXrGroupBox;
    }
}