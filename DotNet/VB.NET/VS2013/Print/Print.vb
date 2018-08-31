'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Imports Accusoft.ImagXpressSdk

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
    Friend WithEvents ImagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
    Friend WithEvents ImageXView1 As Accusoft.ImagXpressSdk.ImageXView
    Friend WithEvents DescriptionListBox As System.Windows.Forms.ListBox
    Friend WithEvents PrintButton1 As System.Windows.Forms.Button
    Friend WithEvents PrintButton2 As System.Windows.Forms.Button
    Friend WithEvents PrintButton3 As System.Windows.Forms.Button
    Friend WithEvents ErrorLabel2 As System.Windows.Forms.Label
    Friend WithEvents ErrorLabel As System.Windows.Forms.Label
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents FileMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ToolbarMenu As System.Windows.Forms.MenuItem
    Friend WithEvents AboutMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ImagXpressMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents ShowMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents ExitMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents OpenMenuItem As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ImagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
        Me.ImageXView1 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.DescriptionListBox = New System.Windows.Forms.ListBox()
        Me.PrintButton1 = New System.Windows.Forms.Button()
        Me.PrintButton2 = New System.Windows.Forms.Button()
        Me.PrintButton3 = New System.Windows.Forms.Button()
        Me.ErrorLabel2 = New System.Windows.Forms.Label()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.FileMenu = New System.Windows.Forms.MenuItem()
        Me.OpenMenuItem = New System.Windows.Forms.MenuItem()
        Me.ExitMenuItem = New System.Windows.Forms.MenuItem()
        Me.ToolbarMenu = New System.Windows.Forms.MenuItem()
        Me.ShowMenuItem = New System.Windows.Forms.MenuItem()
        Me.AboutMenu = New System.Windows.Forms.MenuItem()
        Me.ImagXpressMenuItem = New System.Windows.Forms.MenuItem()
        Me.SuspendLayout()
        '
        'ImageXView1
        '
        Me.ImageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
        Me.ImageXView1.AutoScroll = True
        Me.ImageXView1.Location = New System.Drawing.Point(8, 72)
        Me.ImageXView1.Name = "ImageXView1"
        Me.ImageXView1.Size = New System.Drawing.Size(384, 304)
        Me.ImageXView1.TabIndex = 0
        '
        'DescriptionListBox
        '
        Me.DescriptionListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionListBox.Items.AddRange(New Object() {"This sample demonstrates the following functionality:", "1) Printing an image with ImagXpress."})
        Me.DescriptionListBox.Location = New System.Drawing.Point(8, 8)
        Me.DescriptionListBox.Name = "DescriptionListBox"
        Me.DescriptionListBox.Size = New System.Drawing.Size(808, 43)
        Me.DescriptionListBox.TabIndex = 1
        '
        'PrintButton1
        '
        Me.PrintButton1.Location = New System.Drawing.Point(120, 432)
        Me.PrintButton1.Name = "PrintButton1"
        Me.PrintButton1.Size = New System.Drawing.Size(192, 32)
        Me.PrintButton1.TabIndex = 2
        Me.PrintButton1.Text = "Print Image Centered on Page"
        '
        'PrintButton2
        '
        Me.PrintButton2.Location = New System.Drawing.Point(120, 480)
        Me.PrintButton2.Name = "PrintButton2"
        Me.PrintButton2.Size = New System.Drawing.Size(192, 32)
        Me.PrintButton2.TabIndex = 3
        Me.PrintButton2.Text = "Print 2 Images Centered on Page"
        '
        'PrintButton3
        '
        Me.PrintButton3.Location = New System.Drawing.Point(120, 528)
        Me.PrintButton3.Name = "PrintButton3"
        Me.PrintButton3.Size = New System.Drawing.Size(192, 32)
        Me.PrintButton3.TabIndex = 4
        Me.PrintButton3.Text = "Print Image Fit to Page"
        '
        'ErrorLabel2
        '
        Me.ErrorLabel2.Location = New System.Drawing.Point(405, 515)
        Me.ErrorLabel2.Name = "ErrorLabel2"
        Me.ErrorLabel2.Size = New System.Drawing.Size(88, 16)
        Me.ErrorLabel2.TabIndex = 5
        Me.ErrorLabel2.Text = "Last Error:"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorLabel.Location = New System.Drawing.Point(408, 549)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(400, 59)
        Me.ErrorLabel.TabIndex = 6
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
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(826, 619)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.ErrorLabel2)
        Me.Controls.Add(Me.PrintButton3)
        Me.Controls.Add(Me.PrintButton2)
        Me.Controls.Add(Me.PrintButton1)
        Me.Controls.Add(Me.DescriptionListBox)
        Me.Controls.Add(Me.ImageXView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print"
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

    ' enumeration for telling the sample which type of document to print
    Private Enum SamplePrintType
        Centered
        TwoBy
        FullPage
    End Enum

    Private sampPrintType As SamplePrintType = SamplePrintType.Centered

    ' Declare the dialog.
    Private printPreviewDialog As PrintPreviewDialog

    ' Declare a PrintDocument object named document.
    Private document As System.Drawing.Printing.PrintDocument

    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm())
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        ' Initialize the Print Preview Dialog
        InitializePrintPreviewDialog()

        Try
            Dim filename As String = "vermont.jpg"
            If (System.IO.File.Exists(filename)) Then
                ImageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(ImagXpress1, filename)
            End If
        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            ErrorLabel.Text = ex.Message
        Finally
            EnablePrintButtons(ImageXView1.Image IsNot Nothing)
        End Try
    End Sub

    Private Sub OpenMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenMenuItem.Click
        Dim imgFilename As String = AccusoftOpenFile()
        If Not (imgFilename = "") Then
            Try
                If (ImageXView1.Image IsNot Nothing) Then
                    ImageXView1.Image.Dispose()
                    ImageXView1.Image = Nothing
                End If
                ImageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(ImagXpress1, imgFilename)
            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(ex, ErrorLabel)
            Finally
                EnablePrintButtons(ImageXView1.Image IsNot Nothing)
            End Try
        End If
    End Sub

    Private Sub ImagXpressMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImagXpressMenuItem.Click
        ImagXpress1.AboutBox()
    End Sub

    Private Sub ExitMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ShowMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMenuItem.Click
        If (ShowMenuItem.Checked = False) Then
            ImageXView1.Toolbar.Activated = True
            ShowMenuItem.Checked = True
        Else
            ImageXView1.Toolbar.Activated = False
            ShowMenuItem.Checked = False
        End If
    End Sub


    Private Sub EnablePrintButtons(ByVal enable As Boolean)
        Me.PrintButton1.Enabled = enable
        Me.PrintButton2.Enabled = enable
        Me.PrintButton3.Enabled = enable
    End Sub

    ' Initalize the Print Preview dialog.
    Private Sub InitializePrintPreviewDialog()
        ' Create a new PrintPreviewDialog using constructor.
        Me.printPreviewDialog = New PrintPreviewDialog()

        ' Create a new Document
        Me.document = New System.Drawing.Printing.PrintDocument()

        'Set the size, location, and name.
        Me.printPreviewDialog.ClientSize = New System.Drawing.Size(480, 320)
        Me.printPreviewDialog.Location = New System.Drawing.Point(100, 100)
        Me.printPreviewDialog.Name = "PrintPreviewDialog"

        ' Associate the event-handling method with the 
        ' document's PrintPage event.
        AddHandler Me.document.PrintPage, AddressOf document_PrintPage

        ' Set the minimum size the dialog can be resized to.
        Me.printPreviewDialog.MinimumSize = New System.Drawing.Size(375, 250)

        ' Set the UseAntiAlias property to true, which will allow the 
        ' operating system to smooth fonts.
        Me.printPreviewDialog.UseAntiAlias = True
    End Sub

    Private Sub PrintButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintButton1.Click
        Try
            PrintPreview(SamplePrintType.Centered, "Centered Image")
        Catch ex As Exception
            ErrorLabel.Text = ex.Message
        End Try
    End Sub

    Private Sub PrintButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintButton2.Click
        Try
            PrintPreview(SamplePrintType.TwoBy, "Two Images")
        Catch ex As Exception
            ErrorLabel.Text = ex.Message
        End Try
    End Sub

    Private Sub PrintButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintButton3.Click
        Try
            PrintPreview(SamplePrintType.FullPage, "Full Page")
        Catch ex As Exception
            ErrorLabel.Text = ex.Message
        End Try
    End Sub

    Private Sub PrintPreview(ByVal printType As SamplePrintType, ByVal documentName As [String])
        Me.sampPrintType = printType
        document.DocumentName = documentName
        Me.printPreviewDialog.Document = Me.document

        ' Call the ShowDialog method. This will trigger the document's
        '  PrintPage event.
        Me.printPreviewDialog.ShowDialog(Me)
    End Sub

    Private Sub document_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        ' This code will be called when the PrintPreviewDialog.Show method is called
        ' and when the document is sent to the printer

        Dim isPreview As Boolean = Me.document.PrintController.IsPreview
        ' Draw the image, call a helper routine
        HelperPrint(e.Graphics, Me.sampPrintType, isPreview, e.PageSettings.PrintableArea)
    End Sub

    Private Sub HelperPrint(ByVal g As Graphics, ByVal printType As SamplePrintType, ByVal isPreview As Boolean, ByVal printerArea As RectangleF)
        Dim width As Single = CSng(imageXView1.Image.ImageXData.Width)
        Dim height As Single = CSng(imageXView1.Image.ImageXData.Height)

        imageXView1.Image.ImageXData.Resolution.Units = GraphicsUnit.Inch

        Dim resx As Double = Math.Round(imageXView1.Image.ImageXData.Resolution.Dimensions.Width)
        Dim resy As Double = Math.Round(imageXView1.Image.ImageXData.Resolution.Dimensions.Height)

        ' Printable area for printers is in 1/100th of an inch, convert to inches
        printerArea.X /= 100
        printerArea.Y /= 100
        printerArea.Width /= 100
        printerArea.Height /= 100

        ' put the graphics into inches for convenience
        g.PageUnit = GraphicsUnit.Inch

        ' put width and height of image in terms of inches
        width = CSng((width / resx))
        height = CSng((height / resy))

        ' default to upper right
        Dim x As Single = 0.0F
        Dim y As Single = 0.0F
        Dim interSpacing As Single = 0.25F
        ' spacing between images
        Dim topBottomSpacing As Single = 0.0F
        ' spacing before first image and after second image
        Dim scaleFactor As Single = 1.0F
        Dim oldValue As Single = 0.0F

        ' keep the preview looking similiar to the hardcopy
        If isPreview Then
            x = printerArea.X
            y = printerArea.Y
        End If

        Select Case printType
            Case SamplePrintType.Centered
                ' allow for larger images, let both checks happen, may need to scale in both directions 
                If height > printerArea.Height Then
                    oldValue = height
                    height = printerArea.Height
                    scaleFactor = height / oldValue
                    width *= scaleFactor
                End If

                If width > printerArea.Width Then
                    oldValue = width
                    width = printerArea.Width
                    scaleFactor = width / oldValue
                    height *= scaleFactor
                End If

                x += (printerArea.Width - width) / 2
                y += (printerArea.Height - height) / 2

                imageXView1.Print(g, New RectangleF(x, y, width, height))
                Exit Select

            Case SamplePrintType.TwoBy
                ' trying to keep this simple, but allow for large images
                If ((height * 2) + interSpacing) > printerArea.Height Then
                    oldValue = height
                    height = (printerArea.Height / 2) - (interSpacing / 2)
                    scaleFactor = height / oldValue
                    width *= scaleFactor
                End If

                If width > printerArea.Width Then
                    oldValue = width
                    width = printerArea.Width
                    scaleFactor = width / oldValue
                    height *= scaleFactor
                End If

                interSpacing = CSng((printerArea.Height - (height * 2)))
                If interSpacing >= 0.25F * 3 Then
                    interSpacing /= 3
                    topBottomSpacing = interSpacing
                Else
                    topBottomSpacing = (interSpacing - 0.25F) / 2
                    If topBottomSpacing < 0 Then
                        topBottomSpacing = 0
                    End If
                    interSpacing = 0.25F
                End If

                x += (printerArea.Width - width) / 2
                y += topBottomSpacing

                imageXView1.Print(g, New RectangleF(x, y, width, height))

                y += (height + interSpacing)
                imageXView1.Print(g, New RectangleF(x, y, width, height))
                Exit Select

            Case SamplePrintType.FullPage
                imageXView1.Print(g, New RectangleF(x, y, printerArea.Width, printerArea.Height))
                Exit Select

        End Select
    End Sub

End Class
