namespace ImagXpressDemo
{
    partial class SaveOptionsPngForm
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
            this.PngGroupBox = new System.Windows.Forms.GroupBox();
            this.TransparencyColorLabel = new System.Windows.Forms.Label();
            this.TransparencyColorButton = new System.Windows.Forms.Button();
            this.TransparencyMatchComboBox = new System.Windows.Forms.ComboBox();
            this.InterlacedCheckBox = new System.Windows.Forms.CheckBox();
            this.TransparencyMatchLabel = new System.Windows.Forms.Label();
            this.PngGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.TabIndex = 1;
            // 
            // CancelOptionsButton
            // 
            this.CancelOptionsButton.TabIndex = 2;
            // 
            // PngGroupBox
            // 
            this.PngGroupBox.Controls.Add(this.TransparencyColorLabel);
            this.PngGroupBox.Controls.Add(this.TransparencyColorButton);
            this.PngGroupBox.Controls.Add(this.TransparencyMatchComboBox);
            this.PngGroupBox.Controls.Add(this.InterlacedCheckBox);
            this.PngGroupBox.Controls.Add(this.TransparencyMatchLabel);
            this.PngGroupBox.Location = new System.Drawing.Point(12, 12);
            this.PngGroupBox.Name = "PngGroupBox";
            this.PngGroupBox.Size = new System.Drawing.Size(318, 81);
            this.PngGroupBox.TabIndex = 0;
            this.PngGroupBox.TabStop = false;
            this.PngGroupBox.Text = "PNG";
            // 
            // TransparencyColorLabel
            // 
            this.TransparencyColorLabel.AutoSize = true;
            this.TransparencyColorLabel.Location = new System.Drawing.Point(17, 49);
            this.TransparencyColorLabel.Name = "TransparencyColorLabel";
            this.TransparencyColorLabel.Size = new System.Drawing.Size(102, 13);
            this.TransparencyColorLabel.TabIndex = 3;
            this.TransparencyColorLabel.Text = "Transparency Color:";
            // 
            // TransparencyColorButton
            // 
            this.TransparencyColorButton.BackColor = System.Drawing.Color.Turquoise;
            this.TransparencyColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransparencyColorButton.Location = new System.Drawing.Point(125, 44);
            this.TransparencyColorButton.Name = "TransparencyColorButton";
            this.TransparencyColorButton.Size = new System.Drawing.Size(28, 23);
            this.TransparencyColorButton.TabIndex = 4;
            this.TransparencyColorButton.UseVisualStyleBackColor = false;
            this.TransparencyColorButton.Click += new System.EventHandler(this.TransparencyColorButton_Click);
            // 
            // TransparencyMatchComboBox
            // 
            this.TransparencyMatchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransparencyMatchComboBox.FormattingEnabled = true;
            this.TransparencyMatchComboBox.Items.AddRange(new object[] {
            "None",
            "Closest",
            "Exact"});
            this.TransparencyMatchComboBox.Location = new System.Drawing.Point(125, 16);
            this.TransparencyMatchComboBox.Name = "TransparencyMatchComboBox";
            this.TransparencyMatchComboBox.Size = new System.Drawing.Size(99, 21);
            this.TransparencyMatchComboBox.TabIndex = 1;
            // 
            // InterlacedCheckBox
            // 
            this.InterlacedCheckBox.AutoSize = true;
            this.InterlacedCheckBox.Location = new System.Drawing.Point(239, 18);
            this.InterlacedCheckBox.Name = "InterlacedCheckBox";
            this.InterlacedCheckBox.Size = new System.Drawing.Size(73, 17);
            this.InterlacedCheckBox.TabIndex = 2;
            this.InterlacedCheckBox.Text = "Interlaced";
            this.InterlacedCheckBox.UseVisualStyleBackColor = true;
            // 
            // TransparencyMatchLabel
            // 
            this.TransparencyMatchLabel.AutoSize = true;
            this.TransparencyMatchLabel.Location = new System.Drawing.Point(17, 19);
            this.TransparencyMatchLabel.Name = "TransparencyMatchLabel";
            this.TransparencyMatchLabel.Size = new System.Drawing.Size(108, 13);
            this.TransparencyMatchLabel.TabIndex = 0;
            this.TransparencyMatchLabel.Text = "Transparency Match:";
            // 
            // SaveOptionsPngForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 103);
            this.Controls.Add(this.PngGroupBox);
            this.Name = "SaveOptionsPngForm";
            this.Text = "Save Options - PNG";
            this.Load += new System.EventHandler(this.SaveOptionsPngForm_Load);
            this.Controls.SetChildIndex(this.PngGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.PngGroupBox.ResumeLayout(false);
            this.PngGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PngGroupBox;
        private System.Windows.Forms.Label TransparencyColorLabel;
        private System.Windows.Forms.Button TransparencyColorButton;
        private System.Windows.Forms.ComboBox TransparencyMatchComboBox;
        private System.Windows.Forms.CheckBox InterlacedCheckBox;
        private System.Windows.Forms.Label TransparencyMatchLabel;
    }
}