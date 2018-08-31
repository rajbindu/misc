namespace ImagXpressDemo
{
    partial class SlideShowForm
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
            if (slideShowTimer != null)
            {
                slideShowTimer.Tick -= slideShowTimer_Tick;
                slideShowTimer.Dispose();
                slideShowTimer = null;
            }
            if (imageXView1 != null)
            {
                if (imageXView1.Image != null)
                {
                    imageXView1.Image.Dispose();
                    imageXView1.Image = null;
                }
                imageXView1.Dispose();
                imageXView1 = null;
            }
            if (imagXpress1 != null)
            {
                imagXpress1.Dispose();
                imagXpress1 = null;
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
            this.components = new System.ComponentModel.Container();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.ImageLabel = new System.Windows.Forms.Label();
            this.ImageLabelPanel = new System.Windows.Forms.Panel();
            this.ImageLabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageXView1
            // 
            this.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
            this.imageXView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageXView1.Location = new System.Drawing.Point(0, 0);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.imageXView1.Size = new System.Drawing.Size(284, 221);
            this.imageXView1.TabIndex = 0;
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageLabel.ForeColor = System.Drawing.Color.Red;
            this.ImageLabel.Location = new System.Drawing.Point(102, 17);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(2, 15);
            this.ImageLabel.TabIndex = 0;
            this.ImageLabel.Visible = false;
            // 
            // ImageLabelPanel
            // 
            this.ImageLabelPanel.Controls.Add(this.ImageLabel);
            this.ImageLabelPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ImageLabelPanel.Location = new System.Drawing.Point(0, 221);
            this.ImageLabelPanel.Name = "ImageLabelPanel";
            this.ImageLabelPanel.Size = new System.Drawing.Size(284, 41);
            this.ImageLabelPanel.TabIndex = 1;
            // 
            // SlideShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.ImageLabelPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "SlideShowForm";
            this.ShowInTaskbar = false;
            this.Text = "SlideShowForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SlideShowForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SlideShowForm_KeyPress);
            this.ImageLabelPanel.ResumeLayout(false);
            this.ImageLabelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Accusoft.ImagXpressSdk.ImagXpress imagXpress1;
        private Accusoft.ImagXpressSdk.ImageXView imageXView1;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Panel ImageLabelPanel;
    }
}