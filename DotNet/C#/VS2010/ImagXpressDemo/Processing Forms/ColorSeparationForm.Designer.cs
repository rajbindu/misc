namespace ImagXpressDemo
{
    partial class ColorSeparationForm
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
            DisposeOfOutputBitmaps(null);
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
            this.RgbaGroupBox = new System.Windows.Forms.GroupBox();
            this.AlphaRgbaRadioButton = new System.Windows.Forms.RadioButton();
            this.BlueRgbaRadioButton = new System.Windows.Forms.RadioButton();
            this.GreenRgbaRadioButton = new System.Windows.Forms.RadioButton();
            this.RedRgbaRadioButton = new System.Windows.Forms.RadioButton();
            this.CmykGroupBox = new System.Windows.Forms.GroupBox();
            this.BlackCmykRadioButton = new System.Windows.Forms.RadioButton();
            this.YellowCmykRadioButton = new System.Windows.Forms.RadioButton();
            this.MagentaCmykRadioButton = new System.Windows.Forms.RadioButton();
            this.CyanCmykRadioButton = new System.Windows.Forms.RadioButton();
            this.HslGroupBox = new System.Windows.Forms.GroupBox();
            this.LuminanceRadioButton = new System.Windows.Forms.RadioButton();
            this.HueRadioButton = new System.Windows.Forms.RadioButton();
            this.SaturationRadioButton = new System.Windows.Forms.RadioButton();
            this.SeparationTypeLabel = new System.Windows.Forms.Label();
            this.SeparationTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CmyGroupBox = new System.Windows.Forms.GroupBox();
            this.YellowCmyRadioButton = new System.Windows.Forms.RadioButton();
            this.MagentaCmyRadioButton = new System.Windows.Forms.RadioButton();
            this.CyanCmyRadioButton = new System.Windows.Forms.RadioButton();
            this.RgbGroupBox = new System.Windows.Forms.GroupBox();
            this.BlueRgbRadioButton = new System.Windows.Forms.RadioButton();
            this.GreenRgbRadioButton = new System.Windows.Forms.RadioButton();
            this.RedRgbRadioButton = new System.Windows.Forms.RadioButton();
            this.RgbaGroupBox.SuspendLayout();
            this.CmykGroupBox.SuspendLayout();
            this.HslGroupBox.SuspendLayout();
            this.CmyGroupBox.SuspendLayout();
            this.RgbGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(373, 621);
            this.PreviewButton.TabIndex = 10;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(13, 621);
            this.OKButton.TabIndex = 9;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(653, 621);
            this.CancelProcessingButton.TabIndex = 11;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.Location = new System.Drawing.Point(592, 454);
            this.RightClickLabel.TabIndex = 12;
            // 
            // RgbaGroupBox
            // 
            this.RgbaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RgbaGroupBox.Controls.Add(this.AlphaRgbaRadioButton);
            this.RgbaGroupBox.Controls.Add(this.BlueRgbaRadioButton);
            this.RgbaGroupBox.Controls.Add(this.GreenRgbaRadioButton);
            this.RgbaGroupBox.Controls.Add(this.RedRgbaRadioButton);
            this.RgbaGroupBox.Location = new System.Drawing.Point(15, 469);
            this.RgbaGroupBox.Name = "RgbaGroupBox";
            this.RgbaGroupBox.Size = new System.Drawing.Size(97, 146);
            this.RgbaGroupBox.TabIndex = 4;
            this.RgbaGroupBox.TabStop = false;
            this.RgbaGroupBox.Text = "RGBA";
            this.RgbaGroupBox.Visible = false;
            // 
            // AlphaRgbaRadioButton
            // 
            this.AlphaRgbaRadioButton.AutoSize = true;
            this.AlphaRgbaRadioButton.Location = new System.Drawing.Point(15, 118);
            this.AlphaRgbaRadioButton.Name = "AlphaRgbaRadioButton";
            this.AlphaRgbaRadioButton.Size = new System.Drawing.Size(52, 17);
            this.AlphaRgbaRadioButton.TabIndex = 3;
            this.AlphaRgbaRadioButton.TabStop = true;
            this.AlphaRgbaRadioButton.Text = "Alpha";
            this.AlphaRgbaRadioButton.UseVisualStyleBackColor = true;
            // 
            // BlueRgbaRadioButton
            // 
            this.BlueRgbaRadioButton.AutoSize = true;
            this.BlueRgbaRadioButton.Location = new System.Drawing.Point(15, 85);
            this.BlueRgbaRadioButton.Name = "BlueRgbaRadioButton";
            this.BlueRgbaRadioButton.Size = new System.Drawing.Size(46, 17);
            this.BlueRgbaRadioButton.TabIndex = 2;
            this.BlueRgbaRadioButton.TabStop = true;
            this.BlueRgbaRadioButton.Text = "Blue";
            this.BlueRgbaRadioButton.UseVisualStyleBackColor = true;
            // 
            // GreenRgbaRadioButton
            // 
            this.GreenRgbaRadioButton.AutoSize = true;
            this.GreenRgbaRadioButton.Location = new System.Drawing.Point(15, 52);
            this.GreenRgbaRadioButton.Name = "GreenRgbaRadioButton";
            this.GreenRgbaRadioButton.Size = new System.Drawing.Size(54, 17);
            this.GreenRgbaRadioButton.TabIndex = 1;
            this.GreenRgbaRadioButton.TabStop = true;
            this.GreenRgbaRadioButton.Text = "Green";
            this.GreenRgbaRadioButton.UseVisualStyleBackColor = true;
            // 
            // RedRgbaRadioButton
            // 
            this.RedRgbaRadioButton.AutoSize = true;
            this.RedRgbaRadioButton.Location = new System.Drawing.Point(15, 19);
            this.RedRgbaRadioButton.Name = "RedRgbaRadioButton";
            this.RedRgbaRadioButton.Size = new System.Drawing.Size(45, 17);
            this.RedRgbaRadioButton.TabIndex = 0;
            this.RedRgbaRadioButton.TabStop = true;
            this.RedRgbaRadioButton.Text = "Red";
            this.RedRgbaRadioButton.UseVisualStyleBackColor = true;
            // 
            // CmykGroupBox
            // 
            this.CmykGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmykGroupBox.Controls.Add(this.BlackCmykRadioButton);
            this.CmykGroupBox.Controls.Add(this.YellowCmykRadioButton);
            this.CmykGroupBox.Controls.Add(this.MagentaCmykRadioButton);
            this.CmykGroupBox.Controls.Add(this.CyanCmykRadioButton);
            this.CmykGroupBox.Location = new System.Drawing.Point(221, 469);
            this.CmykGroupBox.Name = "CmykGroupBox";
            this.CmykGroupBox.Size = new System.Drawing.Size(97, 146);
            this.CmykGroupBox.TabIndex = 6;
            this.CmykGroupBox.TabStop = false;
            this.CmykGroupBox.Text = "CMYK";
            this.CmykGroupBox.Visible = false;
            // 
            // BlackCmykRadioButton
            // 
            this.BlackCmykRadioButton.AutoSize = true;
            this.BlackCmykRadioButton.Location = new System.Drawing.Point(15, 118);
            this.BlackCmykRadioButton.Name = "BlackCmykRadioButton";
            this.BlackCmykRadioButton.Size = new System.Drawing.Size(52, 17);
            this.BlackCmykRadioButton.TabIndex = 3;
            this.BlackCmykRadioButton.TabStop = true;
            this.BlackCmykRadioButton.Text = "Black";
            this.BlackCmykRadioButton.UseVisualStyleBackColor = true;
            // 
            // YellowCmykRadioButton
            // 
            this.YellowCmykRadioButton.AutoSize = true;
            this.YellowCmykRadioButton.Location = new System.Drawing.Point(15, 85);
            this.YellowCmykRadioButton.Name = "YellowCmykRadioButton";
            this.YellowCmykRadioButton.Size = new System.Drawing.Size(56, 17);
            this.YellowCmykRadioButton.TabIndex = 2;
            this.YellowCmykRadioButton.TabStop = true;
            this.YellowCmykRadioButton.Text = "Yellow";
            this.YellowCmykRadioButton.UseVisualStyleBackColor = true;
            // 
            // MagentaCmykRadioButton
            // 
            this.MagentaCmykRadioButton.AutoSize = true;
            this.MagentaCmykRadioButton.Location = new System.Drawing.Point(15, 52);
            this.MagentaCmykRadioButton.Name = "MagentaCmykRadioButton";
            this.MagentaCmykRadioButton.Size = new System.Drawing.Size(67, 17);
            this.MagentaCmykRadioButton.TabIndex = 1;
            this.MagentaCmykRadioButton.TabStop = true;
            this.MagentaCmykRadioButton.Text = "Magenta";
            this.MagentaCmykRadioButton.UseVisualStyleBackColor = true;
            // 
            // CyanCmykRadioButton
            // 
            this.CyanCmykRadioButton.AutoSize = true;
            this.CyanCmykRadioButton.Location = new System.Drawing.Point(15, 19);
            this.CyanCmykRadioButton.Name = "CyanCmykRadioButton";
            this.CyanCmykRadioButton.Size = new System.Drawing.Size(49, 17);
            this.CyanCmykRadioButton.TabIndex = 0;
            this.CyanCmykRadioButton.TabStop = true;
            this.CyanCmykRadioButton.Text = "Cyan";
            this.CyanCmykRadioButton.UseVisualStyleBackColor = true;
            // 
            // HslGroupBox
            // 
            this.HslGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HslGroupBox.Controls.Add(this.LuminanceRadioButton);
            this.HslGroupBox.Controls.Add(this.HueRadioButton);
            this.HslGroupBox.Controls.Add(this.SaturationRadioButton);
            this.HslGroupBox.Location = new System.Drawing.Point(324, 469);
            this.HslGroupBox.Name = "HslGroupBox";
            this.HslGroupBox.Size = new System.Drawing.Size(97, 127);
            this.HslGroupBox.TabIndex = 7;
            this.HslGroupBox.TabStop = false;
            this.HslGroupBox.Text = "HSL";
            this.HslGroupBox.Visible = false;
            // 
            // LuminanceRadioButton
            // 
            this.LuminanceRadioButton.AutoSize = true;
            this.LuminanceRadioButton.Location = new System.Drawing.Point(16, 85);
            this.LuminanceRadioButton.Name = "LuminanceRadioButton";
            this.LuminanceRadioButton.Size = new System.Drawing.Size(77, 17);
            this.LuminanceRadioButton.TabIndex = 2;
            this.LuminanceRadioButton.TabStop = true;
            this.LuminanceRadioButton.Text = "Luminance";
            this.LuminanceRadioButton.UseVisualStyleBackColor = true;
            // 
            // HueRadioButton
            // 
            this.HueRadioButton.AutoSize = true;
            this.HueRadioButton.Location = new System.Drawing.Point(16, 19);
            this.HueRadioButton.Name = "HueRadioButton";
            this.HueRadioButton.Size = new System.Drawing.Size(45, 17);
            this.HueRadioButton.TabIndex = 0;
            this.HueRadioButton.TabStop = true;
            this.HueRadioButton.Text = "Hue";
            this.HueRadioButton.UseVisualStyleBackColor = true;
            // 
            // SaturationRadioButton
            // 
            this.SaturationRadioButton.AutoSize = true;
            this.SaturationRadioButton.Location = new System.Drawing.Point(16, 52);
            this.SaturationRadioButton.Name = "SaturationRadioButton";
            this.SaturationRadioButton.Size = new System.Drawing.Size(73, 17);
            this.SaturationRadioButton.TabIndex = 1;
            this.SaturationRadioButton.TabStop = true;
            this.SaturationRadioButton.Text = "Saturation";
            this.SaturationRadioButton.UseVisualStyleBackColor = true;
            // 
            // SeparationTypeLabel
            // 
            this.SeparationTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SeparationTypeLabel.AutoSize = true;
            this.SeparationTypeLabel.Location = new System.Drawing.Point(12, 446);
            this.SeparationTypeLabel.Name = "SeparationTypeLabel";
            this.SeparationTypeLabel.Size = new System.Drawing.Size(34, 13);
            this.SeparationTypeLabel.TabIndex = 2;
            this.SeparationTypeLabel.Text = "Type:";
            // 
            // SeparationTypeComboBox
            // 
            this.SeparationTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SeparationTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeparationTypeComboBox.FormattingEnabled = true;
            this.SeparationTypeComboBox.Items.AddRange(new object[] {
            "RGB",
            "HSL",
            "CMY",
            "CMYK",
            "RGBA"});
            this.SeparationTypeComboBox.Location = new System.Drawing.Point(53, 442);
            this.SeparationTypeComboBox.Name = "SeparationTypeComboBox";
            this.SeparationTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.SeparationTypeComboBox.TabIndex = 3;
            this.SeparationTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.SeparationTypeComboBox_SelectedIndexChanged);
            // 
            // CmyGroupBox
            // 
            this.CmyGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmyGroupBox.Controls.Add(this.YellowCmyRadioButton);
            this.CmyGroupBox.Controls.Add(this.MagentaCmyRadioButton);
            this.CmyGroupBox.Controls.Add(this.CyanCmyRadioButton);
            this.CmyGroupBox.Location = new System.Drawing.Point(118, 469);
            this.CmyGroupBox.Name = "CmyGroupBox";
            this.CmyGroupBox.Size = new System.Drawing.Size(97, 127);
            this.CmyGroupBox.TabIndex = 5;
            this.CmyGroupBox.TabStop = false;
            this.CmyGroupBox.Text = "CMY";
            this.CmyGroupBox.Visible = false;
            // 
            // YellowCmyRadioButton
            // 
            this.YellowCmyRadioButton.AutoSize = true;
            this.YellowCmyRadioButton.Location = new System.Drawing.Point(15, 85);
            this.YellowCmyRadioButton.Name = "YellowCmyRadioButton";
            this.YellowCmyRadioButton.Size = new System.Drawing.Size(56, 17);
            this.YellowCmyRadioButton.TabIndex = 2;
            this.YellowCmyRadioButton.TabStop = true;
            this.YellowCmyRadioButton.Text = "Yellow";
            this.YellowCmyRadioButton.UseVisualStyleBackColor = true;
            // 
            // MagentaCmyRadioButton
            // 
            this.MagentaCmyRadioButton.AutoSize = true;
            this.MagentaCmyRadioButton.Location = new System.Drawing.Point(15, 52);
            this.MagentaCmyRadioButton.Name = "MagentaCmyRadioButton";
            this.MagentaCmyRadioButton.Size = new System.Drawing.Size(67, 17);
            this.MagentaCmyRadioButton.TabIndex = 1;
            this.MagentaCmyRadioButton.TabStop = true;
            this.MagentaCmyRadioButton.Text = "Magenta";
            this.MagentaCmyRadioButton.UseVisualStyleBackColor = true;
            // 
            // CyanCmyRadioButton
            // 
            this.CyanCmyRadioButton.AutoSize = true;
            this.CyanCmyRadioButton.Location = new System.Drawing.Point(15, 19);
            this.CyanCmyRadioButton.Name = "CyanCmyRadioButton";
            this.CyanCmyRadioButton.Size = new System.Drawing.Size(49, 17);
            this.CyanCmyRadioButton.TabIndex = 0;
            this.CyanCmyRadioButton.TabStop = true;
            this.CyanCmyRadioButton.Text = "Cyan";
            this.CyanCmyRadioButton.UseVisualStyleBackColor = true;
            // 
            // RgbGroupBox
            // 
            this.RgbGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RgbGroupBox.Controls.Add(this.BlueRgbRadioButton);
            this.RgbGroupBox.Controls.Add(this.GreenRgbRadioButton);
            this.RgbGroupBox.Controls.Add(this.RedRgbRadioButton);
            this.RgbGroupBox.Location = new System.Drawing.Point(427, 469);
            this.RgbGroupBox.Name = "RgbGroupBox";
            this.RgbGroupBox.Size = new System.Drawing.Size(97, 127);
            this.RgbGroupBox.TabIndex = 8;
            this.RgbGroupBox.TabStop = false;
            this.RgbGroupBox.Text = "RGB";
            this.RgbGroupBox.Visible = false;
            // 
            // BlueRgbRadioButton
            // 
            this.BlueRgbRadioButton.AutoSize = true;
            this.BlueRgbRadioButton.Location = new System.Drawing.Point(15, 85);
            this.BlueRgbRadioButton.Name = "BlueRgbRadioButton";
            this.BlueRgbRadioButton.Size = new System.Drawing.Size(46, 17);
            this.BlueRgbRadioButton.TabIndex = 2;
            this.BlueRgbRadioButton.TabStop = true;
            this.BlueRgbRadioButton.Text = "Blue";
            this.BlueRgbRadioButton.UseVisualStyleBackColor = true;
            // 
            // GreenRgbRadioButton
            // 
            this.GreenRgbRadioButton.AutoSize = true;
            this.GreenRgbRadioButton.Location = new System.Drawing.Point(15, 52);
            this.GreenRgbRadioButton.Name = "GreenRgbRadioButton";
            this.GreenRgbRadioButton.Size = new System.Drawing.Size(54, 17);
            this.GreenRgbRadioButton.TabIndex = 1;
            this.GreenRgbRadioButton.TabStop = true;
            this.GreenRgbRadioButton.Text = "Green";
            this.GreenRgbRadioButton.UseVisualStyleBackColor = true;
            // 
            // RedRgbRadioButton
            // 
            this.RedRgbRadioButton.AutoSize = true;
            this.RedRgbRadioButton.Location = new System.Drawing.Point(15, 19);
            this.RedRgbRadioButton.Name = "RedRgbRadioButton";
            this.RedRgbRadioButton.Size = new System.Drawing.Size(45, 17);
            this.RedRgbRadioButton.TabIndex = 0;
            this.RedRgbRadioButton.TabStop = true;
            this.RedRgbRadioButton.Text = "Red";
            this.RedRgbRadioButton.UseVisualStyleBackColor = true;
            // 
            // ColorSeparationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 656);
            this.Controls.Add(this.RgbGroupBox);
            this.Controls.Add(this.CmyGroupBox);
            this.Controls.Add(this.SeparationTypeLabel);
            this.Controls.Add(this.CmykGroupBox);
            this.Controls.Add(this.HslGroupBox);
            this.Controls.Add(this.RgbaGroupBox);
            this.Controls.Add(this.SeparationTypeComboBox);
            this.Name = "ColorSeparationForm";
            this.Text = "Color Separation";
            this.Load += new System.EventHandler(this.ColorSeparationForm_Load);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.Controls.SetChildIndex(this.SeparationTypeComboBox, 0);
            this.Controls.SetChildIndex(this.RgbaGroupBox, 0);
            this.Controls.SetChildIndex(this.HslGroupBox, 0);
            this.Controls.SetChildIndex(this.CmykGroupBox, 0);
            this.Controls.SetChildIndex(this.SeparationTypeLabel, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.CmyGroupBox, 0);
            this.Controls.SetChildIndex(this.RgbGroupBox, 0);
            this.RgbaGroupBox.ResumeLayout(false);
            this.RgbaGroupBox.PerformLayout();
            this.CmykGroupBox.ResumeLayout(false);
            this.CmykGroupBox.PerformLayout();
            this.HslGroupBox.ResumeLayout(false);
            this.HslGroupBox.PerformLayout();
            this.CmyGroupBox.ResumeLayout(false);
            this.CmyGroupBox.PerformLayout();
            this.RgbGroupBox.ResumeLayout(false);
            this.RgbGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RgbaGroupBox;
        private System.Windows.Forms.RadioButton AlphaRgbaRadioButton;
        private System.Windows.Forms.RadioButton BlueRgbaRadioButton;
        private System.Windows.Forms.RadioButton GreenRgbaRadioButton;
        private System.Windows.Forms.RadioButton RedRgbaRadioButton;
        private System.Windows.Forms.GroupBox CmykGroupBox;
        private System.Windows.Forms.RadioButton BlackCmykRadioButton;
        private System.Windows.Forms.RadioButton YellowCmykRadioButton;
        private System.Windows.Forms.RadioButton MagentaCmykRadioButton;
        private System.Windows.Forms.RadioButton CyanCmykRadioButton;
        private System.Windows.Forms.GroupBox HslGroupBox;
        private System.Windows.Forms.RadioButton LuminanceRadioButton;
        private System.Windows.Forms.RadioButton HueRadioButton;
        private System.Windows.Forms.RadioButton SaturationRadioButton;
        private System.Windows.Forms.Label SeparationTypeLabel;
        private System.Windows.Forms.ComboBox SeparationTypeComboBox;
        private System.Windows.Forms.GroupBox CmyGroupBox;
        private System.Windows.Forms.RadioButton YellowCmyRadioButton;
        private System.Windows.Forms.RadioButton MagentaCmyRadioButton;
        private System.Windows.Forms.RadioButton CyanCmyRadioButton;
        private System.Windows.Forms.GroupBox RgbGroupBox;
        private System.Windows.Forms.RadioButton BlueRgbRadioButton;
        private System.Windows.Forms.RadioButton GreenRgbRadioButton;
        private System.Windows.Forms.RadioButton RedRgbRadioButton;
    }
}