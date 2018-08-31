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
Imports System.Runtime.InteropServices

Namespace Threading

    Public Class MainForm
        Inherits System.Windows.Forms.Form

        Public Class Win32
            <DllImport("User32.Dll")> _
            Public Shared Sub SetWindowText(ByVal hWnd As Integer, ByVal text As String)
            End Sub
        End Class

        Const LABEL_WIDTH As Integer = 145
        Const LABEL_HEIGHT As Integer = 15
        Const VIEWER_WIDTH As Integer = 145
        Const VIEWER_HEIGHT As Integer = 100
        Const VIEWER_SPACING As Integer = 10
        Const IMAGE1_WIDTH As Integer = 408
        Const IMAGE1_HEIGHT As Integer = 280
        Const IMAGE2_WIDTH As Integer = 320
        Const IMAGE2_HEIGHT As Integer = 240
        Friend WithEvents cmdLoadResize As System.Windows.Forms.Button
        Private chkAsync As System.Windows.Forms.CheckBox
        Private cmbThreadPriority As System.Windows.Forms.ComboBox
        Private label1 As System.Windows.Forms.Label
        Private strImage1 As System.String = "window.jpg"
        Private strImage2 As System.String = "vermont.jpg"
        Private viewerLabel As System.Windows.Forms.Label()
        Private ImagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
        Private ixViewer As Accusoft.ImagXpressSdk.ImageXView()
        Private ViewerNum As Integer
        Private lstView As System.Windows.Forms.ListBox
        Private myThreads As System.Threading.Thread() = New System.Threading.Thread(6) {}
        Private mnuFile As System.Windows.Forms.MainMenu
        Friend WithEvents mnuFileFile As System.Windows.Forms.MenuItem
        Friend WithEvents mnuFileOpen As System.Windows.Forms.MenuItem
        Private menuItem3 As System.Windows.Forms.MenuItem
        Friend WithEvents mnuFileQuit As System.Windows.Forms.MenuItem
        Private lblInfo As System.Windows.Forms.RichTextBox
        Private mnuToolbar As System.Windows.Forms.MenuItem
        Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
        Friend WithEvents mnuToolbarShow As System.Windows.Forms.MenuItem
        Private lblLastError As System.Windows.Forms.Label
        Private lblError As System.Windows.Forms.Label
        Private components As System.ComponentModel.IContainer

        Public Sub New()

            InitializeComponent()
            viewerLabel = New System.Windows.Forms.Label(6) {}


            '***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
            'ImagXpress1.Licensing.SetSolutionName("YourSolutionName")
            'ImagXpress1.Licensing.SetSolutionKey(12345, 12345, 12345, 12345)
            'ImagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�")


            Try
                ixViewer = New Accusoft.ImagXpressSdk.ImageXView(6) {}
            Catch eX As ImagXpressException
                AccusoftError(eX, lblError)
            End Try
            Dim x As Integer = 17
            Dim y As Integer = 190
            Dim i As Integer
            i = 0
            i = 0
            While i < 6
                Try
                    viewerLabel(i) = New System.Windows.Forms.Label
                    viewerLabel(i).Parent = Me
                    viewerLabel(i).Left = x
                    viewerLabel(i).Top = y
                    viewerLabel(i).Width = LABEL_WIDTH
                    viewerLabel(i).Height = LABEL_HEIGHT
                    viewerLabel(i).TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    viewerLabel(i).Text = i.ToString
                    ixViewer(i) = New Accusoft.ImagXpressSdk.ImageXView(Me.Container, ImagXpress1)
                    ixViewer(i).Parent = Me
                    ixViewer(i).Left = x
                    ixViewer(i).Top = y + LABEL_HEIGHT
                    ixViewer(i).Width = VIEWER_WIDTH
                    ixViewer(i).Height = VIEWER_HEIGHT
                    'Tell the ImageXView component to dispose of the ImageX object when itself is
                    'disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
                    'Dispose method before the components.Dispose() section.
                    ixViewer(i).AutoImageDispose = True

                Catch eX As ImagXpressException
                    AccusoftError(eX, lblError)
                End Try
                x += VIEWER_WIDTH + VIEWER_SPACING
                If x > ((VIEWER_WIDTH + VIEWER_SPACING) * 3) + VIEWER_SPACING Then
                    y += VIEWER_HEIGHT + LABEL_HEIGHT + VIEWER_SPACING
                    x = 17
                End If
                System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
            End While
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.cmdLoadResize = New System.Windows.Forms.Button()
            Me.chkAsync = New System.Windows.Forms.CheckBox()
            Me.cmbThreadPriority = New System.Windows.Forms.ComboBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.lstView = New System.Windows.Forms.ListBox()
            Me.mnuFile = New System.Windows.Forms.MainMenu(Me.components)
            Me.mnuFileFile = New System.Windows.Forms.MenuItem()
            Me.mnuFileOpen = New System.Windows.Forms.MenuItem()
            Me.menuItem3 = New System.Windows.Forms.MenuItem()
            Me.mnuFileQuit = New System.Windows.Forms.MenuItem()
            Me.mnuToolbar = New System.Windows.Forms.MenuItem()
            Me.mnuToolbarShow = New System.Windows.Forms.MenuItem()
            Me.mnuAbout = New System.Windows.Forms.MenuItem()
            Me.lblInfo = New System.Windows.Forms.RichTextBox()
            Me.ImagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
            Me.lblLastError = New System.Windows.Forms.Label()
            Me.lblError = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'cmdLoadResize
            '
            Me.cmdLoadResize.Location = New System.Drawing.Point(16, 136)
            Me.cmdLoadResize.Name = "cmdLoadResize"
            Me.cmdLoadResize.Size = New System.Drawing.Size(160, 32)
            Me.cmdLoadResize.TabIndex = 1
            Me.cmdLoadResize.Text = "Load and Resize 2 Images"
            '
            'chkAsync
            '
            Me.chkAsync.Checked = True
            Me.chkAsync.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkAsync.Location = New System.Drawing.Point(192, 136)
            Me.chkAsync.Name = "chkAsync"
            Me.chkAsync.Size = New System.Drawing.Size(168, 32)
            Me.chkAsync.TabIndex = 2
            Me.chkAsync.Text = "Async Processing Enabled"
            Me.chkAsync.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'cmbThreadPriority
            '
            Me.cmbThreadPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbThreadPriority.Items.AddRange(New Object() {"Lowest", "BelowNormal", "Normal", "AboveNormal", "Highest"})
            Me.cmbThreadPriority.Location = New System.Drawing.Point(368, 144)
            Me.cmbThreadPriority.Name = "cmbThreadPriority"
            Me.cmbThreadPriority.Size = New System.Drawing.Size(104, 21)
            Me.cmbThreadPriority.TabIndex = 4
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(368, 128)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(104, 16)
            Me.label1.TabIndex = 5
            Me.label1.Text = "Thread Priority:"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lstView
            '
            Me.lstView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lstView.Location = New System.Drawing.Point(16, 448)
            Me.lstView.Name = "lstView"
            Me.lstView.Size = New System.Drawing.Size(456, 95)
            Me.lstView.TabIndex = 10
            '
            'mnuFile
            '
            Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileFile, Me.mnuToolbar, Me.mnuAbout})
            '
            'mnuFileFile
            '
            Me.mnuFileFile.Index = 0
            Me.mnuFileFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileOpen, Me.menuItem3, Me.mnuFileQuit})
            Me.mnuFileFile.Text = "&File"
            '
            'mnuFileOpen
            '
            Me.mnuFileOpen.Index = 0
            Me.mnuFileOpen.Text = "&Open Two Images"
            '
            'menuItem3
            '
            Me.menuItem3.Index = 1
            Me.menuItem3.Text = "-"
            '
            'mnuFileQuit
            '
            Me.mnuFileQuit.Index = 2
            Me.mnuFileQuit.Text = "&Quit"
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
            'lblInfo
            '
            Me.lblInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInfo.Location = New System.Drawing.Point(16, 8)
            Me.lblInfo.Name = "lblInfo"
            Me.lblInfo.ReadOnly = True
            Me.lblInfo.Size = New System.Drawing.Size(456, 112)
            Me.lblInfo.TabIndex = 11
            Me.lblInfo.Text = resources.GetString("lblInfo.Text")
            '
            'lblLastError
            '
            Me.lblLastError.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblLastError.Location = New System.Drawing.Point(16, 544)
            Me.lblLastError.Name = "lblLastError"
            Me.lblLastError.Size = New System.Drawing.Size(64, 16)
            Me.lblLastError.TabIndex = 12
            Me.lblLastError.Text = "Last Error:"
            '
            'lblError
            '
            Me.lblError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblError.Location = New System.Drawing.Point(80, 544)
            Me.lblError.Name = "lblError"
            Me.lblError.Size = New System.Drawing.Size(384, 16)
            Me.lblError.TabIndex = 13
            '
            'MainForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(488, 571)
            Me.Controls.Add(Me.lblError)
            Me.Controls.Add(Me.lblLastError)
            Me.Controls.Add(Me.lblInfo)
            Me.Controls.Add(Me.lstView)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.cmbThreadPriority)
            Me.Controls.Add(Me.chkAsync)
            Me.Controls.Add(Me.cmdLoadResize)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Menu = Me.mnuFile
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Threading"
            Me.ResumeLayout(False)

        End Sub

        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New MainForm)
        End Sub

        Private Sub cmdLoadResize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadResize.Click
            Dim newViewNum As Integer = GetViewerNum()
            Dim newProc1 As ProcessorThread = New ProcessorThread(strImage1, ixViewer(newViewNum), viewerLabel(newViewNum), 3, ImagXpress1)
            Dim trd1 As System.Threading.Thread = New System.Threading.Thread(New System.Threading.ThreadStart(AddressOf newProc1.Process))
            trd1.IsBackground = chkAsync.Checked
            trd1.Priority = GetPriority()
            trd1.Start()
            newViewNum = GetViewerNum()
            Dim newProc2 As ProcessorThread = New ProcessorThread(strImage2, ixViewer(newViewNum), viewerLabel(newViewNum), 5, ImagXpress1)
            Dim trd2 As System.Threading.Thread = New System.Threading.Thread(New System.Threading.ThreadStart(AddressOf newProc2.Process))
            trd2.IsBackground = chkAsync.Checked
            trd2.Priority = GetPriority()
            trd2.Start()
        End Sub

        Private Sub cmdQuit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Application.Exit()
        End Sub

        Private Function GetPriority() As System.Threading.ThreadPriority
            Select Case cmbThreadPriority.SelectedIndex
                Case 0
                    Return System.Threading.ThreadPriority.Lowest
                Case 1
                    Return System.Threading.ThreadPriority.BelowNormal
                Case 2
                    Return System.Threading.ThreadPriority.Normal
                Case 3
                    Return System.Threading.ThreadPriority.AboveNormal
                Case 4
                    Return System.Threading.ThreadPriority.Highest
                Case Else
                    Return System.Threading.ThreadPriority.Normal
            End Select
        End Function

        Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            '***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
            'imagXpress1.Licensing.SetSolutionName("YourSolutionName")
            'imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345)
            'imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�")

            ' Set the current directory to the Common\Images directory
            Dim strCurrentDir As String = System.IO.Path.Combine(Application.StartupPath, "..\..\..\..\..\..\..\..\..\..\Common\Images\")
            If (System.IO.Directory.Exists(strCurrentDir)) Then
                System.IO.Directory.SetCurrentDirectory(strCurrentDir)
            End If
            strCurrentDir = System.IO.Directory.GetCurrentDirectory()

            cmbThreadPriority.SelectedIndex = 2
        End Sub

        Private Sub lstViewThreadSafeTextAdder(ByVal text As String)
            lstView.Items.Add(text)
            lstView.SelectedIndex = lstView.Items.Count - 1
        End Sub

        Private Delegate Sub controlTextModifier(ByVal text As String)

        Private Sub ImageStatusEventHandler(ByVal sender As Object, ByVal e As Accusoft.ImagXpressSdk.ImageStatusEventArgs)
            If lstView.InvokeRequired Then
                Dim theparams As Object() = {e.Status.ToString()}
                Dim theListViewModder As controlTextModifier = AddressOf lstViewThreadSafeTextAdder
                lstView.Invoke(theListViewModder, theparams)
            Else
                lstView.Items.Add(e.Status.ToString())
            End If
        End Sub

        Private Sub ProgressEventHandler(ByVal sender As Object, ByVal e As Accusoft.ImagXpressSdk.ProgressEventArgs)
            If lstView.InvokeRequired Then
                Dim theParams As Object() = {e.PercentDone.ToString(cultNumber) + "% Loading Complete."}
                lstView.Invoke(New controlTextModifier(AddressOf lstViewThreadSafeTextAdder), theParams)
                If e.IsComplete Then
                    theParams(0) = e.TotalBytes.ToString(cultNumber) + " Bytes Completed Loading."
                    lstView.Invoke(New controlTextModifier(AddressOf lstViewThreadSafeTextAdder), theParams)
                End If
            Else
                lstView.Items.Add(e.PercentDone.ToString(cultNumber) + "% Loading Complete.")
                If e.IsComplete Then
                    lstView.Items.Add(e.TotalBytes.ToString(cultNumber) + " Bytes Completed Loading.")
                End If
                lstView.SelectedIndex = lstView.Items.Count - 1
            End If
        End Sub

        Private Function GetViewerNum() As Integer
            System.Math.Min(System.Threading.Interlocked.Increment(ViewerNum), ViewerNum - 1)
            If ViewerNum > 5 Then
                ViewerNum = 0
                Return 5
            Else
                Return ViewerNum - 1
            End If
        End Function

        Private Sub mnuFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
            Dim tmp As System.String = AccusoftOpenFile()
            If Not (tmp.Length = 0) Then
                strImage1 = tmp
            End If
            tmp = AccusoftOpenFile()
            If Not (tmp.Length = 0) Then
                strImage2 = tmp
            End If
        End Sub

        Private Sub mnuFileQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileQuit.Click
            Application.Exit()
        End Sub

        Private Sub mnuToolbarShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolbarShow.Click
            Me.mnuToolbarShow.Text = Microsoft.VisualBasic.IIf((IXViewer(0).Toolbar.Activated), "&Show", "&Hide")
            Try
                Dim i As Integer = 0
                While i < 6
                    ixViewer(i).Toolbar.Activated = Not ixViewer(i).Toolbar.Activated
                    Dim hWndTB As System.IntPtr = ixViewer(i).Toolbar.Hwnd
                    Win32.SetWindowText(hWndTB.ToInt32, "Toolbar " + i.ToString)
                    System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
                End While
            Catch eX As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(eX, lblError)
            End Try
        End Sub

        Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
            Try
                ImagXpress1.AboutBox()
            Catch eX As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(eX, lblError)
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
                AccusoftError(ex, lblError)
                textTextBox.Text = scrScroll.Value.ToString(cultNumber)
                Return
            Catch ex As System.Exception
                AccusoftError(ex, lblError)
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
    End Class
End Namespace

