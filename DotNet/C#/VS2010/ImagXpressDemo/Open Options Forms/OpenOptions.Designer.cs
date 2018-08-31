namespace ImagXpressDemo
{
    partial class OpenOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenOptionsForm));
            this.CropGroupBox = new System.Windows.Forms.GroupBox();
            this.CropXLabel = new System.Windows.Forms.Label();
            this.CropHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CropXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YLabel = new System.Windows.Forms.Label();
            this.CropYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CropWidthLabel = new System.Windows.Forms.Label();
            this.CropHeightLabel = new System.Windows.Forms.Label();
            this.CropWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OKButton = new System.Windows.Forms.Button();
            this.ResizeGroupBox = new System.Windows.Forms.GroupBox();
            this.ResizeAntiAliasCheckBox = new System.Windows.Forms.CheckBox();
            this.ResizeWidthLabel = new System.Windows.Forms.Label();
            this.ResizeHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ResizeHeightLabel = new System.Windows.Forms.Label();
            this.ResizeWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ScaleToGrayCheckBox = new System.Windows.Forms.CheckBox();
            this.MaintainAspectRatioCheckBox = new System.Windows.Forms.CheckBox();
            this.AlphaChannelCheckBox = new System.Windows.Forms.CheckBox();
            this.PreserveBlackCheckBox = new System.Windows.Forms.CheckBox();
            this.RotationLabel = new System.Windows.Forms.Label();
            this.RotationComboBox = new System.Windows.Forms.ComboBox();
            this.ImageOffsetLabel = new System.Windows.Forms.Label();
            this.ImageOffsetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CancelOptionsButton = new System.Windows.Forms.Button();
            this.CropGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).BeginInit();
            this.ResizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CropGroupBox
            // 
            this.CropGroupBox.Controls.Add(this.CropXLabel);
            this.CropGroupBox.Controls.Add(this.CropHeightNumericUpDown);
            this.CropGroupBox.Controls.Add(this.CropXNumericUpDown);
            this.CropGroupBox.Controls.Add(this.YLabel);
            this.CropGroupBox.Controls.Add(this.CropYNumericUpDown);
            this.CropGroupBox.Controls.Add(this.CropWidthLabel);
            this.CropGroupBox.Controls.Add(this.CropHeightLabel);
            this.CropGroupBox.Controls.Add(this.CropWidthNumericUpDown);
            this.CropGroupBox.Location = new System.Drawing.Point(9, 13);
            this.CropGroupBox.Name = "CropGroupBox";
            this.CropGroupBox.Size = new System.Drawing.Size(152, 147);
            this.CropGroupBox.TabIndex = 0;
            this.CropGroupBox.TabStop = false;
            this.CropGroupBox.Text = "Crop Rectangle";
            // 
            // CropXLabel
            // 
            this.CropXLabel.AutoSize = true;
            this.CropXLabel.Location = new System.Drawing.Point(22, 32);
            this.CropXLabel.Name = "CropXLabel";
            this.CropXLabel.Size = new System.Drawing.Size(17, 13);
            this.CropXLabel.TabIndex = 0;
            this.CropXLabel.Text = "X:";
            // 
            // CropHeightNumericUpDown
            // 
            this.CropHeightNumericUpDown.Location = new System.Drawing.Point(65, 106);
            this.CropHeightNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CropHeightNumericUpDown.Name = "CropHeightNumericUpDown";
            this.CropHeightNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.CropHeightNumericUpDown.TabIndex = 7;
            // 
            // CropXNumericUpDown
            // 
            this.CropXNumericUpDown.Location = new System.Drawing.Point(65, 28);
            this.CropXNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CropXNumericUpDown.Name = "CropXNumericUpDown";
            this.CropXNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.CropXNumericUpDown.TabIndex = 1;
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(22, 58);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 13);
            this.YLabel.TabIndex = 2;
            this.YLabel.Text = "Y:";
            // 
            // CropYNumericUpDown
            // 
            this.CropYNumericUpDown.Location = new System.Drawing.Point(65, 54);
            this.CropYNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CropYNumericUpDown.Name = "CropYNumericUpDown";
            this.CropYNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.CropYNumericUpDown.TabIndex = 3;
            // 
            // CropWidthLabel
            // 
            this.CropWidthLabel.AutoSize = true;
            this.CropWidthLabel.Location = new System.Drawing.Point(22, 84);
            this.CropWidthLabel.Name = "CropWidthLabel";
            this.CropWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.CropWidthLabel.TabIndex = 4;
            this.CropWidthLabel.Text = "Width:";
            // 
            // CropHeightLabel
            // 
            this.CropHeightLabel.AutoSize = true;
            this.CropHeightLabel.Location = new System.Drawing.Point(22, 110);
            this.CropHeightLabel.Name = "CropHeightLabel";
            this.CropHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.CropHeightLabel.TabIndex = 6;
            this.CropHeightLabel.Text = "Height:";
            // 
            // CropWidthNumericUpDown
            // 
            this.CropWidthNumericUpDown.Location = new System.Drawing.Point(65, 80);
            this.CropWidthNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CropWidthNumericUpDown.Name = "CropWidthNumericUpDown";
            this.CropWidthNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.CropWidthNumericUpDown.TabIndex = 5;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(9, 171);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "Ok";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ResizeGroupBox
            // 
            this.ResizeGroupBox.Controls.Add(this.ResizeAntiAliasCheckBox);
            this.ResizeGroupBox.Controls.Add(this.ResizeWidthLabel);
            this.ResizeGroupBox.Controls.Add(this.ResizeHeightNumericUpDown);
            this.ResizeGroupBox.Controls.Add(this.ResizeHeightLabel);
            this.ResizeGroupBox.Controls.Add(this.ResizeWidthNumericUpDown);
            this.ResizeGroupBox.Controls.Add(this.ScaleToGrayCheckBox);
            this.ResizeGroupBox.Location = new System.Drawing.Point(167, 13);
            this.ResizeGroupBox.Name = "ResizeGroupBox";
            this.ResizeGroupBox.Size = new System.Drawing.Size(163, 133);
            this.ResizeGroupBox.TabIndex = 1;
            this.ResizeGroupBox.TabStop = false;
            this.ResizeGroupBox.Text = "Resize";
            // 
            // ResizeAntiAliasCheckBox
            // 
            this.ResizeAntiAliasCheckBox.AutoSize = true;
            this.ResizeAntiAliasCheckBox.Location = new System.Drawing.Point(14, 80);
            this.ResizeAntiAliasCheckBox.Name = "ResizeAntiAliasCheckBox";
            this.ResizeAntiAliasCheckBox.Size = new System.Drawing.Size(69, 17);
            this.ResizeAntiAliasCheckBox.TabIndex = 4;
            this.ResizeAntiAliasCheckBox.Text = "Anti-Alias";
            this.ResizeAntiAliasCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResizeWidthLabel
            // 
            this.ResizeWidthLabel.AutoSize = true;
            this.ResizeWidthLabel.Location = new System.Drawing.Point(11, 32);
            this.ResizeWidthLabel.Name = "ResizeWidthLabel";
            this.ResizeWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.ResizeWidthLabel.TabIndex = 0;
            this.ResizeWidthLabel.Text = "Width:";
            // 
            // ResizeHeightNumericUpDown
            // 
            this.ResizeHeightNumericUpDown.Location = new System.Drawing.Point(80, 54);
            this.ResizeHeightNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ResizeHeightNumericUpDown.Name = "ResizeHeightNumericUpDown";
            this.ResizeHeightNumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.ResizeHeightNumericUpDown.TabIndex = 3;
            // 
            // ResizeHeightLabel
            // 
            this.ResizeHeightLabel.AutoSize = true;
            this.ResizeHeightLabel.Location = new System.Drawing.Point(11, 58);
            this.ResizeHeightLabel.Name = "ResizeHeightLabel";
            this.ResizeHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.ResizeHeightLabel.TabIndex = 2;
            this.ResizeHeightLabel.Text = "Height:";
            // 
            // ResizeWidthNumericUpDown
            // 
            this.ResizeWidthNumericUpDown.Location = new System.Drawing.Point(80, 27);
            this.ResizeWidthNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ResizeWidthNumericUpDown.Name = "ResizeWidthNumericUpDown";
            this.ResizeWidthNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.ResizeWidthNumericUpDown.TabIndex = 1;
            // 
            // ScaleToGrayCheckBox
            // 
            this.ScaleToGrayCheckBox.AutoSize = true;
            this.ScaleToGrayCheckBox.Location = new System.Drawing.Point(14, 106);
            this.ScaleToGrayCheckBox.Name = "ScaleToGrayCheckBox";
            this.ScaleToGrayCheckBox.Size = new System.Drawing.Size(94, 17);
            this.ScaleToGrayCheckBox.TabIndex = 5;
            this.ScaleToGrayCheckBox.Text = "Scale To Gray";
            this.ScaleToGrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // MaintainAspectRatioCheckBox
            // 
            this.MaintainAspectRatioCheckBox.AutoSize = true;
            this.MaintainAspectRatioCheckBox.Location = new System.Drawing.Point(351, 41);
            this.MaintainAspectRatioCheckBox.Name = "MaintainAspectRatioCheckBox";
            this.MaintainAspectRatioCheckBox.Size = new System.Drawing.Size(130, 17);
            this.MaintainAspectRatioCheckBox.TabIndex = 2;
            this.MaintainAspectRatioCheckBox.Text = "Maintain Apsect Ratio";
            this.MaintainAspectRatioCheckBox.UseVisualStyleBackColor = true;
            // 
            // AlphaChannelCheckBox
            // 
            this.AlphaChannelCheckBox.AutoSize = true;
            this.AlphaChannelCheckBox.Location = new System.Drawing.Point(351, 93);
            this.AlphaChannelCheckBox.Name = "AlphaChannelCheckBox";
            this.AlphaChannelCheckBox.Size = new System.Drawing.Size(95, 17);
            this.AlphaChannelCheckBox.TabIndex = 4;
            this.AlphaChannelCheckBox.Text = "Alpha Channel";
            this.AlphaChannelCheckBox.UseVisualStyleBackColor = true;
            // 
            // PreserveBlackCheckBox
            // 
            this.PreserveBlackCheckBox.AutoSize = true;
            this.PreserveBlackCheckBox.Location = new System.Drawing.Point(351, 67);
            this.PreserveBlackCheckBox.Name = "PreserveBlackCheckBox";
            this.PreserveBlackCheckBox.Size = new System.Drawing.Size(98, 17);
            this.PreserveBlackCheckBox.TabIndex = 3;
            this.PreserveBlackCheckBox.Text = "Preserve Black";
            this.PreserveBlackCheckBox.UseVisualStyleBackColor = true;
            // 
            // RotationLabel
            // 
            this.RotationLabel.AutoSize = true;
            this.RotationLabel.Location = new System.Drawing.Point(178, 156);
            this.RotationLabel.Name = "RotationLabel";
            this.RotationLabel.Size = new System.Drawing.Size(50, 13);
            this.RotationLabel.TabIndex = 6;
            this.RotationLabel.Text = "Rotation:";
            // 
            // RotationComboBox
            // 
            this.RotationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RotationComboBox.FormattingEnabled = true;
            this.RotationComboBox.Items.AddRange(new object[] {
            "0",
            "90",
            "180",
            "270",
            "Flip",
            "Mirror"});
            this.RotationComboBox.Location = new System.Drawing.Point(251, 152);
            this.RotationComboBox.Name = "RotationComboBox";
            this.RotationComboBox.Size = new System.Drawing.Size(79, 21);
            this.RotationComboBox.TabIndex = 8;
            // 
            // ImageOffsetLabel
            // 
            this.ImageOffsetLabel.AutoSize = true;
            this.ImageOffsetLabel.Location = new System.Drawing.Point(179, 182);
            this.ImageOffsetLabel.Name = "ImageOffsetLabel";
            this.ImageOffsetLabel.Size = new System.Drawing.Size(70, 13);
            this.ImageOffsetLabel.TabIndex = 7;
            this.ImageOffsetLabel.Text = "Image Offset:";
            // 
            // ImageOffsetNumericUpDown
            // 
            this.ImageOffsetNumericUpDown.Location = new System.Drawing.Point(251, 178);
            this.ImageOffsetNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ImageOffsetNumericUpDown.Name = "ImageOffsetNumericUpDown";
            this.ImageOffsetNumericUpDown.Size = new System.Drawing.Size(79, 20);
            this.ImageOffsetNumericUpDown.TabIndex = 9;
            // 
            // CancelOptionsButton
            // 
            this.CancelOptionsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelOptionsButton.Location = new System.Drawing.Point(406, 171);
            this.CancelOptionsButton.Name = "CancelOptionsButton";
            this.CancelOptionsButton.Size = new System.Drawing.Size(75, 23);
            this.CancelOptionsButton.TabIndex = 10;
            this.CancelOptionsButton.Text = "Cancel";
            this.CancelOptionsButton.UseVisualStyleBackColor = true;
            this.CancelOptionsButton.Click += new System.EventHandler(this.CancelOptionsButton_Click);
            // 
            // OpenOptionsForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelOptionsButton;
            this.ClientSize = new System.Drawing.Size(488, 206);
            this.Controls.Add(this.CancelOptionsButton);
            this.Controls.Add(this.ImageOffsetNumericUpDown);
            this.Controls.Add(this.ImageOffsetLabel);
            this.Controls.Add(this.RotationComboBox);
            this.Controls.Add(this.RotationLabel);
            this.Controls.Add(this.PreserveBlackCheckBox);
            this.Controls.Add(this.AlphaChannelCheckBox);
            this.Controls.Add(this.MaintainAspectRatioCheckBox);
            this.Controls.Add(this.ResizeGroupBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CropGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OpenOptionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Options";
            this.CropGroupBox.ResumeLayout(false);
            this.CropGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).EndInit();
            this.ResizeGroupBox.ResumeLayout(false);
            this.ResizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CropGroupBox;
        private System.Windows.Forms.Label CropXLabel;
        private System.Windows.Forms.Label CropHeightLabel;
        private System.Windows.Forms.Label CropWidthLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.GroupBox ResizeGroupBox;
        private System.Windows.Forms.Label ResizeHeightLabel;
        private System.Windows.Forms.Label ResizeWidthLabel;
        private System.Windows.Forms.CheckBox MaintainAspectRatioCheckBox;
        private System.Windows.Forms.CheckBox ScaleToGrayCheckBox;
        private System.Windows.Forms.CheckBox AlphaChannelCheckBox;
        private System.Windows.Forms.CheckBox PreserveBlackCheckBox;
        protected System.Windows.Forms.Button OKButton;
        protected System.Windows.Forms.Button CancelOptionsButton;
        protected System.Windows.Forms.NumericUpDown CropXNumericUpDown;
        protected System.Windows.Forms.NumericUpDown CropHeightNumericUpDown;
        protected System.Windows.Forms.NumericUpDown CropWidthNumericUpDown;
        protected System.Windows.Forms.NumericUpDown CropYNumericUpDown;
        protected System.Windows.Forms.NumericUpDown ResizeHeightNumericUpDown;
        protected System.Windows.Forms.NumericUpDown ResizeWidthNumericUpDown;
        protected System.Windows.Forms.ComboBox RotationComboBox;
        protected System.Windows.Forms.CheckBox ResizeAntiAliasCheckBox;
        protected System.Windows.Forms.Label RotationLabel;
        protected System.Windows.Forms.Label ImageOffsetLabel;
        protected System.Windows.Forms.NumericUpDown ImageOffsetNumericUpDown;
    }
}