namespace ImagXpressDemo
{
    partial class MergeForm
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
            this.MergeGroupBox = new System.Windows.Forms.GroupBox();
            this.SourceImageLabel = new System.Windows.Forms.Label();
            this.SourceImageTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.TransparentColorLabel = new System.Windows.Forms.Label();
            this.TransparentColorButton = new System.Windows.Forms.Button();
            this.MergePercentHighNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MergePercentLowNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TransparentCheckBox = new System.Windows.Forms.CheckBox();
            this.MergeStyleComboBox = new System.Windows.Forms.ComboBox();
            this.MergeSizeComboBox = new System.Windows.Forms.ComboBox();
            this.MergePercentHighLabel = new System.Windows.Forms.Label();
            this.MergePercentLowLabel = new System.Windows.Forms.Label();
            this.MergeStyleLabel = new System.Windows.Forms.Label();
            this.MergeSizeLabel = new System.Windows.Forms.Label();
            this.MergeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MergePercentHighNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MergePercentLowNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(373, 671);
            this.PreviewButton.TabIndex = 4;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(13, 671);
            this.OKButton.TabIndex = 3;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(653, 671);
            this.CancelProcessingButton.TabIndex = 5;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.TabIndex = 6;
            // 
            // MergeGroupBox
            // 
            this.MergeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MergeGroupBox.Controls.Add(this.SourceImageLabel);
            this.MergeGroupBox.Controls.Add(this.SourceImageTextBox);
            this.MergeGroupBox.Controls.Add(this.BrowseButton);
            this.MergeGroupBox.Controls.Add(this.TransparentColorLabel);
            this.MergeGroupBox.Controls.Add(this.TransparentColorButton);
            this.MergeGroupBox.Controls.Add(this.MergePercentHighNumericUpDown);
            this.MergeGroupBox.Controls.Add(this.MergePercentLowNumericUpDown);
            this.MergeGroupBox.Controls.Add(this.TransparentCheckBox);
            this.MergeGroupBox.Controls.Add(this.MergeStyleComboBox);
            this.MergeGroupBox.Controls.Add(this.MergeSizeComboBox);
            this.MergeGroupBox.Controls.Add(this.MergePercentHighLabel);
            this.MergeGroupBox.Controls.Add(this.MergePercentLowLabel);
            this.MergeGroupBox.Controls.Add(this.MergeStyleLabel);
            this.MergeGroupBox.Controls.Add(this.MergeSizeLabel);
            this.MergeGroupBox.Location = new System.Drawing.Point(12, 433);
            this.MergeGroupBox.Name = "MergeGroupBox";
            this.MergeGroupBox.Size = new System.Drawing.Size(347, 233);
            this.MergeGroupBox.TabIndex = 2;
            this.MergeGroupBox.TabStop = false;
            this.MergeGroupBox.Text = "Merge";
            // 
            // SourceImageLabel
            // 
            this.SourceImageLabel.AutoSize = true;
            this.SourceImageLabel.Location = new System.Drawing.Point(7, 201);
            this.SourceImageLabel.Name = "SourceImageLabel";
            this.SourceImageLabel.Size = new System.Drawing.Size(76, 13);
            this.SourceImageLabel.TabIndex = 11;
            this.SourceImageLabel.Text = "Source Image:";
            // 
            // SourceImageTextBox
            // 
            this.SourceImageTextBox.Location = new System.Drawing.Point(106, 197);
            this.SourceImageTextBox.Name = "SourceImageTextBox";
            this.SourceImageTextBox.ReadOnly = true;
            this.SourceImageTextBox.Size = new System.Drawing.Size(182, 20);
            this.SourceImageTextBox.TabIndex = 12;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(306, 196);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(35, 23);
            this.BrowseButton.TabIndex = 13;
            this.BrowseButton.Text = "...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // TransparentColorLabel
            // 
            this.TransparentColorLabel.AutoSize = true;
            this.TransparentColorLabel.Location = new System.Drawing.Point(7, 169);
            this.TransparentColorLabel.Name = "TransparentColorLabel";
            this.TransparentColorLabel.Size = new System.Drawing.Size(94, 13);
            this.TransparentColorLabel.TabIndex = 9;
            this.TransparentColorLabel.Text = "Transparent Color:";
            // 
            // TransparentColorButton
            // 
            this.TransparentColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransparentColorButton.Location = new System.Drawing.Point(106, 164);
            this.TransparentColorButton.Name = "TransparentColorButton";
            this.TransparentColorButton.Size = new System.Drawing.Size(23, 23);
            this.TransparentColorButton.TabIndex = 10;
            this.TransparentColorButton.UseVisualStyleBackColor = true;
            this.TransparentColorButton.Click += new System.EventHandler(this.TransparentColorButton_Click);
            // 
            // MergePercentHighNumericUpDown
            // 
            this.MergePercentHighNumericUpDown.Location = new System.Drawing.Point(106, 134);
            this.MergePercentHighNumericUpDown.Name = "MergePercentHighNumericUpDown";
            this.MergePercentHighNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.MergePercentHighNumericUpDown.TabIndex = 8;
            // 
            // MergePercentLowNumericUpDown
            // 
            this.MergePercentLowNumericUpDown.Location = new System.Drawing.Point(106, 104);
            this.MergePercentLowNumericUpDown.Name = "MergePercentLowNumericUpDown";
            this.MergePercentLowNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.MergePercentLowNumericUpDown.TabIndex = 6;
            // 
            // TransparentCheckBox
            // 
            this.TransparentCheckBox.AutoSize = true;
            this.TransparentCheckBox.Location = new System.Drawing.Point(106, 15);
            this.TransparentCheckBox.Name = "TransparentCheckBox";
            this.TransparentCheckBox.Size = new System.Drawing.Size(83, 17);
            this.TransparentCheckBox.TabIndex = 0;
            this.TransparentCheckBox.Text = "Transparent";
            this.TransparentCheckBox.UseVisualStyleBackColor = true;
            // 
            // MergeStyleComboBox
            // 
            this.MergeStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MergeStyleComboBox.FormattingEnabled = true;
            this.MergeStyleComboBox.Items.AddRange(new object[] {
            "Normal",
            "If Darker",
            "If Lighter",
            "Additive",
            "Subtractive",
            "Superimpose",
            "Superimpose Left to Right",
            "Superimpose Right to Left",
            "Superimpose Vertical to Center",
            "Superimpose Vertical from Center",
            "Superimpose Top to Bottom",
            "Superimpose Bottom to Top",
            "Superimpose Horizontal from Center",
            "Superimpose Horizontal to Center",
            "Alpha Foreground Over Background",
            "Alpha Foreground Over Foreground",
            "Alpha Most Opaque",
            "Alpha Least Opqaue"});
            this.MergeStyleComboBox.Location = new System.Drawing.Point(106, 73);
            this.MergeStyleComboBox.Name = "MergeStyleComboBox";
            this.MergeStyleComboBox.Size = new System.Drawing.Size(235, 21);
            this.MergeStyleComboBox.TabIndex = 4;
            this.MergeStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.MergeStyleComboBox_SelectedIndexChanged);
            // 
            // MergeSizeComboBox
            // 
            this.MergeSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MergeSizeComboBox.FormattingEnabled = true;
            this.MergeSizeComboBox.Items.AddRange(new object[] {
            "Crop",
            "Resize Area",
            "Resize Image",
            "Tile Image"});
            this.MergeSizeComboBox.Location = new System.Drawing.Point(106, 42);
            this.MergeSizeComboBox.Name = "MergeSizeComboBox";
            this.MergeSizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.MergeSizeComboBox.TabIndex = 2;
            // 
            // MergePercentHighLabel
            // 
            this.MergePercentHighLabel.AutoSize = true;
            this.MergePercentHighLabel.Location = new System.Drawing.Point(7, 138);
            this.MergePercentHighLabel.Name = "MergePercentHighLabel";
            this.MergePercentHighLabel.Size = new System.Drawing.Size(73, 13);
            this.MergePercentHighLabel.TabIndex = 7;
            this.MergePercentHighLabel.Text = "Merge % High";
            // 
            // MergePercentLowLabel
            // 
            this.MergePercentLowLabel.AutoSize = true;
            this.MergePercentLowLabel.Location = new System.Drawing.Point(7, 108);
            this.MergePercentLowLabel.Name = "MergePercentLowLabel";
            this.MergePercentLowLabel.Size = new System.Drawing.Size(71, 13);
            this.MergePercentLowLabel.TabIndex = 5;
            this.MergePercentLowLabel.Text = "Merge % Low";
            // 
            // MergeStyleLabel
            // 
            this.MergeStyleLabel.AutoSize = true;
            this.MergeStyleLabel.Location = new System.Drawing.Point(7, 77);
            this.MergeStyleLabel.Name = "MergeStyleLabel";
            this.MergeStyleLabel.Size = new System.Drawing.Size(66, 13);
            this.MergeStyleLabel.TabIndex = 3;
            this.MergeStyleLabel.Text = "Merge Style:";
            // 
            // MergeSizeLabel
            // 
            this.MergeSizeLabel.AutoSize = true;
            this.MergeSizeLabel.Location = new System.Drawing.Point(7, 46);
            this.MergeSizeLabel.Name = "MergeSizeLabel";
            this.MergeSizeLabel.Size = new System.Drawing.Size(63, 13);
            this.MergeSizeLabel.TabIndex = 1;
            this.MergeSizeLabel.Text = "Merge Size:";
            // 
            // MergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 706);
            this.Controls.Add(this.MergeGroupBox);
            this.Name = "MergeForm";
            this.Text = "Merge";
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.MergeGroupBox, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.MergeGroupBox.ResumeLayout(false);
            this.MergeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MergePercentHighNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MergePercentLowNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MergeGroupBox;
        private System.Windows.Forms.Label TransparentColorLabel;
        private System.Windows.Forms.Button TransparentColorButton;
        private System.Windows.Forms.NumericUpDown MergePercentHighNumericUpDown;
        private System.Windows.Forms.NumericUpDown MergePercentLowNumericUpDown;
        private System.Windows.Forms.CheckBox TransparentCheckBox;
        private System.Windows.Forms.ComboBox MergeStyleComboBox;
        private System.Windows.Forms.ComboBox MergeSizeComboBox;
        private System.Windows.Forms.Label MergePercentHighLabel;
        private System.Windows.Forms.Label MergePercentLowLabel;
        private System.Windows.Forms.Label MergeStyleLabel;
        private System.Windows.Forms.Label MergeSizeLabel;
        private System.Windows.Forms.Label SourceImageLabel;
        private System.Windows.Forms.TextBox SourceImageTextBox;
        private System.Windows.Forms.Button BrowseButton;
    }
}