namespace ImagXpressDemo
{
    partial class IsisScanForm
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
            isisXpressInstance.Scanned -= isisXpressInstance_Scanned;

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
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AcquireButton
            // 
            this.AcquireButton.Click += new System.EventHandler(this.AcquireButton_Click);
            // 
            // SelectSourceButton
            // 
            this.SelectSourceButton.Click += new System.EventHandler(this.SelectSourceButton_Click);
            // 
            // imageXView1
            // 
            this.imageXView1.TabIndex = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(9, 60);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // IsisScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 545);
            this.Controls.Add(this.SettingsButton);
            this.Name = "IsisScanForm";
            this.Text = "ISIS Scan";
            this.Load += new System.EventHandler(this.IsisScanForm_Load);
            this.Controls.SetChildIndex(this.PageCountLabel, 0);
            this.Controls.SetChildIndex(this.CancelScanButton, 0);
            this.Controls.SetChildIndex(this.NextButton, 0);
            this.Controls.SetChildIndex(this.PreviousButton, 0);
            this.Controls.SetChildIndex(this.PageLabel, 0);
            this.Controls.SetChildIndex(this.SettingsButton, 0);
            this.Controls.SetChildIndex(this.SelectSourceButton, 0);
            this.Controls.SetChildIndex(this.AcquireButton, 0);
            this.Controls.SetChildIndex(this.imageXView1, 0);
            this.Controls.SetChildIndex(this.AcceptImageButton, 0);
            this.Controls.SetChildIndex(this.PageTextBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SettingsButton;
    }
}