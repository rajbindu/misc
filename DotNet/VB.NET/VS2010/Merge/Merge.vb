'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Accusoft.ImagXpressSdk

Namespace Merge
    ' <summary>
    ' Summary description for Form1.
    ' </summary>
    Public Class MainForm
        Inherits System.Windows.Forms.Form

        Private WithEvents buttonMerge As System.Windows.Forms.Button
        Private WithEvents buttonQuit As System.Windows.Forms.Button
        Private WithEvents checkBoxTransparent As System.Windows.Forms.CheckBox
        Private WithEvents comboBoxMergeStyle As System.Windows.Forms.ComboBox
        Private WithEvents comboBoxTransparentColor As System.Windows.Forms.ComboBox
        Private WithEvents comboBoxMergeType As System.Windows.Forms.ComboBox
        Private WithEvents hScrollBarMax As System.Windows.Forms.HScrollBar
        Private WithEvents hScrollBarMin As System.Windows.Forms.HScrollBar
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private labelPctMax As System.Windows.Forms.Label
        Private labelPctMin As System.Windows.Forms.Label

        'File I/O Variables

        Dim strimageFile1 As System.String
        Dim strimageFile2 As System.String
        Dim process As Accusoft.ImagXpressSdk.Processor
        Private WithEvents imagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
        Private WithEvents IxSource As Accusoft.ImagXpressSdk.ImageXView
        Private WithEvents mainMenu1 As System.Windows.Forms.MainMenu
        Private WithEvents menuFile As System.Windows.Forms.MenuItem
        Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
        Private WithEvents buttonReloadDestination As System.Windows.Forms.Button
        Private bSelectionActive As Boolean
        Private WithEvents IxDest As Accusoft.ImagXpressSdk.ImageXView
        Private WithEvents menuToolbar As System.Windows.Forms.MenuItem
        Private WithEvents menuToolbarShow As System.Windows.Forms.MenuItem
        Private WithEvents menuFileOpenSource As System.Windows.Forms.MenuItem
        Private WithEvents menuFileOpenDest As System.Windows.Forms.MenuItem
        Private WithEvents menuFileQuit As System.Windows.Forms.MenuItem
        Private components As System.ComponentModel.IContainer

        ' <summary>
        ' Required designer variable.
        ' </summary>

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

        Public Sub New()
            MyBase.New()

            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub

        ' <summary>
        ' Clean up any resources being used.
        ' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If (Not (components) Is Nothing) Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

        ' <summary>
        ' Required method for Designer support - do not modify
        ' the contents of this method with the code editor.
        ' </summary>
        Friend WithEvents lblError As System.Windows.Forms.Label
        Friend WithEvents lblLastError As System.Windows.Forms.Label
        Friend WithEvents lstInfo As System.Windows.Forms.ListBox
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.buttonMerge = New System.Windows.Forms.Button()
            Me.buttonQuit = New System.Windows.Forms.Button()
            Me.checkBoxTransparent = New System.Windows.Forms.CheckBox()
            Me.comboBoxMergeStyle = New System.Windows.Forms.ComboBox()
            Me.imagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
            Me.IxSource = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
            Me.comboBoxTransparentColor = New System.Windows.Forms.ComboBox()
            Me.comboBoxMergeType = New System.Windows.Forms.ComboBox()
            Me.hScrollBarMax = New System.Windows.Forms.HScrollBar()
            Me.hScrollBarMin = New System.Windows.Forms.HScrollBar()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.labelPctMax = New System.Windows.Forms.Label()
            Me.labelPctMin = New System.Windows.Forms.Label()
            Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
            Me.menuFile = New System.Windows.Forms.MenuItem()
            Me.menuFileOpenSource = New System.Windows.Forms.MenuItem()
            Me.menuFileOpenDest = New System.Windows.Forms.MenuItem()
            Me.menuItem5 = New System.Windows.Forms.MenuItem()
            Me.menuFileQuit = New System.Windows.Forms.MenuItem()
            Me.menuToolbar = New System.Windows.Forms.MenuItem()
            Me.menuToolbarShow = New System.Windows.Forms.MenuItem()
            Me.menuItem2 = New System.Windows.Forms.MenuItem()
            Me.buttonReloadDestination = New System.Windows.Forms.Button()
            Me.IxDest = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
            Me.lblError = New System.Windows.Forms.Label()
            Me.lblLastError = New System.Windows.Forms.Label()
            Me.lstInfo = New System.Windows.Forms.ListBox()
            Me.SuspendLayout()
            '
            'buttonMerge
            '
            Me.buttonMerge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.buttonMerge.Location = New System.Drawing.Point(487, 200)
            Me.buttonMerge.Name = "buttonMerge"
            Me.buttonMerge.Size = New System.Drawing.Size(168, 31)
            Me.buttonMerge.TabIndex = 1
            Me.buttonMerge.Text = "Merge"
            '
            'buttonQuit
            '
            Me.buttonQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.buttonQuit.Location = New System.Drawing.Point(487, 279)
            Me.buttonQuit.Name = "buttonQuit"
            Me.buttonQuit.Size = New System.Drawing.Size(168, 32)
            Me.buttonQuit.TabIndex = 2
            Me.buttonQuit.Text = "Quit"
            '
            'checkBoxTransparent
            '
            Me.checkBoxTransparent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.checkBoxTransparent.Location = New System.Drawing.Point(12, 320)
            Me.checkBoxTransparent.Name = "checkBoxTransparent"
            Me.checkBoxTransparent.Size = New System.Drawing.Size(88, 16)
            Me.checkBoxTransparent.TabIndex = 6
            Me.checkBoxTransparent.Text = "Transparent"
            '
            'comboBoxMergeStyle
            '
            Me.comboBoxMergeStyle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.comboBoxMergeStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxMergeStyle.Items.AddRange(New Object() {"Normal", "If Darker", "If Lighter", "Additive", "Subtractive", "Superimpose", "Superimpose Bottom to Top", "Superimpose Horiz from Center", "Superimpose Horiz to Center", "Superimpose Left to Right", "Superimpose Right to Left", "Superimpose Top to Bottom", "Superimpose Vert. from Center", "Superimpose Vert. to Center"})
            Me.comboBoxMergeStyle.Location = New System.Drawing.Point(476, 341)
            Me.comboBoxMergeStyle.Name = "comboBoxMergeStyle"
            Me.comboBoxMergeStyle.Size = New System.Drawing.Size(196, 21)
            Me.comboBoxMergeStyle.TabIndex = 5
            '
            'IxSource
            '
            Me.IxSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.IxSource.Location = New System.Drawing.Point(460, 44)
            Me.IxSource.Name = "IxSource"
            Me.IxSource.Size = New System.Drawing.Size(212, 148)
            Me.IxSource.TabIndex = 15
            '
            'comboBoxTransparentColor
            '
            Me.comboBoxTransparentColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.comboBoxTransparentColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxTransparentColor.Enabled = False
            Me.comboBoxTransparentColor.Items.AddRange(New Object() {"Red", "Green", "Blue", "White"})
            Me.comboBoxTransparentColor.Location = New System.Drawing.Point(12, 341)
            Me.comboBoxTransparentColor.Name = "comboBoxTransparentColor"
            Me.comboBoxTransparentColor.Size = New System.Drawing.Size(145, 21)
            Me.comboBoxTransparentColor.TabIndex = 3
            '
            'comboBoxMergeType
            '
            Me.comboBoxMergeType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.comboBoxMergeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxMergeType.Items.AddRange(New Object() {"Crop", "Resize Area", "Resize Image", "Tile Image"})
            Me.comboBoxMergeType.Location = New System.Drawing.Point(163, 341)
            Me.comboBoxMergeType.Name = "comboBoxMergeType"
            Me.comboBoxMergeType.Size = New System.Drawing.Size(307, 21)
            Me.comboBoxMergeType.TabIndex = 4
            '
            'hScrollBarMax
            '
            Me.hScrollBarMax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.hScrollBarMax.LargeChange = 1
            Me.hScrollBarMax.Location = New System.Drawing.Point(176, 382)
            Me.hScrollBarMax.Name = "hScrollBarMax"
            Me.hScrollBarMax.Size = New System.Drawing.Size(496, 15)
            Me.hScrollBarMax.TabIndex = 7
            Me.hScrollBarMax.Value = 100
            '
            'hScrollBarMin
            '
            Me.hScrollBarMin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.hScrollBarMin.LargeChange = 1
            Me.hScrollBarMin.Location = New System.Drawing.Point(176, 419)
            Me.hScrollBarMin.Name = "hScrollBarMin"
            Me.hScrollBarMin.Size = New System.Drawing.Size(496, 15)
            Me.hScrollBarMin.TabIndex = 7
            '
            'label1
            '
            Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.label1.Location = New System.Drawing.Point(12, 382)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(144, 15)
            Me.label1.TabIndex = 18
            Me.label1.Text = "Superimpose Percent Max"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label2
            '
            Me.label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.label2.Location = New System.Drawing.Point(12, 419)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(136, 15)
            Me.label2.TabIndex = 19
            Me.label2.Text = "Superimpose Percent Min"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'labelPctMax
            '
            Me.labelPctMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.labelPctMax.Location = New System.Drawing.Point(149, 382)
            Me.labelPctMax.Name = "labelPctMax"
            Me.labelPctMax.Size = New System.Drawing.Size(24, 15)
            Me.labelPctMax.TabIndex = 20
            Me.labelPctMax.Text = "100"
            Me.labelPctMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'labelPctMin
            '
            Me.labelPctMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.labelPctMin.Location = New System.Drawing.Point(149, 419)
            Me.labelPctMin.Name = "labelPctMin"
            Me.labelPctMin.Size = New System.Drawing.Size(24, 15)
            Me.labelPctMin.TabIndex = 21
            Me.labelPctMin.Text = "0"
            Me.labelPctMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'mainMenu1
            '
            Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFile, Me.menuToolbar, Me.menuItem2})
            '
            'menuFile
            '
            Me.menuFile.Index = 0
            Me.menuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFileOpenSource, Me.menuFileOpenDest, Me.menuItem5, Me.menuFileQuit})
            Me.menuFile.Text = "&File"
            '
            'menuFileOpenSource
            '
            Me.menuFileOpenSource.Index = 0
            Me.menuFileOpenSource.Text = "Open &Source Image"
            '
            'menuFileOpenDest
            '
            Me.menuFileOpenDest.Index = 1
            Me.menuFileOpenDest.Text = "Open &Destination Image"
            '
            'menuItem5
            '
            Me.menuItem5.Index = 2
            Me.menuItem5.Text = "-"
            '
            'menuFileQuit
            '
            Me.menuFileQuit.Index = 3
            Me.menuFileQuit.Text = "&Quit"
            '
            'menuToolbar
            '
            Me.menuToolbar.Index = 1
            Me.menuToolbar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuToolbarShow})
            Me.menuToolbar.Text = "&Toolbar"
            '
            'menuToolbarShow
            '
            Me.menuToolbarShow.Index = 0
            Me.menuToolbarShow.Text = "&Show"
            '
            'menuItem2
            '
            Me.menuItem2.Index = 2
            Me.menuItem2.Text = "&About"
            '
            'buttonReloadDestination
            '
            Me.buttonReloadDestination.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.buttonReloadDestination.Location = New System.Drawing.Point(487, 239)
            Me.buttonReloadDestination.Name = "buttonReloadDestination"
            Me.buttonReloadDestination.Size = New System.Drawing.Size(168, 33)
            Me.buttonReloadDestination.TabIndex = 26
            Me.buttonReloadDestination.Text = "Reload Destination Image"
            '
            'IxDest
            '
            Me.IxDest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.IxDest.Location = New System.Drawing.Point(12, 44)
            Me.IxDest.Name = "IxDest"
            Me.IxDest.Size = New System.Drawing.Size(422, 270)
            Me.IxDest.TabIndex = 27
            '
            'lblError
            '
            Me.lblError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblError.Location = New System.Drawing.Point(73, 450)
            Me.lblError.Name = "lblError"
            Me.lblError.Size = New System.Drawing.Size(599, 40)
            Me.lblError.TabIndex = 34
            '
            'lblLastError
            '
            Me.lblLastError.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblLastError.Location = New System.Drawing.Point(12, 450)
            Me.lblLastError.Name = "lblLastError"
            Me.lblLastError.Size = New System.Drawing.Size(68, 13)
            Me.lblLastError.TabIndex = 33
            Me.lblLastError.Text = "Last Error:"
            '
            'lstInfo
            '
            Me.lstInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lstInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lstInfo.Items.AddRange(New Object() {"This sample demonstrates the following functionality:", "1)Using the Area and Merge methods to combine images together."})
            Me.lstInfo.Location = New System.Drawing.Point(12, 8)
            Me.lstInfo.Name = "lstInfo"
            Me.lstInfo.Size = New System.Drawing.Size(660, 30)
            Me.lstInfo.TabIndex = 37
            '
            'MainForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(684, 522)
            Me.Controls.Add(Me.lstInfo)
            Me.Controls.Add(Me.lblError)
            Me.Controls.Add(Me.lblLastError)
            Me.Controls.Add(Me.IxDest)
            Me.Controls.Add(Me.buttonReloadDestination)
            Me.Controls.Add(Me.labelPctMin)
            Me.Controls.Add(Me.labelPctMax)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.hScrollBarMin)
            Me.Controls.Add(Me.hScrollBarMax)
            Me.Controls.Add(Me.comboBoxMergeType)
            Me.Controls.Add(Me.comboBoxTransparentColor)
            Me.Controls.Add(Me.IxSource)
            Me.Controls.Add(Me.comboBoxMergeStyle)
            Me.Controls.Add(Me.checkBoxTransparent)
            Me.Controls.Add(Me.buttonQuit)
            Me.Controls.Add(Me.buttonMerge)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Menu = Me.mainMenu1
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Merge"
            Me.ResumeLayout(False)

        End Sub

        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New MainForm())
        End Sub

        Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Try

                Dim strCurrentDir As String

                '***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
                'imagXpress1.Licensing.SetSolutionName("YourSolutionName")
                'imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345)
                'imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�")

                'Because in this sample the ImageX object is always located in the ImageXView
                'tell the ImageXView component to dispose of the ImageX object when itself is
                'disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
                'Dispose method before the components.Dispose() section.
                IxSource.AutoImageDispose = True
                IxDest.AutoImageDispose = True

                'Set the current directory to the Common\Images directory
                strCurrentDir = System.IO.Path.Combine(Application.StartupPath, "..\..\..\..\..\..\..\..\..\..\Common\Images\")
                If (System.IO.Directory.Exists(strCurrentDir)) Then
                    System.IO.Directory.SetCurrentDirectory(strCurrentDir)
                End If
                strCurrentDir = System.IO.Directory.GetCurrentDirectory()

                strimageFile1 = "dome.jpg"
                strimageFile2 = "ball1.bmp"

                If (System.IO.File.Exists(strimageFile1)) Then
                    IxDest.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strimageFile1)
                End If

                If (System.IO.File.Exists(strimageFile2)) Then
                    IxSource.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strimageFile2)
                End If

                bSelectionActive = False
                comboBoxMergeType.SelectedIndex = 0
                comboBoxMergeStyle.SelectedIndex = 0
                comboBoxTransparentColor.SelectedIndex = 0

            Catch eX As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(eX, lblError)
            End Try

        End Sub

        Private Sub hScrollBarMax_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hScrollBarMax.ValueChanged
            labelPctMax.Text = hScrollBarMax.Value.ToString
        End Sub

        Private Sub hScrollBarMin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hScrollBarMin.ValueChanged
            labelPctMin.Text = hScrollBarMin.Value.ToString
        End Sub

        Private Sub buttonQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonQuit.Click
            Application.Exit()
        End Sub

        Private Sub checkBoxTransparent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBoxTransparent.Click
            comboBoxTransparentColor.Enabled = checkBoxTransparent.Checked
        End Sub

        Private Sub buttonMerge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonMerge.Click
            Dim ImageSource As Accusoft.ImagXpressSdk.ImageX

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            process = New Accusoft.ImagXpressSdk.Processor(imagXpress1, IxDest.Image)
            Dim MergeTL As System.Drawing.PointF = New System.Drawing.PointF(IxDest.Rubberband.Dimensions.X, IxDest.Rubberband.Dimensions.Y)
            Dim MergeSize As System.Drawing.SizeF = New System.Drawing.SizeF(IxDest.Rubberband.Dimensions.Width, IxDest.Rubberband.Dimensions.Height)
            Dim MergeRegion As System.Drawing.RectangleF = New System.Drawing.RectangleF(MergeTL, MergeSize)
            process.SetArea(MergeRegion)
            Dim daColor As System.Drawing.Color
            Select Case (comboBoxTransparentColor.SelectedIndex)
                Case 0
                    daColor = System.Drawing.Color.Red
                Case 1
                    daColor = System.Drawing.Color.FromArgb(0, 255, 0)
                Case 2
                    daColor = System.Drawing.Color.Blue
                Case 3
                    daColor = System.Drawing.Color.White
                Case Else
                    daColor = System.Drawing.Color.Black
            End Select

            ImageSource = IxSource.Image
            process.Merge(ImageSource, CType(comboBoxMergeType.SelectedIndex, Accusoft.ImagXpressSdk.MergeSize), CType(comboBoxMergeStyle.SelectedIndex, Accusoft.ImagXpressSdk.MergeStyle), checkBoxTransparent.Checked, daColor, hScrollBarMax.Value, hScrollBarMin.Value)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Sub


        Private Sub AccusoftTextBoxScrollBinder(ByVal scrScroll As System.Windows.Forms.ScrollBar, ByVal textTextBox As System.Windows.Forms.TextBox)
            Dim iTmp As Integer
            Try
                iTmp = Convert.ToInt32(textTextBox.Text, cultNumber)
            Catch ex As System.NullReferenceException
                AccusoftError(ex, lblError)
                textTextBox.Text = scrScroll.Value.ToString(cultNumber)
                Return
            Catch ex As System.Exception
                AccusoftError(ex, lblError)
                textTextBox.Text = scrScroll.Value.ToString(cultNumber)
                Return
            End Try
            If ((iTmp < scrScroll.Maximum) _
                        AndAlso (iTmp > scrScroll.Minimum)) Then
                scrScroll.Value = iTmp
            Else
                iTmp = scrScroll.Value
            End If
            textTextBox.Text = iTmp.ToString(cultNumber)
        End Sub

        Private Sub buttonReloadDestination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonReloadDestination.Click
            IxDest.AllowUpdate = False
            'Dispose the ImageX object if the ImageXView has one
            If (IxDest.Image IsNot Nothing) Then
                IxDest.Image.Dispose()
                IxDest.Image = Nothing
            End If
            IxDest.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strimageFile1)
            IxDest.AllowUpdate = True
        End Sub

        Private Sub IxDest_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles IxDest.MouseDown
            IxDest.Rubberband.Enabled = False
            IxDest.Rubberband.Start(New System.Drawing.Point(e.X, e.Y))
            IxDest.Rubberband.Enabled = True
            bSelectionActive = True
        End Sub

        Private Sub IxDest_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles IxDest.MouseMove
            If bSelectionActive Then
                IxDest.Rubberband.Update(New System.Drawing.Point(e.X, e.Y))
            End If
        End Sub

        Private Sub IxDest_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles IxDest.MouseUp
            IxDest.Rubberband.Update(New System.Drawing.Point(e.X, e.Y))
            bSelectionActive = False
        End Sub

        Private Sub menuToolbarShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuToolbarShow.Click
            If IxDest.Toolbar.Activated = True Then
                menuToolbarShow.Text = "Show"
                IxDest.Toolbar.Activated = False
                IxSource.Toolbar.Activated = False

            Else
                menuToolbarShow.Text = "Hide"
                IxDest.Toolbar.Activated = True
                IxSource.Toolbar.Activated = True
            End If
        End Sub

        Private Sub menuFileOpenSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuFileOpenSource.Click
            Dim strTmp As String = AccusoftOpenFile()
            If (strTmp.Length <> 0) Then
                strimageFile2 = strTmp
                Try
                    'clear out the error in case there was an error from a previous operation
                    lblError.Text = ""
                    'Dispose the ImageX object if the ImageXView has one
                    If (IxSource.Image IsNot Nothing) Then
                        IxSource.Image.Dispose()
                    End If
                    IxSource.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strimageFile2)
                Catch eX As Accusoft.ImagXpressSdk.ImagXpressException
                    AccusoftError(eX, lblError)
                End Try
            End If
        End Sub

        Private Sub menuFileOpenDest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuFileOpenDest.Click
            Dim strTmp As String = AccusoftOpenFile()
            If (strTmp.Length <> 0) Then
                strimageFile1 = strTmp
                Try
                    'clear out the error in case there was an error from a previous operation
                    lblError.Text = ""
                    'Dispose the ImageX object if the ImageXView has one
                    If (IxDest.Image IsNot Nothing) Then
                        IxDest.Image.Dispose()
                    End If
                    IxDest.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strimageFile1)
                Catch eX As Accusoft.ImagXpressSdk.ImagXpressException
                    AccusoftError(eX, lblError)
                End Try
            End If
        End Sub

        Private Sub menuFileQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuFileQuit.Click
            Application.Exit()
        End Sub

        Private Sub menuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem2.Click
            Try
                imagXpress1.AboutBox()
            Catch eX As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(eX, lblError)
            End Try
        End Sub


    End Class
End Namespace