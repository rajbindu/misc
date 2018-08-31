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

namespace Print
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
    {
		private System.Windows.Forms.ListBox DescriptionListBox;
		private System.Windows.Forms.Label ErrorLabel2;
		private System.Windows.Forms.Label ErrorLabel;
		private System.Windows.Forms.MainMenu MainMenu;
		private System.Windows.Forms.Button PrintButton1;
		private System.Windows.Forms.MenuItem FileMenu;
		private System.Windows.Forms.MenuItem OpenMenuItem;
		private System.Windows.Forms.MenuItem ExitMenuItem;
		private System.Windows.Forms.MenuItem ToolbarMenu;
		private System.Windows.Forms.MenuItem ShowMenuItem;
		private System.Windows.Forms.MenuItem AboutMenu;
		private System.Windows.Forms.MenuItem ImagXpressMenuItem;
		private System.Windows.Forms.Button PrintButton2;
		private System.Windows.Forms.Button PrintButton3;

		// enumeration for telling the sample which type of document to print
		enum SamplePrintType
		{
			Centered,
			TwoBy,
			FullPage
		};

		private SamplePrintType samplePrintType = SamplePrintType.Centered;

		// Declare the dialog.
		private PrintPreviewDialog printPreviewDialog;

		// Declare a PrintDocument object named document.
		private System.Drawing.Printing.PrintDocument document;
        private ImagXpress imagXpress1;
        private ImageXView imageXView1;

		private IContainer components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DescriptionListBox = new System.Windows.Forms.ListBox();
            this.ErrorLabel2 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.FileMenu = new System.Windows.Forms.MenuItem();
            this.OpenMenuItem = new System.Windows.Forms.MenuItem();
            this.ExitMenuItem = new System.Windows.Forms.MenuItem();
            this.ToolbarMenu = new System.Windows.Forms.MenuItem();
            this.ShowMenuItem = new System.Windows.Forms.MenuItem();
            this.AboutMenu = new System.Windows.Forms.MenuItem();
            this.ImagXpressMenuItem = new System.Windows.Forms.MenuItem();
            this.PrintButton1 = new System.Windows.Forms.Button();
            this.PrintButton2 = new System.Windows.Forms.Button();
            this.PrintButton3 = new System.Windows.Forms.Button();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.SuspendLayout();
            // 
            // DescriptionListBox
            // 
            this.DescriptionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionListBox.Items.AddRange(new object[] {
            "This sample demonstrates the following functionality:",
            "1) Printing an image with ImagXpress."});
            this.DescriptionListBox.Location = new System.Drawing.Point(8, 8);
            this.DescriptionListBox.Name = "DescriptionListBox";
            this.DescriptionListBox.Size = new System.Drawing.Size(680, 43);
            this.DescriptionListBox.TabIndex = 1;
            // 
            // ErrorLabel2
            // 
            this.ErrorLabel2.Location = new System.Drawing.Point(357, 465);
            this.ErrorLabel2.Name = "ErrorLabel2";
            this.ErrorLabel2.Size = new System.Drawing.Size(80, 16);
            this.ErrorLabel2.TabIndex = 4;
            this.ErrorLabel2.Text = "Last Error:";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.Location = new System.Drawing.Point(357, 502);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(328, 49);
            this.ErrorLabel.TabIndex = 5;
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
            this.OpenMenuItem,
            this.ExitMenuItem});
            this.FileMenu.Text = "&File";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Index = 0;
            this.OpenMenuItem.Text = "&Open";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Index = 1;
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
            // PrintButton1
            // 
            this.PrintButton1.Location = new System.Drawing.Point(80, 432);
            this.PrintButton1.Name = "PrintButton1";
            this.PrintButton1.Size = new System.Drawing.Size(200, 32);
            this.PrintButton1.TabIndex = 6;
            this.PrintButton1.Text = "Print Image Centered on Page";
            this.PrintButton1.Click += new System.EventHandler(this.PrintButton1_Click);
            // 
            // PrintButton2
            // 
            this.PrintButton2.Location = new System.Drawing.Point(80, 480);
            this.PrintButton2.Name = "PrintButton2";
            this.PrintButton2.Size = new System.Drawing.Size(200, 32);
            this.PrintButton2.TabIndex = 7;
            this.PrintButton2.Text = "Print 2 Images Centered on Page";
            this.PrintButton2.Click += new System.EventHandler(this.PrintButton2_Click);
            // 
            // PrintButton3
            // 
            this.PrintButton3.Location = new System.Drawing.Point(80, 528);
            this.PrintButton3.Name = "PrintButton3";
            this.PrintButton3.Size = new System.Drawing.Size(200, 32);
            this.PrintButton3.TabIndex = 8;
            this.PrintButton3.Text = "Print Image Fit to Page";
            this.PrintButton3.Click += new System.EventHandler(this.PrintButton3_Click);
            // 
            // imageXView1
            // 
            this.imageXView1.Location = new System.Drawing.Point(8, 58);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(676, 368);
            this.imageXView1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(696, 579);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.PrintButton3);
            this.Controls.Add(this.PrintButton2);
            this.Controls.Add(this.PrintButton1);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ErrorLabel2);
            this.Controls.Add(this.DescriptionListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.MainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.MainForm_Load);
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

			// Set the current directory to the Common\Images directory
			String strCurrentDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");
			if (System.IO.Directory.Exists(strCurrentDir))
				System.IO.Directory.SetCurrentDirectory(strCurrentDir);
			strCurrentDir = System.IO.Directory.GetCurrentDirectory();

			// Initialize the Print Preview Dialog
			InitializePrintPreviewDialog();

			try
			{
				String filename = "vermont.jpg";
				if (System.IO.File.Exists(filename))
					imageXView1.Image = ImageX.FromFile(imagXpress1, filename);
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
			{
				ErrorLabel.Text = ex.Message;
			}
			finally
			{
				EnablePrintButtons(imageXView1.Image != null);
			}
		}

		private void ImagXpressMenuItem_Click(object sender, System.EventArgs e)
		{
			imagXpress1.AboutBox();
		}

		private void ExitMenuItem_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
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

		private void OpenMenuItem_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
			dlg.Filter = "All files(*.*)|*.*";
			dlg.FilterIndex = 0;
			dlg.Title = "Open Image";

			dlg.ShowDialog();

			if (dlg.FileName != "")
			{
				try
				{
					if (imageXView1.Image != null)
					{
						imageXView1.Image.Dispose();
						imageXView1.Image = null;
					}
					imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, dlg.FileName);
				}
				catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
				{
					ErrorLabel.Text = ex.Message;
				}
				finally
				{
					EnablePrintButtons(imageXView1.Image != null);
				}
			}
		}

		private void EnablePrintButtons(bool enable)
		{
			this.PrintButton1.Enabled = enable;
			this.PrintButton2.Enabled = enable;
			this.PrintButton3.Enabled = enable;
		}

		// Initalize the Print Preview dialog.
		private void InitializePrintPreviewDialog()
		{
			// Create a new PrintPreviewDialog using constructor.
			this.printPreviewDialog = new PrintPreviewDialog();

			// Create a new Document
			this.document = new System.Drawing.Printing.PrintDocument();

			//Set the size, location, and name.
			this.printPreviewDialog.ClientSize = new System.Drawing.Size(480, 320);
			this.printPreviewDialog.Location = new System.Drawing.Point(100, 100);
			this.printPreviewDialog.Name = "PrintPreviewDialog";

			// Associate the event-handling method with the 
			// document's PrintPage event.
			this.document.PrintPage +=
				new System.Drawing.Printing.PrintPageEventHandler
				(document_PrintPage);

			// Set the minimum size the dialog can be resized to.
			this.printPreviewDialog.MinimumSize =
				new System.Drawing.Size(375, 250);

			// Set the UseAntiAlias property to true, which will allow the 
			// operating system to smooth fonts.
			this.printPreviewDialog.UseAntiAlias = true;
		}

		private void PrintButton1_Click(object sender, System.EventArgs e)
		{
			try
			{
				PrintPreview(SamplePrintType.Centered, "Centered Image");
			}
			catch (Exception ex)
			{
				ErrorLabel.Text = ex.Message;
			}
		}

		private void PrintButton2_Click(object sender, System.EventArgs e)
		{
			try
			{
				PrintPreview(SamplePrintType.TwoBy, "Two Images");
			}
			catch (Exception ex)
			{
				ErrorLabel.Text = ex.Message;
			}
		}

		private void PrintButton3_Click(object sender, System.EventArgs e)
		{
			try
			{
				PrintPreview(SamplePrintType.FullPage, "Full Page");
			}
			catch (Exception ex)
			{
				ErrorLabel.Text = ex.Message;
			}
		}

		private void PrintPreview(SamplePrintType printType, String documentName)
		{
			this.samplePrintType = printType;
			document.DocumentName = documentName;
			this.printPreviewDialog.Document = this.document;

			// Call the ShowDialog method. This will trigger the document's
			//  PrintPage event.
			this.printPreviewDialog.ShowDialog(this);
		}

		private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			// This code will be called when the PrintPreviewDialog.Show method is called
			// and when the document is sent to the printer
			
			bool isPreview = this.document.PrintController.IsPreview;
			// Draw the image, call a helper routine
			HelperPrint(e.Graphics, this.samplePrintType, isPreview, e.PageSettings.PrintableArea);
		}

		private void HelperPrint(Graphics g, SamplePrintType printType, bool isPreview, RectangleF printerArea)
		{
			float width = (float)imageXView1.Image.ImageXData.Width;
			float height = (float)imageXView1.Image.ImageXData.Height;

			imageXView1.Image.ImageXData.Resolution.Units = GraphicsUnit.Inch;

			double resx = Math.Round(imageXView1.Image.ImageXData.Resolution.Dimensions.Width);
			double resy = Math.Round(imageXView1.Image.ImageXData.Resolution.Dimensions.Height);

			// Printable area for printers is in 1/100th of an inch, convert to inches
			printerArea.X /= 100;
			printerArea.Y /= 100;
			printerArea.Width /= 100;
			printerArea.Height /= 100;

			// put the graphics into inches for convenience
			g.PageUnit = GraphicsUnit.Inch;

			// put width and height of image in terms of inches
			width = (float)(width / resx);
			height = (float)(height / resy);

			// default to upper right
			float x = 0.0f;
			float y = 0.0f;
			float interSpacing = 0.25f; // spacing between images
			float topBottomSpacing = 0.0f; // spacing before first image and after second image
			float scaleFactor = 1.0f;
			float oldValue = 0.0f;

			// keep the preview looking similiar to the hardcopy
			if (isPreview)
			{
				x = printerArea.X;
				y = printerArea.Y;
			}

			switch (printType)
			{
				case SamplePrintType.Centered:
					// allow for larger images, let both checks happen, may need to scale in both directions 
					if ( height > printerArea.Height )
					{
						oldValue = height;
						height = printerArea.Height;
						scaleFactor = height / oldValue;
						width *= scaleFactor;
					}

					if ( width > printerArea.Width )
					{
						oldValue = width;
						width = printerArea.Width;
						scaleFactor = width / oldValue;
						height *= scaleFactor;
					}

					x += (printerArea.Width - width) / 2;
					y += (printerArea.Height - height) / 2;

					imageXView1.Print(g, new RectangleF(x, y, width, height));
					break;

				case SamplePrintType.TwoBy:
					// trying to keep this simple, but allow for large images
					if (((height * 2) + interSpacing) > printerArea.Height)
					{
						oldValue = height;
						height = (printerArea.Height / 2) - (interSpacing / 2);
						scaleFactor = height / oldValue;
						width *= scaleFactor;
					}

					if (width > printerArea.Width)
					{
						oldValue = width;
						width = printerArea.Width;
						scaleFactor = width / oldValue;
						height *= scaleFactor;
					}

					interSpacing = (float)(printerArea.Height - (height * 2));
					if (interSpacing >= 0.25f * 3)
					{
						interSpacing /= 3;
						topBottomSpacing = interSpacing;
					}
					else
					{
						topBottomSpacing = (interSpacing - 0.25f) / 2;
						if (topBottomSpacing < 0)
							topBottomSpacing = 0;
						interSpacing = 0.25f;
					}

					x += (printerArea.Width - width ) / 2;
					y += topBottomSpacing;

					imageXView1.Print(g, new RectangleF(x, y, width, height));

					y += (height + interSpacing);
					imageXView1.Print(g, new RectangleF(x, y, width, height));
					break;

				case SamplePrintType.FullPage:
					imageXView1.Print(g, new RectangleF(x, y, printerArea.Width, printerArea.Height));
					break;
			}

		}
	}
}
