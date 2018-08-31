namespace ImagXpressDemo
{
    partial class SaveOptionsModcaForm
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
            this.MoDcaGroupBox = new System.Windows.Forms.GroupBox();
            this.DocumentNameTextBox = new System.Windows.Forms.TextBox();
            this.DocumentNameLabel = new System.Windows.Forms.Label();
            this.MoDcaGroupBox.SuspendLayout();
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
            // MoDcaGroupBox
            // 
            this.MoDcaGroupBox.Controls.Add(this.DocumentNameTextBox);
            this.MoDcaGroupBox.Controls.Add(this.DocumentNameLabel);
            this.MoDcaGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MoDcaGroupBox.Name = "MoDcaGroupBox";
            this.MoDcaGroupBox.Size = new System.Drawing.Size(317, 55);
            this.MoDcaGroupBox.TabIndex = 0;
            this.MoDcaGroupBox.TabStop = false;
            this.MoDcaGroupBox.Text = "MO:DCA";
            // 
            // DocumentNameTextBox
            // 
            this.DocumentNameTextBox.Location = new System.Drawing.Point(110, 23);
            this.DocumentNameTextBox.Name = "DocumentNameTextBox";
            this.DocumentNameTextBox.Size = new System.Drawing.Size(197, 20);
            this.DocumentNameTextBox.TabIndex = 1;
            // 
            // DocumentNameLabel
            // 
            this.DocumentNameLabel.AutoSize = true;
            this.DocumentNameLabel.Location = new System.Drawing.Point(14, 26);
            this.DocumentNameLabel.Name = "DocumentNameLabel";
            this.DocumentNameLabel.Size = new System.Drawing.Size(90, 13);
            this.DocumentNameLabel.TabIndex = 0;
            this.DocumentNameLabel.Text = "Document Name:";
            // 
            // SaveOptionsModcaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 83);
            this.Controls.Add(this.MoDcaGroupBox);
            this.Name = "SaveOptionsModcaForm";
            this.Text = "SaveOptions - MO:DCA";
            this.Load += new System.EventHandler(this.SaveOptionsModcaForm_Load);
            this.Controls.SetChildIndex(this.MoDcaGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.MoDcaGroupBox.ResumeLayout(false);
            this.MoDcaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MoDcaGroupBox;
        private System.Windows.Forms.TextBox DocumentNameTextBox;
        private System.Windows.Forms.Label DocumentNameLabel;
    }
}