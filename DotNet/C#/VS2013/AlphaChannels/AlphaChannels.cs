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

namespace Alpha_Channels
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        private System.Windows.Forms.Label AlphaLabel1;
		private System.Windows.Forms.Label SourceLabel;
		private System.Windows.Forms.ListBox DescriptionListBox;
        private System.Windows.Forms.Button BlendButton;
		private System.Windows.Forms.ComboBox AlphaComboBox;
		private System.Windows.Forms.MenuItem FileMenu;
		private System.Windows.Forms.MenuItem OpenSourceMenuItem;
		private System.Windows.Forms.MenuItem OpenAlphaMenuItem;
		private System.Windows.Forms.MenuItem ExitMenuItem;
		private System.Windows.Forms.MenuItem ToolbarMenu;
		private System.Windows.Forms.MenuItem ShowMenuItem;
		private System.Windows.Forms.MenuItem AboutMenu;
		private System.Windows.Forms.MenuItem ImagXpressMenuItem;
		private System.Windows.Forms.MenuItem FileMenuSeparator;
		private System.Windows.Forms.MainMenu MainMenu;

		private Accusoft.ImagXpressSdk.Processor ixproc1;

        private System.Globalization.NumberFormatInfo cultNumber = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
		private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ImagXpress imagXpress1;
        private ImageXView imageXView1;
        private ImagXpress imagXpress2;
        private ImageXView imageXView2;
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
            this.AlphaLabel1 = new System.Windows.Forms.Label();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.DescriptionListBox = new System.Windows.Forms.ListBox();
            this.BlendButton = new System.Windows.Forms.Button();
            this.AlphaComboBox = new System.Windows.Forms.ComboBox();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.FileMenu = new System.Windows.Forms.MenuItem();
            this.OpenSourceMenuItem = new System.Windows.Forms.MenuItem();
            this.OpenAlphaMenuItem = new System.Windows.Forms.MenuItem();
            this.FileMenuSeparator = new System.Windows.Forms.MenuItem();
            this.ExitMenuItem = new System.Windows.Forms.MenuItem();
            this.ToolbarMenu = new System.Windows.Forms.MenuItem();
            this.ShowMenuItem = new System.Windows.Forms.MenuItem();
            this.AboutMenu = new System.Windows.Forms.MenuItem();
            this.ImagXpressMenuItem = new System.Windows.Forms.MenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.imagXpress2 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView2 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlphaLabel1
            // 
            this.AlphaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlphaLabel1.Location = new System.Drawing.Point(20, 154);
            this.AlphaLabel1.Name = "AlphaLabel1";
            this.AlphaLabel1.Size = new System.Drawing.Size(157, 16);
            this.AlphaLabel1.TabIndex = 0;
            this.AlphaLabel1.Text = "Alpha Channel Image";
            this.AlphaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SourceLabel
            // 
            this.SourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceLabel.Location = new System.Drawing.Point(213, 152);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(423, 18);
            this.SourceLabel.TabIndex = 4;
            this.SourceLabel.Text = "Source Image";
            this.SourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionListBox
            // 
            this.DescriptionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionListBox.Items.AddRange(new object[] {
            "This sample demonstrates the following functionality:",
            "Merging an image with an alpha channel to a source image and displaying the combi" +
                "ned image. ",
            "",
            "You can select an Alpha Channel image in the dropdown list or load your own sourc" +
                "e image and/or ",
            "your own Alpha Channel image in the sample."});
            this.DescriptionListBox.Location = new System.Drawing.Point(8, 8);
            this.DescriptionListBox.Name = "DescriptionListBox";
            this.DescriptionListBox.Size = new System.Drawing.Size(692, 69);
            this.DescriptionListBox.TabIndex = 5;
            // 
            // BlendButton
            // 
            this.BlendButton.Location = new System.Drawing.Point(213, 104);
            this.BlendButton.Name = "BlendButton";
            this.BlendButton.Size = new System.Drawing.Size(255, 32);
            this.BlendButton.TabIndex = 6;
            this.BlendButton.Text = "Blend Alpha Channel Image with Source Image";
            this.BlendButton.Click += new System.EventHandler(this.BlendButton_Click);
            // 
            // AlphaComboBox
            // 
            this.AlphaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlphaComboBox.Items.AddRange(new object[] {
            "AlphaImage1",
            "AlphaImage2",
            "AlphaImage3"});
            this.AlphaComboBox.Location = new System.Drawing.Point(23, 104);
            this.AlphaComboBox.Name = "AlphaComboBox";
            this.AlphaComboBox.Size = new System.Drawing.Size(144, 21);
            this.AlphaComboBox.TabIndex = 8;
            this.AlphaComboBox.SelectedIndexChanged += new System.EventHandler(this.AlphaComboBox_SelectedIndexChanged);
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileMenu,
            this.ToolbarMenu,
            this.AboutMenu});
            // 
            // FileMenu
            // 
            this.FileMenu.Index = 0;
            this.FileMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.OpenSourceMenuItem,
            this.OpenAlphaMenuItem,
            this.FileMenuSeparator,
            this.ExitMenuItem});
            this.FileMenu.Text = "&File";
            // 
            // OpenSourceMenuItem
            // 
            this.OpenSourceMenuItem.Index = 0;
            this.OpenSourceMenuItem.Text = "&Open Source Image";
            this.OpenSourceMenuItem.Click += new System.EventHandler(this.OpenSourceMenuItem_Click);
            // 
            // OpenAlphaMenuItem
            // 
            this.OpenAlphaMenuItem.Index = 1;
            this.OpenAlphaMenuItem.Text = "&Open Alpha Channel Image";
            this.OpenAlphaMenuItem.Click += new System.EventHandler(this.OpenAlphaMenuItem_Click);
            // 
            // FileMenuSeparator
            // 
            this.FileMenuSeparator.Index = 2;
            this.FileMenuSeparator.Text = "-";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Index = 3;
            this.ExitMenuItem.Text = "E&xit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // ToolbarMenu
            // 
            this.ToolbarMenu.Index = 1;
            this.ToolbarMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ShowMenuItem});
            this.ToolbarMenu.Text = "&Toolbar";
            // 
            // ShowMenuItem
            // 
            this.ShowMenuItem.Index = 0;
            this.ShowMenuItem.Text = "&Show";
            this.ShowMenuItem.Click += new System.EventHandler(this.ShowMenuItem_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Index = 2;
            this.AboutMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ImagXpressMenuItem});
            this.AboutMenu.Text = "&About";
            // 
            // ImagXpressMenuItem
            // 
            this.ImagXpressMenuItem.Index = 0;
            this.ImagXpressMenuItem.Text = "Imag&Xpress";
            this.ImagXpressMenuItem.Click += new System.EventHandler(this.ImagXpressMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(714, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(22, 17);
            this.statusLabel.Text = "Ok";
            // 
            // imageXView1
            // 
            this.imageXView1.Location = new System.Drawing.Point(199, 182);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(501, 344);
            this.imageXView1.TabIndex = 12;
            // 
            // imageXView2
            // 
            this.imageXView2.Location = new System.Drawing.Point(22, 182);
            this.imageXView2.Name = "imageXView2";
            this.imageXView2.Size = new System.Drawing.Size(155, 344);
            this.imageXView2.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(714, 551);
            this.Controls.Add(this.imageXView2);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.AlphaComboBox);
            this.Controls.Add(this.BlendButton);
            this.Controls.Add(this.DescriptionListBox);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.AlphaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 600);
            this.Menu = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(720, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alpha Channels";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        #region Accusoft Sample Application Standard Functions
        /*********************************************************************
		 *     Accusoft Corporation Standard Function Definitions     *
		 *********************************************************************/

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
                iTmp = Convert.ToInt32(textTextBox.Text, cultNumber);
            }
            catch (System.NullReferenceException ex)
            {
                AccusoftError(ex, statusLabel);
                textTextBox.Text = scrScroll.Value.ToString(cultNumber);
                return;
            }
            catch (System.Exception ex)
            {
                AccusoftError(ex, statusLabel);
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

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new MainForm());
		}

		private void ImagXpressMenuItem_Click(object sender, System.EventArgs e)
		{
			imagXpress1.AboutBox();
		}

		private void ExitMenuItem_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
        
        private void ResetStatus( )
        {
            statusLabel.Text = "Ok";
        }

        private void SetStatus(ImagXpressException ex)
        {
            SetStatus(ex.Message + "\n" + ex.Source + "\n" + "Error Number: " + ex.Number.ToString());
        }

        private void SetStatus(string status)
        {
            statusLabel.Text = status;
        }

		private void ShowMenuItem_Click(object sender, System.EventArgs e)
		{
			if (ShowMenuItem.Checked == false)
			{
				imageXView1.Toolbar.Activated = true;
				ShowMenuItem.Checked = true;
			}
			else
			{
				imageXView1.Toolbar.Activated = false;
				ShowMenuItem.Checked = false;
			}
		}

		private void MainForm_Load(object sender, System.EventArgs e)
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

	        // turn on AlphaBlend in the view that displays the image with the alpha channel
			imageXView2.AlphaBlend = true;


			ixproc1 = new Accusoft.ImagXpressSdk.Processor(imagXpress1);
			AlphaComboBox.SelectedIndex = 0;

            String strCurrentDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");
            if (System.IO.Directory.Exists(strCurrentDir))
                System.IO.Directory.SetCurrentDirectory(strCurrentDir);
            strCurrentDir = System.IO.Directory.GetCurrentDirectory();

            String strCurrentImage = System.IO.Path.Combine(strCurrentDir, "Alpha1.tif");
            imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strCurrentImage);

			try
			{
                String strCurrentAlphaImage = System.IO.Path.Combine(strCurrentDir, "Alpha1.jpg");
                imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strCurrentAlphaImage);
				ixproc1.Image = imageXView1.Image;
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
			{
                SetStatus( ex );              
			}	 
		}

		private void BlendButton_Click(object sender, System.EventArgs e)
		{
			try
			{
                ResetStatus();
				Accusoft.ImagXpressSdk.ImageX alphaImage = imageXView2.Image.Copy();

                // Set an arbitrary location to merge the image into
                PointF pt = GetAlphaImageLocation( );
                SizeF size = new SizeF( alphaImage.ImageXData.Width, alphaImage.ImageXData.Height );
                ixproc1.SetArea(new RectangleF(pt, size));
                ixproc1.EnableArea = true;

				ixproc1.Merge(ref alphaImage, Accusoft.ImagXpressSdk.MergeSize.Crop, Accusoft.ImagXpressSdk.MergeStyle.AlphaForeGroundOverBackGround, false, System.Drawing.Color.Blue, 90, 90);
				if (alphaImage != null)
				{
					alphaImage.Dispose();
					alphaImage = null;
				}
				ixproc1.EnableArea = false;
                SetStatus("Image successfully blended!");
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
			{
				SetStatus( ex );
			}
		}

        private PointF GetAlphaImageLocation( )
        {
            PointF pt = PointF.Empty;
            switch (AlphaComboBox.SelectedIndex)
            {
                case 0:
                    pt = new PointF( 100, 50 );
                    break;
                case 1:
                    pt = new PointF( 0, 25 );
                    break;
                case 2:
                    pt = new PointF( 500, 200 );
                    break;
            }
            return pt;
        }

		private void AlphaComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            ResetStatus();

            try
            {
                switch (AlphaComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, Application.StartupPath + "..\\..\\..\\..\\..\\..\\..\\..\\..\\..\\..\\Common\\Images\\Alpha1.tif");
                            break;
                        }
                    case 1:
                        {
                            imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, Application.StartupPath + "..\\..\\..\\..\\..\\..\\..\\..\\..\\..\\..\\Common\\Images\\Alpha2.tif");
                            break;
                        }
                    case 2:
                        {
                            imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, Application.StartupPath + "..\\..\\..\\..\\..\\..\\..\\..\\..\\..\\..\\Common\\Images\\Alpha3.tif");
                            break;
                        }
                }
            }
            catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
            {
                SetStatus( ex );
            }
		}

		private void OpenSourceMenuItem_Click(object sender, System.EventArgs e)
		{
			string sFileName = AccusoftOpenFile();
            if (sFileName.Length != 0)
            {
                try
                {
                    if (imageXView1.Image != null)
                        imageXView1.Image.Dispose();
                    imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, sFileName);
                    ixproc1.Image = imageXView1.Image;
                    ResetStatus();
                }
                catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
                {
                    SetStatus(ex);
                }
            }
		}

		private void OpenAlphaMenuItem_Click(object sender, System.EventArgs e)
		{
            string aFileName = AccusoftOpenFile();
            if (aFileName.Length != 0)
            {
                try
                {
                    if (imageXView2.Image != null)
                        imageXView2.Image.Dispose();
                    imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, aFileName);
                    ResetStatus();
                }
                catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
                {
                    SetStatus(ex);
                }
            }
		}
	}
}
