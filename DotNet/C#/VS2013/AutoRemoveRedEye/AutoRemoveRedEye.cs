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

namespace AutoRemoveRedEye
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class AutoRemoveRedEyeForm : System.Windows.Forms.Form
	{
        private LoadOptions loLoadOptions;
		private Processor prc;
		private ImageX imagX1;
		private System.Windows.Forms.Button cmdRemove;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		
		//Declare global variables
		
		
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblerror;
		private System.Windows.Forms.MenuItem mnuOpen;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem mnuQuit;
		private System.Windows.Forms.MenuItem mnuToolBar;
		private System.Windows.Forms.MenuItem mnuShow;
		private System.Windows.Forms.MenuItem mnuAbout;
		private System.Windows.Forms.ListBox liststatus;
		private System.Windows.Forms.Label lsterror;

		private  System.String 	strImageFile; 
		
	
		//redeye information
		System.Int32 redeyex;
		System.Int32 redeyey;
		System.Int32 redeyewidth;
		System.Int32 redeyeheight;
		private System.Windows.Forms.ComboBox cmbGlare;
		private System.Windows.Forms.ComboBox cmbShade;
		private System.Windows.Forms.Label lblGlare;
		private System.Windows.Forms.Label lblShade;
		private System.Windows.Forms.ListBox lstDesc;
		private System.Windows.Forms.GroupBox grpRedResult;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.ColumnHeader RedEyeIndex;
		private System.Windows.Forms.ColumnHeader XPos;
		private System.Windows.Forms.ColumnHeader YPos;
	
		private System.Windows.Forms.ListView resultsList;
		private System.Windows.Forms.Label lblRedDesc;
		private System.Windows.Forms.ColumnHeader AreaWidth;
        private System.Windows.Forms.ColumnHeader AreaHeight;
        private MenuItem menuItemAbout;
        private ImagXpress imagXpress1;
        private ImageXView imageXView1;
        private IContainer components;

		public AutoRemoveRedEyeForm()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoRemoveRedEyeForm));
            this.liststatus = new System.Windows.Forms.ListBox();
            this.lstDesc = new System.Windows.Forms.ListBox();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuOpen = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuQuit = new System.Windows.Forms.MenuItem();
            this.mnuToolBar = new System.Windows.Forms.MenuItem();
            this.mnuShow = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.lsterror = new System.Windows.Forms.Label();
            this.cmbGlare = new System.Windows.Forms.ComboBox();
            this.cmbShade = new System.Windows.Forms.ComboBox();
            this.lblGlare = new System.Windows.Forms.Label();
            this.lblShade = new System.Windows.Forms.Label();
            this.grpRedResult = new System.Windows.Forms.GroupBox();
            this.lblRedDesc = new System.Windows.Forms.Label();
            this.resultsList = new System.Windows.Forms.ListView();
            this.RedEyeIndex = new System.Windows.Forms.ColumnHeader();
            this.YPos = new System.Windows.Forms.ColumnHeader();
            this.XPos = new System.Windows.Forms.ColumnHeader();
            this.AreaWidth = new System.Windows.Forms.ColumnHeader();
            this.AreaHeight = new System.Windows.Forms.ColumnHeader();
            this.lblCount = new System.Windows.Forms.Label();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.grpRedResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // liststatus
            // 
            this.liststatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.liststatus.Location = new System.Drawing.Point(584, 96);
            this.liststatus.Name = "liststatus";
            this.liststatus.Size = new System.Drawing.Size(168, 134);
            this.liststatus.TabIndex = 1;
            // 
            // lstDesc
            // 
            this.lstDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDesc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDesc.Items.AddRange(new object[] {
            "This sample demonstrates using the AutoRemoveRedEye method in the ImagXpress cont" +
                "rol. The sample",
            "demonstrates using the RedeyeCollection Class to retrieve information about the r" +
                "ed eyes found in the image."});
            this.lstDesc.Location = new System.Drawing.Point(24, 8);
            this.lstDesc.Name = "lstDesc";
            this.lstDesc.Size = new System.Drawing.Size(728, 56);
            this.lstDesc.TabIndex = 2;
            // 
            // cmdRemove
            // 
            this.cmdRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRemove.Location = new System.Drawing.Point(376, 203);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(136, 32);
            this.cmdRemove.TabIndex = 3;
            this.cmdRemove.Text = "AutoRemoveRedEye";
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.mnuToolBar,
            this.mnuAbout});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuOpen,
            this.menuItem2,
            this.mnuQuit});
            this.menuItem1.Text = "&File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Index = 0;
            this.mnuOpen.Text = "&Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // mnuQuit
            // 
            this.mnuQuit.Index = 2;
            this.mnuQuit.Text = "&Quit";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // mnuToolBar
            // 
            this.mnuToolBar.Index = 1;
            this.mnuToolBar.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuShow});
            this.mnuToolBar.Text = "&Toolbar";
            // 
            // mnuShow
            // 
            this.mnuShow.Index = 0;
            this.mnuShow.Text = "&Show";
            this.mnuShow.Click += new System.EventHandler(this.mnuShow_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 2;
            this.mnuAbout.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemAbout});
            this.mnuAbout.Text = "&About";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 0;
            this.menuItemAbout.Text = "Imag&Xpress";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Location = new System.Drawing.Point(584, 72);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(168, 16);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Load Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblerror
            // 
            this.lblerror.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblerror.Location = new System.Drawing.Point(320, 96);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(248, 35);
            this.lblerror.TabIndex = 5;
            // 
            // lsterror
            // 
            this.lsterror.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lsterror.Location = new System.Drawing.Point(320, 72);
            this.lsterror.Name = "lsterror";
            this.lsterror.Size = new System.Drawing.Size(112, 16);
            this.lsterror.TabIndex = 6;
            this.lsterror.Text = "Last Error Reported:";
            // 
            // cmbGlare
            // 
            this.cmbGlare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGlare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGlare.Items.AddRange(new object[] {
            "None",
            "Slight",
            "Full"});
            this.cmbGlare.Location = new System.Drawing.Point(320, 171);
            this.cmbGlare.Name = "cmbGlare";
            this.cmbGlare.Size = new System.Drawing.Size(112, 21);
            this.cmbGlare.TabIndex = 7;
            // 
            // cmbShade
            // 
            this.cmbShade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbShade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShade.Items.AddRange(new object[] {
            "Normal",
            "Light",
            "Dark"});
            this.cmbShade.Location = new System.Drawing.Point(456, 171);
            this.cmbShade.Name = "cmbShade";
            this.cmbShade.Size = new System.Drawing.Size(112, 21);
            this.cmbShade.TabIndex = 8;
            // 
            // lblGlare
            // 
            this.lblGlare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGlare.Location = new System.Drawing.Point(320, 147);
            this.lblGlare.Name = "lblGlare";
            this.lblGlare.Size = new System.Drawing.Size(112, 16);
            this.lblGlare.TabIndex = 9;
            this.lblGlare.Text = "Glare Settings";
            this.lblGlare.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblShade
            // 
            this.lblShade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShade.Location = new System.Drawing.Point(456, 147);
            this.lblShade.Name = "lblShade";
            this.lblShade.Size = new System.Drawing.Size(112, 16);
            this.lblShade.TabIndex = 10;
            this.lblShade.Text = "Eye Shade";
            this.lblShade.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // grpRedResult
            // 
            this.grpRedResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRedResult.Controls.Add(this.lblRedDesc);
            this.grpRedResult.Controls.Add(this.resultsList);
            this.grpRedResult.Controls.Add(this.lblCount);
            this.grpRedResult.Location = new System.Drawing.Point(312, 243);
            this.grpRedResult.Name = "grpRedResult";
            this.grpRedResult.Size = new System.Drawing.Size(440, 200);
            this.grpRedResult.TabIndex = 11;
            this.grpRedResult.TabStop = false;
            this.grpRedResult.Text = "RedEye Results";
            // 
            // lblRedDesc
            // 
            this.lblRedDesc.Location = new System.Drawing.Point(24, 32);
            this.lblRedDesc.Name = "lblRedDesc";
            this.lblRedDesc.Size = new System.Drawing.Size(160, 16);
            this.lblRedDesc.TabIndex = 2;
            this.lblRedDesc.Text = "Number of Red Eyes Found:";
            // 
            // resultsList
            // 
            this.resultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RedEyeIndex,
            this.YPos,
            this.XPos,
            this.AreaWidth,
            this.AreaHeight});
            this.resultsList.Location = new System.Drawing.Point(16, 56);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(408, 128);
            this.resultsList.TabIndex = 1;
            this.resultsList.UseCompatibleStateImageBehavior = false;
            this.resultsList.View = System.Windows.Forms.View.Details;
            // 
            // RedEyeIndex
            // 
            this.RedEyeIndex.Text = "RedEyeIndex";
            this.RedEyeIndex.Width = 85;
            // 
            // YPos
            // 
            this.YPos.Text = "YPos";
            // 
            // XPos
            // 
            this.XPos.Text = "XPos";
            // 
            // AreaWidth
            // 
            this.AreaWidth.Text = "AreaWidth";
            this.AreaWidth.Width = 100;
            // 
            // AreaHeight
            // 
            this.AreaHeight.Text = "AreaHeight";
            this.AreaHeight.Width = 100;
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(192, 32);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(152, 16);
            this.lblCount.TabIndex = 0;
            // 
            // imageXView1
            // 
            this.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
            this.imageXView1.Location = new System.Drawing.Point(24, 72);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(267, 376);
            this.imageXView1.TabIndex = 12;
            // 
            // AutoRemoveRedEyeForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(768, 460);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.grpRedResult);
            this.Controls.Add(this.lblShade);
            this.Controls.Add(this.lblGlare);
            this.Controls.Add(this.cmbShade);
            this.Controls.Add(this.cmbGlare);
            this.Controls.Add(this.lsterror);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.lstDesc);
            this.Controls.Add(this.liststatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "AutoRemoveRedEyeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Remove RedEye";
            this.Load += new System.EventHandler(this.AutoRemoveRedEye_Load);
            this.grpRedResult.ResumeLayout(false);
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
			Application.Run(new AutoRemoveRedEyeForm());
		}

		private void cmdRemove_Click(object sender, System.EventArgs e)
		{
			
			resultsList.Items.Clear();
			lblCount.Text = "";

				//Glare type
				RedeyeGlare gglare = ((RedeyeGlare )cmbGlare.SelectedIndex);
		
				//Shade type
				RedeyeShade sshade = ((RedeyeShade )cmbShade.SelectedIndex);
				//Create a processor object here
				prc = new Processor(imagXpress1, imageXView1.Image);
				//redeye collection/ to be added
				RedeyeCollection myRedEyes = new RedeyeCollection();
				prc.Redeyes = myRedEyes;

				//Remove the RedEyes from the image
				prc.AutoRemoveRedeye(sshade,gglare,false);
				//report the count of red eyes found in the image
				lblCount.Text = myRedEyes.Count.ToString();
			

			//get the rectangles thought to be redeyes and report information about them
			for(int counter = 0;counter < myRedEyes.Count; counter ++)
			{
				
				redeyex = myRedEyes.GetRedeyeRectangle(counter).Xposition;
				redeyey = myRedEyes.GetRedeyeRectangle(counter).Yposition;
				redeyewidth = myRedEyes.GetRedeyeRectangle(counter).Width;
				redeyeheight = myRedEyes.GetRedeyeRectangle(counter).Height;
			
				resultsList.Items.Add(

						new ListViewItem(
					new String[]{counter.ToString(),redeyex.ToString(),redeyey.ToString(),redeyewidth.ToString(),redeyeheight.ToString()}
				)

				);
			}
			prc.Dispose();
			prc = null;
		}

		
		#region Accusoft Sample Application Standard Functions
		/*********************************************************************
		 *     Accusoft Corporation Standard Function Definitions     *
		 *********************************************************************/

		private System.Globalization.NumberFormatInfo cultNumber = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
		private System.Globalization.TextInfo cultText = System.Globalization.CultureInfo.CurrentCulture.TextInfo;
		private System.Globalization.CompareInfo cultCompare = System.Globalization.CultureInfo.CurrentCulture.CompareInfo;
		private const System.String strDefaultImageFilter = "All ImagXpress Supported File Types|*.bmp;*.cal;*.dib;*.dca;*.mod;*.dcx;*.gif;*.jp2;*.jls;*.jpg;*.jif;*.ljp;*.pbm;*.pcx;*.pgm;*.pic;*.png;*.ppm;*.tiff;*.tif;*.tga;*.wsq;*.jb2;*.gif;*.jpeg;*.cals;*.jbig2;*.ico;*.rle;*.lzw;*.wbmp;*.dwg;*.dxf;*.dwf;*.hdp;*.wdp|Windows Bitmap (*.BMP)|*.bmp|CALS (*.CAL)|*.cal|Windows Device Independent Bitmap(*.DIB)|*.dib|MO:DCA (*.DCA & *.MOD)|*.dca;*.mod|Zsoft Multiple Page (*.DCX)|*.dcx|CompuServe GIF (*.GIF)|*.gif|JPEG 2000 (*.JP2)|*.jp2|JPEG LS (*.JLS)|*.jls|JFIF Compliant JPEG (*.JPG & *.JIF)|*.jpg;*.jif|Lossless JPEG (*.LJP)|*.ljp|Portable Bitmap (*.PBM)|*.pbm|Zsoft PaintBrush (*.PCX)|*.pcx|Portable Graymap (*.PGM)|*.pgm|Pegasus PIC or Enhanced PIC (*.PIC)|*.pic|Portable Network Graphics (*.PNG)|*.png|Portable Pixmap (*.PPM)|*.ppm|Tagged Image Format (*.TIFF)|*.tif;*.tiff|Truevision TARGA (*.TGA)|*.tga|WSQ Fingerprint File (*.WSQ)|*.wsq|JBIG2 File (*.JB2)|*.jb2|CAD Drawing (*.DWG)|*.dwg|Autodesk Design Web Format (*.DWF)|*.dwf|AutoCAD DXF (*.DXF)|*.dxf|HD Photo (*.HDP & *.WDP)|*.hdp;*.wdp|All Files (*.*)|*.*";
		private const System.String strCommonImagesDirectory = "..\\..\\..\\..\\..\\..\\..\\..\\..\\Common\\Images\\";

		static void AccusoftError(System.Exception ErrorException, System.Windows.Forms.Label ErrorLabel) 
		{
			ErrorLabel.Text = ErrorException.Message + "\n" + ErrorException.Source + "\n";
		}

		static void AccusoftError(ImagXpressException ErrorException, System.Windows.Forms.Label ErrorLabel) 
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
				AccusoftError(ex,lblerror);
				textTextBox.Text = scrScroll.Value.ToString(cultNumber);
				return;
			}
			catch (System.Exception ex)
			{
				AccusoftError(ex,lblerror);
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

	

		private void AutoRemoveRedEye_Load(object sender, System.EventArgs e)
		{
				
			//***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
			//imagXpress1.Licensing.SetSolutionName("YourSolutionName");
			//imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345);
			//imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�");

			cmbGlare.SelectedIndex = 0;
			cmbShade.SelectedIndex = 0;

            // Because in this sample the ImageX object is always located in the ImageXView
            // tell the ImageXView component to dispose of the ImageX object when itself is
            // disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
            // Dispose method before the components.Dispose() section.
            imageXView1.AutoImageDispose = true;

			try
			{
				//Create a new load options object so we can recieve events from the images we load
				loLoadOptions = new LoadOptions();
			}
			catch (ImagXpressException ex) 
			{
				AccusoftError(ex,lblerror);
			}
			
			try
			{
				imagX1 = new ImageX(imagXpress1);
		
				//here we set the current directory and image so that the file open dialog box works well
                String strCurrentDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");
                if (System.IO.Directory.Exists(strCurrentDir))
                    System.IO.Directory.SetCurrentDirectory(strCurrentDir);
                strCurrentDir = System.IO.Directory.GetCurrentDirectory();
                
                strImageFile = System.IO.Path.Combine (strCurrentDir, "ImagXpress Redeye 2 Sample.jpg");				
                
                imageXView1.Image = ImageX.FromFile(imagXpress1, strImageFile,loLoadOptions);
			}
			catch (ImagXpressException ex)
			{
				AccusoftError(ex,lblerror);

			}
			
		}

		private void mnuOpen_Click(object sender, System.EventArgs e)
		{
			System.String strTmp = AccusoftOpenFile();
			if (strTmp.Length != 0) 
			{
				try
				{
					strImageFile = strTmp;

                    if (imageXView1.Image != null)
                        imageXView1.Image.Dispose();

					imageXView1.Image = ImageX.FromFile(imagXpress1, strImageFile,loLoadOptions);

					// clear out the error in case there was an error from a previous operation
					lblerror.Text = "";
				}
				catch(ImagXpressException ex)
				{
					AccusoftError(ex,lblerror);
				}
				catch(System.IO.IOException ex)
				{
					AccusoftError(ex,lblerror);
				}
				resultsList.Items.Clear();
				
			}		
		}
		
		private void mnuQuit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();

		}

		private void mnuShow_Click(object sender, System.EventArgs e)
		{
			this.mnuShow.Text = (imageXView1.Toolbar.Activated) ? "&Show":"&Hide";
			try 
			{
				imageXView1.Toolbar.Activated = !imageXView1.Toolbar.Activated;
			}
			catch (ImagXpressException eX) 
			{
				AccusoftError(eX,lblerror);
			}
		}

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            imagXpress1.AboutBox();
        }

        private void imagXpress1_ImageStatusEvent(object sender, Accusoft.ImagXpressSdk.ImageStatusEventArgs e)
        {
            liststatus.Items.Add(e.Status.ToString());
        }

        private void imagXpress1_ProgressEvent(object sender, Accusoft.ImagXpressSdk.ProgressEventArgs e)
        {
            liststatus.Items.Add(e.PercentDone.ToString(cultNumber) + "% Loading Complete.");
            if (e.IsComplete)
            {
                liststatus.Items.Add(e.TotalBytes + " Bytes Completed Loading.");
            }
            liststatus.SelectedIndex = liststatus.Items.Count - 1;
        }
		
	}
}
