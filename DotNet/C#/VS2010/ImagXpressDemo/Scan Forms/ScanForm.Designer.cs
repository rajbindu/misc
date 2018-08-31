using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    partial class ScanForm
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
            foreach (ImageX img in imagesScanned)
            {
                helperInstance.Image = img;
                helperInstance.DisposeOfImageX();
            }

            imagesScanned.Clear();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanForm));
            this.SelectSourceButton = new System.Windows.Forms.Button();
            this.AcquireButton = new System.Windows.Forms.Button();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.AcceptImageButton = new System.Windows.Forms.Button();
            this.CancelScanButton = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.PageTextBox = new System.Windows.Forms.TextBox();
            this.PageCountLabel = new System.Windows.Forms.Label();
            this.PageLabel = new System.Windows.Forms.Label();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectSourceButton
            // 
            this.SelectSourceButton.Location = new System.Drawing.Point(9, 18);
            this.SelectSourceButton.Name = "SelectSourceButton";
            this.SelectSourceButton.Size = new System.Drawing.Size(99, 23);
            this.SelectSourceButton.TabIndex = 0;
            this.SelectSourceButton.Text = "Select Source";
            this.SelectSourceButton.UseVisualStyleBackColor = true;
            // 
            // AcquireButton
            // 
            this.AcquireButton.Enabled = false;
            this.AcquireButton.Location = new System.Drawing.Point(9, 463);
            this.AcquireButton.Name = "AcquireButton";
            this.AcquireButton.Size = new System.Drawing.Size(75, 23);
            this.AcquireButton.TabIndex = 2;
            this.AcquireButton.Text = "Acquire";
            this.AcquireButton.UseVisualStyleBackColor = true;
            // 
            // imageXView1
            // 
            this.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
            this.imageXView1.Location = new System.Drawing.Point(280, 12);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(626, 445);
            this.imageXView1.TabIndex = 1;
            // 
            // AcceptImageButton
            // 
            this.AcceptImageButton.Enabled = false;
            this.AcceptImageButton.Location = new System.Drawing.Point(9, 492);
            this.AcceptImageButton.Name = "AcceptImageButton";
            this.AcceptImageButton.Size = new System.Drawing.Size(113, 23);
            this.AcceptImageButton.TabIndex = 8;
            this.AcceptImageButton.Text = "Accept Image";
            this.AcceptImageButton.UseVisualStyleBackColor = true;
            this.AcceptImageButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelScanButton
            // 
            this.CancelScanButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelScanButton.Location = new System.Drawing.Point(831, 492);
            this.CancelScanButton.Name = "CancelScanButton";
            this.CancelScanButton.Size = new System.Drawing.Size(75, 23);
            this.CancelScanButton.TabIndex = 9;
            this.CancelScanButton.Text = "Cancel";
            this.CancelScanButton.UseVisualStyleBackColor = true;
            this.CancelScanButton.Click += new System.EventHandler(this.CancelScanButton_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 523);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(918, 22);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 10;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(540, 463);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Enabled = false;
            this.PreviousButton.Location = new System.Drawing.Point(459, 463);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 3;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // PageTextBox
            // 
            this.PageTextBox.Enabled = false;
            this.PageTextBox.Location = new System.Drawing.Point(662, 464);
            this.PageTextBox.Name = "PageTextBox";
            this.PageTextBox.Size = new System.Drawing.Size(37, 20);
            this.PageTextBox.TabIndex = 6;
            // 
            // PageCountLabel
            // 
            this.PageCountLabel.AutoSize = true;
            this.PageCountLabel.Location = new System.Drawing.Point(705, 468);
            this.PageCountLabel.Name = "PageCountLabel";
            this.PageCountLabel.Size = new System.Drawing.Size(0, 13);
            this.PageCountLabel.TabIndex = 7;
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(621, 468);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(35, 13);
            this.PageLabel.TabIndex = 5;
            this.PageLabel.Text = "Page:";
            // 
            // ScanForm
            // 
            this.AcceptButton = this.AcceptImageButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelScanButton;
            this.ClientSize = new System.Drawing.Size(918, 545);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.PageCountLabel);
            this.Controls.Add(this.PageTextBox);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.CancelScanButton);
            this.Controls.Add(this.AcceptImageButton);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.AcquireButton);
            this.Controls.Add(this.SelectSourceButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ScanForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ScanForm_Load);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button AcquireButton;
        protected System.Windows.Forms.ToolStripStatusLabel StatusBarLabel;
        protected ImagXpress imagXpress1;
        protected System.Windows.Forms.Button SelectSourceButton;
        public System.Windows.Forms.Button AcceptImageButton;
        protected ImageXView imageXView1;
        protected System.Windows.Forms.Button PreviousButton;
        protected System.Windows.Forms.Button NextButton;
        protected System.Windows.Forms.Button CancelScanButton;
        protected System.Windows.Forms.StatusStrip StatusBar;
        protected System.Windows.Forms.Label PageLabel;
        protected System.Windows.Forms.TextBox PageTextBox;
        protected System.Windows.Forms.Label PageCountLabel;
    }
}