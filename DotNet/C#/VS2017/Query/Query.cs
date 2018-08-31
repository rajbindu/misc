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

namespace Query
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Query : System.Windows.Forms.Form
    {
		private System.Windows.Forms.Label ErrorLabel2;
		private System.Windows.Forms.Label ErrorLabel;
		private System.Windows.Forms.ListBox ResultsListBox;
		private System.Windows.Forms.Button QueryButton;
		private System.Windows.Forms.ListBox DescriptionListBox;
		private System.Windows.Forms.MainMenu MainMenu;
		private System.Windows.Forms.MenuItem FileMenu;
		private System.Windows.Forms.MenuItem OpenMenuItem;
		private System.Windows.Forms.MenuItem ExitMenuItem;
		private System.Windows.Forms.MenuItem AboutMenu;
		private System.Windows.Forms.MenuItem ImagXpressMenuItem;
		private string filename;
		private Button queryBufferButton;
		private Button queryFromStreamButton;
        private ImagXpress imagXpress1;
		private IContainer components;

		public Query()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Query));
            this.ErrorLabel2 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.QueryButton = new System.Windows.Forms.Button();
            this.DescriptionListBox = new System.Windows.Forms.ListBox();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.FileMenu = new System.Windows.Forms.MenuItem();
            this.OpenMenuItem = new System.Windows.Forms.MenuItem();
            this.ExitMenuItem = new System.Windows.Forms.MenuItem();
            this.AboutMenu = new System.Windows.Forms.MenuItem();
            this.ImagXpressMenuItem = new System.Windows.Forms.MenuItem();
            this.queryBufferButton = new System.Windows.Forms.Button();
            this.queryFromStreamButton = new System.Windows.Forms.Button();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.SuspendLayout();
            // 
            // ErrorLabel2
            // 
            this.ErrorLabel2.Location = new System.Drawing.Point(516, 339);
            this.ErrorLabel2.Name = "ErrorLabel2";
            this.ErrorLabel2.Size = new System.Drawing.Size(72, 16);
            this.ErrorLabel2.TabIndex = 3;
            this.ErrorLabel2.Text = "Last Error:";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.Location = new System.Drawing.Point(519, 355);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(320, 157);
            this.ErrorLabel.TabIndex = 4;
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.Location = new System.Drawing.Point(8, 85);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(832, 251);
            this.ResultsListBox.TabIndex = 5;
            // 
            // QueryButton
            // 
            this.QueryButton.Location = new System.Drawing.Point(186, 369);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(120, 32);
            this.QueryButton.TabIndex = 6;
            this.QueryButton.Text = "Query File";
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // DescriptionListBox
            // 
            this.DescriptionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionListBox.Items.AddRange(new object[] {
            "This sample demonstrates the following functionality:",
            "1) Retrieving information about the image using the QueryFile method.",
            "2) Retrieving information about the image using the QueryBuffer method.",
            "3) Retrieving information about the image using the QueryStream method."});
            this.DescriptionListBox.Location = new System.Drawing.Point(8, 8);
            this.DescriptionListBox.Name = "DescriptionListBox";
            this.DescriptionListBox.Size = new System.Drawing.Size(832, 69);
            this.DescriptionListBox.TabIndex = 7;
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileMenu,
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
            // AboutMenu
            // 
            this.AboutMenu.Index = 1;
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
            // queryBufferButton
            // 
            this.queryBufferButton.Location = new System.Drawing.Point(186, 407);
            this.queryBufferButton.Name = "queryBufferButton";
            this.queryBufferButton.Size = new System.Drawing.Size(120, 33);
            this.queryBufferButton.TabIndex = 8;
            this.queryBufferButton.Text = "Query Buffer";
            this.queryBufferButton.UseVisualStyleBackColor = true;
            this.queryBufferButton.Click += new System.EventHandler(this.queryBufferButton_Click);
            // 
            // queryFromStreamButton
            // 
            this.queryFromStreamButton.Location = new System.Drawing.Point(186, 446);
            this.queryFromStreamButton.Name = "queryFromStreamButton";
            this.queryFromStreamButton.Size = new System.Drawing.Size(120, 34);
            this.queryFromStreamButton.TabIndex = 9;
            this.queryFromStreamButton.Text = "Query Stream";
            this.queryFromStreamButton.UseVisualStyleBackColor = true;
            this.queryFromStreamButton.Click += new System.EventHandler(this.queryFromStreamButton_Click);
            // 
            // Query
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(843, 518);
            this.Controls.Add(this.queryFromStreamButton);
            this.Controls.Add(this.queryBufferButton);
            this.Controls.Add(this.DescriptionListBox);
            this.Controls.Add(this.QueryButton);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ErrorLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.MainMenu;
            this.Name = "Query";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query";
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
			Application.Run(new Query());
		}

		private void ImagXpressMenuItem_Click(object sender, System.EventArgs e)
		{
			imagXpress1.AboutBox();
		}

		private void ExitMenuItem_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
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
				filename = dlg.FileName;	
			}
		}

		private void MainForm_Load(object sender, System.EventArgs e)
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

			filename = "benefits.tif";
		}


		private void QueryButton_Click(object sender, System.EventArgs e)
		{
            try
            {
                Accusoft.ImagXpressSdk.ImageXData data = Accusoft.ImagXpressSdk.ImageX.QueryFile(imagXpress1, filename);
                AppendFileInfo(data);
            }
            catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

		private void AppendFileInfo(Accusoft.ImagXpressSdk.ImageXData data)
		{
			ResultsListBox.Items.Clear();
			ResultsListBox.Items.Add("Filename: " + filename);
			ResultsListBox.Items.Add("Width: " + data.Width);
			ResultsListBox.Items.Add("Height: " + data.Height);
			ResultsListBox.Items.Add("Bits Per Pixel: " + data.BitsPerPixel);
			ResultsListBox.Items.Add("Format: " + data.Format);
			ResultsListBox.Items.Add("FileSize: " + data.Size);
			ResultsListBox.Items.Add("Resolution Units: " + data.Resolution.Units);
			ResultsListBox.Items.Add("X Resolution: " + data.Resolution.Dimensions.Width);
			ResultsListBox.Items.Add("Y Resolution: " + data.Resolution.Dimensions.Height);
		}

		private void queryBufferButton_Click(object sender, EventArgs e)
		{
            try
            {
                System.IO.FileStream stream = new System.IO.FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);

                Byte[] imgData = new byte[stream.Length];
                stream.Read(imgData, 0, imgData.Length);
                stream.Close();
                AppendFileInfo(ImageX.QueryBuffer(imagXpress1, imgData, 1));
            }
            catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

		private void queryFromStreamButton_Click(object sender, EventArgs e)
		{
            try
            {
                System.IO.FileStream stream = new System.IO.FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);

                AppendFileInfo(ImageX.QueryFromStream(imagXpress1, stream, 1));
                stream.Close();
            }
            catch (Accusoft.ImagXpressSdk.ImagXpressException ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
	}
}
