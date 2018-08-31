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

namespace Draw
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu menuFile;
		private System.Windows.Forms.MenuItem menuFileFile;
		private System.Windows.Forms.MenuItem menuToolbar;
		private System.Windows.Forms.MenuItem menuAbout;
		private System.Windows.Forms.MenuItem menuToolbarShow;
		private System.Windows.Forms.MenuItem menuFileOpen;
		private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuFileQuit;
		private System.Windows.Forms.Label labelLastError;
		private System.Windows.Forms.Label labelError;

		private System.String strCurrentImage;
		private Accusoft.ImagXpressSdk.LoadOptions loLoadOptions;
		private Accusoft.ImagXpressSdk.Processor changebitdepth;
		private System.Windows.Forms.Button buttonCircle;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button buttonPie;
		private System.Windows.Forms.Button buttonLine;
		private System.Windows.Forms.Button buttonText;
		private System.Windows.Forms.Button buttonPen;
		private System.Boolean isDrawingWithPen;
		private System.Boolean isMouseDrawing;
        private System.Drawing.PointF LastDrawPoint;
        private Accusoft.ImagXpressSdk.ImagXpress imagXpress1;
        private Accusoft.ImagXpressSdk.ImageXView imageXView1;
        private IContainer components;

		public MainForm()
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
			//***call the Dispose method on the imagXpress1 object and the
			//*** imageXView1 object
			
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
            this.menuFile = new System.Windows.Forms.MainMenu(this.components);
            this.menuFileFile = new System.Windows.Forms.MenuItem();
            this.menuFileOpen = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuFileQuit = new System.Windows.Forms.MenuItem();
            this.menuToolbar = new System.Windows.Forms.MenuItem();
            this.menuToolbarShow = new System.Windows.Forms.MenuItem();
            this.menuAbout = new System.Windows.Forms.MenuItem();
            this.labelLastError = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonPie = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonText = new System.Windows.Forms.Button();
            this.buttonPen = new System.Windows.Forms.Button();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.SuspendLayout();
            // 
            // menuFile
            // 
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFileFile,
            this.menuToolbar,
            this.menuAbout});
            // 
            // menuFileFile
            // 
            this.menuFileFile.Index = 0;
            this.menuFileFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFileOpen,
            this.menuItem2,
            this.menuFileQuit});
            this.menuFileFile.Text = "&File";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Index = 0;
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // menuFileQuit
            // 
            this.menuFileQuit.Index = 2;
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
            // menuAbout
            // 
            this.menuAbout.Index = 2;
            this.menuAbout.Text = "&About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // labelLastError
            // 
            this.labelLastError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastError.Location = new System.Drawing.Point(414, 63);
            this.labelLastError.Name = "labelLastError";
            this.labelLastError.Size = new System.Drawing.Size(96, 16);
            this.labelLastError.TabIndex = 4;
            this.labelLastError.Text = "Last Error:";
            // 
            // labelError
            // 
            this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelError.Location = new System.Drawing.Point(414, 79);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(176, 120);
            this.labelError.TabIndex = 5;
            // 
            // buttonCircle
            // 
            this.buttonCircle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCircle.Location = new System.Drawing.Point(8, 367);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(104, 32);
            this.buttonCircle.TabIndex = 6;
            this.buttonCircle.Text = "Draw Circle";
            this.buttonCircle.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.Items.AddRange(new object[] {
            "This sample demonstrates the following functionality:",
            "1)Drawing on an Image using the GDI+ .NET drawing features."});
            this.listBox1.Location = new System.Drawing.Point(8, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(592, 43);
            this.listBox1.TabIndex = 7;
            // 
            // buttonPie
            // 
            this.buttonPie.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPie.Location = new System.Drawing.Point(120, 367);
            this.buttonPie.Name = "buttonPie";
            this.buttonPie.Size = new System.Drawing.Size(104, 32);
            this.buttonPie.TabIndex = 8;
            this.buttonPie.Text = "Draw Pie";
            this.buttonPie.Click += new System.EventHandler(this.buttonPie_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLine.Location = new System.Drawing.Point(232, 367);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(104, 32);
            this.buttonLine.TabIndex = 9;
            this.buttonLine.Text = "Draw Line";
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonText
            // 
            this.buttonText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonText.Location = new System.Drawing.Point(344, 367);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(104, 32);
            this.buttonText.TabIndex = 10;
            this.buttonText.Text = "Draw Text";
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonPen
            // 
            this.buttonPen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPen.Location = new System.Drawing.Point(456, 367);
            this.buttonPen.Name = "buttonPen";
            this.buttonPen.Size = new System.Drawing.Size(144, 32);
            this.buttonPen.TabIndex = 11;
            this.buttonPen.Text = "Enable Mouse Drawing";
            this.buttonPen.Click += new System.EventHandler(this.buttonPen_Click);
            // 
            // imageXView1
            // 
            this.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
            this.imageXView1.Location = new System.Drawing.Point(8, 58);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(400, 294);
            this.imageXView1.TabIndex = 12;
            this.imageXView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseDown);
            this.imageXView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseMove);
            this.imageXView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(608, 428);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.buttonPen);
            this.Controls.Add(this.buttonText);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonPie);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelLastError);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.menuFile;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw";
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
			Application.Run(new MainForm());
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
		private void formMain_Load(object sender, System.EventArgs e)
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

			//Create a new load options object so we can recieve events from the images we load
			loLoadOptions = new Accusoft.ImagXpressSdk.LoadOptions();

			//here we set the current directory and image so that the file open dialog box works well
            String strCurrentDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");
            if (System.IO.Directory.Exists(strCurrentDir))
                System.IO.Directory.SetCurrentDirectory(strCurrentDir);
            strCurrentDir = System.IO.Directory.GetCurrentDirectory();

			strCurrentImage = System.IO.Path.Combine (strCurrentDir, "window.jpg");

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

			isDrawingWithPen = false;
			LastDrawPoint = new System.Drawing.Point();
		}


		private void menuFileOpen_Click(object sender, System.EventArgs e)
		{
			//First we obtain the filename of the image we want to open
			System.String strLoadResult = AccusoftOpenFile();

			//we check first to make sure the file is valid
			if (strLoadResult.Length != 0) 
			{
				//If it is valid, we set our internal image filename equal to it
				strCurrentImage = strLoadResult;
			}

			//now we load the image
			ReloadImage();						
			
			//refresh the view
			imageXView1.Refresh();
		}

		private void ReloadImage()
		{
			try 
			{
                if (imageXView1.Image != null)
                    imageXView1.Image.Dispose();
				imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strCurrentImage, loLoadOptions);
				changebitdepth = new Accusoft.ImagXpressSdk.Processor(imagXpress1, imageXView1.Image);
				if(imageXView1.Image.ImageXData.BitsPerPixel != 24) 
				{				
					changebitdepth.ColorDepth(24,Accusoft.ImagXpressSdk.PaletteType.Fixed,Accusoft.ImagXpressSdk.DitherType.NoDither);
				}
				changebitdepth.Dispose();

				// clear out the error in case there was an error from a previous operation
				labelError.Text = "";
			} 
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex) 
			{
				AccusoftError(ex,labelError);
			}
		}

		private void buttonLine_Click(object sender, System.EventArgs e)
		{
			ReloadImage();
			System.Drawing.Graphics g = imageXView1.Image.GetGraphics();
			g.DrawLine(System.Drawing.Pens.Cyan,0,0,50,50);
			imageXView1.Image.ReleaseGraphics(true);
		}

		private void buttonPie_Click(object sender, System.EventArgs e)
		{
			ReloadImage();
			System.Drawing.Graphics g = imageXView1.Image.GetGraphics();
			g.DrawPie(System.Drawing.Pens.Honeydew,0,0,50,50,50,270);
			imageXView1.Image.ReleaseGraphics(true);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			ReloadImage();
			System.Drawing.Graphics g = imageXView1.Image.GetGraphics();
			g.DrawEllipse(System.Drawing.Pens.LightSeaGreen,0,0,50,50);
			imageXView1.Image.ReleaseGraphics(true);
		}

		private void buttonText_Click(object sender, System.EventArgs e)
		{
			ReloadImage();
			System.Drawing.Graphics g = imageXView1.Image.GetGraphics();
			g.DrawString(System.DateTime.Now.ToString(cultNumber),new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif.Name,18), System.Drawing.Brushes.DarkBlue,0,0);
			imageXView1.Image.ReleaseGraphics(true);
		}

		private void imageXView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			isMouseDrawing = true;
			if (isDrawingWithPen)
			{
				LastDrawPoint.X = e.X;
				LastDrawPoint.Y = e.Y;
				LastDrawPoint = imageXView1.Translate(LastDrawPoint,Accusoft.ImagXpressSdk.TranslateType.ViewToPixel);
			}
		}

		private void imageXView1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			isMouseDrawing = false;
		}

		private void buttonPen_Click(object sender, System.EventArgs e)
		{
			isDrawingWithPen = !isDrawingWithPen;
			buttonPen.Text = isDrawingWithPen?"Disable Mouse Drawing":"Enable Mouse Drawing";
		}

		private void imageXView1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            if (isDrawingWithPen && isMouseDrawing)
            {
                PointF drawPoint = imageXView1.Translate(new System.Drawing.Point(e.X, e.Y), Accusoft.ImagXpressSdk.TranslateType.ViewToPixel);
                if (drawPoint.X >= 0 && drawPoint.Y >= 0)
                {
                    System.Drawing.Graphics g = imageXView1.Image.GetGraphics();
                    g.DrawLine(System.Drawing.Pens.Black, LastDrawPoint, drawPoint);
                    g.Flush();
                    imageXView1.Image.ReleaseGraphics(true);
                    LastDrawPoint = drawPoint;
                }
            }
		}

		private void menuToolbarShow_Click(object sender, System.EventArgs e)
		{
			this.menuToolbarShow.Text = (imageXView1.Toolbar.Activated) ? "&Show":"&Hide";
			try 
			{
				imageXView1.Toolbar.Activated = !imageXView1.Toolbar.Activated;
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException eX) 
			{
				AccusoftError(eX,labelError);
			}
		}

		private void menuFileQuit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuAbout_Click(object sender, System.EventArgs e)
		{
			imagXpress1.AboutBox();
		}
	}
}
