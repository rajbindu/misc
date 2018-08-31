/***************************************************************
* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ImageLoadingAndSaving
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ImageLoadingAndSavingForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mnuFile;
		private System.Windows.Forms.MenuItem mnuFileFile;
		private System.Windows.Forms.MenuItem mnuFileOpen;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem mnuFileQuit;
        private System.Windows.Forms.ComboBox cmbMethod;
		private System.String strImageFile;
        private Accusoft.ImagXpressSdk.LoadOptions loLoadOptions;

		private System.Windows.Forms.MenuItem mnuToolbar;
		private System.Windows.Forms.MenuItem mnuToolbarShow;
		private System.Windows.Forms.MenuItem mnuAbout;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.Label lblLastError;
		private System.Windows.Forms.Button cmdLoad;
		private System.Windows.Forms.Button cmdSave;
		private System.Windows.Forms.ComboBox cmbSave;
		private System.Windows.Forms.ListBox lstStatus;
		private System.Windows.Forms.ListBox lstDesc;
		internal System.Windows.Forms.Label lblLoadStatus;
        private Accusoft.ImagXpressSdk.ImagXpress imagXpress1;
        private Accusoft.ImagXpressSdk.ImageXView imageXView1;
		private IContainer components;

		public ImageLoadingAndSavingForm()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageLoadingAndSavingForm));
            this.mnuFile = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFileFile = new System.Windows.Forms.MenuItem();
            this.mnuFileOpen = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuFileQuit = new System.Windows.Forms.MenuItem();
            this.mnuToolbar = new System.Windows.Forms.MenuItem();
            this.mnuToolbarShow = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblLastError = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmbSave = new System.Windows.Forms.ComboBox();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.lstDesc = new System.Windows.Forms.ListBox();
            this.lblLoadStatus = new System.Windows.Forms.Label();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
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
            this.menuItem3,
            this.mnuFileQuit});
            this.mnuFileFile.Text = "&File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Index = 0;
            this.mnuFileOpen.Text = "&Open (Change Image Location)";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "-";
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
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // cmbMethod
            // 
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.Items.AddRange(new object[] {
            "From File",
            "From Stream",
            "From HBITMAP",
            "From HDIB"});
            this.cmbMethod.Location = new System.Drawing.Point(184, 88);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(144, 21);
            this.cmbMethod.TabIndex = 3;
            this.cmbMethod.SelectedIndexChanged += new System.EventHandler(this.cmbMethod_SelectedIndexChanged);
            // 
            // cmdLoad
            // 
            this.cmdLoad.Location = new System.Drawing.Point(16, 88);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(144, 24);
            this.cmdLoad.TabIndex = 5;
            this.cmdLoad.Text = "Load Image by Method";
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Location = new System.Drawing.Point(336, 355);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(224, 96);
            this.lblError.TabIndex = 9;
            // 
            // lblLastError
            // 
            this.lblLastError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastError.Location = new System.Drawing.Point(336, 331);
            this.lblLastError.Name = "lblLastError";
            this.lblLastError.Size = new System.Drawing.Size(64, 16);
            this.lblLastError.TabIndex = 10;
            this.lblLastError.Text = "Last Error:";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(16, 136);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(144, 24);
            this.cmdSave.TabIndex = 11;
            this.cmdSave.Text = "SaveImage";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmbSave
            // 
            this.cmbSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSave.Items.AddRange(new object[] {
            "Save as BMP",
            "Save as JPG",
            "Save as TIFF"});
            this.cmbSave.Location = new System.Drawing.Point(184, 136);
            this.cmbSave.Name = "cmbSave";
            this.cmbSave.Size = new System.Drawing.Size(144, 21);
            this.cmbSave.TabIndex = 12;
            // 
            // lstStatus
            // 
            this.lstStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStatus.Location = new System.Drawing.Point(336, 144);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(232, 147);
            this.lstStatus.TabIndex = 13;
            // 
            // lstDesc
            // 
            this.lstDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDesc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDesc.Items.AddRange(new object[] {
            "This sample demonstrates the following functionality:",
            "1)Loading image data into the control via the FromFile, FromHbitmap, ",
            "   FromHdib and FromStream methods of the ImageX class.",
            "2)Saving image data via the SaveOptions class and the Save method of the ImageX c" +
                "lass."});
            this.lstDesc.Location = new System.Drawing.Point(8, 8);
            this.lstDesc.Name = "lstDesc";
            this.lstDesc.Size = new System.Drawing.Size(568, 56);
            this.lstDesc.TabIndex = 14;
            // 
            // lblLoadStatus
            // 
            this.lblLoadStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoadStatus.Location = new System.Drawing.Point(336, 112);
            this.lblLoadStatus.Name = "lblLoadStatus";
            this.lblLoadStatus.Size = new System.Drawing.Size(136, 24);
            this.lblLoadStatus.TabIndex = 44;
            this.lblLoadStatus.Text = "Load Status:";
            // 
            // imageXView1
            // 
            this.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
            this.imageXView1.Location = new System.Drawing.Point(8, 167);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(320, 374);
            this.imageXView1.TabIndex = 45;
            // 
            // ImageLoadingAndSavingForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(584, 553);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.lblLoadStatus);
            this.Controls.Add(this.lstDesc);
            this.Controls.Add(this.lstStatus);
            this.Controls.Add(this.cmbSave);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.lblLastError);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.cmbMethod);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mnuFile;
            this.Name = "ImageLoadingAndSavingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Loading and Saving";
            this.Load += new System.EventHandler(this.frmMain_Load);
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
			Application.Run(new ImageLoadingAndSavingForm());
		}


		private void mnuFileQuit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

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

			loLoadOptions = new Accusoft.ImagXpressSdk.LoadOptions();

			cmbMethod.SelectedIndex = 0;
			cmbSave.SelectedIndex = 0;

			// Set the current directory to the Common\Images directory
			String strCurrentDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");
			if (System.IO.Directory.Exists(strCurrentDir))
				System.IO.Directory.SetCurrentDirectory(strCurrentDir);
			strCurrentDir = System.IO.Directory.GetCurrentDirectory();

			strImageFile = "pic1.bmp";
			if (System.IO.File.Exists(strImageFile))
				cmdLoad_Click(sender, e);

            imagXpress1.ProgressEvent += new Accusoft.ImagXpressSdk.ImagXpress.ProgressEventHandler(imagXpress1_ProgressEvent);
            imagXpress1.ImageStatusEvent+= new Accusoft.ImagXpressSdk.ImagXpress.ImageStatusEventHandler(imagXpress1_ImageStatusEvent);
		}

		private void cmdLoad_Click(object sender, System.EventArgs e)
		{
			System.Drawing.Bitmap bBmp;

			// Dispose the ImageX object if the ImageXView has one
			if (imageXView1.Image != null)
			{
				imageXView1.Image.Dispose();
				imageXView1.Image = null;
			}

			switch (cmbMethod.SelectedIndex)
			{
				case 0:
					try
					{
						imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImageFile, loLoadOptions);

						// clear out the error in case there was an error from a previous operation
						lblError.Text = "";
					}
					catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
					{
						AccusoftError(eX, lblError);
					}
					catch (System.IO.FileLoadException eX)
					{
						AccusoftError(eX, lblError);
					}
					catch (System.Exception eX)
					{
						AccusoftError(eX, lblError);
					}
					break;
				case 1:
					System.IO.FileStream fs = new System.IO.FileStream(strImageFile, System.IO.FileMode.Open, System.IO.FileAccess.Read);
					try
					{
						imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromStream(imagXpress1, fs);

						// clear out the error in case there was an error from a previous operation
						lblError.Text = "";
					}
					catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
					{
						AccusoftError(eX, lblError);
					}
					catch (System.IO.FileLoadException eX)
					{
						AccusoftError(eX, lblError);
					}
					catch (System.Exception eX)
					{
						AccusoftError(eX, lblError);
					}
					break;
				case 2:
					bBmp = new System.Drawing.Bitmap(strImageFile);
					try
					{
						imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromHbitmap(imagXpress1, bBmp.GetHbitmap());

						// clear out the error in case there was an error from a previous operation
						lblError.Text = "";
					}
					catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
					{
						AccusoftError(eX, lblError);
					}
					catch (System.IO.FileLoadException eX)
					{
						AccusoftError(eX, lblError);
					}
					catch (System.Exception eX)
					{
						AccusoftError(eX, lblError);
					}
					break;
				case 3:
					bBmp = new System.Drawing.Bitmap(strImageFile);
					try
					{
						imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromHdib(imagXpress1, bBmp.GetHbitmap());

						// clear out the error in case there was an error from a previous operation
						lblError.Text = "";
					}
					catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
					{
						AccusoftError(eX, lblError);
					}
					catch (System.IO.FileLoadException eX)
					{
						AccusoftError(eX, lblError);
					}
					catch (System.Exception eX)
					{
						AccusoftError(eX, lblError);
					}
					break;
				default: break;
			}
		}

		private void mnuFileOpen_Click(object sender, System.EventArgs e)
		{
			System.String strTmp = AccusoftOpenFile();
			if (strTmp.Length != 0)
			{
				try
				{
					Accusoft.ImagXpressSdk.LoadOptions lo = new Accusoft.ImagXpressSdk.LoadOptions();
					lo.CameraRawEnabled = true;
					lo.LoadMode = Accusoft.ImagXpressSdk.LoadMode.Normal;

					strImageFile = strTmp;
					imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImageFile, lo);

					// clear out the error in case there was an error from a previous operation
					lblError.Text = "";
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
		}

		private void mnuAbout_Click(object sender, System.EventArgs e)
		{
			try
			{
				imagXpress1.AboutBox();
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
			{
				AccusoftError(eX, lblError);
			}
		}

		private void mnuToolbarShow_Click(object sender, System.EventArgs e)
		{
			this.mnuToolbarShow.Text = (imageXView1.Toolbar.Activated) ? "&Show" : "&Hide";
			try
			{
				imageXView1.Toolbar.Activated = !imageXView1.Toolbar.Activated;
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
			{
				AccusoftError(eX, lblError);
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
				iTmp = Convert.ToInt32(textTextBox.Text, cultNumber);
			}
			catch (System.NullReferenceException ex)
			{
				AccusoftError(ex, lblError);
				textTextBox.Text = scrScroll.Value.ToString(cultNumber);
				return;
			}
			catch (System.Exception ex)
			{
				AccusoftError(ex, lblError);
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

		private void cmbMethod_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		}

		private void cmdSave_Click(object sender, System.EventArgs e)
		{
			Accusoft.ImagXpressSdk.SaveOptions so = new Accusoft.ImagXpressSdk.SaveOptions();
			string saveDirectory = Application.StartupPath;

			switch (cmbSave.SelectedIndex)
			{
				//BMP
				case 0:
					try
					{
						so.Format = Accusoft.ImagXpressSdk.ImageXFormat.Bmp;
						imageXView1.Image.Save(saveDirectory + @"\temp.bmp", so);
					}
					catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
					{
						AccusoftError(eX, lblError);
					}
					catch (System.IO.FileLoadException eX)
					{
						AccusoftError(eX, lblError);
					}
					catch (System.Exception eX)
					{
						AccusoftError(eX, lblError);
					}
					break;
				//JPG
				case 1:

					try
					{
						so.Format = Accusoft.ImagXpressSdk.ImageXFormat.Jpeg;
						so.Jpeg.Luminance = 13;
						so.Jpeg.Chrominance = 13;
						so.Jpeg.SubSampling = Accusoft.ImagXpressSdk.SubSampling.SubSampling111;
						imageXView1.Image.Save(saveDirectory + @"\temp.jpg", so);
					}
					catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
					{
						AccusoftError(eX, lblError);
					}
					catch (System.IO.FileLoadException eX)
					{
						AccusoftError(eX, lblError);
					}
					catch (System.Exception eX)
					{
						AccusoftError(eX, lblError);
					}
					break;
				//TIFF
				case 2:

					try
					{
						so.Format = Accusoft.ImagXpressSdk.ImageXFormat.Tiff;
						so.Tiff.Compression = Accusoft.ImagXpressSdk.Compression.Group4;
						imageXView1.Image.Save(saveDirectory + @"\temp.tiff", so);
					}
					catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
					{
						AccusoftError(eX, lblError);
					}
					catch (System.IO.FileLoadException eX)
					{
						AccusoftError(eX, lblError);
					}
					catch (System.Exception eX)
					{
						AccusoftError(eX, lblError);
					}
					break;


				default: break;
			}
		}

		private void imagXpress1_ImageStatusEvent(object sender, Accusoft.ImagXpressSdk.ImageStatusEventArgs e)
		{
			lstStatus.Items.Add(e.Status.ToString());
			lstStatus.SelectedIndex = lstStatus.Items.Count - 1;
		}

		private void imagXpress1_ProgressEvent(object sender, Accusoft.ImagXpressSdk.ProgressEventArgs e)
		{
			lstStatus.Items.Add(e.PercentDone.ToString(cultNumber) + "% Loading Complete.");
			if (e.IsComplete)
			{
				lstStatus.Items.Add(e.TotalBytes + " Bytes Completed Loading.");
			}
			lstStatus.SelectedIndex = lstStatus.Items.Count - 1;
		}
	}
}
