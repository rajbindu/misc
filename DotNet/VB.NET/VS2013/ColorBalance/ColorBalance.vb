'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Imports Accusoft.ImagXpressSdk
Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private imgFileName As String
    Friend WithEvents imagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
    Friend WithEvents processor1 As Accusoft.ImagXpressSdk.Processor
    Friend WithEvents imageXView1 As Accusoft.ImagXpressSdk.ImageXView
    Friend WithEvents docAutoLightness As System.Windows.Forms.TabPage
    Friend WithEvents cmdAutoLightness As System.Windows.Forms.Button
    Friend WithEvents lblColorVal As System.Windows.Forms.Label
    Friend WithEvents hscrColor As System.Windows.Forms.HScrollBar

    Private imagX1 As Accusoft.ImagXpressSdk.ImageX

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

            ' Don't forget to dispose IX
            '
            If Not (imagXpress1 Is Nothing) Then

                imagXpress1.Dispose()
                imagXpress1 = Nothing
            End If

            If Not (imageXView1 Is Nothing) Then

                imageXView1.Dispose()
                imageXView1 = Nothing
            End If
            If Not (processor1 Is Nothing) Then

                processor1.Dispose()
                processor1 = Nothing
            End If
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
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblLastError As System.Windows.Forms.Label
    Friend WithEvents lstInfo As System.Windows.Forms.ListBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolbar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolbarShow As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents docAutoColorBalance As System.Windows.Forms.TabPage
    Friend WithEvents docAdjustColorBalance As System.Windows.Forms.TabPage
    Friend WithEvents cmdAutoColorbalance As System.Windows.Forms.Button
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents lblRed As System.Windows.Forms.Label
    Friend WithEvents lblGreen As System.Windows.Forms.Label
    Friend WithEvents lblBlue As System.Windows.Forms.Label
    Friend WithEvents hscrRed As System.Windows.Forms.HScrollBar
    Friend WithEvents hscrGreen As System.Windows.Forms.HScrollBar
    Friend WithEvents lblRedVal As System.Windows.Forms.Label
    Friend WithEvents lblGreenVal As System.Windows.Forms.Label
    Friend WithEvents lblBlueVal As System.Windows.Forms.Label
    Friend WithEvents cmdAdjustColorBalance As System.Windows.Forms.Button
    Friend WithEvents hscrBlue As System.Windows.Forms.HScrollBar
    Friend WithEvents cmdReloadImage As System.Windows.Forms.Button
    Friend WithEvents mnuReloadCurrentImage As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblLastError = New System.Windows.Forms.Label()
        Me.lstInfo = New System.Windows.Forms.ListBox()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.MenuItem()
        Me.mnuReloadCurrentImage = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.mnuQuit = New System.Windows.Forms.MenuItem()
        Me.mnuToolbar = New System.Windows.Forms.MenuItem()
        Me.mnuToolbarShow = New System.Windows.Forms.MenuItem()
        Me.mnuAbout = New System.Windows.Forms.MenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.docAutoColorBalance = New System.Windows.Forms.TabPage()
        Me.cmdAutoColorbalance = New System.Windows.Forms.Button()
        Me.docAdjustColorBalance = New System.Windows.Forms.TabPage()
        Me.lblColorVal = New System.Windows.Forms.Label()
        Me.hscrColor = New System.Windows.Forms.HScrollBar()
        Me.cmdAdjustColorBalance = New System.Windows.Forms.Button()
        Me.lblBlueVal = New System.Windows.Forms.Label()
        Me.lblGreenVal = New System.Windows.Forms.Label()
        Me.lblRedVal = New System.Windows.Forms.Label()
        Me.hscrBlue = New System.Windows.Forms.HScrollBar()
        Me.hscrGreen = New System.Windows.Forms.HScrollBar()
        Me.hscrRed = New System.Windows.Forms.HScrollBar()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.docAutoLightness = New System.Windows.Forms.TabPage()
        Me.cmdAutoLightness = New System.Windows.Forms.Button()
        Me.cmdReloadImage = New System.Windows.Forms.Button()
        Me.imagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
        Me.processor1 = New Accusoft.ImagXpressSdk.Processor(Me.components)
        Me.imageXView1 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.docAutoColorBalance.SuspendLayout()
        Me.docAdjustColorBalance.SuspendLayout()
        Me.docAutoLightness.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblError
        '
        Me.lblError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblError.Location = New System.Drawing.Point(664, 440)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(184, 77)
        Me.lblError.TabIndex = 35
        '
        'lblLastError
        '
        Me.lblLastError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLastError.Location = New System.Drawing.Point(656, 392)
        Me.lblLastError.Name = "lblLastError"
        Me.lblLastError.Size = New System.Drawing.Size(160, 77)
        Me.lblLastError.TabIndex = 34
        Me.lblLastError.Text = "Last Error:"
        '
        'lstInfo
        '
        Me.lstInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInfo.Items.AddRange(New Object() {"This sample demonstrates the following functionality:", "1) Adjusting the image color using the AutoLightness, AutoColorBalance, and Adjus" & _
                        "tColorBalance methods."})
        Me.lstInfo.Location = New System.Drawing.Point(16, 8)
        Me.lstInfo.Name = "lstInfo"
        Me.lstInfo.Size = New System.Drawing.Size(824, 30)
        Me.lstInfo.TabIndex = 33
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuToolbar, Me.mnuAbout})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileOpen, Me.mnuReloadCurrentImage, Me.MenuItem3, Me.mnuQuit})
        Me.mnuFile.Text = "&File"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Index = 0
        Me.mnuFileOpen.Text = "&Open Image..."
        '
        'mnuReloadCurrentImage
        '
        Me.mnuReloadCurrentImage.Index = 1
        Me.mnuReloadCurrentImage.Text = "Reload Current Image"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "-"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 3
        Me.mnuQuit.Text = "&Quit"
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
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.docAutoColorBalance)
        Me.TabControl1.Controls.Add(Me.docAdjustColorBalance)
        Me.TabControl1.Controls.Add(Me.docAutoLightness)
        Me.TabControl1.Location = New System.Drawing.Point(424, 128)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(392, 248)
        Me.TabControl1.TabIndex = 38
        '
        'docAutoColorBalance
        '
        Me.docAutoColorBalance.Controls.Add(Me.cmdAutoColorbalance)
        Me.docAutoColorBalance.Location = New System.Drawing.Point(4, 22)
        Me.docAutoColorBalance.Name = "docAutoColorBalance"
        Me.docAutoColorBalance.Size = New System.Drawing.Size(384, 222)
        Me.docAutoColorBalance.TabIndex = 1
        Me.docAutoColorBalance.Text = "AutoColorBalance"
        Me.docAutoColorBalance.UseVisualStyleBackColor = True
        '
        'cmdAutoColorbalance
        '
        Me.cmdAutoColorbalance.Location = New System.Drawing.Point(128, 168)
        Me.cmdAutoColorbalance.Name = "cmdAutoColorbalance"
        Me.cmdAutoColorbalance.Size = New System.Drawing.Size(128, 32)
        Me.cmdAutoColorbalance.TabIndex = 0
        Me.cmdAutoColorbalance.Text = "Apply"
        '
        'docAdjustColorBalance
        '
        Me.docAdjustColorBalance.Controls.Add(Me.lblColorVal)
        Me.docAdjustColorBalance.Controls.Add(Me.hscrColor)
        Me.docAdjustColorBalance.Controls.Add(Me.cmdAdjustColorBalance)
        Me.docAdjustColorBalance.Controls.Add(Me.lblBlueVal)
        Me.docAdjustColorBalance.Controls.Add(Me.lblGreenVal)
        Me.docAdjustColorBalance.Controls.Add(Me.lblRedVal)
        Me.docAdjustColorBalance.Controls.Add(Me.hscrBlue)
        Me.docAdjustColorBalance.Controls.Add(Me.hscrGreen)
        Me.docAdjustColorBalance.Controls.Add(Me.hscrRed)
        Me.docAdjustColorBalance.Controls.Add(Me.lblBlue)
        Me.docAdjustColorBalance.Controls.Add(Me.lblGreen)
        Me.docAdjustColorBalance.Controls.Add(Me.lblRed)
        Me.docAdjustColorBalance.Controls.Add(Me.lblColor)
        Me.docAdjustColorBalance.Location = New System.Drawing.Point(4, 22)
        Me.docAdjustColorBalance.Name = "docAdjustColorBalance"
        Me.docAdjustColorBalance.Size = New System.Drawing.Size(384, 222)
        Me.docAdjustColorBalance.TabIndex = 2
        Me.docAdjustColorBalance.Text = "AdjustColorBalance"
        Me.docAdjustColorBalance.UseVisualStyleBackColor = True
        '
        'lblColorVal
        '
        Me.lblColorVal.Location = New System.Drawing.Point(336, 16)
        Me.lblColorVal.Name = "lblColorVal"
        Me.lblColorVal.Size = New System.Drawing.Size(48, 24)
        Me.lblColorVal.TabIndex = 13
        '
        'hscrColor
        '
        Me.hscrColor.LargeChange = 1
        Me.hscrColor.Location = New System.Drawing.Point(104, 16)
        Me.hscrColor.Name = "hscrColor"
        Me.hscrColor.Size = New System.Drawing.Size(224, 16)
        Me.hscrColor.TabIndex = 12
        '
        'cmdAdjustColorBalance
        '
        Me.cmdAdjustColorBalance.Location = New System.Drawing.Point(144, 184)
        Me.cmdAdjustColorBalance.Name = "cmdAdjustColorBalance"
        Me.cmdAdjustColorBalance.Size = New System.Drawing.Size(120, 24)
        Me.cmdAdjustColorBalance.TabIndex = 11
        Me.cmdAdjustColorBalance.Text = "Apply"
        '
        'lblBlueVal
        '
        Me.lblBlueVal.Location = New System.Drawing.Point(336, 144)
        Me.lblBlueVal.Name = "lblBlueVal"
        Me.lblBlueVal.Size = New System.Drawing.Size(48, 16)
        Me.lblBlueVal.TabIndex = 10
        '
        'lblGreenVal
        '
        Me.lblGreenVal.Location = New System.Drawing.Point(336, 96)
        Me.lblGreenVal.Name = "lblGreenVal"
        Me.lblGreenVal.Size = New System.Drawing.Size(48, 24)
        Me.lblGreenVal.TabIndex = 9
        '
        'lblRedVal
        '
        Me.lblRedVal.Location = New System.Drawing.Point(336, 56)
        Me.lblRedVal.Name = "lblRedVal"
        Me.lblRedVal.Size = New System.Drawing.Size(48, 24)
        Me.lblRedVal.TabIndex = 8
        '
        'hscrBlue
        '
        Me.hscrBlue.LargeChange = 1
        Me.hscrBlue.Location = New System.Drawing.Point(104, 144)
        Me.hscrBlue.Minimum = -100
        Me.hscrBlue.Name = "hscrBlue"
        Me.hscrBlue.Size = New System.Drawing.Size(224, 16)
        Me.hscrBlue.TabIndex = 7
        '
        'hscrGreen
        '
        Me.hscrGreen.LargeChange = 1
        Me.hscrGreen.Location = New System.Drawing.Point(104, 96)
        Me.hscrGreen.Minimum = -100
        Me.hscrGreen.Name = "hscrGreen"
        Me.hscrGreen.Size = New System.Drawing.Size(224, 16)
        Me.hscrGreen.TabIndex = 6
        '
        'hscrRed
        '
        Me.hscrRed.LargeChange = 1
        Me.hscrRed.Location = New System.Drawing.Point(104, 56)
        Me.hscrRed.Minimum = -100
        Me.hscrRed.Name = "hscrRed"
        Me.hscrRed.Size = New System.Drawing.Size(224, 16)
        Me.hscrRed.TabIndex = 5
        '
        'lblBlue
        '
        Me.lblBlue.Location = New System.Drawing.Point(16, 144)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(72, 24)
        Me.lblBlue.TabIndex = 3
        Me.lblBlue.Text = "Blue:"
        '
        'lblGreen
        '
        Me.lblGreen.Location = New System.Drawing.Point(16, 96)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(64, 24)
        Me.lblGreen.TabIndex = 2
        Me.lblGreen.Text = "Green:"
        '
        'lblRed
        '
        Me.lblRed.Location = New System.Drawing.Point(16, 56)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(64, 24)
        Me.lblRed.TabIndex = 1
        Me.lblRed.Text = "Red:"
        '
        'lblColor
        '
        Me.lblColor.Location = New System.Drawing.Point(16, 16)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(64, 24)
        Me.lblColor.TabIndex = 0
        Me.lblColor.Text = "Color:"
        '
        'docAutoLightness
        '
        Me.docAutoLightness.Controls.Add(Me.cmdAutoLightness)
        Me.docAutoLightness.Location = New System.Drawing.Point(4, 22)
        Me.docAutoLightness.Name = "docAutoLightness"
        Me.docAutoLightness.Size = New System.Drawing.Size(384, 222)
        Me.docAutoLightness.TabIndex = 3
        Me.docAutoLightness.Text = "AutoLightness"
        Me.docAutoLightness.UseVisualStyleBackColor = True
        '
        'cmdAutoLightness
        '
        Me.cmdAutoLightness.Location = New System.Drawing.Point(127, 166)
        Me.cmdAutoLightness.Name = "cmdAutoLightness"
        Me.cmdAutoLightness.Size = New System.Drawing.Size(119, 34)
        Me.cmdAutoLightness.TabIndex = 0
        Me.cmdAutoLightness.Text = "Apply"
        Me.cmdAutoLightness.UseVisualStyleBackColor = True
        '
        'cmdReloadImage
        '
        Me.cmdReloadImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdReloadImage.Location = New System.Drawing.Point(520, 80)
        Me.cmdReloadImage.Name = "cmdReloadImage"
        Me.cmdReloadImage.Size = New System.Drawing.Size(168, 32)
        Me.cmdReloadImage.TabIndex = 39
        Me.cmdReloadImage.Text = "Reload Image"
        '
        'imageXView1
        '
        Me.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
        Me.imageXView1.Location = New System.Drawing.Point(16, 60)
        Me.imageXView1.Name = "imageXView1"
        Me.imageXView1.Size = New System.Drawing.Size(386, 478)
        Me.imageXView1.TabIndex = 40
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(864, 553)
        Me.Controls.Add(Me.imageXView1)
        Me.Controls.Add(Me.cmdReloadImage)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblLastError)
        Me.Controls.Add(Me.lstInfo)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Balance"
        Me.TabControl1.ResumeLayout(False)
        Me.docAutoColorBalance.ResumeLayout(False)
        Me.docAdjustColorBalance.ResumeLayout(False)
        Me.docAutoLightness.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim imagXpress2 As Accusoft.ImagXpressSdk.ImagXpress
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

            imageXView1.AutoScroll = True

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblError)
        End Try

        strCurrentDir = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\..\Common\Images"
        If System.IO.Directory.Exists(strCurrentDir) Then
            System.IO.Directory.SetCurrentDirectory(strCurrentDir)
        End If
        strCurrentDir = System.IO.Directory.GetCurrentDirectory()

        imgFileName = System.IO.Path.Combine(strCurrentDir, "ImagXpress AutoBalance Sample.jpg")

        LoadFile()

        lblBlueVal.Text = hscrBlue.Value.ToString()
        lblGreenVal.Text = hscrGreen.Value.ToString()
        lblRedVal.Text = hscrRed.Value.ToString()
        lblColorVal.Text = hscrColor.Value.ToString()

    End Sub

    Private Sub LoadFile()
        Try

            'clear out the error in case there was an error from a previous operation
            lblError.Text = ""

            If Not imageXView1.Image Is Nothing Then
                imageXView1.Image.Dispose()
            End If
            imagX1 = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, imgFileName)

            If imagX1.ImageXData.BitsPerPixel <> 24 Then
                MessageBox.Show("Image must be 24-bit for sample methods. Converting image to 24-bit.")
                processor1.Image = imagX1

                processor1.ColorDepth(24, PaletteType.Fixed, DitherType.NoDither)

            End If

            imageXView1.Image = imagX1


        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblError)
        End Try

    End Sub


    Private Sub hscrRed_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hscrRed.Scroll
        lblRedVal.Text = hscrRed.Value.ToString()
    End Sub

    Private Sub hscrGreen_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hscrGreen.Scroll
        lblGreenVal.Text = hscrGreen.Value.ToString()
    End Sub

    Private Sub hscrBlue_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hscrBlue.Scroll
        lblBlueVal.Text = hscrBlue.Value.ToString()
    End Sub

    Private Sub hscrColor_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hscrColor.Scroll
        lblColorVal.Text = hscrColor.Value.ToString()
    End Sub

    Private Sub cmdAutoLightness_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAutoLightness.Click

        Try

            processor1.Image = imageXView1.Image
            processor1.AutoLightness()

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblError)
        End Try

    End Sub

    Private Sub cmdAutoColorbalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAutoColorbalance.Click

        Try

            processor1.Image = imageXView1.Image
            processor1.AutoColorBalance()

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblError)
        End Try

    End Sub

    Private Sub cmdAdjustColorBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdjustColorBalance.Click
        Try

            processor1.Image = imageXView1.Image
            processor1.AdjustColorBalance(hscrColor.Value, hscrRed.Value, hscrGreen.Value, hscrBlue.Value)

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblError)
        End Try

    End Sub

    Private Sub mnuFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
        imgFileName = AccusoftOpenFile()
        LoadFile()
    End Sub


    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Application.Exit()
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

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        imagXpress1.AboutBox()
    End Sub

    Private Sub mnuReloadCurrentImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReloadCurrentImage.Click
        LoadFile()
    End Sub

    Private Sub cmdReloadImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReloadImage.Click
        LoadFile()
    End Sub

    Private Const colorScrollMinPct As Long = -100
    Private Const colorScrollMaxPct As Long = 100
    Private Const colorScrollMinVal As Long = -100
    Private Const colorScrollMaxVal As Long = 100

End Class
