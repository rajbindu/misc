namespace ImagXpressDemo
{
    partial class SaveOptionsPicForm
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
            this.PicGroupBox = new System.Windows.Forms.GroupBox();
            this.PicPasswordLabel = new System.Windows.Forms.Label();
            this.PicPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PicGroupBox.SuspendLayout();
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
            // PicGroupBox
            // 
            this.PicGroupBox.Controls.Add(this.PicPasswordLabel);
            this.PicGroupBox.Controls.Add(this.PicPasswordTextBox);
            this.PicGroupBox.Location = new System.Drawing.Point(12, 12);
            this.PicGroupBox.Name = "PicGroupBox";
            this.PicGroupBox.Size = new System.Drawing.Size(241, 55);
            this.PicGroupBox.TabIndex = 0;
            this.PicGroupBox.TabStop = false;
            this.PicGroupBox.Text = "PIC";
            // 
            // PicPasswordLabel
            // 
            this.PicPasswordLabel.AutoSize = true;
            this.PicPasswordLabel.Location = new System.Drawing.Point(13, 25);
            this.PicPasswordLabel.Name = "PicPasswordLabel";
            this.PicPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PicPasswordLabel.TabIndex = 0;
            this.PicPasswordLabel.Text = "Password:";
            // 
            // PicPasswordTextBox
            // 
            this.PicPasswordTextBox.Location = new System.Drawing.Point(103, 22);
            this.PicPasswordTextBox.Name = "PicPasswordTextBox";
            this.PicPasswordTextBox.Size = new System.Drawing.Size(121, 20);
            this.PicPasswordTextBox.TabIndex = 1;
            // 
            // SaveOptionsPicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 77);
            this.Controls.Add(this.PicGroupBox);
            this.Name = "SaveOptionsPicForm";
            this.Text = "Save Options - PIC";
            this.Load += new System.EventHandler(this.SaveOptionsPicForm_Load);
            this.Controls.SetChildIndex(this.PicGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.PicGroupBox.ResumeLayout(false);
            this.PicGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PicGroupBox;
        private System.Windows.Forms.Label PicPasswordLabel;
        private System.Windows.Forms.TextBox PicPasswordTextBox;
    }
}