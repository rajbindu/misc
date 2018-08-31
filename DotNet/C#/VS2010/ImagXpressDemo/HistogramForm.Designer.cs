namespace ImagXpressDemo
{
    partial class HistogramForm
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
            if (image != null)
            {
                image.Dispose();
                image = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistogramForm));
            this.OkButton = new System.Windows.Forms.Button();
            this.HistogramPictureBox = new System.Windows.Forms.PictureBox();
            this.ChannelComboBox = new System.Windows.Forms.ComboBox();
            this.ChannelLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(8, 304);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // HistogramPictureBox
            // 
            this.HistogramPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HistogramPictureBox.Location = new System.Drawing.Point(8, 12);
            this.HistogramPictureBox.Name = "HistogramPictureBox";
            this.HistogramPictureBox.Size = new System.Drawing.Size(260, 256);
            this.HistogramPictureBox.TabIndex = 1;
            this.HistogramPictureBox.TabStop = false;
            this.HistogramPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.HistogramPictureBox.MouseLeave += new System.EventHandler(this.HistogramPictureBox_MouseLeave);
            this.HistogramPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HistogramPictureBox_MouseMove);
            // 
            // ChannelComboBox
            // 
            this.ChannelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChannelComboBox.FormattingEnabled = true;
            this.ChannelComboBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "RGB"});
            this.ChannelComboBox.Location = new System.Drawing.Point(132, 274);
            this.ChannelComboBox.Name = "ChannelComboBox";
            this.ChannelComboBox.Size = new System.Drawing.Size(66, 21);
            this.ChannelComboBox.TabIndex = 1;
            this.ChannelComboBox.SelectedIndexChanged += new System.EventHandler(this.ChannelComboBox_SelectedIndexChanged);
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.AutoSize = true;
            this.ChannelLabel.Location = new System.Drawing.Point(78, 278);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(49, 13);
            this.ChannelLabel.TabIndex = 0;
            this.ChannelLabel.Text = "Channel:";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(102, 309);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(0, 13);
            this.PositionLabel.TabIndex = 3;
            // 
            // HistogramForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 334);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.ChannelLabel);
            this.Controls.Add(this.ChannelComboBox);
            this.Controls.Add(this.HistogramPictureBox);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HistogramForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histogram";
            this.Load += new System.EventHandler(this.HistogramForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HistogramPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.PictureBox HistogramPictureBox;
        private System.Windows.Forms.ComboBox ChannelComboBox;
        private System.Windows.Forms.Label ChannelLabel;
        private System.Windows.Forms.Label PositionLabel;
    }
}