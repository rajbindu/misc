'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace AutoRemoveRedEye

	Public Class AutoRemoveRedEye
	Inherits System.Windows.Forms.Form
        Private loLoadOptions As Accusoft.ImagXpressSdk.LoadOptions
        Private prc As Accusoft.ImagXpressSdk.Processor
        Private imagX1 As Accusoft.ImagXpressSdk.ImageX
        Private WithEvents cmdRemove As System.Windows.Forms.Button
        Private mainMenu1 As System.Windows.Forms.MainMenu
        Private menuItem1 As System.Windows.Forms.MenuItem
        Private lblerror As System.Windows.Forms.Label
        Private WithEvents mnuOpen As System.Windows.Forms.MenuItem
        Private menuItem2 As System.Windows.Forms.MenuItem
        Private WithEvents mnuQuit As System.Windows.Forms.MenuItem
        Private mnuToolBar As System.Windows.Forms.MenuItem
        Private WithEvents mnuShow As System.Windows.Forms.MenuItem
        Private WithEvents mnuAbout As System.Windows.Forms.MenuItem
        Private lsterror As System.Windows.Forms.Label
        Private strImageFile As System.String
        Private redeyex As System.Int32
        Private redeyey As System.Int32
        Private redeyewidth As System.Int32
        Private redeyeheight As System.Int32
        Private cmbGlare As System.Windows.Forms.ComboBox
        Private cmbShade As System.Windows.Forms.ComboBox
        Private lblGlare As System.Windows.Forms.Label
        Private lblShade As System.Windows.Forms.Label
        Private lstDesc As System.Windows.Forms.ListBox
        Private grpRedResult As System.Windows.Forms.GroupBox
        Private lblCount As System.Windows.Forms.Label
        Private RedEyeIndex As System.Windows.Forms.ColumnHeader
        Private XPos As System.Windows.Forms.ColumnHeader
        Private YPos As System.Windows.Forms.ColumnHeader
        Private resultsList As System.Windows.Forms.ListView
        Private lblRedDesc As System.Windows.Forms.Label
        Private AreaWidth As System.Windows.Forms.ColumnHeader
        Private AreaHeight As System.Windows.Forms.ColumnHeader
        Friend WithEvents ImagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
        Friend WithEvents ImageXView1 As Accusoft.ImagXpressSdk.ImageXView
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutoRemoveRedEye))
            Me.lstDesc = New System.Windows.Forms.ListBox()
            Me.cmdRemove = New System.Windows.Forms.Button()
            Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
            Me.menuItem1 = New System.Windows.Forms.MenuItem()
            Me.mnuOpen = New System.Windows.Forms.MenuItem()
            Me.menuItem2 = New System.Windows.Forms.MenuItem()
            Me.mnuQuit = New System.Windows.Forms.MenuItem()
            Me.mnuToolBar = New System.Windows.Forms.MenuItem()
            Me.mnuShow = New System.Windows.Forms.MenuItem()
            Me.mnuAbout = New System.Windows.Forms.MenuItem()
            Me.lblerror = New System.Windows.Forms.Label()
            Me.lsterror = New System.Windows.Forms.Label()
            Me.cmbGlare = New System.Windows.Forms.ComboBox()
            Me.cmbShade = New System.Windows.Forms.ComboBox()
            Me.lblGlare = New System.Windows.Forms.Label()
            Me.lblShade = New System.Windows.Forms.Label()
            Me.grpRedResult = New System.Windows.Forms.GroupBox()
            Me.lblRedDesc = New System.Windows.Forms.Label()
            Me.resultsList = New System.Windows.Forms.ListView()
            Me.RedEyeIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.YPos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.XPos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.AreaWidth = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.AreaHeight = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.lblCount = New System.Windows.Forms.Label()
            Me.ImagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
            Me.ImageXView1 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
            Me.grpRedResult.SuspendLayout()
            Me.SuspendLayout()
            '
            'lstDesc
            '
            Me.lstDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lstDesc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lstDesc.Items.AddRange(New Object() {"This sample demonstrates the following functionality:", "1) Using the AutoRemoveRedEye method in the ImagXpress control.", "2) Using the RedeyeCollection Class to retrieve information about the red eyes fo" & _
                            "und in the image."})
            Me.lstDesc.Location = New System.Drawing.Point(16, 8)
            Me.lstDesc.Name = "lstDesc"
            Me.lstDesc.Size = New System.Drawing.Size(736, 43)
            Me.lstDesc.TabIndex = 2
            '
            'cmdRemove
            '
            Me.cmdRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmdRemove.Location = New System.Drawing.Point(375, 203)
            Me.cmdRemove.Name = "cmdRemove"
            Me.cmdRemove.Size = New System.Drawing.Size(137, 32)
            Me.cmdRemove.TabIndex = 3
            Me.cmdRemove.Text = "AutoRemoveRedEye"
            '
            'mainMenu1
            '
            Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.mnuToolBar, Me.mnuAbout})
            '
            'menuItem1
            '
            Me.menuItem1.Index = 0
            Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOpen, Me.menuItem2, Me.mnuQuit})
            Me.menuItem1.Text = "&File"
            '
            'mnuOpen
            '
            Me.mnuOpen.Index = 0
            Me.mnuOpen.Text = "&Open"
            '
            'menuItem2
            '
            Me.menuItem2.Index = 1
            Me.menuItem2.Text = "-"
            '
            'mnuQuit
            '
            Me.mnuQuit.Index = 2
            Me.mnuQuit.Text = "&Quit"
            '
            'mnuToolBar
            '
            Me.mnuToolBar.Index = 1
            Me.mnuToolBar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShow})
            Me.mnuToolBar.Text = "&Toolbar"
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
            'lblerror
            '
            Me.lblerror.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblerror.Location = New System.Drawing.Point(320, 96)
            Me.lblerror.Name = "lblerror"
            Me.lblerror.Size = New System.Drawing.Size(432, 51)
            Me.lblerror.TabIndex = 5
            '
            'lsterror
            '
            Me.lsterror.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lsterror.Location = New System.Drawing.Point(320, 72)
            Me.lsterror.Name = "lsterror"
            Me.lsterror.Size = New System.Drawing.Size(112, 16)
            Me.lsterror.TabIndex = 6
            Me.lsterror.Text = "Last Error:"
            '
            'cmbGlare
            '
            Me.cmbGlare.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbGlare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbGlare.Items.AddRange(New Object() {"None", "Slight", "Full"})
            Me.cmbGlare.Location = New System.Drawing.Point(320, 171)
            Me.cmbGlare.Name = "cmbGlare"
            Me.cmbGlare.Size = New System.Drawing.Size(112, 21)
            Me.cmbGlare.TabIndex = 7
            '
            'cmbShade
            '
            Me.cmbShade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbShade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbShade.Items.AddRange(New Object() {"Normal", "Light", "Dark"})
            Me.cmbShade.Location = New System.Drawing.Point(455, 171)
            Me.cmbShade.Name = "cmbShade"
            Me.cmbShade.Size = New System.Drawing.Size(113, 21)
            Me.cmbShade.TabIndex = 8
            '
            'lblGlare
            '
            Me.lblGlare.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblGlare.Location = New System.Drawing.Point(320, 147)
            Me.lblGlare.Name = "lblGlare"
            Me.lblGlare.Size = New System.Drawing.Size(112, 16)
            Me.lblGlare.TabIndex = 9
            Me.lblGlare.Text = "Glare Settings"
            Me.lblGlare.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            '
            'lblShade
            '
            Me.lblShade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblShade.Location = New System.Drawing.Point(455, 147)
            Me.lblShade.Name = "lblShade"
            Me.lblShade.Size = New System.Drawing.Size(113, 16)
            Me.lblShade.TabIndex = 10
            Me.lblShade.Text = "Eye Shade"
            Me.lblShade.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            '
            'grpRedResult
            '
            Me.grpRedResult.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grpRedResult.Controls.Add(Me.lblRedDesc)
            Me.grpRedResult.Controls.Add(Me.resultsList)
            Me.grpRedResult.Controls.Add(Me.lblCount)
            Me.grpRedResult.Location = New System.Drawing.Point(312, 244)
            Me.grpRedResult.Name = "grpRedResult"
            Me.grpRedResult.Size = New System.Drawing.Size(440, 199)
            Me.grpRedResult.TabIndex = 11
            Me.grpRedResult.TabStop = False
            Me.grpRedResult.Text = "RedEye Results"
            '
            'lblRedDesc
            '
            Me.lblRedDesc.Location = New System.Drawing.Point(24, 32)
            Me.lblRedDesc.Name = "lblRedDesc"
            Me.lblRedDesc.Size = New System.Drawing.Size(160, 16)
            Me.lblRedDesc.TabIndex = 2
            Me.lblRedDesc.Text = "Number of Red Eyes Found:"
            '
            'resultsList
            '
            Me.resultsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RedEyeIndex, Me.YPos, Me.XPos, Me.AreaWidth, Me.AreaHeight})
            Me.resultsList.Location = New System.Drawing.Point(16, 56)
            Me.resultsList.Name = "resultsList"
            Me.resultsList.Size = New System.Drawing.Size(408, 128)
            Me.resultsList.TabIndex = 1
            Me.resultsList.UseCompatibleStateImageBehavior = False
            Me.resultsList.View = System.Windows.Forms.View.Details
            '
            'RedEyeIndex
            '
            Me.RedEyeIndex.Text = "RedEyeIndex"
            Me.RedEyeIndex.Width = 85
            '
            'YPos
            '
            Me.YPos.Text = "YPos"
            '
            'XPos
            '
            Me.XPos.Text = "XPos"
            '
            'AreaWidth
            '
            Me.AreaWidth.Text = "AreaWidth"
            Me.AreaWidth.Width = 100
            '
            'AreaHeight
            '
            Me.AreaHeight.Text = "AreaHeight"
            Me.AreaHeight.Width = 100
            '
            'lblCount
            '
            Me.lblCount.Location = New System.Drawing.Point(192, 32)
            Me.lblCount.Name = "lblCount"
            Me.lblCount.Size = New System.Drawing.Size(152, 16)
            Me.lblCount.TabIndex = 0
            '
            'ImageXView1
            '
            Me.ImageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
            Me.ImageXView1.Location = New System.Drawing.Point(15, 63)
            Me.ImageXView1.Name = "ImageXView1"
            Me.ImageXView1.Size = New System.Drawing.Size(278, 379)
            Me.ImageXView1.TabIndex = 12
            '
            'AutoRemoveRedEye
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(768, 460)
            Me.Controls.Add(Me.ImageXView1)
            Me.Controls.Add(Me.grpRedResult)
            Me.Controls.Add(Me.lblShade)
            Me.Controls.Add(Me.lblGlare)
            Me.Controls.Add(Me.cmbShade)
            Me.Controls.Add(Me.cmbGlare)
            Me.Controls.Add(Me.lsterror)
            Me.Controls.Add(Me.lblerror)
            Me.Controls.Add(Me.cmdRemove)
            Me.Controls.Add(Me.lstDesc)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Menu = Me.mainMenu1
            Me.Name = "AutoRemoveRedEye"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Auto Remove Red Eye"
            Me.grpRedResult.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New AutoRemoveRedEye())
        End Sub

        Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
            resultsList.Items.Clear()
            lblCount.Text = ""
            Dim gglare As Accusoft.ImagXpressSdk.RedeyeGlare = CType(cmbGlare.SelectedIndex, Accusoft.ImagXpressSdk.RedeyeGlare)
            Dim sshade As Accusoft.ImagXpressSdk.RedeyeShade = CType(cmbShade.SelectedIndex, Accusoft.ImagXpressSdk.RedeyeShade)
            prc = New Accusoft.ImagXpressSdk.Processor(imagXpress1, imageXView1.Image)
            Dim myRedEyes As Accusoft.ImagXpressSdk.RedeyeCollection = New Accusoft.ImagXpressSdk.RedeyeCollection()
            prc.Redeyes = myRedEyes
            prc.AutoRemoveRedeye(sshade, gglare, False)
            lblCount.Text = myRedEyes.Count.ToString
            Dim counter As Integer = 0
            While counter < myRedEyes.Count
                redeyex = myRedEyes.GetRedeyeRectangle(counter).Xposition
                redeyey = myRedEyes.GetRedeyeRectangle(counter).Yposition
                redeyewidth = myRedEyes.GetRedeyeRectangle(counter).Width
                redeyeheight = myRedEyes.GetRedeyeRectangle(counter).Height
                resultsList.Items.Add(New ListViewItem(New String() {counter.ToString, redeyex.ToString, redeyey.ToString, redeyewidth.ToString, redeyeheight.ToString}))
                System.Math.Min(System.Threading.Interlocked.Increment(counter), counter - 1)
            End While
            prc.Dispose()
            prc = Nothing
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

        Sub AccusoftTextBoxScrollBinder(ByVal scrScroll As System.Windows.Forms.ScrollBar, ByVal textTextBox As System.Windows.Forms.TextBox)
            Dim iTmp As System.Int32
            Try
                iTmp = Convert.ToInt32(textTextBox.Text, cultNumber)
            Catch ex As System.NullReferenceException
                AccusoftError(ex, lblerror)
                textTextBox.Text = scrScroll.Value.ToString(cultNumber)
                Return
            Catch ex As System.Exception
                AccusoftError(ex, lblerror)
                textTextBox.Text = scrScroll.Value.ToString(cultNumber)
                Return
            End Try
            If (iTmp < scrScroll.Maximum) AndAlso (iTmp > scrScroll.Minimum) Then
                scrScroll.Value = iTmp
            Else
                iTmp = scrScroll.Value
            End If
            textTextBox.Text = iTmp.ToString(cultNumber)
        End Sub

