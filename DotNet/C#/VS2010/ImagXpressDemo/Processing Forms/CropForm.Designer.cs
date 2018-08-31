namespace ImagXpressDemo
{
    partial class CropForm
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
            this.LeftLabel = new System.Windows.Forms.Label();
            this.TopLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.LeftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TopNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CropGroupBox = new System.Windows.Forms.GroupBox();
            this.MouseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LeftNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            this.CropGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageXView1
            // 
            this.imageXView1.TabIndex = 0;     
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(373, 514);
            this.PreviewButton.TabIndex = 5;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(13, 514);
            this.OKButton.TabIndex = 4;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(653, 514);
            this.CancelProcessingButton.TabIndex = 6;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.TabIndex = 7;
            // 
            // LeftLabel
            // 
            this.LeftLabel.AutoSize = true;
            this.LeftLabel.Location = new System.Drawing.Point(19, 23);
            this.LeftLabel.Name = "LeftLabel";
            this.LeftLabel.Size = new System.Drawing.Size(28, 13);
            this.LeftLabel.TabIndex = 0;
            this.LeftLabel.Text = "Left:";
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Location = new System.Drawing.Point(19, 55);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(29, 13);
            this.TopLabel.TabIndex = 4;
            this.TopLabel.Text = "Top:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(145, 23);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Width:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(145, 55);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 6;
            this.HeightLabel.Text = "Height:";
            // 
            // LeftNumericUpDown
            // 
            this.LeftNumericUpDown.Location = new System.Drawing.Point(65, 19);
            this.LeftNumericUpDown.Name = "LeftNumericUpDown";
            this.LeftNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.LeftNumericUpDown.TabIndex = 1;
            // 
            // TopNumericUpDown
            // 
            this.TopNumericUpDown.Location = new System.Drawing.Point(65, 51);
            this.TopNumericUpDown.Name = "TopNumericUpDown";
            this.TopNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.TopNumericUpDown.TabIndex = 5;
            // 
            // WidthNumericUpDown
            // 
            this.WidthNumericUpDown.Location = new System.Drawing.Point(191, 19);
            this.WidthNumericUpDown.Name = "WidthNumericUpDown";
            this.WidthNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.WidthNumericUpDown.TabIndex = 3;
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.Location = new System.Drawing.Point(191, 51);
            this.HeightNumericUpDown.Name = "HeightNumericUpDown";
            this.HeightNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.HeightNumericUpDown.TabIndex = 7;
            // 
            // CropGroupBox
            // 
            this.CropGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CropGroupBox.Controls.Add(this.HeightNumericUpDown);
            this.CropGroupBox.Controls.Add(this.WidthNumericUpDown);
            this.CropGroupBox.Controls.Add(this.TopNumericUpDown);
            this.CropGroupBox.Controls.Add(this.LeftNumericUpDown);
            this.CropGroupBox.Controls.Add(this.HeightLabel);
            this.CropGroupBox.Controls.Add(this.WidthLabel);
            this.CropGroupBox.Controls.Add(this.TopLabel);
            this.CropGroupBox.Controls.Add(this.LeftLabel);
            this.CropGroupBox.Location = new System.Drawing.Point(185, 426);
            this.CropGroupBox.Name = "CropGroupBox";
            this.CropGroupBox.Size = new System.Drawing.Size(269, 82);
            this.CropGroupBox.TabIndex = 3;
            this.CropGroupBox.TabStop = false;
            this.CropGroupBox.Text = "Crop";
            // 
            // MouseLabel
            // 
            this.MouseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MouseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MouseLabel.Location = new System.Drawing.Point(13, 433);
            this.MouseLabel.Name = "MouseLabel";
            this.MouseLabel.Size = new System.Drawing.Size(152, 28);
            this.MouseLabel.TabIndex = 2;
            this.MouseLabel.Text = "Please use the mouse to select an area to Crop.";
            // 
            // CropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 549);
            this.Controls.Add(this.CropGroupBox);
            this.Controls.Add(this.MouseLabel);
            this.Name = "CropForm";
            this.Text = "Crop";
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.MouseLabel, 0);
            this.Controls.SetChildIndex(this.CropGroupBox, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.LeftNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            this.CropGroupBox.ResumeLayout(false);
            this.CropGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LeftLabel;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.NumericUpDown LeftNumericUpDown;
        private System.Windows.Forms.NumericUpDown TopNumericUpDown;
        private System.Windows.Forms.NumericUpDown WidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown;
        private System.Windows.Forms.GroupBox CropGroupBox;
        private System.Windows.Forms.Label MouseLabel;
    }
}