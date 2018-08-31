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

namespace TIFFTags
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Tags : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmdGet;
        private System.Windows.Forms.MainMenu menu;
        private IContainer components;
	
		private System.String strSaveFile;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnuOpen;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem mnuQuit;
		private System.Windows.Forms.ListBox lstDesc;
		private System.Windows.Forms.MenuItem mnuAbout;
		private System.Windows.Forms.Label lblerror;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView lstTags;
		private System.Windows.Forms.ColumnHeader TagNumber;
		private System.Windows.Forms.ColumnHeader Type;
		private System.Windows.Forms.ColumnHeader Count;
		private System.Windows.Forms.ColumnHeader Data;
        private System.String strCurrentImage;
		internal System.Windows.Forms.TextBox txtSaveFile;
		internal System.Windows.Forms.Label lblSaveFileName;
		internal System.Windows.Forms.Button cmdSave;
		internal System.Windows.Forms.Button cmdAddMulti;
		internal System.Windows.Forms.Button cmdDelete;
		internal System.Windows.Forms.Button cmdAdd;
		internal System.Windows.Forms.TextBox txtLoadFile;
        internal System.Windows.Forms.Label lblLoadFileName;
        private ImagXpress imagXpress1;
        private ImageXView imageXView1;

		private Accusoft.ImagXpressSdk.ImageXTagCollection colTags;

		public Tags()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tags));
            this.cmdGet = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuOpen = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuQuit = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.lblerror = new System.Windows.Forms.Label();
            this.lstDesc = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTags = new System.Windows.Forms.ListView();
            this.TagNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSaveFile = new System.Windows.Forms.TextBox();
            this.lblSaveFileName = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdAddMulti = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtLoadFile = new System.Windows.Forms.TextBox();
            this.lblLoadFileName = new System.Windows.Forms.Label();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.SuspendLayout();
            // 
            // cmdGet
            // 
            this.cmdGet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGet.Location = new System.Drawing.Point(8, 80);
            this.cmdGet.Name = "cmdGet";
            this.cmdGet.Size = new System.Drawing.Size(264, 24);
            this.cmdGet.TabIndex = 2;
            this.cmdGet.Text = "1) Load an Image and Show the Tags";
            this.cmdGet.Click += new System.EventHandler(this.cmdGet_Click);
            // 
            // menu
            // 
            this.menu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
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
            // mnuAbout
            // 
            this.mnuAbout.Index = 1;
            this.mnuAbout.Text = "&About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // lblerror
            // 
            this.lblerror.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblerror.Location = new System.Drawing.Point(592, 120);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(200, 128);
            this.lblerror.TabIndex = 3;
            // 
            // lstDesc
            // 
            this.lstDesc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDesc.Items.AddRange(new object[] {
            "This sample demonstrates the following functionality:",
            "1)Using the ImageXTagCollection Class and the GetTags method.",
            "2)Loading an image and viewing all the TIFF tags."});
            this.lstDesc.Location = new System.Drawing.Point(8, 8);
            this.lstDesc.Name = "lstDesc";
            this.lstDesc.Size = new System.Drawing.Size(800, 56);
            this.lstDesc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(592, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Last Error:";
            // 
            // lstTags
            // 
            this.lstTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TagNumber,
            this.Type,
            this.Count,
            this.Data});
            this.lstTags.Location = new System.Drawing.Point(8, 448);
            this.lstTags.Name = "lstTags";
            this.lstTags.Size = new System.Drawing.Size(472, 187);
            this.lstTags.TabIndex = 6;
            this.lstTags.UseCompatibleStateImageBehavior = false;
            this.lstTags.View = System.Windows.Forms.View.Details;
            // 
            // TagNumber
            // 
            this.TagNumber.Text = "TagNumber";
            this.TagNumber.Width = 100;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 100;
            // 
            // Count
            // 
            this.Count.Text = "Count";
            this.Count.Width = 100;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 200;
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Location = new System.Drawing.Point(8, 392);
            this.txtSaveFile.Multiline = true;
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.Size = new System.Drawing.Size(776, 40);
            this.txtSaveFile.TabIndex = 59;
            // 
            // lblSaveFileName
            // 
            this.lblSaveFileName.Location = new System.Drawing.Point(16, 360);
            this.lblSaveFileName.Name = "lblSaveFileName";
            this.lblSaveFileName.Size = new System.Drawing.Size(168, 24);
            this.lblSaveFileName.TabIndex = 58;
            this.lblSaveFileName.Text = "Save File Name:";
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Location = new System.Drawing.Point(8, 328);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(264, 24);
            this.cmdSave.TabIndex = 57;
            this.cmdSave.Text = "5) Save the file and reload it with Modified Tags";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdAddMulti
            // 
            this.cmdAddMulti.Enabled = false;
            this.cmdAddMulti.Location = new System.Drawing.Point(8, 304);
            this.cmdAddMulti.Name = "cmdAddMulti";
            this.cmdAddMulti.Size = new System.Drawing.Size(264, 24);
            this.cmdAddMulti.TabIndex = 56;
            this.cmdAddMulti.Text = "4) Add Tags with multiple Data (Tags 201 - 212)";
            this.cmdAddMulti.Click += new System.EventHandler(this.cmdAddMulti_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Enabled = false;
            this.cmdDelete.Location = new System.Drawing.Point(8, 280);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(264, 24);
            this.cmdDelete.TabIndex = 55;
            this.cmdDelete.Text = "3) Delete and ReAdd  (Tags 101 - 112)";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Enabled = false;
            this.cmdAdd.Location = new System.Drawing.Point(8, 256);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(264, 24);
            this.cmdAdd.TabIndex = 54;
            this.cmdAdd.Text = "2) Add Some Tiff Tags  (Tags 101 - 112)";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // txtLoadFile
            // 
            this.txtLoadFile.Enabled = false;
            this.txtLoadFile.Location = new System.Drawing.Point(16, 160);
            this.txtLoadFile.Multiline = true;
            this.txtLoadFile.Name = "txtLoadFile";
            this.txtLoadFile.Size = new System.Drawing.Size(248, 80);
            this.txtLoadFile.TabIndex = 53;
            // 
            // lblLoadFileName
            // 
            this.lblLoadFileName.Location = new System.Drawing.Point(16, 120);
            this.lblLoadFileName.Name = "lblLoadFileName";
            this.lblLoadFileName.Size = new System.Drawing.Size(112, 32);
            this.lblLoadFileName.TabIndex = 52;
            this.lblLoadFileName.Text = "Load File Name:";
            // 
            // imageXView1
            // 
            this.imageXView1.Location = new System.Drawing.Point(294, 80);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(281, 272);
            this.imageXView1.TabIndex = 60;
            // 
            // Tags
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(832, 644);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.txtSaveFile);
            this.Controls.Add(this.lblSaveFileName);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdAddMulti);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtLoadFile);
            this.Controls.Add(this.lblLoadFileName);
            this.Controls.Add(this.lstTags);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDesc);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.cmdGet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.menu;
            this.Name = "Tags";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIFF Tags";
            this.Load += new System.EventHandler(this.Tags_Load);
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
			Application.Run(new Tags());
		}

		private void cmdGet_Click(object sender, System.EventArgs e)
		{
			LoadAndGetTags(strCurrentImage);
            cmdAdd.Enabled = true;
            cmdDelete.Enabled = true;
            cmdAddMulti.Enabled = true;
            cmdSave.Enabled = true;
		}

		private void LoadAndGetTags(String filename)
		{
			//create a tag collection object for accessing the tags
			try
			{
				string ret;

				if (imageXView1.Image != null)
				{
					imageXView1.Image.Dispose();
					imageXView1.Image = null;
				}
				imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, filename);
				colTags = imageXView1.Image.Tags;
				txtLoadFile.Text = filename;
				lstTags.Items.Clear();

                if (colTags != null)
                {
                    foreach (Accusoft.ImagXpressSdk.ImageXTag itag in colTags)
                    {
                        ret = GetTags(itag);
                        lstTags.Items.Add(new ListViewItem(new System.String[] { itag.TagNumber.ToString(), itag.TagType.ToString(), itag.TagElementsCount.ToString(), ret }));
                    }
                }
                else
                {
                    lblerror.Text = "This image does not contain any TIFF tags.";
                }

			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
			{
				AccusoftError(ex, lblerror);
			}
		}

		public static String GetTags(Accusoft.ImagXpressSdk.ImageXTag Tag)
		{
			string TagString;
			switch(Tag.TagType)
			{
				case Accusoft.ImagXpressSdk.TagTypes.Ascii:
				{
					System.String outdata = "" ;
					for (int j = 0; j < Tag.TagElementsCount; j++)
					{		
						outdata += ((char)Tag.GetTagBytes()[j]);		
					}						
					TagString = outdata;  return TagString;
				}
				case Accusoft.ImagXpressSdk.TagTypes.Byte:
				{
					System.String outdata = "" ;
					for (int j = 0; j < Tag.TagElementsCount; j++)
					{
						if (j > 0)
						{
							outdata += ", ";
						}
						outdata += (Tag.GetTagBytes()[j]);
					}
					TagString = outdata;  return TagString;
				}
				case Accusoft.ImagXpressSdk.TagTypes.Double:
				{
					System.String outdata = "" ;
					for (int j = 0; j < Tag.TagElementsCount; j++)
					{
						if (j > 0)
						{
							outdata += ", ";
						}
						outdata +=  Tag.GetTagDouble()[j].ToString();
					}
					TagString = outdata;  return TagString;
				}
				case Accusoft.ImagXpressSdk.TagTypes.Float:
				{
					System.String outdata = "" ;
					for (int j = 0; j < Tag.TagElementsCount; j++)
					{
						if (j > 0)
						{
							outdata += ", ";
						}
						outdata += Tag.GetTagFloat()[j].ToString();
					}
					TagString = outdata;  return TagString;
				}
				case Accusoft.ImagXpressSdk.TagTypes.Long:
				{
					TagString = "";
					for (int i = 0; i < Tag.TagElementsCount; i++)
					{
						if (i > 0)
						{
							TagString += ", ";
						}
						TagString += Tag.GetTagRational()[i].ToString();
					}
					return TagString;
				}
				case Accusoft.ImagXpressSdk.TagTypes.Rational:
				{
					TagString = "";
					for (int i = 0; i < (Tag.TagElementsCount/2); i++)
					{
						if (i > 0)
						{
							TagString += ", ";
						}
						TagString += Tag.GetTagRational()[i*2].ToString() + "/" + Tag.GetTagRational()[(i*2)+1].ToString();
					}
					return TagString; 
				}
				case Accusoft.ImagXpressSdk.TagTypes.Sbyte:
				{
					System.String outdata = "" ;
					for (int j = 0; j < Tag.TagElementsCount; j++)
					{
						if (j > 0)
						{
							outdata += ", ";
						}
						outdata += Tag.GetTagSBytes()[j].ToString();
					}
					TagString = outdata;  return TagString;
				}
				case Accusoft.ImagXpressSdk.TagTypes.Short:
				{
			
					System.String outdata = "" ;
					for (int j = 0; j < Tag.TagElementsCount; j++)
					{
						if (j > 0)
						{
							outdata += ", ";
						}
						outdata += Tag.GetTagUInt16()[j].ToString();
					}
					TagString = outdata;  return TagString;
				}
				case Accusoft.ImagXpressSdk.TagTypes.Slong:
				{					
					TagString = "";
					for (int i = 0; i < Tag.TagElementsCount; i++)
					{
						if (i > 0)
						{
							TagString += ", ";
						}
						TagString += Tag.GetTagInt32()[i].ToString();
					}
					return TagString; 
				}
				case Accusoft.ImagXpressSdk.TagTypes.Srational:
				{
					TagString = "";
					for (int i = 0; i < (Tag.TagElementsCount / 2); i++)
					{
						if (i > 0)
						{
							TagString += ", ";
						}
						TagString += Tag.GetTagSRational()[i*2].ToString() + "/" + Tag.GetTagSRational()[(i*2) + 1].ToString();
					}
					return TagString; 
				}
				case Accusoft.ImagXpressSdk.TagTypes.Sshort:
				{
					System.String outdata = "" ;
					for (int j = 0; j < Tag.TagElementsCount; j++)
					{
						if (j > 0)
						{
							outdata += ", ";
						}
						outdata += Tag.GetTagInt16()[j].ToString();
					}
					TagString = outdata; return TagString;
				}
				case Accusoft.ImagXpressSdk.TagTypes.Undefine:
				{
					System.String outdata = "" ;
					for (int j = 0; j < Tag.TagElementsCount; j++)
					{
						if (j > 0)
						{
							outdata += ", ";
						}
						outdata += Tag.GetTagBytes()[j].ToString();
					}
					TagString = outdata; return TagString;
				}
			}
			return "";			
		}

		private void Tags_Load(object sender, System.EventArgs e)
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

			// Set the current directory to the Common\Images directory
			String strCurrentDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");
			if (System.IO.Directory.Exists(strCurrentDir))
				System.IO.Directory.SetCurrentDirectory(strCurrentDir);
			strCurrentDir = System.IO.Directory.GetCurrentDirectory();

			strCurrentImage = "benefits.tif";
			strSaveFile = Application.StartupPath + @"\TagsOutput.tif";
			
			txtLoadFile.Text = strCurrentImage;
			txtSaveFile.Text = strSaveFile;
		}
		
		private void mnuOpen_Click(object sender, System.EventArgs e)
		{
			System.String sTmp = AccusoftOpenFile();
			if (sTmp.Length != 0) 
			{
				strCurrentImage = sTmp;
				LoadAndGetTags(strCurrentImage);
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
		private const System.String strCommonImagesDirectory = "..\\..\\..\\..\\..\\..\\..\\..\\Common\\Images\\";

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

		private void cmdSave_Click(object sender, System.EventArgs e)
		{
			try
			{

				Accusoft.ImagXpressSdk.SaveOptions so;

                if (imageXView1.Image.Tags != null)
                {
                    imageXView1.Image.Tags.Dispose();
                    imageXView1.Image.Tags = null;
                }

				imageXView1.Image.Tags = colTags;
				
                so = new Accusoft.ImagXpressSdk.SaveOptions();
				so.Format = ImageXFormat.Tiff;
				so.Tiff.Compression = Compression.NoCompression;
				
                imageXView1.Image.Save(txtSaveFile.Text, so);
				
                Application.DoEvents();
				LoadAndGetTags(txtSaveFile.Text);
			}
			catch(Accusoft.ImagXpressSdk.ImagXpressException ex)
			{
				AccusoftError(ex, lblerror);
			}
		}

		private void cmdAddMulti_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Byte - TIFF Type 1
				byte[] byteTag;
				byteTag = new byte[3];
				byteTag[0] = 1;
				byteTag[1] = 2;
				byteTag[2] = 3;
				Accusoft.ImagXpressSdk.ImageXTag my201Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my201Tag.TagNumber = 201;
				my201Tag.TagType = TagTypes.Byte;
				my201Tag.TagLevel = 0;
				my201Tag.SetTagBytes(byteTag);
				colTags.Add(my201Tag);

				// Ascii - TIFF Type 2
				byte[] asciiTag;
				System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
				asciiTag = encoding.GetBytes("Tag 2");
				Accusoft.ImagXpressSdk.ImageXTag my202Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my202Tag.SetTagBytes(asciiTag);
				my202Tag.TagNumber = 202;
				my202Tag.TagType = TagTypes.Ascii;
				my202Tag.TagLevel = 0;
				colTags.Add(my202Tag);

				// Short - TIFF Type 3
				int[] shortTag;
				shortTag = new int[3];
				shortTag[0] = 3;
				shortTag[1] = 4;
				shortTag[2] = 5;
				Accusoft.ImagXpressSdk.ImageXTag my203Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my203Tag.TagNumber = 203;
				my203Tag.TagType = TagTypes.Short;
				my203Tag.TagLevel = 0;
				my203Tag.SetTagUInt16(shortTag);
				colTags.Add(my203Tag);

				// Long - TIFF Type 4
				long[] longTag;
				longTag = new long[3];
				longTag[0] = 4;
				longTag[1] = 5;
				longTag[2] = 6;
				Accusoft.ImagXpressSdk.ImageXTag my204Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my204Tag.TagNumber = 204;
				my204Tag.TagType = TagTypes.Long;
				my204Tag.TagLevel = 0;
				my204Tag.SetTagUInt32(longTag);
				colTags.Add(my204Tag);

				// Rational - TIFF Type 5
				long[] rationalTag;
				rationalTag = new long[6];
				// Holder for rational data
				rationalTag[0] = 600; // Numerator
				rationalTag[1] = 2; // Denominator
				rationalTag[2] = 720; // Numerator
				rationalTag[3] = 10; // Denominator
				rationalTag[4] = 300; // Numerator
				rationalTag[5] = 1; // Denominator
				Accusoft.ImagXpressSdk.ImageXTag my205Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my205Tag.TagNumber = 205;
				my205Tag.TagType = TagTypes.Rational;
				my205Tag.TagLevel = 0;
				my205Tag.SetTagRational(rationalTag);
				colTags.Add(my205Tag);

				// SByte - TIFF Type 6
				short[] sbyteTag;
				sbyteTag = new short[3];
				sbyteTag[0] = -6;
				sbyteTag[1] = -7;
				sbyteTag[2] = -8;
				Accusoft.ImagXpressSdk.ImageXTag my206Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my206Tag.TagNumber = 206;
				my206Tag.TagType = TagTypes.Sbyte;
				my206Tag.TagLevel = 0;
				my206Tag.SetTagSBytes(sbyteTag);
				colTags.Add(my206Tag);

				// Undefine - TIFF Type 7
				byte[] undefineTag;
				undefineTag = new byte[3];
				undefineTag[0] = 7;
				undefineTag[1] = 8;
				undefineTag[2] = 9;
				Accusoft.ImagXpressSdk.ImageXTag my207Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my207Tag.SetTagBytes(undefineTag);
				my207Tag.TagNumber = 207;
				my207Tag.TagType = TagTypes.Undefine;
				my207Tag.TagLevel = 0;
				colTags.Add(my207Tag);

				// SShort - TIFF Type 8
				short[] sshortTag;
				sshortTag = new short[3];
				sshortTag[0] = -8;
				sshortTag[1] = -9;
				sshortTag[2] = -10;
				Accusoft.ImagXpressSdk.ImageXTag my208Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my208Tag.TagNumber = 208;
				my208Tag.TagType = TagTypes.Sshort;
				my208Tag.TagLevel = 0;
				my208Tag.SetTagInt16(sshortTag);
				colTags.Add(my208Tag);

				// SLong - TIFF Type 9
				int[] slongTag;
				slongTag = new int[3];
				slongTag[0] = -9;
				slongTag[1] = -10;
				slongTag[2] = -11;
				Accusoft.ImagXpressSdk.ImageXTag my209Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my209Tag.TagNumber = 209;
				my209Tag.TagType = TagTypes.Slong;
				my209Tag.TagLevel = 0;
				my209Tag.SetTagInt32(slongTag);
				colTags.Add(my209Tag);

				// SRational - TIFF Type 10
				int[] srationalTag;
				srationalTag = new int[6];
				//  Holder for srational data
				srationalTag[0] = -600; // Numerator
				srationalTag[1] = 2; // Denominator
				srationalTag[2] = -720; // Numerator
				srationalTag[3] = 10; // Denominator
				srationalTag[4] = -300; // Numerator
				srationalTag[5] = 1; // Denominator
				Accusoft.ImagXpressSdk.ImageXTag my210Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my210Tag.TagNumber = 210;
				my210Tag.TagType = TagTypes.Srational;
				my210Tag.TagLevel = 0;
				my210Tag.SetTagSRational(srationalTag);
				colTags.Add(my210Tag);

				// Float - TIFF Type 11
				float[] floatTag;
				floatTag = new float[3];
				floatTag[0] = 11.65F;
				floatTag[1] = -12.65F;
				floatTag[2] = -13.65F;
				Accusoft.ImagXpressSdk.ImageXTag my211Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my211Tag.TagNumber = 211;
				my211Tag.TagType = TagTypes.Float;
				my211Tag.TagLevel = 0;
				my211Tag.SetTagFloat(floatTag);
				colTags.Add(my211Tag);

				// Double - TIFF Type 12
				double[] doubleTag;
				doubleTag = new double[3];
				doubleTag[0] = 12.42;
				doubleTag[1] = -13.42;
				doubleTag[2] = -14.42;
				Accusoft.ImagXpressSdk.ImageXTag my212Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my212Tag.TagNumber = 212;
				my212Tag.TagType = TagTypes.Double;
				my212Tag.TagLevel = 0;
				my212Tag.SetTagDouble(doubleTag);
				colTags.Add(my212Tag);

				string ret;
				lstTags.Items.Clear();
	
				foreach(Accusoft.ImagXpressSdk.ImageXTag itag in colTags)
				{
					ret = GetTags(itag);
					lstTags.Items.Add(new ListViewItem(new System.String[]{ itag.TagNumber.ToString(),itag.TagType.ToString(),itag.TagElementsCount.ToString(), ret}));                
				}

			}
			catch(Accusoft.ImagXpressSdk.ImagXpressException ex)
			{
				AccusoftError(ex, lblerror);
			}
		}

		private void cmdDelete_Click(object sender, System.EventArgs e)
		{
			try
			{

				// Delete our test tags and readd them to test
				// Retrieve, Add, and Delete for each tag type

				int i;
				for (i = 101; i <= 112; i++) 
				{
					Accusoft.ImagXpressSdk.ImageXTag myTag;
					myTag = colTags.GetTag(i, 0);
					colTags.RemoveTag(i, 0);
					colTags.Add(myTag);
				}

				string ret;
				lstTags.Items.Clear();
	
				foreach(Accusoft.ImagXpressSdk.ImageXTag itag in colTags)
				{
					ret = GetTags(itag);
					lstTags.Items.Add(new ListViewItem(new System.String[]{ itag.TagNumber.ToString(),itag.TagType.ToString(),itag.TagElementsCount.ToString(), ret}));                
				}

			}
			catch(Accusoft.ImagXpressSdk.ImagXpressException ex)
			{
				AccusoftError(ex, lblerror);
			}
		}

		private void cmdAdd_Click(object sender, System.EventArgs e)
		{
			try
			{

				// We assemble and add some test TIFF tags
				// This demonstrates adding each type of tag

				string ret;

				// Byte - TIFF Type 1
				byte[] byteTag;
				byteTag = new byte[1];
				byteTag[0] = 1;
				Accusoft.ImagXpressSdk.ImageXTag my101Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my101Tag.TagNumber = 101;
				my101Tag.TagType = TagTypes.Byte;
				my101Tag.TagLevel = 0;
				my101Tag.SetTagBytes(byteTag);
				colTags.Add(my101Tag);

				// Ascii - TIFF Type 2
				byte[] asciiTag;
				System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
				asciiTag = encoding.GetBytes("Tag 2");
				Accusoft.ImagXpressSdk.ImageXTag my102Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my102Tag.SetTagBytes(asciiTag);
				my102Tag.TagNumber = 102;
				my102Tag.TagType = TagTypes.Ascii;
				my102Tag.TagLevel = 0;
				colTags.Add(my102Tag);

				// Short - TIFF Type 3
				int[] shortTag;
				shortTag = new int[1];
				shortTag[0] = 3;
				Accusoft.ImagXpressSdk.ImageXTag my103Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my103Tag.TagNumber = 103;
				my103Tag.TagType = TagTypes.Short;
				my103Tag.TagLevel = 0;
				my103Tag.SetTagUInt16(shortTag);
				colTags.Add(my103Tag);

				// Long - TIFF Type 4
				long[] longTag;
				longTag = new long[1];
				longTag[0] = 4;
				Accusoft.ImagXpressSdk.ImageXTag my104Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my104Tag.TagNumber = 104;
				my104Tag.TagType = TagTypes.Long;
				my104Tag.TagLevel = 0;
				my104Tag.SetTagUInt32(longTag);
				colTags.Add(my104Tag);

				// Rational - TIFF Type 5
				long[] rationalTag;
				rationalTag = new long[2];
				// Holder for rational data
				rationalTag[0] = 600; // Numerator
				rationalTag[1] = 2; // Denominator
				Accusoft.ImagXpressSdk.ImageXTag my105Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my105Tag.TagNumber = 105;
				my105Tag.TagType = TagTypes.Rational;
				my105Tag.TagLevel = 0;
				my105Tag.SetTagRational(rationalTag);
				colTags.Add(my105Tag);

				// SByte - TIFF Type 6
				short[] sbyteTag;
				sbyteTag = new short[1];
				sbyteTag[0] = -6;
				Accusoft.ImagXpressSdk.ImageXTag my106Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my106Tag.TagNumber = 106;
				my106Tag.TagType = TagTypes.Sbyte;
				my106Tag.TagLevel = 0;
				my106Tag.SetTagSBytes(sbyteTag);
				colTags.Add(my106Tag);

				// Undefine - TIFF Type 7
				byte[] undefineTag;
				undefineTag = new byte[1];
				undefineTag[0] = 7;
				Accusoft.ImagXpressSdk.ImageXTag my107Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my107Tag.SetTagBytes(undefineTag);
				my107Tag.TagNumber = 107;
				my107Tag.TagType = TagTypes.Undefine;
				my107Tag.TagLevel = 0;
				colTags.Add(my107Tag);

				// SShort - TIFF Type 8
				short[] sshortTag;
				sshortTag = new short[1];
				sshortTag[0] = -8;
				Accusoft.ImagXpressSdk.ImageXTag my108Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my108Tag.TagNumber = 108;
				my108Tag.TagType = TagTypes.Sshort;
				my108Tag.TagLevel = 0;
				my108Tag.SetTagInt16(sshortTag);
				colTags.Add(my108Tag);

				// SLong - TIFF Type 9
				int[] slongTag;
				slongTag = new int[1];
				slongTag[0] = -9;
				Accusoft.ImagXpressSdk.ImageXTag my109Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my109Tag.TagNumber = 109;
				my109Tag.TagType = TagTypes.Slong;
				my109Tag.TagLevel = 0;
				my109Tag.SetTagInt32(slongTag);
				colTags.Add(my109Tag);

				// SRational - TIFF Type 10
				int[] srationalTag;
				srationalTag = new int[2];
				//  Holder for srational data
				srationalTag[0] = -600; // Numerator
				srationalTag[1] = 2; // Denominator
				Accusoft.ImagXpressSdk.ImageXTag my110Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my110Tag.TagNumber = 110;
				my110Tag.TagType = TagTypes.Srational;
				my110Tag.TagLevel = 0;
				my110Tag.SetTagSRational(srationalTag);
				colTags.Add(my110Tag);

				// Float - TIFF Type 11
				float[] floatTag;
				floatTag = new float[1];
				floatTag[0] = 11.65F;
				Accusoft.ImagXpressSdk.ImageXTag my111Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my111Tag.TagNumber = 111;
				my111Tag.TagType = TagTypes.Float;
				my111Tag.TagLevel = 0;
				my111Tag.SetTagFloat(floatTag);
				colTags.Add(my111Tag);

				// Double - TIFF Type 12
				double[] doubleTag;
				doubleTag = new double[1];
				doubleTag[0] = 12.42;
				Accusoft.ImagXpressSdk.ImageXTag my112Tag = new Accusoft.ImagXpressSdk.ImageXTag();
				my112Tag.TagNumber = 112;
				my112Tag.TagType = TagTypes.Double;
				my112Tag.TagLevel = 0;
				my112Tag.SetTagDouble(doubleTag);
				colTags.Add(my112Tag);

				lstTags.Items.Clear();
	
				foreach(Accusoft.ImagXpressSdk.ImageXTag itag in colTags)
				{
					ret = GetTags(itag);
					lstTags.Items.Add(new ListViewItem(new System.String[]{ itag.TagNumber.ToString(),itag.TagType.ToString(),itag.TagElementsCount.ToString(), ret}));                
				}

		}
			catch(Accusoft.ImagXpressSdk.ImagXpressException ex)
			{
				AccusoftError(ex, lblerror);
			}
			
		}

		private void mnuAbout_Click(object sender, System.EventArgs e)
		{
			imagXpress1.AboutBox();
		}

		private void mnuQuit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
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
	
	}
}
