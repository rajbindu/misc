namespace ImagXpressDemo
{
    partial class SaveOptionsJpegForm
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
            this.JpegGroupBox = new System.Windows.Forms.GroupBox();
            this.SubSamplingLabel = new System.Windows.Forms.Label();
            this.SubSamplingComboBox = new System.Windows.Forms.ComboBox();
            this.ProgressiveCheckBox = new System.Windows.Forms.CheckBox();
            this.GrayscaleCheckBox = new System.Windows.Forms.CheckBox();
            this.CositedCheckBox = new System.Windows.Forms.CheckBox();
            this.ColorSpaceLabel = new System.Windows.Forms.Label();
            this.ColorSpaceComboBox = new System.Windows.Forms.ComboBox();
            this.LuminanceLabel = new System.Windows.Forms.Label();
            this.LuminanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChrominanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChrominanceLabel = new System.Windows.Forms.Label();
            this.ColorRenderIntentLabel = new System.Windows.Forms.Label();
            this.TargetProfileNameBrowseButton = new System.Windows.Forms.Button();
            this.TargetProfileNameTextBox = new System.Windows.Forms.TextBox();
            this.TargetProfileNameLabel = new System.Windows.Forms.Label();
            this.ColorRenderIntentComboBox = new System.Windows.Forms.ComboBox();
            this.JpegGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuminanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChrominanceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.TabIndex = 6;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelOptionsButton
            // 
            this.CancelOptionsButton.TabIndex = 7;
            // 
            // JpegGroupBox
            // 
            this.JpegGroupBox.Controls.Add(this.SubSamplingLabel);
            this.JpegGroupBox.Controls.Add(this.SubSamplingComboBox);
            this.JpegGroupBox.Controls.Add(this.ProgressiveCheckBox);
            this.JpegGroupBox.Controls.Add(this.GrayscaleCheckBox);
            this.JpegGroupBox.Controls.Add(this.CositedCheckBox);
            this.JpegGroupBox.Controls.Add(this.ColorSpaceLabel);
            this.JpegGroupBox.Controls.Add(this.ColorSpaceComboBox);
            this.JpegGroupBox.Controls.Add(this.LuminanceLabel);
            this.JpegGroupBox.Controls.Add(this.LuminanceNumericUpDown);
            this.JpegGroupBox.Controls.Add(this.ChrominanceNumericUpDown);
            this.JpegGroupBox.Controls.Add(this.ChrominanceLabel);
            this.JpegGroupBox.Location = new System.Drawing.Point(11, 12);
            this.JpegGroupBox.Name = "JpegGroupBox";
            this.JpegGroupBox.Size = new System.Drawing.Size(341, 127);
            this.JpegGroupBox.TabIndex = 0;
            this.JpegGroupBox.TabStop = false;
            this.JpegGroupBox.Text = "JPEG";
            // 
            // SubSamplingLabel
            // 
            this.SubSamplingLabel.AutoSize = true;
            this.SubSamplingLabel.Location = new System.Drawing.Point(9, 16);
            this.SubSamplingLabel.Name = "SubSamplingLabel";
            this.SubSamplingLabel.Size = new System.Drawing.Size(72, 13);
            this.SubSamplingLabel.TabIndex = 0;
            this.SubSamplingLabel.Text = "SubSampling:";
            // 
            // SubSamplingComboBox
            // 
            this.SubSamplingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubSamplingComboBox.FormattingEnabled = true;
            this.SubSamplingComboBox.Items.AddRange(new object[] {
            "No subsampling (1:1:1)",
            "2 to 1 Horizontal (2:1:1)",
            "2 to 1 Horizontal & Vertical (4:1:1)",
            "2 to 1 Vertical (2:1:1)"});
            this.SubSamplingComboBox.Location = new System.Drawing.Point(90, 13);
            this.SubSamplingComboBox.Name = "SubSamplingComboBox";
            this.SubSamplingComboBox.Size = new System.Drawing.Size(240, 21);
            this.SubSamplingComboBox.TabIndex = 1;
            // 
            // ProgressiveCheckBox
            // 
            this.ProgressiveCheckBox.AutoSize = true;
            this.ProgressiveCheckBox.Location = new System.Drawing.Point(87, 193);
            this.ProgressiveCheckBox.Name = "ProgressiveCheckBox";
            this.ProgressiveCheckBox.Size = new System.Drawing.Size(81, 17);
            this.ProgressiveCheckBox.TabIndex = 10;
            this.ProgressiveCheckBox.Text = "Progressive";
            this.ProgressiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // GrayscaleCheckBox
            // 
            this.GrayscaleCheckBox.AutoSize = true;
            this.GrayscaleCheckBox.Location = new System.Drawing.Point(179, 67);
            this.GrayscaleCheckBox.Name = "GrayscaleCheckBox";
            this.GrayscaleCheckBox.Size = new System.Drawing.Size(73, 17);
            this.GrayscaleCheckBox.TabIndex = 7;
            this.GrayscaleCheckBox.Text = "Grayscale";
            this.GrayscaleCheckBox.UseVisualStyleBackColor = true;
            this.GrayscaleCheckBox.CheckedChanged += new System.EventHandler(this.GrayscaleCheckBox_CheckedChanged);
            // 
            // CositedCheckBox
            // 
            this.CositedCheckBox.AutoSize = true;
            this.CositedCheckBox.Location = new System.Drawing.Point(179, 44);
            this.CositedCheckBox.Name = "CositedCheckBox";
            this.CositedCheckBox.Size = new System.Drawing.Size(61, 17);
            this.CositedCheckBox.TabIndex = 4;
            this.CositedCheckBox.Text = "Cosited";
            this.CositedCheckBox.UseVisualStyleBackColor = true;
            // 
            // ColorSpaceLabel
            // 
            this.ColorSpaceLabel.AutoSize = true;
            this.ColorSpaceLabel.Location = new System.Drawing.Point(9, 94);
            this.ColorSpaceLabel.Name = "ColorSpaceLabel";
            this.ColorSpaceLabel.Size = new System.Drawing.Size(65, 13);
            this.ColorSpaceLabel.TabIndex = 8;
            this.ColorSpaceLabel.Text = "ColorSpace:";
            // 
            // ColorSpaceComboBox
            // 
            this.ColorSpaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorSpaceComboBox.FormattingEnabled = true;
            this.ColorSpaceComboBox.Items.AddRange(new object[] {
            "RGB",
            "CMYK"});
            this.ColorSpaceComboBox.Location = new System.Drawing.Point(90, 90);
            this.ColorSpaceComboBox.Name = "ColorSpaceComboBox";
            this.ColorSpaceComboBox.Size = new System.Drawing.Size(70, 21);
            this.ColorSpaceComboBox.TabIndex = 9;
            this.ColorSpaceComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorSpaceComboBox_SelectedIndexChanged);
            // 
            // LuminanceLabel
            // 
            this.LuminanceLabel.AutoSize = true;
            this.LuminanceLabel.Location = new System.Drawing.Point(9, 69);
            this.LuminanceLabel.Name = "LuminanceLabel";
            this.LuminanceLabel.Size = new System.Drawing.Size(62, 13);
            this.LuminanceLabel.TabIndex = 5;
            this.LuminanceLabel.Text = "Luminance:";
            // 
            // LuminanceNumericUpDown
            // 
            this.LuminanceNumericUpDown.Location = new System.Drawing.Point(90, 65);
            this.LuminanceNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LuminanceNumericUpDown.Name = "LuminanceNumericUpDown";
            this.LuminanceNumericUpDown.Size = new System.Drawing.Size(70, 20);
            this.LuminanceNumericUpDown.TabIndex = 6;
            // 
            // ChrominanceNumericUpDown
            // 
            this.ChrominanceNumericUpDown.Location = new System.Drawing.Point(90, 40);
            this.ChrominanceNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ChrominanceNumericUpDown.Name = "ChrominanceNumericUpDown";
            this.ChrominanceNumericUpDown.Size = new System.Drawing.Size(70, 20);
            this.ChrominanceNumericUpDown.TabIndex = 3;
            // 
            // ChrominanceLabel
            // 
            this.ChrominanceLabel.AutoSize = true;
            this.ChrominanceLabel.Location = new System.Drawing.Point(9, 44);
            this.ChrominanceLabel.Name = "ChrominanceLabel";
            this.ChrominanceLabel.Size = new System.Drawing.Size(72, 13);
            this.ChrominanceLabel.TabIndex = 2;
            this.ChrominanceLabel.Text = "Chrominance:";
            // 
            // ColorRenderIntentLabel
            // 
            this.ColorRenderIntentLabel.AutoSize = true;
            this.ColorRenderIntentLabel.Location = new System.Drawing.Point(8, 155);
            this.ColorRenderIntentLabel.Name = "ColorRenderIntentLabel";
            this.ColorRenderIntentLabel.Size = new System.Drawing.Size(102, 13);
            this.ColorRenderIntentLabel.TabIndex = 1;
            this.ColorRenderIntentLabel.Text = "Color Render Intent:";
            // 
            // TargetProfileNameBrowseButton
            // 
            this.TargetProfileNameBrowseButton.Location = new System.Drawing.Point(419, 178);
            this.TargetProfileNameBrowseButton.Name = "TargetProfileNameBrowseButton";
            this.TargetProfileNameBrowseButton.Size = new System.Drawing.Size(31, 23);
            this.TargetProfileNameBrowseButton.TabIndex = 5;
            this.TargetProfileNameBrowseButton.Text = "...";
            this.TargetProfileNameBrowseButton.UseVisualStyleBackColor = true;
            this.TargetProfileNameBrowseButton.Click += new System.EventHandler(this.TargetProfileNameBrowseButton_Click);
            // 
            // TargetProfileNameTextBox
            // 
            this.TargetProfileNameTextBox.Location = new System.Drawing.Point(114, 179);
            this.TargetProfileNameTextBox.Name = "TargetProfileNameTextBox";
            this.TargetProfileNameTextBox.Size = new System.Drawing.Size(299, 20);
            this.TargetProfileNameTextBox.TabIndex = 4;
            // 
            // TargetProfileNameLabel
            // 
            this.TargetProfileNameLabel.AutoSize = true;
            this.TargetProfileNameLabel.Location = new System.Drawing.Point(8, 183);
            this.TargetProfileNameLabel.Name = "TargetProfileNameLabel";
            this.TargetProfileNameLabel.Size = new System.Drawing.Size(104, 13);
            this.TargetProfileNameLabel.TabIndex = 3;
            this.TargetProfileNameLabel.Text = "Target Profile Name:";
            // 
            // ColorRenderIntentComboBox
            // 
            this.ColorRenderIntentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorRenderIntentComboBox.FormattingEnabled = true;
            this.ColorRenderIntentComboBox.Items.AddRange(new object[] {
            "Images",
            "Business",
            "Graphics",
            "Absolute ColorMetric"});
            this.ColorRenderIntentComboBox.Location = new System.Drawing.Point(114, 152);
            this.ColorRenderIntentComboBox.Name = "ColorRenderIntentComboBox";
            this.ColorRenderIntentComboBox.Size = new System.Drawing.Size(121, 21);
            this.ColorRenderIntentComboBox.TabIndex = 2;
            // 
            // SaveOptionsJpegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 217);
            this.Controls.Add(this.ColorRenderIntentLabel);
            this.Controls.Add(this.TargetProfileNameBrowseButton);
            this.Controls.Add(this.TargetProfileNameTextBox);
            this.Controls.Add(this.TargetProfileNameLabel);
            this.Controls.Add(this.ColorRenderIntentComboBox);
            this.Controls.Add(this.JpegGroupBox);
            this.Name = "SaveOptionsJpegForm";
            this.Text = "Save Options - JPEG";
            this.Load += new System.EventHandler(this.SaveOptionsJpegForm_Load);
            this.Controls.SetChildIndex(this.JpegGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.Controls.SetChildIndex(this.ColorRenderIntentComboBox, 0);
            this.Controls.SetChildIndex(this.TargetProfileNameLabel, 0);
            this.Controls.SetChildIndex(this.TargetProfileNameTextBox, 0);
            this.Controls.SetChildIndex(this.TargetProfileNameBrowseButton, 0);
            this.Controls.SetChildIndex(this.ColorRenderIntentLabel, 0);
            this.JpegGroupBox.ResumeLayout(false);
            this.JpegGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuminanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChrominanceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox JpegGroupBox;
        private System.Windows.Forms.Label SubSamplingLabel;
        private System.Windows.Forms.ComboBox SubSamplingComboBox;
        private System.Windows.Forms.CheckBox ProgressiveCheckBox;
        private System.Windows.Forms.CheckBox GrayscaleCheckBox;
        private System.Windows.Forms.CheckBox CositedCheckBox;
        private System.Windows.Forms.Label ColorSpaceLabel;
        private System.Windows.Forms.ComboBox ColorSpaceComboBox;
        private System.Windows.Forms.Label LuminanceLabel;
        private System.Windows.Forms.NumericUpDown LuminanceNumericUpDown;
        private System.Windows.Forms.NumericUpDown ChrominanceNumericUpDown;
        private System.Windows.Forms.Label ChrominanceLabel;
        private System.Windows.Forms.Label ColorRenderIntentLabel;
        private System.Windows.Forms.Button TargetProfileNameBrowseButton;
        protected System.Windows.Forms.TextBox TargetProfileNameTextBox;
        private System.Windows.Forms.Label TargetProfileNameLabel;
        private System.Windows.Forms.ComboBox ColorRenderIntentComboBox;
    }
}