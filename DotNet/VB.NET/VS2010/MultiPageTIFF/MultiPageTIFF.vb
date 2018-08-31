'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Namespace MultipageTIFF


    ' <summary>
    ' Summary description for Form1.
    ' </summary>
    Public Class MainForm

        Inherits System.Windows.Forms.Form
        Private strImageFile1 As String
        Private strImageFile2 As String
        Private strImageFile3 As String
        Private strMPFile As String
        Private strMP2File As String
        Private strTmpFile As String


#Region " Windows Form Designer generated code "
        ' <summary>
        ' Required designer variable.
        ' </summary>
        Private WithEvents buttonMake As System.Windows.Forms.Button
        Private WithEvents buttonRemove As System.Windows.Forms.Button
        Private WithEvents buttonInsert As System.Windows.Forms.Button
        Private WithEvents buttonCompact As System.Windows.Forms.Button
        Private mnuFile As System.Windows.Forms.MainMenu
        Private WithEvents mnuFileFile As System.Windows.Forms.MenuItem
        Private WithEvents mnuFileQuit As System.Windows.Forms.MenuItem
        Private imagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
        Private WithEvents mnuAbout As System.Windows.Forms.MenuItem
        Private components As System.ComponentModel.IContainer
        Friend WithEvents ImageXView1 As Accusoft.ImagXpressSdk.ImageXView
        Friend WithEvents ImageXView2 As Accusoft.ImagXpressSdk.ImageXView
        Friend WithEvents ImageXView3 As Accusoft.ImagXpressSdk.ImageXView
        Friend WithEvents lstInfo As System.Windows.Forms.ListBox
        Friend WithEvents lblError As System.Windows.Forms.Label
        Private WithEvents buttonInsertMulti As System.Windows.Forms.Button
        Private WithEvents buttonRemoveMulti As System.Windows.Forms.Button
        Friend WithEvents lblLastError As System.Windows.Forms.Label


        Public Sub New()
            MyBase.New()
            '
            ' Required for Windows Form Designer support
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
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.buttonMake = New System.Windows.Forms.Button()
            Me.buttonRemove = New System.Windows.Forms.Button()
            Me.buttonInsert = New System.Windows.Forms.Button()
            Me.buttonCompact = New System.Windows.Forms.Button()
            Me.mnuFile = New System.Windows.Forms.MainMenu(Me.components)
            Me.mnuFileFile = New System.Windows.Forms.MenuItem()
            Me.mnuFileQuit = New System.Windows.Forms.MenuItem()
            Me.mnuAbout = New System.Windows.Forms.MenuItem()
            Me.imagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
            Me.ImageXView1 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
            Me.ImageXView2 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
            Me.ImageXView3 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
            Me.lstInfo = New System.Windows.Forms.ListBox()
            Me.lblError = New System.Windows.Forms.Label()
            Me.lblLastError = New System.Windows.Forms.Label()
            Me.lblFileStats = New System.Windows.Forms.Label()
            Me.buttonInsertMulti = New System.Windows.Forms.Button()
            Me.buttonRemoveMulti = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'buttonMake
            '
            Me.buttonMake.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.buttonMake.Location = New System.Drawing.Point(511, 138)
            Me.buttonMake.Name = "buttonMake"
            Me.buttonMake.Size = New System.Drawing.Size(222, 24)
            Me.buttonMake.TabIndex = 4
            Me.buttonMake.Text = "Make Multi-page Tiff files "
            '
            'buttonRemove
            '
            Me.buttonRemove.Location = New System.Drawing.Point(511, 168)
            Me.buttonRemove.Name = "buttonRemove"
            Me.buttonRemove.Size = New System.Drawing.Size(109, 24)
            Me.buttonRemove.TabIndex = 5
            Me.buttonRemove.Text = "Remove Page 2"
            '
            'buttonInsert
            '
            Me.buttonInsert.Location = New System.Drawing.Point(512, 198)
            Me.buttonInsert.Name = "buttonInsert"
            Me.buttonInsert.Size = New System.Drawing.Size(109, 24)
            Me.buttonInsert.TabIndex = 6
            Me.buttonInsert.Text = "Insert Page 2"
            '
            'buttonCompact
            '
            Me.buttonCompact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.buttonCompact.Location = New System.Drawing.Point(511, 228)
            Me.buttonCompact.Name = "buttonCompact"
            Me.buttonCompact.Size = New System.Drawing.Size(222, 24)
            Me.buttonCompact.TabIndex = 7
            Me.buttonCompact.Text = "Compact"
            '
            'mnuFile
            '
            Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileFile, Me.mnuAbout})
            '
            'mnuFileFile
            '
            Me.mnuFileFile.Index = 0
            Me.mnuFileFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileQuit})
            Me.mnuFileFile.Text = "&File"
            '
            'mnuFileQuit
            '
            Me.mnuFileQuit.Index = 0
            Me.mnuFileQuit.Text = "&Quit"
            '
            'mnuAbout
            '
            Me.mnuAbout.Index = 1
            Me.mnuAbout.Text = "&About"
            '
            'ImageXView1
            '
            Me.ImageXView1.Location = New System.Drawing.Point(9, 138)
            Me.ImageXView1.Name = "ImageXView1"
            Me.ImageXView1.Size = New System.Drawing.Size(160, 168)
            Me.ImageXView1.TabIndex = 16
            '
            'ImageXView2
            '
            Me.ImageXView2.Location = New System.Drawing.Point(177, 138)
            Me.ImageXView2.Name = "ImageXView2"
            Me.ImageXView2.Size = New System.Drawing.Size(160, 168)
            Me.ImageXView2.TabIndex = 17
            '
            'ImageXView3
            '
            Me.ImageXView3.Location = New System.Drawing.Point(345, 138)
            Me.ImageXView3.Name = "ImageXView3"
            Me.ImageXView3.Size = New System.Drawing.Size(160, 168)
            Me.ImageXView3.TabIndex = 18
            '
            'lstInfo
            '
            Me.lstInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lstInfo.Items.AddRange(New Object() {"This sample demonstrates operations that ImagXpress can perform on Multiple page " & _
                            "Tiff files.", "1)Creating  multiple page Tiff files.", "2)Displaying individual pages.", "3)Obtaining the number of Pages.", "4)Deleting one or more pages.", "5)Inserting one or more pages.", "6)Compacting unused pages from a file."})
            Me.lstInfo.Location = New System.Drawing.Point(8, 16)
            Me.lstInfo.Name = "lstInfo"
            Me.lstInfo.Size = New System.Drawing.Size(710, 108)
            Me.lstInfo.TabIndex = 19
            '
            'lblError
            '
            Me.lblError.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblError.Location = New System.Drawing.Point(105, 363)
            Me.lblError.Name = "lblError"
            Me.lblError.Size = New System.Drawing.Size(608, 54)
            Me.lblError.TabIndex = 34
            '
            'lblLastError
            '
            Me.lblLastError.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblLastError.Location = New System.Drawing.Point(12, 374)
            Me.lblLastError.Name = "lblLastError"
            Me.lblLastError.Size = New System.Drawing.Size(71, 34)
            Me.lblLastError.TabIndex = 33
            Me.lblLastError.Text = "Last Error:"
            '
            'lblFileStats
            '
            Me.lblFileStats.Location = New System.Drawing.Point(10, 315)
            Me.lblFileStats.Name = "lblFileStats"
            Me.lblFileStats.Size = New System.Drawing.Size(479, 39)
            Me.lblFileStats.TabIndex = 35
            '
            'buttonInsertMulti
            '
            Me.buttonInsertMulti.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.buttonInsertMulti.Location = New System.Drawing.Point(624, 198)
            Me.buttonInsertMulti.Name = "buttonInsertMulti"
            Me.buttonInsertMulti.Size = New System.Drawing.Size(109, 24)
            Me.buttonInsertMulti.TabIndex = 37
            Me.buttonInsertMulti.Text = "Insert Pages 2-3"
            '
            'buttonRemoveMulti
            '
            Me.buttonRemoveMulti.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.buttonRemoveMulti.Location = New System.Drawing.Point(624, 168)
            Me.buttonRemoveMulti.Name = "buttonRemoveMulti"
            Me.buttonRemoveMulti.Size = New System.Drawing.Size(109, 24)
            Me.buttonRemoveMulti.TabIndex = 36
            Me.buttonRemoveMulti.Text = "Remove Pages 2-3"
            '
            'MainForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(740, 417)
            Me.Controls.Add(Me.buttonInsertMulti)
            Me.Controls.Add(Me.buttonRemoveMulti)
            Me.Controls.Add(Me.lblFileStats)
            Me.Controls.Add(Me.lblError)
            Me.Controls.Add(Me.lblLastError)
            Me.Controls.Add(Me.lstInfo)
            Me.Controls.Add(Me.ImageXView3)
            Me.Controls.Add(Me.ImageXView2)
            Me.Controls.Add(Me.ImageXView1)
            Me.Controls.Add(Me.buttonCompact)
            Me.Controls.Add(Me.buttonInsert)
            Me.Controls.Add(Me.buttonRemove)
            Me.Controls.Add(Me.buttonMake)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Menu = Me.mnuFile
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MultiPage TIFF"
            Me.ResumeLayout(False)

        End Sub

