/***************************************************************
* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices; // DllImport

namespace MultiPageTIFF
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MultiPageTIFF : System.Windows.Forms.Form
	{
		//private Accusoft.ImagXpressSdk.ImageX ixTiffFile;
		private System.Windows.Forms.Button buttonMake;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.Button buttonInsert;
		private System.Windows.Forms.Button buttonCompact;
		private System.Windows.Forms.MainMenu mnuFile;
		private System.Windows.Forms.MenuItem mnuFileFile;
		private System.Windows.Forms.MenuItem mnuFileQuit;
		private System.String strImageFile1;
		private System.String strImageFile2;
		private System.String strImageFile3;
		private System.String strMPFile;
        private System.String strMP2File;
		private System.String strTmpFile;
        private System.Windows.Forms.RichTextBox rtfInfo;
		private System.Windows.Forms.MenuItem mnuAbout;
		private System.Windows.Forms.Label lblLastError;
        private System.Windows.Forms.Label lblError;
        private Label labelFileStats;
        private Accusoft.ImagXpressSdk.ImagXpress imagXpress1;
        private Accusoft.ImagXpressSdk.ImageXView imageXView1;
        private Accusoft.ImagXpressSdk.ImageXView imageXView2;
        private Accusoft.ImagXpressSdk.ImageXView imageXView3;
        private Button buttonInsertMulti;
        private Button buttonRemoveMulti;
		private IContainer components;

		public MultiPageTIFF()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiPageTIFF));
            this.buttonMake = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonCompact = new System.Windows.Forms.Button();
            this.mnuFile = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFileFile = new System.Windows.Forms.MenuItem();
            this.mnuFileQuit = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.rtfInfo = new System.Windows.Forms.RichTextBox();
            this.lblLastError = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.labelFileStats = new System.Windows.Forms.Label();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.imageXView2 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.imageXView3 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.buttonInsertMulti = new System.Windows.Forms.Button();
            this.buttonRemoveMulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMake
            // 
            this.buttonMake.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMake.Location = new System.Drawing.Point(399, 152);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(238, 24);
            this.buttonMake.TabIndex = 4;
            this.buttonMake.Text = "Make Multi-page Tiff Files";
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(399, 184);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(118, 24);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove Page 2";
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(399, 216);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(118, 24);
            this.buttonInsert.TabIndex = 6;
            this.buttonInsert.Text = "Insert Page 2";
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonCompact
            // 
            this.buttonCompact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCompact.Location = new System.Drawing.Point(399, 248);
            this.buttonCompact.Name = "buttonCompact";
            this.buttonCompact.Size = new System.Drawing.Size(238, 24);
            this.buttonCompact.TabIndex = 7;
            this.buttonCompact.Text = "Compact";
            this.buttonCompact.Click += new System.EventHandler(this.buttonCompact_Click);
            // 
            // mnuFile
            // 
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFileFile,
            this.mnuAbout});
            // 
            // mnuFileFile
            // 
            this.mnuFileFile.Index = 0;
            this.mnuFileFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFileQuit});
            this.mnuFileFile.Text = "&File";
            // 
            // mnuFileQuit
            // 
            this.mnuFileQuit.Index = 0;
            this.mnuFileQuit.Text = "&Quit";
            this.mnuFileQuit.Click += new System.EventHandler(this.mnuFileQuit_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 1;
            this.mnuAbout.Text = "&About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // rtfInfo
            // 
            this.rtfInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfInfo.Location = new System.Drawing.Point(16, 8);
            this.rtfInfo.Name = "rtfInfo";
            this.rtfInfo.ReadOnly = true;
            this.rtfInfo.Size = new System.Drawing.Size(613, 128);
            this.rtfInfo.TabIndex = 10;
            this.rtfInfo.Text = resources.GetString("rtfInfo.Text");
            // 
            // lblLastError
            // 
            this.lblLastError.Location = new System.Drawing.Point(13, 388);
            this.lblLastError.Name = "lblLastError";
            this.lblLastError.Size = new System.Drawing.Size(77, 40);
            this.lblLastError.TabIndex = 14;
            this.lblLastError.Text = "Last Error:";
            // 
            // lblError
            // 
            this.lblError.Location = new System.Drawing.Point(96, 377);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(491, 51);
            this.lblError.TabIndex = 15;
            // 
            // labelFileStats
            // 
            this.labelFileStats.Location = new System.Drawing.Point(10, 301);
            this.labelFileStats.Name = "labelFileStats";
            this.labelFileStats.Size = new System.Drawing.Size(394, 55);
            this.labelFileStats.TabIndex = 19;
            // 
            // imageXView1
            // 
            this.imageXView1.Location = new System.Drawing.Point(13, 152);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(122, 120);
            this.imageXView1.TabIndex = 21;
            // 
            // imageXView2
            // 
            this.imageXView2.Location = new System.Drawing.Point(142, 152);
            this.imageXView2.Name = "imageXView2";
            this.imageXView2.Size = new System.Drawing.Size(122, 120);
            this.imageXView2.TabIndex = 22;
            // 
            // imageXView3
            // 
            this.imageXView3.Location = new System.Drawing.Point(271, 152);
            this.imageXView3.Name = "imageXView3";
            this.imageXView3.Size = new System.Drawing.Size(122, 120);
            this.imageXView3.TabIndex = 23;
            // 
            // buttonInsertMulti
            // 
            this.buttonInsertMulti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsertMulti.Location = new System.Drawing.Point(519, 216);
            this.buttonInsertMulti.Name = "buttonInsertMulti";
            this.buttonInsertMulti.Size = new System.Drawing.Size(118, 24);
            this.buttonInsertMulti.TabIndex = 25;
            this.buttonInsertMulti.Text = "Insert Pages 2-3";
            this.buttonInsertMulti.Click += new System.EventHandler(this.buttonInsertMulti_Click);
            // 
            // buttonRemoveMulti
            // 
            this.buttonRemoveMulti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveMulti.Location = new System.Drawing.Point(519, 184);
            this.buttonRemoveMulti.Name = "buttonRemoveMulti";
            this.buttonRemoveMulti.Size = new System.Drawing.Size(118, 24);
            this.buttonRemoveMulti.TabIndex = 24;
            this.buttonRemoveMulti.Text = "Remove Pages 2-3";
            this.buttonRemoveMulti.Click += new System.EventHandler(this.buttonRemoveMulti_Click);
            // 
            // MultiPageTIFF
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(645, 408);
            this.Controls.Add(this.buttonInsertMulti);
            this.Controls.Add(this.buttonRemoveMulti);
            this.Controls.Add(this.imageXView3);
            this.Controls.Add(this.imageXView2);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.labelFileStats);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblLastError);
            this.Controls.Add(this.rtfInfo);
            this.Controls.Add(this.buttonCompact);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonMake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mnuFile;
            this.Name = "MultiPageTIFF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiPage TIFF";
            this.Load += new System.EventHandler(this.MultiPageTIFF_Load);
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
			Application.Run(new MultiPageTIFF());
		}

        private void MultiPageTIFF_Load(object sender, System.EventArgs e)
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
            imageXView3.AutoImageDispose = true;

            // Set the current directory to the Common\Images directory
            String strCurrentDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");
            if (System.IO.Directory.Exists(strCurrentDir))
                System.IO.Directory.SetCurrentDirectory(strCurrentDir);
            strCurrentDir = System.IO.Directory.GetCurrentDirectory();

            strImageFile1 = "page1.tif";
            strImageFile2 = "page2.tif";
            strImageFile3 = "page3.tif";
            strMPFile = Application.StartupPath + @"\multi.tif";
            strMP2File = Application.StartupPath + @"\multi2.tif";
            strTmpFile = Application.StartupPath + @"\compact.tif";

            buttonInsert.Enabled = false;
            buttonInsertMulti.Enabled = false;
            buttonRemove.Enabled = false;
            buttonRemoveMulti.Enabled = false;
            buttonCompact.Enabled = false;
        }

        private void buttonMake_Click(object sender, System.EventArgs e)
        {
            ClearErrorLabel( );
            buttonMake.Enabled = false;
            buttonRemove.Enabled = false;
            buttonRemoveMulti.Enabled = false;
            buttonInsert.Enabled = false;
            buttonInsertMulti.Enabled = false;
            buttonCompact.Enabled = false;

            if (System.IO.File.Exists(strMPFile))
            {
                System.IO.File.Delete(strMPFile);
            }
            if (System.IO.File.Exists(strMP2File))
            {
                System.IO.File.Delete(strMP2File);
            }
            try
            {
                Accusoft.ImagXpressSdk.ImageX imgTmp = null;

                // Create file with first page
                imgTmp = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImageFile1);
                Accusoft.ImagXpressSdk.SaveOptions soOpts = new Accusoft.ImagXpressSdk.SaveOptions();

                soOpts.Format = Accusoft.ImagXpressSdk.ImageXFormat.Tiff;
                soOpts.Tiff.Compression = Accusoft.ImagXpressSdk.Compression.NoCompression;
                soOpts.Tiff.MultiPage = true;
                imgTmp.Save(strMPFile, soOpts);
                imgTmp.Dispose();
                imgTmp = null;

                // Insert pages 2 and 3
                Accusoft.ImagXpressSdk.ImageX.InsertPage(imagXpress1, strImageFile2, strMPFile, 2);
                Accusoft.ImagXpressSdk.ImageX.InsertPage(imagXpress1, strImageFile3, strMPFile, 3);
                // Make an identical copy for multi-page inserts
                System.IO.File.Copy(strMPFile, strMP2File);

                buttonRemove.Enabled = true;
                buttonRemoveMulti.Enabled = true;
                buttonMake.Enabled = true;
            }
            catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
            {
                AccusoftError(ex, lblError);
                buttonMake.Enabled = true;
                return;
            }
            ReloadViews();
        }

        // The DeletePage method is a method that allows you to delete one page
        // at a time from a multi-page tiff and is useful when you only have one page to delete.
        // The DeletePages method is a method that allows you to delete multiple consecutive
        // pages at one time from a multi-page tiff. It works with a single page as well.
        private void buttonRemove_Click(object sender, System.EventArgs e)
        {
            try
            {
                ClearErrorLabel( );
                buttonRemove.Enabled = false;
                buttonRemoveMulti.Enabled = false;

                // delete 2nd page
                Accusoft.ImagXpressSdk.ImageX.DeletePage(imagXpress1, strMPFile, 2);

                buttonInsert.Enabled = true;
                buttonCompact.Enabled = true;
            }
            catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
            {
                AccusoftError(ex, lblError);
            }
            ReloadViews();
        }

        private void buttonRemoveMulti_Click(object sender, EventArgs e)
        {
            try
            {
                ClearErrorLabel( );
                buttonRemoveMulti.Enabled = false;
                buttonRemove.Enabled = false;
                
                // delete pages 2 and 3
                Accusoft.ImagXpressSdk.ImageX.DeletePages(imagXpress1, strMPFile, 2, 2);

                buttonInsertMulti.Enabled = true;
                buttonCompact.Enabled = true;
            }
            catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
            {
                AccusoftError(ex, lblError);
            }
            ReloadViews();
        }

        private void buttonInsert_Click(object sender, System.EventArgs e)
        {
            try
            {
                ClearErrorLabel( );
                buttonInsert.Enabled = false;
                buttonInsertMulti.Enabled = false;

                // insert 'page2.tif' into the page 2 position
                Accusoft.ImagXpressSdk.ImageX.InsertPage(imagXpress1, strImageFile2, strMPFile, 2);

                buttonCompact.Enabled = true;
                buttonRemove.Enabled = true;
                buttonRemoveMulti.Enabled = true;
            }
            catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
            {
                AccusoftError(eX, lblError);
            }
            ReloadViews();
        }

        private void buttonInsertMulti_Click(object sender, EventArgs e)
        {
            try
            {
                ClearErrorLabel( );
                buttonInsert.Enabled = false;
                buttonInsertMulti.Enabled = false;

                // insert pages 2 and 3 from the 'multi2.tif' copy of the original starting at the page 2 position
                Accusoft.ImagXpressSdk.ImageX.InsertPages(imagXpress1, strMP2File, 2, 2, strMPFile, 2);

                buttonCompact.Enabled = true;
                buttonRemove.Enabled = true;
                buttonRemoveMulti.Enabled = true;
            }
            catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
            {
                AccusoftError(eX, lblError);
            }
            ReloadViews();
        }

        private void buttonCompact_Click(object sender, System.EventArgs e)
        {
            try
            {
                ClearErrorLabel( );
                buttonCompact.Enabled = false;

                // compact the file and remove orphaned pages
                Accusoft.ImagXpressSdk.ImageX.CompactFile(imagXpress1, strMPFile, strTmpFile);
            }
            catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
            {
                AccusoftError(ex, lblError); ;
            }
            if (System.IO.File.Exists(strTmpFile))
            {
                System.IO.File.Delete(strMPFile);
                System.IO.File.Move(strTmpFile, strMPFile);
            }
            ReloadViews();
        }

		private void ReloadViews() 
		{
			try
			{
				// Get the number of pages in the multi-page TIFF here
				System.Int32 nNbrPages = Accusoft.ImagXpressSdk.ImageX.NumPages(imagXpress1, strMPFile);

				// Show the first 3 pages
				for (System.Int32 i = 1; i <= 3; i++)
				{
					// Dispose of any current images
					switch (i)
					{
						case 1:
							if (imageXView1.Image != null)
							{
								imageXView1.Image.Dispose();
								imageXView1.Image = null;
							}
							break;

						case 2:
							if (imageXView2.Image != null)
							{
								imageXView2.Image.Dispose();
								imageXView2.Image = null;
							}
							break;

						case 3:
							if (imageXView3.Image != null)
							{
								imageXView3.Image.Dispose();
								imageXView3.Image = null;
							}
							break;

					}

					// load the correct page into the correct view
					if (i <= nNbrPages)
					{
						switch (i)
						{
							case 1:
								imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strMPFile, i);
								break;

							case 2:
								imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strMPFile, i);
								break;

							case 3:
								imageXView3.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strMPFile, i);
								break;
						}
					}
				}

				labelFileStats.Text = "File Size: " + imageXView1.Image.ImageXData.Size.ToString(cultNumber) + " bytes.\n" + "Pages: " + imageXView1.Image.PageCount;

			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException eX)
			{
				AccusoftError(eX, lblError);
			}
		}

        private void ClearErrorLabel( )
        {
            // clear out any error before next operation
            lblError.Text = "";
        }
			
		private void mnuFileQuit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}


		private void mnuAbout_Click(object sender, System.EventArgs e)
		{
			imagXpress1.AboutBox();
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

	}

}
