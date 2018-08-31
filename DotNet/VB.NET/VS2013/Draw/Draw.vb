'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Imports Accusoft.ImagXpressSdk

Public Class DrawingForm
    Inherits System.Windows.Forms.Form

    'declare the global variables

    Private imagX1 As Accusoft.ImagXpressSdk.ImageX
    Private bitprc As Accusoft.ImagXpressSdk.Processor
    Private isDrawingWithPen As System.Boolean
    Private isMouseDrawing As System.Boolean
    Private LastDrawPoint As System.Drawing.PointF
    Friend WithEvents imagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
    Friend WithEvents imageXView1 As Accusoft.ImagXpressSdk.ImageXView

    'File I/O Variables

    Dim strimageFile As System.String

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
    Friend WithEvents mnuFile As System.Windows.Forms.MainMenu
    Friend WithEvents lstDesc As System.Windows.Forms.ListBox
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents lblerror As System.Windows.Forms.Label
    Friend WithEvents buttonCircle As System.Windows.Forms.Button
    Friend WithEvents buttonPie As System.Windows.Forms.Button
    Friend WithEvents buttonmouse As System.Windows.Forms.Button
    Friend WithEvents buttonTxt As System.Windows.Forms.Button
    Friend WithEvents btnMouse As System.Windows.Forms.Button
    Friend WithEvents mnuToolBar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
    Friend WithEvents lblErrorName As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DrawingForm))
        Me.mnuFile = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnuOpen = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.mnuQuit = New System.Windows.Forms.MenuItem()
        Me.mnuToolBar = New System.Windows.Forms.MenuItem()
        Me.mnuShow = New System.Windows.Forms.MenuItem()
        Me.mnuAbout = New System.Windows.Forms.MenuItem()
        Me.lstDesc = New System.Windows.Forms.ListBox()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.buttonCircle = New System.Windows.Forms.Button()
        Me.buttonPie = New System.Windows.Forms.Button()
        Me.buttonmouse = New System.Windows.Forms.Button()
        Me.buttonTxt = New System.Windows.Forms.Button()
        Me.btnMouse = New System.Windows.Forms.Button()
        Me.lblErrorName = New System.Windows.Forms.Label()
        Me.imagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
        Me.imageXView1 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.SuspendLayout()
        '
        'mnuFile
        '
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.mnuToolBar, Me.mnuAbout})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOpen, Me.MenuItem4, Me.mnuQuit})
        Me.MenuItem1.Text = "&File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Index = 0
        Me.mnuOpen.Text = "&Open"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "-"
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
        'lstDesc
        '
        Me.lstDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDesc.Items.AddRange(New Object() {"This sample demonstrates the following functionality:", "1) Drawing on an Image using the GDI+ .NET drawing features."})
        Me.lstDesc.Location = New System.Drawing.Point(16, 8)
        Me.lstDesc.Name = "lstDesc"
        Me.lstDesc.Size = New System.Drawing.Size(714, 43)
        Me.lstDesc.TabIndex = 1
        '
        'lblerror
        '
        Me.lblerror.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblerror.Location = New System.Drawing.Point(80, 54)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(650, 33)
        Me.lblerror.TabIndex = 3
        '
        'buttonCircle
        '
        Me.buttonCircle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonCircle.Location = New System.Drawing.Point(8, 393)
        Me.buttonCircle.Name = "buttonCircle"
        Me.buttonCircle.Size = New System.Drawing.Size(112, 24)
        Me.buttonCircle.TabIndex = 4
        Me.buttonCircle.Text = "Draw Circle"
        '
        'buttonPie
        '
        Me.buttonPie.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonPie.Location = New System.Drawing.Point(128, 393)
        Me.buttonPie.Name = "buttonPie"
        Me.buttonPie.Size = New System.Drawing.Size(112, 24)
        Me.buttonPie.TabIndex = 5
        Me.buttonPie.Text = "Draw Pie"
        '
        'buttonmouse
        '
        Me.buttonmouse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonmouse.Location = New System.Drawing.Point(248, 393)
        Me.buttonmouse.Name = "buttonmouse"
        Me.buttonmouse.Size = New System.Drawing.Size(213, 24)
        Me.buttonmouse.TabIndex = 6
        Me.buttonmouse.Text = "Draw Line"
        '
        'buttonTxt
        '
        Me.buttonTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonTxt.Location = New System.Drawing.Point(467, 393)
        Me.buttonTxt.Name = "buttonTxt"
        Me.buttonTxt.Size = New System.Drawing.Size(129, 24)
        Me.buttonTxt.TabIndex = 7
        Me.buttonTxt.Text = "DrawText"
        '
        'btnMouse
        '
        Me.btnMouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMouse.Location = New System.Drawing.Point(602, 393)
        Me.btnMouse.Name = "btnMouse"
        Me.btnMouse.Size = New System.Drawing.Size(136, 24)
        Me.btnMouse.TabIndex = 8
        Me.btnMouse.Text = "Enable Mouse Drawing"
        '
        'lblErrorName
        '
        Me.lblErrorName.Location = New System.Drawing.Point(16, 64)
        Me.lblErrorName.Name = "lblErrorName"
        Me.lblErrorName.Size = New System.Drawing.Size(64, 16)
        Me.lblErrorName.TabIndex = 9
        Me.lblErrorName.Text = "Last Error:"
        '
        'imageXView1
        '
        Me.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
        Me.imageXView1.Location = New System.Drawing.Point(19, 100)
        Me.imageXView1.Name = "imageXView1"
        Me.imageXView1.Size = New System.Drawing.Size(600, 281)
        Me.imageXView1.TabIndex = 10
        '
        'DrawingForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(747, 438)
        Me.Controls.Add(Me.imageXView1)
        Me.Controls.Add(Me.lblErrorName)
        Me.Controls.Add(Me.btnMouse)
        Me.Controls.Add(Me.buttonTxt)
        Me.Controls.Add(Me.buttonmouse)
        Me.Controls.Add(Me.buttonPie)
        Me.Controls.Add(Me.buttonCircle)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.lstDesc)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.mnuFile
        Me.Name = "DrawingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Draw"
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

    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New DrawingForm())
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
        imageXView1.AutoImageDispose = True

        imagX1 = New Accusoft.ImagXpressSdk.ImageX(imagXpress1)

        Try
            imageXView1.AutoImageDispose = True

            'here we set the current directory and image so that the file open dialog box works well

            strCurrentDir = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\..\Common\Images"
            If System.IO.Directory.Exists(strCurrentDir) Then
                System.IO.Directory.SetCurrentDirectory(strCurrentDir)
            End If
            strCurrentDir = System.IO.Directory.GetCurrentDirectory()

            strimageFile = System.IO.Path.Combine(strCurrentDir, "vermont.jpg")

            imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strimageFile)

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblerror)
        End Try
        isDrawingWithPen = False

    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Application.Exit()
    End Sub

    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        'obtain the filename of the image to open
        Dim strtemp As System.String = AccusoftOpenFile()
        If strtemp.Length <> 0 Then

            Try

                'clear out the error in case there was an error from a previous operation
                lblerror.Text = ""

                If Not imageXView1.Image Is Nothing Then
                    imageXView1.Image.Dispose()
                End If
                strimageFile = strtemp
                imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strimageFile)
            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(ex, lblerror)
            Catch ex As System.IO.IOException
                AccusoftError(ex, lblerror)

            End Try
        End If

    End Sub


    Private Sub buttonCircle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonCircle.Click

        ReLoadImage()
        Try
            Dim g As System.Drawing.Graphics = imageXView1.Image.GetGraphics()
            g.DrawEllipse(System.Drawing.Pens.Blue, 0, 0, 50, 50)
            imageXView1.Image.ReleaseGraphics(True)
        Catch ex As Exception
            lblerror.Text = ex.Message
        End Try
    End Sub

    Private Sub buttonPie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonPie.Click
        Try
            ReLoadImage()
            Dim g As System.Drawing.Graphics = imageXView1.Image.GetGraphics()
            g.DrawPie(System.Drawing.Pens.DarkBlue, 0, 0, 50, 50, 50, 270)
            imageXView1.Image.ReleaseGraphics(True)
        Catch ex As Exception
            lblerror.Text = ex.Message
        End Try
    End Sub

    Private Sub buttonmouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonmouse.Click
        Try
            ReLoadImage()
            Dim g As System.Drawing.Graphics = imageXView1.Image.GetGraphics()
            g.DrawLine(System.Drawing.Pens.DarkBlue, 25, 50, 100, 150)
            imageXView1.Image.ReleaseGraphics(True)
        Catch ex As Exception
            lblerror.Text = ex.Message
        End Try
    End Sub

    Private Sub buttonTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonTxt.Click
        Try
            ReLoadImage()
            Dim g As System.Drawing.Graphics = imageXView1.Image.GetGraphics()
            g.DrawString(System.DateTime.Now.ToShortDateString(), New System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif.Name, 18, FontStyle.Bold), System.Drawing.Brushes.DarkBlue, 0, 0)
            imageXView1.Image.ReleaseGraphics(True)
        Catch ex As Exception
            lblerror.Text = ex.Message
        End Try

    End Sub

    Private Sub ReLoadImage()
        Try
            Dim oldImage As Accusoft.ImagXpressSdk.ImageX = imageXView1.Image
            imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strimageFile)
            If imageXView1.Image.ImageXData.BitsPerPixel <> 24 Then
                bitprc = New Accusoft.ImagXpressSdk.Processor(imagXpress1, imageXView1.Image)
                bitprc.ColorDepth(24, PaletteType.Fixed, DitherType.NoDither)
                bitprc.Dispose()
            End If
            oldImage.Dispose()
        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblerror)
        End Try
    End Sub

    Private Sub btnMouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMouse.Click
        isDrawingWithPen = Not isDrawingWithPen
        If isDrawingWithPen Then
            btnMouse.Text = "Disable Mouse Drawing"
        Else
            btnMouse.Text = "Enable Mouse Drawing"
        End If
    End Sub

    Private Sub ImageXView1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imageXView1.MouseUp
        isMouseDrawing = False
    End Sub

    Private Sub ImageXView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imageXView1.MouseDown
        isMouseDrawing = True
        If isDrawingWithPen Then
            LastDrawPoint.X = e.X
            LastDrawPoint.Y = e.Y
            LastDrawPoint = imageXView1.Translate(LastDrawPoint, TranslateType.ViewToPixel)
        End If
    End Sub

    Private Sub ImageXView1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imageXView1.MouseMove
        Try
            If isDrawingWithPen And isMouseDrawing Then
                Dim drawPoint As PointF
                drawPoint = imageXView1.Translate(New System.Drawing.PointF(e.X, e.Y), TranslateType.ViewToPixel)
                If (drawPoint.X >= 0 And drawPoint.Y >= 0) Then
                    Dim g As System.Drawing.Graphics = imageXView1.Image.GetGraphics()
                    g.DrawLine(System.Drawing.Pens.Black, LastDrawPoint, drawPoint)
                    g.Flush()
                    imageXView1.Image.ReleaseGraphics(True)
                    LastDrawPoint = drawPoint
                End If
            End If

        Catch ex As Exception
            lblerror.Text = ex.Message
        End Try
    End Sub

    Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
        Try

            If imageXView1.Toolbar.Activated = True Then
                mnuShow.Text = "Show"
                imageXView1.Toolbar.Activated = False
            Else
                mnuShow.Text = "Hide"
                imageXView1.Toolbar.Activated = True

            End If

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            AccusoftError(ex, lblerror)
        End Try
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        imagXpress1.AboutBox()
    End Sub
End Class
