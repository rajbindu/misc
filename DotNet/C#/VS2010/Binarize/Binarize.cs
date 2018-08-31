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
using Accusoft.ImagXpressSdk;

namespace Binarize
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mnuFile;
		private System.Windows.Forms.MenuItem mnuFileFile;
		private System.Windows.Forms.MenuItem mnuFileOpen;
		private System.Windows.Forms.MenuItem menuItemBar;
		private System.Windows.Forms.MenuItem mnuFileQuit;
		private System.String strCurrentImage;
		private System.String strImagePath;
		private System.Windows.Forms.ComboBox cmbBlur;
		private System.Windows.Forms.HScrollBar hsLocalContrast;
		private System.Windows.Forms.HScrollBar hsEccentricity;
		private System.Windows.Forms.HScrollBar hsPitch;
		private System.Windows.Forms.HScrollBar hsAngle;
		private System.Windows.Forms.HScrollBar hsLowThresh;
		private System.Windows.Forms.Label labelBlurType;
		private System.Windows.Forms.Label labelLocalContrast;
		private System.Windows.Forms.Label labelEccentricity;
		private System.Windows.Forms.Label labelGridPitch;
		private System.Windows.Forms.Label labelGridAngle;
		private System.Windows.Forms.Label labelHighThreshold;
		private System.Windows.Forms.Label labelLowThreshold;
		private System.Windows.Forms.ComboBox cmbMode;
		private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Button buttonProcess;
		private Accusoft.ImagXpressSdk.LoadOptions loLoadOptions;
		private System.Windows.Forms.MenuItem mnuAbout;
		private System.Windows.Forms.MenuItem mnuToolbar;
        private System.Windows.Forms.MenuItem mnuToolbarShow;
		private System.Windows.Forms.TextBox textPitch;
		private System.Windows.Forms.TextBox textEccentricity;
        private System.Windows.Forms.TextBox textLocalContrast;
		private System.Windows.Forms.TextBox textLowThresh;
		private System.Windows.Forms.TextBox textHighThresh;
		private System.Windows.Forms.TextBox textAngle;
        private System.Windows.Forms.HScrollBar hsHighThresh;
        private System.Windows.Forms.ListBox lstDesc;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private IContainer components;

        //new variables
        private BinarizeMode _mode = BinarizeMode.QuickText;
        private System.Int32 _lowThreshold = 0;
        private System.Int32 _gridAngle = 0;
        private System.Int32 _highThreshold = 1;
        private System.Int32 _gridPitch = 1;
        private System.Int32 _eccentricity = 0;
        private System.Int32 _lceFactor = 0;
        private BinarizeBlur _blur = BinarizeBlur.NoBlur;
        private Button buttonReload;
        private Label statusLabel;
		private Button buttonAutoBinarize2;
        private ImagXpress imagXpress1;
        private Processor processor1;
        private ImageXView imageXView1;
        private ImageXView imageXView2;       
        private Button buttonBinarize;
       


		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();


            //set up event handlers
            imageXView2.ZoomFactorChanged += new ImageXView.ZoomFactorChangedEventHandler(imageXView2_ZoomFactorChanged);
            imageXView2.ScrollEvent += new ImageXView.ScrollEventHandler(imageXView2_ScrollEvent);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();			
				}
			}
			
			base.Dispose( disposing );
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
            this.mnuFile = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFileFile = new System.Windows.Forms.MenuItem();
            this.mnuFileOpen = new System.Windows.Forms.MenuItem();
            this.menuItemBar = new System.Windows.Forms.MenuItem();
            this.mnuFileQuit = new System.Windows.Forms.MenuItem();
            this.mnuToolbar = new System.Windows.Forms.MenuItem();
            this.mnuToolbarShow = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.cmbBlur = new System.Windows.Forms.ComboBox();
            this.hsLocalContrast = new System.Windows.Forms.HScrollBar();
            this.hsEccentricity = new System.Windows.Forms.HScrollBar();
            this.hsPitch = new System.Windows.Forms.HScrollBar();
            this.hsAngle = new System.Windows.Forms.HScrollBar();
            this.hsHighThresh = new System.Windows.Forms.HScrollBar();
            this.hsLowThresh = new System.Windows.Forms.HScrollBar();
            this.labelBlurType = new System.Windows.Forms.Label();
            this.labelLocalContrast = new System.Windows.Forms.Label();
            this.labelEccentricity = new System.Windows.Forms.Label();
            this.labelGridPitch = new System.Windows.Forms.Label();
            this.labelGridAngle = new System.Windows.Forms.Label();
            this.labelHighThreshold = new System.Windows.Forms.Label();
            this.labelLowThreshold = new System.Windows.Forms.Label();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.textPitch = new System.Windows.Forms.TextBox();
            this.textEccentricity = new System.Windows.Forms.TextBox();
            this.textLocalContrast = new System.Windows.Forms.TextBox();
            this.textLowThresh = new System.Windows.Forms.TextBox();
            this.textHighThresh = new System.Windows.Forms.TextBox();
            this.textAngle = new System.Windows.Forms.TextBox();
            this.lstDesc = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBinarize = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.imageXView2 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.buttonReload = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.buttonAutoBinarize2 = new System.Windows.Forms.Button();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.processor1 = new Accusoft.ImagXpressSdk.Processor(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFileFile,
            this.mnuToolbar,
            this.mnuAbout});
            // 
            // mnuFileFile
            // 
            this.mnuFileFile.Index = 0;
            this.mnuFileFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFileOpen,
            this.menuItemBar,
            this.mnuFileQuit});
            this.mnuFileFile.Text = "&File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Index = 0;
            this.mnuFileOpen.Text = "&Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // menuItemBar
            // 
            this.menuItemBar.Index = 1;
            this.menuItemBar.Text = "-";
            // 
            // mnuFileQuit
            // 
            this.mnuFileQuit.Index = 2;
            this.mnuFileQuit.Text = "&Quit";
            this.mnuFileQuit.Click += new System.EventHandler(this.mnuFileQuit_Click);
            // 
            // mnuToolbar
            // 
            this.mnuToolbar.Index = 1;
            this.mnuToolbar.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuToolbarShow});
            this.mnuToolbar.Text = "&Toolbar";
            // 
            // mnuToolbarShow
            // 
            this.mnuToolbarShow.Index = 0;
            this.mnuToolbarShow.Text = "&Show";
            this.mnuToolbarShow.Click += new System.EventHandler(this.mnuToolbarShow_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 2;
            this.mnuAbout.Text = "&About";
            this.mnuAbout.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // cmbBlur
            // 
            this.cmbBlur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbBlur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlur.ItemHeight = 13;
            this.cmbBlur.Items.AddRange(new object[] {
            "None",
            "Gaussian",
            "Smart"});
            this.cmbBlur.Location = new System.Drawing.Point(197, 453);
            this.cmbBlur.Name = "cmbBlur";
            this.cmbBlur.Size = new System.Drawing.Size(166, 21);
            this.cmbBlur.TabIndex = 31;
            // 
            // hsLocalContrast
            // 
            this.hsLocalContrast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hsLocalContrast.LargeChange = 1;
            this.hsLocalContrast.Location = new System.Drawing.Point(197, 426);
            this.hsLocalContrast.Maximum = 255;
            this.hsLocalContrast.Name = "hsLocalContrast";
            this.hsLocalContrast.Size = new System.Drawing.Size(131, 16);
            this.hsLocalContrast.TabIndex = 30;
            this.hsLocalContrast.Value = 163;
            this.hsLocalContrast.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsLocalContrast_Scroll);
            // 
            // hsEccentricity
            // 
            this.hsEccentricity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hsEccentricity.LargeChange = 1;
            this.hsEccentricity.Location = new System.Drawing.Point(465, 424);
            this.hsEccentricity.Maximum = 255;
            this.hsEccentricity.Minimum = -255;
            this.hsEccentricity.Name = "hsEccentricity";
            this.hsEccentricity.Size = new System.Drawing.Size(333, 16);
            this.hsEccentricity.TabIndex = 29;
            this.hsEccentricity.Value = 255;
            this.hsEccentricity.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsEccentricity_Scroll);
            // 
            // hsPitch
            // 
            this.hsPitch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hsPitch.Enabled = false;
            this.hsPitch.LargeChange = 1;
            this.hsPitch.Location = new System.Drawing.Point(465, 397);
            this.hsPitch.Maximum = 32;
            this.hsPitch.Minimum = 1;
            this.hsPitch.Name = "hsPitch";
            this.hsPitch.Size = new System.Drawing.Size(333, 16);
            this.hsPitch.TabIndex = 28;
            this.hsPitch.Value = 1;
            this.hsPitch.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsPitch_Scroll);
            // 
            // hsAngle
            // 
            this.hsAngle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hsAngle.LargeChange = 1;
            this.hsAngle.Location = new System.Drawing.Point(465, 370);
            this.hsAngle.Maximum = 360;
            this.hsAngle.Name = "hsAngle";
            this.hsAngle.Size = new System.Drawing.Size(333, 16);
            this.hsAngle.TabIndex = 27;
            this.hsAngle.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsAngle_Scroll);
            // 
            // hsHighThresh
            // 
            this.hsHighThresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hsHighThresh.LargeChange = 1;
            this.hsHighThresh.Location = new System.Drawing.Point(197, 399);
            this.hsHighThresh.Maximum = 255;
            this.hsHighThresh.Name = "hsHighThresh";
            this.hsHighThresh.Size = new System.Drawing.Size(131, 16);
            this.hsHighThresh.TabIndex = 25;
            this.hsHighThresh.Value = 126;
            this.hsHighThresh.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsHighThresh_Scroll);
            // 
            // hsLowThresh
            // 
            this.hsLowThresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hsLowThresh.LargeChange = 1;
            this.hsLowThresh.Location = new System.Drawing.Point(197, 372);
            this.hsLowThresh.Maximum = 255;
            this.hsLowThresh.Name = "hsLowThresh";
            this.hsLowThresh.Size = new System.Drawing.Size(131, 16);
            this.hsLowThresh.TabIndex = 24;
            this.hsLowThresh.Value = 86;
            this.hsLowThresh.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsLowThresh_Scroll);
            // 
            // labelBlurType
            // 
            this.labelBlurType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelBlurType.Location = new System.Drawing.Point(131, 453);
            this.labelBlurType.Name = "labelBlurType";
            this.labelBlurType.Size = new System.Drawing.Size(56, 16);
            this.labelBlurType.TabIndex = 23;
            this.labelBlurType.Text = "Blur Type";
            this.labelBlurType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLocalContrast
            // 
            this.labelLocalContrast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelLocalContrast.Location = new System.Drawing.Point(82, 426);
            this.labelLocalContrast.Name = "labelLocalContrast";
            this.labelLocalContrast.Size = new System.Drawing.Size(105, 16);
            this.labelLocalContrast.TabIndex = 22;
            this.labelLocalContrast.Text = "Local Contrast";
            this.labelLocalContrast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEccentricity
            // 
            this.labelEccentricity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelEccentricity.Location = new System.Drawing.Point(377, 424);
            this.labelEccentricity.Name = "labelEccentricity";
            this.labelEccentricity.Size = new System.Drawing.Size(80, 16);
            this.labelEccentricity.TabIndex = 21;
            this.labelEccentricity.Text = "Eccentricity";
            this.labelEccentricity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGridPitch
            // 
            this.labelGridPitch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelGridPitch.Location = new System.Drawing.Point(377, 397);
            this.labelGridPitch.Name = "labelGridPitch";
            this.labelGridPitch.Size = new System.Drawing.Size(80, 16);
            this.labelGridPitch.TabIndex = 20;
            this.labelGridPitch.Text = "Grid Pitch";
            this.labelGridPitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGridAngle
            // 
            this.labelGridAngle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelGridAngle.Location = new System.Drawing.Point(369, 370);
            this.labelGridAngle.Name = "labelGridAngle";
            this.labelGridAngle.Size = new System.Drawing.Size(88, 16);
            this.labelGridAngle.TabIndex = 19;
            this.labelGridAngle.Text = "Grid Angle";
            this.labelGridAngle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHighThreshold
            // 
            this.labelHighThreshold.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelHighThreshold.Location = new System.Drawing.Point(99, 398);
            this.labelHighThreshold.Name = "labelHighThreshold";
            this.labelHighThreshold.Size = new System.Drawing.Size(88, 16);
            this.labelHighThreshold.TabIndex = 17;
            this.labelHighThreshold.Text = "High Threshold";
            this.labelHighThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLowThreshold
            // 
            this.labelLowThreshold.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelLowThreshold.Location = new System.Drawing.Point(99, 371);
            this.labelLowThreshold.Name = "labelLowThreshold";
            this.labelLowThreshold.Size = new System.Drawing.Size(88, 16);
            this.labelLowThreshold.TabIndex = 16;
            this.labelLowThreshold.Text = "Low Threshold";
            this.labelLowThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbMode
            // 
            this.cmbMode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.Items.AddRange(new object[] {
            "QuickText",
            "HalfTone"});
            this.cmbMode.Location = new System.Drawing.Point(465, 453);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(373, 21);
            this.cmbMode.TabIndex = 32;
            this.cmbMode.SelectedIndexChanged += new System.EventHandler(this.cmbMode_SelectedIndexChanged);
            // 
            // labelMode
            // 
            this.labelMode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMode.Location = new System.Drawing.Point(417, 458);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(40, 16);
            this.labelMode.TabIndex = 33;
            this.labelMode.Text = "Mode";
            // 
            // buttonProcess
            // 
            this.buttonProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcess.Location = new System.Drawing.Point(603, 556);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(165, 39);
            this.buttonProcess.TabIndex = 41;
            this.buttonProcess.Text = "AutoBinarize";
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // textPitch
            // 
            this.textPitch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textPitch.Location = new System.Drawing.Point(809, 395);
            this.textPitch.Name = "textPitch";
            this.textPitch.ReadOnly = true;
            this.textPitch.Size = new System.Drawing.Size(32, 21);
            this.textPitch.TabIndex = 45;
            this.textPitch.Text = "1";
            // 
            // textEccentricity
            // 
            this.textEccentricity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textEccentricity.Location = new System.Drawing.Point(809, 422);
            this.textEccentricity.Name = "textEccentricity";
            this.textEccentricity.ReadOnly = true;
            this.textEccentricity.Size = new System.Drawing.Size(32, 21);
            this.textEccentricity.TabIndex = 46;
            this.textEccentricity.Text = "0";
            // 
            // textLocalContrast
            // 
            this.textLocalContrast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textLocalContrast.Location = new System.Drawing.Point(339, 426);
            this.textLocalContrast.Name = "textLocalContrast";
            this.textLocalContrast.ReadOnly = true;
            this.textLocalContrast.Size = new System.Drawing.Size(32, 21);
            this.textLocalContrast.TabIndex = 47;
            this.textLocalContrast.Text = "0";
            // 
            // textLowThresh
            // 
            this.textLowThresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textLowThresh.Location = new System.Drawing.Point(339, 370);
            this.textLowThresh.Name = "textLowThresh";
            this.textLowThresh.ReadOnly = true;
            this.textLowThresh.Size = new System.Drawing.Size(32, 21);
            this.textLowThresh.TabIndex = 50;
            this.textLowThresh.Text = "0";
            // 
            // textHighThresh
            // 
            this.textHighThresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textHighThresh.Location = new System.Drawing.Point(339, 397);
            this.textHighThresh.Name = "textHighThresh";
            this.textHighThresh.ReadOnly = true;
            this.textHighThresh.Size = new System.Drawing.Size(32, 21);
            this.textHighThresh.TabIndex = 51;
            this.textHighThresh.Text = "0";
            // 
            // textAngle
            // 
            this.textAngle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textAngle.Location = new System.Drawing.Point(809, 370);
            this.textAngle.Name = "textAngle";
            this.textAngle.ReadOnly = true;
            this.textAngle.Size = new System.Drawing.Size(32, 21);
            this.textAngle.TabIndex = 52;
            this.textAngle.Text = "0";
            // 
            // lstDesc
            // 
            this.lstDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDesc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDesc.Items.AddRange(new object[] {
            "This sample demonstrates the following functionality of the Processor class:",
            "1) Using the Binarize method  to transform an image into black and white using th" +
                "e settings supplied.",
            "2) Using the AutoBinarize method to automatically process an image and then retri" +
                "eve the settings used.",
            "3) Using the newer and faster AutoBinarize2 method to automatically process an im" +
                "age."});
            this.lstDesc.Location = new System.Drawing.Point(3, 3);
            this.lstDesc.Name = "lstDesc";
            this.lstDesc.Size = new System.Drawing.Size(917, 69);
            this.lstDesc.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonBinarize);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.lstDesc);
            this.panel1.Controls.Add(this.labelGridPitch);
            this.panel1.Controls.Add(this.textAngle);
            this.panel1.Controls.Add(this.labelLowThreshold);
            this.panel1.Controls.Add(this.textHighThresh);
            this.panel1.Controls.Add(this.labelHighThreshold);
            this.panel1.Controls.Add(this.textLowThresh);
            this.panel1.Controls.Add(this.labelGridAngle);
            this.panel1.Controls.Add(this.textLocalContrast);
            this.panel1.Controls.Add(this.labelEccentricity);
            this.panel1.Controls.Add(this.textEccentricity);
            this.panel1.Controls.Add(this.labelLocalContrast);
            this.panel1.Controls.Add(this.textPitch);
            this.panel1.Controls.Add(this.labelBlurType);
            this.panel1.Controls.Add(this.hsLowThresh);
            this.panel1.Controls.Add(this.labelMode);
            this.panel1.Controls.Add(this.hsHighThresh);
            this.panel1.Controls.Add(this.cmbMode);
            this.panel1.Controls.Add(this.hsAngle);
            this.panel1.Controls.Add(this.cmbBlur);
            this.panel1.Controls.Add(this.hsPitch);
            this.panel1.Controls.Add(this.hsLocalContrast);
            this.panel1.Controls.Add(this.hsEccentricity);
            this.panel1.Location = new System.Drawing.Point(11, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 547);
            this.panel1.TabIndex = 57;
            // 
            // buttonBinarize
            // 
            this.buttonBinarize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBinarize.Location = new System.Drawing.Point(592, 495);
            this.buttonBinarize.Name = "buttonBinarize";
            this.buttonBinarize.Size = new System.Drawing.Size(165, 37);
            this.buttonBinarize.TabIndex = 58;
            this.buttonBinarize.Text = "Binarize";
            this.buttonBinarize.UseVisualStyleBackColor = true;
            this.buttonBinarize.Click += new System.EventHandler(this.buttonBinarize_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.imageXView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageXView2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 78);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 273);
            this.tableLayoutPanel1.TabIndex = 56;
            // 
            // imageXView1
            // 
            this.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
            this.imageXView1.Location = new System.Drawing.Point(3, 3);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(452, 267);
            this.imageXView1.TabIndex = 0;
            this.imageXView1.AutoResizeChanged += new Accusoft.ImagXpressSdk.ImageXView.AutoResizeChangedEventHandler(this.imageXView1_AutoResizeChanged);
            this.imageXView1.ZoomFactorChanged += new Accusoft.ImagXpressSdk.ImageXView.ZoomFactorChangedEventHandler(this.imageXView1_ZoomFactorChanged);
            this.imageXView1.ScrollEvent += new Accusoft.ImagXpressSdk.ImageXView.ScrollEventHandler(this.imageXView1_ScrollEvent);
            // 
            // imageXView2
            // 
            this.imageXView2.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
            this.imageXView2.Location = new System.Drawing.Point(461, 3);
            this.imageXView2.Name = "imageXView2";
            this.imageXView2.Size = new System.Drawing.Size(452, 267);
            this.imageXView2.TabIndex = 1;
            this.imageXView2.AutoResizeChanged += new Accusoft.ImagXpressSdk.ImageXView.AutoResizeChangedEventHandler(this.imageXView2_AutoResizeChanged);
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReload.Location = new System.Drawing.Point(123, 556);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(165, 39);
            this.buttonReload.TabIndex = 58;
            this.buttonReload.Text = "Reload Image";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(8, 638);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 59;
            // 
            // buttonAutoBinarize2
            // 
            this.buttonAutoBinarize2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAutoBinarize2.Location = new System.Drawing.Point(603, 612);
            this.buttonAutoBinarize2.Name = "buttonAutoBinarize2";
            this.buttonAutoBinarize2.Size = new System.Drawing.Size(165, 39);
            this.buttonAutoBinarize2.TabIndex = 60;
            this.buttonAutoBinarize2.Text = "AutoBinarize 2";
            this.buttonAutoBinarize2.Click += new System.EventHandler(this.buttonAutoBinarize2_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonProcess;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(944, 682);
            this.Controls.Add(this.buttonAutoBinarize2);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonProcess);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.Menu = this.mnuFile;
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binarize";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new MainForm());
		}

        #region Form Initialization

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
            imageXView2.AutoImageDispose = true;

			//Set the default directory to the common images directory
            String strCurrentDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");
            if (System.IO.Directory.Exists(strCurrentDir))
                System.IO.Directory.SetCurrentDirectory(strCurrentDir);
            strCurrentDir = System.IO.Directory.GetCurrentDirectory();

			//Create a new load options object so we can recieve events from the images we load
			loLoadOptions = new Accusoft.ImagXpressSdk.LoadOptions();
			
			strImagePath = System.IO.Path.Combine (strCurrentDir, "ImagXpress AutoBinarize Sample.jpg");
			//Load the images and set some default parameters

            imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImagePath);
            imageXView1.AutoResize = AutoResizeType.BestFit;
        
            imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImagePath);
            imageXView2.AutoResize = AutoResizeType.BestFit;
           
			cmbBlur.SelectedIndex = 0;
			cmbMode.SelectedIndex = 0;

			textLowThresh.Text = hsLowThresh.Value.ToString(cultNumber);
			textHighThresh.Text = hsHighThresh.Value.ToString(cultNumber);
			textLocalContrast.Text = hsLocalContrast.Value.ToString(cultNumber);	

			buttonProcess_Click(sender, e);

		}

        #endregion Form Initialization

        #region Button Processing

        private void buttonBinarize_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure we have a base image to work with
                if (imageXView1.Image != null)
                {

                    processor1.Image = imageXView1.Image.Copy();
                    processor1.Binarize(_mode, _lowThreshold, _highThreshold, _gridAngle, _gridPitch, _eccentricity, _lceFactor, _blur);

                    imageXView2.AllowUpdate = false;
                    if (imageXView2.Image != null)
                        imageXView2.Image.Dispose();
                    imageXView2.Image = processor1.Image;
                    SynchScrollPosition();
                    imageXView2.AllowUpdate = true;

                    processor1.Image = null;
                }
            }
            catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
            {
                AccusoftError(ex, statusLabel);
            }
        }

		private void buttonProcess_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Make sure we have a base image to work with
				if (imageXView1.Image != null)
				{
					processor1.Image = imageXView1.Image.Copy();
					processor1.AutoBinarize();

					_lceFactor = processor1.BinarizeLceFactor;
					textLocalContrast.Text = _lceFactor.ToString();
					hsLocalContrast.Value = _lceFactor;

					_lowThreshold = processor1.BinarizeLowThreshold;
					textLowThresh.Text = _lowThreshold.ToString();
					hsLowThresh.Value = _lowThreshold;

					_highThreshold = processor1.BinarizeHighThreshold;
					textHighThresh.Text = _highThreshold.ToString();
					hsHighThresh.Value = _highThreshold;

					_eccentricity = processor1.BinarizeEccentricity;
					textEccentricity.Text = _eccentricity.ToString();
					hsEccentricity.Value = _eccentricity;

					_gridAngle = processor1.BinarizeGridAngle;
					textAngle.Text = _gridAngle.ToString();
					hsAngle.Value = _gridAngle;

					_gridPitch = processor1.BinarizeGridPitch;
					if (_gridPitch <= 0)
						_gridPitch = 1;
					textPitch.Text = _gridPitch.ToString();
					hsPitch.Value = _gridPitch;

					_blur = processor1.BinarizeBlur;
					cmbBlur.SelectedIndex = (int)processor1.BinarizeBlur;

					_mode = processor1.BinarizeMode;
					cmbMode.SelectedIndex = (int)processor1.BinarizeMode;

					imageXView2.AllowUpdate = false;
					if (imageXView2.Image != null)
						imageXView2.Image.Dispose();
					imageXView2.Image = processor1.Image;
					SynchScrollPosition();
					imageXView2.AllowUpdate = true;

					processor1.Image = null;
				}
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
			{
				AccusoftError(ex, statusLabel);
			}
		}

		private void buttonAutoBinarize2_Click(object sender, EventArgs e)
		{
			try 
			{
				// Make sure we have a base image to work with
				if ( imageXView1.Image != null )
				{
                    processor1.Image = imageXView1.Image.Copy();
                    processor1.AutoBinarize2();

					// AutoBinarize2 does not update the Processor.Binarize settings
					// So we're not modifying the user interface for the binarize seettings

					imageXView2.AllowUpdate = false;
					if (imageXView2.Image != null)
						imageXView2.Image.Dispose();
					imageXView2.Image = processor1.Image;
					SynchScrollPosition();
					imageXView2.AllowUpdate = true;

					processor1.Image = null;
				}
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
			{
				AccusoftError(ex,statusLabel);
			}
		}

		private void buttonReload_Click(object sender, EventArgs e)
		{
			imageXView2.AllowUpdate = false;
			if (imageXView2.Image != null)
			{
				imageXView2.Image.Dispose();
				imageXView2.Image = null;
			}

			if ( imageXView1.Image != null )
				imageXView2.Image = imageXView1.Image.Copy();

			SynchScrollPosition();
			imageXView2.AllowUpdate = true;
		}

        #endregion Button Processing

        #region Option Handling

        // Low Threshold
        private void hsLowThresh_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            if (hsLowThresh.Value >= hsHighThresh.Value)
            {
                hsLowThresh.Value = hsHighThresh.Value - 1;
                e.NewValue = hsLowThresh.Value;
            }

            textLowThresh.Text = hsLowThresh.Value.ToString();
            _lowThreshold = hsLowThresh.Value;
        }

        // High Threshold
        private void hsHighThresh_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            if (hsHighThresh.Value <= hsLowThresh.Value)
            {
                hsHighThresh.Value = hsLowThresh.Value + 1;
                e.NewValue = hsHighThresh.Value;
            }

            textHighThresh.Text = hsHighThresh.Value.ToString();
            _highThreshold = hsHighThresh.Value;
        }

        // Local Contrast Enhancement
        private void hsLocalContrast_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            textLocalContrast.Text = hsLocalContrast.Value.ToString();
            _lceFactor = hsLocalContrast.Value;
        }

        // Grid Angle
        private void hsAngle_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            textAngle.Text = hsAngle.Value.ToString();
            _gridAngle = hsAngle.Value;
        }

        // Grid Pitch
        private void hsPitch_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            textPitch.Text = hsPitch.Value.ToString();
            _gridPitch = hsPitch.Value;
        }

        // Eccentricity
        private void hsEccentricity_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            textEccentricity.Text = hsEccentricity.Value.ToString();
            _eccentricity = hsEccentricity.Value;
        }

        // Mode Selection
        private void cmbMode_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbMode.SelectedIndex == 0)
            {
                hsLowThresh.Enabled = true;
                hsHighThresh.Enabled = true;
                hsLocalContrast.Enabled = true;
                hsAngle.Enabled = false;
                hsPitch.Enabled = false;
                hsEccentricity.Enabled = false;
                _mode = BinarizeMode.QuickText;
            }
            else
            {
                hsLowThresh.Enabled = false;
                hsHighThresh.Enabled = false;
                hsLocalContrast.Enabled = false;
                hsAngle.Enabled = true;
                hsPitch.Enabled = true;
                hsEccentricity.Enabled = true;
                _mode = BinarizeMode.PhotoHalftone;
            }
            hsLowThresh.Refresh();
            hsHighThresh.Refresh();
            hsLocalContrast.Refresh();
            hsAngle.Refresh();
            hsPitch.Refresh();
            hsEccentricity.Refresh();
        }

        #endregion Option Handling

        #region Menu Handling

        private void mnuFileOpen_Click(object sender, System.EventArgs e)
        {
            System.String sFileName = AccusoftOpenFile();
            if (sFileName.Length != 0)
            {
                strCurrentImage = sFileName;
                try
                {
                    imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, sFileName, loLoadOptions);
                    imageXView1.ZoomToFit(Accusoft.ImagXpressSdk.ZoomToFitType.FitBest);

                    imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, sFileName, loLoadOptions);
                    imageXView2.ZoomToFit(Accusoft.ImagXpressSdk.ZoomToFitType.FitBest);

                }
                catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
                {
                    AccusoftError(ex, statusLabel);
                }
            }
        }

        private void mnuFileQuit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            try
            {
                imagXpress1.AboutBox();
            }
            catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
            {
                AccusoftError(ex, statusLabel);
            }
        }

        private void mnuToolbarShow_Click(object sender, System.EventArgs e)
        {
            mnuToolbarShow.Text = (imageXView2.Toolbar.Activated) ? "Show" : "Hide";
            try
            {
                imageXView2.Toolbar.Activated = !imageXView2.Toolbar.Activated;
            }
            catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
            {
                AccusoftError(ex, statusLabel);
            }
        }

        #endregion Menu Handling

        #region ImageXView object synchronization

        private void SynchScrollPosition()
        {
            //set the output control's scroll view position to the source control's scroll view position
            imageXView2.ScrollPosition = imageXView1.ScrollPosition;
        }

        private void imageXView1_ScrollEvent(object sender, Accusoft.ImagXpressSdk.ScrollEventArgs e)
        {
            System.Drawing.Point point = new Point(e.NewValue.X, e.NewValue.Y);
            imageXView2.ScrollPosition = point;
            imageXView2.Refresh();
        }

        private void imageXView1_ZoomFactorChanged(object sender, ZoomFactorChangedEventArgs e)
        {
            imageXView2.ZoomFactor = e.NewValue;

            System.Drawing.Point point = new Point(imageXView1.ScrollPosition.X, imageXView1.ScrollPosition.Y);
            imageXView2.ScrollPosition = point;
            imageXView2.Refresh();
        }

        private void imageXView1_AutoResizeChanged(object sender, AutoResizeChangedEventArgs e)
        {
            imageXView2.AutoResize = e.NewValue;
            imageXView2.ZoomFactor = imageXView1.ZoomFactor;
            imageXView2.Refresh();
        }

        void imageXView2_ScrollEvent(object sender, Accusoft.ImagXpressSdk.ScrollEventArgs e)
        {
            System.Drawing.Point point = new Point(e.NewValue.X, e.NewValue.Y);
            imageXView1.ScrollPosition = point;
            imageXView1.Refresh();
        }

        void imageXView2_ZoomFactorChanged(object sender, Accusoft.ImagXpressSdk.ZoomFactorChangedEventArgs e)
        {
            imageXView1.ZoomFactor = e.NewValue;

            System.Drawing.Point point = new Point(imageXView2.ScrollPosition.X, imageXView2.ScrollPosition.Y);
            imageXView1.ScrollPosition = point;
            imageXView1.Refresh();
        }

        private void imageXView2_AutoResizeChanged(object sender, AutoResizeChangedEventArgs e)
        {
            imageXView1.AutoResize = e.NewValue;
            imageXView1.ZoomFactor = imageXView2.ZoomFactor;
            imageXView1.Refresh();
        }

        #endregion

		#region Accusoft Sample Application Standard Functions
		/*********************************************************************
		 *     Accusoft Corporation Standard Function Definitions     *
		 *********************************************************************/

		private System.Globalization.NumberFormatInfo cultNumber = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
		private System.Globalization.TextInfo cultText = System.Globalization.CultureInfo.CurrentCulture.TextInfo;
		private System.Globalization.CompareInfo cultCompare = System.Globalization.CultureInfo.CurrentCulture.CompareInfo;
		private const System.String strDefaultImageFilter = "All ImagXpress Supported File Types|*.bmp;*.cal;*.dib;*.dca;*.mod;*.dcx;*.gif;*.jp2;*.jls;*.jpg;*.jif;*.ljp;*.pbm;*.pcx;*.pgm;*.pic;*.png;*.ppm;*.tiff;*.tif;*.tga;*.wsq;*.jb2;*.gif;*.jpeg;*.cals;*.jbig2;*.ico;*.rle;*.lzw;*.wbmp;*.dwg;*.dxf;*.dwf;*.hdp;*.wdp|Windows Bitmap (*.BMP)|*.bmp|CALS (*.CAL)|*.cal|Windows Device Independent Bitmap(*.DIB)|*.dib|MO:DCA (*.DCA & *.MOD)|*.dca;*.mod|Zsoft Multiple Page (*.DCX)|*.dcx|CompuServe GIF (*.GIF)|*.gif|JPEG 2000 (*.JP2)|*.jp2|JPEG LS (*.JLS)|*.jls|JFIF Compliant JPEG (*.JPG & *.JIF)|*.jpg;*.jif|Lossless JPEG (*.LJP)|*.ljp|Portable Bitmap (*.PBM)|*.pbm|Zsoft PaintBrush (*.PCX)|*.pcx|Portable Graymap (*.PGM)|*.pgm|Pegasus PIC or Enhanced PIC (*.PIC)|*.pic|Portable Network Graphics (*.PNG)|*.png|Portable Pixmap (*.PPM)|*.ppm|Tagged Image Format (*.TIFF)|*.tif;*.tiff|Truevision TARGA (*.TGA)|*.tga|WSQ Fingerprint File (*.WSQ)|*.wsq|JBIG2 File (*.JB2)|*.jb2|CAD Drawing (*.DWG)|*.dwg|Autodesk Design Web Format (*.DWF)|*.dwf|AutoCAD DXF (*.DXF)|*.dxf|HD Photo (*.HDP & *.WDP)|*.hdp;*.wdp|All Files (*.*)|*.*";

        static void AccusoftError(System.Exception ErrorException, System.Windows.Forms.ToolStripStatusLabel statusLabel)
        {
            statusLabel.Text = ErrorException.Message + "\n" + ErrorException.Source + "\n";
        }

        static void AccusoftError(System.Exception ErrorException, System.Windows.Forms.Label ErrorLabel)
        {
            ErrorLabel.Text = ErrorException.Message + "\n" + ErrorException.Source + "\n";
        }

        static void AccusoftError(Accusoft.ImagXpressSdk.ImagXpressException ErrorException, System.Windows.Forms.ToolStripStatusLabel statusLabel)
        {
            statusLabel.Text = ErrorException.Message + "\n" + ErrorException.Source + "\n" + "Error Number: " + ErrorException.Number.ToString(System.Globalization.CultureInfo.CurrentCulture.NumberFormat);
        }

		static void AccusoftError(Accusoft.ImagXpressSdk.ImagXpressException ErrorException, System.Windows.Forms.Label ErrorLabel) 
		{
			ErrorLabel.Text = ErrorException.Message + "\n" + ErrorException.Source + "\n" + "Error Number: " + ErrorException.Number.ToString(System.Globalization.CultureInfo.CurrentCulture.NumberFormat);
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

		void AccusoftTextBoxScrollBinder(System.Windows.Forms.ScrollBar scrScroll, System.Windows.Forms.TextBox textTextBox)
		{
			System.Int32 iTmp;
			try 
			{
				iTmp = Convert.ToInt32(textTextBox.Text,cultNumber);
			} 
			catch (System.NullReferenceException ex)
			{
				AccusoftError(ex,statusLabel);
				textTextBox.Text = scrScroll.Value.ToString(cultNumber);
				return;
			}
			catch (System.Exception ex)
			{
				AccusoftError(ex,statusLabel);
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

	}
}
