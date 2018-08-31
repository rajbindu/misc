namespace ImagXpressDemo
{
    partial class SaveOptionsDcxForm
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
            this.DcxGroupBox = new System.Windows.Forms.GroupBox();
            this.MultiPageCheckBox = new System.Windows.Forms.CheckBox();
            this.DcxGroupBox.SuspendLayout();
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
            // DcxGroupBox
            // 
            this.DcxGroupBox.Controls.Add(this.MultiPageCheckBox);
            this.DcxGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DcxGroupBox.Name = "DcxGroupBox";
            this.DcxGroupBox.Size = new System.Drawing.Size(134, 42);
            this.DcxGroupBox.TabIndex = 0;
            this.DcxGroupBox.TabStop = false;
            this.DcxGroupBox.Text = "DCX";
            // 
            // MultiPageCheckBox
            // 
            this.MultiPageCheckBox.AutoSize = true;
            this.MultiPageCheckBox.Location = new System.Drawing.Point(31, 15);
            this.MultiPageCheckBox.Name = "MultiPageCheckBox";
            this.MultiPageCheckBox.Size = new System.Drawing.Size(73, 17);
            this.MultiPageCheckBox.TabIndex = 0;
            this.MultiPageCheckBox.Text = "MultiPage";
            this.MultiPageCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveOptionsDcxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 65);
            this.Controls.Add(this.DcxGroupBox);
            this.Name = "SaveOptionsDcxForm";
            this.Text = "Save Options - DCX";
            this.Load += new System.EventHandler(this.SaveOptionsDcxForm_Load);
            this.Controls.SetChildIndex(this.DcxGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.DcxGroupBox.ResumeLayout(false);
            this.DcxGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DcxGroupBox;
        private System.Windows.Forms.CheckBox MultiPageCheckBox;
    }
}