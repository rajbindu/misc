'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Public Class MainForm
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
    Friend WithEvents ErrorLabel2 As System.Windows.Forms.Label
    Friend WithEvents ErrorLabel As System.Windows.Forms.Label
    Friend WithEvents ICMCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ProofingCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RenderLabel As System.Windows.Forms.Label
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents FileMenu As System.Windows.Forms.MenuItem
    Friend WithEvents MonitorMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents ExitMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents PrinterMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents TargetMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents OpenMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents ToolbarMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ShowMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents AboutMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ImagXpressMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents DescriptionListBox As System.Windows.Forms.ListBox
    Friend WithEvents Separator As System.Windows.Forms.MenuItem
    Friend WithEvents imagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
    Friend WithEvents imageXView1 As Accusoft.ImagXpressSdk.ImageXView
    Friend WithEvents RenderComboBox As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.DescriptionListBox = New System.Windows.Forms.ListBox()
        Me.ErrorLabel2 = New System.Windows.Forms.Label()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.ICMCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProofingCheckBox = New System.Windows.Forms.CheckBox()
        Me.RenderLabel = New System.Windows.Forms.Label()
        Me.RenderComboBox = New System.Windows.Forms.ComboBox()
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.FileMenu = New System.Windows.Forms.MenuItem()
        Me.MonitorMenuItem = New System.Windows.Forms.MenuItem()
        Me.PrinterMenuItem = New System.Windows.Forms.MenuItem()
        Me.TargetMenuItem = New System.Windows.Forms.MenuItem()
        Me.Separator = New System.Windows.Forms.MenuItem()
        Me.OpenMenuItem = New System.Windows.Forms.MenuItem()
        Me.ExitMenuItem = New System.Windows.Forms.MenuItem()
        Me.ToolbarMenu = New System.Windows.Forms.MenuItem()
        Me.ShowMenuItem = New System.Windows.Forms.MenuItem()
        Me.AboutMenu = New System.Windows.Forms.MenuItem()
        Me.ImagXpressMenuItem = New System.Windows.Forms.MenuItem()
        Me.imagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
        Me.imageXView1 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.SuspendLayout()
        '
        'DescriptionListBox
        '
        Me.DescriptionListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionListBox.Items.AddRange(New Object() {"This sample demonstrates the ICM Profile capabilities of the ImagXpress Professio" & _
                        "nal control.", "The steps to run the sample are as follows:", "", "1) Choose the appropriate Load Profile option from the pull-down menu. If you are" & _
                        " going to be performing", "    printer proofing and want to use a printer/ink that is different than the sel" & _
                        "ected printer please", "    choose the Load Target Profile option.", "2) Select an image to load. The sample opens with a default image and profiles lo" & _
                        "aded.", "3) The ICMEnabled and ICMProofing options can be used to disable the ICM", "    functionality and the proofing functionality respectively.", "4) The RenderIntent options control how the profiles should be applied. The Image" & _
                        "s", "    options is the default option."})
        Me.DescriptionListBox.Location = New System.Drawing.Point(8, 8)
        Me.DescriptionListBox.Name = "DescriptionListBox"
        Me.DescriptionListBox.Size = New System.Drawing.Size(824, 160)
        Me.DescriptionListBox.TabIndex = 1
        '
        'ErrorLabel2
        '
        Me.ErrorLabel2.Location = New System.Drawing.Point(528, 176)
        Me.ErrorLabel2.Name = "ErrorLabel2"
        Me.ErrorLabel2.Size = New System.Drawing.Size(88, 16)
        Me.ErrorLabel2.TabIndex = 2
        Me.ErrorLabel2.Text = "Last Error:"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorLabel.Location = New System.Drawing.Point(528, 192)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(304, 184)
        Me.ErrorLabel.TabIndex = 3
        '
        'ICMCheckBox
        '
        Me.ICMCheckBox.Checked = True
        Me.ICMCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ICMCheckBox.Location = New System.Drawing.Point(56, 640)
        Me.ICMCheckBox.Name = "ICMCheckBox"
        Me.ICMCheckBox.Size = New System.Drawing.Size(120, 21)
        Me.ICMCheckBox.TabIndex = 6
        Me.ICMCheckBox.Text = "ICM Enabled"
        '
        'ProofingCheckBox
        '
        Me.ProofingCheckBox.Checked = True
        Me.ProofingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ProofingCheckBox.Location = New System.Drawing.Point(287, 640)
        Me.ProofingCheckBox.Name = "ProofingCheckBox"
        Me.ProofingCheckBox.Size = New System.Drawing.Size(152, 21)
        Me.ProofingCheckBox.TabIndex = 7
        Me.ProofingCheckBox.Text = "ICM Proofing Enabled"
        '
        'RenderLabel
        '
        Me.RenderLabel.Location = New System.Drawing.Point(570, 641)
        Me.RenderLabel.Name = "RenderLabel"
        Me.RenderLabel.Size = New System.Drawing.Size(88, 16)
        Me.RenderLabel.TabIndex = 8
        Me.RenderLabel.Text = "Render Intent:"
        Me.RenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RenderComboBox
        '
        Me.RenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RenderComboBox.Items.AddRange(New Object() {"Images", "Business", "Graphics", "Absolute Color Metric"})
        Me.RenderComboBox.Location = New System.Drawing.Point(664, 640)
        Me.RenderComboBox.Name = "RenderComboBox"
        Me.RenderComboBox.Size = New System.Drawing.Size(112, 21)
        Me.RenderComboBox.TabIndex = 9
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FileMenu, Me.ToolbarMenu, Me.AboutMenu})
        '
        'FileMenu
        '
        Me.FileMenu.Index = 0
        Me.FileMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MonitorMenuItem, Me.PrinterMenuItem, Me.TargetMenuItem, Me.Separator, Me.OpenMenuItem, Me.ExitMenuItem})
        Me.FileMenu.Text = "&File"
        '
        'MonitorMenuItem
        '
        Me.MonitorMenuItem.Index = 0
        Me.MonitorMenuItem.Text = "Open &Monitor Profile"
        '
        'PrinterMenuItem
        '
        Me.PrinterMenuItem.Index = 1
        Me.PrinterMenuItem.Text = "Open &Printer Profile"
        '
        'TargetMenuItem
        '
        Me.TargetMenuItem.Index = 2
        Me.TargetMenuItem.Text = "Open &Target Profile"
        '
        'Separator
        '
        Me.Separator.Index = 3
        Me.Separator.Text = "-"
        '
        'OpenMenuItem
        '
        Me.OpenMenuItem.Index = 4
        Me.OpenMenuItem.Text = "&Open Image"
        '
        'ExitMenuItem
        '
        Me.ExitMenuItem.Index = 5
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
        'imageXView1
        '
        Me.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
        Me.imageXView1.Location = New System.Drawing.Point(8, 179)
        Me.imageXView1.Name = "imageXView1"
        Me.imageXView1.Size = New System.Drawing.Size(510, 441)
        Me.imageXView1.TabIndex = 10
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(840, 675)
        Me.Controls.Add(Me.imageXView1)
        Me.Controls.Add(Me.RenderComboBox)
        Me.Controls.Add(Me.RenderLabel)
        Me.Controls.Add(Me.ProofingCheckBox)
        Me.Controls.Add(Me.ICMCheckBox)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.ErrorLabel2)
        Me.Controls.Add(Me.DescriptionListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Profiles"
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
    Dim strCommonImagesDirectory As System.String = "..\..\..\..\..\..\..\..\Common\Images\"
    Dim strCurrentDir As System.String = strCommonImagesDirectory
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
        dlg.InitialDirectory = strCurrentDir
        If (dlg.ShowDialog = DialogResult.OK) Then
            strCurrentDir = dlg.FileName.Remove(dlg.FileName.LastIndexOf("\"), (dlg.FileName.Length - dlg.FileName.LastIndexOf("\")))
            Return dlg.FileName
        Else
            Return ""
        End If
    End Function

    Private Overloads Function AccusoftOpenFile(ByVal strFilter As String) As String
        Dim dlg As OpenFileDialog = New OpenFileDialog()
        dlg.Title = "Select an Image File"
        dlg.Filter = strFilter
        dlg.InitialDirectory = strCurrentDir
        If (dlg.ShowDialog = DialogResult.OK) Then
            strCurrentDir = dlg.FileName.Remove(dlg.FileName.LastIndexOf("\"), (dlg.FileName.Length - dlg.FileName.LastIndexOf("\")))
            Return dlg.FileName
        Else
            Return ""
        End If
    End Function

#End Region

    Dim ICMMonitorProfile As String
    Dim ICMPrinterProfile As String
    Dim ICMTargetProfile As String
    Dim ICMRenderIntent As Accusoft.ImagXpressSdk.RenderIntent

    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm())
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
        'imagXpress1.Licensing.SetSolutionName("YourSolutionName")
        'imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345)
        'imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�")

        Try
            'Because in this sample the ImageX object is always located in the ImageXView
            'tell the ImageXView component to dispose of the ImageX object when itself is
            'disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
            'Dispose method before the components.Dispose() section.
            imageXView1.AutoImageDispose = True

            ICMMonitorProfile = imageXView1.MonitorProfileName
            ICMPrinterProfile = imageXView1.PrinterProfileName
            ICMTargetProfile = imageXView1.TargetProfileName
            ICMRenderIntent = imageXView1.ColorRenderIntent

            imageXView1.IcmEnabled = True
            imageXView1.IcmProofingEnabled = True

            strCurrentDir = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\..\Common\Images"
            If System.IO.Directory.Exists(strCurrentDir) Then
                System.IO.Directory.SetCurrentDirectory(strCurrentDir)
            End If
            strCurrentDir = System.IO.Directory.GetCurrentDirectory()

            imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, System.IO.Path.Combine(strCurrentDir, "window.jpg"))
            RenderComboBox.SelectedIndex = 0
        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            ErrorLabel.Text = ex.Message
        End Try
    End Sub

    Private Sub ImagXpressMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImagXpressMenuItem.Click
        imagXpress1.AboutBox()
    End Sub

    Private Sub ExitMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ShowMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMenuItem.Click
        If ShowMenuItem.Checked = True Then
            imageXView1.Toolbar.Activated = False
            ShowMenuItem.Checked = False
        Else
            imageXView1.Toolbar.Activated = True
            ShowMenuItem.Checked = True
        End If
    End Sub

    Private Sub OpenMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenMenuItem.Click

        Dim imgFilename As String = AccusoftOpenFile()

        If Not (imgFilename Is Nothing) Then
            Try
                If Not imageXView1.Image Is Nothing Then
                    imageXView1.Image.Dispose()
                End If
                imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, imgFilename)
                ErrorLabel.Text = ""
                ICMCheckBox.Checked = True
                ProofingCheckBox.Checked = True
            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(ex, ErrorLabel)
            End Try
        End If
    End Sub

    Private Sub RenderComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenderComboBox.SelectedIndexChanged
        ICMRenderIntent = CType(RenderComboBox.SelectedIndex, Accusoft.ImagXpressSdk.RenderIntent)
        imageXView1.ColorRenderIntent = ICMRenderIntent
    End Sub

    Private Sub ICMCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ICMCheckBox.CheckedChanged
        imageXView1.IcmEnabled = ICMCheckBox.Checked
    End Sub

    Private Sub ProofingCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProofingCheckBox.CheckedChanged
        imageXView1.IcmProofingEnabled = ProofingCheckBox.Checked
    End Sub

    Private Sub MonitorMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonitorMenuItem.Click
        Dim dlg As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()

        dlg.Filter = "All Files (*.*)|*.*"
        dlg.Title = "Open Profile"
        dlg.InitialDirectory = Environment.SystemDirectory + "\spool\drivers\color"

        dlg.ShowDialog()

        If Not (dlg.FileName Is Nothing) Then
            Try
                ICMMonitorProfile = dlg.FileName
                If Not (ICMMonitorProfile.Length = 0) Then
                    imageXView1.MonitorProfileName = ICMMonitorProfile
                    ICMCheckBox.Checked = True
                    ProofingCheckBox.Checked = False

                    imageXView1.IcmEnabled = True
                    imageXView1.IcmProofingEnabled = False
                End If
                ErrorLabel.Text = ""
            Catch ex As System.Exception
                ErrorLabel.Text = ex.Message
            End Try
        End If
    End Sub

    Private Sub PrinterMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrinterMenuItem.Click
        Dim dlg As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()

        dlg.Filter = "All Files (*.*)|*.*"
        dlg.Title = "Open Profile"
        dlg.InitialDirectory = Environment.SystemDirectory + "\spool\drivers\color"

        dlg.ShowDialog()

        If Not (dlg.FileName Is Nothing) Then
            Try
                ICMPrinterProfile = dlg.FileName
                If Not (ICMPrinterProfile.Length = 0) Then
                    imageXView1.PrinterProfileName = ICMPrinterProfile
                    ICMCheckBox.Checked = True
                    ProofingCheckBox.Checked = False

                    imageXView1.IcmEnabled = True
                    imageXView1.IcmProofingEnabled = False
                End If
                ErrorLabel.Text = ""
            Catch ex As System.Exception
                ErrorLabel.Text = ex.Message
            End Try
        End If
    End Sub

    Private Sub TargetMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TargetMenuItem.Click
        Dim dlg As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()

        dlg.Filter = "All Files (*.*)|*.*"
        dlg.Title = "Open Profile"
        dlg.InitialDirectory = Environment.SystemDirectory + "\spool\drivers\color"

        dlg.ShowDialog()

        If Not (dlg.FileName Is Nothing) Then
            Try
                ICMTargetProfile = dlg.FileName
                If Not (ICMTargetProfile.Length = 0) Then
                    imageXView1.TargetProfileName = ICMTargetProfile
                    ICMCheckBox.Checked = True
                    ProofingCheckBox.Checked = False

                    imageXView1.IcmEnabled = True
                    imageXView1.IcmProofingEnabled = False
                End If
                ErrorLabel.Text = ""
            Catch ex As System.Exception
                ErrorLabel.Text = ex.Message
            End Try
        End If
    End Sub
End Class