#End Region

        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New MainForm())
        End Sub

        Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Dim strCurrentDir As String


            '***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
            'imagXpress1.Licensing.SetSolutionName("YourSolutionName")
            'imagXpress1.Licensing.SetSolutionKey(12345, 12345, 12345, 12345)
            'imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�")


            'Because in this sample the ImageX object is always located in the ImageXView
            'tell the ImageXView component to dispose of the ImageX object when itself is
            'disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
            'Dispose method before the components.Dispose() section.
            ImageXView1.AutoImageDispose = True
            ImageXView2.AutoImageDispose = True
            ImageXView3.AutoImageDispose = True

            'Set the current directory to the Common\Images directory
            strCurrentDir = System.IO.Path.Combine(Application.StartupPath, "..\..\..\..\..\..\..\..\..\..\Common\Images\")
            If (System.IO.Directory.Exists(strCurrentDir)) Then
                System.IO.Directory.SetCurrentDirectory(strCurrentDir)
            End If
            strCurrentDir = System.IO.Directory.GetCurrentDirectory()

            strImageFile1 = "page1.tif"
            strImageFile2 = "page2.tif"
            strImageFile3 = "page3.tif"
            strMPFile = Application.StartupPath + "\multi.tif"
            strMP2File = Application.StartupPath + "\multi2.tif"
            strTmpFile = Application.StartupPath + "\compact.tif"

            buttonInsert.Enabled = False
            buttonInsertMulti.Enabled = False
            buttonRemove.Enabled = False
            buttonRemoveMulti.Enabled = False
            buttonCompact.Enabled = False

        End Sub

        Private Sub buttonMake_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonMake.Click
            Dim imgTmp As Accusoft.ImagXpressSdk.ImageX
            ClearErrorLabel()
            buttonMake.Enabled = False
            buttonRemove.Enabled = False
            buttonRemoveMulti.Enabled = False
            buttonInsert.Enabled = False
            buttonInsertMulti.Enabled = False
            buttonCompact.Enabled = False


            If System.IO.File.Exists(strMPFile) Then
                System.IO.File.Delete(strMPFile)
            End If
            If System.IO.File.Exists(strMP2File) Then
                System.IO.File.Delete(strMP2File)
            End If
            Try
                ' Create file with first page
                imgTmp = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strImageFile1)
                Dim soOpts As Accusoft.ImagXpressSdk.SaveOptions = New Accusoft.ImagXpressSdk.SaveOptions()
                soOpts.Format = Accusoft.ImagXpressSdk.ImageXFormat.Tiff
                soOpts.Tiff.Compression = Accusoft.ImagXpressSdk.Compression.NoCompression
                soOpts.Tiff.MultiPage = True
                imgTmp.Save(strMPFile, soOpts)
                imgTmp.Dispose()
                imgTmp = Nothing

                ' Insert pages 2 and 3
                Accusoft.ImagXpressSdk.ImageX.InsertPage(imagXpress1, strImageFile2, strMPFile, 2)
                Accusoft.ImagXpressSdk.ImageX.InsertPage(imagXpress1, strImageFile3, strMPFile, 3)
                ' Make an identical copy for multi-page inserts
                System.IO.File.Copy(strMPFile, strMP2File)

                buttonRemove.Enabled = True
                buttonRemoveMulti.Enabled = True
                buttonMake.Enabled = True

            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(ex, lblError)
                buttonMake.Enabled = True
                Return
            End Try

            ReloadViews()
        End Sub

        ' The DeletePage method is a method that allows you to delete one page
        ' at a time from a multi-page tiff and is useful when you only have one page to delete.
        ' The DeletePages method is a method that allows you to delete multiple consecutive
        ' pages at one time from a multi-page tiff. It works with a single page as well.
        Private Sub buttonRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonRemove.Click
            Try
                ClearErrorLabel()
                buttonRemove.Enabled = False
                buttonRemoveMulti.Enabled = False

                ' delete 2nd page
                Accusoft.ImagXpressSdk.ImageX.DeletePage(imagXpress1, strMPFile, 2)

                buttonInsert.Enabled = True
                buttonCompact.Enabled = True
            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(ex, lblError)
            End Try
            ReloadViews()
        End Sub

        Private Sub buttonRemoveMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonRemoveMulti.Click
            Try
                ClearErrorLabel()
                buttonRemoveMulti.Enabled = False
                buttonRemove.Enabled = False

                ' delete pages 2 and 3
                Accusoft.ImagXpressSdk.ImageX.DeletePages(imagXpress1, strMPFile, 2, 2)

                buttonInsertMulti.Enabled = True
                buttonCompact.Enabled = True
            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(ex, lblError)
            End Try
            ReloadViews()
        End Sub

        Private Sub buttonInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonInsert.Click
            Try
                ClearErrorLabel()
                buttonInsert.Enabled = False
                buttonInsertMulti.Enabled = False

                ' insert "page2.tif" into the page 2 position
                Accusoft.ImagXpressSdk.ImageX.InsertPage(imagXpress1, strImageFile2, strMPFile, 2)

                buttonCompact.Enabled = True
                buttonRemove.Enabled = True
                buttonRemoveMulti.Enabled = True

            Catch eX As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(eX, lblError)
            End Try
            ReloadViews()
        End Sub

        Private Sub buttonInsertMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonInsertMulti.Click
            Try
                ClearErrorLabel()
                buttonInsert.Enabled = False
                buttonInsertMulti.Enabled = False

                ' insert pages 2 and 3 from the "multi2.tif" copy of the original starting at the page 2 position
                Accusoft.ImagXpressSdk.ImageX.InsertPages(imagXpress1, strMP2File, 2, 2, strMPFile, 2)

                buttonCompact.Enabled = True
                buttonRemove.Enabled = True
                buttonRemoveMulti.Enabled = True

            Catch eX As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(eX, lblError)
            End Try
            ReloadViews()
        End Sub

        Private Sub buttonCompact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonCompact.Click
            Try
                ClearErrorLabel()
                buttonCompact.Enabled = False

                ' compact the file and remove orphaned pages
                Accusoft.ImagXpressSdk.ImageX.CompactFile(imagXpress1, strMPFile, strTmpFile)

            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(ex, lblError)

            End Try
            If System.IO.File.Exists(strTmpFile) Then
                System.IO.File.Delete(strMPFile)
                System.IO.File.Move(strTmpFile, strMPFile)
            End If
            ReloadViews()
        End Sub

        Private Sub ReloadViews()
            Dim pageCount As Integer

            Try
                ' Dispose any current images
                If (ImageXView1.Image IsNot Nothing) Then
                    ImageXView1.Image.Dispose()
                    ImageXView1.Image = Nothing
                End If
                If (ImageXView2.Image IsNot Nothing) Then
                    ImageXView2.Image.Dispose()
                    ImageXView3.Image = Nothing
                End If
                If (ImageXView3.Image IsNot Nothing) Then
                    ImageXView3.Image.Dispose()
                    ImageXView3.Image = Nothing
                End If

                ImageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strMPFile, 1)
                pageCount = ImageXView1.Image.PageCount

                If (pageCount > 1) Then
                    ImageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strMPFile, 2)
                End If

                If (pageCount > 2) Then
                    ImageXView3.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, strMPFile, 3)
                End If

                lblFileStats.Text = ("File Size: " _
                            + (ImageXView1.Image.ImageXData.Size.ToString(cultNumber) + (" bytes." + Microsoft.VisualBasic.ChrW(10) + ("Pages: " + pageCount.ToString()))))

            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(ex, lblError)
            End Try

        End Sub

        Private Sub ClearErrorLabel()
            ' clear out the error in case there was an error from a previous operation
            lblError.Text = ""
        End Sub

        Private Sub mnuFileQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileQuit.Click
            Application.Exit()
        End Sub

        Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
            imagXpress1.AboutBox()
        End Sub


#Region "Accusoft Sample Application Standard Functions"
        '/*********************************************************************
        '*     Accusoft Corporation Standard Function Definitions     *
        ' *********************************************************************/

        Dim cultNumber As System.Globalization.NumberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat
        Dim cultText As System.Globalization.TextInfo = System.Globalization.CultureInfo.CurrentCulture.TextInfo
        Dim cultCompare As System.Globalization.CompareInfo = System.Globalization.CultureInfo.CurrentCulture.CompareInfo
        Friend WithEvents lblFileStats As System.Windows.Forms.Label
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

#End Region

    End Class
End Namespace