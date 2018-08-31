namespace ImagXpressDemo
{
    partial class ResizeForm
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
            this.ResizeGroupBox = new System.Windows.Forms.GroupBox();
            this.NewSizeLabel = new System.Windows.Forms.Label();
            this.SizesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SizeHeightLabel = new System.Windows.Forms.Label();
            this.SizeWidthLabel = new System.Windows.Forms.Label();
            this.SizeWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SizeHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ResizeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.PreserveBlackResizeCheckBox = new System.Windows.Forms.CheckBox();
            this.ScaleResizeToGrayCheckBox = new System.Windows.Forms.CheckBox();
            this.ResizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeHeightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(372, 554);
            this.PreviewButton.TabIndex = 4;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 554);
            this.OKButton.TabIndex = 3;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(652, 554);
            this.CancelProcessingButton.TabIndex = 5;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.Location = new System.Drawing.Point(592, 436);
            this.RightClickLabel.TabIndex = 6;
            // 
            // ResizeGroupBox
            // 
            this.ResizeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResizeGroupBox.Controls.Add(this.NewSizeLabel);
            this.ResizeGroupBox.Controls.Add(this.SizesComboBox);
            this.ResizeGroupBox.Controls.Add(this.label1);
            this.ResizeGroupBox.Controls.Add(this.SizeHeightLabel);
            this.ResizeGroupBox.Controls.Add(this.SizeWidthLabel);
            this.ResizeGroupBox.Controls.Add(this.SizeWidthNumericUpDown);
            this.ResizeGroupBox.Controls.Add(this.SizeHeightNumericUpDown);
            this.ResizeGroupBox.Controls.Add(this.ResizeTypeComboBox);
            this.ResizeGroupBox.Controls.Add(this.PreserveBlackResizeCheckBox);
            this.ResizeGroupBox.Controls.Add(this.ScaleResizeToGrayCheckBox);
            this.ResizeGroupBox.Location = new System.Drawing.Point(12, 430);
            this.ResizeGroupBox.Name = "ResizeGroupBox";
            this.ResizeGroupBox.Size = new System.Drawing.Size(404, 112);
            this.ResizeGroupBox.TabIndex = 2;
            this.ResizeGroupBox.TabStop = false;
            this.ResizeGroupBox.Text = "Resize";
            // 
            // NewSizeLabel
            // 
            this.NewSizeLabel.AutoSize = true;
            this.NewSizeLabel.Location = new System.Drawing.Point(201, 21);
            this.NewSizeLabel.Name = "NewSizeLabel";
            this.NewSizeLabel.Size = new System.Drawing.Size(55, 13);
            this.NewSizeLabel.TabIndex = 9;
            this.NewSizeLabel.Text = "New Size:";
            // 
            // SizesComboBox
            // 
            this.SizesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizesComboBox.FormattingEnabled = true;
            this.SizesComboBox.Items.AddRange(new object[] {
            "320 x 240",
            "640 x 480",
            "800 x 600",
            "1024 x 768",
            "1280 x 720",
            "1280 x 1024",
            "Half",
            "Double",
            "Custom"});
            this.SizesComboBox.Location = new System.Drawing.Point(262, 17);
            this.SizesComboBox.Name = "SizesComboBox";
            this.SizesComboBox.Size = new System.Drawing.Size(136, 21);
            this.SizesComboBox.TabIndex = 8;
            this.SizesComboBox.SelectedIndexChanged += new System.EventHandler(this.SizesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resize Type:";
            // 
            // SizeHeightLabel
            // 
            this.SizeHeightLabel.AutoSize = true;
            this.SizeHeightLabel.Location = new System.Drawing.Point(201, 80);
            this.SizeHeightLabel.Name = "SizeHeightLabel";
            this.SizeHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.SizeHeightLabel.TabIndex = 4;
            this.SizeHeightLabel.Text = "Height:";
            // 
            // SizeWidthLabel
            // 
            this.SizeWidthLabel.AutoSize = true;
            this.SizeWidthLabel.Location = new System.Drawing.Point(201, 55);
            this.SizeWidthLabel.Name = "SizeWidthLabel";
            this.SizeWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.SizeWidthLabel.TabIndex = 2;
            this.SizeWidthLabel.Text = "Width:";
            // 
            // SizeWidthNumericUpDown
            // 
            this.SizeWidthNumericUpDown.Location = new System.Drawing.Point(262, 50);
            this.SizeWidthNumericUpDown.Name = "SizeWidthNumericUpDown";
            this.SizeWidthNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.SizeWidthNumericUpDown.TabIndex = 3;
            // 
            // SizeHeightNumericUpDown
            // 
            this.SizeHeightNumericUpDown.Location = new System.Drawing.Point(262, 76);
            this.SizeHeightNumericUpDown.Name = "SizeHeightNumericUpDown";
            this.SizeHeightNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.SizeHeightNumericUpDown.TabIndex = 5;
            // 
            // ResizeTypeComboBox
            // 
            this.ResizeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResizeTypeComboBox.FormattingEnabled = true;
            this.ResizeTypeComboBox.Items.AddRange(new object[] {
            "Quality",
            "Fast"});
            this.ResizeTypeComboBox.Location = new System.Drawing.Point(87, 76);
            this.ResizeTypeComboBox.Name = "ResizeTypeComboBox";
            this.ResizeTypeComboBox.Size = new System.Drawing.Size(98, 21);
            this.ResizeTypeComboBox.TabIndex = 7;
            // 
            // PreserveBlackResizeCheckBox
            // 
            this.PreserveBlackResizeCheckBox.AutoSize = true;
            this.PreserveBlackResizeCheckBox.Location = new System.Drawing.Point(87, 51);
            this.PreserveBlackResizeCheckBox.Name = "PreserveBlackResizeCheckBox";
            this.PreserveBlackResizeCheckBox.Size = new System.Drawing.Size(98, 17);
            this.PreserveBlackResizeCheckBox.TabIndex = 1;
            this.PreserveBlackResizeCheckBox.Text = "Preserve Black";
            this.PreserveBlackResizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ScaleResizeToGrayCheckBox
            // 
            this.ScaleResizeToGrayCheckBox.AutoSize = true;
            this.ScaleResizeToGrayCheckBox.Location = new System.Drawing.Point(87, 19);
            this.ScaleResizeToGrayCheckBox.Name = "ScaleResizeToGrayCheckBox";
            this.ScaleResizeToGrayCheckBox.Size = new System.Drawing.Size(90, 17);
            this.ScaleResizeToGrayCheckBox.TabIndex = 0;
            this.ScaleResizeToGrayCheckBox.Text = "Scale to Gray";
            this.ScaleResizeToGrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 585);
            this.Controls.Add(this.ResizeGroupBox);
            this.Name = "ResizeForm";
            this.Text = "Resize";
            this.Load += new System.EventHandler(this.ResizeForm_Load);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.Controls.SetChildIndex(this.ResizeGroupBox, 0);
            this.ResizeGroupBox.ResumeLayout(false);
            this.ResizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeHeightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ResizeGroupBox;
        private System.Windows.Forms.Label SizeWidthLabel;
        private System.Windows.Forms.NumericUpDown SizeWidthNumericUpDown;
        private System.Windows.Forms.ComboBox ResizeTypeComboBox;
        private System.Windows.Forms.CheckBox PreserveBlackResizeCheckBox;
        private System.Windows.Forms.CheckBox ScaleResizeToGrayCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SizeHeightLabel;
        private System.Windows.Forms.NumericUpDown SizeHeightNumericUpDown;
        private System.Windows.Forms.ComboBox SizesComboBox;
        private System.Windows.Forms.Label NewSizeLabel;
    }
}