namespace ImagXpressDemo
{
    partial class AlphaFlattenForm
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
            this.AlphaFlattenGroupBox = new System.Windows.Forms.GroupBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.AlphaFlattenGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(373, 499);
            this.PreviewButton.TabIndex = 5;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(13, 499);
            this.OKButton.TabIndex = 4;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(653, 499);
            this.CancelProcessingButton.TabIndex = 6;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.TabIndex = 0;
            // 
            // AlphaFlattenGroupBox
            // 
            this.AlphaFlattenGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AlphaFlattenGroupBox.Controls.Add(this.ColorButton);
            this.AlphaFlattenGroupBox.Controls.Add(this.ColorLabel);
            this.AlphaFlattenGroupBox.Location = new System.Drawing.Point(12, 436);
            this.AlphaFlattenGroupBox.Name = "AlphaFlattenGroupBox";
            this.AlphaFlattenGroupBox.Size = new System.Drawing.Size(100, 55);
            this.AlphaFlattenGroupBox.TabIndex = 2;
            this.AlphaFlattenGroupBox.TabStop = false;
            this.AlphaFlattenGroupBox.Text = "Alpha Flatten";
            // 
            // ColorButton
            // 
            this.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorButton.Location = new System.Drawing.Point(59, 25);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(24, 23);
            this.ColorButton.TabIndex = 1;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(18, 30);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 0;
            this.ColorLabel.Text = "Color:";
            // 
            // AlphaFlattenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 534);
            this.Controls.Add(this.AlphaFlattenGroupBox);
            this.Name = "AlphaFlattenForm";
            this.Text = "Alpha Flatten";
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.AlphaFlattenGroupBox, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.AlphaFlattenGroupBox.ResumeLayout(false);
            this.AlphaFlattenGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AlphaFlattenGroupBox;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Label ColorLabel;
    }
}