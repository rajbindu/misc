namespace ImagXpressDemo
{
    partial class OpenOptionsCameraRawForm
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
            this.CameraRawGroupBox = new System.Windows.Forms.GroupBox();
            this.BrightnessCheckBox = new System.Windows.Forms.CheckBox();
            this.RedFactorCheckBox = new System.Windows.Forms.CheckBox();
            this.BlueFactorCheckBox = new System.Windows.Forms.CheckBox();
            this.WhiteBalanceMethodComboBox = new System.Windows.Forms.ComboBox();
            this.WhiteBalanceMethodLabel = new System.Windows.Forms.Label();
            this.UseHalfSizeImageCheckBox = new System.Windows.Forms.CheckBox();
            this.UseSecondaryPixelsCheckBox = new System.Windows.Forms.CheckBox();
            this.UseFastInterpolationMethodCheckBox = new System.Windows.Forms.CheckBox();
            this.ReturnThumbnailCheckBox = new System.Windows.Forms.CheckBox();
            this.GammaCorrectionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GammaCorrectionLabel = new System.Windows.Forms.Label();
            this.RemoveRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.ConvertTosRGBCheckBox = new System.Windows.Forms.CheckBox();
            this.ClipHighlightsToWhiteCheckBox = new System.Windows.Forms.CheckBox();
            this.BrightnessFactorLabel = new System.Windows.Forms.Label();
            this.BrightnessFactorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RedFactorLabel = new System.Windows.Forms.Label();
            this.RedFactorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BlueFactorLabel = new System.Windows.Forms.Label();
            this.BlueFactorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AutoBrightnessAndContrastCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).BeginInit();
            this.CameraRawGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GammaCorrectionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessFactorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedFactorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueFactorNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.TabIndex = 11;
            // 
            // CancelOptionsButton
            // 
            this.CancelOptionsButton.TabIndex = 0;
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
            // CameraRawGroupBox
            // 
            this.CameraRawGroupBox.Controls.Add(this.BrightnessCheckBox);
            this.CameraRawGroupBox.Controls.Add(this.RedFactorCheckBox);
            this.CameraRawGroupBox.Controls.Add(this.BlueFactorCheckBox);
            this.CameraRawGroupBox.Controls.Add(this.WhiteBalanceMethodComboBox);
            this.CameraRawGroupBox.Controls.Add(this.WhiteBalanceMethodLabel);
            this.CameraRawGroupBox.Controls.Add(this.UseHalfSizeImageCheckBox);
            this.CameraRawGroupBox.Controls.Add(this.UseSecondaryPixelsCheckBox);
            this.CameraRawGroupBox.Controls.Add(this.UseFastInterpolationMethodCheckBox);
            this.CameraRawGroupBox.Controls.Add(this.ReturnThumbnailCheckBox);
            this.CameraRawGroupBox.Controls.Add(this.GammaCorrectionNumericUpDown);
            this.CameraRawGroupBox.Controls.Add(this.GammaCorrectionLabel);
            this.CameraRawGroupBox.Controls.Add(this.RemoveRotationCheckBox);
            this.CameraRawGroupBox.Controls.Add(this.ConvertTosRGBCheckBox);
            this.CameraRawGroupBox.Controls.Add(this.ClipHighlightsToWhiteCheckBox);
            this.CameraRawGroupBox.Controls.Add(this.BrightnessFactorLabel);
            this.CameraRawGroupBox.Controls.Add(this.BrightnessFactorNumericUpDown);
            this.CameraRawGroupBox.Controls.Add(this.RedFactorLabel);
            this.CameraRawGroupBox.Controls.Add(this.RedFactorNumericUpDown);
            this.CameraRawGroupBox.Controls.Add(this.BlueFactorLabel);
            this.CameraRawGroupBox.Controls.Add(this.BlueFactorNumericUpDown);
            this.CameraRawGroupBox.Controls.Add(this.AutoBrightnessAndContrastCheckBox);
            this.CameraRawGroupBox.Location = new System.Drawing.Point(9, 200);
            this.CameraRawGroupBox.Name = "CameraRawGroupBox";
            this.CameraRawGroupBox.Size = new System.Drawing.Size(387, 214);
            this.CameraRawGroupBox.TabIndex = 10;
            this.CameraRawGroupBox.TabStop = false;
            this.CameraRawGroupBox.Text = "Camera Raw";
            // 
            // BrightnessCheckBox
            // 
            this.BrightnessCheckBox.AutoSize = true;
            this.BrightnessCheckBox.Location = new System.Drawing.Point(7, 75);
            this.BrightnessCheckBox.Name = "BrightnessCheckBox";
            this.BrightnessCheckBox.Size = new System.Drawing.Size(15, 14);
            this.BrightnessCheckBox.TabIndex = 19;
            this.BrightnessCheckBox.UseVisualStyleBackColor = true;
            this.BrightnessCheckBox.CheckedChanged += new System.EventHandler(this.BrightnessCheckBox_CheckedChanged);
            // 
            // RedFactorCheckBox
            // 
            this.RedFactorCheckBox.AutoSize = true;
            this.RedFactorCheckBox.Location = new System.Drawing.Point(7, 51);
            this.RedFactorCheckBox.Name = "RedFactorCheckBox";
            this.RedFactorCheckBox.Size = new System.Drawing.Size(15, 14);
            this.RedFactorCheckBox.TabIndex = 18;
            this.RedFactorCheckBox.UseVisualStyleBackColor = true;
            this.RedFactorCheckBox.CheckedChanged += new System.EventHandler(this.RedFactorCheckBox_CheckedChanged);
            // 
            // BlueFactorCheckBox
            // 
            this.BlueFactorCheckBox.AutoSize = true;
            this.BlueFactorCheckBox.Location = new System.Drawing.Point(7, 27);
            this.BlueFactorCheckBox.Name = "BlueFactorCheckBox";
            this.BlueFactorCheckBox.Size = new System.Drawing.Size(15, 14);
            this.BlueFactorCheckBox.TabIndex = 17;
            this.BlueFactorCheckBox.UseVisualStyleBackColor = true;
            this.BlueFactorCheckBox.CheckedChanged += new System.EventHandler(this.BlueFactorCheckBox_CheckedChanged);
            // 
            // WhiteBalanceMethodComboBox
            // 
            this.WhiteBalanceMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WhiteBalanceMethodComboBox.FormattingEnabled = true;
            this.WhiteBalanceMethodComboBox.Items.AddRange(new object[] {
            "Camera",
            "Auto",
            "Manual"});
            this.WhiteBalanceMethodComboBox.Location = new System.Drawing.Point(25, 144);
            this.WhiteBalanceMethodComboBox.Name = "WhiteBalanceMethodComboBox";
            this.WhiteBalanceMethodComboBox.Size = new System.Drawing.Size(121, 21);
            this.WhiteBalanceMethodComboBox.TabIndex = 13;
            // 
            // WhiteBalanceMethodLabel
            // 
            this.WhiteBalanceMethodLabel.AutoSize = true;
            this.WhiteBalanceMethodLabel.Location = new System.Drawing.Point(22, 125);
            this.WhiteBalanceMethodLabel.Name = "WhiteBalanceMethodLabel";
            this.WhiteBalanceMethodLabel.Size = new System.Drawing.Size(119, 13);
            this.WhiteBalanceMethodLabel.TabIndex = 11;
            this.WhiteBalanceMethodLabel.Text = "White Balance Method:";
            // 
            // UseHalfSizeImageCheckBox
            // 
            this.UseHalfSizeImageCheckBox.AutoSize = true;
            this.UseHalfSizeImageCheckBox.Location = new System.Drawing.Point(213, 169);
            this.UseHalfSizeImageCheckBox.Name = "UseHalfSizeImageCheckBox";
            this.UseHalfSizeImageCheckBox.Size = new System.Drawing.Size(122, 17);
            this.UseHalfSizeImageCheckBox.TabIndex = 15;
            this.UseHalfSizeImageCheckBox.Text = "Use Half Size Image";
            this.UseHalfSizeImageCheckBox.UseVisualStyleBackColor = true;
            // 
            // UseSecondaryPixelsCheckBox
            // 
            this.UseSecondaryPixelsCheckBox.AutoSize = true;
            this.UseSecondaryPixelsCheckBox.Location = new System.Drawing.Point(213, 194);
            this.UseSecondaryPixelsCheckBox.Name = "UseSecondaryPixelsCheckBox";
            this.UseSecondaryPixelsCheckBox.Size = new System.Drawing.Size(129, 17);
            this.UseSecondaryPixelsCheckBox.TabIndex = 16;
            this.UseSecondaryPixelsCheckBox.Text = "Use Secondary Pixels";
            this.UseSecondaryPixelsCheckBox.UseVisualStyleBackColor = true;
            // 
            // UseFastInterpolationMethodCheckBox
            // 
            this.UseFastInterpolationMethodCheckBox.AutoSize = true;
            this.UseFastInterpolationMethodCheckBox.Location = new System.Drawing.Point(213, 144);
            this.UseFastInterpolationMethodCheckBox.Name = "UseFastInterpolationMethodCheckBox";
            this.UseFastInterpolationMethodCheckBox.Size = new System.Drawing.Size(168, 17);
            this.UseFastInterpolationMethodCheckBox.TabIndex = 14;
            this.UseFastInterpolationMethodCheckBox.Text = "Use Fast Interpolation Method";
            this.UseFastInterpolationMethodCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReturnThumbnailCheckBox
            // 
            this.ReturnThumbnailCheckBox.AutoSize = true;
            this.ReturnThumbnailCheckBox.Location = new System.Drawing.Point(213, 119);
            this.ReturnThumbnailCheckBox.Name = "ReturnThumbnailCheckBox";
            this.ReturnThumbnailCheckBox.Size = new System.Drawing.Size(110, 17);
            this.ReturnThumbnailCheckBox.TabIndex = 12;
            this.ReturnThumbnailCheckBox.Text = "Return Thumbnail";
            this.ReturnThumbnailCheckBox.UseVisualStyleBackColor = true;
            // 
            // GammaCorrectionNumericUpDown
            // 
            this.GammaCorrectionNumericUpDown.DecimalPlaces = 2;
            this.GammaCorrectionNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.GammaCorrectionNumericUpDown.Location = new System.Drawing.Point(145, 92);
            this.GammaCorrectionNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.GammaCorrectionNumericUpDown.Name = "GammaCorrectionNumericUpDown";
            this.GammaCorrectionNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.GammaCorrectionNumericUpDown.TabIndex = 9;
            // 
            // GammaCorrectionLabel
            // 
            this.GammaCorrectionLabel.AutoSize = true;
            this.GammaCorrectionLabel.Location = new System.Drawing.Point(22, 99);
            this.GammaCorrectionLabel.Name = "GammaCorrectionLabel";
            this.GammaCorrectionLabel.Size = new System.Drawing.Size(97, 13);
            this.GammaCorrectionLabel.TabIndex = 8;
            this.GammaCorrectionLabel.Text = "Gamma Correction:";
            // 
            // RemoveRotationCheckBox
            // 
            this.RemoveRotationCheckBox.AutoSize = true;
            this.RemoveRotationCheckBox.Location = new System.Drawing.Point(213, 96);
            this.RemoveRotationCheckBox.Name = "RemoveRotationCheckBox";
            this.RemoveRotationCheckBox.Size = new System.Drawing.Size(109, 17);
            this.RemoveRotationCheckBox.TabIndex = 10;
            this.RemoveRotationCheckBox.Text = "Remove Rotation";
            this.RemoveRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConvertTosRGBCheckBox
            // 
            this.ConvertTosRGBCheckBox.AutoSize = true;
            this.ConvertTosRGBCheckBox.Location = new System.Drawing.Point(213, 71);
            this.ConvertTosRGBCheckBox.Name = "ConvertTosRGBCheckBox";
            this.ConvertTosRGBCheckBox.Size = new System.Drawing.Size(110, 17);
            this.ConvertTosRGBCheckBox.TabIndex = 7;
            this.ConvertTosRGBCheckBox.Text = "Convert To sRGB";
            this.ConvertTosRGBCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClipHighlightsToWhiteCheckBox
            // 
            this.ClipHighlightsToWhiteCheckBox.AutoSize = true;
            this.ClipHighlightsToWhiteCheckBox.Location = new System.Drawing.Point(213, 46);
            this.ClipHighlightsToWhiteCheckBox.Name = "ClipHighlightsToWhiteCheckBox";
            this.ClipHighlightsToWhiteCheckBox.Size = new System.Drawing.Size(135, 17);
            this.ClipHighlightsToWhiteCheckBox.TabIndex = 4;
            this.ClipHighlightsToWhiteCheckBox.Text = "Clip Highlights to White";
            this.ClipHighlightsToWhiteCheckBox.UseVisualStyleBackColor = true;
            // 
            // BrightnessFactorLabel
            // 
            this.BrightnessFactorLabel.AutoSize = true;
            this.BrightnessFactorLabel.Location = new System.Drawing.Point(22, 75);
            this.BrightnessFactorLabel.Name = "BrightnessFactorLabel";
            this.BrightnessFactorLabel.Size = new System.Drawing.Size(92, 13);
            this.BrightnessFactorLabel.TabIndex = 5;
            this.BrightnessFactorLabel.Text = "Brightness Factor:";
            this.BrightnessFactorLabel.Click += new System.EventHandler(this.BrightnessFactorLabel_Click);
            // 
            // BrightnessFactorNumericUpDown
            // 
            this.BrightnessFactorNumericUpDown.DecimalPlaces = 2;
            this.BrightnessFactorNumericUpDown.Enabled = false;
            this.BrightnessFactorNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.BrightnessFactorNumericUpDown.Location = new System.Drawing.Point(145, 68);
            this.BrightnessFactorNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.BrightnessFactorNumericUpDown.Name = "BrightnessFactorNumericUpDown";
            this.BrightnessFactorNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.BrightnessFactorNumericUpDown.TabIndex = 6;
            this.BrightnessFactorNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // RedFactorLabel
            // 
            this.RedFactorLabel.AutoSize = true;
            this.RedFactorLabel.Location = new System.Drawing.Point(22, 51);
            this.RedFactorLabel.Name = "RedFactorLabel";
            this.RedFactorLabel.Size = new System.Drawing.Size(63, 13);
            this.RedFactorLabel.TabIndex = 3;
            this.RedFactorLabel.Text = "Red Factor:";
            this.RedFactorLabel.Click += new System.EventHandler(this.RedFactorLabel_Click);
            // 
            // RedFactorNumericUpDown
            // 
            this.RedFactorNumericUpDown.DecimalPlaces = 2;
            this.RedFactorNumericUpDown.Enabled = false;
            this.RedFactorNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.RedFactorNumericUpDown.Location = new System.Drawing.Point(145, 44);
            this.RedFactorNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.RedFactorNumericUpDown.Name = "RedFactorNumericUpDown";
            this.RedFactorNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.RedFactorNumericUpDown.TabIndex = 3;
            this.RedFactorNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // BlueFactorLabel
            // 
            this.BlueFactorLabel.AutoSize = true;
            this.BlueFactorLabel.Location = new System.Drawing.Point(22, 27);
            this.BlueFactorLabel.Name = "BlueFactorLabel";
            this.BlueFactorLabel.Size = new System.Drawing.Size(64, 13);
            this.BlueFactorLabel.TabIndex = 0;
            this.BlueFactorLabel.Text = "Blue Factor:";
            this.BlueFactorLabel.Click += new System.EventHandler(this.BlueFactorLabel_Click);
            // 
            // BlueFactorNumericUpDown
            // 
            this.BlueFactorNumericUpDown.DecimalPlaces = 2;
            this.BlueFactorNumericUpDown.Enabled = false;
            this.BlueFactorNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.BlueFactorNumericUpDown.Location = new System.Drawing.Point(145, 20);
            this.BlueFactorNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.BlueFactorNumericUpDown.Name = "BlueFactorNumericUpDown";
            this.BlueFactorNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.BlueFactorNumericUpDown.TabIndex = 1;
            this.BlueFactorNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // AutoBrightnessAndContrastCheckBox
            // 
            this.AutoBrightnessAndContrastCheckBox.AutoSize = true;
            this.AutoBrightnessAndContrastCheckBox.Location = new System.Drawing.Point(213, 21);
            this.AutoBrightnessAndContrastCheckBox.Name = "AutoBrightnessAndContrastCheckBox";
            this.AutoBrightnessAndContrastCheckBox.Size = new System.Drawing.Size(163, 17);
            this.AutoBrightnessAndContrastCheckBox.TabIndex = 2;
            this.AutoBrightnessAndContrastCheckBox.Text = "Auto Brightness and Contrast";
            this.AutoBrightnessAndContrastCheckBox.UseVisualStyleBackColor = true;
            // 
            // OpenOptionsCameraRawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 426);
            this.Controls.Add(this.CameraRawGroupBox);
            this.Name = "OpenOptionsCameraRawForm";
            this.Text = "Open Options - Camera Raw";
            this.Load += new System.EventHandler(this.OpenOptionsCameraRawForm_Load);
            this.Controls.SetChildIndex(this.RotationLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetNumericUpDown, 0);
            this.Controls.SetChildIndex(this.RotationComboBox, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CameraRawGroupBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).EndInit();
            this.CameraRawGroupBox.ResumeLayout(false);
            this.CameraRawGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GammaCorrectionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessFactorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedFactorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueFactorNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CameraRawGroupBox;
        private System.Windows.Forms.Label RedFactorLabel;
        private System.Windows.Forms.NumericUpDown RedFactorNumericUpDown;
        private System.Windows.Forms.Label BlueFactorLabel;
        private System.Windows.Forms.NumericUpDown BlueFactorNumericUpDown;
        private System.Windows.Forms.CheckBox AutoBrightnessAndContrastCheckBox;
        private System.Windows.Forms.CheckBox ConvertTosRGBCheckBox;
        private System.Windows.Forms.CheckBox ClipHighlightsToWhiteCheckBox;
        private System.Windows.Forms.Label BrightnessFactorLabel;
        private System.Windows.Forms.NumericUpDown BrightnessFactorNumericUpDown;
        private System.Windows.Forms.ComboBox WhiteBalanceMethodComboBox;
        private System.Windows.Forms.Label WhiteBalanceMethodLabel;
        private System.Windows.Forms.CheckBox UseHalfSizeImageCheckBox;
        private System.Windows.Forms.CheckBox UseSecondaryPixelsCheckBox;
        private System.Windows.Forms.CheckBox UseFastInterpolationMethodCheckBox;
        private System.Windows.Forms.CheckBox ReturnThumbnailCheckBox;
        private System.Windows.Forms.NumericUpDown GammaCorrectionNumericUpDown;
        private System.Windows.Forms.Label GammaCorrectionLabel;
        private System.Windows.Forms.CheckBox RemoveRotationCheckBox;
        private System.Windows.Forms.CheckBox BrightnessCheckBox;
        private System.Windows.Forms.CheckBox RedFactorCheckBox;
        private System.Windows.Forms.CheckBox BlueFactorCheckBox;
    }
}