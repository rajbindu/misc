/***************************************************************
* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.OleDb;

namespace DatabaseInteraction
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.MainMenu mainMenu1;
		internal System.Windows.Forms.Label lblError;
		internal System.Windows.Forms.Label lblLastError;
		internal System.Windows.Forms.Button cmdInsert;
		internal System.Windows.Forms.Button cmdRemove;
		internal System.Windows.Forms.ComboBox CmbBxImages;
		internal System.Windows.Forms.RichTextBox rtbInfo;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuFileQuit;
		private System.Windows.Forms.MenuItem mnuToolbar;
		private System.Windows.Forms.MenuItem mnuToolbarShow;
		private System.Windows.Forms.MenuItem mnuAbout;

		string strCurrentDatabase;
		string strProvider = "Provider=Microsoft.Jet.OLEDB.4.0.;";
		string strDataSource;
		System.Data.OleDb.OleDbConnection dbConnection;
		System.Data.OleDb.OleDbDataAdapter dbAdapter;
		System.Data.OleDb.OleDbCommand dbInsertCommand;
		System.Data.OleDb.OleDbCommand dbDeleteCommand;
		System.Data.OleDb.OleDbCommand dbUpdateCommand;
		bool bFormLoadComplete;
        Accusoft.ImagXpressSdk.LoadOptions loLoadOptions;
        private Accusoft.ImagXpressSdk.ImagXpress imagXpress1;
        private Accusoft.ImagXpressSdk.ImageXView imageXView1;
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuFileQuit = new System.Windows.Forms.MenuItem();
            this.mnuToolbar = new System.Windows.Forms.MenuItem();
            this.mnuToolbarShow = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.lblError = new System.Windows.Forms.Label();
            this.lblLastError = new System.Windows.Forms.Label();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.CmbBxImages = new System.Windows.Forms.ComboBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuToolbar,
            this.mnuAbout});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFileQuit});
            this.mnuFile.Text = "&File";
            // 
            // mnuFileQuit
            // 
            this.mnuFileQuit.Index = 0;
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
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Location = new System.Drawing.Point(461, 123);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(240, 184);
            this.lblError.TabIndex = 30;
            // 
            // lblLastError
            // 
            this.lblLastError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastError.Location = new System.Drawing.Point(461, 102);
            this.lblLastError.Name = "lblLastError";
            this.lblLastError.Size = new System.Drawing.Size(168, 15);
            this.lblLastError.TabIndex = 29;
            this.lblLastError.Text = "Last Error:";
            // 
            // cmdInsert
            // 
            this.cmdInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdInsert.Location = new System.Drawing.Point(344, 491);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(103, 40);
            this.cmdInsert.TabIndex = 28;
            this.cmdInsert.Text = "Insert Image";
            this.cmdInsert.Click += new System.EventHandler(this.cmdInsert_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdRemove.Location = new System.Drawing.Point(8, 491);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(96, 40);
            this.cmdRemove.TabIndex = 27;
            this.cmdRemove.Text = "Remove Image";
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // CmbBxImages
            // 
            this.CmbBxImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbBxImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxImages.Location = new System.Drawing.Point(120, 499);
            this.CmbBxImages.Name = "CmbBxImages";
            this.CmbBxImages.Size = new System.Drawing.Size(207, 21);
            this.CmbBxImages.TabIndex = 26;
            this.CmbBxImages.SelectedIndexChanged += new System.EventHandler(this.CmbBxImages_SelectedIndexChanged);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfo.Location = new System.Drawing.Point(8, 8);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(696, 91);
            this.rtbInfo.TabIndex = 25;
            this.rtbInfo.Text = resources.GetString("rtbInfo.Text");
            // 
            // imageXView1
            // 
            this.imageXView1.Location = new System.Drawing.Point(8, 106);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(420, 383);
            this.imageXView1.TabIndex = 31;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(712, 540);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblLastError);
            this.Controls.Add(this.cmdInsert);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.CmbBxImages);
            this.Controls.Add(this.rtbInfo);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImagXpress Database Interaction";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

		#region Accusoft Sample Application Standard Functions
		/*********************************************************************
		 *     Accusoft Corporation Standard Function Definitions     *
		 *********************************************************************/

		private System.Globalization.NumberFormatInfo cultNumber = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
		private System.Globalization.TextInfo cultText = System.Globalization.CultureInfo.CurrentCulture.TextInfo;
		private System.Globalization.CompareInfo cultCompare = System.Globalization.CultureInfo.CurrentCulture.CompareInfo;
		
				
		const System.String strDefaultImageFilter = "All ImagXpress Supported File Types|*.bmp;*.cal;*.dib;*.dca;*.mod;*.dcx;*.gif;*.jp2;*.jls;*.jpg;*.jif;*.ljp;*.pbm;*.pcx;*.pgm;*.pic;*.png;*.ppm;*.tiff;*.tif;*.tga;*.wsq;*.jb2;*.gif;*.jpeg;*.cals;*.jbig2;*.ico;*.rle;*.lzw;*.wbmp;*.dwg;*.dxf;*.dwf;*.hdp;*.wdp|Windows Bitmap (*.BMP)|*.bmp|CALS (*.CAL)|*.cal|Windows Device Independent Bitmap(*.DIB)|*.dib|MO:DCA (*.DCA & *.MOD)|*.dca;*.mod|Zsoft Multiple Page (*.DCX)|*.dcx|CompuServe GIF (*.GIF)|*.gif|JPEG 2000 (*.JP2)|*.jp2|JPEG LS (*.JLS)|*.jls|JFIF Compliant JPEG (*.JPG & *.JIF)|*.jpg;*.jif|Lossless JPEG (*.LJP)|*.ljp|Portable Bitmap (*.PBM)|*.pbm|Zsoft PaintBrush (*.PCX)|*.pcx|Portable Graymap (*.PGM)|*.pgm|Pegasus PIC or Enhanced PIC (*.PIC)|*.pic|Portable Network Graphics (*.PNG)|*.png|Portable Pixmap (*.PPM)|*.ppm|Tagged Image Format (*.TIFF)|*.tif;*.tiff|Truevision TARGA (*.TGA)|*.tga|WSQ Fingerprint File (*.WSQ)|*.wsq|JBIG2 File (*.JB2)|*.jb2|CAD Drawing (*.DWG)|*.dwg|Autodesk Design Web Format (*.DWF)|*.dwf|AutoCAD DXF (*.DXF)|*.dxf|HD Photo (*.HDP & *.WDP)|*.hdp;*.wdp|All Files (*.*)|*.*";

		string GetFileName(System.String FullName) 
		{
			return (FullName.Substring(FullName.LastIndexOf("\\")+1,FullName.Length - FullName.LastIndexOf("\\") - 1));
		}
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


		 
		private void Form1_Load(object sender, System.EventArgs e)
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

			int bufferSize = 16777216;
			byte[] outByte = new byte[bufferSize-1];
			string stringConnection = (strProvider + strDataSource);
			string stringSQL = "SELECT * FROM [tblImages]";
			
			try 
			{
				//Create a new load options object so we can recieve events from the images we load
				loLoadOptions = new Accusoft.ImagXpressSdk.LoadOptions();
				
			} 
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex) 
			{
				AccusoftError(ex,lblError);
			}

            // Note that this database does not support 64-bit so the target platform
            // for this project must be set to x86

			strCurrentDatabase = Application.StartupPath + "..\\..\\..\\..\\..\\..\\..\\..\\..\\..\\..\\Common\\Images\\DatabaseInteraction.mdb";

            String strCurrentDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");
            if (System.IO.Directory.Exists(strCurrentDir))
                System.IO.Directory.SetCurrentDirectory(strCurrentDir);
            strCurrentDir = System.IO.Directory.GetCurrentDirectory();

			strDataSource = "Data Source=" + strCurrentDatabase;
			stringSQL = "SELECT * FROM [tblImages]";
			imageXView1.AutoScroll = true;
			dbConnection = new OleDbConnection();
			
			dbInsertCommand = new System.Data.OleDb.OleDbCommand();
			dbInsertCommand.CommandText = "INSERT INTO tblImages([Image], ImageName) VALUES (?, ?)";
			dbInsertCommand.Connection = dbConnection;
			dbInsertCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Image", System.Data.OleDb.OleDbType.VarBinary, 0, "Image"));
			dbInsertCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("ImageName", System.Data.OleDb.OleDbType.VarWChar, 255, "ImageName"));
			
			dbDeleteCommand = new System.Data.OleDb.OleDbCommand();
			dbUpdateCommand = new System.Data.OleDb.OleDbCommand();
			
			dbDeleteCommand.CommandText = "DELETE FROM tblImages WHERE (ID = ?) AND (ImageName = ? OR ? IS NULL AND ImageName IS NULL)";
			dbDeleteCommand.Connection = dbConnection;
			dbDeleteCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			dbDeleteCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ImageName", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ImageName", System.Data.DataRowVersion.Original, null));
			dbDeleteCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ImageName1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ImageName", System.Data.DataRowVersion.Original, null));
			
			dbConnection.ConnectionString = strProvider + strDataSource;
            dbConnection.Open();
			
			System.Data.OleDb.OleDbCommand dbCommandGet = new OleDbCommand(stringSQL, dbConnection);
			System.Data.OleDb.OleDbDataReader dbReader = dbCommandGet.ExecuteReader(CommandBehavior.Default);
			int i = 0;
			while (dbReader.Read()) 
			{
				CmbBxImages.Items.Add(dbReader["ImageName"].ToString());
				if ((i == 0)) 
				{
					CmbBxImages.Text = dbReader["ImageName"].ToString();
				}
				i = (i + 1);
			}
			dbReader.Close();
			dbConnection.Close();
			// Load the first Image in the List
			GetDBImage(0, imageXView1);
			bFormLoadComplete = true;
		}
    
		private string GetDBImage(int Index, Accusoft.ImagXpressSdk.ImageXView iXView) 
		{
			string ImageName;
			long retter;
			int bufferSize = 16777216;
			byte[] outByte = new byte[bufferSize-1];
			string stringConnection = (strProvider + strDataSource);
			string stringSQL = "SELECT * FROM [tblImages]";
			dbConnection.ConnectionString = (strProvider + strDataSource);
			dbConnection.Open();
			System.Data.OleDb.OleDbCommand dbCommandGet = new OleDbCommand(stringSQL, dbConnection);
			System.Data.OleDb.OleDbDataReader dbReader = dbCommandGet.ExecuteReader(CommandBehavior.Default);
			int i = 0;
			while ((i <= Index)) 
			{
				dbReader.Read();
				i = (i + 1);
			}
			retter = dbReader.GetBytes(2, 0, outByte, 0, bufferSize);
			MemoryStream stmBLOBData = new MemoryStream(outByte);
			ImageName = dbReader["ImageName"].ToString();
			dbReader.Close();
			try 
			{
				iXView.Image = Accusoft.ImagXpressSdk.ImageX.FromStream(imagXpress1, stmBLOBData,loLoadOptions);
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex) 
			{
				AccusoftError(ex, lblError);
			}
			if ((dbConnection.State == ConnectionState.Open)) 
			{
				dbConnection.Close();
				dbConnection.Dispose();
			}
			return ImageName;
		}
    
			
    
		private void RemoveDBImage(int Index) 
		{
			string stringConnection = (strProvider + strDataSource);
			string stringSQL = "SELECT * FROM [tblImages]";
			dbConnection.ConnectionString = (strProvider + strDataSource);
			dbConnection.Open();
			dbAdapter = new OleDbDataAdapter(stringSQL, dbConnection);
			dbAdapter.DeleteCommand = dbDeleteCommand;
			System.Data.DataSet dataSet = new DataSet("tblImages");
			dataSet.Locale = System.Globalization.CultureInfo.InvariantCulture;
			dbAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
			dbAdapter.Fill(dataSet, "tblImages");
			
			dataSet.Tables["tblImages"].Rows[Index].Delete();
			
			dbAdapter.Update(dataSet, "tblImages");
			dbConnection.Close();
			CmbBxImages.Items.Remove(CmbBxImages.Text);
			if ((Index == CmbBxImages.Items.Count)) 
			{
				CmbBxImages.SelectedIndex = (Index - 1);
			}
			else 
			{
				CmbBxImages.SelectedIndex = Index;
			}
		}
    
		private void InsertDBImage(string FileName) 
		{
			System.IO.FileStream fileStream = new System.IO.FileStream(FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
			long imageSize = fileStream.Length;
			byte[] imageData = new Byte[fileStream.Length];
			fileStream.Read(imageData, 0, System.Convert.ToInt32(fileStream.Length));
			fileStream.Close();
			string FName = GetFileName(FileName);
			string stringConnection = strProvider + strDataSource;
			string stringSQL = "SELECT * FROM [tblImages]";
			dbConnection.ConnectionString = (strProvider + strDataSource);
			dbConnection.Open();
			
			dbAdapter = new OleDbDataAdapter(stringSQL, dbConnection);
			dbAdapter.InsertCommand = dbInsertCommand;
			System.Data.DataSet dataSet = new DataSet("tblImages");
			dataSet.Locale = System.Globalization.CultureInfo.InvariantCulture;
			dbAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
			dbAdapter.Fill(dataSet, "tblImages");
			System.Data.DataRow newRow = dataSet.Tables["tblImages"].NewRow();
			newRow["ImageName"] = FName;
			newRow["Image"] = imageData;
			dataSet.Tables["tblImages"].Rows.Add(newRow);
			try 
			{	
		
				dbAdapter.Update(dataSet, "tblImages");
				CmbBxImages.Items.Add(FName);
				dbConnection.Close();
				CmbBxImages.SelectedIndex = (CmbBxImages.Items.Count - 1);
			}
			catch (System.Exception ex) 
			{
				AccusoftError(ex, lblError);
				dbConnection.Close();
			}
		}
   	

		private void CmbBxImages_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if ((bFormLoadComplete == true)) 
			{
				GetDBImage(CmbBxImages.SelectedIndex, imageXView1);
			}
		}

		private void cmdInsert_Click(object sender, System.EventArgs e)
		{
			string strLoadResult = AccusoftOpenFile();
			if ((strLoadResult.Length != 0)) 
			{
				InsertDBImage(strLoadResult);
			}
		}

		private void cmdRemove_Click(object sender, System.EventArgs e)
		{
			RemoveDBImage(CmbBxImages.SelectedIndex);
		}

		private void mnuToolbarShow_Click(object sender, System.EventArgs e)
		{
			this.mnuToolbarShow.Text = (imageXView1.Toolbar.Activated) ? "&Show":"&Hide";
			try 
			{
				imageXView1.Toolbar.Activated = !imageXView1.Toolbar.Activated;
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException eX) 
			{
				AccusoftError(eX,lblError);
			}
		}

		private void mnuFileQuit_Click(object sender, System.EventArgs e) 
		{
			Application.Exit();
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

						
	}
}

