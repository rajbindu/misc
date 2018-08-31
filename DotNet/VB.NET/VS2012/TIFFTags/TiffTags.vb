'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Imports Accusoft.ImagXpressSdk
Public Class MainForm
    Inherits System.Windows.Forms.Form
    Private colTags As Accusoft.ImagXpressSdk.ImageXTagCollection
    Private itag As Accusoft.ImagXpressSdk.ImageXTag

    'File I/O Variables
    Private strCurrentImage As System.String
    Dim sSaveFileName As System.String

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
    Friend WithEvents ImageXView1 As Accusoft.ImagXpressSdk.ImageXView
    Friend WithEvents ImagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
    Friend WithEvents cmdTags As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTool As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolShow As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
    Friend WithEvents lstTags As System.Windows.Forms.ListBox
    Friend WithEvents lstDesc As System.Windows.Forms.ListBox
    Friend WithEvents lblLastError As System.Windows.Forms.Label
    Friend WithEvents lblerror As System.Windows.Forms.Label
    Friend WithEvents lblLoadFileName As System.Windows.Forms.Label
    Friend WithEvents txtLoadFile As System.Windows.Forms.TextBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdAddMulti As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents lblSaveFileName As System.Windows.Forms.Label
    Friend WithEvents txtSaveFile As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.cmdTags = New System.Windows.Forms.Button()
        Me.ImagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
        Me.ImageXView1 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.lstTags = New System.Windows.Forms.ListBox()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnuOpen = New System.Windows.Forms.MenuItem()
        Me.mnuQuit = New System.Windows.Forms.MenuItem()
        Me.mnuTool = New System.Windows.Forms.MenuItem()
        Me.mnuToolShow = New System.Windows.Forms.MenuItem()
        Me.mnuAbout = New System.Windows.Forms.MenuItem()
        Me.lstDesc = New System.Windows.Forms.ListBox()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.lblLastError = New System.Windows.Forms.Label()
        Me.lblLoadFileName = New System.Windows.Forms.Label()
        Me.txtLoadFile = New System.Windows.Forms.TextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdAddMulti = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.lblSaveFileName = New System.Windows.Forms.Label()
        Me.txtSaveFile = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdTags
        '
        Me.cmdTags.Location = New System.Drawing.Point(8, 72)
        Me.cmdTags.Name = "cmdTags"
        Me.cmdTags.Size = New System.Drawing.Size(208, 24)
        Me.cmdTags.TabIndex = 0
        Me.cmdTags.Text = "1)Load an Image and Show the Tags"
        '
        'ImageXView1
        '
        Me.ImageXView1.Location = New System.Drawing.Point(280, 80)
        Me.ImageXView1.Name = "ImageXView1"
        Me.ImageXView1.Size = New System.Drawing.Size(307, 264)
        Me.ImageXView1.TabIndex = 1
        '
        'lstTags
        '
        Me.lstTags.Location = New System.Drawing.Point(8, 432)
        Me.lstTags.Name = "lstTags"
        Me.lstTags.Size = New System.Drawing.Size(440, 225)
        Me.lstTags.TabIndex = 2
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.mnuTool, Me.mnuAbout})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOpen, Me.mnuQuit})
        Me.MenuItem1.Text = "&File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Index = 0
        Me.mnuOpen.Text = "&Open"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 1
        Me.mnuQuit.Text = "&Quit"
        '
        'mnuTool
        '
        Me.mnuTool.Index = 1
        Me.mnuTool.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuToolShow})
        Me.mnuTool.Text = "&ToolBar"
        '
        'mnuToolShow
        '
        Me.mnuToolShow.Index = 0
        Me.mnuToolShow.Text = "Show"
        '
        'mnuAbout
        '
        Me.mnuAbout.Index = 2
        Me.mnuAbout.Text = "&About"
        '
        'lstDesc
        '
        Me.lstDesc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDesc.Items.AddRange(New Object() {"This sample demonstrates the following functionality:", "1)Loading an image and viewing all the TIFF tags via the ImageXTagCollection Clas" & _
                "s.", "2)Adding and saving tags in a TIFF image."})
        Me.lstDesc.Location = New System.Drawing.Point(8, 8)
        Me.lstDesc.Name = "lstDesc"
        Me.lstDesc.Size = New System.Drawing.Size(760, 56)
        Me.lstDesc.TabIndex = 3
        '
        'lblerror
        '
        Me.lblerror.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblerror.Location = New System.Drawing.Point(501, 383)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(200, 96)
        Me.lblerror.TabIndex = 38
        '
        'lblLastError
        '
        Me.lblLastError.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLastError.Location = New System.Drawing.Point(501, 359)
        Me.lblLastError.Name = "lblLastError"
        Me.lblLastError.Size = New System.Drawing.Size(184, 24)
        Me.lblLastError.TabIndex = 37
        Me.lblLastError.Text = "Last Error:"
        '
        'lblLoadFileName
        '
        Me.lblLoadFileName.Location = New System.Drawing.Point(16, 112)
        Me.lblLoadFileName.Name = "lblLoadFileName"
        Me.lblLoadFileName.Size = New System.Drawing.Size(112, 32)
        Me.lblLoadFileName.TabIndex = 41
        Me.lblLoadFileName.Text = "Load File Name:"
        '
        'txtLoadFile
        '
        Me.txtLoadFile.Enabled = False
        Me.txtLoadFile.Location = New System.Drawing.Point(16, 152)
        Me.txtLoadFile.Multiline = True
        Me.txtLoadFile.Name = "txtLoadFile"
        Me.txtLoadFile.Size = New System.Drawing.Size(248, 80)
        Me.txtLoadFile.TabIndex = 42
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Location = New System.Drawing.Point(8, 248)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(264, 24)
        Me.cmdAdd.TabIndex = 43
        Me.cmdAdd.Text = "2) Add Some Tiff Tags  (Tags 101 - 112)"
        '
        'cmdDelete
        '
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.Location = New System.Drawing.Point(8, 272)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(264, 24)
        Me.cmdDelete.TabIndex = 44
        Me.cmdDelete.Text = "3) Delete and ReAdd  (Tags 101 - 112)"
        '
        'cmdAddMulti
        '
        Me.cmdAddMulti.Enabled = False
        Me.cmdAddMulti.Location = New System.Drawing.Point(8, 296)
        Me.cmdAddMulti.Name = "cmdAddMulti"
        Me.cmdAddMulti.Size = New System.Drawing.Size(264, 24)
        Me.cmdAddMulti.TabIndex = 45
        Me.cmdAddMulti.Text = "4) Add Tags with multiple Data (Tags 201 - 212)"
        '
        'cmdSave
        '
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(8, 320)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(264, 24)
        Me.cmdSave.TabIndex = 46
        Me.cmdSave.Text = "5) Save the file and reload it with Modified Tags"
        '
        'lblSaveFileName
        '
        Me.lblSaveFileName.Location = New System.Drawing.Point(16, 352)
        Me.lblSaveFileName.Name = "lblSaveFileName"
        Me.lblSaveFileName.Size = New System.Drawing.Size(168, 24)
        Me.lblSaveFileName.TabIndex = 47
        Me.lblSaveFileName.Text = "Save File Name:"
        '
        'txtSaveFile
        '
        Me.txtSaveFile.Location = New System.Drawing.Point(8, 384)
        Me.txtSaveFile.Multiline = True
        Me.txtSaveFile.Name = "txtSaveFile"
        Me.txtSaveFile.Size = New System.Drawing.Size(440, 40)
        Me.txtSaveFile.TabIndex = 48
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(852, 676)
        Me.Controls.Add(Me.txtSaveFile)
        Me.Controls.Add(Me.lblSaveFileName)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdAddMulti)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtLoadFile)
        Me.Controls.Add(Me.lblLoadFileName)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.lblLastError)
        Me.Controls.Add(Me.lstDesc)
        Me.Controls.Add(Me.lstTags)
        Me.Controls.Add(Me.ImageXView1)
        Me.Controls.Add(Me.cmdTags)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TIFFTags"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTags.Click

        Try
            'clear out the error in case there was an error from a previous operation
            lblerror.Text = ""

            LoadFile()
            colTags = ImageXView1.Image.Tags
            PopulateTIFFTagListBox(colTags)

            cmdAdd.Enabled = True
            cmdDelete.Enabled = True
            cmdAddMulti.Enabled = True
            cmdSave.Enabled = True
        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblerror)
        End Try

    End Sub

    Public Sub PopulateTIFFTagListBox(ByVal ixTagColl As Accusoft.ImagXpressSdk.ImageXTagCollection)

        Dim ret As String

        lstTags.Items.Clear()

        lstTags.Items.Add("Tag" & Chr(9) & "Type" & Chr(9) & "Count" & Chr(9) & "Data")

        If Not ixTagColl Is Nothing Then
            'iterate through the tags collection
            For Each itag In ixTagColl
                ret = GetTagString(itag)
                'Add the returned items here 
                lstTags.Items.Add(itag.TagNumber & Chr(9) & itag.TagType & Chr(9) & itag.TagElementsCount & Chr(9) & ret)
            Next
        Else
            lblerror.Text = "This image does not contain any TIFF tags."
        End If

    End Sub
    Public Function GetTagString(ByVal itag As Accusoft.ImagXpressSdk.ImageXTag) As String

        Dim tagcounter As Integer
        Dim tagstring As String
        Dim outdata As String = ""

        Select Case (itag.TagType)
            'Ascii Tag data
            Case Accusoft.ImagXpressSdk.TagTypes.Ascii
                For tagcounter = 0 To itag.TagElementsCount - 1
                    outdata = outdata & Convert.ToChar((itag.GetTagBytes(tagcounter)))
                Next

                tagstring = outdata
                Return tagstring
                'Byte Tag data
            Case Accusoft.ImagXpressSdk.TagTypes.Byte
                For tagcounter = 0 To itag.TagElementsCount - 1
                    If tagcounter > 0 Then
                        outdata = outdata & ", "
                    End If
                    outdata = outdata & itag.GetTagBytes(tagcounter)
                Next
                tagstring = outdata
                Return tagstring
                'Double Tag Data
            Case Accusoft.ImagXpressSdk.TagTypes.Double

                'outdata = "Double:"
                For tagcounter = 0 To itag.TagElementsCount - 1
                    If tagcounter > 0 Then
                        outdata = outdata & ", "
                    End If
                    outdata = outdata & itag.GetTagDouble(tagcounter).ToString()
                Next
                tagstring = outdata
                Return tagstring
                'Float Tag Data
            Case Accusoft.ImagXpressSdk.TagTypes.Float

                'outdata = "Float:"
                For tagcounter = 0 To itag.TagElementsCount - 1
                    If tagcounter > 0 Then
                        outdata = outdata & ", "
                    End If
                    outdata = outdata & itag.GetTagFloat(tagcounter).ToString()
                Next
                tagstring = outdata
                Return tagstring
                'Long Tag Data
            Case Accusoft.ImagXpressSdk.TagTypes.Long

                'tagstring = "Long"

                For tagcounter = 0 To itag.TagElementsCount - 1
                    If tagcounter > 0 Then
                        outdata = outdata & ", "
                    End If
                    outdata = outdata & itag.GetTagUInt32(tagcounter).ToString()
                Next
                tagstring = outdata
                Return tagstring
                'Rational Tag Data
            Case Accusoft.ImagXpressSdk.TagTypes.Rational


                'tagstring = "Rational"
                For tagcounter = 0 To itag.TagElementsCount / 2 - 1
                    If tagcounter > 0 Then
                        outdata = outdata & ", "
                    End If
                    outdata = outdata & itag.GetTagRational(tagcounter * 2).ToString() & "/" & itag.GetTagRational((tagcounter * 2) + 1).ToString
                Next
                tagstring = outdata
                Return tagstring

                'Sbyte Tag Data
            Case Accusoft.ImagXpressSdk.TagTypes.[Sbyte]

                'outdata = "Sbyte"
                For tagcounter = 0 To itag.TagElementsCount - 1
                    If tagcounter > 0 Then
                        outdata = outdata & ", "
                    End If
                    outdata = outdata & itag.GetTagSBytes(tagcounter).ToString()
                Next
                tagstring = outdata
                Return tagstring

                'Short Tag Data
            Case Accusoft.ImagXpressSdk.TagTypes.Short

                'outdata = "Short"
                For tagcounter = 0 To itag.TagElementsCount - 1
                    If tagcounter > 0 Then
                        outdata = outdata & ", "
                    End If
                    outdata = outdata & itag.GetTagUInt16(tagcounter).ToString()
                Next
                tagstring = outdata
                Return tagstring
                'Slong Tag Data
            Case Accusoft.ImagXpressSdk.TagTypes.Slong

                'outdata = "SLong"
                For tagcounter = 0 To itag.TagElementsCount - 1
                    If tagcounter > 0 Then
                        outdata = outdata & ", "
                    End If
                    outdata = outdata & itag.GetTagInt32(tagcounter).ToString()
                Next
                tagstring = outdata
                Return tagstring
                'SRational Tag Data
            Case Accusoft.ImagXpressSdk.TagTypes.Srational

                'outdata = "SRational"
                For tagcounter = 0 To itag.TagElementsCount / 2 - 1
                    If tagcounter > 0 Then
                        outdata = outdata & ", "
                    End If
                    outdata = outdata & itag.GetTagSRational(tagcounter * 2).ToString() & "/" & itag.GetTagSRational((tagcounter * 2) + 1).ToString
                Next
                tagstring = outdata
                Return tagstring
                'Short Tag Data
            Case Accusoft.ImagXpressSdk.TagTypes.Sshort

                'outdata = "SShort"
                For tagcounter = 0 To itag.TagElementsCount - 1
                    If tagcounter > 0 Then
                        outdata = outdata & ", "
                    End If
                    outdata = outdata & itag.GetTagInt16(tagcounter).ToString()
                Next
                tagstring = outdata
                Return tagstring
                'Undefined Tag Data
            Case Accusoft.ImagXpressSdk.TagTypes.Undefine

                For tagcounter = 0 To itag.TagElementsCount - 1
                    If tagcounter > 0 Then
                        outdata = outdata & ", "
                    End If
                    outdata = outdata + itag.GetTagBytes(tagcounter).ToString()
                Next

                tagstring = outdata
                Return tagstring
        End Select

        tagstring = ""
        Return tagstring
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

        'Because in this sample the ImageX object is always located in the ImageXView
        'tell the ImageXView component to dispose of the ImageX object when itself is
        'disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
        'Dispose method before the components.Dispose() section.
        ImageXView1.AutoImageDispose = True

        'Set the current directory to the Common\Images directory
        strCurrentDir = System.IO.Path.Combine(Application.StartupPath, "..\..\..\..\..\..\..\..\..\..\Common\Images\")
        If (System.IO.Directory.Exists(strCurrentDir)) Then
            System.IO.Directory.SetCurrentDirectory(strCurrentDir)
        End If
        strCurrentDir = System.IO.Directory.GetCurrentDirectory()

        strCurrentImage = "benefits.tif"
        sSaveFileName = Application.StartupPath + "\TagsOutput.tif"
        txtLoadFile.Text = strCurrentImage
        txtSaveFile.Text = sSaveFileName

    End Sub


    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        'obtain the filename of the image to open
        Dim strtemp As System.String = AccusoftOpenFile()
        If strtemp.Length <> 0 Then

            Try
                strCurrentImage = strtemp

                lblerror.Text = ""

                LoadFile()
                colTags = ImageXView1.Image.Tags
                PopulateTIFFTagListBox(colTags)

            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(ex, lblerror)
            Catch ex As System.IO.IOException
                AccusoftError(ex, lblerror)

            End Try
        End If
    End Sub

    Private Sub LoadFile()
        Try
            If (ImageXView1.Image IsNot Nothing) Then
                ImageXView1.Image.Dispose()
                ImageXView1.Image = Nothing
            End If
            ImageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(ImagXpress1, strCurrentImage)
            txtLoadFile.Text = strCurrentImage

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblerror)
        End Try

    End Sub

    Private Sub mnuToolShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolShow.Click
        If ImageXView1.Toolbar.Activated = True Then
            mnuToolShow.Text = "Show"
            ImageXView1.Toolbar.Activated = False
        Else
            mnuToolShow.Text = "Hide"
            ImageXView1.Toolbar.Activated = True

        End If
    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Application.Exit()
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        ImagXpress1.AboutBox()
    End Sub


    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        Try

            ' We assemble and add some bogus TIFF tags
            ' This demonstrates adding each type of tag

            ' Byte - TIFF Type 1
            Dim byteTag(0) As Byte
            byteTag(0) = 1
            Dim my101Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my101Tag.TagNumber = 101
            my101Tag.TagType = TagTypes.Byte
            my101Tag.TagLevel = 0
            my101Tag.SetTagBytes(byteTag)
            colTags.Add(my101Tag)

            ' Ascii - TIFF Type 2
            Dim asciiTag As Byte()
            Dim encoding As New System.Text.ASCIIEncoding()
            asciiTag = encoding.GetBytes("Tag 2")
            Dim my102Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my102Tag.SetTagBytes(asciiTag)
            my102Tag.TagNumber = 102
            my102Tag.TagType = TagTypes.Ascii
            my102Tag.TagLevel = 0
            colTags.Add(my102Tag)

            ' Short - TIFF Type 3
            Dim shortTag(0) As Integer
            shortTag(0) = 3
            Dim my103Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my103Tag.TagNumber = 103
            my103Tag.TagType = TagTypes.Short
            my103Tag.TagLevel = 0
            my103Tag.SetTagUInt16(shortTag)
            colTags.Add(my103Tag)

            ' Long - TIFF Type 4
            Dim longTag(0) As Long
            longTag(0) = 4
            Dim my104Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my104Tag.TagNumber = 104
            my104Tag.TagType = TagTypes.Long
            my104Tag.TagLevel = 0
            my104Tag.SetTagUInt32(longTag)
            colTags.Add(my104Tag)

            ' Rational - TIFF Type 5
            Dim rationalTag(1) As Long ' Holder for rational data
            rationalTag(0) = 600 ' Numerator
            rationalTag(1) = 2 ' Denominator
            Dim my105Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my105Tag.TagNumber = 105
            my105Tag.TagType = TagTypes.Rational
            my105Tag.TagLevel = 0
            my105Tag.SetTagRational(rationalTag)
            colTags.Add(my105Tag)

            ' SByte - TIFF Type 6
            Dim sbyteTag(0) As Short
            sbyteTag(0) = -6
            Dim my106Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my106Tag.TagNumber = 106
            my106Tag.TagType = TagTypes.[Sbyte]
            my106Tag.TagLevel = 0
            my106Tag.SetTagSBytes(sbyteTag)
            colTags.Add(my106Tag)

            ' Undefine - TIFF Type 7
            Dim undefineTag(0) As Byte
            undefineTag(0) = 7
            Dim my107Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my107Tag.SetTagBytes(undefineTag)
            my107Tag.TagNumber = 107
            my107Tag.TagType = TagTypes.Undefine
            my107Tag.TagLevel = 0
            colTags.Add(my107Tag)

            ' SShort - TIFF Type 8
            Dim sshortTag(0) As Short
            sshortTag(0) = -8
            Dim my108Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my108Tag.TagNumber = 108
            my108Tag.TagType = TagTypes.Sshort
            my108Tag.TagLevel = 0
            my108Tag.SetTagInt16(sshortTag)
            colTags.Add(my108Tag)

            ' SLong - TIFF Type 9
            Dim slongTag(0) As Integer
            slongTag(0) = -9
            Dim my109Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my109Tag.TagNumber = 109
            my109Tag.TagType = TagTypes.Slong
            my109Tag.TagLevel = 0
            my109Tag.SetTagInt32(slongTag)
            colTags.Add(my109Tag)

            ' SRational - TIFF Type 10
            Dim srationalTag(1) As Integer ' Holder for srational data
            srationalTag(0) = -600 ' Numerator
            srationalTag(1) = 2 ' Denominator
            Dim my110Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my110Tag.TagNumber = 110
            my110Tag.TagType = TagTypes.Srational
            my110Tag.TagLevel = 0
            my110Tag.SetTagSRational(srationalTag)
            colTags.Add(my110Tag)

            ' Float - TIFF Type 11
            Dim floatTag(0) As Single
            floatTag(0) = 11.65
            Dim my111Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my111Tag.TagNumber = 111
            my111Tag.TagType = TagTypes.Float
            my111Tag.TagLevel = 0
            my111Tag.SetTagFloat(floatTag)
            colTags.Add(my111Tag)

            ' Double - TIFF Type 12
            Dim doubleTag(0) As Double
            doubleTag(0) = 12.42
            Dim my112Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my112Tag.TagNumber = 112
            my112Tag.TagType = TagTypes.Double
            my112Tag.TagLevel = 0
            my112Tag.SetTagDouble(doubleTag)
            colTags.Add(my112Tag)

            PopulateTIFFTagListBox(colTags)

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblerror)
        End Try

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

        Try

            ' Delete our bogus tags and readd them to test
            ' Retrieve, Add, and Delete for each tag type

            Dim i As Integer
            For i = 101 To 112
                Dim myTag As Accusoft.ImagXpressSdk.ImageXTag
                myTag = colTags.GetTag(i, 0)
                colTags.RemoveTag(i, 0)
                colTags.Add(myTag)

            Next

            PopulateTIFFTagListBox(colTags)

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblerror)
        End Try

    End Sub

    Private Sub cmdAddMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddMulti.Click

        Try

            ' Byte - TIFF Type 1
            Dim byteTag(2) As Byte
            byteTag(0) = 1
            byteTag(1) = 2
            byteTag(2) = 3
            Dim my201Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my201Tag.TagNumber = 201
            my201Tag.TagType = TagTypes.Byte
            my201Tag.TagLevel = 0
            my201Tag.SetTagBytes(byteTag)
            colTags.Add(my201Tag)

            ' Ascii - TIFF Type 2
            Dim asciiTag As Byte()
            Dim encoding As New System.Text.ASCIIEncoding()
            asciiTag = encoding.GetBytes("Tag 2")
            Dim my202Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my202Tag.SetTagBytes(asciiTag)
            my202Tag.TagNumber = 202
            my202Tag.TagType = TagTypes.Ascii
            my202Tag.TagLevel = 0
            colTags.Add(my202Tag)

            ' Short - TIFF Type 3
            Dim shortTag(2) As Integer
            shortTag(0) = 3
            shortTag(1) = 4
            shortTag(2) = 5
            Dim my203Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my203Tag.TagNumber = 203
            my203Tag.TagType = TagTypes.Short
            my203Tag.TagLevel = 0
            my203Tag.SetTagUInt16(shortTag)
            colTags.Add(my203Tag)

            ' Long - TIFF Type 4
            Dim longTag(2) As Long
            longTag(0) = 4
            longTag(1) = 5
            longTag(2) = 6
            Dim my204Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my204Tag.TagNumber = 204
            my204Tag.TagType = TagTypes.Long
            my204Tag.TagLevel = 0
            my204Tag.SetTagUInt32(longTag)
            colTags.Add(my204Tag)

            ' Rational - TIFF Type 5
            Dim rationalTag(5) As Long ' Holder for rational data
            rationalTag(0) = 600 ' Numerator
            rationalTag(1) = 2 ' Denominator
            rationalTag(2) = 720 ' Numerator
            rationalTag(3) = 10 ' Denominator
            rationalTag(4) = 300 ' Numerator
            rationalTag(5) = 1 ' Denominator
            Dim my205Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my205Tag.TagNumber = 205
            my205Tag.TagType = TagTypes.Rational
            my205Tag.TagLevel = 0
            my205Tag.SetTagRational(rationalTag)
            colTags.Add(my205Tag)

            ' SByte - TIFF Type 6
            Dim sbyteTag(2) As Short
            sbyteTag(0) = -6
            sbyteTag(1) = -7
            sbyteTag(2) = -8
            Dim my206Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my206Tag.TagNumber = 206
            my206Tag.TagType = TagTypes.[Sbyte]
            my206Tag.TagLevel = 0
            my206Tag.SetTagSBytes(sbyteTag)
            colTags.Add(my206Tag)

            ' Undefine - TIFF Type 7
            Dim undefineTag(2) As Byte
            undefineTag(0) = 7
            undefineTag(1) = 8
            undefineTag(2) = 9
            Dim my207Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my207Tag.SetTagBytes(undefineTag)
            my207Tag.TagNumber = 207
            my207Tag.TagType = TagTypes.Undefine
            my207Tag.TagLevel = 0
            colTags.Add(my207Tag)

            ' SShort - TIFF Type 8
            Dim sshortTag(2) As Short
            sshortTag(0) = -8
            sshortTag(1) = -9
            sshortTag(2) = -10
            Dim my208Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my208Tag.TagNumber = 208
            my208Tag.TagType = TagTypes.Sshort
            my208Tag.TagLevel = 0
            my208Tag.SetTagInt16(sshortTag)
            colTags.Add(my208Tag)

            ' SLong - TIFF Type 9
            Dim slongTag(2) As Integer
            slongTag(0) = -9
            slongTag(1) = -10
            slongTag(2) = -11
            Dim my209Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my209Tag.TagNumber = 209
            my209Tag.TagType = TagTypes.Slong
            my209Tag.TagLevel = 0
            my209Tag.SetTagInt32(slongTag)
            colTags.Add(my209Tag)

            ' SRational - TIFF Type 10
            Dim srationalTag(5) As Integer ' Holder for srational data
            srationalTag(0) = -600 ' Numerator
            srationalTag(1) = 2 ' Denominator
            srationalTag(2) = -720 ' Numerator
            srationalTag(3) = 10 ' Denominator
            srationalTag(4) = -300 ' Numerator
            srationalTag(5) = 1 ' Denominator
            Dim my210Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my210Tag.TagNumber = 210
            my210Tag.TagType = TagTypes.Srational
            my210Tag.TagLevel = 0
            my210Tag.SetTagSRational(srationalTag)
            colTags.Add(my210Tag)

            ' Float - TIFF Type 11
            Dim floatTag(2) As Single
            floatTag(0) = 11.65
            floatTag(1) = -12.65
            floatTag(2) = -13.65
            Dim my211Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my211Tag.TagNumber = 211
            my211Tag.TagType = TagTypes.Float
            my211Tag.TagLevel = 0
            my211Tag.SetTagFloat(floatTag)
            colTags.Add(my211Tag)

            ' Double - TIFF Type 12
            Dim doubleTag(2) As Double
            doubleTag(0) = 12.42
            doubleTag(1) = -13.42
            doubleTag(2) = -14.42
            Dim my212Tag As New Accusoft.ImagXpressSdk.ImageXTag()
            my212Tag.TagNumber = 212
            my212Tag.TagType = TagTypes.Double
            my212Tag.TagLevel = 0
            my212Tag.SetTagDouble(doubleTag)
            colTags.Add(my212Tag)

            PopulateTIFFTagListBox(colTags)

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblerror)
        End Try

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim so As Accusoft.ImagXpressSdk.SaveOptions
        Try

            If Not (ImageXView1.Image.Tags Is Nothing) Then
                ImageXView1.Image.Tags.Dispose()
                ImageXView1.Image.Tags = Nothing
            End If

            ImageXView1.Image.Tags = colTags

            so = New Accusoft.ImagXpressSdk.SaveOptions()
            so.Format = ImageXFormat.Tiff
            so.Tiff.Compression = Compression.NoCompression

            ImageXView1.Image.Save(txtSaveFile.Text, so)

            Application.DoEvents()

            'clear out the error in case there was an error from a previous operation
            lblerror.Text = ""

            LoadFile()

            colTags = ImageXView1.Image.Tags

            PopulateTIFFTagListBox(colTags)


        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblerror)
        Catch ex As System.IO.FileLoadException

        Catch ex As System.Exception
            AccusoftError(ex, lblerror)
        End Try
    End Sub


End Class
