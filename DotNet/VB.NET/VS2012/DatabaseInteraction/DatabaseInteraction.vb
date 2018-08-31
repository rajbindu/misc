'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports Accusoft.ImagXpressSdk


Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private strCurrentDatabase As String
    Private strProvider As String = "Provider=Microsoft.Jet.OLEDB.4.0.;"
    Private strDataSource As String
    Private dbConnection As System.Data.OleDb.OleDbConnection
    Private dbAdapter As System.Data.OleDb.OleDbDataAdapter
    Private dbInsertCommand As System.Data.OleDb.OleDbCommand
    Private dbDeleteCommand As System.Data.OleDb.OleDbCommand
    Private dbUpdateCommand As System.Data.OleDb.OleDbCommand
    Friend WithEvents imagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
    Friend WithEvents imageXView1 As Accusoft.ImagXpressSdk.ImageXView
    Private bFormLoadComplete As Boolean

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If

        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents rtbInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents CmbBxImages As System.Windows.Forms.ComboBox
    Friend WithEvents cmdRemove As System.Windows.Forms.Button
    Friend WithEvents cmdInsert As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents lblLastError As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolbar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolbarShow As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.rtbInfo = New System.Windows.Forms.RichTextBox()
        Me.CmbBxImages = New System.Windows.Forms.ComboBox()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.cmdInsert = New System.Windows.Forms.Button()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileQuit = New System.Windows.Forms.MenuItem()
        Me.mnuToolbar = New System.Windows.Forms.MenuItem()
        Me.mnuToolbarShow = New System.Windows.Forms.MenuItem()
        Me.mnuAbout = New System.Windows.Forms.MenuItem()
        Me.lblLastError = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.imagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
        Me.imageXView1 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.SuspendLayout()
        '
        'rtbInfo
        '
        Me.rtbInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbInfo.Location = New System.Drawing.Point(16, 16)
        Me.rtbInfo.Name = "rtbInfo"
        Me.rtbInfo.Size = New System.Drawing.Size(688, 93)
        Me.rtbInfo.TabIndex = 0
        Me.rtbInfo.Text = resources.GetString("rtbInfo.Text")
        '
        'CmbBxImages
        '
        Me.CmbBxImages.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbBxImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBxImages.Location = New System.Drawing.Point(136, 408)
        Me.CmbBxImages.Name = "CmbBxImages"
        Me.CmbBxImages.Size = New System.Drawing.Size(200, 21)
        Me.CmbBxImages.TabIndex = 2
        '
        'cmdRemove
        '
        Me.cmdRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdRemove.Location = New System.Drawing.Point(64, 448)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(96, 40)
        Me.cmdRemove.TabIndex = 4
        Me.cmdRemove.Text = "Remove Image"
        '
        'cmdInsert
        '
        Me.cmdInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdInsert.Location = New System.Drawing.Point(312, 456)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(104, 32)
        Me.cmdInsert.TabIndex = 5
        Me.cmdInsert.Text = "Insert Image"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuToolbar, Me.mnuAbout})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileQuit})
        Me.mnuFile.Text = "&File"
        '
        'mnuFileQuit
        '
        Me.mnuFileQuit.Index = 0
        Me.mnuFileQuit.Text = "&Quit"
        '
        'mnuToolbar
        '
        Me.mnuToolbar.Index = 1
        Me.mnuToolbar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuToolbarShow})
        Me.mnuToolbar.Text = "&Toolbar"
        '
        'mnuToolbarShow
        '
        Me.mnuToolbarShow.Index = 0
        Me.mnuToolbarShow.Text = "&Show"
        '
        'mnuAbout
        '
        Me.mnuAbout.Index = 2
        Me.mnuAbout.Text = "&About"
        '
        'lblLastError
        '
        Me.lblLastError.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLastError.Location = New System.Drawing.Point(504, 312)
        Me.lblLastError.Name = "lblLastError"
        Me.lblLastError.Size = New System.Drawing.Size(168, 32)
        Me.lblLastError.TabIndex = 6
        Me.lblLastError.Text = "Last Error:"
        '
        'lblError
        '
        Me.lblError.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblError.Location = New System.Drawing.Point(512, 360)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(192, 128)
        Me.lblError.TabIndex = 7
        '
        'imageXView1
        '
        Me.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
        Me.imageXView1.Location = New System.Drawing.Point(16, 115)
        Me.imageXView1.Name = "imageXView1"
        Me.imageXView1.Size = New System.Drawing.Size(436, 272)
        Me.imageXView1.TabIndex = 8
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(720, 497)
        Me.Controls.Add(Me.imageXView1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblLastError)
        Me.Controls.Add(Me.cmdInsert)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.CmbBxImages)
        Me.Controls.Add(Me.rtbInfo)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Interaction"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim printDocument1 As System.Drawing.Printing.PrintDocument

