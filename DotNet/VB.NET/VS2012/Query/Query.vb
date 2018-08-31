'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Public Class Query
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
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
    Friend WithEvents DescriptionListBox As System.Windows.Forms.ListBox
    Friend WithEvents QueryButton As System.Windows.Forms.Button
    Friend WithEvents ResultsListBox As System.Windows.Forms.ListBox
    Friend WithEvents ErrorLabel2 As System.Windows.Forms.Label
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents FileMenu As System.Windows.Forms.MenuItem
    Friend WithEvents OpenMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents ExitMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents AboutMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ImagXpressMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents ErrorLabel As System.Windows.Forms.Label
    Friend WithEvents StreamButton As System.Windows.Forms.Button
    Friend WithEvents BufferButton As System.Windows.Forms.Button
    Friend WithEvents ImagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Query))
        Me.DescriptionListBox = New System.Windows.Forms.ListBox()
        Me.QueryButton = New System.Windows.Forms.Button()
        Me.ResultsListBox = New System.Windows.Forms.ListBox()
        Me.ErrorLabel2 = New System.Windows.Forms.Label()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.FileMenu = New System.Windows.Forms.MenuItem()
        Me.OpenMenuItem = New System.Windows.Forms.MenuItem()
        Me.ExitMenuItem = New System.Windows.Forms.MenuItem()
        Me.AboutMenu = New System.Windows.Forms.MenuItem()
        Me.ImagXpressMenuItem = New System.Windows.Forms.MenuItem()
        Me.ImagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
        Me.StreamButton = New System.Windows.Forms.Button()
        Me.BufferButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DescriptionListBox
        '
        Me.DescriptionListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionListBox.Items.AddRange(New Object() {"This sample demonstrates the following functionality:", "1) Retrieving information about the image using the QueryFile method.", "2) Retrieving information about the image using the QueryBuffer method.", "3) Retrieving information about the image using the QueryStream method."})
        Me.DescriptionListBox.Location = New System.Drawing.Point(8, 8)
        Me.DescriptionListBox.Name = "DescriptionListBox"
        Me.DescriptionListBox.Size = New System.Drawing.Size(640, 69)
        Me.DescriptionListBox.TabIndex = 0
        '
        'QueryButton
        '
        Me.QueryButton.Location = New System.Drawing.Point(131, 352)
        Me.QueryButton.Name = "QueryButton"
        Me.QueryButton.Size = New System.Drawing.Size(104, 32)
        Me.QueryButton.TabIndex = 1
        Me.QueryButton.Text = "Query File"
        '
        'ResultsListBox
        '
        Me.ResultsListBox.Location = New System.Drawing.Point(8, 83)
        Me.ResultsListBox.Name = "ResultsListBox"
        Me.ResultsListBox.Size = New System.Drawing.Size(640, 173)
        Me.ResultsListBox.TabIndex = 2
        '
        'ErrorLabel2
        '
        Me.ErrorLabel2.Location = New System.Drawing.Point(360, 272)
        Me.ErrorLabel2.Name = "ErrorLabel2"
        Me.ErrorLabel2.Size = New System.Drawing.Size(72, 16)
        Me.ErrorLabel2.TabIndex = 3
        Me.ErrorLabel2.Text = "Last Error:"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorLabel.Location = New System.Drawing.Point(360, 288)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(288, 232)
        Me.ErrorLabel.TabIndex = 4
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FileMenu, Me.AboutMenu})
        '
        'FileMenu
        '
        Me.FileMenu.Index = 0
        Me.FileMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.OpenMenuItem, Me.ExitMenuItem})
        Me.FileMenu.Text = "&File"
        '
        'OpenMenuItem
        '
        Me.OpenMenuItem.Index = 0
        Me.OpenMenuItem.Text = "&Open"
        '
        'ExitMenuItem
        '
        Me.ExitMenuItem.Index = 1
        Me.ExitMenuItem.Text = "E&xit"
        '
        'AboutMenu
        '
        Me.AboutMenu.Index = 1
        Me.AboutMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ImagXpressMenuItem})
        Me.AboutMenu.Text = "&About"
        '
        'ImagXpressMenuItem
        '
        Me.ImagXpressMenuItem.Index = 0
        Me.ImagXpressMenuItem.Text = "Imag&Xpress"
        '
        'StreamButton
        '
        Me.StreamButton.Location = New System.Drawing.Point(131, 428)
        Me.StreamButton.Name = "StreamButton"
        Me.StreamButton.Size = New System.Drawing.Size(104, 32)
        Me.StreamButton.TabIndex = 5
        Me.StreamButton.Text = "Query Stream"
        '
        'BufferButton
        '
        Me.BufferButton.Location = New System.Drawing.Point(131, 390)
        Me.BufferButton.Name = "BufferButton"
        Me.BufferButton.Size = New System.Drawing.Size(104, 32)
        Me.BufferButton.TabIndex = 6
        Me.BufferButton.Text = "Query Buffer"
        '
        'Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 531)
        Me.Controls.Add(Me.BufferButton)
        Me.Controls.Add(Me.StreamButton)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.ErrorLabel2)
        Me.Controls.Add(Me.ResultsListBox)
        Me.Controls.Add(Me.QueryButton)
        Me.Controls.Add(Me.DescriptionListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu
        Me.Name = "Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Query"
        Me.ResumeLayout(False)

    End Sub

#End Region
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

    Dim filename As String

    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Query())
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim strCurrentDir As String

        '***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
        'imagXpress1.Licensing.SetSolutionName("YourSolutionName")
        'imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345)
        'imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�")

        'Set the current directory to the Common\Images directory
        strCurrentDir = System.IO.Path.Combine(Application.StartupPath, "..\..\..\..\..\..\..\..\..\..\Common\Images\")
        If (System.IO.Directory.Exists(strCurrentDir)) Then
            System.IO.Directory.SetCurrentDirectory(strCurrentDir)
        End If
        strCurrentDir = System.IO.Directory.GetCurrentDirectory()

        filename = "benefits.tif"

    End Sub

    Private Sub ImagXpressMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImagXpressMenuItem.Click
        ImagXpress1.AboutBox()
    End Sub

    Private Sub ExitMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub OpenMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenMenuItem.Click
        Dim imgFilename As String = AccusoftOpenFile()

        If Not (imgFilename = "") Then

            filename = imgFilename
        End If
    End Sub

    Private Sub appendData(ByVal Data As Accusoft.ImagXpressSdk.ImageXData)
        ResultsListBox.Items.Clear()
        ResultsListBox.Items.Add("Filename: " + filename)
        ResultsListBox.Items.Add("Width: " + Data.Width.ToString())
        ResultsListBox.Items.Add("Height: " + Data.Height.ToString())
        ResultsListBox.Items.Add("Bits Per Pixel: " + Data.BitsPerPixel.ToString())
        ResultsListBox.Items.Add("Format: " + Data.Format.ToString())
        ResultsListBox.Items.Add("FileSize: " + Data.Size.ToString())
        ResultsListBox.Items.Add("Resolution Units: " + Data.Resolution.Units.ToString())
        ResultsListBox.Items.Add("X Resolution: " + Data.Resolution.Dimensions.Width.ToString())
        ResultsListBox.Items.Add("Y Resolution: " + Data.Resolution.Dimensions.Height.ToString())
    End Sub

    Private Sub QueryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryButton.Click
        Try
            appendData(Accusoft.ImagXpressSdk.ImageX.QueryFile(ImagXpress1, filename))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BufferButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BufferButton.Click
        Try
            Dim stream As System.IO.FileStream = New System.IO.FileStream(filename, IO.FileMode.Open)

            Dim ImgData(stream.Length) As Byte
            stream.Read(ImgData, 0, CInt(stream.Length))
            stream.Close()
            appendData(Accusoft.ImagXpressSdk.ImageX.QueryBuffer(ImagXpress1, ImgData, 1))
        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub StreamButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StreamButton.Click
        Try
            Dim stream As System.IO.FileStream = New System.IO.FileStream(filename, IO.FileMode.Open)

            appendData(Accusoft.ImagXpressSdk.ImageX.QueryFromStream(ImagXpress1, stream, 1))

            stream.Close()
        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
