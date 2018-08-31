namespace ImagXpressDemo
{
    partial class MotionBlurForm
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
            this.MotionBlurGroupBox = new System.Windows.Forms.GroupBox();
            this.IntensityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VelocityXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VelocityYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VelocityYLabel = new System.Windows.Forms.Label();
            this.VelocityXLabel = new System.Windows.Forms.Label();
            this.IntensityLabel = new System.Windows.Forms.Label();
            this.MotionBlurGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityYNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(372, 539);
            this.PreviewButton.TabIndex = 4;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 539);
            this.OKButton.TabIndex = 3;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(652, 539);
            this.CancelProcessingButton.TabIndex = 5;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.TabIndex = 6;
            // 
            // MotionBlurGroupBox
            // 
            this.MotionBlurGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MotionBlurGroupBox.Controls.Add(this.IntensityNumericUpDown);
            this.MotionBlurGroupBox.Controls.Add(this.VelocityXNumericUpDown);
            this.MotionBlurGroupBox.Controls.Add(this.VelocityYNumericUpDown);
            this.MotionBlurGroupBox.Controls.Add(this.VelocityYLabel);
            this.MotionBlurGroupBox.Controls.Add(this.VelocityXLabel);
            this.MotionBlurGroupBox.Controls.Add(this.IntensityLabel);
            this.MotionBlurGroupBox.Location = new System.Drawing.Point(12, 433);
            this.MotionBlurGroupBox.Name = "MotionBlurGroupBox";
            this.MotionBlurGroupBox.Size = new System.Drawing.Size(164, 100);
            this.MotionBlurGroupBox.TabIndex = 2;
            this.MotionBlurGroupBox.TabStop = false;
            this.MotionBlurGroupBox.Text = "Motion Blur";
            // 
            // IntensityNumericUpDown
            // 
            this.IntensityNumericUpDown.Location = new System.Drawing.Point(96, 18);
            this.IntensityNumericUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.IntensityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntensityNumericUpDown.Name = "IntensityNumericUpDown";
            this.IntensityNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.IntensityNumericUpDown.TabIndex = 1;
            this.IntensityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // VelocityXNumericUpDown
            // 
            this.VelocityXNumericUpDown.Location = new System.Drawing.Point(96, 44);
            this.VelocityXNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.VelocityXNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.VelocityXNumericUpDown.Name = "VelocityXNumericUpDown";
            this.VelocityXNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.VelocityXNumericUpDown.TabIndex = 3;
            // 
            // VelocityYNumericUpDown
            // 
            this.VelocityYNumericUpDown.Location = new System.Drawing.Point(96, 70);
            this.VelocityYNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.VelocityYNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.VelocityYNumericUpDown.Name = "VelocityYNumericUpDown";
            this.VelocityYNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.VelocityYNumericUpDown.TabIndex = 5;
            // 
            // VelocityYLabel
            // 
            this.VelocityYLabel.AutoSize = true;
            this.VelocityYLabel.Location = new System.Drawing.Point(23, 74);
            this.VelocityYLabel.Name = "VelocityYLabel";
            this.VelocityYLabel.Size = new System.Drawing.Size(57, 13);
            this.VelocityYLabel.TabIndex = 4;
            this.VelocityYLabel.Text = "Velocity Y:";
            // 
            // VelocityXLabel
            // 
            this.VelocityXLabel.AutoSize = true;
            this.VelocityXLabel.Location = new System.Drawing.Point(23, 48);
            this.VelocityXLabel.Name = "VelocityXLabel";
            this.VelocityXLabel.Size = new System.Drawing.Size(57, 13);
            this.VelocityXLabel.TabIndex = 2;
            this.VelocityXLabel.Text = "Velocity X:";
            // 
            // IntensityLabel
            // 
            this.IntensityLabel.AutoSize = true;
            this.IntensityLabel.Location = new System.Drawing.Point(23, 22);
            this.IntensityLabel.Name = "IntensityLabel";
            this.IntensityLabel.Size = new System.Drawing.Size(49, 13);
            this.IntensityLabel.TabIndex = 0;
            this.IntensityLabel.Text = "Intensity:";
            // 
            // MotionBlurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 573);
            this.Controls.Add(this.MotionBlurGroupBox);
            this.Name = "MotionBlurForm";
            this.Text = "Motion Blur";
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.MotionBlurGroupBox, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.MotionBlurGroupBox.ResumeLayout(false);
            this.MotionBlurGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityYNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MotionBlurGroupBox;
        private System.Windows.Forms.NumericUpDown IntensityNumericUpDown;
        private System.Windows.Forms.NumericUpDown VelocityXNumericUpDown;
        private System.Windows.Forms.NumericUpDown VelocityYNumericUpDown;
        private System.Windows.Forms.Label VelocityYLabel;
        private System.Windows.Forms.Label VelocityXLabel;
        private System.Windows.Forms.Label IntensityLabel;
    }
}