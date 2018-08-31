namespace SimpleImagXpressDemo
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonPageBack = new System.Windows.Forms.Button();
            this.buttonPageForward = new System.Windows.Forms.Button();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.notateXpress1 = new Accusoft.NotateXpressSdk.NotateXpress(this.components);
            this.thumbnailXpress1 = new Accusoft.ThumbnailXpressSdk.ThumbnailXpress();
            this.SuspendLayout();
            // 
            // buttonPageBack
            // 
            this.buttonPageBack.Location = new System.Drawing.Point(175, 482);
            this.buttonPageBack.Name = "buttonPageBack";
            this.buttonPageBack.Size = new System.Drawing.Size(144, 41);
            this.buttonPageBack.TabIndex = 1;
            this.buttonPageBack.Text = "<";
            this.buttonPageBack.UseVisualStyleBackColor = true;
            this.buttonPageBack.Click += new System.EventHandler(this.buttonPageBack_Click);
            // 
            // buttonPageForward
            // 
            this.buttonPageForward.Location = new System.Drawing.Point(336, 482);
            this.buttonPageForward.Name = "buttonPageForward";
            this.buttonPageForward.Size = new System.Drawing.Size(137, 40);
            this.buttonPageForward.TabIndex = 2;
            this.buttonPageForward.Text = ">";
            this.buttonPageForward.UseVisualStyleBackColor = true;
            this.buttonPageForward.Click += new System.EventHandler(this.buttonPageForward_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.Location = new System.Drawing.Point(522, 138);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(78, 41);
            this.buttonZoomIn.TabIndex = 3;
            this.buttonZoomIn.Text = "Zoom In";
            this.buttonZoomIn.UseVisualStyleBackColor = true;
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.Location = new System.Drawing.Point(523, 198);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(76, 39);
            this.buttonZoomOut.TabIndex = 4;
            this.buttonZoomOut.Text = "Zoom Out";
            this.buttonZoomOut.UseVisualStyleBackColor = true;
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // imageXView1
            // 
            this.imageXView1.Location = new System.Drawing.Point(147, 12);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(369, 464);
            this.imageXView1.TabIndex = 5;
            // 
            // notateXpress1
            // 
            this.notateXpress1.AllowPaint = true;
            this.notateXpress1.FontScaling = Accusoft.NotateXpressSdk.FontScaling.Normal;
            this.notateXpress1.ImagXpressLoad = true;
            this.notateXpress1.ImagXpressSave = true;
            this.notateXpress1.InteractMode = Accusoft.NotateXpressSdk.AnnotationMode.Edit;
            this.notateXpress1.LineScaling = Accusoft.NotateXpressSdk.LineScaling.Normal;
            this.notateXpress1.MultiLineEdit = false;
            this.notateXpress1.RecalibrateXdpi = -1;
            this.notateXpress1.RecalibrateYdpi = -1;
            this.notateXpress1.ToolTipTimeEdit = 0;
            this.notateXpress1.ToolTipTimeInteractive = 0;
            // 
            // thumbnailXpress1
            // 
            this.thumbnailXpress1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thumbnailXpress1.BottomMargin = 5;
            this.thumbnailXpress1.CameraRaw = false;
            this.thumbnailXpress1.CellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.thumbnailXpress1.CellBorderWidth = 1;
            this.thumbnailXpress1.CellHeight = 80;
            this.thumbnailXpress1.CellHorizontalSpacing = 5;
            this.thumbnailXpress1.CellSpacingColor = System.Drawing.Color.White;
            this.thumbnailXpress1.CellVerticalSpacing = 5;
            this.thumbnailXpress1.CellWidth = 80;
            this.thumbnailXpress1.DblClickDirectoryDrillDown = true;
            this.thumbnailXpress1.DescriptorAlignment = ((Accusoft.ThumbnailXpressSdk.DescriptorAlignments)((Accusoft.ThumbnailXpressSdk.DescriptorAlignments.AlignCenter | Accusoft.ThumbnailXpressSdk.DescriptorAlignments.AlignBottom)));
            this.thumbnailXpress1.DescriptorDisplayMethod = Accusoft.ThumbnailXpressSdk.DescriptorDisplayMethods.Default;
            this.thumbnailXpress1.EnableAsDragSourceForExternalDragDrop = true;
            this.thumbnailXpress1.EnableAsDropTargetForExternalDragDrop = true;
            this.thumbnailXpress1.ErrorAction = Accusoft.ThumbnailXpressSdk.ErrorAction.UseErrorIcon;
            this.thumbnailXpress1.FtpPassword = "";
            this.thumbnailXpress1.FtpUserName = "";
            this.thumbnailXpress1.InterComponentThumbnailDragDropEnabled = true;
            this.thumbnailXpress1.IntraComponentThumbnailDragDropEnabled = true;
            this.thumbnailXpress1.LeftMargin = 5;
            this.thumbnailXpress1.Location = new System.Drawing.Point(12, 12);
            this.thumbnailXpress1.MaximumThumbnailBitDepth = 24;
            this.thumbnailXpress1.Name = "thumbnailXpress1";
            this.thumbnailXpress1.PreserveBlack = false;
            this.thumbnailXpress1.ProxyServer = "";
            this.thumbnailXpress1.RightMargin = 5;
            this.thumbnailXpress1.ScrollDirection = Accusoft.ThumbnailXpressSdk.ScrollDirection.Vertical;
            this.thumbnailXpress1.SelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.thumbnailXpress1.SelectionMode = Accusoft.ThumbnailXpressSdk.SelectionMode.MultiExtended;
            this.thumbnailXpress1.ShowBusyCursor = true;
            this.thumbnailXpress1.ShowHourglass = true;
            this.thumbnailXpress1.ShowImagePlaceholders = false;
            this.thumbnailXpress1.Size = new System.Drawing.Size(117, 464);
            this.thumbnailXpress1.TabIndex = 6;
            this.thumbnailXpress1.TextBackColor = System.Drawing.Color.White;
            this.thumbnailXpress1.TopMargin = 5;
            this.thumbnailXpress1.UseCameraRawThumbnail = false;
            this.thumbnailXpress1.SelectedIndexChanged += new Accusoft.ThumbnailXpressSdk.ThumbnailXpressEvents.SelectedIndexChangedEventHandler(this.thumbnailXpress1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 535);
            this.Controls.Add(this.thumbnailXpress1);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.buttonZoomOut);
            this.Controls.Add(this.buttonZoomIn);
            this.Controls.Add(this.buttonPageForward);
            this.Controls.Add(this.buttonPageBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple ImagXpress Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPageBack;
        private System.Windows.Forms.Button buttonPageForward;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.Button buttonZoomOut;
        private Accusoft.ImagXpressSdk.ImagXpress imagXpress1;
        private Accusoft.ImagXpressSdk.ImageXView imageXView1;
        private Accusoft.NotateXpressSdk.NotateXpress notateXpress1;
        private Accusoft.ThumbnailXpressSdk.ThumbnailXpress thumbnailXpress1;
    }
}

