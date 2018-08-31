namespace ImagXpressDemo
{
    partial class SaveOptionsTifForm
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
            this.TifGroupBox = new System.Windows.Forms.GroupBox();
            this.RowsPerStripNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IFDOffsetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RowsPerStripLabel = new System.Windows.Forms.Label();
            this.IFDOffsetLabel = new System.Windows.Forms.Label();
            this.UseIFDOffsetCheckBox = new System.Windows.Forms.CheckBox();
            this.MultiPageCheckBox = new System.Windows.Forms.CheckBox();
            this.ColorSpaceComboBox = new System.Windows.Forms.ComboBox();
            this.ColorSpaceLabel = new System.Windows.Forms.Label();
            this.CompressionLabel = new System.Windows.Forms.Label();
            this.CompressionComboBox = new System.Windows.Forms.ComboBox();
            this.ByteOrderComboBox = new System.Windows.Forms.ComboBox();
            this.ByteOrderLabel = new System.Windows.Forms.Label();
            this.ColorRenderIntentLabel = new System.Windows.Forms.Label();
            this.TargetProfileNameBrowseButton = new System.Windows.Forms.Button();
            this.TargetProfileNameTextBox = new System.Windows.Forms.TextBox();
            this.TargetProfileNameLabel = new System.Windows.Forms.Label();
            this.ColorRenderIntentComboBox = new System.Windows.Forms.ComboBox();
            this.TifGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RowsPerStripNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IFDOffsetNumericUpDown)).BeginInit();
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
            // TifGroupBox
            // 
            this.TifGroupBox.Controls.Add(this.RowsPerStripNumericUpDown);
            this.TifGroupBox.Controls.Add(this.IFDOffsetNumericUpDown);
            this.TifGroupBox.Controls.Add(this.RowsPerStripLabel);
            this.TifGroupBox.Controls.Add(this.IFDOffsetLabel);
            this.TifGroupBox.Controls.Add(this.UseIFDOffsetCheckBox);
            this.TifGroupBox.Controls.Add(this.MultiPageCheckBox);
            this.TifGroupBox.Controls.Add(this.ColorSpaceComboBox);
            this.TifGroupBox.Controls.Add(this.ColorSpaceLabel);
            this.TifGroupBox.Controls.Add(this.CompressionLabel);
            this.TifGroupBox.Controls.Add(this.CompressionComboBox);
            this.TifGroupBox.Controls.Add(this.ByteOrderComboBox);
            this.TifGroupBox.Controls.Add(this.ByteOrderLabel);
            this.TifGroupBox.Location = new System.Drawing.Point(11, 12);
            this.TifGroupBox.Name = "TifGroupBox";
            this.TifGroupBox.Size = new System.Drawing.Size(360, 140);
            this.TifGroupBox.TabIndex = 0;
            this.TifGroupBox.TabStop = false;
            this.TifGroupBox.Text = "TIF";
            // 
            // RowsPerStripNumericUpDown
            // 
            this.RowsPerStripNumericUpDown.Location = new System.Drawing.Point(292, 83);
            this.RowsPerStripNumericUpDown.Name = "RowsPerStripNumericUpDown";
            this.RowsPerStripNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.RowsPerStripNumericUpDown.TabIndex = 10;
            // 
            // IFDOffsetNumericUpDown
            // 
            this.IFDOffsetNumericUpDown.Location = new System.Drawing.Point(292, 49);
            this.IFDOffsetNumericUpDown.Name = "IFDOffsetNumericUpDown";
            this.IFDOffsetNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.IFDOffsetNumericUpDown.TabIndex = 6;
            // 
            // RowsPerStripLabel
            // 
            this.RowsPerStripLabel.AutoSize = true;
            this.RowsPerStripLabel.Location = new System.Drawing.Point(212, 87);
            this.RowsPerStripLabel.Name = "RowsPerStripLabel";
            this.RowsPerStripLabel.Size = new System.Drawing.Size(80, 13);
            this.RowsPerStripLabel.TabIndex = 9;
            this.RowsPerStripLabel.Text = "Rows Per Strip:";
            // 
            // IFDOffsetLabel
            // 
            this.IFDOffsetLabel.AutoSize = true;
            this.IFDOffsetLabel.Location = new System.Drawing.Point(212, 53);
            this.IFDOffsetLabel.Name = "IFDOffsetLabel";
            this.IFDOffsetLabel.Size = new System.Drawing.Size(58, 13);
            this.IFDOffsetLabel.TabIndex = 5;
            this.IFDOffsetLabel.Text = "IFD Offset:";
            // 
            // UseIFDOffsetCheckBox
            // 
            this.UseIFDOffsetCheckBox.AutoSize = true;
            this.UseIFDOffsetCheckBox.Location = new System.Drawing.Point(215, 17);
            this.UseIFDOffsetCheckBox.Name = "UseIFDOffsetCheckBox";
            this.UseIFDOffsetCheckBox.Size = new System.Drawing.Size(93, 17);
            this.UseIFDOffsetCheckBox.TabIndex = 2;
            this.UseIFDOffsetCheckBox.Text = "Use IFDOffset";
            this.UseIFDOffsetCheckBox.UseVisualStyleBackColor = true;
            // 
            // MultiPageCheckBox
            // 
            this.MultiPageCheckBox.AutoSize = true;
            this.MultiPageCheckBox.Location = new System.Drawing.Point(88, 117);
            this.MultiPageCheckBox.Name = "MultiPageCheckBox";
            this.MultiPageCheckBox.Size = new System.Drawing.Size(73, 17);
            this.MultiPageCheckBox.TabIndex = 11;
            this.MultiPageCheckBox.Text = "MultiPage";
            this.MultiPageCheckBox.UseVisualStyleBackColor = true;
            // 
            // ColorSpaceComboBox
            // 
            this.ColorSpaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorSpaceComboBox.FormattingEnabled = true;
            this.ColorSpaceComboBox.Items.AddRange(new object[] {
            "RGB",
            "CMYK"});
            this.ColorSpaceComboBox.Location = new System.Drawing.Point(88, 81);
            this.ColorSpaceComboBox.Name = "ColorSpaceComboBox";
            this.ColorSpaceComboBox.Size = new System.Drawing.Size(105, 21);
            this.ColorSpaceComboBox.TabIndex = 8;
            this.ColorSpaceComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorSpaceComboBox_SelectedIndexChanged);
            // 
            // ColorSpaceLabel
            // 
            this.ColorSpaceLabel.AutoSize = true;
            this.ColorSpaceLabel.Location = new System.Drawing.Point(8, 85);
            this.ColorSpaceLabel.Name = "ColorSpaceLabel";
            this.ColorSpaceLabel.Size = new System.Drawing.Size(65, 13);
            this.ColorSpaceLabel.TabIndex = 7;
            this.ColorSpaceLabel.Text = "ColorSpace:";
            // 
            // CompressionLabel
            // 
            this.CompressionLabel.AutoSize = true;
            this.CompressionLabel.Location = new System.Drawing.Point(8, 52);
            this.CompressionLabel.Name = "CompressionLabel";
            this.CompressionLabel.Size = new System.Drawing.Size(70, 13);
            this.CompressionLabel.TabIndex = 3;
            this.CompressionLabel.Text = "Compression:";
            // 
            // CompressionComboBox
            // 
            this.CompressionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompressionComboBox.FormattingEnabled = true;
            this.CompressionComboBox.Location = new System.Drawing.Point(88, 48);
            this.CompressionComboBox.Name = "CompressionComboBox";
            this.CompressionComboBox.Size = new System.Drawing.Size(105, 21);
            this.CompressionComboBox.TabIndex = 4;
            this.CompressionComboBox.SelectedIndexChanged += new System.EventHandler(this.CompressionComboBox_SelectedIndexChanged);
            // 
            // ByteOrderComboBox
            // 
            this.ByteOrderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ByteOrderComboBox.FormattingEnabled = true;
            this.ByteOrderComboBox.Items.AddRange(new object[] {
            "Original Image",
            "Intel",
            "Motorola"});
            this.ByteOrderComboBox.Location = new System.Drawing.Point(88, 15);
            this.ByteOrderComboBox.Name = "ByteOrderComboBox";
            this.ByteOrderComboBox.Size = new System.Drawing.Size(105, 21);
            this.ByteOrderComboBox.TabIndex = 1;
            // 
            // ByteOrderLabel
            // 
            this.ByteOrderLabel.AutoSize = true;
            this.ByteOrderLabel.Location = new System.Drawing.Point(8, 19);
            this.ByteOrderLabel.Name = "ByteOrderLabel";
            this.ByteOrderLabel.Size = new System.Drawing.Size(60, 13);
            this.ByteOrderLabel.TabIndex = 0;
            this.ByteOrderLabel.Text = "Byte Order:";
            // 
            // ColorRenderIntentLabel
            // 
            this.ColorRenderIntentLabel.AutoSize = true;
            this.ColorRenderIntentLabel.Location = new System.Drawing.Point(8, 166);
            this.ColorRenderIntentLabel.Name = "ColorRenderIntentLabel";
            this.ColorRenderIntentLabel.Size = new System.Drawing.Size(102, 13);
            this.ColorRenderIntentLabel.TabIndex = 1;
            this.ColorRenderIntentLabel.Text = "Color Render Intent:";
            // 
            // TargetProfileNameBrowseButton
            // 
            this.TargetProfileNameBrowseButton.Location = new System.Drawing.Point(419, 189);
            this.TargetProfileNameBrowseButton.Name = "TargetProfileNameBrowseButton";
            this.TargetProfileNameBrowseButton.Size = new System.Drawing.Size(31, 23);
            this.TargetProfileNameBrowseButton.TabIndex = 5;
            this.TargetProfileNameBrowseButton.Text = "...";
            this.TargetProfileNameBrowseButton.UseVisualStyleBackColor = true;
            this.TargetProfileNameBrowseButton.Click += new System.EventHandler(this.TargetProfileNameBrowseButton_Click);
            // 
            // TargetProfileNameTextBox
            // 
            this.TargetProfileNameTextBox.Location = new System.Drawing.Point(114, 190);
            this.TargetProfileNameTextBox.Name = "TargetProfileNameTextBox";
            this.TargetProfileNameTextBox.Size = new System.Drawing.Size(299, 20);
            this.TargetProfileNameTextBox.TabIndex = 4;
            // 
            // TargetProfileNameLabel
            // 
            this.TargetProfileNameLabel.AutoSize = true;
            this.TargetProfileNameLabel.Location = new System.Drawing.Point(8, 194);
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
            this.ColorRenderIntentComboBox.Location = new System.Drawing.Point(114, 163);
            this.ColorRenderIntentComboBox.Name = "ColorRenderIntentComboBox";
            this.ColorRenderIntentComboBox.Size = new System.Drawing.Size(121, 21);
            this.ColorRenderIntentComboBox.TabIndex = 2;
            // 
            // SaveOptionsTifForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 230);
            this.Controls.Add(this.ColorRenderIntentLabel);
            this.Controls.Add(this.TargetProfileNameBrowseButton);
            this.Controls.Add(this.TargetProfileNameTextBox);
            this.Controls.Add(this.TargetProfileNameLabel);
            this.Controls.Add(this.ColorRenderIntentComboBox);
            this.Controls.Add(this.TifGroupBox);
            this.Name = "SaveOptionsTifForm";
            this.Text = "Save Options - TIF";
            this.Load += new System.EventHandler(this.SaveOptionsTifForm_Load);
            this.Controls.SetChildIndex(this.TifGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.Controls.SetChildIndex(this.ColorRenderIntentComboBox, 0);
            this.Controls.SetChildIndex(this.TargetProfileNameLabel, 0);
            this.Controls.SetChildIndex(this.TargetProfileNameTextBox, 0);
            this.Controls.SetChildIndex(this.TargetProfileNameBrowseButton, 0);
            this.Controls.SetChildIndex(this.ColorRenderIntentLabel, 0);
            this.TifGroupBox.ResumeLayout(false);
            this.TifGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RowsPerStripNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IFDOffsetNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TifGroupBox;
        private System.Windows.Forms.NumericUpDown RowsPerStripNumericUpDown;
        private System.Windows.Forms.NumericUpDown IFDOffsetNumericUpDown;
        private System.Windows.Forms.Label RowsPerStripLabel;
        private System.Windows.Forms.Label IFDOffsetLabel;
        private System.Windows.Forms.CheckBox UseIFDOffsetCheckBox;
        private System.Windows.Forms.CheckBox MultiPageCheckBox;
        private System.Windows.Forms.ComboBox ColorSpaceComboBox;
        private System.Windows.Forms.Label ColorSpaceLabel;
        private System.Windows.Forms.ComboBox ByteOrderComboBox;
        private System.Windows.Forms.Label ByteOrderLabel;
        private System.Windows.Forms.Label CompressionLabel;
        private System.Windows.Forms.ComboBox CompressionComboBox;
        private System.Windows.Forms.Label ColorRenderIntentLabel;
        private System.Windows.Forms.Button TargetProfileNameBrowseButton;
        protected System.Windows.Forms.TextBox TargetProfileNameTextBox;
        private System.Windows.Forms.Label TargetProfileNameLabel;
        private System.Windows.Forms.ComboBox ColorRenderIntentComboBox;
    }
}