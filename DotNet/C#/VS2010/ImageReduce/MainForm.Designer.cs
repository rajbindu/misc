namespace ImageReduce
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
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reduceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorExit = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagXpressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeaderFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReducedSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSavings = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRemarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.selectLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.reduceButton = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.outputImageXView = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.outputFileNameLabel = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.inputImageXView = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.inputFileNameLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.outputPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(936, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilesToolStripMenuItem,
            this.addDirectoryToolStripMenuItem,
            this.clearFilesToolStripMenuItem,
            this.toolStripSeparator1,
            this.reduceToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripSeparatorExit,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // addFilesToolStripMenuItem
            // 
            this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            this.addFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.addFilesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addFilesToolStripMenuItem.Text = "&Add File(s)...";
            this.addFilesToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // addDirectoryToolStripMenuItem
            // 
            this.addDirectoryToolStripMenuItem.Name = "addDirectoryToolStripMenuItem";
            this.addDirectoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.addDirectoryToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addDirectoryToolStripMenuItem.Text = "Add &Directory";
            this.addDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openDirectoryToolStripMenuItem_Click);
            // 
            // clearFilesToolStripMenuItem
            // 
            this.clearFilesToolStripMenuItem.Name = "clearFilesToolStripMenuItem";
            this.clearFilesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.clearFilesToolStripMenuItem.Text = "Clear";
            this.clearFilesToolStripMenuItem.Click += new System.EventHandler(this.closeFilesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // reduceToolStripMenuItem
            // 
            this.reduceToolStripMenuItem.Name = "reduceToolStripMenuItem";
            this.reduceToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.reduceToolStripMenuItem.Text = "Reduce";
            this.reduceToolStripMenuItem.Click += new System.EventHandler(this.reduceToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // toolStripSeparatorExit
            // 
            this.toolStripSeparatorExit.Name = "toolStripSeparatorExit";
            this.toolStripSeparatorExit.Size = new System.Drawing.Size(219, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.optionsToolStripMenuItem.Text = "Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagXpressToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // imagXpressToolStripMenuItem
            // 
            this.imagXpressToolStripMenuItem.Name = "imagXpressToolStripMenuItem";
            this.imagXpressToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.imagXpressToolStripMenuItem.Text = "&ImagXpress...";
            this.imagXpressToolStripMenuItem.Click += new System.EventHandler(this.imagXpressToolStripMenuItem_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFilename,
            this.columnHeaderSize,
            this.columnHeaderReducedSize,
            this.columnHeaderSavings,
            this.columnRemarks});
            this.listView.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 24);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(936, 113);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeaderFilename
            // 
            this.columnHeaderFilename.Text = "File";
            this.columnHeaderFilename.Width = 400;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Original";
            this.columnHeaderSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderSize.Width = 100;
            // 
            // columnHeaderReducedSize
            // 
            this.columnHeaderReducedSize.Text = "Reduced";
            this.columnHeaderReducedSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderReducedSize.Width = 100;
            // 
            // columnHeaderSavings
            // 
            this.columnHeaderSavings.Text = "Savings";
            this.columnHeaderSavings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderSavings.Width = 110;
            // 
            // columnRemarks
            // 
            this.columnRemarks.Text = "Remarks";
            this.columnRemarks.Width = 200;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.selectLabel);
            this.panel4.Controls.Add(this.stopButton);
            this.panel4.Controls.Add(this.reduceButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(936, 29);
            this.panel4.TabIndex = 9;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.selectLabel.Location = new System.Drawing.Point(0, 0);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(282, 13);
            this.selectLabel.TabIndex = 7;
            this.selectLabel.Text = "Select a row to see the results once reduction is complete.";
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Location = new System.Drawing.Point(777, 3);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 8;
            this.stopButton.Text = "&Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // reduceButton
            // 
            this.reduceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reduceButton.Enabled = false;
            this.reduceButton.Location = new System.Drawing.Point(858, 3);
            this.reduceButton.Name = "reduceButton";
            this.reduceButton.Size = new System.Drawing.Size(75, 23);
            this.reduceButton.TabIndex = 9;
            this.reduceButton.Text = "&Reduce";
            this.reduceButton.UseVisualStyleBackColor = true;
            this.reduceButton.Click += new System.EventHandler(this.buttonReduce_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 137);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(936, 3);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.outputPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 169);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(936, 404);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // outputPanel
            // 
            this.outputPanel.Controls.Add(this.outputImageXView);
            this.outputPanel.Controls.Add(this.outputFileNameLabel);
            this.outputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPanel.Location = new System.Drawing.Point(471, 3);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(462, 398);
            this.outputPanel.TabIndex = 17;
            // 
            // outputImageXView
            // 
            this.outputImageXView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputImageXView.Location = new System.Drawing.Point(0, 13);
            this.outputImageXView.Name = "outputImageXView";
            this.outputImageXView.Size = new System.Drawing.Size(462, 385);
            this.outputImageXView.TabIndex = 2;
            this.outputImageXView.ZoomFactorChanged += new Accusoft.ImagXpressSdk.ImageXView.ZoomFactorChangedEventHandler(this.outputImageXView_ZoomFactorChanged);
            this.outputImageXView.ScrollEvent += new Accusoft.ImagXpressSdk.ImageXView.ScrollEventHandler(this.outputImageXView_ScrollEvent);
            // 
            // outputFileNameLabel
            // 
            this.outputFileNameLabel.AutoSize = true;
            this.outputFileNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputFileNameLabel.Location = new System.Drawing.Point(0, 0);
            this.outputFileNameLabel.Name = "outputFileNameLabel";
            this.outputFileNameLabel.Size = new System.Drawing.Size(87, 13);
            this.outputFileNameLabel.TabIndex = 0;
            this.outputFileNameLabel.Text = "Output Filename:";
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.inputImageXView);
            this.inputPanel.Controls.Add(this.inputFileNameLabel);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(3, 3);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(462, 398);
            this.inputPanel.TabIndex = 14;
            // 
            // inputImageXView
            // 
            this.inputImageXView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputImageXView.Location = new System.Drawing.Point(0, 13);
            this.inputImageXView.Name = "inputImageXView";
            this.inputImageXView.Size = new System.Drawing.Size(462, 385);
            this.inputImageXView.TabIndex = 1;
            this.inputImageXView.ZoomFactorChanged += new Accusoft.ImagXpressSdk.ImageXView.ZoomFactorChangedEventHandler(this.inputImageXView_ZoomFactorChanged);
            this.inputImageXView.ScrollEvent += new Accusoft.ImagXpressSdk.ImageXView.ScrollEventHandler(this.inputImageXView_ScrollEvent);
            // 
            // inputFileNameLabel
            // 
            this.inputFileNameLabel.AutoSize = true;
            this.inputFileNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputFileNameLabel.Location = new System.Drawing.Point(0, 0);
            this.inputFileNameLabel.Name = "inputFileNameLabel";
            this.inputFileNameLabel.Size = new System.Drawing.Size(79, 13);
            this.inputFileNameLabel.TabIndex = 0;
            this.inputFileNameLabel.Text = "Input Filename:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(952, 611);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageReduce";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.outputPanel.ResumeLayout(false);
            this.outputPanel.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagXpressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDirectoryToolStripMenuItem;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeaderFilename;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ColumnHeader columnHeaderReducedSize;
        private System.Windows.Forms.ColumnHeader columnHeaderSavings;
        private System.Windows.Forms.ToolStripMenuItem clearFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem reduceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button reduceButton;
        private System.Windows.Forms.Splitter splitter2;
        private Accusoft.ImagXpressSdk.ImagXpress imagXpress1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel outputPanel;
        private Accusoft.ImagXpressSdk.ImageXView outputImageXView;
        private System.Windows.Forms.Label outputFileNameLabel;
        private System.Windows.Forms.Panel inputPanel;
        private Accusoft.ImagXpressSdk.ImageXView inputImageXView;
        private System.Windows.Forms.Label inputFileNameLabel;
        private System.Windows.Forms.ColumnHeader columnRemarks;
    }
}

