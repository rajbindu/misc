namespace ImagXpressDemo
{
    partial class IntensityForm
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
            this.IntensityGroupBox = new System.Windows.Forms.GroupBox();
            this.IntensityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IntensityLabel = new System.Windows.Forms.Label();
            this.IntensityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(373, 483);
            this.PreviewButton.TabIndex = 4;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(13, 483);
            this.OKButton.TabIndex = 3;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(653, 483);
            this.CancelProcessingButton.TabIndex = 5;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.TabIndex = 6;
            // 
            // IntensityGroupBox
            // 
            this.IntensityGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IntensityGroupBox.Controls.Add(this.IntensityNumericUpDown);
            this.IntensityGroupBox.Controls.Add(this.IntensityLabel);
            this.IntensityGroupBox.Location = new System.Drawing.Point(12, 433);
            this.IntensityGroupBox.Name = "IntensityGroupBox";
            this.IntensityGroupBox.Size = new System.Drawing.Size(146, 46);
            this.IntensityGroupBox.TabIndex = 2;
            this.IntensityGroupBox.TabStop = false;
            // 
            // IntensityNumericUpDown
            // 
            this.IntensityNumericUpDown.Location = new System.Drawing.Point(70, 16);
            this.IntensityNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.IntensityNumericUpDown.Name = "IntensityNumericUpDown";
            this.IntensityNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.IntensityNumericUpDown.TabIndex = 1;
            // 
            // IntensityLabel
            // 
            this.IntensityLabel.AutoSize = true;
            this.IntensityLabel.Location = new System.Drawing.Point(18, 20);
            this.IntensityLabel.Name = "IntensityLabel";
            this.IntensityLabel.Size = new System.Drawing.Size(49, 13);
            this.IntensityLabel.TabIndex = 0;
            this.IntensityLabel.Text = "Intensity:";
            // 
            // IntensityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 518);
            this.Controls.Add(this.IntensityGroupBox);
            this.Name = "IntensityForm";
            this.Text = "";
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.IntensityGroupBox, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.IntensityGroupBox.ResumeLayout(false);
            this.IntensityGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox IntensityGroupBox;
        private System.Windows.Forms.NumericUpDown IntensityNumericUpDown;
        private System.Windows.Forms.Label IntensityLabel;
    }
}