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

namespace BufferingSample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
    {
        private IContainer components;
		private System.Windows.Forms.ComboBox cboImageList;
		private System.Windows.Forms.Button cmdRotate;
		private System.Windows.Forms.Button cmdColorDepth;
		private System.Windows.Forms.Button cmdEmboss;
		private System.Windows.Forms.Button cmdReloadImage;
		private System.Windows.Forms.Label lblBufferSel;
		private System.Windows.Forms.Label lblViewBuf2;
		private System.Windows.Forms.Label lblViewBuf1;
		private System.Windows.Forms.Label lblViewBuf3;
		private System.Windows.Forms.Label lblViewBuf4;
		private System.Windows.Forms.ListBox lstStatus;
		private System.Windows.Forms.Label lblStatus;
		private System.String strImagePath = "";
		private System.String[] strImagePaths;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.RichTextBox lblInfo;
		private System.Windows.Forms.Label lblLastError;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.MenuItem mnuToolbar;
		private System.Windows.Forms.MenuItem mnuAbout;
        private System.Windows.Forms.MenuItem mnuToolbarShow;
        private ImagXpress imagXpress1;
        private ImageXView imageXView1;
        private ImageXView imageXView2;
        private ImageXView imageXView3;
        private ImageXView imageXView4;
        private ImageXView imageXViewMain;
		private Accusoft.ImagXpressSdk.LoadOptions opts;

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
            this.cboImageList = new System.Windows.Forms.ComboBox();
            this.cmdRotate = new System.Windows.Forms.Button();
            this.cmdColorDepth = new System.Windows.Forms.Button();
            this.cmdEmboss = new System.Windows.Forms.Button();
            this.cmdReloadImage = new System.Windows.Forms.Button();
            this.lblBufferSel = new System.Windows.Forms.Label();
            this.lblViewBuf2 = new System.Windows.Forms.Label();
            this.lblViewBuf1 = new System.Windows.Forms.Label();
            this.lblViewBuf3 = new System.Windows.Forms.Label();
            this.lblViewBuf4 = new System.Windows.Forms.Label();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnuToolbar = new System.Windows.Forms.MenuItem();
            this.mnuToolbarShow = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.lblInfo = new System.Windows.Forms.RichTextBox();
            this.lblLastError = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.imageXView2 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.imageXView3 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.imageXView4 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.imageXViewMain = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.SuspendLayout();
            // 
            // cboImageList
            // 
            this.cboImageList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImageList.Location = new System.Drawing.Point(16, 192);
            this.cboImageList.MaxDropDownItems = 12;
            this.cboImageList.Name = "cboImageList";
            this.cboImageList.Size = new System.Drawing.Size(144, 21);
            this.cboImageList.TabIndex = 0;
            this.cboImageList.SelectedIndexChanged += new System.EventHandler(this.cboImageList_SelectedIndexChanged);
            // 
            // cmdRotate
            // 
            this.cmdRotate.Location = new System.Drawing.Point(16, 224);
            this.cmdRotate.Name = "cmdRotate";
            this.cmdRotate.Size = new System.Drawing.Size(144, 24);
            this.cmdRotate.TabIndex = 6;
            this.cmdRotate.Text = "Rotate 90";
            this.cmdRotate.Click += new System.EventHandler(this.cmdRotate_Click);
            // 
            // cmdColorDepth
            // 
            this.cmdColorDepth.Location = new System.Drawing.Point(16, 256);
            this.cmdColorDepth.Name = "cmdColorDepth";
            this.cmdColorDepth.Size = new System.Drawing.Size(144, 24);
            this.cmdColorDepth.TabIndex = 7;
            this.cmdColorDepth.Text = "Make 1-bit";
            this.cmdColorDepth.Click += new System.EventHandler(this.cmdColorDepth_Click);
            // 
            // cmdEmboss
            // 
            this.cmdEmboss.Location = new System.Drawing.Point(16, 288);
            this.cmdEmboss.Name = "cmdEmboss";
            this.cmdEmboss.Size = new System.Drawing.Size(144, 24);
            this.cmdEmboss.TabIndex = 8;
            this.cmdEmboss.Text = "Emboss";
            this.cmdEmboss.Click += new System.EventHandler(this.cmdEmboss_Click);
            // 
            // cmdReloadImage
            // 
            this.cmdReloadImage.Location = new System.Drawing.Point(16, 120);
            this.cmdReloadImage.Name = "cmdReloadImage";
            this.cmdReloadImage.Size = new System.Drawing.Size(144, 32);
            this.cmdReloadImage.TabIndex = 9;
            this.cmdReloadImage.Text = "Reload Current Image";
            this.cmdReloadImage.Click += new System.EventHandler(this.cmdReloadImage_Click);
            // 
            // lblBufferSel
            // 
            this.lblBufferSel.Location = new System.Drawing.Point(16, 160);
            this.lblBufferSel.Name = "lblBufferSel";
            this.lblBufferSel.Size = new System.Drawing.Size(144, 24);
            this.lblBufferSel.TabIndex = 11;
            this.lblBufferSel.Text = "Select image buffer to view/process:";
            this.lblBufferSel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblViewBuf2
            // 
            this.lblViewBuf2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblViewBuf2.Location = new System.Drawing.Point(168, 475);
            this.lblViewBuf2.Name = "lblViewBuf2";
            this.lblViewBuf2.Size = new System.Drawing.Size(120, 16);
            this.lblViewBuf2.TabIndex = 12;
            this.lblViewBuf2.Text = "View Buffer 2";
            this.lblViewBuf2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblViewBuf1
            // 
            this.lblViewBuf1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblViewBuf1.Location = new System.Drawing.Point(16, 475);
            this.lblViewBuf1.Name = "lblViewBuf1";
            this.lblViewBuf1.Size = new System.Drawing.Size(120, 16);
            this.lblViewBuf1.TabIndex = 13;
            this.lblViewBuf1.Text = "View Buffer 1";
            this.lblViewBuf1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblViewBuf3
            // 
            this.lblViewBuf3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblViewBuf3.Location = new System.Drawing.Point(320, 475);
            this.lblViewBuf3.Name = "lblViewBuf3";
            this.lblViewBuf3.Size = new System.Drawing.Size(120, 16);
            this.lblViewBuf3.TabIndex = 14;
            this.lblViewBuf3.Text = "View Buffer 3";
            this.lblViewBuf3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblViewBuf4
            // 
            this.lblViewBuf4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblViewBuf4.Location = new System.Drawing.Point(464, 475);
            this.lblViewBuf4.Name = "lblViewBuf4";
            this.lblViewBuf4.Size = new System.Drawing.Size(120, 16);
            this.lblViewBuf4.TabIndex = 15;
            this.lblViewBuf4.Text = "View Buffer 4";
            this.lblViewBuf4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lstStatus
            // 
            this.lstStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStatus.Location = new System.Drawing.Point(16, 379);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(576, 82);
            this.lstStatus.TabIndex = 16;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Location = new System.Drawing.Point(24, 363);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(568, 16);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Image Process Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.mnuToolbar,
            this.mnuAbout});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem4});
            this.menuItem1.Text = "&File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "&Open";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "-";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "&Quit";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
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
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(16, 8);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.ReadOnly = true;
            this.lblInfo.Size = new System.Drawing.Size(576, 104);
            this.lblInfo.TabIndex = 18;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // lblLastError
            // 
            this.lblLastError.Location = new System.Drawing.Point(16, 312);
            this.lblLastError.Name = "lblLastError";
            this.lblLastError.Size = new System.Drawing.Size(100, 16);
            this.lblLastError.TabIndex = 19;
            this.lblLastError.Text = "Last Error:";
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblError.Location = new System.Drawing.Point(16, 328);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(144, 35);
            this.lblError.TabIndex = 20;
            // 
            // imageXView1
            // 
            this.imageXView1.Location = new System.Drawing.Point(19, 515);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(141, 100);
            this.imageXView1.TabIndex = 21;
            // 
            // imageXView2
            // 
            this.imageXView2.Location = new System.Drawing.Point(166, 515);
            this.imageXView2.Name = "imageXView2";
            this.imageXView2.Size = new System.Drawing.Size(141, 100);
            this.imageXView2.TabIndex = 22;
            // 
            // imageXView3
            // 
            this.imageXView3.Location = new System.Drawing.Point(313, 515);
            this.imageXView3.Name = "imageXView3";
            this.imageXView3.Size = new System.Drawing.Size(141, 100);
            this.imageXView3.TabIndex = 23;
            // 
            // imageXView4
            // 
            this.imageXView4.Location = new System.Drawing.Point(460, 515);
            this.imageXView4.Name = "imageXView4";
            this.imageXView4.Size = new System.Drawing.Size(141, 100);
            this.imageXView4.TabIndex = 24;
            // 
            // imageXViewMain
            // 
            this.imageXViewMain.Location = new System.Drawing.Point(171, 120);
            this.imageXViewMain.Name = "imageXViewMain";
            this.imageXViewMain.Size = new System.Drawing.Size(425, 261);
            this.imageXViewMain.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(608, 625);
            this.Controls.Add(this.imageXViewMain);
            this.Controls.Add(this.imageXView4);
            this.Controls.Add(this.imageXView3);
            this.Controls.Add(this.imageXView2);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblLastError);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstStatus);
            this.Controls.Add(this.lblViewBuf4);
            this.Controls.Add(this.lblViewBuf3);
            this.Controls.Add(this.lblViewBuf1);
            this.Controls.Add(this.lblViewBuf2);
            this.Controls.Add(this.lblBufferSel);
            this.Controls.Add(this.cmdReloadImage);
            this.Controls.Add(this.cmdEmboss);
            this.Controls.Add(this.cmdColorDepth);
            this.Controls.Add(this.cmdRotate);
            this.Controls.Add(this.cboImageList);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buffer / Stream Sample";
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
			Application.Run(new MainForm());
		}

		static private string StatusStr(ImageStatus Status)
		{
			//Takes the status flags and returns a list of
			//the enabled ones as a string.
			System.String Txt = "";
			if (Status == ImageStatus.Empty) Txt = "Empty";
			if ((Status & ImageStatus.Opened) > 0) Txt = Txt + "Opened ";
			if ((Status & ImageStatus.Defined) > 0) Txt = Txt + "Defined ";
			if ((Status & ImageStatus.Decoding) > 0) Txt = Txt + "Decoding ";
			if ((Status & ImageStatus.Decoded) > 0) Txt = Txt + "Decoded ";
			if ((Status & ImageStatus.Canceled) > 0) Txt = Txt + "Canceled ";
			if ((Status & ImageStatus.Error) > 0) Txt = Txt + "Error ";
			if ((Status & ImageStatus.ImageProcessed) > 0) Txt = Txt + "ImageProcessed ";
			if ((Status & ImageStatus.ImageProcessing) > 0) Txt = Txt + "ImageProcessing ";
			if ((Status & ImageStatus.Wait) > 0) Txt = Txt + "Wait ";
			return Txt.Trim();
		}

		private void FormMain_Load(object sender, System.EventArgs e)
		{

			//***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
			//imagXpress1.Licensing.SetSolutionName("YourSolutionName");
			//imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345);
			//imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�");

			try
			{
                // Because in this sample the ImageX object is always located in the ImageXView
                // tell the ImageXView component to dispose of the ImageX object when itself is
                // disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
                // Dispose method before the components.Dispose() section.
                imageXView1.AutoImageDispose = true;
                imageXView2.AutoImageDispose = true;
                imageXView3.AutoImageDispose = true;
                imageXView4.AutoImageDispose = true;
                imageXViewMain.AutoImageDispose = true;

				opts = new Accusoft.ImagXpressSdk.LoadOptions();

                String strCurrentDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");
                if (System.IO.Directory.Exists(strCurrentDir))
                    System.IO.Directory.SetCurrentDirectory(strCurrentDir);
                strCurrentDir = System.IO.Directory.GetCurrentDirectory();

                strImagePaths = new System.String[4];
			
				strImagePath = System.IO.Path.Combine (strCurrentDir, "window.jpg");
				cboImageList.Items.Add(parseFNam(strImagePath));
				imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImagePath, opts);
				imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
				strImagePaths[0] = strImagePath;

				strImagePath = System.IO.Path.Combine (strCurrentDir, "door.jpg");
				cboImageList.Items.Add(parseFNam(strImagePath));
				imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImagePath, opts);
				imageXView2.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
				strImagePaths[1] = strImagePath;

				strImagePath = System.IO.Path.Combine (strCurrentDir, "water.jpg");
				cboImageList.Items.Add(parseFNam(strImagePath));
				imageXView3.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImagePath, opts);
				imageXView3.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
				strImagePaths[2] = strImagePath;

				strImagePath = System.IO.Path.Combine (strCurrentDir, "boat.jpg");
				cboImageList.Items.Add(parseFNam(strImagePath));			
				imageXView4.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImagePath, opts);
				imageXView4.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
				strImagePaths[3] = strImagePath;

				imageXViewMain.Image = imageXView1.Image;
				imageXViewMain.AutoResize = AutoResizeType.BestFit;

				cboImageList.SelectedIndex = 0;
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
			{
				AccusoftError(ex,lblError);
			}
		}

		static private string parseFNam(string fNam)
		{
			//Function to return the image filename to use in the cboImageList Combo
			System.Int32 index = fNam.LastIndexOf(@"\");
			return fNam.Remove(0, index+1);
		}

		private void cboImageList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Accusoft.ImagXpressSdk.ImageXView tmp;
			switch (cboImageList.SelectedIndex)
			{
				case 0: 
                    tmp = this.imageXView1;
                    break;
				case 1: 
				    tmp = this.imageXView2;
                    break;
				case 2: 
				    tmp = this.imageXView3;
                    break;
				case 3: 
				    tmp = this.imageXView4;
                    break;
				default:
                    tmp = this.imageXView1;
                    break;
			}	
			try 
			{
				imageXViewMain.Image = tmp.Image;
			} 
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex) 
			{
				AccusoftError(ex,lblError);
			}
			this.Refresh();
		}

		private void cmdReloadImage_Click(object sender, System.EventArgs e)
		{
			Accusoft.ImagXpressSdk.ImageXView tmp;
			switch (cboImageList.SelectedIndex)
			{
                case 0:
                    tmp = this.imageXView1;
                    break;
                case 1:
                    tmp = this.imageXView2;
                    break;
                case 2:
                    tmp = this.imageXView3;
                    break;
                case 3:
                    tmp = this.imageXView4;
                    break;
                default:
                    tmp = this.imageXView1;
                    break;
			}	

			try
			{
                if (tmp.Image != null)
                    tmp.Image.Dispose();
				tmp.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImagePaths[cboImageList.SelectedIndex], opts);
				// clear out the error in case there was an error from a previous operation
				lblError.Text = "";
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
			{
				AccusoftError(ex,lblError);
			}
			try
			{
				imageXViewMain.Image = tmp.Image;

				// clear out the error in case there was an error from a previous operation
				lblError.Text = "";
			} 
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex) 
			{
				AccusoftError(ex,lblError);
			}
			this.Refresh();
		}

		private void cmdRotate_Click(object sender, System.EventArgs e)
		{
			// Perform image processing to demonstrate that two ImagXpress controls
			// are viewing the same image buffer
			try
			{
				Accusoft.ImagXpressSdk.Processor process;
				process = new Accusoft.ImagXpressSdk.Processor(imagXpress1, imageXViewMain.Image);
				process.Rotate(90);

				// clear out the error in case there was an error from a previous operation
				lblError.Text = "";
			} 
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
			{
				AccusoftError(ex,lblError);
			}
			catch (System.NullReferenceException ex)
			{
				AccusoftError(ex,lblError);
			}
			this.Refresh();
		}

		private void cmdColorDepth_Click(object sender, System.EventArgs e)
		{
			// Perform image processing to demonstrate that two ImagXpress controls
			// are viewing the same image buffer
			try
			{
				Accusoft.ImagXpressSdk.Processor process;
				process = new Accusoft.ImagXpressSdk.Processor(imagXpress1, imageXViewMain.Image);
				process.ColorDepth(1,PaletteType.Optimized,DitherType.Floyd);

				// clear out the error in case there was an error from a previous operation
				lblError.Text = "";
			} 
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
			{
				AccusoftError(ex,lblError);
			}
			catch (System.NullReferenceException ex)
			{
				AccusoftError(ex,lblError);
			}
			this.Refresh();
		}

		private void cmdEmboss_Click(object sender, System.EventArgs e)
		{
			// Perform image processing to demonstrate that two ImagXpress controls
			// are viewing the same image buffer
			try
			{
				Accusoft.ImagXpressSdk.Processor process;
				process = new Accusoft.ImagXpressSdk.Processor(imagXpress1, imageXViewMain.Image);
				process.Emboss();

				// clear out the error in case there was an error from a previous operation
				lblError.Text = "";
			} 
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
			{
				AccusoftError(ex,lblError);
			}
			catch (System.NullReferenceException ex)
			{
				AccusoftError(ex,lblError);
			}
			this.Refresh();
		}

        private void imagXpress1_ImageStatusEvent(object sender, ImageStatusEventArgs e)
        {
            lstStatus.Items.Add(e.Status.ToString());
        }

        private void imagXpress1_ProgressEvent(object sender, ProgressEventArgs e)
        {
            lstStatus.Items.Add(e.PercentDone.ToString(cultNumber) + "% Loading Complete.");
            if (e.IsComplete)
            {
                lstStatus.Items.Add(e.TotalBytes + " Bytes Completed Loading.");
            }
            lstStatus.SelectedIndex = lstStatus.Items.Count - 1;
        }

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void imageXView4_Click(object sender, System.EventArgs e)
		{
			try
			{
				imageXViewMain.Image = imageXView4.Image;

				// clear out the error in case there was an error from a previous operation
				lblError.Text = "";
			} 
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex) 
			{
				AccusoftError(ex,lblError);
			}
			cboImageList.SelectedIndex = 3;
		}

		private void imageXView3_Click(object sender, System.EventArgs e)
		{
			try
			{
				imageXViewMain.Image = imageXView3.Image;

				// clear out the error in case there was an error from a previous operation
				lblError.Text = "";
			} 
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex) 
			{
				AccusoftError(ex,lblError);
			}
			cboImageList.SelectedIndex = 2;
		}

		private void imageXView2_Click(object sender, System.EventArgs e)
		{
			try
			{
				imageXViewMain.Image = imageXView2.Image;
		
				// clear out the error in case there was an error from a previous operation
				lblError.Text = "";
			} 
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex) 
			{
				AccusoftError(ex,lblError);
			}
			cboImageList.SelectedIndex = 1;
		}

		private void imageXView1_Click(object sender, System.EventArgs e)
		{
			try
			{
				imageXViewMain.Image = imageXView1.Image;
	
				// clear out the error in case there was an error from a previous operation
				lblError.Text = "";
			} 
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex) 
			{
				AccusoftError(ex,lblError);
			}
			cboImageList.SelectedIndex = 0;
		}

		private void cmdLoadImage_Click(object sender, System.EventArgs e)
		{
			System.String filename = AccusoftOpenFile();
			if (filename.Length != 0) 
			{
				cboImageList.Items[cboImageList.SelectedIndex] = parseFNam(filename);
				try 
				{
					Accusoft.ImagXpressSdk.ImageXView tmp = new Accusoft.ImagXpressSdk.ImageXView(imagXpress1); 
					switch (cboImageList.SelectedIndex)
					{
                        case 0:
                            tmp = this.imageXView1;
                            break;
                        case 1:
                            tmp = this.imageXView2;
                            break;
                        case 2:
                            tmp = this.imageXView3;
                            break;
                        case 3:
                            tmp = this.imageXView4;
                            break;
						default:
                            break;
					}
					tmp.Image = StreamInFile(filename, opts, imagXpress1);
					imageXViewMain.Image = tmp.Image;

					// clear out the error in case there was an error from a previous operation
					lblError.Text = "";
				}
				catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
				{
					AccusoftError(ex,lblError);
				}
				this.Refresh();			
			}
		}

		static private Accusoft.ImagXpressSdk.ImageX StreamInFile(System.String sFilename, Accusoft.ImagXpressSdk.LoadOptions oOpts, ImagXpress imagXpress1)
		{
			System.Int32 iFileLength;

			System.IO.FileStream fsReader = new System.IO.FileStream(sFilename,System.IO.FileMode.Open);
			iFileLength = Convert.ToInt32(fsReader.Length);
			if (iFileLength < 0) 
			{
				iFileLength = 0;
                fsReader.Close();
				return null;
			} 
			else 
			{
                Accusoft.ImagXpressSdk.ImageX returnImageX = Accusoft.ImagXpressSdk.ImageX.FromStream(imagXpress1, fsReader, oOpts);
                fsReader.Close();
                return returnImageX;
			}
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			string filename = AccusoftOpenFile();

			if (filename.Length != 0) 
			{
				cboImageList.Items[cboImageList.SelectedIndex] = parseFNam(filename);
                strImagePaths[cboImageList.SelectedIndex] = filename;
		
				try 
				{
					Accusoft.ImagXpressSdk.ImageXView tmp = new Accusoft.ImagXpressSdk.ImageXView(imagXpress1); 
					switch (cboImageList.SelectedIndex)
					{
                        case 0:
                            tmp = this.imageXView1;
                            break;
                        case 1:
                            tmp = this.imageXView2;
                            break;
                        case 2:
                            tmp = this.imageXView3;
                            break;
                        case 3:
                            tmp = this.imageXView4;
                            break;
						default:
                            break;
					}
					tmp.Image = StreamInFile(filename, opts, imagXpress1);
					imageXViewMain.Image = tmp.Image;

					// clear out the error in case there was an error from a previous operation
					lblError.Text = "";
				}
                catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
				{
					AccusoftError(ex,lblError);
				}
				this.Refresh();			
			}
		}

		
		private void mnuToolbarShow_Click(object sender, System.EventArgs e)
		{
			this.mnuToolbarShow.Text = (imageXViewMain.Toolbar.Activated) ? "&Show":"&Hide";
			try 
			{
				imageXViewMain.Toolbar.Activated = !imageXViewMain.Toolbar.Activated;
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException eX) 
			{
				AccusoftError(eX,lblError);
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
				AccusoftError(eX,lblError);
			}
		}

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

	}
}

