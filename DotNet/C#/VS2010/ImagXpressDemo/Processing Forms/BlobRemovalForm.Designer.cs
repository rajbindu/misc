namespace ImagXpressDemo
{
    partial class BlobRemovalForm
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
            if (imageXView1 != null)
            {
                this.imageXView1.MouseDown -= imageXView1_MouseDown;
                this.imageXView1.MouseMove -= imageXView1_MouseMove;
                this.imageXView1.MouseUp -= imageXView1_MouseUp;
            }

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
            this.BlobRemovalGroupBox = new System.Windows.Forms.GroupBox();
            this.MinimumDensityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinimumPixelCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaximumPixelCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinimumDensityLabel = new System.Windows.Forms.Label();
            this.MinimumPixelCountLabel = new System.Windows.Forms.Label();
            this.MaximumPixelCountLabel = new System.Windows.Forms.Label();
            this.MouseLabel = new System.Windows.Forms.Label();
            this.ImageWasModifiedLabel = new System.Windows.Forms.Label();
            this.CountOfBlobsFoundLabel = new System.Windows.Forms.Label();
            this.ImageWasModifiedValueLabel = new System.Windows.Forms.Label();
            this.CountOfBlobsFoundValueLabel = new System.Windows.Forms.Label();
            this.ResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.BlobRemovalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumDensityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumPixelCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumPixelCountNumericUpDown)).BeginInit();
            this.ResultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(370, 559);
            this.PreviewButton.TabIndex = 7;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(9, 559);
            this.OKButton.TabIndex = 6;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(650, 559);
            this.CancelProcessingButton.TabIndex = 8;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.TabIndex = 0;
            // 
            // BlobRemovalGroupBox
            // 
            this.BlobRemovalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BlobRemovalGroupBox.Controls.Add(this.MinimumDensityNumericUpDown);
            this.BlobRemovalGroupBox.Controls.Add(this.MinimumPixelCountNumericUpDown);
            this.BlobRemovalGroupBox.Controls.Add(this.MaximumPixelCountNumericUpDown);
            this.BlobRemovalGroupBox.Controls.Add(this.MinimumDensityLabel);
            this.BlobRemovalGroupBox.Controls.Add(this.MinimumPixelCountLabel);
            this.BlobRemovalGroupBox.Controls.Add(this.MaximumPixelCountLabel);
            this.BlobRemovalGroupBox.Location = new System.Drawing.Point(170, 433);
            this.BlobRemovalGroupBox.Name = "BlobRemovalGroupBox";
            this.BlobRemovalGroupBox.Size = new System.Drawing.Size(235, 115);
            this.BlobRemovalGroupBox.TabIndex = 3;
            this.BlobRemovalGroupBox.TabStop = false;
            this.BlobRemovalGroupBox.Text = "Blob Removal";
            // 
            // MinimumDensityNumericUpDown
            // 
            this.MinimumDensityNumericUpDown.Location = new System.Drawing.Point(137, 84);
            this.MinimumDensityNumericUpDown.Name = "MinimumDensityNumericUpDown";
            this.MinimumDensityNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.MinimumDensityNumericUpDown.TabIndex = 5;
            // 
            // MinimumPixelCountNumericUpDown
            // 
            this.MinimumPixelCountNumericUpDown.Location = new System.Drawing.Point(137, 51);
            this.MinimumPixelCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinimumPixelCountNumericUpDown.Name = "MinimumPixelCountNumericUpDown";
            this.MinimumPixelCountNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.MinimumPixelCountNumericUpDown.TabIndex = 3;
            this.MinimumPixelCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MaximumPixelCountNumericUpDown
            // 
            this.MaximumPixelCountNumericUpDown.Location = new System.Drawing.Point(137, 18);
            this.MaximumPixelCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaximumPixelCountNumericUpDown.Name = "MaximumPixelCountNumericUpDown";
            this.MaximumPixelCountNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.MaximumPixelCountNumericUpDown.TabIndex = 1;
            this.MaximumPixelCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MinimumDensityLabel
            // 
            this.MinimumDensityLabel.AutoSize = true;
            this.MinimumDensityLabel.Location = new System.Drawing.Point(21, 88);
            this.MinimumDensityLabel.Name = "MinimumDensityLabel";
            this.MinimumDensityLabel.Size = new System.Drawing.Size(89, 13);
            this.MinimumDensityLabel.TabIndex = 4;
            this.MinimumDensityLabel.Text = "Minimum Density:";
            // 
            // MinimumPixelCountLabel
            // 
            this.MinimumPixelCountLabel.AutoSize = true;
            this.MinimumPixelCountLabel.Location = new System.Drawing.Point(21, 55);
            this.MinimumPixelCountLabel.Name = "MinimumPixelCountLabel";
            this.MinimumPixelCountLabel.Size = new System.Drawing.Size(107, 13);
            this.MinimumPixelCountLabel.TabIndex = 2;
            this.MinimumPixelCountLabel.Text = "Minimum Pixel Count:";
            // 
            // MaximumPixelCountLabel
            // 
            this.MaximumPixelCountLabel.AutoSize = true;
            this.MaximumPixelCountLabel.Location = new System.Drawing.Point(21, 22);
            this.MaximumPixelCountLabel.Name = "MaximumPixelCountLabel";
            this.MaximumPixelCountLabel.Size = new System.Drawing.Size(110, 13);
            this.MaximumPixelCountLabel.TabIndex = 0;
            this.MaximumPixelCountLabel.Text = "Maximum Pixel Count:";
            // 
            // MouseLabel
            // 
            this.MouseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MouseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MouseLabel.Location = new System.Drawing.Point(12, 440);
            this.MouseLabel.Name = "MouseLabel";
            this.MouseLabel.Size = new System.Drawing.Size(152, 28);
            this.MouseLabel.TabIndex = 2;
            this.MouseLabel.Text = "Please use the mouse to select an area.";
            // 
            // ImageWasModifiedLabel
            // 
            this.ImageWasModifiedLabel.AutoSize = true;
            this.ImageWasModifiedLabel.Location = new System.Drawing.Point(6, 20);
            this.ImageWasModifiedLabel.Name = "ImageWasModifiedLabel";
            this.ImageWasModifiedLabel.Size = new System.Drawing.Size(104, 13);
            this.ImageWasModifiedLabel.TabIndex = 0;
            this.ImageWasModifiedLabel.Text = "Image was Modified:";
            // 
            // CountOfBlobsFoundLabel
            // 
            this.CountOfBlobsFoundLabel.AutoSize = true;
            this.CountOfBlobsFoundLabel.Location = new System.Drawing.Point(6, 55);
            this.CountOfBlobsFoundLabel.Name = "CountOfBlobsFoundLabel";
            this.CountOfBlobsFoundLabel.Size = new System.Drawing.Size(112, 13);
            this.CountOfBlobsFoundLabel.TabIndex = 2;
            this.CountOfBlobsFoundLabel.Text = "Count of Blobs Found:";
            // 
            // ImageWasModifiedValueLabel
            // 
            this.ImageWasModifiedValueLabel.AutoSize = true;
            this.ImageWasModifiedValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImageWasModifiedValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageWasModifiedValueLabel.Location = new System.Drawing.Point(125, 22);
            this.ImageWasModifiedValueLabel.Name = "ImageWasModifiedValueLabel";
            this.ImageWasModifiedValueLabel.Size = new System.Drawing.Size(2, 15);
            this.ImageWasModifiedValueLabel.TabIndex = 1;
            // 
            // CountOfBlobsFoundValueLabel
            // 
            this.CountOfBlobsFoundValueLabel.AutoSize = true;
            this.CountOfBlobsFoundValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CountOfBlobsFoundValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountOfBlobsFoundValueLabel.Location = new System.Drawing.Point(124, 55);
            this.CountOfBlobsFoundValueLabel.Name = "CountOfBlobsFoundValueLabel";
            this.CountOfBlobsFoundValueLabel.Size = new System.Drawing.Size(2, 15);
            this.CountOfBlobsFoundValueLabel.TabIndex = 3;
            // 
            // ResultsGroupBox
            // 
            this.ResultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultsGroupBox.Controls.Add(this.CountOfBlobsFoundValueLabel);
            this.ResultsGroupBox.Controls.Add(this.ImageWasModifiedLabel);
            this.ResultsGroupBox.Controls.Add(this.ImageWasModifiedValueLabel);
            this.ResultsGroupBox.Controls.Add(this.CountOfBlobsFoundLabel);
            this.ResultsGroupBox.Location = new System.Drawing.Point(411, 468);
            this.ResultsGroupBox.Name = "ResultsGroupBox";
            this.ResultsGroupBox.Size = new System.Drawing.Size(159, 80);
            this.ResultsGroupBox.TabIndex = 5;
            this.ResultsGroupBox.TabStop = false;
            this.ResultsGroupBox.Text = "Results";
            this.ResultsGroupBox.Visible = false;
            // 
            // BlobRemovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 594);
            this.Controls.Add(this.MouseLabel);
            this.Controls.Add(this.BlobRemovalGroupBox);
            this.Controls.Add(this.ResultsGroupBox);
            this.Name = "BlobRemovalForm";
            this.Text = "Blob Removal";
            this.Controls.SetChildIndex(this.ResultsGroupBox, 0);
            this.Controls.SetChildIndex(this.BlobRemovalGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.Controls.SetChildIndex(this.MouseLabel, 0);
            this.BlobRemovalGroupBox.ResumeLayout(false);
            this.BlobRemovalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumDensityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumPixelCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumPixelCountNumericUpDown)).EndInit();
            this.ResultsGroupBox.ResumeLayout(false);
            this.ResultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BlobRemovalGroupBox;
        private System.Windows.Forms.NumericUpDown MinimumDensityNumericUpDown;
        private System.Windows.Forms.NumericUpDown MinimumPixelCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown MaximumPixelCountNumericUpDown;
        private System.Windows.Forms.Label MinimumDensityLabel;
        private System.Windows.Forms.Label MinimumPixelCountLabel;
        private System.Windows.Forms.Label MaximumPixelCountLabel;
        private System.Windows.Forms.Label MouseLabel;
        private System.Windows.Forms.Label ImageWasModifiedLabel;
        private System.Windows.Forms.Label CountOfBlobsFoundLabel;
        private System.Windows.Forms.Label ImageWasModifiedValueLabel;
        private System.Windows.Forms.Label CountOfBlobsFoundValueLabel;
        private System.Windows.Forms.GroupBox ResultsGroupBox;
    }
}