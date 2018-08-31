/***************************************************************
* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Accusoft.ImagXpressSdk;

namespace ColorBalance
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
    {
		internal System.Windows.Forms.Button cmdReloadImage;
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage docAutoColorBalance;
		internal System.Windows.Forms.Button cmdAutoColorbalance;
		internal System.Windows.Forms.TabPage docAdjustColorBalance;
		internal System.Windows.Forms.Button cmdAdjustColorBalance;
		internal System.Windows.Forms.Label lblBlueVal;
		internal System.Windows.Forms.Label lblGreenVal;
		internal System.Windows.Forms.Label lblRedVal;
		internal System.Windows.Forms.HScrollBar hscrBlue;
		internal System.Windows.Forms.HScrollBar hscrGreen;
        internal System.Windows.Forms.HScrollBar hscrRed;
		internal System.Windows.Forms.Label lblBlue;
		internal System.Windows.Forms.Label lblGreen;
		internal System.Windows.Forms.Label lblRed;
        internal System.Windows.Forms.Label lblColor;
		internal System.Windows.Forms.Label lblError;
		internal System.Windows.Forms.Label lblLastError;
		internal System.Windows.Forms.ListBox lstInfo;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuFileOpen;
		private System.Windows.Forms.MenuItem mnuReloadCurrentImage;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem mnuQuit;
		private System.Windows.Forms.MenuItem mnuToolbar;
		private System.Windows.Forms.MenuItem mnuToolbarShow;
		private System.Windows.Forms.MenuItem mnuAbout;


		string imgFileName;
		Accusoft.ImagXpressSdk.ImageX imagX1;
        private TabPage tabPage1;
        internal Button button1;
        internal HScrollBar hscrColor;
        internal Label lblColorVal;
        private ImagXpress imagXpress1;
        private Processor processor1;
        private ImageXView imageXView1;
		private IContainer components;

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
            this.cmdReloadImage = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.docAutoColorBalance = new System.Windows.Forms.TabPage();
            this.cmdAutoColorbalance = new System.Windows.Forms.Button();
            this.docAdjustColorBalance = new System.Windows.Forms.TabPage();
            this.lblColorVal = new System.Windows.Forms.Label();
            this.hscrColor = new System.Windows.Forms.HScrollBar();
            this.cmdAdjustColorBalance = new System.Windows.Forms.Button();
            this.lblBlueVal = new System.Windows.Forms.Label();
            this.lblGreenVal = new System.Windows.Forms.Label();
            this.lblRedVal = new System.Windows.Forms.Label();
            this.hscrBlue = new System.Windows.Forms.HScrollBar();
            this.hscrGreen = new System.Windows.Forms.HScrollBar();
            this.hscrRed = new System.Windows.Forms.HScrollBar();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblLastError = new System.Windows.Forms.Label();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuFileOpen = new System.Windows.Forms.MenuItem();
            this.mnuReloadCurrentImage = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnuQuit = new System.Windows.Forms.MenuItem();
            this.mnuToolbar = new System.Windows.Forms.MenuItem();
            this.mnuToolbarShow = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.processor1 = new Accusoft.ImagXpressSdk.Processor(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.TabControl1.SuspendLayout();
            this.docAutoColorBalance.SuspendLayout();
            this.docAdjustColorBalance.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdReloadImage
            // 
            this.cmdReloadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdReloadImage.Location = new System.Drawing.Point(560, 88);
            this.cmdReloadImage.Name = "cmdReloadImage";
            this.cmdReloadImage.Size = new System.Drawing.Size(168, 32);
            this.cmdReloadImage.TabIndex = 46;
            this.cmdReloadImage.Text = "Reload Image";
            this.cmdReloadImage.Click += new System.EventHandler(this.cmdReloadImage_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.docAutoColorBalance);
            this.TabControl1.Controls.Add(this.docAdjustColorBalance);
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Location = new System.Drawing.Point(440, 136);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(408, 248);
            this.TabControl1.TabIndex = 45;
            // 
            // docAutoColorBalance
            // 
            this.docAutoColorBalance.BackColor = System.Drawing.SystemColors.Control;
            this.docAutoColorBalance.Controls.Add(this.cmdAutoColorbalance);
            this.docAutoColorBalance.Location = new System.Drawing.Point(4, 22);
            this.docAutoColorBalance.Name = "docAutoColorBalance";
            this.docAutoColorBalance.Size = new System.Drawing.Size(400, 222);
            this.docAutoColorBalance.TabIndex = 1;
            this.docAutoColorBalance.Text = "AutoColorBalance";
            this.docAutoColorBalance.Visible = false;
            // 
            // cmdAutoColorbalance
            // 
            this.cmdAutoColorbalance.Location = new System.Drawing.Point(136, 184);
            this.cmdAutoColorbalance.Name = "cmdAutoColorbalance";
            this.cmdAutoColorbalance.Size = new System.Drawing.Size(128, 32);
            this.cmdAutoColorbalance.TabIndex = 0;
            this.cmdAutoColorbalance.Text = "Apply";
            this.cmdAutoColorbalance.Click += new System.EventHandler(this.cmdAutoColorbalance_Click);
            // 
            // docAdjustColorBalance
            // 
            this.docAdjustColorBalance.BackColor = System.Drawing.SystemColors.Control;
            this.docAdjustColorBalance.Controls.Add(this.lblColorVal);
            this.docAdjustColorBalance.Controls.Add(this.hscrColor);
            this.docAdjustColorBalance.Controls.Add(this.cmdAdjustColorBalance);
            this.docAdjustColorBalance.Controls.Add(this.lblBlueVal);
            this.docAdjustColorBalance.Controls.Add(this.lblGreenVal);
            this.docAdjustColorBalance.Controls.Add(this.lblRedVal);
            this.docAdjustColorBalance.Controls.Add(this.hscrBlue);
            this.docAdjustColorBalance.Controls.Add(this.hscrGreen);
            this.docAdjustColorBalance.Controls.Add(this.hscrRed);
            this.docAdjustColorBalance.Controls.Add(this.lblBlue);
            this.docAdjustColorBalance.Controls.Add(this.lblGreen);
            this.docAdjustColorBalance.Controls.Add(this.lblRed);
            this.docAdjustColorBalance.Controls.Add(this.lblColor);
            this.docAdjustColorBalance.Location = new System.Drawing.Point(4, 22);
            this.docAdjustColorBalance.Name = "docAdjustColorBalance";
            this.docAdjustColorBalance.Size = new System.Drawing.Size(400, 222);
            this.docAdjustColorBalance.TabIndex = 2;
            this.docAdjustColorBalance.Text = "AdjustColorBalance";
            this.docAdjustColorBalance.Visible = false;
            // 
            // lblColorVal
            // 
            this.lblColorVal.Location = new System.Drawing.Point(336, 16);
            this.lblColorVal.Name = "lblColorVal";
            this.lblColorVal.Size = new System.Drawing.Size(48, 24);
            this.lblColorVal.TabIndex = 13;
            // 
            // hscrColor
            // 
            this.hscrColor.LargeChange = 1;
            this.hscrColor.Location = new System.Drawing.Point(104, 16);
            this.hscrColor.Name = "hscrColor";
            this.hscrColor.Size = new System.Drawing.Size(224, 16);
            this.hscrColor.TabIndex = 12;
            this.hscrColor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscrColor_Scroll);
            // 
            // cmdAdjustColorBalance
            // 
            this.cmdAdjustColorBalance.Location = new System.Drawing.Point(136, 184);
            this.cmdAdjustColorBalance.Name = "cmdAdjustColorBalance";
            this.cmdAdjustColorBalance.Size = new System.Drawing.Size(128, 32);
            this.cmdAdjustColorBalance.TabIndex = 11;
            this.cmdAdjustColorBalance.Text = "Apply";
            this.cmdAdjustColorBalance.Click += new System.EventHandler(this.cmdAdjustColorBalance_Click);
            // 
            // lblBlueVal
            // 
            this.lblBlueVal.Location = new System.Drawing.Point(336, 144);
            this.lblBlueVal.Name = "lblBlueVal";
            this.lblBlueVal.Size = new System.Drawing.Size(48, 16);
            this.lblBlueVal.TabIndex = 10;
            // 
            // lblGreenVal
            // 
            this.lblGreenVal.Location = new System.Drawing.Point(336, 96);
            this.lblGreenVal.Name = "lblGreenVal";
            this.lblGreenVal.Size = new System.Drawing.Size(48, 24);
            this.lblGreenVal.TabIndex = 9;
            // 
            // lblRedVal
            // 
            this.lblRedVal.Location = new System.Drawing.Point(336, 56);
            this.lblRedVal.Name = "lblRedVal";
            this.lblRedVal.Size = new System.Drawing.Size(48, 24);
            this.lblRedVal.TabIndex = 8;
            // 
            // hscrBlue
            // 
            this.hscrBlue.LargeChange = 1;
            this.hscrBlue.Location = new System.Drawing.Point(104, 144);
            this.hscrBlue.Minimum = -100;
            this.hscrBlue.Name = "hscrBlue";
            this.hscrBlue.Size = new System.Drawing.Size(224, 16);
            this.hscrBlue.TabIndex = 7;
            this.hscrBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscrBlue_Scroll);
            // 
            // hscrGreen
            // 
            this.hscrGreen.LargeChange = 1;
            this.hscrGreen.Location = new System.Drawing.Point(104, 96);
            this.hscrGreen.Minimum = -100;
            this.hscrGreen.Name = "hscrGreen";
            this.hscrGreen.Size = new System.Drawing.Size(224, 16);
            this.hscrGreen.TabIndex = 6;
            this.hscrGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscrGreen_Scroll);
            // 
            // hscrRed
            // 
            this.hscrRed.LargeChange = 1;
            this.hscrRed.Location = new System.Drawing.Point(104, 56);
            this.hscrRed.Minimum = -100;
            this.hscrRed.Name = "hscrRed";
            this.hscrRed.Size = new System.Drawing.Size(224, 16);
            this.hscrRed.TabIndex = 5;
            this.hscrRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscrRed_Scroll);
            // 
            // lblBlue
            // 
            this.lblBlue.Location = new System.Drawing.Point(16, 144);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(72, 24);
            this.lblBlue.TabIndex = 3;
            this.lblBlue.Text = "Blue:";
            // 
            // lblGreen
            // 
            this.lblGreen.Location = new System.Drawing.Point(16, 96);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(64, 24);
            this.lblGreen.TabIndex = 2;
            this.lblGreen.Text = "Green:";
            // 
            // lblRed
            // 
            this.lblRed.Location = new System.Drawing.Point(16, 56);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(64, 24);
            this.lblRed.TabIndex = 1;
            this.lblRed.Text = "Red:";
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(16, 16);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(64, 24);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(400, 222);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "AutoLightness";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.Click += new System.EventHandler(this.cmdAutoLightness_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Location = new System.Drawing.Point(501, 415);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(171, 79);
            this.lblError.TabIndex = 42;
            // 
            // lblLastError
            // 
            this.lblLastError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastError.AutoSize = true;
            this.lblLastError.Location = new System.Drawing.Point(437, 415);
            this.lblLastError.Name = "lblLastError";
            this.lblLastError.Size = new System.Drawing.Size(58, 13);
            this.lblLastError.TabIndex = 41;
            this.lblLastError.Text = "Last Error:";
            // 
            // lstInfo
            // 
            this.lstInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInfo.Items.AddRange(new object[] {
            "This sample demonstrates the following functionality:",
            "1) Adjusting the image color using the AutoLightness, AutoColorBalance, and Adjus" +
                "tColorBalance methods."});
            this.lstInfo.Location = new System.Drawing.Point(16, 8);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(832, 30);
            this.lstInfo.TabIndex = 40;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuToolbar,
            this.mnuAbout});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFileOpen,
            this.mnuReloadCurrentImage,
            this.menuItem4,
            this.mnuQuit});
            this.mnuFile.Text = "&File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Index = 0;
            this.mnuFileOpen.Text = "&Open Image...";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuReloadCurrentImage
            // 
            this.mnuReloadCurrentImage.Index = 1;
            this.mnuReloadCurrentImage.Text = "Reload Current Image";
            this.mnuReloadCurrentImage.Click += new System.EventHandler(this.mnuReloadCurrentImage_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "-";
            // 
            // mnuQuit
            // 
            this.mnuQuit.Index = 3;
            this.mnuQuit.Text = "&Quit";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
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
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // imageXView1
            // 
            this.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
            this.imageXView1.Location = new System.Drawing.Point(13, 45);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(418, 525);
            this.imageXView1.TabIndex = 47;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(872, 582);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.cmdReloadImage);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblLastError);
            this.Controls.Add(this.lstInfo);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorBalance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl1.ResumeLayout(false);
            this.docAutoColorBalance.ResumeLayout(false);
            this.docAdjustColorBalance.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

		private void LoadFile() 
		{
			try 
			{
                if (imageXView1.Image != null)
                    imageXView1.Image.Dispose();
				imagX1 = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, imgFileName);
				if ((imagX1.ImageXData.BitsPerPixel != 24)) 
				{
					MessageBox.Show("Image must be 24-bit for sample methods. Converting image to 24-bit.");
					processor1.Image = imagX1;
					processor1.ColorDepth(24, PaletteType.Fixed, DitherType.NoDither);
				}
				imageXView1.Image = imagX1;
				// clear out the error in case there was an error from a previous operation
				lblError.Text = "";
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex) 
			{
				AccusoftError(ex, lblError);
			}
		}


		private void Form1_Load(object sender, System.EventArgs e)
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

            String strCurrentDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");
            if (System.IO.Directory.Exists(strCurrentDir))
                System.IO.Directory.SetCurrentDirectory(strCurrentDir);
            strCurrentDir = System.IO.Directory.GetCurrentDirectory();

			imgFileName = System.IO.Path.Combine(strCurrentDir, "ImagXpress AutoBalance Sample.jpg");
			LoadFile();
			
			lblBlueVal.Text = hscrBlue.Value.ToString();
			lblGreenVal.Text = hscrGreen.Value.ToString();
			lblRedVal.Text = hscrRed.Value.ToString();
            lblColorVal.Text = hscrColor.Value.ToString();


		}

		private void hscrRed_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			lblRedVal.Text = hscrRed.Value.ToString();
		}

		private void hscrGreen_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			lblGreenVal.Text = hscrGreen.Value.ToString();
		}

		private void hscrBlue_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			lblBlueVal.Text = hscrBlue.Value.ToString();
		}

        private void hscrColor_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            lblColorVal.Text = hscrColor.Value.ToString();
        }

		private void mnuFileOpen_Click(object sender, System.EventArgs e)
		{
			imgFileName = AccusoftOpenFile();
			LoadFile();
		}
		private void mnuReloadCurrentImage_Click(object sender, System.EventArgs e)
		{
			LoadFile();
		}

		private void mnuQuit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void mnuToolbarShow_Click(object sender, System.EventArgs e)
		{
			if ((imageXView1.Toolbar.Activated == true)) 
			{
				mnuToolbarShow.Text = "Show";
				imageXView1.Toolbar.Activated = false;
			}
			else 
			{
				mnuToolbarShow.Text = "Hide";
				imageXView1.Toolbar.Activated = true;
			}
		}

		private void mnuAbout_Click(object sender, System.EventArgs e)
		{
			imagXpress1.AboutBox();
		}

		private void cmdReloadImage_Click(object sender, System.EventArgs e)
		{
			LoadFile();
		}

		private void cmdAutoLightness_Click(object sender, System.EventArgs e)
		{	
			try 
			{
				processor1.Image = imageXView1.Image;
				processor1.AutoLightness();
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex) 
			{
				AccusoftError(ex, lblError);
			}
		}

		private void cmdAutoColorbalance_Click(object sender, System.EventArgs e)
		{
			try 
			{
				processor1.Image = imageXView1.Image;
				processor1.AutoColorBalance();
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex) 
			{
				AccusoftError(ex, lblError);
			}

		}

		private void cmdAdjustColorBalance_Click(object sender, System.EventArgs e)
		{
	
			try 
			{
				processor1.Image = imageXView1.Image;
				processor1.AdjustColorBalance((short)(hscrColor.Value), (short)(hscrRed.Value), (short)hscrGreen.Value, (short)hscrBlue.Value);
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex) 
			{
				AccusoftError(ex, lblError);
			}
		}
		
	}
}
