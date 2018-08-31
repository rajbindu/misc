namespace ImagXpressDemo
{
    partial class SaveOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveOptionsForm));
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelOptionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 12);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "Ok";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelOptionsButton
            // 
            this.CancelOptionsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelOptionsButton.Location = new System.Drawing.Point(378, 12);
            this.CancelOptionsButton.Name = "CancelOptionsButton";
            this.CancelOptionsButton.Size = new System.Drawing.Size(75, 23);
            this.CancelOptionsButton.TabIndex = 1;
            this.CancelOptionsButton.Text = "Cancel";
            this.CancelOptionsButton.UseVisualStyleBackColor = true;
            this.CancelOptionsButton.Click += new System.EventHandler(this.CancelOptionsForm_Click);
            // 
            // SaveOptionsForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelOptionsButton;
            this.ClientSize = new System.Drawing.Size(461, 43);
            this.Controls.Add(this.CancelOptionsButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SaveOptionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save Options";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button OKButton;
        protected System.Windows.Forms.Button CancelOptionsButton;
    }
}