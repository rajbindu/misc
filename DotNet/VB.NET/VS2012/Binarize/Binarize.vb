'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Imports Accusoft.ImagXpressSdk

Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private _mode As BinarizeMode = BinarizeMode.QuickText
    Private _lowThreshold As System.Int32 = 0
    Private _gridAngle As System.Int32 = 0
    Private _highThreshold As System.Int32 = 1
    Private _gridPitch As System.Int32 = 1
    Private _eccentricity As System.Int32 = 0
    Private _lceFactor As System.Int32 = 0
    Friend WithEvents ButtonAutoBinarize2 As System.Windows.Forms.Button
    Friend WithEvents ButtonReload As System.Windows.Forms.Button
    Private _blur As BinarizeBlur = BinarizeBlur.NoBlur


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
            If Not imageXView1.Image Is Nothing Then
                imageXView1.Image.Dispose()
                imageXView1.Image = Nothing
            End If
            If Not imageXView2.Image Is Nothing Then
                imageXView2.Image.Dispose()
                imageXView2.Image = Nothing
            End If
            If Not imageXView1 Is Nothing Then
                imageXView1.Dispose()
                imageXView1 = Nothing
            End If
            If Not imageXView2 Is Nothing Then
                imageXView2.Dispose()
                imageXView2 = Nothing
            End If
            If Not imagXpress1 Is Nothing Then
                imagXpress1.Dispose()
                imagXpress1 = Nothing
            End If
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
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ProcessButton As System.Windows.Forms.Button
    Friend WithEvents LowTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HighTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GridTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LowLabel As System.Windows.Forms.Label
    Friend WithEvents HighLabel As System.Windows.Forms.Label
    Friend WithEvents GridLabel As System.Windows.Forms.Label
    Friend WithEvents BlurLabel As System.Windows.Forms.Label
    Friend WithEvents BlurComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ModeLabel As System.Windows.Forms.Label
    Friend WithEvents ModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ContrastLabel As System.Windows.Forms.Label
    Friend WithEvents EccLabel As System.Windows.Forms.Label
    Friend WithEvents PitchLabel As System.Windows.Forms.Label
    Friend WithEvents FileMenu As System.Windows.Forms.MenuItem
    Friend WithEvents OpenMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents ExitMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents ToolbarMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ShowMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents AboutMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ImagXpressMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents LowScroll As System.Windows.Forms.HScrollBar
    Friend WithEvents HighScroll As System.Windows.Forms.HScrollBar
    Friend WithEvents AngleScroll As System.Windows.Forms.HScrollBar
    Friend WithEvents EccScroll As System.Windows.Forms.HScrollBar
    Friend WithEvents ContrastScroll As System.Windows.Forms.HScrollBar
    Friend WithEvents ContrastTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EccTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PitchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents imagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
    Friend WithEvents imageXView1 As Accusoft.ImagXpressSdk.ImageXView
    Friend WithEvents imageXView2 As Accusoft.ImagXpressSdk.ImageXView
    Friend WithEvents ErrorLabel As System.Windows.Forms.Label
    Friend WithEvents ButtonAutoBinarize As System.Windows.Forms.Button
    Friend WithEvents processor1 As Accusoft.ImagXpressSdk.Processor
    Friend WithEvents PitchScroll As System.Windows.Forms.HScrollBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ProcessButton = New System.Windows.Forms.Button()
        Me.LowScroll = New System.Windows.Forms.HScrollBar()
        Me.HighScroll = New System.Windows.Forms.HScrollBar()
        Me.AngleScroll = New System.Windows.Forms.HScrollBar()
        Me.PitchScroll = New System.Windows.Forms.HScrollBar()
        Me.EccScroll = New System.Windows.Forms.HScrollBar()
        Me.ContrastScroll = New System.Windows.Forms.HScrollBar()
        Me.LowTextBox = New System.Windows.Forms.TextBox()
        Me.HighTextBox = New System.Windows.Forms.TextBox()
        Me.GridTextBox = New System.Windows.Forms.TextBox()
        Me.ContrastTextBox = New System.Windows.Forms.TextBox()
        Me.EccTextBox = New System.Windows.Forms.TextBox()
        Me.PitchTextBox = New System.Windows.Forms.TextBox()
        Me.LowLabel = New System.Windows.Forms.Label()
        Me.HighLabel = New System.Windows.Forms.Label()
        Me.GridLabel = New System.Windows.Forms.Label()
        Me.BlurLabel = New System.Windows.Forms.Label()
        Me.BlurComboBox = New System.Windows.Forms.ComboBox()
        Me.ModeLabel = New System.Windows.Forms.Label()
        Me.ModeComboBox = New System.Windows.Forms.ComboBox()
        Me.ContrastLabel = New System.Windows.Forms.Label()
        Me.EccLabel = New System.Windows.Forms.Label()
        Me.PitchLabel = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.FileMenu = New System.Windows.Forms.MenuItem()
        Me.OpenMenuItem = New System.Windows.Forms.MenuItem()
        Me.ExitMenuItem = New System.Windows.Forms.MenuItem()
        Me.ToolbarMenu = New System.Windows.Forms.MenuItem()
        Me.ShowMenuItem = New System.Windows.Forms.MenuItem()
        Me.AboutMenu = New System.Windows.Forms.MenuItem()
        Me.ImagXpressMenuItem = New System.Windows.Forms.MenuItem()
        Me.imagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
        Me.imageXView1 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.imageXView2 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.ButtonAutoBinarize = New System.Windows.Forms.Button()
        Me.processor1 = New Accusoft.ImagXpressSdk.Processor(Me.components)
        Me.ButtonAutoBinarize2 = New System.Windows.Forms.Button()
        Me.ButtonReload = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.Items.AddRange(New Object() {"This sample demonstrates the following functionality of the Processor class:", "1) Using the Binarize method to transform an image into black and white using the" & _
                        " settings supplied.", "2) Using the AutoBinarize method to automatically process an image and then retri" & _
                        "eve the settings used.", "3) Using the newer and faster AutoBinarize2 method to automatically process an im" & _
                        "age."})
        Me.ListBox1.Location = New System.Drawing.Point(8, 8)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(934, 69)
        Me.ListBox1.TabIndex = 2
        '
        'ProcessButton
        '
        Me.ProcessButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ProcessButton.Location = New System.Drawing.Point(489, 501)
        Me.ProcessButton.Name = "ProcessButton"
        Me.ProcessButton.Size = New System.Drawing.Size(151, 42)
        Me.ProcessButton.TabIndex = 6
        Me.ProcessButton.Text = "Binarize"
        '
        'LowScroll
        '
        Me.LowScroll.LargeChange = 1
        Me.LowScroll.Location = New System.Drawing.Point(190, 372)
        Me.LowScroll.Maximum = 255
        Me.LowScroll.Name = "LowScroll"
        Me.LowScroll.Size = New System.Drawing.Size(240, 16)
        Me.LowScroll.TabIndex = 7
        Me.LowScroll.Value = 86
        '
        'HighScroll
        '
        Me.HighScroll.LargeChange = 1
        Me.HighScroll.Location = New System.Drawing.Point(190, 396)
        Me.HighScroll.Maximum = 255
        Me.HighScroll.Name = "HighScroll"
        Me.HighScroll.Size = New System.Drawing.Size(240, 16)
        Me.HighScroll.TabIndex = 8
        Me.HighScroll.Value = 126
        '
        'AngleScroll
        '
        Me.AngleScroll.LargeChange = 1
        Me.AngleScroll.Location = New System.Drawing.Point(582, 372)
        Me.AngleScroll.Maximum = 360
        Me.AngleScroll.Name = "AngleScroll"
        Me.AngleScroll.Size = New System.Drawing.Size(240, 16)
        Me.AngleScroll.TabIndex = 9
        '
        'PitchScroll
        '
        Me.PitchScroll.LargeChange = 1
        Me.PitchScroll.Location = New System.Drawing.Point(582, 396)
        Me.PitchScroll.Maximum = 32
        Me.PitchScroll.Minimum = 1
        Me.PitchScroll.Name = "PitchScroll"
        Me.PitchScroll.Size = New System.Drawing.Size(240, 16)
        Me.PitchScroll.TabIndex = 10
        Me.PitchScroll.Value = 1
        '
        'EccScroll
        '
        Me.EccScroll.LargeChange = 1
        Me.EccScroll.Location = New System.Drawing.Point(582, 420)
        Me.EccScroll.Maximum = 255
        Me.EccScroll.Minimum = -255
        Me.EccScroll.Name = "EccScroll"
        Me.EccScroll.Size = New System.Drawing.Size(240, 16)
        Me.EccScroll.TabIndex = 11
        Me.EccScroll.Value = 255
        '
        'ContrastScroll
        '
        Me.ContrastScroll.LargeChange = 1
        Me.ContrastScroll.Location = New System.Drawing.Point(190, 420)
        Me.ContrastScroll.Maximum = 255
        Me.ContrastScroll.Name = "ContrastScroll"
        Me.ContrastScroll.Size = New System.Drawing.Size(240, 16)
        Me.ContrastScroll.TabIndex = 12
        Me.ContrastScroll.Value = 163
        '
        'LowTextBox
        '
        Me.LowTextBox.Location = New System.Drawing.Point(438, 370)
        Me.LowTextBox.Name = "LowTextBox"
        Me.LowTextBox.ReadOnly = True
        Me.LowTextBox.Size = New System.Drawing.Size(24, 20)
        Me.LowTextBox.TabIndex = 13
        Me.LowTextBox.Text = "0"
        '
        'HighTextBox
        '
        Me.HighTextBox.Location = New System.Drawing.Point(438, 392)
        Me.HighTextBox.Name = "HighTextBox"
        Me.HighTextBox.ReadOnly = True
        Me.HighTextBox.Size = New System.Drawing.Size(24, 20)
        Me.HighTextBox.TabIndex = 14
        Me.HighTextBox.Text = "0"
        '
        'GridTextBox
        '
        Me.GridTextBox.Location = New System.Drawing.Point(838, 370)
        Me.GridTextBox.Name = "GridTextBox"
        Me.GridTextBox.ReadOnly = True
        Me.GridTextBox.Size = New System.Drawing.Size(24, 20)
        Me.GridTextBox.TabIndex = 15
        Me.GridTextBox.Text = "0"
        '
        'ContrastTextBox
        '
        Me.ContrastTextBox.Location = New System.Drawing.Point(438, 420)
        Me.ContrastTextBox.Name = "ContrastTextBox"
        Me.ContrastTextBox.ReadOnly = True
        Me.ContrastTextBox.Size = New System.Drawing.Size(24, 20)
        Me.ContrastTextBox.TabIndex = 18
        Me.ContrastTextBox.Text = "0"
        '
        'EccTextBox
        '
        Me.EccTextBox.Location = New System.Drawing.Point(838, 420)
        Me.EccTextBox.Name = "EccTextBox"
        Me.EccTextBox.ReadOnly = True
        Me.EccTextBox.Size = New System.Drawing.Size(24, 20)
        Me.EccTextBox.TabIndex = 17
        Me.EccTextBox.Text = "0"
        '
        'PitchTextBox
        '
        Me.PitchTextBox.Location = New System.Drawing.Point(838, 396)
        Me.PitchTextBox.Name = "PitchTextBox"
        Me.PitchTextBox.ReadOnly = True
        Me.PitchTextBox.Size = New System.Drawing.Size(24, 20)
        Me.PitchTextBox.TabIndex = 16
        Me.PitchTextBox.Text = "1"
        '
        'LowLabel
        '
        Me.LowLabel.Location = New System.Drawing.Point(94, 372)
        Me.LowLabel.Name = "LowLabel"
        Me.LowLabel.Size = New System.Drawing.Size(88, 16)
        Me.LowLabel.TabIndex = 19
        Me.LowLabel.Text = "Low Threshold:"
        Me.LowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HighLabel
        '
        Me.HighLabel.Location = New System.Drawing.Point(94, 396)
        Me.HighLabel.Name = "HighLabel"
        Me.HighLabel.Size = New System.Drawing.Size(88, 16)
        Me.HighLabel.TabIndex = 20
        Me.HighLabel.Text = "High Threshold:"
        Me.HighLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GridLabel
        '
        Me.GridLabel.Location = New System.Drawing.Point(510, 372)
        Me.GridLabel.Name = "GridLabel"
        Me.GridLabel.Size = New System.Drawing.Size(64, 16)
        Me.GridLabel.TabIndex = 21
        Me.GridLabel.Text = "Grid Angle:"
        Me.GridLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BlurLabel
        '
        Me.BlurLabel.Location = New System.Drawing.Point(106, 451)
        Me.BlurLabel.Name = "BlurLabel"
        Me.BlurLabel.Size = New System.Drawing.Size(80, 16)
        Me.BlurLabel.TabIndex = 22
        Me.BlurLabel.Text = "Blur Type:"
        Me.BlurLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BlurComboBox
        '
        Me.BlurComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BlurComboBox.Items.AddRange(New Object() {"None", "Gaussian", "Smart"})
        Me.BlurComboBox.Location = New System.Drawing.Point(202, 451)
        Me.BlurComboBox.Name = "BlurComboBox"
        Me.BlurComboBox.Size = New System.Drawing.Size(249, 21)
        Me.BlurComboBox.TabIndex = 23
        '
        'ModeLabel
        '
        Me.ModeLabel.Location = New System.Drawing.Point(512, 452)
        Me.ModeLabel.Name = "ModeLabel"
        Me.ModeLabel.Size = New System.Drawing.Size(64, 16)
        Me.ModeLabel.TabIndex = 24
        Me.ModeLabel.Text = "Mode:"
        Me.ModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ModeComboBox
        '
        Me.ModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ModeComboBox.Items.AddRange(New Object() {"QuickText", "HalfTone"})
        Me.ModeComboBox.Location = New System.Drawing.Point(582, 451)
        Me.ModeComboBox.Name = "ModeComboBox"
        Me.ModeComboBox.Size = New System.Drawing.Size(270, 21)
        Me.ModeComboBox.TabIndex = 25
        '
        'ContrastLabel
        '
        Me.ContrastLabel.Location = New System.Drawing.Point(102, 420)
        Me.ContrastLabel.Name = "ContrastLabel"
        Me.ContrastLabel.Size = New System.Drawing.Size(80, 16)
        Me.ContrastLabel.TabIndex = 29
        Me.ContrastLabel.Text = "Local Contrast:"
        Me.ContrastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EccLabel
        '
        Me.EccLabel.Location = New System.Drawing.Point(486, 420)
        Me.EccLabel.Name = "EccLabel"
        Me.EccLabel.Size = New System.Drawing.Size(88, 16)
        Me.EccLabel.TabIndex = 28
        Me.EccLabel.Text = "Eccentricity:"
        Me.EccLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PitchLabel
        '
        Me.PitchLabel.Location = New System.Drawing.Point(486, 396)
        Me.PitchLabel.Name = "PitchLabel"
        Me.PitchLabel.Size = New System.Drawing.Size(88, 16)
        Me.PitchLabel.TabIndex = 27
        Me.PitchLabel.Text = "Grid Pitch:"
        Me.PitchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'imageXView1
        '
        Me.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
        Me.imageXView1.Location = New System.Drawing.Point(8, 86)
        Me.imageXView1.Name = "imageXView1"
        Me.imageXView1.Size = New System.Drawing.Size(454, 261)
        Me.imageXView1.TabIndex = 31
        '
        'imageXView2
        '
        Me.imageXView2.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
        Me.imageXView2.Location = New System.Drawing.Point(488, 86)
        Me.imageXView2.Name = "imageXView2"
        Me.imageXView2.Size = New System.Drawing.Size(454, 261)
        Me.imageXView2.TabIndex = 32
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.Location = New System.Drawing.Point(8, 640)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(0, 13)
        Me.ErrorLabel.TabIndex = 5
        '
        'ButtonAutoBinarize
        '
        Me.ButtonAutoBinarize.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonAutoBinarize.Location = New System.Drawing.Point(489, 559)
        Me.ButtonAutoBinarize.Name = "ButtonAutoBinarize"
        Me.ButtonAutoBinarize.Size = New System.Drawing.Size(151, 42)
        Me.ButtonAutoBinarize.TabIndex = 33
        Me.ButtonAutoBinarize.Text = "AutoBinarize"
        Me.ButtonAutoBinarize.UseVisualStyleBackColor = True
        '
        'ButtonAutoBinarize2
        '
        Me.ButtonAutoBinarize2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonAutoBinarize2.Location = New System.Drawing.Point(489, 618)
        Me.ButtonAutoBinarize2.Name = "ButtonAutoBinarize2"
        Me.ButtonAutoBinarize2.Size = New System.Drawing.Size(151, 42)
        Me.ButtonAutoBinarize2.TabIndex = 34
        Me.ButtonAutoBinarize2.Text = "AutoBinarize 2"
        Me.ButtonAutoBinarize2.UseVisualStyleBackColor = True
        '
        'ButtonReload
        '
        Me.ButtonReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonReload.Location = New System.Drawing.Point(190, 501)
        Me.ButtonReload.Name = "ButtonReload"
        Me.ButtonReload.Size = New System.Drawing.Size(151, 42)
        Me.ButtonReload.TabIndex = 35
        Me.ButtonReload.Text = "Reload Image"
        Me.ButtonReload.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(954, 671)
        Me.Controls.Add(Me.ButtonReload)
        Me.Controls.Add(Me.ButtonAutoBinarize2)
        Me.Controls.Add(Me.ButtonAutoBinarize)
        Me.Controls.Add(Me.imageXView2)
        Me.Controls.Add(Me.imageXView1)
        Me.Controls.Add(Me.ContrastLabel)
        Me.Controls.Add(Me.EccLabel)
        Me.Controls.Add(Me.PitchLabel)
        Me.Controls.Add(Me.ModeComboBox)
        Me.Controls.Add(Me.ModeLabel)
        Me.Controls.Add(Me.BlurComboBox)
        Me.Controls.Add(Me.BlurLabel)
        Me.Controls.Add(Me.GridLabel)
        Me.Controls.Add(Me.HighLabel)
        Me.Controls.Add(Me.LowLabel)
        Me.Controls.Add(Me.ContrastTextBox)
        Me.Controls.Add(Me.EccTextBox)
        Me.Controls.Add(Me.PitchTextBox)
        Me.Controls.Add(Me.GridTextBox)
        Me.Controls.Add(Me.HighTextBox)
        Me.Controls.Add(Me.LowTextBox)
        Me.Controls.Add(Me.ContrastScroll)
        Me.Controls.Add(Me.EccScroll)
        Me.Controls.Add(Me.PitchScroll)
        Me.Controls.Add(Me.AngleScroll)
        Me.Controls.Add(Me.HighScroll)
        Me.Controls.Add(Me.LowScroll)
        Me.Controls.Add(Me.ProcessButton)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(960, 720)
        Me.Menu = Me.MainMenu
        Me.MinimumSize = New System.Drawing.Size(960, 720)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Binarize"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Form Initialization"

    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm())
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Application.EnableVisualStyles()

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
        imageXView2.AutoImageDispose = True

        BlurComboBox.SelectedIndex = 0
        ModeComboBox.SelectedIndex = 0

        Try
            strCurrentDir = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\..\Common\Images"
            If System.IO.Directory.Exists(strCurrentDir) Then
                System.IO.Directory.SetCurrentDirectory(strCurrentDir)
            End If
            strCurrentDir = System.IO.Directory.GetCurrentDirectory()

            imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, System.IO.Path.Combine(strCurrentDir, "ImagXpress AutoBinarize Sample.jpg"))
            imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, System.IO.Path.Combine(strCurrentDir, "Binarize.jpg"))
            ButtonAutoBinarize_Click(sender, e)

        Catch ex As Accusoft.ImagXpressSdk.ImageXException
            ErrorLabel.Text = ex.Message
        End Try

        LowTextBox.Text = LowScroll.Value.ToString()
        HighTextBox.Text = HighScroll.Value.ToString()
        ContrastTextBox.Text = ContrastScroll.Value.ToString()

    End Sub