#End Region



        Private Sub AutoRemoveRedEye_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

            cmbGlare.SelectedIndex = 0
            cmbShade.SelectedIndex = 0
            Try
                loLoadOptions = New Accusoft.ImagXpressSdk.LoadOptions()
            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(ex, lblerror)
            End Try

            Try
                imagX1 = New Accusoft.ImagXpressSdk.ImageX(imagXpress1)

                strCurrentDir = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\..\Common\Images"
                If System.IO.Directory.Exists(strCurrentDir) Then
                    System.IO.Directory.SetCurrentDirectory(strCurrentDir)
                End If
                strCurrentDir = System.IO.Directory.GetCurrentDirectory()

                strImageFile = System.IO.Path.Combine(strCurrentDir, "ImagXpress RedEye 2 Sample.jpg")

                imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImageFile, loLoadOptions)
            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(ex, lblerror)
            End Try
        End Sub

        Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
            imagXpress1.AboutBox()
        End Sub

        Private Sub mnuOpen_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
            Dim strTmp As System.String = AccusoftOpenFile()
            If Not (strTmp.Length = 0) Then
                Try

                    'clear out any error before next operation
                    lblerror.Text = ""

                    strImageFile = strTmp
                    If Not imageXView1.Image Is Nothing Then
                        imageXView1.Image.Dispose()
                    End If
                    imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImageFile, loLoadOptions)
                Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                    AccusoftError(ex, lblerror)
                Catch ex As System.IO.IOException
                    AccusoftError(ex, lblerror)
                End Try
                resultsList.Items.Clear()
            End If
        End Sub

        Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
            Application.Exit()
        End Sub

        Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
            Me.mnuShow.Text = Microsoft.VisualBasic.IIf((imageXView1.Toolbar.Activated), "&Show", "&Hide")
            Try
                imageXView1.Toolbar.Activated = Not imageXView1.Toolbar.Activated
            Catch eX As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(eX, lblerror)
            End Try
        End Sub

  
    End Class
End Namespace

