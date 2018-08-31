namespace ImagXpressDemo
{
    partial class SkewForm
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
            this.SkewGroupBox = new System.Windows.Forms.GroupBox();
            this.AngleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AngleLabel = new System.Windows.Forms.Label();
            this.BackgroundColorLabel = new System.Windows.Forms.Label();
            this.BackgroundColorButton = new System.Windows.Forms.Button();
            this.DeskewTypeLabel = new System.Windows.Forms.Label();
            this.OneBitBackgroundColorComboBox = new System.Windows.Forms.ComboBox();
            this.DeskewTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SkewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AngleNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(373, 495);
            this.PreviewButton.TabIndex = 4;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(13, 495);
            this.OKButton.TabIndex = 3;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(653, 495);
            this.CancelProcessingButton.TabIndex = 5;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.TabIndex = 6;
            // 
            // SkewGroupBox
            // 
            this.SkewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SkewGroupBox.Controls.Add(this.AngleNumericUpDown);
            this.SkewGroupBox.Controls.Add(this.AngleLabel);
            this.SkewGroupBox.Controls.Add(this.BackgroundColorLabel);
            this.SkewGroupBox.Controls.Add(this.BackgroundColorButton);
            this.SkewGroupBox.Controls.Add(this.DeskewTypeLabel);
            this.SkewGroupBox.Controls.Add(this.OneBitBackgroundColorComboBox);
            this.SkewGroupBox.Controls.Add(this.DeskewTypeComboBox);
            this.SkewGroupBox.Location = new System.Drawing.Point(12, 433);
            this.SkewGroupBox.Name = "SkewGroupBox";
            this.SkewGroupBox.Size = new System.Drawing.Size(573, 56);
            this.SkewGroupBox.TabIndex = 2;
            this.SkewGroupBox.TabStop = false;
            // 
            // AngleNumericUpDown
            // 
            this.AngleNumericUpDown.DecimalPlaces = 2;
            this.AngleNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AngleNumericUpDown.Location = new System.Drawing.Point(426, 20);
            this.AngleNumericUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.AngleNumericUpDown.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.AngleNumericUpDown.Name = "AngleNumericUpDown";
            this.AngleNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.AngleNumericUpDown.TabIndex = 5;
            // 
            // AngleLabel
            // 
            this.AngleLabel.AutoSize = true;
            this.AngleLabel.Location = new System.Drawing.Point(377, 23);
            this.AngleLabel.Name = "AngleLabel";
            this.AngleLabel.Size = new System.Drawing.Size(37, 13);
            this.AngleLabel.TabIndex = 4;
            this.AngleLabel.Text = "Angle:";
            // 
            // BackgroundColorLabel
            // 
            this.BackgroundColorLabel.AutoSize = true;
            this.BackgroundColorLabel.Location = new System.Drawing.Point(17, 23);
            this.BackgroundColorLabel.Name = "BackgroundColorLabel";
            this.BackgroundColorLabel.Size = new System.Drawing.Size(95, 13);
            this.BackgroundColorLabel.TabIndex = 0;
            this.BackgroundColorLabel.Text = "Background Color:";
            // 
            // BackgroundColorButton
            // 
            this.BackgroundColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackgroundColorButton.Location = new System.Drawing.Point(124, 18);
            this.BackgroundColorButton.Name = "BackgroundColorButton";
            this.BackgroundColorButton.Size = new System.Drawing.Size(20, 23);
            this.BackgroundColorButton.TabIndex = 1;
            this.BackgroundColorButton.UseVisualStyleBackColor = true;
            this.BackgroundColorButton.Click += new System.EventHandler(this.BackgroundColorButton_Click);
            // 
            // DeskewTypeLabel
            // 
            this.DeskewTypeLabel.AutoSize = true;
            this.DeskewTypeLabel.Location = new System.Drawing.Point(156, 23);
            this.DeskewTypeLabel.Name = "DeskewTypeLabel";
            this.DeskewTypeLabel.Size = new System.Drawing.Size(76, 13);
            this.DeskewTypeLabel.TabIndex = 2;
            this.DeskewTypeLabel.Text = "Deskew Type:";
            // 
            // OneBitBackgroundColorComboBox
            // 
            this.OneBitBackgroundColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OneBitBackgroundColorComboBox.FormattingEnabled = true;
            this.OneBitBackgroundColorComboBox.Items.AddRange(new object[] {
            "Black",
            "White"});
            this.OneBitBackgroundColorComboBox.Location = new System.Drawing.Point(488, 19);
            this.OneBitBackgroundColorComboBox.Name = "OneBitBackgroundColorComboBox";
            this.OneBitBackgroundColorComboBox.Size = new System.Drawing.Size(68, 21);
            this.OneBitBackgroundColorComboBox.TabIndex = 6;
            // 
            // DeskewTypeComboBox
            // 
            this.DeskewTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeskewTypeComboBox.FormattingEnabled = true;
            this.DeskewTypeComboBox.Items.AddRange(new object[] {
            "Normal",
            "Adjust Size",
            "Preserve Crop",
            "Preserve Resize",
            "Preserve Resample",
            "Preserve Resize Quality",
            "Photo Crop"});
            this.DeskewTypeComboBox.Location = new System.Drawing.Point(244, 19);
            this.DeskewTypeComboBox.Name = "DeskewTypeComboBox";
            this.DeskewTypeComboBox.Size = new System.Drawing.Size(145, 21);
            this.DeskewTypeComboBox.TabIndex = 3;
            // 
            // SkewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 527);
            this.Controls.Add(this.SkewGroupBox);
            this.Name = "SkewForm";
            this.Text = "";
            this.Load += new System.EventHandler(this.DeskewForm_Load);
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.SkewGroupBox, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.SkewGroupBox.ResumeLayout(false);
            this.SkewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AngleNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SkewGroupBox;
        private System.Windows.Forms.Label DeskewTypeLabel;
        private System.Windows.Forms.ComboBox DeskewTypeComboBox;
        private System.Windows.Forms.Label BackgroundColorLabel;
        private System.Windows.Forms.Button BackgroundColorButton;
        private System.Windows.Forms.NumericUpDown AngleNumericUpDown;
        private System.Windows.Forms.Label AngleLabel;
        private System.Windows.Forms.ComboBox OneBitBackgroundColorComboBox;
    }
}