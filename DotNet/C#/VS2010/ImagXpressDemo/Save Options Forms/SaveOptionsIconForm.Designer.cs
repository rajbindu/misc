namespace ImagXpressDemo
{
    partial class SaveOptionsIconForm
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
            this.IconGroupBox = new System.Windows.Forms.GroupBox();
            this.MultiPageCheckBox = new System.Windows.Forms.CheckBox();
            this.IconGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.TabIndex = 2;
            // 
            // IconGroupBox
            // 
            this.IconGroupBox.Controls.Add(this.MultiPageCheckBox);
            this.IconGroupBox.Location = new System.Drawing.Point(12, 12);
            this.IconGroupBox.Name = "IconGroupBox";
            this.IconGroupBox.Size = new System.Drawing.Size(130, 45);
            this.IconGroupBox.TabIndex = 0;
            this.IconGroupBox.TabStop = false;
            this.IconGroupBox.Text = "ICON";
            // 
            // MultiPageCheckBox
            // 
            this.MultiPageCheckBox.AutoSize = true;
            this.MultiPageCheckBox.Location = new System.Drawing.Point(29, 17);
            this.MultiPageCheckBox.Name = "MultiPageCheckBox";
            this.MultiPageCheckBox.Size = new System.Drawing.Size(73, 17);
            this.MultiPageCheckBox.TabIndex = 0;
            this.MultiPageCheckBox.Text = "MultiPage";
            this.MultiPageCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveOptionsIconForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 68);
            this.Controls.Add(this.IconGroupBox);
            this.Name = "SaveOptionsIconForm";
            this.Text = "Save Options - ICON";
            this.Load += new System.EventHandler(this.SaveOptionsIconForm_Load);
            this.Controls.SetChildIndex(this.IconGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.IconGroupBox.ResumeLayout(false);
            this.IconGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox IconGroupBox;
        private System.Windows.Forms.CheckBox MultiPageCheckBox;
    }
}