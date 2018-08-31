namespace ImagXpressDemo
{
    partial class CropBorderForm
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
            this.CropGroupBox = new System.Windows.Forms.GroupBox();
            this.UpperLeftLabel = new System.Windows.Forms.Label();
            this.CropTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CropTypeLabel = new System.Windows.Forms.Label();
            this.PercentToCropLabel = new System.Windows.Forms.Label();
            this.PercentToCropNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LeftLabel = new System.Windows.Forms.Label();
            this.TopNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TopLabel = new System.Windows.Forms.Label();
            this.LeftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CropGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentToCropNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(372, 520);
            this.PreviewButton.TabIndex = 4;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 520);
            this.OKButton.TabIndex = 3;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(652, 520);
            this.CancelProcessingButton.TabIndex = 5;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.Location = new System.Drawing.Point(592, 445);
            this.RightClickLabel.TabIndex = 6;
            // 
            // CropGroupBox
            // 
            this.CropGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CropGroupBox.Controls.Add(this.UpperLeftLabel);
            this.CropGroupBox.Controls.Add(this.CropTypeComboBox);
            this.CropGroupBox.Controls.Add(this.CropTypeLabel);
            this.CropGroupBox.Controls.Add(this.PercentToCropLabel);
            this.CropGroupBox.Controls.Add(this.PercentToCropNumericUpDown);
            this.CropGroupBox.Controls.Add(this.LeftLabel);
            this.CropGroupBox.Controls.Add(this.TopNumericUpDown);
            this.CropGroupBox.Controls.Add(this.TopLabel);
            this.CropGroupBox.Controls.Add(this.LeftNumericUpDown);
            this.CropGroupBox.Location = new System.Drawing.Point(12, 433);
            this.CropGroupBox.Name = "CropGroupBox";
            this.CropGroupBox.Size = new System.Drawing.Size(389, 76);
            this.CropGroupBox.TabIndex = 2;
            this.CropGroupBox.TabStop = false;
            // 
            // UpperLeftLabel
            // 
            this.UpperLeftLabel.AutoSize = true;
            this.UpperLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperLeftLabel.Location = new System.Drawing.Point(208, 16);
            this.UpperLeftLabel.Name = "UpperLeftLabel";
            this.UpperLeftLabel.Size = new System.Drawing.Size(71, 13);
            this.UpperLeftLabel.TabIndex = 9;
            this.UpperLeftLabel.Text = "Upper Left:";
            // 
            // CropTypeComboBox
            // 
            this.CropTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CropTypeComboBox.FormattingEnabled = true;
            this.CropTypeComboBox.Items.AddRange(new object[] {
            "Border Background Color",
            "Border Foreground Color",
            "Border Black Color",
            "Border White Color"});
            this.CropTypeComboBox.Location = new System.Drawing.Point(113, 40);
            this.CropTypeComboBox.Name = "CropTypeComboBox";
            this.CropTypeComboBox.Size = new System.Drawing.Size(157, 21);
            this.CropTypeComboBox.TabIndex = 3;
            this.CropTypeComboBox.Visible = false;
            // 
            // CropTypeLabel
            // 
            this.CropTypeLabel.AutoSize = true;
            this.CropTypeLabel.Location = new System.Drawing.Point(15, 44);
            this.CropTypeLabel.Name = "CropTypeLabel";
            this.CropTypeLabel.Size = new System.Drawing.Size(59, 13);
            this.CropTypeLabel.TabIndex = 2;
            this.CropTypeLabel.Text = "Crop Type:";
            this.CropTypeLabel.Visible = false;
            // 
            // PercentToCropLabel
            // 
            this.PercentToCropLabel.AutoSize = true;
            this.PercentToCropLabel.Location = new System.Drawing.Point(15, 16);
            this.PercentToCropLabel.Name = "PercentToCropLabel";
            this.PercentToCropLabel.Size = new System.Drawing.Size(88, 13);
            this.PercentToCropLabel.TabIndex = 0;
            this.PercentToCropLabel.Text = "Percent To Crop:";
            // 
            // PercentToCropNumericUpDown
            // 
            this.PercentToCropNumericUpDown.DecimalPlaces = 2;
            this.PercentToCropNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PercentToCropNumericUpDown.Location = new System.Drawing.Point(113, 12);
            this.PercentToCropNumericUpDown.Name = "PercentToCropNumericUpDown";
            this.PercentToCropNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.PercentToCropNumericUpDown.TabIndex = 1;
            // 
            // LeftLabel
            // 
            this.LeftLabel.AutoSize = true;
            this.LeftLabel.Location = new System.Drawing.Point(285, 16);
            this.LeftLabel.Name = "LeftLabel";
            this.LeftLabel.Size = new System.Drawing.Size(28, 13);
            this.LeftLabel.TabIndex = 5;
            this.LeftLabel.Text = "Left:";
            this.LeftLabel.Visible = false;
            // 
            // TopNumericUpDown
            // 
            this.TopNumericUpDown.Location = new System.Drawing.Point(318, 40);
            this.TopNumericUpDown.Name = "TopNumericUpDown";
            this.TopNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.TopNumericUpDown.TabIndex = 8;
            this.TopNumericUpDown.Visible = false;
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Location = new System.Drawing.Point(284, 44);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(29, 13);
            this.TopLabel.TabIndex = 7;
            this.TopLabel.Text = "Top:";
            this.TopLabel.Visible = false;
            // 
            // LeftNumericUpDown
            // 
            this.LeftNumericUpDown.Location = new System.Drawing.Point(319, 12);
            this.LeftNumericUpDown.Name = "LeftNumericUpDown";
            this.LeftNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.LeftNumericUpDown.TabIndex = 6;
            this.LeftNumericUpDown.Visible = false;
            // 
            // CropBorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 552);
            this.Controls.Add(this.CropGroupBox);
            this.Name = "CropBorderForm";
            this.Text = "";
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.Controls.SetChildIndex(this.CropGroupBox, 0);
            this.CropGroupBox.ResumeLayout(false);
            this.CropGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentToCropNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CropGroupBox;
        private System.Windows.Forms.ComboBox CropTypeComboBox;
        private System.Windows.Forms.Label CropTypeLabel;
        private System.Windows.Forms.Label PercentToCropLabel;
        private System.Windows.Forms.NumericUpDown PercentToCropNumericUpDown;
        private System.Windows.Forms.NumericUpDown TopNumericUpDown;
        private System.Windows.Forms.NumericUpDown LeftNumericUpDown;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label LeftLabel;
        private System.Windows.Forms.Label UpperLeftLabel;
    }
}