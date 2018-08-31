namespace ImagXpressDemo
{
    partial class ProcessingForm
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
                if (imageXView1.ContextMenu.MenuItems.Count > 0 &&
                    imageXView1.ContextMenu.MenuItems[imageXView1.ContextMenu.MenuItems.Count - 1].MenuItems.Count > 0)
                {
                    imageXView1.ContextMenu.MenuItems[imageXView1.ContextMenu.MenuItems.Count - 1].MenuItems[0].Click -= ContextMenuPointerClickEventHandler;
                    imageXView1.ContextMenu.MenuItems[imageXView1.ContextMenu.MenuItems.Count - 1].MenuItems[1].Click -= ContextMenuZoomRectClickEventHandler;
                }

                if (imageXView1.Image != null)
                {
                    imageXView1.Image.Dispose();
                    imageXView1.Image = null;
                }
                imageXView1.Dispose();
                imageXView1 = null;
            }
            if (imageXView2 != null)
            {
                if (imageXView2.ContextMenu.MenuItems.Count > 0 &&
                    imageXView2.ContextMenu.MenuItems[imageXView2.ContextMenu.MenuItems.Count - 1].MenuItems.Count > 0)
                {
                    imageXView2.ContextMenu.MenuItems[imageXView2.ContextMenu.MenuItems.Count - 1].MenuItems[0].Click -= ContextMenuPointerClickEventHandler;
                    imageXView2.ContextMenu.MenuItems[imageXView2.ContextMenu.MenuItems.Count - 1].MenuItems[1].Click -= ContextMenuZoomRectClickEventHandler;
                }

                if (imageXView2.Image != null)
                {
                    imageXView2.Image.Dispose();
                    imageXView2.Image = null;
                }
                imageXView2.Dispose();
                imageXView2 = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessingForm));
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelProcessingButton = new System.Windows.Forms.Button();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.imageXView2 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.PreviewButton = new System.Windows.Forms.Button();
            this.RightClickLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AfterLabel = new System.Windows.Forms.Label();
            this.BeforeLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OKButton.Location = new System.Drawing.Point(13, 478);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelProcessingButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelProcessingButton.Location = new System.Drawing.Point(653, 478);
            this.CancelProcessingButton.Name = "CancelProcessingButton";
            this.CancelProcessingButton.Size = new System.Drawing.Size(75, 23);
            this.CancelProcessingButton.TabIndex = 4;
            this.CancelProcessingButton.Text = "Cancel";
            this.CancelProcessingButton.UseVisualStyleBackColor = true;
            this.CancelProcessingButton.Click += new System.EventHandler(this.CancelProcessingButton_Click);
            // 
            // imageXView1
            // 
            this.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
            this.imageXView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageXView1.Location = new System.Drawing.Point(3, 29);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(352, 392);
            this.imageXView1.TabIndex = 0;
            this.imageXView1.ZoomFactorChanged += new Accusoft.ImagXpressSdk.ImageXView.ZoomFactorChangedEventHandler(this.imageXView1_ZoomFactorChanged);
            this.imageXView1.ScrollEvent += new Accusoft.ImagXpressSdk.ImageXView.ScrollEventHandler(this.imageXView1_ScrollEvent);
            // 
            // imageXView2
            // 
            this.imageXView2.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
            this.imageXView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageXView2.Location = new System.Drawing.Point(361, 29);
            this.imageXView2.Name = "imageXView2";
            this.imageXView2.Size = new System.Drawing.Size(352, 392);
            this.imageXView2.TabIndex = 1;
            this.imageXView2.ZoomFactorChanged += new Accusoft.ImagXpressSdk.ImageXView.ZoomFactorChangedEventHandler(this.imageXView2_ZoomFactorChanged);
            this.imageXView2.ScrollEvent += new Accusoft.ImagXpressSdk.ImageXView.ScrollEventHandler(this.imageXView2_ScrollEvent);
            // 
            // PreviewButton
            // 
            this.PreviewButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PreviewButton.Location = new System.Drawing.Point(373, 478);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(75, 23);
            this.PreviewButton.TabIndex = 3;
            this.PreviewButton.Text = "Preview";
            this.PreviewButton.UseVisualStyleBackColor = true;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RightClickLabel.AutoSize = true;
            this.RightClickLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RightClickLabel.Location = new System.Drawing.Point(592, 446);
            this.RightClickLabel.Name = "RightClickLabel";
            this.RightClickLabel.Size = new System.Drawing.Size(136, 15);
            this.RightClickLabel.TabIndex = 5;
            this.RightClickLabel.Text = "Right-click menu available.";
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Controls.Add(this.imageXView2, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.imageXView1, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.AfterLabel, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.BeforeLabel, 0, 0);
            this.TableLayoutPanel.Location = new System.Drawing.Point(12, 3);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 2;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(716, 424);
            this.TableLayoutPanel.TabIndex = 6;
            // 
            // AfterLabel
            // 
            this.AfterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AfterLabel.AutoSize = true;
            this.AfterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfterLabel.Location = new System.Drawing.Point(505, 0);
            this.AfterLabel.Name = "AfterLabel";
            this.AfterLabel.Size = new System.Drawing.Size(63, 26);
            this.AfterLabel.TabIndex = 3;
            this.AfterLabel.Text = "After";
            // 
            // BeforeLabel
            // 
            this.BeforeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BeforeLabel.AutoSize = true;
            this.BeforeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeforeLabel.Location = new System.Drawing.Point(138, 0);
            this.BeforeLabel.Name = "BeforeLabel";
            this.BeforeLabel.Size = new System.Drawing.Size(82, 26);
            this.BeforeLabel.TabIndex = 2;
            this.BeforeLabel.Text = "Before";
            // 
            // ProcessingForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelProcessingButton;
            this.ClientSize = new System.Drawing.Size(740, 513);
            this.Controls.Add(this.TableLayoutPanel);
            this.Controls.Add(this.RightClickLabel);
            this.Controls.Add(this.PreviewButton);
            this.Controls.Add(this.CancelProcessingButton);
            this.Controls.Add(this.OKButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processing";
            this.Load += new System.EventHandler(this.ProcessingForm_Load);
            this.Resize += new System.EventHandler(this.ProcessingForm_Resize);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Accusoft.ImagXpressSdk.ImagXpress imagXpress1;
        protected Accusoft.ImagXpressSdk.ImageXView imageXView1;
        protected Accusoft.ImagXpressSdk.ImageXView imageXView2;
        protected System.Windows.Forms.Button PreviewButton;
        protected System.Windows.Forms.Button OKButton;
        protected System.Windows.Forms.Button CancelProcessingButton;
        protected System.Windows.Forms.Label RightClickLabel;
        protected System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Label AfterLabel;
        private System.Windows.Forms.Label BeforeLabel;
    }
}