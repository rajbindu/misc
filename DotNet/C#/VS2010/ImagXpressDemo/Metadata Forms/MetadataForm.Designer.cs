namespace ImagXpressDemo
{
    partial class MetadataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetadataForm));
            this.OKButton = new System.Windows.Forms.Button();
            this.TagsListView = new System.Windows.Forms.ListView();
            this.LevelColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TagNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.HexRadioButton = new System.Windows.Forms.RadioButton();
            this.DecimalRadioButton = new System.Windows.Forms.RadioButton();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.ThumbnailLabel = new System.Windows.Forms.Label();
            this.TagsLabel = new System.Windows.Forms.Label();
            this.JpegCommentsButton = new System.Windows.Forms.Button();
            this.IptcButton = new System.Windows.Forms.Button();
            this.CalsButton = new System.Windows.Forms.Button();
            this.TagNumberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(9, 473);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // TagsListView
            // 
            this.TagsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LevelColumnHeader,
            this.NumberColumnHeader,
            this.TypeColumnHeader,
            this.CountColumnHeader,
            this.DataColumnHeader});
            this.TagsListView.FullRowSelect = true;
            this.TagsListView.Location = new System.Drawing.Point(9, 32);
            this.TagsListView.Name = "TagsListView";
            this.TagsListView.Size = new System.Drawing.Size(611, 356);
            this.TagsListView.TabIndex = 1;
            this.TagsListView.UseCompatibleStateImageBehavior = false;
            this.TagsListView.View = System.Windows.Forms.View.Details;
            // 
            // LevelColumnHeader
            // 
            this.LevelColumnHeader.Text = "Level";
            this.LevelColumnHeader.Width = 57;
            // 
            // NumberColumnHeader
            // 
            this.NumberColumnHeader.Text = "Number";
            this.NumberColumnHeader.Width = 55;
            // 
            // TypeColumnHeader
            // 
            this.TypeColumnHeader.Text = "Type";
            // 
            // CountColumnHeader
            // 
            this.CountColumnHeader.Text = "Count";
            this.CountColumnHeader.Width = 50;
            // 
            // DataColumnHeader
            // 
            this.DataColumnHeader.Text = "Data";
            this.DataColumnHeader.Width = 407;
            // 
            // TagNumberGroupBox
            // 
            this.TagNumberGroupBox.Controls.Add(this.HexRadioButton);
            this.TagNumberGroupBox.Controls.Add(this.DecimalRadioButton);
            this.TagNumberGroupBox.Location = new System.Drawing.Point(9, 395);
            this.TagNumberGroupBox.Name = "TagNumberGroupBox";
            this.TagNumberGroupBox.Size = new System.Drawing.Size(114, 72);
            this.TagNumberGroupBox.TabIndex = 2;
            this.TagNumberGroupBox.TabStop = false;
            this.TagNumberGroupBox.Text = "Number";
            // 
            // HexRadioButton
            // 
            this.HexRadioButton.AutoSize = true;
            this.HexRadioButton.Location = new System.Drawing.Point(13, 37);
            this.HexRadioButton.Name = "HexRadioButton";
            this.HexRadioButton.Size = new System.Drawing.Size(88, 18);
            this.HexRadioButton.TabIndex = 1;
            this.HexRadioButton.Text = "Hexadecimal";
            this.HexRadioButton.UseCompatibleTextRendering = true;
            this.HexRadioButton.UseVisualStyleBackColor = true;
            this.HexRadioButton.CheckedChanged += new System.EventHandler(this.HexRadioButton_CheckedChanged);
            // 
            // DecimalRadioButton
            // 
            this.DecimalRadioButton.AutoSize = true;
            this.DecimalRadioButton.Checked = true;
            this.DecimalRadioButton.Location = new System.Drawing.Point(13, 17);
            this.DecimalRadioButton.Name = "DecimalRadioButton";
            this.DecimalRadioButton.Size = new System.Drawing.Size(63, 17);
            this.DecimalRadioButton.TabIndex = 0;
            this.DecimalRadioButton.TabStop = true;
            this.DecimalRadioButton.Text = "Decimal";
            this.DecimalRadioButton.UseVisualStyleBackColor = true;
            this.DecimalRadioButton.CheckedChanged += new System.EventHandler(this.DecimalRadioButton_CheckedChanged);
            // 
            // imageXView1
            // 
            this.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
            this.imageXView1.Location = new System.Drawing.Point(520, 394);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(100, 100);
            this.imageXView1.TabIndex = 4;
            this.imageXView1.Visible = false;
            // 
            // ThumbnailLabel
            // 
            this.ThumbnailLabel.AutoSize = true;
            this.ThumbnailLabel.Location = new System.Drawing.Point(455, 394);
            this.ThumbnailLabel.Name = "ThumbnailLabel";
            this.ThumbnailLabel.Size = new System.Drawing.Size(59, 13);
            this.ThumbnailLabel.TabIndex = 5;
            this.ThumbnailLabel.Text = "Thumbnail:";
            this.ThumbnailLabel.Visible = false;
            // 
            // TagsLabel
            // 
            this.TagsLabel.AutoSize = true;
            this.TagsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagsLabel.Location = new System.Drawing.Point(9, 13);
            this.TagsLabel.Name = "TagsLabel";
            this.TagsLabel.Size = new System.Drawing.Size(31, 13);
            this.TagsLabel.TabIndex = 6;
            this.TagsLabel.Text = "Tags";
            // 
            // JpegCommentsButton
            // 
            this.JpegCommentsButton.Location = new System.Drawing.Point(129, 444);
            this.JpegCommentsButton.Name = "JpegCommentsButton";
            this.JpegCommentsButton.Size = new System.Drawing.Size(157, 23);
            this.JpegCommentsButton.TabIndex = 7;
            this.JpegCommentsButton.Text = "JPEG Comments";
            this.JpegCommentsButton.UseVisualStyleBackColor = true;
            this.JpegCommentsButton.Visible = false;
            this.JpegCommentsButton.Click += new System.EventHandler(this.JpegCommentsButton_Click);
            // 
            // IptcButton
            // 
            this.IptcButton.Location = new System.Drawing.Point(130, 415);
            this.IptcButton.Name = "IptcButton";
            this.IptcButton.Size = new System.Drawing.Size(75, 23);
            this.IptcButton.TabIndex = 8;
            this.IptcButton.Text = "IPTC";
            this.IptcButton.UseVisualStyleBackColor = true;
            this.IptcButton.Visible = false;
            this.IptcButton.Click += new System.EventHandler(this.IptcButton_Click);
            // 
            // CalsButton
            // 
            this.CalsButton.Location = new System.Drawing.Point(211, 415);
            this.CalsButton.Name = "CalsButton";
            this.CalsButton.Size = new System.Drawing.Size(75, 23);
            this.CalsButton.TabIndex = 9;
            this.CalsButton.Text = "CALS";
            this.CalsButton.UseVisualStyleBackColor = true;
            this.CalsButton.Visible = false;
            this.CalsButton.Click += new System.EventHandler(this.CalsButton_Click);
            // 
            // MetadataForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 508);
            this.Controls.Add(this.CalsButton);
            this.Controls.Add(this.IptcButton);
            this.Controls.Add(this.JpegCommentsButton);
            this.Controls.Add(this.TagsLabel);
            this.Controls.Add(this.ThumbnailLabel);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.TagNumberGroupBox);
            this.Controls.Add(this.TagsListView);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MetadataForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metadata";
            this.Load += new System.EventHandler(this.MetadataForm_Load);
            this.TagNumberGroupBox.ResumeLayout(false);
            this.TagNumberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ListView TagsListView;
        private System.Windows.Forms.ColumnHeader NumberColumnHeader;
        private System.Windows.Forms.ColumnHeader TypeColumnHeader;
        private System.Windows.Forms.ColumnHeader CountColumnHeader;
        private System.Windows.Forms.ColumnHeader DataColumnHeader;
        private System.Windows.Forms.ColumnHeader LevelColumnHeader;
        private System.Windows.Forms.GroupBox TagNumberGroupBox;
        private System.Windows.Forms.RadioButton HexRadioButton;
        private System.Windows.Forms.RadioButton DecimalRadioButton;
        private Accusoft.ImagXpressSdk.ImagXpress imagXpress1;
        private Accusoft.ImagXpressSdk.ImageXView imageXView1;
        private System.Windows.Forms.Label ThumbnailLabel;
        private System.Windows.Forms.Label TagsLabel;
        private System.Windows.Forms.Button JpegCommentsButton;
        private System.Windows.Forms.Button IptcButton;
        private System.Windows.Forms.Button CalsButton;
    }
}