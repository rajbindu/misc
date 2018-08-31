/***************************************************************
* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace LoadingOptions
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grpCrop;
		private System.Windows.Forms.GroupBox grpResize;
		private System.Windows.Forms.GroupBox grpRotate;
		private System.Windows.Forms.CheckBox chkCrop;
		private System.Windows.Forms.CheckBox chkResize;
		private System.Windows.Forms.CheckBox chkRotate;
		private System.Windows.Forms.Label lblCropLeftVal;
		private System.Windows.Forms.Label lblCropTopVal;
		private System.Windows.Forms.Label lblCropRightVal;
		private System.Windows.Forms.Label lblCropBottomVal;
		private System.Windows.Forms.Label lblCropLeft;
		private System.Windows.Forms.Label lblCropTop;
		private System.Windows.Forms.Label lblCropRight;
		private System.Windows.Forms.Label lblCropBottom;
		private System.Windows.Forms.CheckBox chkResizeAspect;
		private System.Windows.Forms.Label lblResizeWidth;
		private System.Windows.Forms.Label lblResizeHeight;
		private System.Windows.Forms.Label lblRotateSettings;
		private System.String strCurrentImage;
		private Accusoft.ImagXpressSdk.LoadOptions loLoadOptions;
		private System.Windows.Forms.HScrollBar scrCropLeft;
		private System.Windows.Forms.HScrollBar scrCropTop;
		private System.Windows.Forms.HScrollBar scrCropRight;
        private System.Windows.Forms.HScrollBar scrCropBottom;
		private System.Windows.Forms.ComboBox cmbRotate;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.MenuItem menuItemFileOpen;
		private System.Windows.Forms.MenuItem menuItemSpacer;
		private System.Windows.Forms.MenuItem menuItemFileExit;
        private System.Windows.Forms.RichTextBox lblInfo;
		private System.Windows.Forms.MenuItem menuItemAbout;
		private System.Windows.Forms.Label lblLastError;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.MenuItem menuItemToolbar;
        private System.Windows.Forms.MenuItem menuItemToolbarShow;
        private Button buttonReloadImage;
		private IContainer components;
        private int widthStart;
        private NumericUpDown numericUpDownResizeHeight;
        private NumericUpDown numericUpDownResizeWidth;
        private Accusoft.ImagXpressSdk.ImagXpress imagXpress1;
        private Accusoft.ImagXpressSdk.ImageXView imageXView1;
        private int heightStart;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
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
            this.grpCrop = new System.Windows.Forms.GroupBox();
            this.lblCropBottom = new System.Windows.Forms.Label();
            this.lblCropRight = new System.Windows.Forms.Label();
            this.lblCropTop = new System.Windows.Forms.Label();
            this.lblCropLeft = new System.Windows.Forms.Label();
            this.lblCropBottomVal = new System.Windows.Forms.Label();
            this.lblCropRightVal = new System.Windows.Forms.Label();
            this.lblCropTopVal = new System.Windows.Forms.Label();
            this.lblCropLeftVal = new System.Windows.Forms.Label();
            this.scrCropBottom = new System.Windows.Forms.HScrollBar();
            this.scrCropRight = new System.Windows.Forms.HScrollBar();
            this.scrCropTop = new System.Windows.Forms.HScrollBar();
            this.scrCropLeft = new System.Windows.Forms.HScrollBar();
            this.chkCrop = new System.Windows.Forms.CheckBox();
            this.grpResize = new System.Windows.Forms.GroupBox();
            this.numericUpDownResizeHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownResizeWidth = new System.Windows.Forms.NumericUpDown();
            this.lblResizeHeight = new System.Windows.Forms.Label();
            this.lblResizeWidth = new System.Windows.Forms.Label();
            this.chkResizeAspect = new System.Windows.Forms.CheckBox();
            this.chkResize = new System.Windows.Forms.CheckBox();
            this.grpRotate = new System.Windows.Forms.GroupBox();
            this.lblRotateSettings = new System.Windows.Forms.Label();
            this.cmbRotate = new System.Windows.Forms.ComboBox();
            this.chkRotate = new System.Windows.Forms.CheckBox();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemFileOpen = new System.Windows.Forms.MenuItem();
            this.menuItemSpacer = new System.Windows.Forms.MenuItem();
            this.menuItemFileExit = new System.Windows.Forms.MenuItem();
            this.menuItemToolbar = new System.Windows.Forms.MenuItem();
            this.menuItemToolbarShow = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.lblInfo = new System.Windows.Forms.RichTextBox();
            this.lblLastError = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.buttonReloadImage = new System.Windows.Forms.Button();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.grpCrop.SuspendLayout();
            this.grpResize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResizeHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResizeWidth)).BeginInit();
            this.grpRotate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCrop
            // 
            this.grpCrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpCrop.Controls.Add(this.lblCropBottom);
            this.grpCrop.Controls.Add(this.lblCropRight);
            this.grpCrop.Controls.Add(this.lblCropTop);
            this.grpCrop.Controls.Add(this.lblCropLeft);
            this.grpCrop.Controls.Add(this.lblCropBottomVal);
            this.grpCrop.Controls.Add(this.lblCropRightVal);
            this.grpCrop.Controls.Add(this.lblCropTopVal);
            this.grpCrop.Controls.Add(this.lblCropLeftVal);
            this.grpCrop.Controls.Add(this.scrCropBottom);
            this.grpCrop.Controls.Add(this.scrCropRight);
            this.grpCrop.Controls.Add(this.scrCropTop);
            this.grpCrop.Controls.Add(this.scrCropLeft);
            this.grpCrop.Controls.Add(this.chkCrop);
            this.grpCrop.Location = new System.Drawing.Point(16, 339);
            this.grpCrop.Name = "grpCrop";
            this.grpCrop.Size = new System.Drawing.Size(200, 128);
            this.grpCrop.TabIndex = 2;
            this.grpCrop.TabStop = false;
            this.grpCrop.Text = "Load Crop";
            // 
            // lblCropBottom
            // 
            this.lblCropBottom.Location = new System.Drawing.Point(8, 96);
            this.lblCropBottom.Name = "lblCropBottom";
            this.lblCropBottom.Size = new System.Drawing.Size(45, 16);
            this.lblCropBottom.TabIndex = 12;
            this.lblCropBottom.Text = "Bottom";
            this.lblCropBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCropRight
            // 
            this.lblCropRight.Location = new System.Drawing.Point(8, 80);
            this.lblCropRight.Name = "lblCropRight";
            this.lblCropRight.Size = new System.Drawing.Size(45, 16);
            this.lblCropRight.TabIndex = 11;
            this.lblCropRight.Text = "Right";
            this.lblCropRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCropTop
            // 
            this.lblCropTop.Location = new System.Drawing.Point(8, 64);
            this.lblCropTop.Name = "lblCropTop";
            this.lblCropTop.Size = new System.Drawing.Size(45, 16);
            this.lblCropTop.TabIndex = 10;
            this.lblCropTop.Text = "Top";
            this.lblCropTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCropLeft
            // 
            this.lblCropLeft.Location = new System.Drawing.Point(8, 48);
            this.lblCropLeft.Name = "lblCropLeft";
            this.lblCropLeft.Size = new System.Drawing.Size(45, 16);
            this.lblCropLeft.TabIndex = 9;
            this.lblCropLeft.Text = "Left";
            this.lblCropLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCropBottomVal
            // 
            this.lblCropBottomVal.Location = new System.Drawing.Point(160, 96);
            this.lblCropBottomVal.Name = "lblCropBottomVal";
            this.lblCropBottomVal.Size = new System.Drawing.Size(32, 16);
            this.lblCropBottomVal.TabIndex = 8;
            this.lblCropBottomVal.Text = "0";
            this.lblCropBottomVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCropRightVal
            // 
            this.lblCropRightVal.Location = new System.Drawing.Point(160, 80);
            this.lblCropRightVal.Name = "lblCropRightVal";
            this.lblCropRightVal.Size = new System.Drawing.Size(32, 16);
            this.lblCropRightVal.TabIndex = 7;
            this.lblCropRightVal.Text = "0";
            this.lblCropRightVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCropTopVal
            // 
            this.lblCropTopVal.Location = new System.Drawing.Point(160, 64);
            this.lblCropTopVal.Name = "lblCropTopVal";
            this.lblCropTopVal.Size = new System.Drawing.Size(32, 16);
            this.lblCropTopVal.TabIndex = 6;
            this.lblCropTopVal.Text = "0";
            this.lblCropTopVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCropLeftVal
            // 
            this.lblCropLeftVal.Location = new System.Drawing.Point(160, 48);
            this.lblCropLeftVal.Name = "lblCropLeftVal";
            this.lblCropLeftVal.Size = new System.Drawing.Size(32, 16);
            this.lblCropLeftVal.TabIndex = 5;
            this.lblCropLeftVal.Text = "0";
            this.lblCropLeftVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scrCropBottom
            // 
            this.scrCropBottom.LargeChange = 1;
            this.scrCropBottom.Location = new System.Drawing.Point(56, 96);
            this.scrCropBottom.Maximum = 1200;
            this.scrCropBottom.Name = "scrCropBottom";
            this.scrCropBottom.Size = new System.Drawing.Size(104, 16);
            this.scrCropBottom.TabIndex = 4;
            this.scrCropBottom.ValueChanged += new System.EventHandler(this.scrCropBottom_Changed);
            // 
            // scrCropRight
            // 
            this.scrCropRight.LargeChange = 1;
            this.scrCropRight.Location = new System.Drawing.Point(56, 80);
            this.scrCropRight.Maximum = 1600;
            this.scrCropRight.Name = "scrCropRight";
            this.scrCropRight.Size = new System.Drawing.Size(104, 16);
            this.scrCropRight.TabIndex = 3;
            this.scrCropRight.ValueChanged += new System.EventHandler(this.scrCropRight_Changed);
            // 
            // scrCropTop
            // 
            this.scrCropTop.LargeChange = 1;
            this.scrCropTop.Location = new System.Drawing.Point(56, 64);
            this.scrCropTop.Maximum = 1200;
            this.scrCropTop.Name = "scrCropTop";
            this.scrCropTop.Size = new System.Drawing.Size(104, 16);
            this.scrCropTop.TabIndex = 2;
            this.scrCropTop.ValueChanged += new System.EventHandler(this.scrCropTop_Changed);
            // 
            // scrCropLeft
            // 
            this.scrCropLeft.LargeChange = 1;
            this.scrCropLeft.Location = new System.Drawing.Point(56, 48);
            this.scrCropLeft.Maximum = 1600;
            this.scrCropLeft.Name = "scrCropLeft";
            this.scrCropLeft.Size = new System.Drawing.Size(104, 16);
            this.scrCropLeft.TabIndex = 1;
            this.scrCropLeft.ValueChanged += new System.EventHandler(this.scrCropLeft_Changed);
            // 
            // chkCrop
            // 
            this.chkCrop.Location = new System.Drawing.Point(11, 17);
            this.chkCrop.Name = "chkCrop";
            this.chkCrop.Size = new System.Drawing.Size(168, 21);
            this.chkCrop.TabIndex = 0;
            this.chkCrop.Text = "Crop Image on Load";
            this.chkCrop.CheckedChanged += new System.EventHandler(this.chkCrop_CheckedChanged);
            // 
            // grpResize
            // 
            this.grpResize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResize.Controls.Add(this.numericUpDownResizeHeight);
            this.grpResize.Controls.Add(this.numericUpDownResizeWidth);
            this.grpResize.Controls.Add(this.lblResizeHeight);
            this.grpResize.Controls.Add(this.lblResizeWidth);
            this.grpResize.Controls.Add(this.chkResizeAspect);
            this.grpResize.Controls.Add(this.chkResize);
            this.grpResize.Location = new System.Drawing.Point(224, 339);
            this.grpResize.Name = "grpResize";
            this.grpResize.Size = new System.Drawing.Size(200, 128);
            this.grpResize.TabIndex = 3;
            this.grpResize.TabStop = false;
            this.grpResize.Text = "Load Resize";
            // 
            // numericUpDownResizeHeight
            // 
            this.numericUpDownResizeHeight.Location = new System.Drawing.Point(59, 72);
            this.numericUpDownResizeHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownResizeHeight.Name = "numericUpDownResizeHeight";
            this.numericUpDownResizeHeight.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownResizeHeight.TabIndex = 7;
            // 
            // numericUpDownResizeWidth
            // 
            this.numericUpDownResizeWidth.Location = new System.Drawing.Point(59, 48);
            this.numericUpDownResizeWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownResizeWidth.Name = "numericUpDownResizeWidth";
            this.numericUpDownResizeWidth.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownResizeWidth.TabIndex = 6;
            // 
            // lblResizeHeight
            // 
            this.lblResizeHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblResizeHeight.Location = new System.Drawing.Point(8, 72);
            this.lblResizeHeight.Name = "lblResizeHeight";
            this.lblResizeHeight.Size = new System.Drawing.Size(40, 16);
            this.lblResizeHeight.TabIndex = 5;
            this.lblResizeHeight.Text = "Height";
            this.lblResizeHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResizeWidth
            // 
            this.lblResizeWidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblResizeWidth.Location = new System.Drawing.Point(8, 48);
            this.lblResizeWidth.Name = "lblResizeWidth";
            this.lblResizeWidth.Size = new System.Drawing.Size(40, 16);
            this.lblResizeWidth.TabIndex = 4;
            this.lblResizeWidth.Text = "Width";
            this.lblResizeWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkResizeAspect
            // 
            this.chkResizeAspect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkResizeAspect.Location = new System.Drawing.Point(32, 96);
            this.chkResizeAspect.Name = "chkResizeAspect";
            this.chkResizeAspect.Size = new System.Drawing.Size(136, 16);
            this.chkResizeAspect.TabIndex = 3;
            this.chkResizeAspect.Text = "Preserve Aspect Ratio";
            // 
            // chkResize
            // 
            this.chkResize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkResize.Location = new System.Drawing.Point(11, 15);
            this.chkResize.Name = "chkResize";
            this.chkResize.Size = new System.Drawing.Size(168, 23);
            this.chkResize.TabIndex = 0;
            this.chkResize.Text = "Resize Image on Load";
            this.chkResize.CheckedChanged += new System.EventHandler(this.chkResize_CheckedChanged);
            // 
            // grpRotate
            // 
            this.grpRotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRotate.Controls.Add(this.lblRotateSettings);
            this.grpRotate.Controls.Add(this.cmbRotate);
            this.grpRotate.Controls.Add(this.chkRotate);
            this.grpRotate.Location = new System.Drawing.Point(432, 339);
            this.grpRotate.Name = "grpRotate";
            this.grpRotate.Size = new System.Drawing.Size(176, 128);
            this.grpRotate.TabIndex = 4;
            this.grpRotate.TabStop = false;
            this.grpRotate.Text = "Load Rotate";
            // 
            // lblRotateSettings
            // 
            this.lblRotateSettings.Location = new System.Drawing.Point(16, 64);
            this.lblRotateSettings.Name = "lblRotateSettings";
            this.lblRotateSettings.Size = new System.Drawing.Size(88, 16);
            this.lblRotateSettings.TabIndex = 2;
            this.lblRotateSettings.Text = "Rotate Settings";
            // 
            // cmbRotate
            // 
            this.cmbRotate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRotate.Items.AddRange(new object[] {
            "None",
            "90 Degrees",
            "180 Degrees",
            "270 Degrees",
            "Flip",
            "Mirror"});
            this.cmbRotate.Location = new System.Drawing.Point(40, 80);
            this.cmbRotate.Name = "cmbRotate";
            this.cmbRotate.Size = new System.Drawing.Size(120, 21);
            this.cmbRotate.TabIndex = 1;
            // 
            // chkRotate
            // 
            this.chkRotate.Location = new System.Drawing.Point(16, 17);
            this.chkRotate.Name = "chkRotate";
            this.chkRotate.Size = new System.Drawing.Size(144, 21);
            this.chkRotate.TabIndex = 0;
            this.chkRotate.Text = "Rotate Image on Load";
            this.chkRotate.CheckedChanged += new System.EventHandler(this.chkRotate_CheckedChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemToolbar,
            this.menuItemAbout});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFileOpen,
            this.menuItemSpacer,
            this.menuItemFileExit});
            this.menuItemFile.Text = "File";
            // 
            // menuItemFileOpen
            // 
            this.menuItemFileOpen.Index = 0;
            this.menuItemFileOpen.Text = "Open Image";
            this.menuItemFileOpen.Click += new System.EventHandler(this.menuItemFileOpen_Click);
            // 
            // menuItemSpacer
            // 
            this.menuItemSpacer.Index = 1;
            this.menuItemSpacer.Text = "-";
            // 
            // menuItemFileExit
            // 
            this.menuItemFileExit.Index = 2;
            this.menuItemFileExit.Text = "Exit";
            this.menuItemFileExit.Click += new System.EventHandler(this.menuItemFileExit_Click);
            // 
            // menuItemToolbar
            // 
            this.menuItemToolbar.Index = 1;
            this.menuItemToolbar.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemToolbarShow});
            this.menuItemToolbar.Text = "Toolbar";
            // 
            // menuItemToolbarShow
            // 
            this.menuItemToolbarShow.Index = 0;
            this.menuItemToolbarShow.Text = "Show";
            this.menuItemToolbarShow.Click += new System.EventHandler(this.menuItemToolbarShow_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 2;
            this.menuItemAbout.Text = "About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(16, 8);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.ReadOnly = true;
            this.lblInfo.Size = new System.Drawing.Size(592, 64);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "This example demonstrates the following:\n1) Using the LoadOptions object.\nSelect " +
    "any of the 3 loading options by clicking the box next to the appropriate option," +
    "\nthen click the Load Image button.";
            // 
            // lblLastError
            // 
            this.lblLastError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastError.Location = new System.Drawing.Point(429, 80);
            this.lblLastError.Name = "lblLastError";
            this.lblLastError.Size = new System.Drawing.Size(176, 24);
            this.lblLastError.TabIndex = 9;
            this.lblLastError.Text = "Last Error:";
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Location = new System.Drawing.Point(429, 104);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(179, 143);
            this.lblError.TabIndex = 10;
            // 
            // buttonReloadImage
            // 
            this.buttonReloadImage.Location = new System.Drawing.Point(460, 276);
            this.buttonReloadImage.Name = "buttonReloadImage";
            this.buttonReloadImage.Size = new System.Drawing.Size(132, 37);
            this.buttonReloadImage.TabIndex = 13;
            this.buttonReloadImage.Text = "Reload Image";
            this.buttonReloadImage.UseVisualStyleBackColor = true;
            this.buttonReloadImage.Click += new System.EventHandler(this.buttonReloadImage_Click);
            // 
            // imageXView1
            // 
            this.imageXView1.Location = new System.Drawing.Point(13, 80);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(410, 253);
            this.imageXView1.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.buttonReloadImage);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblLastError);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.grpRotate);
            this.Controls.Add(this.grpResize);
            this.Controls.Add(this.grpCrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Options";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpCrop.ResumeLayout(false);
            this.grpResize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResizeHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResizeWidth)).EndInit();
            this.grpRotate.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            Application.EnableVisualStyles();
			Application.Run(new LoadingOptions.MainForm());
		}

		// Set the current directory to the Common\Images directory
		private void frmMain_Load(object sender, System.EventArgs e)
		{

			//***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
			//imagXpress1.Licensing.SetSolutionName("YourSolutionName");
			//imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345);
			//imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�");

			// Because in this sample the ImageX object is always located in the ImageXView
			// tell the ImageXView component to dispose of the ImageX object when itself is
			// disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
			// Dispose method before the components.Dispose() section.
			imageXView1.AutoImageDispose = true;

            imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;

			String strCurrentDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");
			if (System.IO.Directory.Exists(strCurrentDir))
				System.IO.Directory.SetCurrentDirectory(strCurrentDir);
			strCurrentDir = System.IO.Directory.GetCurrentDirectory();

			//Create a new load options object so we can recieve events from the images we load
			loLoadOptions = new Accusoft.ImagXpressSdk.LoadOptions();

			//here we set the current directory and image so that the file open dialog box works well
			strCurrentImage = System.IO.Path.Combine(strCurrentDir, "window.jpg");
			//we open a default image to view
			if (System.IO.File.Exists(strCurrentImage))
				imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strCurrentImage, loLoadOptions);

            widthStart = imageXView1.Image.ImageXData.Width;
            heightStart = imageXView1.Image.ImageXData.Height;

            scrCropLeft.Maximum = widthStart;
            scrCropTop.Maximum = heightStart;
            scrCropRight.Maximum = widthStart;
            scrCropBottom.Maximum = heightStart;

            numericUpDownResizeWidth.Value = 100;
            numericUpDownResizeHeight.Value = 100;
            chkResizeAspect.Checked = true;

            scrCropLeft.Value = 30;
            scrCropTop.Value = 30;
            scrCropRight.Value = 100;
            scrCropBottom.Value = 100;
            lblCropLeftVal.Text = "30";
            lblCropTopVal.Text = "30";
            lblCropRightVal.Text = "100";
            lblCropBottomVal.Text = "100";

			//Now we reset our options controls to enabled or disabled.
			chkCrop_CheckedChanged(sender, e);
			chkResize_CheckedChanged(sender, e);
			chkRotate_CheckedChanged(sender, e);
			cmbRotate.SelectedIndex = 1;
		}

		private void chkCrop_CheckedChanged(object sender, System.EventArgs e)
		{
            // If the check box was checked, enable the options controls,
            // otherwise, disable them.
			foreach (System.Windows.Forms.Control cControl in grpCrop.Controls)
			{
				if (cControl.Name != "chkCrop")
				{
					cControl.Enabled = chkCrop.Checked;
				}
			}
		}

		private void chkResize_CheckedChanged(object sender, System.EventArgs e)
		{
            // If the check box was checked, enable the options controls,
            // otherwise, disable them.
			foreach (System.Windows.Forms.Control cControl in grpResize.Controls)
			{
				if (cControl.Name != "chkResize")
				{
					cControl.Enabled = chkResize.Checked;
				}
			}
		}

		private void chkRotate_CheckedChanged(object sender, System.EventArgs e)
		{
            // If the check box was checked, enable the options controls,
            // otherwise, disable them.
			foreach (System.Windows.Forms.Control cControl in grpRotate.Controls)
			{
				if (cControl.Name != "chkRotate")
				{
					cControl.Enabled = chkRotate.Checked;
				}
			}
		}

		private void scrCropLeft_Changed(object sender, System.EventArgs e)
		{
            if (scrCropLeft.Value >= scrCropRight.Value - 1 && scrCropRight.Value > 1)
                scrCropLeft.Value = scrCropRight.Value - 1;
			lblCropLeftVal.Text = scrCropLeft.Value.ToString(cultNumber);
		}

		private void scrCropTop_Changed(object sender, System.EventArgs e)
		{
            if (scrCropTop.Value >= scrCropBottom.Value - 1 && scrCropBottom.Value > 1)
                scrCropTop.Value = scrCropBottom.Value - 1;
			lblCropTopVal.Text = scrCropTop.Value.ToString(cultNumber);
		}

		private void scrCropRight_Changed(object sender, System.EventArgs e)
		{
            if (scrCropRight.Value <= scrCropLeft.Value + 1)
                scrCropRight.Value = scrCropLeft.Value + 1;
			lblCropRightVal.Text = scrCropRight.Value.ToString(cultNumber);
		}

		private void scrCropBottom_Changed(object sender, System.EventArgs e)
		{
            if (scrCropBottom.Value <= scrCropTop.Value + 1)
                scrCropBottom.Value = scrCropTop.Value + 1;
			lblCropBottomVal.Text = scrCropBottom.Value.ToString(cultNumber);
		}

		private void menuItemFileExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuItemFileOpen_Click(object sender, System.EventArgs e)
		{
			//First we grab the filename of the image we want to open
			System.String strLoadResult = AccusoftOpenFile();

			//And we check to make sure the file is valid
			if (strLoadResult.Length != 0)
			{
				//If it is valid, we set our internal image filename equal to it
				strCurrentImage = strLoadResult;

				//then we create an image object, but we don't open a file yet
				Accusoft.ImagXpressSdk.ImageXData imageData;

				try
				{
					//now we query the image using our internal filename
					imageData = Accusoft.ImagXpressSdk.ImageX.QueryFile(imagXpress1, strCurrentImage);

                    widthStart = imageData.Width;
                    heightStart = imageData.Height;
                    scrCropLeft.Maximum = widthStart;
                    scrCropTop.Maximum = heightStart;
                    scrCropRight.Maximum = widthStart;
                    scrCropBottom.Maximum = heightStart;

                    //load the image
                    lblError.Text = "";
                    buttonReloadImage_Click(sender, e);
				}
				catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
				{
					AccusoftError(ex, lblError);
				}
				catch (System.IO.IOException ex)
				{
					AccusoftError(ex, lblError);
				}
			}
			else
			{
				System.Windows.Forms.MessageBox.Show(strNoImageError);
			}
		}

		private void menuItemAbout_Click(object sender, System.EventArgs e)
		{
			imagXpress1.AboutBox();
		}

		private void menuItemToolbarShow_Click(object sender, System.EventArgs e)
		{
            // If the toolbar is showing, hide it.  If it is hidden, show it.
			this.menuItemToolbarShow.Text = (imageXView1.Toolbar.Activated) ? "Show" : "Hide";
			imageXView1.Toolbar.Activated = !imageXView1.Toolbar.Activated;
		}

		#region Accusoft Sample Application Standard Functions
		/*********************************************************************
		 *     Accusoft Corporation Standard Function Definitions     *
		 *********************************************************************/

		private System.Globalization.NumberFormatInfo cultNumber = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
		private System.Globalization.TextInfo cultText = System.Globalization.CultureInfo.CurrentCulture.TextInfo;
		private System.Globalization.CompareInfo cultCompare = System.Globalization.CultureInfo.CurrentCulture.CompareInfo;
		private const System.String strNoImageError = "You must select an image file to open.";
		private const System.String strDefaultImageFilter = "All ImagXpress Supported File Types|*.bmp;*.cal;*.dib;*.dca;*.mod;*.dcx;*.gif;*.jp2;*.jls;*.jpg;*.jif;*.ljp;*.pbm;*.pcx;*.pgm;*.pic;*.png;*.ppm;*.tiff;*.tif;*.tga;*.wsq;*.jb2;*.gif;*.jpeg;*.cals;*.jbig2;*.ico;*.rle;*.lzw;*.wbmp;*.dwg;*.dxf;*.dwf;*.hdp;*.wdp|Windows Bitmap (*.BMP)|*.bmp|CALS (*.CAL)|*.cal|Windows Device Independent Bitmap(*.DIB)|*.dib|MO:DCA (*.DCA & *.MOD)|*.dca;*.mod|Zsoft Multiple Page (*.DCX)|*.dcx|CompuServe GIF (*.GIF)|*.gif|JPEG 2000 (*.JP2)|*.jp2|JPEG LS (*.JLS)|*.jls|JFIF Compliant JPEG (*.JPG & *.JIF)|*.jpg;*.jif|Lossless JPEG (*.LJP)|*.ljp|Portable Bitmap (*.PBM)|*.pbm|Zsoft PaintBrush (*.PCX)|*.pcx|Portable Graymap (*.PGM)|*.pgm|Pegasus PIC or Enhanced PIC (*.PIC)|*.pic|Portable Network Graphics (*.PNG)|*.png|Portable Pixmap (*.PPM)|*.ppm|Tagged Image Format (*.TIFF)|*.tif;*.tiff|Truevision TARGA (*.TGA)|*.tga|WSQ Fingerprint File (*.WSQ)|*.wsq|JBIG2 File (*.JB2)|*.jb2|CAD Drawing (*.DWG)|*.dwg|Autodesk Design Web Format (*.DWF)|*.dwf|AutoCAD DXF (*.DXF)|*.dxf|HD Photo (*.HDP & *.WDP)|*.hdp;*.wdp|All Files (*.*)|*.*";

		static void AccusoftError(System.Exception errorException, System.Windows.Forms.Label errorLabel)
		{
			errorLabel.Text = errorException.Message + "\n" + errorException.Source + "\n";
		}

		static void AccusoftError(Accusoft.ImagXpressSdk.ImagXpressException errorException, System.Windows.Forms.Label errorLabel)
		{
			errorLabel.Text = errorException.Message + "\n" + errorException.Source + "\n" + "Error Number: " + errorException.Number.ToString(System.Globalization.CultureInfo.CurrentCulture.NumberFormat);
		}

		string AccusoftOpenFile()
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Title = "Select an Image File";
			dlg.Filter = strDefaultImageFilter;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				return dlg.FileName;
			}
			else
			{
				return "";
			}
		}

		string AccusoftOpenFile(System.String strFilter)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Title = "Select an Image File";
			dlg.Filter = strFilter;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				return dlg.FileName;
			}
			else
			{
				return "";
			}
		}

		void AccusoftTextBoxScrollBinder(System.Windows.Forms.ScrollBar scrScroll, System.Windows.Forms.TextBox textTextBox, System.Windows.Forms.Label ErrorLabel)
		{
			System.Int32 iTmp;
			try
			{
				iTmp = Convert.ToInt32(textTextBox.Text, cultNumber);
			}
			catch (System.NullReferenceException ex)
			{
				AccusoftError(ex, ErrorLabel);
				textTextBox.Text = scrScroll.Value.ToString(cultNumber);
				return;
			}
			catch (System.FormatException ex)
			{
				AccusoftError(ex, ErrorLabel);
				textTextBox.Text = scrScroll.Value.ToString(cultNumber);
				return;
			}
			if ((iTmp < scrScroll.Maximum) && (iTmp > scrScroll.Minimum))
			{
				scrScroll.Value = iTmp;
			}
			else
			{
				iTmp = scrScroll.Value;
			}
			textTextBox.Text = iTmp.ToString(cultNumber);
		}
		#endregion

        private void buttonReloadImage_Click(object sender, EventArgs e)
        {
            try
            {
                // If the crop check box is checked, set the crop rectangle load option
                // to the specified crop rectangle
                if (chkCrop.Checked == true)
                {
                    System.Drawing.Rectangle rect = new Rectangle(scrCropLeft.Value, scrCropTop.Value, scrCropRight.Value - scrCropLeft.Value, scrCropBottom.Value - scrCropTop.Value);
                    loLoadOptions.CropRectangle = rect;
                }
                else
                {
                    loLoadOptions.CropRectangle = new Rectangle(0, 0, widthStart, heightStart);
                }
                
                // If the resize check box is checked, set the resize load option
                // to the specified resize width and height
                if (chkResize.Checked == true)
                {
                    loLoadOptions.Resize = new System.Drawing.Size((int)numericUpDownResizeWidth.Value, (int)numericUpDownResizeHeight.Value);
                    loLoadOptions.MaintainAspectRatio = chkResizeAspect.Checked;
                }
                else
                {
                    loLoadOptions.MaintainAspectRatio = false;
                    loLoadOptions.Resize = new System.Drawing.Size(0, 0);
                }
                
                // If the rotate check box is checked, set the rotate load option
                // to the specified angle
                if (chkRotate.Checked == true)
                {
                    loLoadOptions.Rotation = (Accusoft.ImagXpressSdk.RotateAngle)cmbRotate.SelectedIndex;
                }
                else
                {
                    loLoadOptions.Rotation = Accusoft.ImagXpressSdk.RotateAngle.Rotate0;
                }
                
                //Dispose the ImageX object if the ImageXView has one
                if ((imageXView1.Image != null))
                {
                    imageXView1.Image.Dispose();
                    imageXView1.Image = null;
                }
                imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strCurrentImage, loLoadOptions);
            }
            catch (Accusoft.ImagXpressSdk.ImageXException ex)
            {
                lblError.Text = ex.Message;
            }
            catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
            {
                lblError.Text = ex.Message;
            }
        }

	}
}
