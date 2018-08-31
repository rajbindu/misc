'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Public Class MainForm
    Inherits System.Windows.Forms.Form

    Dim opts As Accusoft.ImagXpressSdk.LoadOptions
    Friend WithEvents imagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
    Friend WithEvents imageXView1 As Accusoft.ImagXpressSdk.ImageXView
    Friend WithEvents imageXView2 As Accusoft.ImagXpressSdk.ImageXView
    Friend WithEvents imageXView3 As Accusoft.ImagXpressSdk.ImageXView
    Friend WithEvents imageXView4 As Accusoft.ImagXpressSdk.ImageXView
    Friend WithEvents imageXView5 As Accusoft.ImagXpressSdk.ImageXView
    Dim imagePath(4) As String

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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DescriptionListBox As System.Windows.Forms.ListBox
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents FileMenu As System.Windows.Forms.MenuItem
    Friend WithEvents OpenMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents ExitMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents ToolbarMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ShowMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents AboutMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ImagXpressMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents Buffer As System.Windows.Forms.Label
    Friend WithEvents ErrorLabel As System.Windows.Forms.Label
    Friend WithEvents BufferLabel1 As System.Windows.Forms.Label
    Friend WithEvents StatusListBox As System.Windows.Forms.ListBox
    Friend WithEvents ReloadButton As System.Windows.Forms.Button
    Friend WithEvents RotateButton As System.Windows.Forms.Button
    Friend WithEvents BinarizeButton As System.Windows.Forms.Button
    Friend WithEvents EmbossButton As System.Windows.Forms.Button
    Friend WithEvents BufferComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorLabel2 As System.Windows.Forms.Label
    Friend WithEvents BufferLabel2 As System.Windows.Forms.Label
    Friend WithEvents BufferLabel3 As System.Windows.Forms.Label
    Friend WithEvents BufferLabel4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Buffer = New System.Windows.Forms.Label()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.BufferLabel1 = New System.Windows.Forms.Label()
        Me.StatusListBox = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DescriptionListBox = New System.Windows.Forms.ListBox()
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.FileMenu = New System.Windows.Forms.MenuItem()
        Me.OpenMenuItem = New System.Windows.Forms.MenuItem()
        Me.ExitMenuItem = New System.Windows.Forms.MenuItem()
        Me.ToolbarMenu = New System.Windows.Forms.MenuItem()
        Me.ShowMenuItem = New System.Windows.Forms.MenuItem()
        Me.AboutMenu = New System.Windows.Forms.MenuItem()
        Me.ImagXpressMenuItem = New System.Windows.Forms.MenuItem()
        Me.ReloadButton = New System.Windows.Forms.Button()
        Me.RotateButton = New System.Windows.Forms.Button()
        Me.BinarizeButton = New System.Windows.Forms.Button()
        Me.EmbossButton = New System.Windows.Forms.Button()
        Me.BufferComboBox = New System.Windows.Forms.ComboBox()
        Me.ErrorLabel2 = New System.Windows.Forms.Label()
        Me.BufferLabel2 = New System.Windows.Forms.Label()
        Me.BufferLabel3 = New System.Windows.Forms.Label()
        Me.BufferLabel4 = New System.Windows.Forms.Label()
        Me.imagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
        Me.imageXView1 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.imageXView2 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.imageXView3 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.imageXView4 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.imageXView5 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.SuspendLayout()
        '
        'Buffer
        '
        Me.Buffer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buffer.Location = New System.Drawing.Point(40, 160)
        Me.Buffer.Name = "Buffer"
        Me.Buffer.Size = New System.Drawing.Size(104, 32)
        Me.Buffer.TabIndex = 1
        Me.Buffer.Text = "Select image buffer to view/process:"
        Me.Buffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorLabel
        '
        Me.ErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorLabel.Location = New System.Drawing.Point(8, 400)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(184, 104)
        Me.ErrorLabel.TabIndex = 2
        '
        'BufferLabel1
        '
        Me.BufferLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BufferLabel1.Location = New System.Drawing.Point(24, 544)
        Me.BufferLabel1.Name = "BufferLabel1"
        Me.BufferLabel1.Size = New System.Drawing.Size(104, 16)
        Me.BufferLabel1.TabIndex = 3
        Me.BufferLabel1.Text = "View Buffer 1"
        Me.BufferLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusListBox
        '
        Me.StatusListBox.Location = New System.Drawing.Point(216, 416)
        Me.StatusListBox.Name = "StatusListBox"
        Me.StatusListBox.Size = New System.Drawing.Size(504, 95)
        Me.StatusListBox.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(400, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Image Process Status"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DescriptionListBox
        '
        Me.DescriptionListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionListBox.Items.AddRange(New Object() {"This example demonstrates the following:", "1) Loading images and displaying their buffer on other controls.", "2) Applying effects and processing images.", "3) Receiving status events from processing images.", "To use sample, select one image from the Combo Box. Use the three", "buttons to do some image processing on the selected image buffer", "to demonstrate that the two controls are viewing the same buffer."})
        Me.DescriptionListBox.Location = New System.Drawing.Point(8, 8)
        Me.DescriptionListBox.Name = "DescriptionListBox"
        Me.DescriptionListBox.Size = New System.Drawing.Size(712, 95)
        Me.DescriptionListBox.TabIndex = 13
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FileMenu, Me.ToolbarMenu, Me.AboutMenu})
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
        'ToolbarMenu
        '
        Me.ToolbarMenu.Index = 1
        Me.ToolbarMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ShowMenuItem})
        Me.ToolbarMenu.Text = "&Toolbar"
        '
        'ShowMenuItem
        '
        Me.ShowMenuItem.Index = 0
        Me.ShowMenuItem.Text = "&Show"
        '
        'AboutMenu
        '
        Me.AboutMenu.Index = 2
        Me.AboutMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ImagXpressMenuItem})
        Me.AboutMenu.Text = "&About"
        '
        'ImagXpressMenuItem
        '
        Me.ImagXpressMenuItem.Index = 0
        Me.ImagXpressMenuItem.Text = "Imag&Xpress"
        '
        'ReloadButton
        '
        Me.ReloadButton.Location = New System.Drawing.Point(24, 112)
        Me.ReloadButton.Name = "ReloadButton"
        Me.ReloadButton.Size = New System.Drawing.Size(128, 32)
        Me.ReloadButton.TabIndex = 14
        Me.ReloadButton.Text = "Reload Current Image"
        '
        'RotateButton
        '
        Me.RotateButton.Location = New System.Drawing.Point(16, 232)
        Me.RotateButton.Name = "RotateButton"
        Me.RotateButton.Size = New System.Drawing.Size(136, 32)
        Me.RotateButton.TabIndex = 15
        Me.RotateButton.Text = "Rotate by 90 Degrees"
        '
        'BinarizeButton
        '
        Me.BinarizeButton.Location = New System.Drawing.Point(16, 272)
        Me.BinarizeButton.Name = "BinarizeButton"
        Me.BinarizeButton.Size = New System.Drawing.Size(136, 32)
        Me.BinarizeButton.TabIndex = 16
        Me.BinarizeButton.Text = "Make 1-bit"
        '
        'EmbossButton
        '
        Me.EmbossButton.Location = New System.Drawing.Point(16, 312)
        Me.EmbossButton.Name = "EmbossButton"
        Me.EmbossButton.Size = New System.Drawing.Size(136, 32)
        Me.EmbossButton.TabIndex = 17
        Me.EmbossButton.Text = "Emboss"
        '
        'BufferComboBox
        '
        Me.BufferComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BufferComboBox.Location = New System.Drawing.Point(16, 192)
        Me.BufferComboBox.Name = "BufferComboBox"
        Me.BufferComboBox.Size = New System.Drawing.Size(160, 21)
        Me.BufferComboBox.TabIndex = 18
        '
        'ErrorLabel2
        '
        Me.ErrorLabel2.Location = New System.Drawing.Point(8, 384)
        Me.ErrorLabel2.Name = "ErrorLabel2"
        Me.ErrorLabel2.Size = New System.Drawing.Size(96, 16)
        Me.ErrorLabel2.TabIndex = 19
        Me.ErrorLabel2.Text = "Last Error:"
        '
        'BufferLabel2
        '
        Me.BufferLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BufferLabel2.Location = New System.Drawing.Point(224, 544)
        Me.BufferLabel2.Name = "BufferLabel2"
        Me.BufferLabel2.Size = New System.Drawing.Size(104, 16)
        Me.BufferLabel2.TabIndex = 20
        Me.BufferLabel2.Text = "View Buffer 2"
        Me.BufferLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BufferLabel3
        '
        Me.BufferLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BufferLabel3.Location = New System.Drawing.Point(408, 544)
        Me.BufferLabel3.Name = "BufferLabel3"
        Me.BufferLabel3.Size = New System.Drawing.Size(104, 16)
        Me.BufferLabel3.TabIndex = 22
        Me.BufferLabel3.Text = "View Buffer 3"
        Me.BufferLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BufferLabel4
        '
        Me.BufferLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BufferLabel4.Location = New System.Drawing.Point(592, 544)
        Me.BufferLabel4.Name = "BufferLabel4"
        Me.BufferLabel4.Size = New System.Drawing.Size(104, 16)
        Me.BufferLabel4.TabIndex = 24
        Me.BufferLabel4.Text = "View Buffer 4"
        Me.BufferLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imageXView1
        '
        Me.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
        Me.imageXView1.Location = New System.Drawing.Point(215, 111)
        Me.imageXView1.Name = "imageXView1"
        Me.imageXView1.Size = New System.Drawing.Size(504, 276)
        Me.imageXView1.TabIndex = 25
        '
        'imageXView2
        '
        Me.imageXView2.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
        Me.imageXView2.Location = New System.Drawing.Point(16, 571)
        Me.imageXView2.Name = "imageXView2"
        Me.imageXView2.Size = New System.Drawing.Size(121, 108)
        Me.imageXView2.TabIndex = 26
        '
        'imageXView3
        '
        Me.imageXView3.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
        Me.imageXView3.Location = New System.Drawing.Point(205, 571)
        Me.imageXView3.Name = "imageXView3"
        Me.imageXView3.Size = New System.Drawing.Size(121, 108)
        Me.imageXView3.TabIndex = 27
        '
        'imageXView4
        '
        Me.imageXView4.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
        Me.imageXView4.Location = New System.Drawing.Point(394, 571)
        Me.imageXView4.Name = "imageXView4"
        Me.imageXView4.Size = New System.Drawing.Size(121, 108)
        Me.imageXView4.TabIndex = 27
        '
        'imageXView5
        '
        Me.imageXView5.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
        Me.imageXView5.Location = New System.Drawing.Point(583, 571)
        Me.imageXView5.Name = "imageXView5"
        Me.imageXView5.Size = New System.Drawing.Size(121, 108)
        Me.imageXView5.TabIndex = 27
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(730, 691)
        Me.Controls.Add(Me.imageXView5)
        Me.Controls.Add(Me.imageXView4)
        Me.Controls.Add(Me.imageXView3)
        Me.Controls.Add(Me.imageXView2)
        Me.Controls.Add(Me.imageXView1)
        Me.Controls.Add(Me.BufferLabel4)
        Me.Controls.Add(Me.BufferLabel3)
        Me.Controls.Add(Me.BufferLabel2)
        Me.Controls.Add(Me.ErrorLabel2)
        Me.Controls.Add(Me.BufferComboBox)
        Me.Controls.Add(Me.EmbossButton)
        Me.Controls.Add(Me.BinarizeButton)
        Me.Controls.Add(Me.RotateButton)
        Me.Controls.Add(Me.ReloadButton)
        Me.Controls.Add(Me.DescriptionListBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.StatusListBox)
        Me.Controls.Add(Me.BufferLabel1)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.Buffer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buffering"
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
    Private Sub ImagXpressMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImagXpressMenuItem.Click
        imagXpress1.AboutBox()
    End Sub

    Private Sub ExitMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ShowMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMenuItem.Click
        If (ShowMenuItem.Checked = False) Then
            imageXView1.Toolbar.Activated = True
            ShowMenuItem.Checked = True
        Else
            imageXView1.Toolbar.Activated = False
            ShowMenuItem.Checked = False
        End If
    End Sub

    Private Sub OpenMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenMenuItem.Click

        Dim imgFilename As String = AccusoftOpenFile()

        If Not (String.IsNullOrEmpty(imgFilename)) Then

            BufferComboBox.Items.Item(BufferComboBox.SelectedIndex) = imgFilename.Remove(0, imgFilename.LastIndexOf("\") + 1)
            imagePath(BufferComboBox.SelectedIndex) = imgFilename

            Try
                Dim tmp As Accusoft.ImagXpressSdk.ImageXView = New Accusoft.ImagXpressSdk.ImageXView(imagXpress1)

                Select Case BufferComboBox.SelectedIndex
                    Case 0
                        tmp = imageXView2
                    Case 1
                        tmp = imageXView3
                    Case 2
                        tmp = imageXView4
                    Case 3
                        tmp = imageXView5
                End Select

                If Not imageXView1.Image Is Nothing Then
                    imageXView1.Image.Dispose()
                End If
                tmp.Image = StreamInFile(imgFilename, opts)
                imageXView1.Image = tmp.Image
                ErrorLabel.Text = ""

            Catch ex As Accusoft.ImagXpressSdk.ImageXException
                AccusoftError(ex, ErrorLabel)
            End Try
        End If
    End Sub

    Function StreamInFile(ByVal sFilename As String, ByVal oOpts As Accusoft.ImagXpressSdk.LoadOptions) As Accusoft.ImagXpressSdk.ImageX
        Dim iFileLength As Int32
        Dim fsReader As System.IO.FileStream = New System.IO.FileStream(sFilename, System.IO.FileMode.Open)
        iFileLength = fsReader.Length
        If (iFileLength < 0) Then
            iFileLength = 0
            fsReader.Close()
            Return (Nothing)
        Else
            Dim returnImageX As Accusoft.ImagXpressSdk.ImageX
            returnImageX = Accusoft.ImagXpressSdk.ImageX.FromStream(imagXpress1, fsReader, oOpts)
            fsReader.Close()
            Return returnImageX
        End If
    End Function

    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm())
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim strCurrentDir As String

        '***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
        'imagXpress1.Licensing.SetSolutionName("YourSolutionName")
        'imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345)
        'imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�")
        'imagXpress2.Licensing.SetSolutionName("YourSolutionName")
        'imagXpress2.Licensing.SetSolutionKey(12345,12345,12345,12345)
        'imagXpress2.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�")
        'imagXpress3.Licensing.SetSolutionName("YourSolutionName")
        'imagXpress3.Licensing.SetSolutionKey(12345,12345,12345,12345)
        'imagXpress3.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�")
        'imagXpress4.Licensing.SetSolutionName("YourSolutionName")
        'imagXpress4.Licensing.SetSolutionKey(12345,12345,12345,12345)
        'imagXpress4.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�")
        'imagXpress5.Licensing.SetSolutionName("YourSolutionName")
        'imagXpress5.Licensing.SetSolutionKey(12345,12345,12345,12345)
        'imagXpress5.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�")

        Try

            'Because in this sample the ImageX object is always located in the ImageXView
            'tell the ImageXView component to dispose of the ImageX object when itself is
            'disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
            'Dispose method before the components.Dispose() section.
            imageXView1.AutoImageDispose = True
            imageXView2.AutoImageDispose = True
            imageXView3.AutoImageDispose = True
            imageXView4.AutoImageDispose = True
            imageXView5.AutoImageDispose = True

            opts = New Accusoft.ImagXpressSdk.LoadOptions()

            AddHandler imagXpress1.ProgressEvent, AddressOf ProgressEventHandler
            AddHandler imagXpress1.ImageStatusEvent, AddressOf ImageStatusEventHandler

            strCurrentDir = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\..\Common\Images"
            If System.IO.Directory.Exists(strCurrentDir) Then
                System.IO.Directory.SetCurrentDirectory(strCurrentDir)
            End If
            strCurrentDir = System.IO.Directory.GetCurrentDirectory()

            imagePath(0) = System.IO.Path.Combine(strCurrentDir, "Window.jpg")
            imagePath(1) = System.IO.Path.Combine(strCurrentDir, "Door.jpg")
            imagePath(2) = System.IO.Path.Combine(strCurrentDir, "Water.jpg")
            imagePath(3) = System.IO.Path.Combine(strCurrentDir, "Boat.jpg")

            BufferComboBox.Items.Add(imagePath(0).Remove(0, imagePath(0).LastIndexOf("\") + 1))
            imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, imagePath(0), opts)

            BufferComboBox.Items.Add(imagePath(1).Remove(0, imagePath(1).LastIndexOf("\") + 1))
            imageXView3.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, imagePath(1), opts)

            BufferComboBox.Items.Add(imagePath(2).Remove(0, imagePath(2).LastIndexOf("\") + 1))
            imageXView4.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, imagePath(2), opts)

            BufferComboBox.Items.Add(imagePath(3).Remove(0, imagePath(3).LastIndexOf("\") + 1))
            imageXView5.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, imagePath(3), opts)

            BufferComboBox.SelectedIndex = 0

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            ErrorLabel.Text = ex.Message
        End Try
    End Sub

    Private Sub ImageStatusEventHandler(ByVal sender As Object, ByVal e As Accusoft.ImagXpressSdk.ImageStatusEventArgs)
        StatusListBox.Items.Add(e.Status.ToString())
    End Sub

    Private Sub ProgressEventHandler(ByVal sender As Object, ByVal e As Accusoft.ImagXpressSdk.ProgressEventArgs)
        StatusListBox.Items.Add(e.PercentDone.ToString() + "% Loading Complete.")
        If (e.IsComplete) Then
            StatusListBox.Items.Add(e.TotalBytes.ToString() + " Bytes Completed Loading.")
        End If
        StatusListBox.SelectedIndex = StatusListBox.Items.Count - 1
    End Sub

    Private Sub ReloadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadButton.Click
        Dim tmp As Accusoft.ImagXpressSdk.ImageXView

        Select Case BufferComboBox.SelectedIndex
            Case 0
                tmp = imageXView2
            Case 1
                tmp = imageXView3
            Case 2
                tmp = imageXView4
            Case 3
                tmp = imageXView5
            Case Else
                tmp = imageXView2
        End Select

        Try
            If Not tmp.Image Is Nothing Then
                tmp.Image.Dispose()
            End If
            tmp.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, imagePath(BufferComboBox.SelectedIndex), opts)
            ErrorLabel.Text = ""
        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            ErrorLabel.Text = ex.Message
        End Try

        Try
            imageXView1.Image = tmp.Image
            ErrorLabel.Text = ""
        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            ErrorLabel.Text = ex.Message
        End Try
    End Sub

    Private Sub BufferComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BufferComboBox.SelectedIndexChanged
        Dim tmp As Accusoft.ImagXpressSdk.ImageXView

        Select Case BufferComboBox.SelectedIndex
            Case 0
                tmp = imageXView2
            Case 1
                tmp = imageXView3
            Case 2
                tmp = imageXView4
            Case 3
                tmp = imageXView5
            Case Else
                tmp = imageXView2
        End Select

        Try
            imageXView1.Image = tmp.Image
        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            ErrorLabel.Text = ex.Message
        End Try
    End Sub

    Private Sub RotateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotateButton.Click
        Try
            Dim process As Accusoft.ImagXpressSdk.Processor
            process = New Accusoft.ImagXpressSdk.Processor(imagXpress1, imageXView1.Image)
            process.Rotate(90)
            ErrorLabel.Text = ""
        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            ErrorLabel.Text = ex.Message
        Catch ex As System.NullReferenceException
            ErrorLabel.Text += ex.Message
        End Try
    End Sub

    Private Sub BinarizeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BinarizeButton.Click
        Try
            Dim process As Accusoft.ImagXpressSdk.Processor
            process = New Accusoft.ImagXpressSdk.Processor(imagXpress1, imageXView1.Image)
            process.ColorDepth(1, Accusoft.ImagXpressSdk.PaletteType.Optimized, Accusoft.ImagXpressSdk.DitherType.Floyd)
            ErrorLabel.Text = ""
        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            ErrorLabel.Text = ex.Message
        Catch ex As System.NullReferenceException
            ErrorLabel.Text += ex.Message
        End Try
    End Sub

    Private Sub EmbossButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmbossButton.Click
        Try
            Dim process As Accusoft.ImagXpressSdk.Processor
            process = New Accusoft.ImagXpressSdk.Processor(imagXpress1, imageXView1.Image)
            process.Emboss()
            ErrorLabel.Text = ""
        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            ErrorLabel.Text = ex.Message
        Catch ex As System.NullReferenceException
            ErrorLabel.Text += ex.Message
        End Try
    End Sub

End Class
