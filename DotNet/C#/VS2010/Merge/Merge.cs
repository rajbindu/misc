/***************************************************************
* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MergeCSharp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MergeForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button buttonMerge;
		private System.Windows.Forms.CheckBox checkBoxTransparent;
		private System.Windows.Forms.ComboBox comboBoxMergeStyle;
		private System.Windows.Forms.ComboBox comboBoxTransparentColor;
		private System.Windows.Forms.ComboBox comboBoxMergeType;
		private System.Windows.Forms.HScrollBar hScrollBarMax;
		private System.Windows.Forms.HScrollBar hScrollBarMin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelPctMax;
		private System.Windows.Forms.Label labelPctMin;
		private System.String strImageFile1;
		private System.String strImageFile2;
		private System.Windows.Forms.RichTextBox rtfInfo;
		private Accusoft.ImagXpressSdk.ImagXpress imagXpress1;
		private Accusoft.ImagXpressSdk.ImageXView IxSource;
		private Accusoft.ImagXpressSdk.ImageXView IxDest;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.Label lblLastError;
		private System.Windows.Forms.Button buttonReloadDestination;
		private System.Boolean bSelectionActive;
		private System.Windows.Forms.MenuItem menuToolbar;
		private System.Windows.Forms.MenuItem menuToolbarShow;
		private System.Windows.Forms.MenuItem menuFileOpenSource;
		private System.Windows.Forms.MenuItem menuFileOpenDest;
		private System.Windows.Forms.MenuItem menuFileQuit;
		private IContainer components;

		public MergeForm()
		{
			//
			// Required for Windows Form Designer support
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergeForm));
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.buttonMerge = new System.Windows.Forms.Button();
            this.checkBoxTransparent = new System.Windows.Forms.CheckBox();
            this.comboBoxMergeStyle = new System.Windows.Forms.ComboBox();
            this.IxSource = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.comboBoxTransparentColor = new System.Windows.Forms.ComboBox();
            this.comboBoxMergeType = new System.Windows.Forms.ComboBox();
            this.hScrollBarMax = new System.Windows.Forms.HScrollBar();
            this.hScrollBarMin = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPctMax = new System.Windows.Forms.Label();
            this.labelPctMin = new System.Windows.Forms.Label();
            this.rtfInfo = new System.Windows.Forms.RichTextBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuFileOpenSource = new System.Windows.Forms.MenuItem();
            this.menuFileOpenDest = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuFileQuit = new System.Windows.Forms.MenuItem();
            this.menuToolbar = new System.Windows.Forms.MenuItem();
            this.menuToolbarShow = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.lblError = new System.Windows.Forms.Label();
            this.lblLastError = new System.Windows.Forms.Label();
            this.buttonReloadDestination = new System.Windows.Forms.Button();
            this.IxDest = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.SuspendLayout();
            // 
            // buttonMerge
            // 
            this.buttonMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMerge.Location = new System.Drawing.Point(440, 233);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(168, 32);
            this.buttonMerge.TabIndex = 1;
            this.buttonMerge.Text = "Merge";
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // checkBoxTransparent
            // 
            this.checkBoxTransparent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxTransparent.Location = new System.Drawing.Point(16, 388);
            this.checkBoxTransparent.Name = "checkBoxTransparent";
            this.checkBoxTransparent.Size = new System.Drawing.Size(88, 16);
            this.checkBoxTransparent.TabIndex = 6;
            this.checkBoxTransparent.Text = "Transparent";
            this.checkBoxTransparent.Click += new System.EventHandler(this.checkBoxTransparent_Click);
            // 
            // comboBoxMergeStyle
            // 
            this.comboBoxMergeStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMergeStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMergeStyle.Items.AddRange(new object[] {
            "Normal",
            "If Darker",
            "If Lighter",
            "Additive",
            "Subtractive",
            "Superimpose",
            "Superimpose Bottom to Top",
            "Superimpose Horiz from Center",
            "Superimpose Horiz to Center",
            "Superimpose Left to Right",
            "Superimpose Right to Left",
            "Superimpose Top to Bottom",
            "Superimpose Vert. from Center",
            "Superimpose Vert. to Center"});
            this.comboBoxMergeStyle.Location = new System.Drawing.Point(360, 404);
            this.comboBoxMergeStyle.Name = "comboBoxMergeStyle";
            this.comboBoxMergeStyle.Size = new System.Drawing.Size(248, 21);
            this.comboBoxMergeStyle.TabIndex = 5;
            // 
            // IxSource
            // 
            this.IxSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.IxSource.Location = new System.Drawing.Point(440, 80);
            this.IxSource.Name = "IxSource";
            this.IxSource.Size = new System.Drawing.Size(168, 147);
            this.IxSource.TabIndex = 15;
            // 
            // comboBoxTransparentColor
            // 
            this.comboBoxTransparentColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxTransparentColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransparentColor.Enabled = false;
            this.comboBoxTransparentColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "White"});
            this.comboBoxTransparentColor.Location = new System.Drawing.Point(16, 404);
            this.comboBoxTransparentColor.Name = "comboBoxTransparentColor";
            this.comboBoxTransparentColor.Size = new System.Drawing.Size(104, 21);
            this.comboBoxTransparentColor.TabIndex = 3;
            this.comboBoxTransparentColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransparentColor_SelectedIndexChanged);
            // 
            // comboBoxMergeType
            // 
            this.comboBoxMergeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMergeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMergeType.Items.AddRange(new object[] {
            "Crop",
            "Resize Area",
            "Resize Image",
            "Tile Image"});
            this.comboBoxMergeType.Location = new System.Drawing.Point(152, 404);
            this.comboBoxMergeType.Name = "comboBoxMergeType";
            this.comboBoxMergeType.Size = new System.Drawing.Size(168, 21);
            this.comboBoxMergeType.TabIndex = 4;
            // 
            // hScrollBarMax
            // 
            this.hScrollBarMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBarMax.LargeChange = 1;
            this.hScrollBarMax.Location = new System.Drawing.Point(176, 436);
            this.hScrollBarMax.Name = "hScrollBarMax";
            this.hScrollBarMax.Size = new System.Drawing.Size(432, 17);
            this.hScrollBarMax.TabIndex = 7;
            this.hScrollBarMax.Value = 100;
            this.hScrollBarMax.ValueChanged += new System.EventHandler(this.hScrollBarMax_ValueChanged);
            // 
            // hScrollBarMin
            // 
            this.hScrollBarMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBarMin.LargeChange = 1;
            this.hScrollBarMin.Location = new System.Drawing.Point(176, 468);
            this.hScrollBarMin.Name = "hScrollBarMin";
            this.hScrollBarMin.Size = new System.Drawing.Size(432, 16);
            this.hScrollBarMin.TabIndex = 7;
            this.hScrollBarMin.ValueChanged += new System.EventHandler(this.hScrollBarMin_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(8, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Superimpose Percent Max";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(8, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Superimpose Percent Min";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPctMax
            // 
            this.labelPctMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPctMax.Location = new System.Drawing.Point(144, 436);
            this.labelPctMax.Name = "labelPctMax";
            this.labelPctMax.Size = new System.Drawing.Size(24, 17);
            this.labelPctMax.TabIndex = 20;
            this.labelPctMax.Text = "100";
            this.labelPctMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPctMin
            // 
            this.labelPctMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPctMin.Location = new System.Drawing.Point(144, 468);
            this.labelPctMin.Name = "labelPctMin";
            this.labelPctMin.Size = new System.Drawing.Size(24, 16);
            this.labelPctMin.TabIndex = 21;
            this.labelPctMin.Text = "0";
            this.labelPctMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtfInfo
            // 
            this.rtfInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfInfo.Location = new System.Drawing.Point(16, 8);
            this.rtfInfo.Name = "rtfInfo";
            this.rtfInfo.Size = new System.Drawing.Size(592, 64);
            this.rtfInfo.TabIndex = 22;
            this.rtfInfo.Text = "This example demonstrates how to use the Area and Merge methods to combine images" +
                " together.";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuToolbar,
            this.menuItem2});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFileOpenSource,
            this.menuFileOpenDest,
            this.menuItem5,
            this.menuFileQuit});
            this.menuFile.Text = "&File";
            // 
            // menuFileOpenSource
            // 
            this.menuFileOpenSource.Index = 0;
            this.menuFileOpenSource.Text = "Open &Source Image";
            this.menuFileOpenSource.Click += new System.EventHandler(this.menuFileOpenSource_Click);
            // 
            // menuFileOpenDest
            // 
            this.menuFileOpenDest.Index = 1;
            this.menuFileOpenDest.Text = "Open &Destination Image";
            this.menuFileOpenDest.Click += new System.EventHandler(this.menuFileOpenDest_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "-";
            // 
            // menuFileQuit
            // 
            this.menuFileQuit.Index = 3;
            this.menuFileQuit.Text = "&Quit";
            this.menuFileQuit.Click += new System.EventHandler(this.menuFileQuit_Click);
            // 
            // menuToolbar
            // 
            this.menuToolbar.Index = 1;
            this.menuToolbar.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuToolbarShow});
            this.menuToolbar.Text = "&Toolbar";
            // 
            // menuToolbarShow
            // 
            this.menuToolbarShow.Index = 0;
            this.menuToolbarShow.Text = "&Show";
            this.menuToolbarShow.Click += new System.EventHandler(this.menuToolbarShow_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "&About";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Location = new System.Drawing.Point(72, 492);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(544, 28);
            this.lblError.TabIndex = 24;
            // 
            // lblLastError
            // 
            this.lblLastError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLastError.Location = new System.Drawing.Point(8, 492);
            this.lblLastError.Name = "lblLastError";
            this.lblLastError.Size = new System.Drawing.Size(64, 16);
            this.lblLastError.TabIndex = 25;
            this.lblLastError.Text = "Last Error:";
            // 
            // buttonReloadDestination
            // 
            this.buttonReloadDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReloadDestination.Location = new System.Drawing.Point(440, 272);
            this.buttonReloadDestination.Name = "buttonReloadDestination";
            this.buttonReloadDestination.Size = new System.Drawing.Size(168, 32);
            this.buttonReloadDestination.TabIndex = 26;
            this.buttonReloadDestination.Text = "Reload Destination Image";
            this.buttonReloadDestination.Click += new System.EventHandler(this.buttonReloadDestination_Click);
            // 
            // IxDest
            // 
            this.IxDest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.IxDest.AutoScroll = true;
            this.IxDest.Location = new System.Drawing.Point(16, 80);
            this.IxDest.Name = "IxDest";
            this.IxDest.Size = new System.Drawing.Size(415, 300);
            this.IxDest.TabIndex = 27;
            this.IxDest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IxDest_MouseDown);
            this.IxDest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.IxDest_MouseMove);
            this.IxDest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IxDest_MouseUp);
            // 
            // MergeForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(624, 545);
            this.Controls.Add(this.IxDest);
            this.Controls.Add(this.buttonReloadDestination);
            this.Controls.Add(this.lblLastError);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.rtfInfo);
            this.Controls.Add(this.labelPctMin);
            this.Controls.Add(this.labelPctMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBarMin);
            this.Controls.Add(this.hScrollBarMax);
            this.Controls.Add(this.comboBoxMergeType);
            this.Controls.Add(this.comboBoxTransparentColor);
            this.Controls.Add(this.IxSource);
            this.Controls.Add(this.comboBoxMergeStyle);
            this.Controls.Add(this.checkBoxTransparent);
            this.Controls.Add(this.buttonMerge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "MergeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge";
            this.Load += new System.EventHandler(this.FormMain_Load);
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
			Application.Run(new MergeForm());
		}

		private void FormMain_Load(object sender, System.EventArgs e)
		{

			//***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
			//imagXpress1.Licensing.SetSolutionName("YourSolutionName");
			//imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345);
			//imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�");

			// Because in this sample the ImageX object is always located in the ImageXView
			// tell the ImageXView component to dispose of the ImageX object when itself is
			// disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
			// Dispose method before the components.Dispose() section.
			IxDest.AutoImageDispose = true;
			IxSource.AutoImageDispose = true;

			// Set the current directory to the Common\Images directory
			String strCurrentDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");
			if (System.IO.Directory.Exists(strCurrentDir))
				System.IO.Directory.SetCurrentDirectory(strCurrentDir);
			strCurrentDir = System.IO.Directory.GetCurrentDirectory();

			// Set some initial files
			strImageFile1 = "Dome.jpg";
			strImageFile2 = "ball1.bmp";
			if (System.IO.File.Exists(strImageFile1))
				IxDest.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImageFile1);
			if (System.IO.File.Exists(strImageFile1))
				IxSource.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImageFile2);

			bSelectionActive = false;
			comboBoxMergeType.SelectedIndex = 0;
			comboBoxMergeStyle.SelectedIndex = 0;
		}
		
		private void hScrollBarMax_ValueChanged(object sender, System.EventArgs e)
		{
			labelPctMax.Text = hScrollBarMax.Value.ToString(cultNumber);
		}

		private void hScrollBarMin_ValueChanged(object sender, System.EventArgs e)
		{
			labelPctMin.Text = hScrollBarMin.Value.ToString(cultNumber);
		}

		private void checkBoxTransparent_Click(object sender, System.EventArgs e)
		{
			comboBoxTransparentColor.Enabled = checkBoxTransparent.Checked;
		}

		private void buttonMerge_Click(object sender, System.EventArgs e)
		{
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
		
			Accusoft.ImagXpressSdk.Processor process;
			process = new Accusoft.ImagXpressSdk.Processor(imagXpress1, IxDest.Image);
			System.Drawing.PointF MergeTL = new System.Drawing.PointF(IxDest.Rubberband.Dimensions.X,IxDest.Rubberband.Dimensions.Y);
			System.Drawing.SizeF MergeSize = new System.Drawing.SizeF(IxDest.Rubberband.Dimensions.Width,IxDest.Rubberband.Dimensions.Height);
			System.Drawing.RectangleF MergeRegion = new System.Drawing.RectangleF(MergeTL,MergeSize);

			process.SetArea(MergeRegion);

			System.Drawing.Color daColor;
			switch (comboBoxTransparentColor.SelectedIndex) //red, green, blue, white
			{
				case 0: 
				{
					daColor = System.Drawing.Color.Red;
				} break;
				case 1: 
				{
					daColor = System.Drawing.Color.FromArgb(0, 255, 0);
				} break;
				case 2: 
				{
					daColor = System.Drawing.Color.Blue;
				} break;
				case 3:
				{
					daColor = System.Drawing.Color.White;
				} break;
				default: 
				{
					daColor = System.Drawing.Color.Black;
				} break;
			}

			Accusoft.ImagXpressSdk.ImageX imageSource = IxSource.Image;
			process.Merge(ref imageSource,(Accusoft.ImagXpressSdk.MergeSize)comboBoxMergeType.SelectedIndex,(Accusoft.ImagXpressSdk.MergeStyle)comboBoxMergeStyle.SelectedIndex,checkBoxTransparent.Checked,daColor,hScrollBarMax.Value,hScrollBarMin.Value);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			
		}


		#region Accusoft Sample Application Standard Functions
		/*********************************************************************
		 *     Accusoft Corporation Standard Function Definitions     *
		 *********************************************************************/

		private System.Globalization.NumberFormatInfo cultNumber = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
		private System.Globalization.TextInfo cultText = System.Globalization.CultureInfo.CurrentCulture.TextInfo;
		private System.Globalization.CompareInfo cultCompare = System.Globalization.CultureInfo.CurrentCulture.CompareInfo;
		const System.String strDefaultImageFilter = "All ImagXpress Supported File Types|*.bmp;*.cal;*.dib;*.dca;*.mod;*.dcx;*.gif;*.jp2;*.jls;*.jpg;*.jif;*.ljp;*.pbm;*.pcx;*.pgm;*.pic;*.png;*.ppm;*.tiff;*.tif;*.tga;*.wsq;*.jb2;*.gif;*.jpeg;*.cals;*.jbig2;*.ico;*.rle;*.lzw;*.wbmp;*.dwg;*.dxf;*.dwf;*.hdp;*.wdp|Windows Bitmap (*.BMP)|*.bmp|CALS (*.CAL)|*.cal|Windows Device Independent Bitmap(*.DIB)|*.dib|MO:DCA (*.DCA & *.MOD)|*.dca;*.mod|Zsoft Multiple Page (*.DCX)|*.dcx|CompuServe GIF (*.GIF)|*.gif|JPEG 2000 (*.JP2)|*.jp2|JPEG LS (*.JLS)|*.jls|JFIF Compliant JPEG (*.JPG & *.JIF)|*.jpg;*.jif|Lossless JPEG (*.LJP)|*.ljp|Portable Bitmap (*.PBM)|*.pbm|Zsoft PaintBrush (*.PCX)|*.pcx|Portable Graymap (*.PGM)|*.pgm|Pegasus PIC or Enhanced PIC (*.PIC)|*.pic|Portable Network Graphics (*.PNG)|*.png|Portable Pixmap (*.PPM)|*.ppm|Tagged Image Format (*.TIFF)|*.tif;*.tiff|Truevision TARGA (*.TGA)|*.tga|WSQ Fingerprint File (*.WSQ)|*.wsq|JBIG2 File (*.JB2)|*.jb2|CAD Drawing (*.DWG)|*.dwg|Autodesk Design Web Format (*.DWF)|*.dwf|AutoCAD DXF (*.DXF)|*.dxf|HD Photo (*.HDP & *.WDP)|*.hdp;*.wdp|All Files (*.*)|*.*";

		static void AccusoftError(System.Exception ErrorException, System.Windows.Forms.Label ErrorLabel) 
		{
			ErrorLabel.Text = ErrorException.Message + "\n" + ErrorException.Source + "\n";
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
				AccusoftError(ex,lblError);
				textTextBox.Text = scrScroll.Value.ToString(cultNumber);
				return;
			}
			catch (System.Exception ex)
			{
				AccusoftError(ex,lblError);
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

		private void buttonReloadDestination_Click(object sender, System.EventArgs e)
		{
			IxDest.AllowUpdate = false;
			// Dispose the ImageX object if the ImageXView has one
			if (IxDest.Image != null)
			{
				IxDest.Image.Dispose();
				IxDest.Image = null;
			}
			IxDest.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImageFile1);
			IxDest.AllowUpdate = true;
		}

		private void IxDest_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			IxDest.Rubberband.Enabled = false;
			IxDest.Rubberband.Start(new System.Drawing.Point(e.X,e.Y));
			IxDest.Rubberband.Enabled = true;
			bSelectionActive = true;
		}

		private void IxDest_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (bSelectionActive) 
			{
				IxDest.Rubberband.Update(new System.Drawing.Point(e.X,e.Y));
			}
		}

		private void IxDest_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			IxDest.Rubberband.Update(new System.Drawing.Point(e.X,e.Y));
			bSelectionActive = false;
		}

		private void menuToolbarShow_Click(object sender, System.EventArgs e)
		{
			menuToolbarShow.Text = (IxDest.Toolbar.Activated)? "&Show":"&Hide";
			try
			{
				IxDest.Toolbar.Activated = !IxDest.Toolbar.Activated;
			} catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
			{
				AccusoftError(eX,lblError);
            }
		}

		private void menuFileOpenSource_Click(object sender, System.EventArgs e)
		{
			System.String strTmp = AccusoftOpenFile();
			if (strTmp.Length != 0) 
			{
				strImageFile2 = strTmp;
				try 
				{
					// Dispose the ImageX object if the ImageXView has one
					if (IxSource.Image != null)
					{
						IxSource.Image.Dispose();
						IxSource.Image = null;
					}
					IxSource.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImageFile2);
				} 
				catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
				{
					AccusoftError(eX,lblError);
				}
				catch (System.IO.IOException eX)
				{
					AccusoftError(eX,lblError);
				}
			}
		}

		private void menuFileOpenDest_Click(object sender, System.EventArgs e)
		{
			System.String strTmp = AccusoftOpenFile();
			if (strTmp.Length != 0) 
			{
				strImageFile1 = strTmp;
				try 
				{
					// Dispose the ImageX object if the ImageXView has one
					if (IxDest.Image != null)
					{
						IxDest.Image.Dispose();
						IxDest.Image = null;
					}
					IxDest.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImageFile1);
				} 
				catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
				{
					AccusoftError(eX,lblError);
				}
			}
		}

		private void menuFileQuit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			try 
			{
				imagXpress1.AboutBox();
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
			{
				AccusoftError(eX,lblError);
			}
		}

		private void comboBoxTransparentColor_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
