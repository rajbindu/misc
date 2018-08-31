namespace ImagXpressDemo
{
    partial class OpenOptionsJbig2Form
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
            this.SwapBlackAndWhiteCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).BeginInit();
            this.Jbig2GroupBox.SuspendLayout();
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
            // Jbig2GroupBox
            // 
            this.Jbig2GroupBox.Controls.Add(this.SwapBlackAndWhiteCheckBox);
            this.Jbig2GroupBox.Location = new System.Drawing.Point(9, 198);
            this.Jbig2GroupBox.Name = "Jbig2GroupBox";
            this.Jbig2GroupBox.Size = new System.Drawing.Size(200, 46);
            this.Jbig2GroupBox.TabIndex = 9;
            this.Jbig2GroupBox.TabStop = false;
            this.Jbig2GroupBox.Text = "JBIG2";
            // 
            // SwapBlackAndWhiteCheckBox
            // 
            this.SwapBlackAndWhiteCheckBox.AutoSize = true;
            this.SwapBlackAndWhiteCheckBox.Location = new System.Drawing.Point(22, 21);
            this.SwapBlackAndWhiteCheckBox.Name = "SwapBlackAndWhiteCheckBox";
            this.SwapBlackAndWhiteCheckBox.Size = new System.Drawing.Size(136, 17);
            this.SwapBlackAndWhiteCheckBox.TabIndex = 0;
            this.SwapBlackAndWhiteCheckBox.Text = "Swap Black And White";
            this.SwapBlackAndWhiteCheckBox.UseVisualStyleBackColor = true;
            // 
            // OpenOptionsJbig2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 249);
            this.Controls.Add(this.Jbig2GroupBox);
            this.Name = "OpenOptionsJbig2Form";
            this.Text = "Open Options - JBIG2";
            this.Load += new System.EventHandler(this.OpenOptionsJbig2Form_Load);
            this.Controls.SetChildIndex(this.RotationLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetNumericUpDown, 0);
            this.Controls.SetChildIndex(this.RotationComboBox, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.Jbig2GroupBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).EndInit();
            this.Jbig2GroupBox.ResumeLayout(false);
            this.Jbig2GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Jbig2GroupBox;
        private System.Windows.Forms.CheckBox SwapBlackAndWhiteCheckBox;
    }
}