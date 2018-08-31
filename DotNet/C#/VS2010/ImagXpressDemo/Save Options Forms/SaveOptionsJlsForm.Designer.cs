namespace ImagXpressDemo
{
    partial class SaveOptionsJlsForm
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
            this.JlsGroupBox = new System.Windows.Forms.GroupBox();
            this.NearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NearLabel = new System.Windows.Forms.Label();
            this.PointPrecisionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PointPrecisionLabel = new System.Windows.Forms.Label();
            this.MaxValueLabel = new System.Windows.Forms.Label();
            this.MaxValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InterleaveLabel = new System.Windows.Forms.Label();
            this.InterleaveComboBox = new System.Windows.Forms.ComboBox();
            this.JlsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointPrecisionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxValueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.TabIndex = 2;
            // 
            // CancelOptionsButton
            // 
            this.CancelOptionsButton.TabIndex = 0;
            // 
            // JlsGroupBox
            // 
            this.JlsGroupBox.Controls.Add(this.NearNumericUpDown);
            this.JlsGroupBox.Controls.Add(this.NearLabel);
            this.JlsGroupBox.Controls.Add(this.PointPrecisionNumericUpDown);
            this.JlsGroupBox.Controls.Add(this.PointPrecisionLabel);
            this.JlsGroupBox.Controls.Add(this.MaxValueLabel);
            this.JlsGroupBox.Controls.Add(this.MaxValueNumericUpDown);
            this.JlsGroupBox.Controls.Add(this.InterleaveLabel);
            this.JlsGroupBox.Controls.Add(this.InterleaveComboBox);
            this.JlsGroupBox.Location = new System.Drawing.Point(9, 12);
            this.JlsGroupBox.Name = "JlsGroupBox";
            this.JlsGroupBox.Size = new System.Drawing.Size(363, 164);
            this.JlsGroupBox.TabIndex = 1;
            this.JlsGroupBox.TabStop = false;
            this.JlsGroupBox.Text = "JLS";
            // 
            // NearNumericUpDown
            // 
            this.NearNumericUpDown.Location = new System.Drawing.Point(242, 125);
            this.NearNumericUpDown.Name = "NearNumericUpDown";
            this.NearNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.NearNumericUpDown.TabIndex = 7;
            // 
            // NearLabel
            // 
            this.NearLabel.AutoSize = true;
            this.NearLabel.Location = new System.Drawing.Point(6, 127);
            this.NearLabel.Name = "NearLabel";
            this.NearLabel.Size = new System.Drawing.Size(230, 13);
            this.NearLabel.TabIndex = 6;
            this.NearLabel.Text = "Error Tolerance for Near-Lossless Compression:";
            // 
            // PointPrecisionNumericUpDown
            // 
            this.PointPrecisionNumericUpDown.Location = new System.Drawing.Point(242, 95);
            this.PointPrecisionNumericUpDown.Name = "PointPrecisionNumericUpDown";
            this.PointPrecisionNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.PointPrecisionNumericUpDown.TabIndex = 5;
            // 
            // PointPrecisionLabel
            // 
            this.PointPrecisionLabel.AutoSize = true;
            this.PointPrecisionLabel.Location = new System.Drawing.Point(6, 95);
            this.PointPrecisionLabel.Name = "PointPrecisionLabel";
            this.PointPrecisionLabel.Size = new System.Drawing.Size(92, 13);
            this.PointPrecisionLabel.TabIndex = 4;
            this.PointPrecisionLabel.Text = "Precision of Point:";
            // 
            // MaxValueLabel
            // 
            this.MaxValueLabel.AutoSize = true;
            this.MaxValueLabel.Location = new System.Drawing.Point(6, 59);
            this.MaxValueLabel.Name = "MaxValueLabel";
            this.MaxValueLabel.Size = new System.Drawing.Size(98, 13);
            this.MaxValueLabel.TabIndex = 2;
            this.MaxValueLabel.Text = "Max Value of Near:";
            // 
            // MaxValueNumericUpDown
            // 
            this.MaxValueNumericUpDown.Location = new System.Drawing.Point(242, 57);
            this.MaxValueNumericUpDown.Name = "MaxValueNumericUpDown";
            this.MaxValueNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.MaxValueNumericUpDown.TabIndex = 3;
            // 
            // InterleaveLabel
            // 
            this.InterleaveLabel.AutoSize = true;
            this.InterleaveLabel.Location = new System.Drawing.Point(6, 26);
            this.InterleaveLabel.Name = "InterleaveLabel";
            this.InterleaveLabel.Size = new System.Drawing.Size(57, 13);
            this.InterleaveLabel.TabIndex = 0;
            this.InterleaveLabel.Text = "Interleave:";
            // 
            // InterleaveComboBox
            // 
            this.InterleaveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InterleaveComboBox.FormattingEnabled = true;
            this.InterleaveComboBox.Items.AddRange(new object[] {
            "NonInterleaved",
            "Line Interleaved",
            "Sample Interleaved"});
            this.InterleaveComboBox.Location = new System.Drawing.Point(242, 23);
            this.InterleaveComboBox.Name = "InterleaveComboBox";
            this.InterleaveComboBox.Size = new System.Drawing.Size(115, 21);
            this.InterleaveComboBox.TabIndex = 1;
            // 
            // SaveOptionsJlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 189);
            this.Controls.Add(this.JlsGroupBox);
            this.Name = "SaveOptionsJlsForm";
            this.Text = "Save Options - JLS";
            this.Load += new System.EventHandler(this.SaveOptionsJlsForm_Load);
            this.Controls.SetChildIndex(this.JlsGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.JlsGroupBox.ResumeLayout(false);
            this.JlsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointPrecisionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxValueNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox JlsGroupBox;
        private System.Windows.Forms.NumericUpDown MaxValueNumericUpDown;
        private System.Windows.Forms.Label InterleaveLabel;
        private System.Windows.Forms.ComboBox InterleaveComboBox;
        private System.Windows.Forms.Label NearLabel;
        private System.Windows.Forms.NumericUpDown PointPrecisionNumericUpDown;
        private System.Windows.Forms.Label PointPrecisionLabel;
        private System.Windows.Forms.Label MaxValueLabel;
        private System.Windows.Forms.NumericUpDown NearNumericUpDown;
    }
}