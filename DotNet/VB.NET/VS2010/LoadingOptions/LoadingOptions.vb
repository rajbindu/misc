'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
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
    Friend WithEvents ErrorLabel2 As System.Windows.Forms.Label
    Friend WithEvents ErrorLabel As System.Windows.Forms.Label
    Friend WithEvents CropGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RotateGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents CropCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ResizeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ResizeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Rotate As System.Windows.Forms.Label
    Friend WithEvents RotateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PreserveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FileMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ExitMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents ToolbarMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ShowMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents AboutMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ImagXpressMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents OpenMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents LeftLabel As System.Windows.Forms.Label
    Friend WithEvents BottomLabel As System.Windows.Forms.Label
    Friend WithEvents RightLabel As System.Windows.Forms.Label
    Friend WithEvents TopLabel As System.Windows.Forms.Label
    Friend WithEvents TopValueLabel As System.Windows.Forms.Label
    Friend WithEvents RightValueLabel As System.Windows.Forms.Label
    Friend WithEvents BottomValueLabel As System.Windows.Forms.Label
    Friend WithEvents LeftValueLabel As System.Windows.Forms.Label
    Friend WithEvents LeftScroll As System.Windows.Forms.HScrollBar
    Friend WithEvents TopScroll As System.Windows.Forms.HScrollBar
    Friend WithEvents RightScroll As System.Windows.Forms.HScrollBar
    Friend WithEvents BottomScroll As System.Windows.Forms.HScrollBar
    Friend WithEvents RotateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDownResizeHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownResizeWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents ReloadButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.DescriptionListBox = New System.Windows.Forms.ListBox()
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.FileMenu = New System.Windows.Forms.MenuItem()
        Me.OpenMenuItem = New System.Windows.Forms.MenuItem()
        Me.ExitMenuItem = New System.Windows.Forms.MenuItem()
        Me.ToolbarMenu = New System.Windows.Forms.MenuItem()
        Me.ShowMenuItem = New System.Windows.Forms.MenuItem()
        Me.AboutMenu = New System.Windows.Forms.MenuItem()
        Me.ImagXpressMenuItem = New System.Windows.Forms.MenuItem()
        Me.ErrorLabel2 = New System.Windows.Forms.Label()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.CropGroupBox = New System.Windows.Forms.GroupBox()
        Me.TopValueLabel = New System.Windows.Forms.Label()
        Me.RightValueLabel = New System.Windows.Forms.Label()
        Me.BottomValueLabel = New System.Windows.Forms.Label()
        Me.LeftValueLabel = New System.Windows.Forms.Label()
        Me.TopLabel = New System.Windows.Forms.Label()
        Me.RightLabel = New System.Windows.Forms.Label()
        Me.BottomLabel = New System.Windows.Forms.Label()
        Me.LeftLabel = New System.Windows.Forms.Label()
        Me.BottomScroll = New System.Windows.Forms.HScrollBar()
        Me.RightScroll = New System.Windows.Forms.HScrollBar()
        Me.TopScroll = New System.Windows.Forms.HScrollBar()
        Me.LeftScroll = New System.Windows.Forms.HScrollBar()
        Me.CropCheckBox = New System.Windows.Forms.CheckBox()
        Me.ResizeGroupBox = New System.Windows.Forms.GroupBox()
        Me.NumericUpDownResizeHeight = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownResizeWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PreserveCheckBox = New System.Windows.Forms.CheckBox()
        Me.ResizeCheckBox = New System.Windows.Forms.CheckBox()
        Me.RotateGroupBox = New System.Windows.Forms.GroupBox()
        Me.RotateComboBox = New System.Windows.Forms.ComboBox()
        Me.Rotate = New System.Windows.Forms.Label()
        Me.RotateCheckBox = New System.Windows.Forms.CheckBox()
        Me.ImagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
        Me.ImageXView1 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.ReloadButton = New System.Windows.Forms.Button()
        Me.CropGroupBox.SuspendLayout()
        Me.ResizeGroupBox.SuspendLayout()
        CType(Me.NumericUpDownResizeHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownResizeWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RotateGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DescriptionListBox
        '
        Me.DescriptionListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionListBox.Items.AddRange(New Object() {"This example demonstrates the following:", "1) Using the LoadOptions object.", "", "Select any of the 3 loading options by clicking the box next to the appropriate o" & _
                        "ption,", "then click the Reload Image button."})
        Me.DescriptionListBox.Location = New System.Drawing.Point(8, 8)
        Me.DescriptionListBox.Name = "DescriptionListBox"
        Me.DescriptionListBox.Size = New System.Drawing.Size(786, 69)
        Me.DescriptionListBox.TabIndex = 0
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
        'ErrorLabel2
        '
        Me.ErrorLabel2.Location = New System.Drawing.Point(445, 88)
        Me.ErrorLabel2.Name = "ErrorLabel2"
        Me.ErrorLabel2.Size = New System.Drawing.Size(64, 16)
        Me.ErrorLabel2.TabIndex = 3
        Me.ErrorLabel2.Text = "Last Error:"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorLabel.Location = New System.Drawing.Point(448, 104)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(346, 176)
        Me.ErrorLabel.TabIndex = 4
        '
        'CropGroupBox
        '
        Me.CropGroupBox.Controls.Add(Me.TopValueLabel)
        Me.CropGroupBox.Controls.Add(Me.RightValueLabel)
        Me.CropGroupBox.Controls.Add(Me.BottomValueLabel)
        Me.CropGroupBox.Controls.Add(Me.LeftValueLabel)
        Me.CropGroupBox.Controls.Add(Me.TopLabel)
        Me.CropGroupBox.Controls.Add(Me.RightLabel)
        Me.CropGroupBox.Controls.Add(Me.BottomLabel)
        Me.CropGroupBox.Controls.Add(Me.LeftLabel)
        Me.CropGroupBox.Controls.Add(Me.BottomScroll)
        Me.CropGroupBox.Controls.Add(Me.RightScroll)
        Me.CropGroupBox.Controls.Add(Me.TopScroll)
        Me.CropGroupBox.Controls.Add(Me.LeftScroll)
        Me.CropGroupBox.Controls.Add(Me.CropCheckBox)
        Me.CropGroupBox.Location = New System.Drawing.Point(8, 414)
        Me.CropGroupBox.Name = "CropGroupBox"
        Me.CropGroupBox.Size = New System.Drawing.Size(296, 176)
        Me.CropGroupBox.TabIndex = 5
        Me.CropGroupBox.TabStop = False
        Me.CropGroupBox.Text = "Load Crop"
        '
        'TopValueLabel
        '
        Me.TopValueLabel.Location = New System.Drawing.Point(240, 88)
        Me.TopValueLabel.Name = "TopValueLabel"
        Me.TopValueLabel.Size = New System.Drawing.Size(48, 16)
        Me.TopValueLabel.TabIndex = 12
        Me.TopValueLabel.Text = "0"
        '
        'RightValueLabel
        '
        Me.RightValueLabel.Location = New System.Drawing.Point(240, 112)
        Me.RightValueLabel.Name = "RightValueLabel"
        Me.RightValueLabel.Size = New System.Drawing.Size(48, 16)
        Me.RightValueLabel.TabIndex = 11
        Me.RightValueLabel.Text = "0"
        '
        'BottomValueLabel
        '
        Me.BottomValueLabel.Location = New System.Drawing.Point(240, 136)
        Me.BottomValueLabel.Name = "BottomValueLabel"
        Me.BottomValueLabel.Size = New System.Drawing.Size(48, 16)
        Me.BottomValueLabel.TabIndex = 10
        Me.BottomValueLabel.Text = "0"
        '
        'LeftValueLabel
        '
        Me.LeftValueLabel.Location = New System.Drawing.Point(240, 64)
        Me.LeftValueLabel.Name = "LeftValueLabel"
        Me.LeftValueLabel.Size = New System.Drawing.Size(48, 16)
        Me.LeftValueLabel.TabIndex = 9
        Me.LeftValueLabel.Text = "0"
        '
        'TopLabel
        '
        Me.TopLabel.Location = New System.Drawing.Point(11, 88)
        Me.TopLabel.Name = "TopLabel"
        Me.TopLabel.Size = New System.Drawing.Size(37, 16)
        Me.TopLabel.TabIndex = 8
        Me.TopLabel.Text = "Top"
        Me.TopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RightLabel
        '
        Me.RightLabel.Location = New System.Drawing.Point(8, 112)
        Me.RightLabel.Name = "RightLabel"
        Me.RightLabel.Size = New System.Drawing.Size(40, 16)
        Me.RightLabel.TabIndex = 7
        Me.RightLabel.Text = "Right"
        Me.RightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BottomLabel
        '
        Me.BottomLabel.Location = New System.Drawing.Point(8, 136)
        Me.BottomLabel.Name = "BottomLabel"
        Me.BottomLabel.Size = New System.Drawing.Size(40, 16)
        Me.BottomLabel.TabIndex = 6
        Me.BottomLabel.Text = "Bottom"
        Me.BottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LeftLabel
        '
        Me.LeftLabel.Location = New System.Drawing.Point(6, 64)
        Me.LeftLabel.Name = "LeftLabel"
        Me.LeftLabel.Size = New System.Drawing.Size(42, 16)
        Me.LeftLabel.TabIndex = 5
        Me.LeftLabel.Text = "Left"
        Me.LeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BottomScroll
        '
        Me.BottomScroll.LargeChange = 1
        Me.BottomScroll.Location = New System.Drawing.Point(56, 136)
        Me.BottomScroll.Maximum = 1200
        Me.BottomScroll.Minimum = 1
        Me.BottomScroll.Name = "BottomScroll"
        Me.BottomScroll.Size = New System.Drawing.Size(176, 16)
        Me.BottomScroll.TabIndex = 4
        Me.BottomScroll.Value = 1
        '
        'RightScroll
        '
        Me.RightScroll.LargeChange = 1
        Me.RightScroll.Location = New System.Drawing.Point(56, 112)
        Me.RightScroll.Maximum = 1600
        Me.RightScroll.Minimum = 1
        Me.RightScroll.Name = "RightScroll"
        Me.RightScroll.Size = New System.Drawing.Size(176, 16)
        Me.RightScroll.TabIndex = 3
        Me.RightScroll.Value = 1
        '
        'TopScroll
        '
        Me.TopScroll.LargeChange = 1
        Me.TopScroll.Location = New System.Drawing.Point(56, 88)
        Me.TopScroll.Maximum = 1200
        Me.TopScroll.Minimum = 1
        Me.TopScroll.Name = "TopScroll"
        Me.TopScroll.Size = New System.Drawing.Size(176, 16)
        Me.TopScroll.TabIndex = 2
        Me.TopScroll.Value = 1
        '
        'LeftScroll
        '
        Me.LeftScroll.LargeChange = 1
        Me.LeftScroll.Location = New System.Drawing.Point(56, 64)
        Me.LeftScroll.Maximum = 1600
        Me.LeftScroll.Minimum = 1
        Me.LeftScroll.Name = "LeftScroll"
        Me.LeftScroll.Size = New System.Drawing.Size(176, 16)
        Me.LeftScroll.TabIndex = 1
        Me.LeftScroll.Value = 1
        '
        'CropCheckBox
        '
        Me.CropCheckBox.Location = New System.Drawing.Point(27, 26)
        Me.CropCheckBox.Name = "CropCheckBox"
        Me.CropCheckBox.Size = New System.Drawing.Size(144, 29)
        Me.CropCheckBox.TabIndex = 0
        Me.CropCheckBox.Text = "Crop Image on Load"
        '
        'ResizeGroupBox
        '
        Me.ResizeGroupBox.Controls.Add(Me.NumericUpDownResizeHeight)
        Me.ResizeGroupBox.Controls.Add(Me.NumericUpDownResizeWidth)
        Me.ResizeGroupBox.Controls.Add(Me.Label13)
        Me.ResizeGroupBox.Controls.Add(Me.Label16)
        Me.ResizeGroupBox.Controls.Add(Me.PreserveCheckBox)
        Me.ResizeGroupBox.Controls.Add(Me.ResizeCheckBox)
        Me.ResizeGroupBox.Location = New System.Drawing.Point(320, 414)
        Me.ResizeGroupBox.Name = "ResizeGroupBox"
        Me.ResizeGroupBox.Size = New System.Drawing.Size(224, 176)
        Me.ResizeGroupBox.TabIndex = 6
        Me.ResizeGroupBox.TabStop = False
        Me.ResizeGroupBox.Text = "Load Resize"
        '
        'NumericUpDownResizeHeight
        '
        Me.NumericUpDownResizeHeight.Location = New System.Drawing.Point(79, 96)
        Me.NumericUpDownResizeHeight.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDownResizeHeight.Name = "NumericUpDownResizeHeight"
        Me.NumericUpDownResizeHeight.Size = New System.Drawing.Size(83, 20)
        Me.NumericUpDownResizeHeight.TabIndex = 14
        Me.NumericUpDownResizeHeight.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'NumericUpDownResizeWidth
        '
        Me.NumericUpDownResizeWidth.Location = New System.Drawing.Point(79, 62)
        Me.NumericUpDownResizeWidth.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDownResizeWidth.Name = "NumericUpDownResizeWidth"
        Me.NumericUpDownResizeWidth.Size = New System.Drawing.Size(83, 20)
        Me.NumericUpDownResizeWidth.TabIndex = 13
        Me.NumericUpDownResizeWidth.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Height"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(16, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 16)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Width"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PreserveCheckBox
        '
        Me.PreserveCheckBox.Checked = True
        Me.PreserveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PreserveCheckBox.Location = New System.Drawing.Point(23, 137)
        Me.PreserveCheckBox.Name = "PreserveCheckBox"
        Me.PreserveCheckBox.Size = New System.Drawing.Size(184, 16)
        Me.PreserveCheckBox.TabIndex = 3
        Me.PreserveCheckBox.Text = "Preserve Aspect Ratio"
        '
        'ResizeCheckBox
        '
        Me.ResizeCheckBox.Location = New System.Drawing.Point(23, 22)
        Me.ResizeCheckBox.Name = "ResizeCheckBox"
        Me.ResizeCheckBox.Size = New System.Drawing.Size(176, 29)
        Me.ResizeCheckBox.TabIndex = 0
        Me.ResizeCheckBox.Text = "Resize Image on Load"
        '
        'RotateGroupBox
        '
        Me.RotateGroupBox.Controls.Add(Me.RotateComboBox)
        Me.RotateGroupBox.Controls.Add(Me.Rotate)
        Me.RotateGroupBox.Controls.Add(Me.RotateCheckBox)
        Me.RotateGroupBox.Location = New System.Drawing.Point(562, 414)
        Me.RotateGroupBox.Name = "RotateGroupBox"
        Me.RotateGroupBox.Size = New System.Drawing.Size(232, 176)
        Me.RotateGroupBox.TabIndex = 7
        Me.RotateGroupBox.TabStop = False
        Me.RotateGroupBox.Text = "Load Rotate"
        '
        'RotateComboBox
        '
        Me.RotateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RotateComboBox.Items.AddRange(New Object() {"None", "90 Degrees", "180 Degrees", "270 Degrees", "Flip", "Mirror"})
        Me.RotateComboBox.Location = New System.Drawing.Point(80, 104)
        Me.RotateComboBox.Name = "RotateComboBox"
        Me.RotateComboBox.Size = New System.Drawing.Size(112, 21)
        Me.RotateComboBox.TabIndex = 2
        '
        'Rotate
        '
        Me.Rotate.Location = New System.Drawing.Point(16, 80)
        Me.Rotate.Name = "Rotate"
        Me.Rotate.Size = New System.Drawing.Size(88, 16)
        Me.Rotate.TabIndex = 1
        Me.Rotate.Text = "RotateSettings:"
        '
        'RotateCheckBox
        '
        Me.RotateCheckBox.Location = New System.Drawing.Point(19, 25)
        Me.RotateCheckBox.Name = "RotateCheckBox"
        Me.RotateCheckBox.Size = New System.Drawing.Size(152, 23)
        Me.RotateCheckBox.TabIndex = 0
        Me.RotateCheckBox.Text = "Rotate Image on Load"
        '
        'ImageXView1
        '
        Me.ImageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
        Me.ImageXView1.AutoScroll = True
        Me.ImageXView1.Location = New System.Drawing.Point(8, 88)
        Me.ImageXView1.Name = "ImageXView1"
        Me.ImageXView1.Size = New System.Drawing.Size(424, 320)
        Me.ImageXView1.TabIndex = 8
        '
        'ReloadButton
        '
        Me.ReloadButton.Location = New System.Drawing.Point(546, 329)
        Me.ReloadButton.Name = "ReloadButton"
        Me.ReloadButton.Size = New System.Drawing.Size(152, 40)
        Me.ReloadButton.TabIndex = 9
        Me.ReloadButton.Text = "Reload Image"
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(807, 596)
        Me.Controls.Add(Me.ReloadButton)
        Me.Controls.Add(Me.ImageXView1)
        Me.Controls.Add(Me.RotateGroupBox)
        Me.Controls.Add(Me.ResizeGroupBox)
        Me.Controls.Add(Me.CropGroupBox)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.ErrorLabel2)
        Me.Controls.Add(Me.DescriptionListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading Options"
        Me.CropGroupBox.ResumeLayout(False)
        Me.ResizeGroupBox.ResumeLayout(False)
        CType(Me.NumericUpDownResizeHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownResizeWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RotateGroupBox.ResumeLayout(False)
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

    Dim loadOptions As Accusoft.ImagXpressSdk.LoadOptions
    Dim filename As String
    Dim heightStart As Integer
    Dim widthStart As Integer

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

        loadOptions = New Accusoft.ImagXpressSdk.LoadOptions()

        Try
            'Set an initial image
            filename = "window.jpg"
            If (System.IO.File.Exists(filename)) Then
                ImageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(ImagXpress1, filename, loadOptions)

                widthStart = ImageXView1.Image.ImageXData.Width
                heightStart = ImageXView1.Image.ImageXData.Height

                RightScroll.Maximum = widthStart
                BottomScroll.Maximum = heightStart
                LeftScroll.Maximum = widthStart
                TopScroll.Maximum = heightStart

                NumericUpDownResizeWidth.Value = 100
                NumericUpDownResizeHeight.Value = 100
                PreserveCheckBox.Checked = True

                LeftScroll.Value = 30
                LeftValueLabel.Text = 30
                TopScroll.Value = 30
                TopValueLabel.Text = 30
                BottomScroll.Value = 100
                BottomValueLabel.Text = 100
                RightScroll.Value = 100
                RightValueLabel.Text = 100

                ' Reset the options controls.
                CropCheckBox_CheckedChanged(sender, e)
                ResizeCheckBox_CheckedChanged(sender, e)
                RotateCheckBox_CheckedChanged(sender, e)
                RotateComboBox.SelectedIndex = 1
            End If
        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            ErrorLabel.Text = ex.Message
        End Try
    End Sub

    Private Sub ResizeCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResizeCheckBox.CheckedChanged
        ' If the check box was checked, enable the options controls,
        ' otherwise, disable them
        Dim cControl As System.Windows.Forms.Control
        For Each cControl In ResizeGroupBox.Controls
            If Not (cControl.Name = "ResizeCheckBox") Then
                cControl.Enabled = ResizeCheckBox.Checked
            End If
        Next
    End Sub

    Private Sub CropCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CropCheckBox.CheckedChanged
        ' If the check box was checked, enable the options controls,
        ' otherwise, disable them
        Dim cControl As System.Windows.Forms.Control
        For Each cControl In CropGroupBox.Controls
            If Not (cControl.Name = "CropCheckBox") Then
                cControl.Enabled = CropCheckBox.Checked
            End If
        Next
    End Sub

    Private Sub RotateCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotateCheckBox.CheckedChanged
        ' If the check box was checked, enable the options controls,
        ' otherwise, disable them
        Dim cControl As System.Windows.Forms.Control
        For Each cControl In RotateGroupBox.Controls
            If Not (cControl.Name = "RotateCheckBox") Then
                cControl.Enabled = RotateCheckBox.Checked
            End If
        Next
    End Sub

    Private Sub ImagXpressMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImagXpressMenuItem.Click
        ImagXpress1.AboutBox()
    End Sub

    Private Sub ExitMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ShowMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMenuItem.Click
        ' If the toolbar is showing, hide it.  If it is hidden, show it.
        If (ShowMenuItem.Checked = False) Then
            ImageXView1.Toolbar.Activated = True
            ShowMenuItem.Checked = True
        Else
            ImageXView1.Toolbar.Activated = False
            ShowMenuItem.Checked = False
        End If
    End Sub

    Private Sub OpenMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenMenuItem.Click
        Dim imageData As Accusoft.ImagXpressSdk.ImageXData
        ' Get the filename of the image we want to open
        Dim strtemp As System.String = AccusoftOpenFile()

        ' Check to make sure the file is valid
        If Not (strtemp = "") Then
            ' If it is valid, set the internal image filename equal to it
            filename = strtemp
            Try
                ' Query the image using the internal filename
                imageData = Accusoft.ImagXpressSdk.ImageX.QueryFile(ImagXpress1, filename)
                widthStart = imageData.Width
                heightStart = imageData.Height
                RightScroll.Maximum = widthStart
                BottomScroll.Maximum = heightStart
                LeftScroll.Maximum = widthStart
                TopScroll.Maximum = heightStart
                ' Load the image into an ImageX object
                ReloadButton_Click(sender, e)
                ErrorLabel.Text = ""
            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(ex, ErrorLabel)
            End Try
        End If
    End Sub

    Private Sub ReloadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadButton.Click
        Try
            ' If the crop check box is checked, set the crop rectangle load option
            ' to the specified crop rectangle
            If CropCheckBox.Checked = True Then
                Dim rect As System.Drawing.Rectangle = New Rectangle(LeftScroll.Value, TopScroll.Value, RightScroll.Value - LeftScroll.Value, BottomScroll.Value - TopScroll.Value)
                loadOptions.CropRectangle = rect
            Else
                loadOptions.CropRectangle = New Rectangle(0, 0, widthStart, heightStart)
            End If

            ' If the resize check box is checked, set the resize load option
            ' to the specified resize width and height
            If ResizeCheckBox.Checked = True Then
                loadOptions.Resize = New System.Drawing.Size(NumericUpDownResizeWidth.Value, NumericUpDownResizeHeight.Value)
                loadOptions.MaintainAspectRatio = PreserveCheckBox.Checked
            Else
                loadOptions.MaintainAspectRatio = False
                loadOptions.Resize = New System.Drawing.Size(0, 0)
            End If

            ' If the rotate check box is checked, set the rotate load option
            ' to the specified angle
            If RotateCheckBox.Checked = True Then
                loadOptions.Rotation = CType(RotateComboBox.SelectedIndex, Accusoft.ImagXpressSdk.RotateAngle)
            Else
                loadOptions.Rotation = Accusoft.ImagXpressSdk.RotateAngle.Rotate0
            End If

            'Dispose the ImageX object if the ImageXView has one
            If (ImageXView1.Image IsNot Nothing) Then
                ImageXView1.Image.Dispose()
                ImageXView1.Image = Nothing
            End If
            ImageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(ImagXpress1, filename, loadOptions)
        Catch ex As Accusoft.ImagXpressSdk.ImageXException
            ErrorLabel.Text = ex.Message
        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            ErrorLabel.Text = ex.Message
        End Try

    End Sub

    Private Sub LeftScroll_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LeftScroll.ValueChanged
        If (LeftScroll.Value >= RightScroll.Value - 1 And RightScroll.Value > 1) Then
            LeftScroll.Value = RightScroll.Value - 1
        End If
        LeftValueLabel.Text = LeftScroll.Value.ToString()
    End Sub

    Private Sub TopScroll_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TopScroll.ValueChanged
        If (TopScroll.Value >= BottomScroll.Value - 1 And BottomScroll.Value > 1) Then
            TopScroll.Value = BottomScroll.Value - 1
        End If
        TopValueLabel.Text = TopScroll.Value.ToString()
    End Sub

    Private Sub RightScroll_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightScroll.ValueChanged
        If (RightScroll.Value <= LeftScroll.Value + 1) Then
            RightScroll.Value = LeftScroll.Value + 1
        End If
        RightValueLabel.Text = RightScroll.Value.ToString()
    End Sub

    Private Sub BottomScroll_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BottomScroll.ValueChanged
        If (BottomScroll.Value <= TopScroll.Value + 1) Then
            BottomScroll.Value = TopScroll.Value + 1
        End If
        BottomValueLabel.Text = BottomScroll.Value.ToString()
    End Sub
End Class