#Region "Accusoft Sample Application Standard Functions"

    '/*********************************************************************
    '*     Accusoft Corporation Standard Function Definitions     *
    ' *********************************************************************/

    Dim cultNumber As System.Globalization.NumberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat
    Dim cultText As System.Globalization.TextInfo = System.Globalization.CultureInfo.CurrentCulture.TextInfo
    Dim cultCompare As System.Globalization.CompareInfo = System.Globalization.CultureInfo.CurrentCulture.CompareInfo
    Dim strDefaultImageFilter As String = "All ImagXpress Supported File Types|*.bmp;*.cal;*.dib;*.dca;*.mod;*.dcx;*.dwf;*.dwg;*.dxf;*.gif;*.hdp;*.jp2;*.jls;*.jpg;*.jif" & _
    ";*.ljp;*.pbm;*.pcx;*.pgm;*.pic;*.png;*.ppm;*.tiff;*.tif;*.tga;*.wdp;*.wsq;*.jb2;*.gif;*.jpeg;*.cals;*.jbig" & _
    "2;*.ico;*.rle;*.lzw;*.wbmp|Windows Bitmap (*.BMP)|*.bmp|CALS (*.CAL)|*.cal|Windows Device Independen" & _
    "t Bitmap(*.DIB)|*.dib|MO:DCA (*.DCA & *.MOD)|*.dca;*.mod|Zsoft Multiple Page (*.DCX)|*.dcx|CompuServ" & _
    "e GIF (*.GIF)|*.gif|JPEG 2000 (*.JP2)|*.jp2|JPEG LS (*.JLS)|*.jls|JFIF Compliant JPEG (*.JPG & *.JIF" & _
    ")|*.jpg;*.jif|Lossless JPEG (*.LJP)|*.ljp|Portable Bitmap (*.PBM)|*.pbm|Zsoft PaintBrush (*.PCX)|*.p" & _
    "cx|Portable Graymap (*.PGM)|*.pgm|Pegasus PIC or Enhanced PIC (*.PIC)|*.pic|Portable Network Graphic" & _
    "s (*.PNG)|*.png|Portable Pixmap (*.PPM)|*.ppm|Tagged Image Format (*.TIFF)|*.tif;*.tiff|Truevision T" & _
    "ARGA (*.TGA)|*.tga|WSQ Fingerprint File (*.WSQ)|*.wsq|JBIG2 File (*.JB2)|*.jb2|CAD Drawing (*.DWG)|*" & _
 ".dwg|Autodesk Design Web Format (*.DWF)|*.dwf|AutoCAD DXF (*.DXF)|*.dxf|HD Photo (*.HDP & *.WDP)|*.h" & _
 "dp;*.wdp|All Files (*.*)|*.*"

    Private Function GetFileName(ByVal FullName As String) As String

        Return FullName.Substring((FullName.LastIndexOf("\") + 1), (FullName.Length - (FullName.LastIndexOf("\") + 1)))
    End Function

    Private Overloads Shared Sub AccusoftError(ByVal ErrorException As System.Exception, ByVal ErrorLabel As System.Windows.Forms.Label)
        ErrorLabel.Text = (ErrorException.Message + ("" & vbLf _
                    + (ErrorException.Source + "" & vbLf)))
    End Sub

    Private Overloads Shared Sub AccusoftError(ByVal ErrorException As Accusoft.ImagXpressSdk.ImagXpressException, ByVal ErrorLabel As System.Windows.Forms.Label)
        ErrorLabel.Text = (ErrorException.Message + ("" & vbLf _
                    + (ErrorException.Source + ("" & vbLf + ("Error Number: " + ErrorException.Number.ToString(System.Globalization.CultureInfo.CurrentCulture.NumberFormat))))))
    End Sub

    Private Overloads Function AccusoftOpenFile() As String
        Dim dlg As OpenFileDialog = New OpenFileDialog()
        dlg.Title = "Select an Image File"
        dlg.Filter = strDefaultImageFilter
        If (dlg.ShowDialog = DialogResult.OK) Then
            Return dlg.FileName
        Else
            Return ""
        End If
    End Function

    Private Overloads Function AccusoftOpenFile(ByVal strFilter As String) As String
        Dim dlg As OpenFileDialog = New OpenFileDialog()
        dlg.Title = "Select an Image File"
        dlg.Filter = strFilter
        If (dlg.ShowDialog = DialogResult.OK) Then
            Return dlg.FileName
        Else
            Return ""
        End If
    End Function

#End Region

    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm())
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim strCurrentDir As String

        Dim fileHandle As System.IntPtr = New System.IntPtr()
        Dim bufferSize As Integer = 16777216
        Dim outByte() As Byte = New Byte(((bufferSize - 1)) - 1) {}
        Dim stringConnection As String = (strProvider + strDataSource)
        Dim stringSQL As String = "SELECT * FROM [tblImages]"

        '***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
        'imagXpress1.Licensing.SetSolutionName("YourSolutionName")
        'imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345)
        'imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�")

        'Because in this sample the ImageX object is always located in the ImageXView
        'tell the ImageXView component to dispose of the ImageX object when itself is
        'disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
        'Dispose method before the components.Dispose() section.
        imageXView1.AutoImageDispose = True

        ' Note that this database does not support 64-bit so the target platform
        ' for this project must be set to x86

        strCurrentDir = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\..\Common\Images"
        If System.IO.Directory.Exists(strCurrentDir) Then
            System.IO.Directory.SetCurrentDirectory(strCurrentDir)
        End If
        strCurrentDir = System.IO.Directory.GetCurrentDirectory()

        strCurrentDatabase = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\..\Common\Images\DatabaseInteraction.mdb"
        strDataSource = "Data Source=" + strCurrentDatabase
        stringSQL = "SELECT * FROM [tblImages]"

        imageXView1.AutoScroll = True

        dbConnection = New OleDbConnection()

        dbInsertCommand = New System.Data.OleDb.OleDbCommand()

        dbInsertCommand.CommandText = "INSERT INTO tblImages([Image], ImageName) VALUES (?, ?)"
        dbInsertCommand.Connection = dbConnection
        dbInsertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Image", System.Data.OleDb.OleDbType.VarBinary, 0, "Image"))
        dbInsertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("ImageName", System.Data.OleDb.OleDbType.VarWChar, 255, "ImageName"))

        dbDeleteCommand = New System.Data.OleDb.OleDbCommand()
        dbUpdateCommand = New System.Data.OleDb.OleDbCommand()

        dbDeleteCommand.CommandText = "DELETE FROM tblImages WHERE (ID = ?) AND (ImageName = ? OR ? IS NULL AND ImageName IS NULL)"
        dbDeleteCommand.Connection = dbConnection
        dbDeleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        dbDeleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ImageName", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ImageName", System.Data.DataRowVersion.Original, Nothing))
        dbDeleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ImageName1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ImageName", System.Data.DataRowVersion.Original, Nothing))

        dbConnection.ConnectionString = (strProvider + strDataSource)
        dbConnection.Open()
        Dim dbCommandGet As System.Data.OleDb.OleDbCommand = New OleDbCommand(stringSQL, dbConnection)
        Dim dbReader As System.Data.OleDb.OleDbDataReader = dbCommandGet.ExecuteReader(CommandBehavior.Default)
        Dim i As Integer = 0
        Do While dbReader.Read()

            CmbBxImages.Items.Add(dbReader("ImageName").ToString)
            If i = 0 Then
                CmbBxImages.Text = dbReader("ImageName").ToString
            End If
            i = i + 1
        Loop

        dbReader.Close()
        dbConnection.Close()

        'Load the first Image in the List
        Call GetDBImage(0, imageXView1)

        bFormLoadComplete = True

    End Sub

    Private Function GetDBImage(ByVal Index As Integer, ByVal iXView As Accusoft.ImagXpressSdk.ImageXView) As String

        Dim ImageName As String
        Dim fileHandle As System.IntPtr = New System.IntPtr()
        Dim retter As Long
        Dim bufferSize As Integer = 16777216
        Dim outByte() As Byte = New Byte(((bufferSize - 1)) - 1) {}
        Dim stringConnection As String = (strProvider + strDataSource)
        Dim stringSQL As String = "SELECT * FROM [tblImages]"
        dbConnection.ConnectionString = (strProvider + strDataSource)
        dbConnection.Open()
        Dim dbCommandGet As System.Data.OleDb.OleDbCommand = New OleDbCommand(stringSQL, dbConnection)
        Dim dbReader As System.Data.OleDb.OleDbDataReader = dbCommandGet.ExecuteReader(CommandBehavior.Default)
        Dim i As Integer = 0
        Do While (i <= Index)
            dbReader.Read()
            i = (i + 1)
        Loop
        retter = dbReader.GetBytes(2, 0, outByte, 0, bufferSize)
        Dim stmBLOBData As MemoryStream = New MemoryStream(outByte)
        ImageName = dbReader("ImageName").ToString
        dbReader.Close()
        Try
            iXView.Image = Accusoft.ImagXpressSdk.ImageX.FromStream(imagXpress1, stmBLOBData)
        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblError)
        End Try
        If (dbConnection.State = ConnectionState.Open) Then
            dbConnection.Close()
            dbConnection.Dispose()
        End If
        Return ImageName
    End Function


    Private Sub CmbBxImages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBxImages.SelectedIndexChanged

        If bFormLoadComplete = True Then
            GetDBImage(CmbBxImages.SelectedIndex, imageXView1)

        End If
    End Sub


    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        RemoveDBImage(CmbBxImages.SelectedIndex)
    End Sub

    Private Sub RemoveDBImage(ByVal Index As Integer)
        Dim stringConnection As String = (strProvider + strDataSource)
        Dim stringSQL As String = "SELECT * FROM [tblImages]"
        dbConnection.ConnectionString = (strProvider + strDataSource)
        dbConnection.Open()
        dbAdapter = New OleDbDataAdapter(stringSQL, dbConnection)
        dbAdapter.DeleteCommand = dbDeleteCommand
        Dim dataSet As System.Data.DataSet = New DataSet("tblImages")
        dataSet.Locale = System.Globalization.CultureInfo.InvariantCulture
        dbAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        dbAdapter.Fill(dataSet, "tblImages")
        dataSet.Tables("tblImages").Rows(Index).Delete()
        dbAdapter.Update(dataSet, "tblImages")
        dbConnection.Close()


        CmbBxImages.Items.Remove(CmbBxImages.Text)

        If Index = CmbBxImages.Items.Count Then

            CmbBxImages.SelectedIndex = Index - 1
        Else

            CmbBxImages.SelectedIndex = Index

        End If

    End Sub

    Private Sub InsertDBImage(ByVal FileName As String)
        Dim fileStream As System.IO.FileStream = New System.IO.FileStream(FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read)
        Dim imageSize As Long = fileStream.Length
        Dim imageData(fileStream.Length) As Byte

        fileStream.Read(imageData, 0, System.Convert.ToInt32(fileStream.Length))
        fileStream.Close()
        Dim FName As String = GetFileName(FileName)
        Dim stringConnection As String = (strProvider + strDataSource)
        Dim stringSQL As String = "SELECT * FROM [tblImages]"
        dbConnection.ConnectionString = (strProvider + strDataSource)
        dbConnection.Open()
        dbAdapter = New OleDbDataAdapter(stringSQL, dbConnection)
        dbAdapter.InsertCommand = dbInsertCommand
        Dim dataSet As System.Data.DataSet = New DataSet("tblImages")
        dbAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        dbAdapter.Fill(dataSet, "tblImages")
        Dim newRow As System.Data.DataRow = dataSet.Tables("tblImages").NewRow
        newRow("ImageName") = FName
        newRow("Image") = imageData
        dataSet.Tables("tblImages").Rows.Add(newRow)
        Try
            dbAdapter.Update(dataSet, "tblImages")
            CmbBxImages.Items.Add(FName)
            dbConnection.Close()
            CmbBxImages.SelectedIndex = CmbBxImages.Items.Count - 1

        Catch ex As System.Exception
            AccusoftError(ex, lblError)
            dbConnection.Close()
        End Try

    End Sub

    Private Sub mnuFileQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileQuit.Click
        Application.Exit()
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        Try
            imagXpress1.AboutBox()
        Catch eX As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(eX, lblError)
        End Try
    End Sub

    Private Sub mnuToolbarShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolbarShow.Click


        If imageXView1.Toolbar.Activated = True Then
            mnuToolbarShow.Text = "Show"
            imageXView1.Toolbar.Activated = False

        Else
            mnuToolbarShow.Text = "Hide"
            imageXView1.Toolbar.Activated = True
        End If
    End Sub


    Private Sub cmdInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsert.Click
        Dim strLoadResult As String = AccusoftOpenFile()
        If (strLoadResult.Length <> 0) Then
            InsertDBImage(strLoadResult)

        End If
    End Sub


End Class