#End Region

#Region "Button Processing"

    Private Sub ProcessButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessButton.Click
        Try

            ' Make sure we have a base image to work with
            If (imageXView1.Image IsNot Nothing) Then

                processor1.Image = imageXView1.Image.Copy()

                Dim bMode As Accusoft.ImagXpressSdk.BinarizeMode = CType(ModeComboBox.SelectedIndex, Accusoft.ImagXpressSdk.BinarizeMode)
                Dim bBlur As Accusoft.ImagXpressSdk.BinarizeBlur = CType(BlurComboBox.SelectedIndex, Accusoft.ImagXpressSdk.BinarizeBlur)
                processor1.Binarize(bMode, LowScroll.Value, HighScroll.Value, AngleScroll.Value, PitchScroll.Value, EccScroll.Value, ContrastScroll.Value, bBlur)

                imageXView2.AllowUpdate = False
                If (imageXView2.Image IsNot Nothing) Then
                    imageXView2.Image.Dispose()
                End If
                imageXView2.Image = processor1.Image
                SynchScrollPosition()
                imageXView2.AllowUpdate = True

                processor1.Image = Nothing
            End If

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            ErrorLabel.Text = ex.Message
        End Try
    End Sub

    Private Sub ButtonAutoBinarize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAutoBinarize.Click
        Try
            ' Make sure we have a base image to work with
            If (imageXView1.Image IsNot Nothing) Then

                processor1.Image = imageXView1.Image.Copy()
                processor1.AutoBinarize()

                _lceFactor = processor1.BinarizeLceFactor
                ContrastTextBox.Text = _lceFactor.ToString()
                ContrastScroll.Value = _lceFactor

                _lowThreshold = processor1.BinarizeLowThreshold
                LowTextBox.Text = _lowThreshold.ToString()
                LowScroll.Value = _lowThreshold

                _highThreshold = processor1.BinarizeHighThreshold
                HighTextBox.Text = _highThreshold.ToString()
                HighScroll.Value = _highThreshold

                _eccentricity = processor1.BinarizeEccentricity
                EccTextBox.Text = _eccentricity.ToString()
                EccScroll.Value = _eccentricity

                _gridAngle = processor1.BinarizeGridAngle
                GridTextBox.Text = _gridAngle.ToString()
                AngleScroll.Value = _gridAngle

                _gridPitch = processor1.BinarizeGridPitch
                If (_gridPitch <= 0) Then
                    _gridPitch = 1
                End If
                PitchTextBox.Text = _gridPitch.ToString()
                PitchScroll.Value = _gridPitch

                _blur = processor1.BinarizeBlur
                BlurComboBox.SelectedIndex = CType(_blur, Integer)

                _mode = processor1.BinarizeMode
                ModeComboBox.SelectedIndex = CType(_mode, Integer)

                imageXView2.AllowUpdate = False
                If (imageXView2.Image IsNot Nothing) Then
                    imageXView2.Image.Dispose()
                End If
                imageXView2.Image = processor1.Image
                SynchScrollPosition()
                imageXView2.AllowUpdate = True

                processor1.Image = Nothing
            End If

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            ErrorLabel.Text = ex.Message
        End Try
    End Sub

    Private Sub ButtonAutoBinarize2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAutoBinarize2.Click
        Try
            ' Make sure we have a base image to work with
            If (imageXView1.Image IsNot Nothing) Then

                processor1.Image = imageXView1.Image.Copy()
                processor1.AutoBinarize2()

                'AutoBinarize2 does not update the Processor.Binarize settings
                'So we're not modifying the user interface for the binarize seettings

                imageXView2.AllowUpdate = False
                If (imageXView2.Image IsNot Nothing) Then
                    imageXView2.Image.Dispose()
                End If
                imageXView2.Image = processor1.Image
                SynchScrollPosition()
                imageXView2.AllowUpdate = True

                processor1.Image = Nothing
            End If

        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
            ErrorLabel.Text = ex.Message
        End Try

    End Sub

    Private Sub ButtonReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReload.Click
        imageXView2.AllowUpdate = False
        If (imageXView2.Image IsNot Nothing) Then
            imageXView2.Image.Dispose()
            imageXView2.Image = Nothing
        End If

        If (imageXView1.Image IsNot Nothing) Then
            imageXView2.Image = imageXView1.Image.Copy()
        End If

        SynchScrollPosition()
        imageXView2.AllowUpdate = True
    End Sub

