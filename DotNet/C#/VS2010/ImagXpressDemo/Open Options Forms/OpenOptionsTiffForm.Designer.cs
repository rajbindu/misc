namespace ImagXpressDemo
{
    partial class OpenOptionsTiffForm
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
            this.TiffGroupBox = new System.Windows.Forms.GroupBox();
            this.SpecialHandlingCheckBox = new System.Windows.Forms.CheckBox();
            this.IfdOffsetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IfdOffsetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).BeginInit();
            this.TiffGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IfdOffsetNumericUpDown)).BeginInit();
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
            // TiffGroupBox
            // 
            this.TiffGroupBox.Controls.Add(this.SpecialHandlingCheckBox);
            this.TiffGroupBox.Controls.Add(this.IfdOffsetNumericUpDown);
            this.TiffGroupBox.Controls.Add(this.IfdOffsetLabel);
            this.TiffGroupBox.Location = new System.Drawing.Point(9, 204);
            this.TiffGroupBox.Name = "TiffGroupBox";
            this.TiffGroupBox.Size = new System.Drawing.Size(307, 53);
            this.TiffGroupBox.TabIndex = 9;
            this.TiffGroupBox.TabStop = false;
            this.TiffGroupBox.Text = "TIFF";
            // 
            // SpecialHandlingCheckBox
            // 
            this.SpecialHandlingCheckBox.AutoSize = true;
            this.SpecialHandlingCheckBox.Location = new System.Drawing.Point(194, 23);
            this.SpecialHandlingCheckBox.Name = "SpecialHandlingCheckBox";
            this.SpecialHandlingCheckBox.Size = new System.Drawing.Size(106, 17);
            this.SpecialHandlingCheckBox.TabIndex = 2;
            this.SpecialHandlingCheckBox.Text = "Special Handling";
            this.SpecialHandlingCheckBox.UseVisualStyleBackColor = true;
            // 
            // IfdOffsetNumericUpDown
            // 
            this.IfdOffsetNumericUpDown.Location = new System.Drawing.Point(93, 21);
            this.IfdOffsetNumericUpDown.Name = "IfdOffsetNumericUpDown";
            this.IfdOffsetNumericUpDown.Size = new System.Drawing.Size(77, 20);
            this.IfdOffsetNumericUpDown.TabIndex = 1;
            // 
            // IfdOffsetLabel
            // 
            this.IfdOffsetLabel.AutoSize = true;
            this.IfdOffsetLabel.Location = new System.Drawing.Point(29, 25);
            this.IfdOffsetLabel.Name = "IfdOffsetLabel";
            this.IfdOffsetLabel.Size = new System.Drawing.Size(58, 13);
            this.IfdOffsetLabel.TabIndex = 0;
            this.IfdOffsetLabel.Text = "IFD Offset:";
            // 
            // OpenOptionsTiffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 263);
            this.Controls.Add(this.TiffGroupBox);
            this.Name = "OpenOptionsTiffForm";
            this.Text = "Open Options - TIFF";
            this.Load += new System.EventHandler(this.OpenOptionsTiffForm_Load);
            this.Controls.SetChildIndex(this.RotationLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetNumericUpDown, 0);
            this.Controls.SetChildIndex(this.TiffGroupBox, 0);
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
            this.TiffGroupBox.ResumeLayout(false);
            this.TiffGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IfdOffsetNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TiffGroupBox;
        private System.Windows.Forms.CheckBox SpecialHandlingCheckBox;
        private System.Windows.Forms.NumericUpDown IfdOffsetNumericUpDown;
        private System.Windows.Forms.Label IfdOffsetLabel;
    }
}