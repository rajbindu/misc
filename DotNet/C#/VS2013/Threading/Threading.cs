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
using System.Runtime.InteropServices; // DllImport

namespace Threading
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	/// 
	public class MainForm : System.Windows.Forms.Form
	{
		const int LABEL_WIDTH=145;
		const int LABEL_HEIGHT=15;
		const int VIEWER_WIDTH=145;
		const int VIEWER_HEIGHT=100;
		const int VIEWER_SPACING=10;

		const int IMAGE1_WIDTH=408;
		const int IMAGE1_HEIGHT=280;
		const int IMAGE2_WIDTH=320;
		const int IMAGE2_HEIGHT=240;
		private System.Windows.Forms.Button cmdLoadResize;
		private System.Windows.Forms.CheckBox chkAsync;
		private System.Windows.Forms.ComboBox cmbThreadPriority;
		private System.Windows.Forms.Label threadPriorityLabel;
		private System.String strImage1 = "window.jpg";
		private System.String strImage2 = "vermont.jpg";
        private System.Windows.Forms.Label[] viewerLabel;
		private Accusoft.ImagXpressSdk.ImageXView[] ixViewer;
		private int ViewerNum;
		private System.Windows.Forms.ListBox lstView;
		private System.Threading.Thread[] myThreads = new System.Threading.Thread[6];
		private System.Windows.Forms.MainMenu mnuFile;
		private System.Windows.Forms.MenuItem mnuFileFile;
		private System.Windows.Forms.MenuItem mnuFileOpen;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem mnuFileQuit;
		private System.Windows.Forms.RichTextBox lblInfo;
		private System.Windows.Forms.MenuItem mnuToolbar;
		private System.Windows.Forms.MenuItem mnuAbout;
		private System.Windows.Forms.MenuItem mnuToolbarShow;
		private System.Windows.Forms.Label lblLastError;
        private System.Windows.Forms.Label lblError;
        private ImagXpress imagXpress1;
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
			viewerLabel = new System.Windows.Forms.Label[6];
			try 
			{
				ixViewer = new Accusoft.ImagXpressSdk.ImageXView[6];
			}
			catch (ImagXpressException eX) 
			{
				AccusoftError(eX,lblError);
			}
			int x = 17, y = 190;
			int i;
			for (i = 0; i < 6; i++)
			{
				try
				{
					viewerLabel[i] = new System.Windows.Forms.Label();
					viewerLabel[i].Parent = this;
					viewerLabel[i].Left = x;
					viewerLabel[i].Top = y;
					viewerLabel[i].Width = LABEL_WIDTH;
					viewerLabel[i].Height = LABEL_HEIGHT;
					viewerLabel[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
					viewerLabel[i].Text = i.ToString();

					ixViewer[i] = new Accusoft.ImagXpressSdk.ImageXView(this.Container, imagXpress1);
					ixViewer[i].Parent = this;
					ixViewer[i].Left = x;
					ixViewer[i].Top = y + LABEL_HEIGHT;
					ixViewer[i].Width = VIEWER_WIDTH;
					ixViewer[i].Height = VIEWER_HEIGHT;

					// Because in this sample the ImageX object is always located in the ImageXView
					// tell the ImageXView component to dispose of the ImageX object when itself is
					// disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
					// Dispose method before the components.Dispose() section.
					ixViewer[i].AutoImageDispose = true;

				}
				catch (ImagXpressException eX) 
				{
					AccusoftError(eX,lblError);
				}

				x += VIEWER_WIDTH + VIEWER_SPACING;
				if ( x > (( VIEWER_WIDTH + VIEWER_SPACING ) * 3 ) + VIEWER_SPACING )
				{
					y += VIEWER_HEIGHT + LABEL_HEIGHT + VIEWER_SPACING;
					x = 17;
				}
			}
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
            this.cmdLoadResize = new System.Windows.Forms.Button();
            this.chkAsync = new System.Windows.Forms.CheckBox();
            this.cmbThreadPriority = new System.Windows.Forms.ComboBox();
            this.threadPriorityLabel = new System.Windows.Forms.Label();
            this.lstView = new System.Windows.Forms.ListBox();
            this.mnuFile = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFileFile = new System.Windows.Forms.MenuItem();
            this.mnuFileOpen = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuFileQuit = new System.Windows.Forms.MenuItem();
            this.mnuToolbar = new System.Windows.Forms.MenuItem();
            this.mnuToolbarShow = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.lblInfo = new System.Windows.Forms.RichTextBox();
            this.lblLastError = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.SuspendLayout();
            // 
            // cmdLoadResize
            // 
            this.cmdLoadResize.Location = new System.Drawing.Point(16, 136);
            this.cmdLoadResize.Name = "cmdLoadResize";
            this.cmdLoadResize.Size = new System.Drawing.Size(160, 32);
            this.cmdLoadResize.TabIndex = 1;
            this.cmdLoadResize.Text = "Load and Resize 2 Images";
            this.cmdLoadResize.Click += new System.EventHandler(this.cmdLoadResize_Click);
            // 
            // chkAsync
            // 
            this.chkAsync.Checked = true;
            this.chkAsync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAsync.Location = new System.Drawing.Point(192, 136);
            this.chkAsync.Name = "chkAsync";
            this.chkAsync.Size = new System.Drawing.Size(168, 32);
            this.chkAsync.TabIndex = 2;
            this.chkAsync.Text = "Async Processing Enabled";
            this.chkAsync.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbThreadPriority
            // 
            this.cmbThreadPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThreadPriority.Items.AddRange(new object[] {
            "Lowest",
            "BelowNormal",
            "Normal",
            "AboveNormal",
            "Highest"});
            this.cmbThreadPriority.Location = new System.Drawing.Point(368, 144);
            this.cmbThreadPriority.Name = "cmbThreadPriority";
            this.cmbThreadPriority.Size = new System.Drawing.Size(104, 21);
            this.cmbThreadPriority.TabIndex = 4;
            // 
            // threadPriorityLabel
            // 
            this.threadPriorityLabel.Location = new System.Drawing.Point(368, 128);
            this.threadPriorityLabel.Name = "threadPriorityLabel";
            this.threadPriorityLabel.Size = new System.Drawing.Size(104, 16);
            this.threadPriorityLabel.TabIndex = 5;
            this.threadPriorityLabel.Text = "Thread Priority:";
            this.threadPriorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstView
            // 
            this.lstView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstView.Location = new System.Drawing.Point(16, 448);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(456, 95);
            this.lstView.TabIndex = 10;
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
            this.mnuFileOpen.Text = "&Open Two Images";
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
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(16, 8);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.ReadOnly = true;
            this.lblInfo.Size = new System.Drawing.Size(456, 112);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // lblLastError
            // 
            this.lblLastError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLastError.Location = new System.Drawing.Point(16, 544);
            this.lblLastError.Name = "lblLastError";
            this.lblLastError.Size = new System.Drawing.Size(64, 16);
            this.lblLastError.TabIndex = 12;
            this.lblLastError.Text = "Last Error:";
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Location = new System.Drawing.Point(80, 544);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(384, 16);
            this.lblError.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(488, 571);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblLastError);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.threadPriorityLabel);
            this.Controls.Add(this.cmbThreadPriority);
            this.Controls.Add(this.chkAsync);
            this.Controls.Add(this.cmdLoadResize);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mnuFile;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Threading";
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
			Application.Run(new Threading.MainForm());
		}

		private void cmdLoadResize_Click(object sender, System.EventArgs e)
		{
			int newViewNum = GetViewerNum();
			ProcessorThread newProc1 = new ProcessorThread(strImage1,ixViewer[newViewNum], viewerLabel[newViewNum], 3, imagXpress1);
			System.Threading.Thread trd1 = new System.Threading.Thread(new System.Threading.ThreadStart(newProc1.Process));
			trd1.IsBackground = chkAsync.Checked;
			trd1.Priority = GetPriority();
			trd1.Start();

			newViewNum = GetViewerNum();
			ProcessorThread newProc2 = new ProcessorThread(strImage2, ixViewer[newViewNum], viewerLabel[newViewNum], 5, imagXpress1);
			System.Threading.Thread trd2 = new System.Threading.Thread(new System.Threading.ThreadStart(newProc2.Process));
			trd2.IsBackground = chkAsync.Checked;
			trd2.Priority = GetPriority();
			trd2.Start();
		}

		private void cmdQuit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private System.Threading.ThreadPriority GetPriority()
		{
			switch (cmbThreadPriority.SelectedIndex)
			{
				case 0: return System.Threading.ThreadPriority.Lowest; 
				case 1: return System.Threading.ThreadPriority.BelowNormal;
				case 2: return System.Threading.ThreadPriority.Normal;
				case 3: return System.Threading.ThreadPriority.AboveNormal;
				case 4: return System.Threading.ThreadPriority.Highest;
				default: return System.Threading.ThreadPriority.Normal;
			}
		}

		private void FormMain_Load(object sender, System.EventArgs e)
		{

			//***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
			//imagXpress1.Licensing.SetSolutionName("YourSolutionName");
			//imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345);
			//imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�");

			// Set the current directory to the Common\Images directory
			String strCurrentDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");
			if (System.IO.Directory.Exists(strCurrentDir))
				System.IO.Directory.SetCurrentDirectory(strCurrentDir);
			strCurrentDir = System.IO.Directory.GetCurrentDirectory();

			cmbThreadPriority.SelectedIndex = 2;
		}

		private void lstViewThreadSafeTextAdder(string text)
        {
            lstView.Items.Add(text);
			lstView.SelectedIndex = lstView.Items.Count - 1;
        }

        private delegate void controlTextModifier(string text);

		private void ImageStatusEventHandler(object sender, Accusoft.ImagXpressSdk.ImageStatusEventArgs e) 
		{
            if (lstView.InvokeRequired)
            {
                object[] theparams = {e.Status.ToString()};
				controlTextModifier theListViewModder = new controlTextModifier(lstViewThreadSafeTextAdder);
                lstView.Invoke(theListViewModder , theparams);
            }
            else
            {
                lstView.Items.Add(e.Status.ToString());
            }
			
		}

		private void ProgressEventHandler(object sender, Accusoft.ImagXpressSdk.ProgressEventArgs e) 
		{
			if (lstView.InvokeRequired)
			{
				object[] theArgs = {e.PercentDone.ToString(cultNumber) + "% Loading Complete."};
				lstView.Invoke(new controlTextModifier(this.lstViewThreadSafeTextAdder),theArgs);
				if (e.IsComplete)
				{
					theArgs[0] = e.TotalBytes + " Bytes Completed Loading.";
					lstView.Invoke(new controlTextModifier(this.lstViewThreadSafeTextAdder),theArgs);
				}
			} 
			else 
			{
				lstView.Items.Add(e.PercentDone.ToString(cultNumber) + "% Loading Complete.");
				if (e.IsComplete) 
				{
					lstView.Items.Add(e.TotalBytes + " Bytes Completed Loading.");
				}
				lstView.SelectedIndex = lstView.Items.Count - 1;
			}
		}

		private int GetViewerNum()
		{
			ViewerNum++;
			if (ViewerNum > 5)
			{
				ViewerNum = 0;
				return 5;
			} 
			else 
			{
				return ViewerNum-1;
			}
		}

		private void mnuFileOpen_Click(object sender, System.EventArgs e)
		{
			System.String tmp = AccusoftOpenFile();
			if (tmp.Length != 0) 
			{
				strImage1 = tmp;
			}
			tmp = AccusoftOpenFile();
			if (tmp.Length != 0) 
			{
				strImage2 = tmp;
			}
		}

		private void mnuFileQuit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
	
		private void mnuToolbarShow_Click(object sender, System.EventArgs e)
		{
			this.mnuToolbarShow.Text = (ixViewer[0].Toolbar.Activated) ? "&Show":"&Hide";
			try 
			{
				for (int i = 0; i < 6; i++)
				{
					ixViewer[i].Toolbar.Activated = !ixViewer[i].Toolbar.Activated;
					System.IntPtr hWndTB = ixViewer[i].Toolbar.Hwnd;
					Win32.SetWindowText(hWndTB.ToInt32(), "Toolbar " + i.ToString());
				}
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

    public class Win32
    {
        [DllImport("User32.Dll")]
        public static extern void SetWindowText(int hWnd, String text);
    }
}
