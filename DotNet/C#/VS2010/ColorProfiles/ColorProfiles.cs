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

namespace ColorProfiles
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ColorProfilesForm : System.Windows.Forms.Form
    {
		private Accusoft.ImagXpressSdk.LoadOptions loLoadOptions;
		private System.Windows.Forms.CheckBox checkICM;
		private System.Windows.Forms.CheckBox checkICMProofing;
		private System.String ICMMonitorProfile;
		private System.String ICMPrinterProfile;
		private System.String ICMTargetProfile;
		private System.String strCurrentDir;
		private System.String strCurrentImage;
		private Accusoft.ImagXpressSdk.RenderIntent ICMRenderIntent;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuFileOpenMonitor;
		private System.Windows.Forms.MenuItem menuFileOpenPrinter;
		private System.Windows.Forms.MenuItem menuFileOpenTarget;
		private System.Windows.Forms.MenuItem menuFileOpenImage;
		private System.Windows.Forms.MenuItem menuFileQuit;
		private System.Windows.Forms.MenuItem menuToolbar;
		private System.Windows.Forms.MenuItem menuAbout;
		private System.Windows.Forms.MenuItem menuToolbarShow;
		private System.Windows.Forms.Label lblRenderIntent;
		private System.Windows.Forms.Label labelLastError;
		private System.Windows.Forms.Label labelError;
		private System.Windows.Forms.ComboBox comboRenderIntent;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private ImagXpress imagXpress1;
        private ImageXView imageXView1;
		private IContainer components;

		public ColorProfilesForm()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorProfilesForm));
            this.checkICM = new System.Windows.Forms.CheckBox();
            this.checkICMProofing = new System.Windows.Forms.CheckBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuFileOpenMonitor = new System.Windows.Forms.MenuItem();
            this.menuFileOpenPrinter = new System.Windows.Forms.MenuItem();
            this.menuFileOpenTarget = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuFileOpenImage = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuFileQuit = new System.Windows.Forms.MenuItem();
            this.menuToolbar = new System.Windows.Forms.MenuItem();
            this.menuToolbarShow = new System.Windows.Forms.MenuItem();
            this.menuAbout = new System.Windows.Forms.MenuItem();
            this.comboRenderIntent = new System.Windows.Forms.ComboBox();
            this.lblRenderIntent = new System.Windows.Forms.Label();
            this.labelLastError = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.SuspendLayout();
            // 
            // checkICM
            // 
            this.checkICM.Checked = true;
            this.checkICM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkICM.Location = new System.Drawing.Point(12, 495);
            this.checkICM.Name = "checkICM";
            this.checkICM.Size = new System.Drawing.Size(94, 21);
            this.checkICM.TabIndex = 1;
            this.checkICM.Text = "ICM Enabled";
            this.checkICM.CheckedChanged += new System.EventHandler(this.checkICM_CheckedChanged);
            // 
            // checkICMProofing
            // 
            this.checkICMProofing.Checked = true;
            this.checkICMProofing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkICMProofing.Location = new System.Drawing.Point(112, 495);
            this.checkICMProofing.Name = "checkICMProofing";
            this.checkICMProofing.Size = new System.Drawing.Size(136, 21);
            this.checkICMProofing.TabIndex = 2;
            this.checkICMProofing.Text = "ICM Proofing Enabled";
            this.checkICMProofing.CheckedChanged += new System.EventHandler(this.checkICMProofing_CheckedChanged);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuToolbar,
            this.menuAbout});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFileOpenMonitor,
            this.menuFileOpenPrinter,
            this.menuFileOpenTarget,
            this.menuItem5,
            this.menuFileOpenImage,
            this.menuItem7,
            this.menuFileQuit});
            this.menuFile.Text = "&File";
            // 
            // menuFileOpenMonitor
            // 
            this.menuFileOpenMonitor.Index = 0;
            this.menuFileOpenMonitor.Text = "Open &Monitor Profile";
            this.menuFileOpenMonitor.Click += new System.EventHandler(this.menuFileOpenMonitor_Click);
            // 
            // menuFileOpenPrinter
            // 
            this.menuFileOpenPrinter.Index = 1;
            this.menuFileOpenPrinter.Text = "Open &Printer Profile";
            this.menuFileOpenPrinter.Click += new System.EventHandler(this.menuFileOpenPrinter_Click);
            // 
            // menuFileOpenTarget
            // 
            this.menuFileOpenTarget.Index = 2;
            this.menuFileOpenTarget.Text = "Open &Target Profile";
            this.menuFileOpenTarget.Click += new System.EventHandler(this.menuFileOpenTarget_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.Text = "-";
            // 
            // menuFileOpenImage
            // 
            this.menuFileOpenImage.Index = 4;
            this.menuFileOpenImage.Text = "&Open Image";
            this.menuFileOpenImage.Click += new System.EventHandler(this.menuFileOpenImage_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 5;
            this.menuItem7.Text = "-";
            // 
            // menuFileQuit
            // 
            this.menuFileQuit.Index = 6;
            this.menuFileQuit.Text = "&Quit";
            this.menuFileQuit.Click += new System.EventHandler(this.menuItem8_Click);
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
            // menuAbout
            // 
            this.menuAbout.Index = 2;
            this.menuAbout.Text = "&About";
            this.menuAbout.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // comboRenderIntent
            // 
            this.comboRenderIntent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRenderIntent.Items.AddRange(new object[] {
            "Images",
            "Business",
            "Graphics",
            "Absolute Color Metric"});
            this.comboRenderIntent.Location = new System.Drawing.Point(536, 492);
            this.comboRenderIntent.Name = "comboRenderIntent";
            this.comboRenderIntent.Size = new System.Drawing.Size(169, 21);
            this.comboRenderIntent.TabIndex = 3;
            this.comboRenderIntent.SelectedIndexChanged += new System.EventHandler(this.comboRenderIntent_SelectedIndexChanged);
            // 
            // lblRenderIntent
            // 
            this.lblRenderIntent.Location = new System.Drawing.Point(425, 493);
            this.lblRenderIntent.Name = "lblRenderIntent";
            this.lblRenderIntent.Size = new System.Drawing.Size(87, 16);
            this.lblRenderIntent.TabIndex = 4;
            this.lblRenderIntent.Text = "Render Intent:";
            this.lblRenderIntent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLastError
            // 
            this.labelLastError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastError.Location = new System.Drawing.Point(368, 136);
            this.labelLastError.Name = "labelLastError";
            this.labelLastError.Size = new System.Drawing.Size(63, 16);
            this.labelLastError.TabIndex = 5;
            this.labelLastError.Text = "Last Error:";
            // 
            // labelError
            // 
            this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelError.Location = new System.Drawing.Point(425, 136);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(271, 40);
            this.labelError.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(8, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(697, 120);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // imageXView1
            // 
            this.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
            this.imageXView1.Location = new System.Drawing.Point(8, 127);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(341, 344);
            this.imageXView1.TabIndex = 8;
            // 
            // ColorProfilesForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(712, 528);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelLastError);
            this.Controls.Add(this.lblRenderIntent);
            this.Controls.Add(this.comboRenderIntent);
            this.Controls.Add(this.checkICMProofing);
            this.Controls.Add(this.checkICM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "ColorProfilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Profiles";
            this.Load += new System.EventHandler(this.formMain_Load);
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
			Application.Run(new ColorProfilesForm());
		}

		private void formMain_Load(object sender, System.EventArgs e)
		{



            comboRenderIntent.SelectedIndex = 0;

			//***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
			//imagXpress1.Licensing.SetSolutionName("YourSolutionName");
			//imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345);
			//imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�");

            // Because in this sample the ImageX object is always located in the ImageXView
            // tell the ImageXView component to dispose of the ImageX object when itself is
            // disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
            // Dispose method before the components.Dispose() section.
            imageXView1.AutoImageDispose = true;

			loLoadOptions = new Accusoft.ImagXpressSdk.LoadOptions();

			ICMMonitorProfile = imageXView1.MonitorProfileName;
			ICMPrinterProfile = imageXView1.PrinterProfileName;
			ICMTargetProfile = imageXView1.TargetProfileName;	
			ICMRenderIntent = imageXView1.ColorRenderIntent;
			//here we set the current directory and image so that the file open dialog box works well
            strCurrentDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");
            if (System.IO.Directory.Exists(strCurrentDir))
                System.IO.Directory.SetCurrentDirectory(strCurrentDir);
            strCurrentDir = System.IO.Directory.GetCurrentDirectory();

			strCurrentImage = System.IO.Path.Combine (strCurrentDir, "window.jpg");

			imageXView1.IcmEnabled = true;
			imageXView1.IcmProofingEnabled = true;

			if (System.IO.File.Exists(strCurrentImage))
			{
				try 
				{
					imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strCurrentImage, loLoadOptions);
				}
				catch (Accusoft.ImagXpressSdk.ImagXpressException eX) 
				{
					AccusoftError(eX,labelError);
				}
			}
		}
		private void checkICMProofing_CheckedChanged(object sender, System.EventArgs e)
		{
			imageXView1.IcmProofingEnabled = checkICMProofing.Checked;
		}

		private void checkICM_CheckedChanged(object sender, System.EventArgs e)
		{
			imageXView1.IcmEnabled = checkICM.Checked;
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			imagXpress1.AboutBox();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuToolbarShow_Click(object sender, System.EventArgs e)
		{
		
			menuToolbarShow.Text = (imageXView1.Toolbar.Activated)? "&Show":"&Hide";
			try 
			{
				imageXView1.Toolbar.Activated = !imageXView1.Toolbar.Activated;
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException eX) 
			{
				AccusoftError(eX,labelError);
			}
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
			dlg.InitialDirectory = System.IO.Path.GetFullPath(strCurrentDir);
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				strCurrentDir = dlg.FileName.Remove(dlg.FileName.LastIndexOf(@"\"),dlg.FileName.Length - dlg.FileName.LastIndexOf(@"\"));
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
			dlg.InitialDirectory = System.IO.Path.GetFullPath(strCurrentDir);
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				strCurrentDir = dlg.FileName.Remove(dlg.FileName.LastIndexOf(@"\"),dlg.FileName.Length - dlg.FileName.LastIndexOf(@"\"));
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
				AccusoftError(ex,labelError);
				textTextBox.Text = scrScroll.Value.ToString(cultNumber);
				return;
			}
			catch (System.Exception ex)
			{
				AccusoftError(ex,labelError);
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
		
		private void comboRenderIntent_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			ICMRenderIntent = (Accusoft.ImagXpressSdk.RenderIntent)comboRenderIntent.SelectedIndex;
			imageXView1.ColorRenderIntent = ICMRenderIntent;
		}
		private void menuFileOpenMonitor_Click(object sender, System.EventArgs e)
		{

			ICMMonitorProfile = GetICMProfile();
			if (ICMMonitorProfile.Length != 0) 
			{
				
				imageXView1.MonitorProfileName = ICMMonitorProfile;
				imageXView1.IcmEnabled = true;
				imageXView1.IcmProofingEnabled = false;
				checkICM.Checked = true;
				checkICMProofing.Checked = false;
			}
		}
		private System.String GetICMProfile() 
		{
				System.String oldDir,strProfile;
				oldDir = strCurrentDir;
				strCurrentDir = Environment.SystemDirectory + "\\spool\\drivers\\color";
				strProfile = AccusoftOpenFile("All Supported Profiles|*.icm;*.icc");
				strCurrentDir = oldDir;
				if (strProfile.Length != 0) 
				{
					return strProfile;
				} 
				else 
				{
				
					return "";
				}

			
		}

		private void menuFileOpenPrinter_Click(object sender, System.EventArgs e)
		{
			ICMPrinterProfile = GetICMProfile();
			if (ICMPrinterProfile.Length != 0) 
			{
				imageXView1.PrinterProfileName = ICMPrinterProfile;
				imageXView1.IcmEnabled = true;
				imageXView1.IcmProofingEnabled = false;
				checkICM.Checked = true;
				checkICMProofing.Checked = false;
			}
		}

		private void menuFileOpenTarget_Click(object sender, System.EventArgs e)
		{
			ICMTargetProfile = GetICMProfile();
			if (ICMTargetProfile.Length != 0) 
			{
                imageXView1.TargetProfileName = ICMTargetProfile;
				imageXView1.IcmEnabled = true;
				imageXView1.IcmProofingEnabled = false;
				checkICM.Checked = true;
				checkICMProofing.Checked = false;
			}
		}

		private void menuFileOpenImage_Click(object sender, System.EventArgs e)
		{

			System.String strNewIF = AccusoftOpenFile();
			if (strNewIF.Length != 0) 
			{
				try
				{
                    if (imageXView1.Image != null)
                        imageXView1.Image.Dispose();
					imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strNewIF, loLoadOptions);
					checkICM.Checked = true;
					checkICMProofing.Checked = true;
				}
				catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
				{
						
					AccusoftError(ex,labelError);

				}
				}
			
		}

	}
}
