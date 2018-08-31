'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Imports Accusoft.ImagXpressSdk
Public Class MainForm
    Inherits System.Windows.Forms.Form

    'declare variables

    Private strCurrentImage As System.String
    Friend WithEvents lblLoadStatus As System.Windows.Forms.Label
    Private WithEvents lstStatus As System.Windows.Forms.ListBox
    Private saveOptions As Accusoft.ImagXpressSdk.SaveOptions


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
    Friend WithEvents lstDesc As System.Windows.Forms.ListBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents lblerror As System.Windows.Forms.Label
    Friend WithEvents mnuToolBar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
    Friend WithEvents cmbMethod As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLoad As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmbSave As System.Windows.Forms.ComboBox
    Friend WithEvents lblLastError As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ImagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
        Me.ImageXView1 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.lstDesc = New System.Windows.Forms.ListBox()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuOpen = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.mnuQuit = New System.Windows.Forms.MenuItem()
        Me.mnuToolBar = New System.Windows.Forms.MenuItem()
        Me.mnuShow = New System.Windows.Forms.MenuItem()
        Me.mnuAbout = New System.Windows.Forms.MenuItem()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.cmbMethod = New System.Windows.Forms.ComboBox()
        Me.cmbLoad = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmbSave = New System.Windows.Forms.ComboBox()
        Me.lblLastError = New System.Windows.Forms.Label()
        Me.lblLoadStatus = New System.Windows.Forms.Label()
        Me.lstStatus = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ImagXpress1
        '
        '
        'ImageXView1
        '
        Me.ImageXView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
        Me.ImageXView1.AutoScroll = True
        Me.ImageXView1.Location = New System.Drawing.Point(16, 184)
        Me.ImageXView1.Name = "ImageXView1"
        Me.ImageXView1.Size = New System.Drawing.Size(384, 227)
        Me.ImageXView1.TabIndex = 0
        '
        'lstDesc
        '
        Me.lstDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDesc.Items.AddRange(New Object() {"This sample demonstrates the following functionality:", "1)Loading image data into the control via the FromFile, FromStream, FromHBitmap a" & _
                        "nd FromHdib methods.", "2)Using the SaveOptions class for saving to various image formats."})
        Me.lstDesc.Location = New System.Drawing.Point(16, 8)
        Me.lstDesc.Name = "lstDesc"
        Me.lstDesc.Size = New System.Drawing.Size(608, 56)
        Me.lstDesc.TabIndex = 1
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuToolBar, Me.mnuAbout})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOpen, Me.MenuItem2, Me.mnuQuit})
        Me.mnuFile.Text = "&File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Index = 0
        Me.mnuOpen.Text = "&Open"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "-"
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
        'lblerror
        '
        Me.lblerror.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblerror.Location = New System.Drawing.Point(320, 104)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(312, 72)
        Me.lblerror.TabIndex = 2
        '
        'cmbMethod
        '
        Me.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMethod.Items.AddRange(New Object() {"From File", "From Stream", "From HBITMAP", "From HDIB"})
        Me.cmbMethod.Location = New System.Drawing.Point(128, 88)
        Me.cmbMethod.Name = "cmbMethod"
        Me.cmbMethod.Size = New System.Drawing.Size(176, 21)
        Me.cmbMethod.TabIndex = 3
        '
        'cmbLoad
        '
        Me.cmbLoad.Location = New System.Drawing.Point(16, 88)
        Me.cmbLoad.Name = "cmbLoad"
        Me.cmbLoad.Size = New System.Drawing.Size(104, 32)
        Me.cmbLoad.TabIndex = 4
        Me.cmbLoad.Text = "Load Image By Method"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(16, 128)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(104, 32)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Save Image"
        '
        'cmbSave
        '
        Me.cmbSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSave.Items.AddRange(New Object() {"Save as BMP", "Save as JPG", "Save as TIFF"})
        Me.cmbSave.Location = New System.Drawing.Point(128, 128)
        Me.cmbSave.Name = "cmbSave"
        Me.cmbSave.Size = New System.Drawing.Size(176, 21)
        Me.cmbSave.TabIndex = 6
        '
        'lblLastError
        '
        Me.lblLastError.Location = New System.Drawing.Point(320, 72)
        Me.lblLastError.Name = "lblLastError"
        Me.lblLastError.Size = New System.Drawing.Size(160, 24)
        Me.lblLastError.TabIndex = 8
        Me.lblLastError.Text = "Last Error:"
        '
        'lblLoadStatus
        '
        Me.lblLoadStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoadStatus.Location = New System.Drawing.Point(406, 184)
        Me.lblLoadStatus.Name = "lblLoadStatus"
        Me.lblLoadStatus.Size = New System.Drawing.Size(136, 24)
        Me.lblLoadStatus.TabIndex = 46
        Me.lblLoadStatus.Text = "Load Status:"
        '
        'lstStatus
        '
        Me.lstStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstStatus.Location = New System.Drawing.Point(406, 216)
        Me.lstStatus.Name = "lstStatus"
        Me.lstStatus.Size = New System.Drawing.Size(218, 173)
        Me.lstStatus.TabIndex = 45
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(640, 441)
        Me.Controls.Add(Me.lblLoadStatus)
        Me.Controls.Add(Me.lstStatus)
        Me.Controls.Add(Me.lblLastError)
        Me.Controls.Add(Me.cmbSave)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmbLoad)
        Me.Controls.Add(Me.cmbMethod)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.lstDesc)
        Me.Controls.Add(Me.ImageXView1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Image Loading And Saving"
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

    Dim strDefaultImageFilter As String = "All ImagXpress Supported File Types|*.bmp;*.cal;*.dib;*.dca;*.mod;*.dcx;*.gif;*.jp2;*.jls;*.jpg;*.jif" & _
    ";*.ljp;*.pbm;*.pcx;*.pgm;*.pic;*.png;*.ppm;*.tiff;*.tif;*.tga;*.wsq;*.jb2;*.gif;*.jpeg;*.cals;*.jbig" & _
    "2;*.ico;*.rle;*.lzw;*.wbmp|Windows Bitmap (*.BMP)|*.bmp|CALS (*.CAL)|*.cal|Windows Device Independen" & _
    "t Bitmap(*.DIB)|*.dib|MO:DCA (*.DCA & *.MOD)|*.dca;*.mod|Zsoft Multiple Page (*.DCX)|*.dcx|CompuServ" & _
    "e GIF (*.GIF)|*.gif|JPEG 2000 (*.JP2)|*.jp2|JPEG LS (*.JLS)|*.jls|JFIF Compliant JPEG (*.JPG & *.JIF" & _
    ")|*.jpg;*.jif|Lossless JPEG (*.LJP)|*.ljp|Portable Bitmap (*.PBM)|*.pbm|Zsoft PaintBrush (*.PCX)|*.p" & _
    "cx|Portable Graymap (*.PGM)|*.pgm|Pegasus PIC or Enhanced PIC (*.PIC)|*.pic|Portable Network Graphic" & _
    "s (*.PNG)|*.png|Portable Pixmap (*.PPM)|*.ppm|Tagged Image Format (*.TIFF)|*.tif;*.tiff|Truevision T" & _
    "ARGA (*.TGA)|*.tga|WSQ Fingerprint File (*.WSQ)|*.wsq|JBIG2 File (*.JB2)|*.jb2|All Files (*.*)|*.*"


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

#End Region

    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm())
    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Application.Exit()
    End Sub

    Private Sub mnuOpen_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        'obtain the filename of the image to open
        Dim strtemp As System.String = AccusoftOpenFile()
        If strtemp.Length <> 0 Then
            Try
                Dim lo As Accusoft.ImagXpressSdk.LoadOptions = New Accusoft.ImagXpressSdk.LoadOptions()
                lo.CameraRawEnabled = True
                lo.LoadMode = LoadMode.Normal

                lblerror.Text = ""
                strCurrentImage = strtemp
                ImageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(ImagXpress1, strCurrentImage, lo)
            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(ex, lblerror)
            Catch ex As System.IO.IOException
                AccusoftError(ex, lblerror)

            End Try
        End If

    End Sub

    Private Sub LoadFile()
        Try
            ImageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(ImagXpress1, strCurrentImage)

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblerror)
        End Try

    End Sub

    Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
        If ImageXView1.Toolbar.Activated = True Then
            mnuShow.Text = "Show"
            ImageXView1.Toolbar.Activated = False
        Else
            mnuShow.Text = "Hide"
            ImageXView1.Toolbar.Activated = True

        End If
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        ImagXpress1.AboutBox()
    End Sub

    Private Sub ImageLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        cmbMethod.SelectedIndex = 0
        cmbSave.SelectedIndex = 0
        '***** Event handlers

        Try

            'Initial file to load
            strCurrentImage = "vermont.jpg"

            If (System.IO.File.Exists(strCurrentImage)) Then
                ImageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(ImagXpress1, strCurrentImage)
            End If

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblerror)
        End Try

    End Sub

    Private Sub cmbLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLoad.Click
        lblerror.Text = ""

        'Dispose the ImageX object if the ImageXView has one
        If (ImageXView1.Image IsNot Nothing) Then
            ImageXView1.Image.Dispose()
            ImageXView1.Image = Nothing
        End If

        Select Case cmbMethod.SelectedIndex
            Case 0
                Try
                    ImageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(ImagXpress1, strCurrentImage)
                Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                    AccusoftError(ex, lblerror)
                Catch ex As System.IO.FileLoadException
                    AccusoftError(ex, lblerror)
                Catch ex As System.Exception
                    AccusoftError(ex, lblerror)
                End Try
            Case 1
                Try
                    Dim fs As System.IO.FileStream = New System.IO.FileStream(strCurrentImage, IO.FileMode.Open, IO.FileAccess.Read)
                    ImageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromStream(ImagXpress1, fs)
                Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                    AccusoftError(ex, lblerror)
                Catch ex As System.IO.FileLoadException
                    AccusoftError(ex, lblerror)
                Catch ex As System.Exception
                    AccusoftError(ex, lblerror)
                End Try
            Case 2
                Try
                    Dim bbmp As New System.Drawing.Bitmap(strCurrentImage)
                    If Not bbmp Is Nothing Then
                        ImageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromHbitmap(ImagXpress1, bbmp.GetHbitmap())
                    Else
                        lblerror.Text = "Unable to load image into a Bitmap object."
                    End If
                Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                    AccusoftError(ex, lblerror)
                Catch ex As System.IO.FileLoadException

                Catch ex As System.Exception
                    AccusoftError(ex, lblerror)
                End Try
            Case 3
                Try
                    Dim bbmp As New System.Drawing.Bitmap(strCurrentImage)
                    If Not bbmp Is Nothing Then
                        ImageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromHdib(ImagXpress1, bbmp.GetHbitmap())
                    Else
                        lblerror.Text = "Unable to load image into a Bitmap object."
                    End If
                Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                    AccusoftError(ex, lblerror)
                Catch ex As System.IO.FileLoadException

                Catch ex As System.Exception
                    AccusoftError(ex, lblerror)
                End Try
        End Select

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim saveDirectory As String
        saveDirectory = Application.StartupPath

        Select Case cmbSave.SelectedIndex
            'bmp save
            Case 0
                Try
                    saveOptions = New Accusoft.ImagXpressSdk.SaveOptions()
                    saveOptions.Format = ImageXFormat.Bmp
                    ImageXView1.Image.Save(saveDirectory + "\temp.bmp", saveOptions)

                Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                    AccusoftError(ex, lblerror)
                Catch ex As System.IO.FileLoadException
                    AccusoftError(ex, lblerror)
                Catch ex As System.Exception
                    AccusoftError(ex, lblerror)
                End Try
                'jpg save
            Case 1
                Try
                    saveOptions = New Accusoft.ImagXpressSdk.SaveOptions()
                    saveOptions.Format = ImageXFormat.Jpeg
                    saveOptions.Jpeg.Chrominance = 13
                    saveOptions.Jpeg.Luminance = 13
                    saveOptions.Jpeg.SubSampling = SubSampling.SubSampling111
                    ImageXView1.Image.Save(saveDirectory + "\temp.jpg", saveOptions)

                Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                    AccusoftError(ex, lblerror)
                Catch ex As System.IO.FileLoadException
                    AccusoftError(ex, lblerror)
                Catch ex As System.Exception
                    AccusoftError(ex, lblerror)
                End Try

                'tiff save
            Case 2
                Try
                    saveOptions = New Accusoft.ImagXpressSdk.SaveOptions()
                    saveOptions.Format = ImageXFormat.Tiff
                    saveOptions.Tiff.Compression = Compression.Group4
                    ImageXView1.Image.Save(saveDirectory + "\temp.tiff", saveOptions)
                Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                    AccusoftError(ex, lblerror)
                Catch ex As System.IO.FileLoadException

                Catch ex As System.Exception
                    AccusoftError(ex, lblerror)
                End Try
        End Select

    End Sub

    Private Sub ImagXpress1_ImageStatusEvent(ByVal sender As System.Object, ByVal e As Accusoft.ImagXpressSdk.ImageStatusEventArgs) Handles ImagXpress1.ImageStatusEvent
        lstStatus.Items.Add(e.Status.ToString())
        lstStatus.SelectedIndex = lstStatus.Items.Count - 1
    End Sub

    Private Sub ImagXpress1_ProgressEvent(ByVal sender As System.Object, ByVal e As Accusoft.ImagXpressSdk.ProgressEventArgs) Handles ImagXpress1.ProgressEvent
        lstStatus.Items.Add(e.PercentDone.ToString(cultNumber) & "% Loading Complete.")
        If e.IsComplete Then
            lstStatus.Items.Add(e.TotalBytes & " Bytes Completed Loading.")
        End If
        lstStatus.SelectedIndex = lstStatus.Items.Count - 1
    End Sub
End Class