#End Region

#Region "Option Handling"

    ' Low Threshold
    Private Sub LowScroll_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles LowScroll.Scroll
        If (LowScroll.Value >= HighScroll.Value) Then
            LowScroll.Value = HighScroll.Value - 1
            e.NewValue = LowScroll.Value
        End If
        LowTextBox.Text = LowScroll.Value.ToString()
    End Sub

    ' High Threshold
    Private Sub HighScroll_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HighScroll.Scroll
        If (HighScroll.Value <= LowScroll.Value) Then
            HighScroll.Value = LowScroll.Value + 1
            e.NewValue = HighScroll.Value
        End If
        HighTextBox.Text = HighScroll.Value.ToString()
    End Sub

    ' Grid Angle
    Private Sub AngleScroll_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles AngleScroll.Scroll
        GridTextBox.Text = AngleScroll.Value.ToString()
    End Sub

    ' Grid Pitch
    Private Sub PitchScroll_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles PitchScroll.Scroll
        PitchTextBox.Text = PitchScroll.Value.ToString()
    End Sub

    ' Eccentricity
    Private Sub EccScroll_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles EccScroll.Scroll
        EccTextBox.Text = EccScroll.Value.ToString()
    End Sub

    ' Local Contrast Enhancement
    Private Sub ContrastScroll_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles ContrastScroll.Scroll
        ContrastTextBox.Text = ContrastScroll.Value.ToString()
    End Sub

    ' Mode Selection
    Private Sub ModeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeComboBox.SelectedIndexChanged
        If ModeComboBox.SelectedIndex = 0 Then
            LowScroll.Enabled = True
            HighScroll.Enabled = True
            ContrastScroll.Enabled = True

            AngleScroll.Enabled = False
            PitchScroll.Enabled = False
            EccScroll.Enabled = False
        Else
            LowScroll.Enabled = False
            HighScroll.Enabled = False
            ContrastScroll.Enabled = False

            AngleScroll.Enabled = True
            PitchScroll.Enabled = True
            EccScroll.Enabled = True
        End If
    End Sub

