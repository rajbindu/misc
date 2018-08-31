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
Namespace AlphaChannels

    Public Class Alpha
        Inherits System.Windows.Forms.Form
        Private ixproc1 As Accusoft.ImagXpressSdk.Processor
        Friend WithEvents menuFile As System.Windows.Forms.MainMenu
        Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
        Friend WithEvents mnuOpen As System.Windows.Forms.MenuItem
        Friend WithEvents menuItem1 As System.Windows.Forms.MenuItem
        Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
        Friend WithEvents mnuToolBar As System.Windows.Forms.MenuItem
        Friend WithEvents mnuShow As System.Windows.Forms.MenuItem

        Private strCurrentImage As System.String
        Private strCurrentImage1 As System.String
        Private strCurrentImage2 As System.String
        Private strCurrentImage3 As System.String
        Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
        Friend WithEvents cmdAddAlpha As System.Windows.Forms.Button
        Friend WithEvents mnuAlpha As System.Windows.Forms.MenuItem
        Private lstdesc As System.Windows.Forms.ListBox
        Friend WithEvents cmbAlpha As System.Windows.Forms.ComboBox
        Private lblAlpha As System.Windows.Forms.Label
        Private lblsource As System.Windows.Forms.Label
        Friend WithEvents statusLabel As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
        Friend WithEvents ImagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
        Friend WithEvents ImageXView1 As Accusoft.ImagXpressSdk.ImageXView
        Friend WithEvents ImageXView2 As Accusoft.ImagXpressSdk.ImageXView
        Friend WithEvents Processor As Accusoft.ImagXpressSdk.Processor
        Private components As System.ComponentModel.IContainer

        Public Sub New()

            InitializeComponent()
        End Sub

        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alpha))
            Me.menuFile = New System.Windows.Forms.MainMenu(Me.components)
            Me.mnuFile = New System.Windows.Forms.MenuItem()
            Me.mnuOpen = New System.Windows.Forms.MenuItem()
            Me.mnuAlpha = New System.Windows.Forms.MenuItem()
            Me.menuItem1 = New System.Windows.Forms.MenuItem()
            Me.mnuQuit = New System.Windows.Forms.MenuItem()
            Me.mnuToolBar = New System.Windows.Forms.MenuItem()
            Me.mnuShow = New System.Windows.Forms.MenuItem()
            Me.mnuAbout = New System.Windows.Forms.MenuItem()
            Me.cmdAddAlpha = New System.Windows.Forms.Button()
            Me.lstdesc = New System.Windows.Forms.ListBox()
            Me.cmbAlpha = New System.Windows.Forms.ComboBox()
            Me.lblAlpha = New System.Windows.Forms.Label()
            Me.lblsource = New System.Windows.Forms.Label()
            Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
            Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
            Me.ImagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
            Me.ImageXView1 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
            Me.ImageXView2 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
            Me.Processor = New Accusoft.ImagXpressSdk.Processor(Me.components)
            Me.StatusStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'menuFile
            '
            Me.menuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuToolBar, Me.mnuAbout})
            '
            'mnuFile
            '
            Me.mnuFile.Index = 0
            Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOpen, Me.mnuAlpha, Me.menuItem1, Me.mnuQuit})
            Me.mnuFile.Text = "&File"
            '
            'mnuOpen
            '
            Me.mnuOpen.Index = 0
            Me.mnuOpen.Text = "&Open Source Image"
            '
            'mnuAlpha
            '
            Me.mnuAlpha.Index = 1
            Me.mnuAlpha.Text = "&Open Alpha Channel Image"
            '
            'menuItem1
            '
            Me.menuItem1.Index = 2
            Me.menuItem1.Text = "-"
            '
            'mnuQuit
            '
            Me.mnuQuit.Index = 3
            Me.mnuQuit.Text = "&Quit"
            '
            'mnuToolBar
            '
            Me.mnuToolBar.Index = 1
            Me.mnuToolBar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShow})
            Me.mnuToolBar.Text = "&ToolBar"
            '
            'mnuShow
            '
            Me.mnuShow.Index = 0
            Me.mnuShow.Text = "&Show"
            '
            'mnuAbout
            '
            Me.mnuAbout.Index = 2
            Me.mnuAbout.Text = "&About"
            '
            'cmdAddAlpha
            '
            Me.cmdAddAlpha.Location = New System.Drawing.Point(205, 91)
            Me.cmdAddAlpha.Name = "cmdAddAlpha"
            Me.cmdAddAlpha.Size = New System.Drawing.Size(269, 40)
            Me.cmdAddAlpha.TabIndex = 3
            Me.cmdAddAlpha.Text = "Blend Alpha Channel Image With Source Image"
            '
            'lstdesc
            '
            Me.lstdesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lstdesc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lstdesc.Items.AddRange(New Object() {"This sample demonstrates the following functionality:", "Merging an image with an alpha channel to a source image and displaying the combi" & _
                            "ned image. ", "", "You can select an Alpha Channel image in the dropdown list or load your own sourc" & _
                            "e image and/or ", "your own Alpha Channel image in the sample."})
            Me.lstdesc.Location = New System.Drawing.Point(16, 16)
            Me.lstdesc.Name = "lstdesc"
            Me.lstdesc.Size = New System.Drawing.Size(746, 69)
            Me.lstdesc.TabIndex = 4
            '
            'cmbAlpha
            '
            Me.cmbAlpha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbAlpha.Items.AddRange(New Object() {"AlphaImage1", "AlphaImage2", "AlphaImage3"})
            Me.cmbAlpha.Location = New System.Drawing.Point(16, 96)
            Me.cmbAlpha.Name = "cmbAlpha"
            Me.cmbAlpha.Size = New System.Drawing.Size(157, 21)
            Me.cmbAlpha.TabIndex = 5
            '
            'lblAlpha
            '
            Me.lblAlpha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblAlpha.Location = New System.Drawing.Point(37, 153)
            Me.lblAlpha.Name = "lblAlpha"
            Me.lblAlpha.Size = New System.Drawing.Size(154, 16)
            Me.lblAlpha.TabIndex = 7
            Me.lblAlpha.Text = "Alpha Channel Image"
            Me.lblAlpha.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            '
            'lblsource
            '
            Me.lblsource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblsource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblsource.Location = New System.Drawing.Point(308, 152)
            Me.lblsource.Name = "lblsource"
            Me.lblsource.Size = New System.Drawing.Size(394, 16)
            Me.lblsource.TabIndex = 8
            Me.lblsource.Text = "Source Image"
            Me.lblsource.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            '
            'statusLabel
            '
            Me.statusLabel.Name = "statusLabel"
            Me.statusLabel.Size = New System.Drawing.Size(22, 17)
            Me.statusLabel.Text = "Ok"
            '
            'StatusStrip1
            '
            Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel})
            Me.StatusStrip1.Location = New System.Drawing.Point(0, 529)
            Me.StatusStrip1.Name = "StatusStrip1"
            Me.StatusStrip1.Size = New System.Drawing.Size(774, 22)
            Me.StatusStrip1.SizingGrip = False
            Me.StatusStrip1.TabIndex = 12
            Me.StatusStrip1.Text = "StatusStrip1"
            '
            'ImageXView1
            '
            Me.ImageXView1.Location = New System.Drawing.Point(229, 172)
            Me.ImageXView1.Name = "ImageXView1"
            Me.ImageXView1.Size = New System.Drawing.Size(517, 344)
            Me.ImageXView1.TabIndex = 13
            '
            'ImageXView2
            '
            Me.ImageXView2.Location = New System.Drawing.Point(13, 172)
            Me.ImageXView2.Name = "ImageXView2"
            Me.ImageXView2.Size = New System.Drawing.Size(210, 344)
            Me.ImageXView2.TabIndex = 14
            '
            'Alpha
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(774, 551)
            Me.Controls.Add(Me.ImageXView2)
            Me.Controls.Add(Me.ImageXView1)
            Me.Controls.Add(Me.StatusStrip1)
            Me.Controls.Add(Me.lblsource)
            Me.Controls.Add(Me.lblAlpha)
            Me.Controls.Add(Me.cmbAlpha)
            Me.Controls.Add(Me.lstdesc)
            Me.Controls.Add(Me.cmdAddAlpha)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(780, 600)
            Me.Menu = Me.menuFile
            Me.MinimumSize = New System.Drawing.Size(780, 600)
            Me.Name = "Alpha"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Alpha Channels"
            Me.StatusStrip1.ResumeLayout(False)
            Me.StatusStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Alpha())
        End Sub

        Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
            Dim strLoadResult As System.String = AccusoftOpenFile()
            If Not (strLoadResult.Length = 0) Then
                strCurrentImage = strLoadResult
            End If

            'clear out the error before the next image load
            ResetStatus()

            Try
                If Not imageXView1.Image Is Nothing Then
                    imageXView1.Image.Dispose()
                End If
                imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strCurrentImage)
                ixproc1.Image = imageXView1.Image
            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                SetStatus(ex)
            End Try
        End Sub

        Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
            Application.Exit()
        End Sub

        Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
            Me.mnuShow.Text = Microsoft.VisualBasic.IIf((imageXView1.Toolbar.Activated), "&Show", "&Hide")
            Try
                imageXView1.Toolbar.Activated = Not imageXView1.Toolbar.Activated
            Catch eX As Accusoft.ImagXpressSdk.ImagXpressException
                SetStatus(eX)
            End Try
        End Sub

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

        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Dim strCurrentDir As String

            '***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
            'ImagXpress1.Licensing.SetSolutionName("YourSolutionName")
            'ImagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345)
            'ImagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�")

            'Because in this sample the ImageX object is always located in the ImageXView
            'tell the ImageXView component to dispose of the ImageX object when itself is
            'disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
            'Dispose method before the components.Dispose() section.
            imageXView1.AutoImageDispose = True
            imageXView2.AutoImageDispose = True

            'turn on AlphaBlend in the view that displays the image with the alpha channel
            imageXView2.AlphaBlend = True

            strCurrentDir = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\..\Common\Images"
            If System.IO.Directory.Exists(strCurrentDir) Then
                System.IO.Directory.SetCurrentDirectory(strCurrentDir)
            End If
            strCurrentDir = System.IO.Directory.GetCurrentDirectory()

            strCurrentImage = System.IO.Path.Combine(strCurrentDir, "alpha1.jpg")
            ixproc1 = New Accusoft.ImagXpressSdk.Processor(imagXpress1)
            strCurrentImage1 = System.IO.Path.Combine(strCurrentDir, "alpha1.tif")
            strCurrentImage2 = System.IO.Path.Combine(strCurrentDir, "alpha2.tif")
            strCurrentImage3 = System.IO.Path.Combine(strCurrentDir, "alpha3.tif")
            cmbAlpha.SelectedIndex = 0
            imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strCurrentImage1)
            If System.IO.File.Exists(strCurrentImage) Then
                Try
                    imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strCurrentImage)
                    ixproc1.Image = imageXView1.Image
                Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                    SetStatus(ex)
                End Try
            End If
        End Sub

        Private Sub ReloadImage()
            Try
                imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strCurrentImage)

            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                SetStatus(ex)
            End Try
        End Sub

        Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
            imagXpress1.AboutBox()
        End Sub

        Private Sub cmdAddAlpha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddAlpha.Click
            Try
                ResetStatus()
                Dim alphaImage As Accusoft.ImagXpressSdk.ImageX = imageXView2.Image.Copy

                ' Set an arbitrary location to merge the image into
                Dim pt As PointF = GetAlphaImageLocation()
                Dim size As New SizeF(alphaImage.ImageXData.Width, alphaImage.ImageXData.Height)
                ixproc1.SetArea(New RectangleF(pt, size))
                ixproc1.EnableArea = True

                ixproc1.Merge(alphaImage, MergeSize.Crop, MergeStyle.AlphaForeGroundOverBackGround, False, Color.Blue, 90, 90)
                If Not (alphaImage Is Nothing) Then
                    alphaImage.Dispose()
                    alphaImage = Nothing
                End If
                ixproc1.EnableArea = False
                SetStatus("Image successfully blended!")

            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                SetStatus(ex)
            End Try
        End Sub

        Private Sub mnuAlpha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAlpha.Click
            Dim strLoadResult As System.String = AccusoftOpenFile()

            'clear out the error before the next image load
            ResetStatus()

            Try
                If Not imageXView2.Image Is Nothing Then
                    imageXView2.Image.Dispose()
                End If
                imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strLoadResult)
            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                SetStatus(ex)
            End Try
        End Sub

        Private Function GetAlphaImageLocation() As PointF
            Dim pt As PointF = PointF.Empty
            Select Case cmbAlpha.SelectedIndex
                Case 0
                    pt = New PointF(100, 50)
                    Exit Select
                Case 1
                    pt = New PointF(0, 25)
                    Exit Select
                Case 2
                    pt = New PointF(500, 200)
                    Exit Select
            End Select
            Return pt
        End Function


        Private Sub cmbAlpha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlpha.SelectedIndexChanged

            'clear out the error before the next image load
            ResetStatus()

            Select Case cmbAlpha.SelectedIndex

                Case 0
                    imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strCurrentImage1)
                    ' break
                Case 1
                    imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strCurrentImage2)
                    ' break
                Case 2
                    imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strCurrentImage3)
                    ' break
            End Select
        End Sub

        Private Sub cmdReload_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            If System.IO.File.Exists(strCurrentImage) Then
                Try
                    imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strCurrentImage)
                Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                    SetStatus(ex)
                End Try
            End If
        End Sub


        Private Sub ResetStatus()
            statusLabel.Text = "Ok"
        End Sub

        Private Sub SetStatus(ByVal ex As ImagXpressException)
            SetStatus(((ex.Message & vbLf) + ex.Source & vbLf & "Error Number: ") + ex.Number.ToString())
        End Sub

        Private Sub SetStatus(ByVal status As String)
            statusLabel.Text = status
        End Sub


    End Class
End Namespace