#End Region

#Region "Menu Handling"

    Private Sub OpenMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenMenuItem.Click

        Dim imgFilename As String = AccusoftOpenFile()

        If Not (imgFilename Is Nothing) Then
            Try

                If Not imageXView1.Image Is Nothing Then
                    imageXView1.Image.Dispose()
                End If
                imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, imgFilename)

                If Not imageXView2.Image Is Nothing Then
                    imageXView2.Image.Dispose()
                End If
                imageXView2.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, imgFilename)

                ErrorLabel.Text = ""

            Catch ex As Accusoft.ImagXpressSdk.ImagXpressException
                AccusoftError(ex, ErrorLabel)
            End Try
        Else
            ProcessButton.Enabled = False
        End If
    End Sub

    Private Sub ExitMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ShowMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMenuItem.Click
        If ShowMenuItem.Checked = True Then
            imageXView1.Toolbar.Activated = False
            ShowMenuItem.Checked = False
        Else
            imageXView1.Toolbar.Activated = True
            ShowMenuItem.Checked = True
        End If
    End Sub

    Private Sub ImagXpressMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImagXpressMenuItem.Click
        imagXpress1.AboutBox()
    End Sub

#End Region

#Region "ImageXView object synchronization"

    Private Sub SynchScrollPosition()
        'set the output control's scroll view position to the source control's scroll view position
        imageXView2.ScrollPosition = imageXView1.ScrollPosition
    End Sub

    Private Sub imageXView1_ScrollEvent(ByVal sender As System.Object, ByVal e As Accusoft.ImagXpressSdk.ScrollEventArgs) Handles imageXView1.ScrollEvent
        Dim point As New Point(e.NewValue.X, e.NewValue.Y)
        imageXView2.ScrollPosition = point
        imageXView2.Refresh()
    End Sub

    Private Sub imageXView1_ZoomFactorChanged(ByVal sender As System.Object, ByVal e As Accusoft.ImagXpressSdk.ZoomFactorChangedEventArgs) Handles imageXView1.ZoomFactorChanged
        imageXView2.ZoomFactor = e.NewValue
        Dim Point As New Point(imageXView1.ScrollPosition.X, imageXView1.ScrollPosition.Y)
        imageXView2.ScrollPosition = Point
        imageXView2.Refresh()
    End Sub

    Private Sub imageXView1_AutoResizeChanged(ByVal sender As System.Object, ByVal e As Accusoft.ImagXpressSdk.AutoResizeChangedEventArgs) Handles imageXView1.AutoResizeChanged
        imageXView2.AutoResize = e.NewValue
        imageXView2.ZoomFactor = imageXView1.ZoomFactor
        imageXView2.Refresh()
    End Sub

    Private Sub imageXView2_ScrollEvent(ByVal sender As System.Object, ByVal e As Accusoft.ImagXpressSdk.ScrollEventArgs) Handles imageXView2.ScrollEvent
        Dim point As New Point(e.NewValue.X, e.NewValue.Y)
        imageXView1.ScrollPosition = point
        imageXView1.Refresh()
    End Sub

    Private Sub imageXView2_ZoomFactorChanged(ByVal sender As System.Object, ByVal e As Accusoft.ImagXpressSdk.ZoomFactorChangedEventArgs) Handles imageXView2.ZoomFactorChanged
        imageXView1.ZoomFactor = e.NewValue
        Dim Point As New Point(imageXView2.ScrollPosition.X, imageXView2.ScrollPosition.Y)
        imageXView1.ScrollPosition = Point
        imageXView1.Refresh()
    End Sub

    Private Sub imageXView2_AutoResizeChanged(ByVal sender As System.Object, ByVal e As Accusoft.ImagXpressSdk.AutoResizeChangedEventArgs) Handles imageXView2.AutoResizeChanged
        imageXView1.AutoResize = e.NewValue
        imageXView1.ZoomFactor = imageXView2.ZoomFactor
        imageXView1.Refresh()
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

End Class
