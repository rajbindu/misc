<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAD))
        Me.imagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imagXperssToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.labelLastError = New System.Windows.Forms.Label()
        Me.imageXView1 = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.labelLastErrorDescription = New System.Windows.Forms.Label()
        Me.DescriptionListBox = New System.Windows.Forms.ListBox()
        Me.LayerGroupBox = New System.Windows.Forms.GroupBox()
        Me.layerBox = New System.Windows.Forms.ComboBox()
        Me.OffRadioButton = New System.Windows.Forms.RadioButton()
        Me.OnRadioButton = New System.Windows.Forms.RadioButton()
        Me.PlotBox = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.LockBox = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.LayerOnBox = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.LayerNumberBox = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.LayerNameBox = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.CountBox2 = New System.Windows.Forms.Label()
        Me.layerLabel2 = New System.Windows.Forms.Label()
        Me.LayerDBox = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.LayerLabel = New System.Windows.Forms.Label()
        Me.inUseBox = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.frozenBox = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.TypeBox = New System.Windows.Forms.Label()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.VersionBox = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.loadButton = New System.Windows.Forms.Button()
        Me.LayoutGroupBox = New System.Windows.Forms.GroupBox()
        Me.layoutBox = New System.Windows.Forms.ComboBox()
        Me.LayoutNumLabel = New System.Windows.Forms.Label()
        Me.UnitLabel = New System.Windows.Forms.Label()
        Me.WidthLabel = New System.Windows.Forms.Label()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.CountLabel = New System.Windows.Forms.Label()
        Me.CountBox = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.Label()
        Me.HeightBox = New System.Windows.Forms.Label()
        Me.WidthBox = New System.Windows.Forms.Label()
        Me.UnitBox = New System.Windows.Forms.Label()
        Me.MainMenu.SuspendLayout()
        Me.LayerGroupBox.SuspendLayout()
        Me.LayoutGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.aboutToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(760, 24)
        Me.MainMenu.TabIndex = 40
        Me.MainMenu.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openToolStripMenuItem, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'openToolStripMenuItem
        '
        Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
        Me.openToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.openToolStripMenuItem.Text = "Open"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.exitToolStripMenuItem.Text = "E&xit"
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.imagXperssToolStripMenuItem})
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.aboutToolStripMenuItem.Text = "&About"
        '
        'imagXperssToolStripMenuItem
        '
        Me.imagXperssToolStripMenuItem.Name = "imagXperssToolStripMenuItem"
        Me.imagXperssToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.imagXperssToolStripMenuItem.Text = "Imag&Xpress"
        '
        'labelLastError
        '
        Me.labelLastError.AutoSize = True
        Me.labelLastError.Location = New System.Drawing.Point(441, 27)
        Me.labelLastError.Name = "labelLastError"
        Me.labelLastError.Size = New System.Drawing.Size(55, 13)
        Me.labelLastError.TabIndex = 55
        Me.labelLastError.Text = "Last Error:"
        '
        'imageXView1
        '
        Me.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit
        Me.imageXView1.Location = New System.Drawing.Point(294, 122)
        Me.imageXView1.Name = "imageXView1"
        Me.imageXView1.Size = New System.Drawing.Size(441, 492)
        Me.imageXView1.TabIndex = 54
        '
        'labelLastErrorDescription
        '
        Me.labelLastErrorDescription.Location = New System.Drawing.Point(441, 50)
        Me.labelLastErrorDescription.Name = "labelLastErrorDescription"
        Me.labelLastErrorDescription.Size = New System.Drawing.Size(295, 58)
        Me.labelLastErrorDescription.TabIndex = 53
        '
        'DescriptionListBox
        '
        Me.DescriptionListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionListBox.FormattingEnabled = True
        Me.DescriptionListBox.Items.AddRange(New Object() {"ImagXpress CAD sample. The following features are demonstrated:", "1) Loading a CAD file into ImagXpress", "2) Obtaining information from CAD files", "3) Accessing and setting ImagXpress' CAD-related fields"})
        Me.DescriptionListBox.Location = New System.Drawing.Point(12, 27)
        Me.DescriptionListBox.Name = "DescriptionListBox"
        Me.DescriptionListBox.Size = New System.Drawing.Size(412, 82)
        Me.DescriptionListBox.TabIndex = 50
        '
        'LayerGroupBox
        '
        Me.LayerGroupBox.Controls.Add(Me.layerBox)
        Me.LayerGroupBox.Controls.Add(Me.OffRadioButton)
        Me.LayerGroupBox.Controls.Add(Me.OnRadioButton)
        Me.LayerGroupBox.Controls.Add(Me.PlotBox)
        Me.LayerGroupBox.Controls.Add(Me.label18)
        Me.LayerGroupBox.Controls.Add(Me.LockBox)
        Me.LayerGroupBox.Controls.Add(Me.label2)
        Me.LayerGroupBox.Controls.Add(Me.LayerOnBox)
        Me.LayerGroupBox.Controls.Add(Me.label12)
        Me.LayerGroupBox.Controls.Add(Me.LayerNumberBox)
        Me.LayerGroupBox.Controls.Add(Me.label14)
        Me.LayerGroupBox.Controls.Add(Me.LayerNameBox)
        Me.LayerGroupBox.Controls.Add(Me.label16)
        Me.LayerGroupBox.Controls.Add(Me.CountBox2)
        Me.LayerGroupBox.Controls.Add(Me.layerLabel2)
        Me.LayerGroupBox.Controls.Add(Me.LayerDBox)
        Me.LayerGroupBox.Controls.Add(Me.label4)
        Me.LayerGroupBox.Controls.Add(Me.LayerLabel)
        Me.LayerGroupBox.Controls.Add(Me.inUseBox)
        Me.LayerGroupBox.Controls.Add(Me.label9)
        Me.LayerGroupBox.Controls.Add(Me.frozenBox)
        Me.LayerGroupBox.Controls.Add(Me.label11)
        Me.LayerGroupBox.Enabled = False
        Me.LayerGroupBox.Location = New System.Drawing.Point(15, 354)
        Me.LayerGroupBox.Name = "LayerGroupBox"
        Me.LayerGroupBox.Size = New System.Drawing.Size(272, 308)
        Me.LayerGroupBox.TabIndex = 52
        Me.LayerGroupBox.TabStop = False
        Me.LayerGroupBox.Text = "Layer"
        '
        'layerBox
        '
        Me.layerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.layerBox.FormattingEnabled = True
        Me.layerBox.Location = New System.Drawing.Point(15, 45)
        Me.layerBox.Name = "layerBox"
        Me.layerBox.Size = New System.Drawing.Size(121, 21)
        Me.layerBox.TabIndex = 41
        '
        'OffRadioButton
        '
        Me.OffRadioButton.AutoSize = True
        Me.OffRadioButton.Location = New System.Drawing.Point(164, 19)
        Me.OffRadioButton.Name = "OffRadioButton"
        Me.OffRadioButton.Size = New System.Drawing.Size(39, 17)
        Me.OffRadioButton.TabIndex = 40
        Me.OffRadioButton.Text = "Off"
        Me.OffRadioButton.UseVisualStyleBackColor = True
        '
        'OnRadioButton
        '
        Me.OnRadioButton.AutoSize = True
        Me.OnRadioButton.Location = New System.Drawing.Point(119, 19)
        Me.OnRadioButton.Name = "OnRadioButton"
        Me.OnRadioButton.Size = New System.Drawing.Size(39, 17)
        Me.OnRadioButton.TabIndex = 39
        Me.OnRadioButton.Text = "On"
        Me.OnRadioButton.UseVisualStyleBackColor = True
        '
        'PlotBox
        '
        Me.PlotBox.Location = New System.Drawing.Point(119, 260)
        Me.PlotBox.Name = "PlotBox"
        Me.PlotBox.Size = New System.Drawing.Size(110, 13)
        Me.PlotBox.TabIndex = 38
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(17, 260)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(51, 13)
        Me.label18.TabIndex = 37
        Me.label18.Text = "Plottable:"
        '
        'LockBox
        '
        Me.LockBox.Location = New System.Drawing.Point(119, 235)
        Me.LockBox.Name = "LockBox"
        Me.LockBox.Size = New System.Drawing.Size(110, 13)
        Me.LockBox.TabIndex = 36
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(17, 235)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(46, 13)
        Me.label2.TabIndex = 35
        Me.label2.Text = "Locked:"
        '
        'LayerOnBox
        '
        Me.LayerOnBox.Location = New System.Drawing.Point(119, 209)
        Me.LayerOnBox.Name = "LayerOnBox"
        Me.LayerOnBox.Size = New System.Drawing.Size(110, 13)
        Me.LayerOnBox.TabIndex = 34
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(17, 209)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(53, 13)
        Me.label12.TabIndex = 33
        Me.label12.Text = "Layer On:"
        '
        'LayerNumberBox
        '
        Me.LayerNumberBox.Location = New System.Drawing.Point(119, 183)
        Me.LayerNumberBox.Name = "LayerNumberBox"
        Me.LayerNumberBox.Size = New System.Drawing.Size(110, 13)
        Me.LayerNumberBox.TabIndex = 32
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(17, 183)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(76, 13)
        Me.label14.TabIndex = 31
        Me.label14.Text = "Layer Number:"
        '
        'LayerNameBox
        '
        Me.LayerNameBox.Location = New System.Drawing.Point(119, 157)
        Me.LayerNameBox.Name = "LayerNameBox"
        Me.LayerNameBox.Size = New System.Drawing.Size(110, 13)
        Me.LayerNameBox.TabIndex = 30
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(17, 157)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(67, 13)
        Me.label16.TabIndex = 29
        Me.label16.Text = "Layer Name:"
        '
        'CountBox2
        '
        Me.CountBox2.Location = New System.Drawing.Point(212, 48)
        Me.CountBox2.Name = "CountBox2"
        Me.CountBox2.Size = New System.Drawing.Size(30, 13)
        Me.CountBox2.TabIndex = 28
        '
        'layerLabel2
        '
        Me.layerLabel2.AutoSize = True
        Me.layerLabel2.Location = New System.Drawing.Point(142, 48)
        Me.layerLabel2.Name = "layerLabel2"
        Me.layerLabel2.Size = New System.Drawing.Size(67, 13)
        Me.layerLabel2.TabIndex = 27
        Me.layerLabel2.Text = "Layer Count:"
        '
        'LayerDBox
        '
        Me.LayerDBox.Location = New System.Drawing.Point(119, 133)
        Me.LayerDBox.Name = "LayerDBox"
        Me.LayerDBox.Size = New System.Drawing.Size(110, 13)
        Me.LayerDBox.TabIndex = 26
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(17, 133)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(92, 13)
        Me.label4.TabIndex = 25
        Me.label4.Text = "Layer Description:"
        '
        'LayerLabel
        '
        Me.LayerLabel.AutoSize = True
        Me.LayerLabel.Location = New System.Drawing.Point(15, 28)
        Me.LayerLabel.Name = "LayerLabel"
        Me.LayerLabel.Size = New System.Drawing.Size(76, 13)
        Me.LayerLabel.TabIndex = 22
        Me.LayerLabel.Text = "Layer Number:"
        '
        'inUseBox
        '
        Me.inUseBox.Location = New System.Drawing.Point(119, 110)
        Me.inUseBox.Name = "inUseBox"
        Me.inUseBox.Size = New System.Drawing.Size(110, 13)
        Me.inUseBox.TabIndex = 20
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(17, 110)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(41, 13)
        Me.label9.TabIndex = 19
        Me.label9.Text = "In Use:"
        '
        'frozenBox
        '
        Me.frozenBox.Location = New System.Drawing.Point(119, 84)
        Me.frozenBox.Name = "frozenBox"
        Me.frozenBox.Size = New System.Drawing.Size(110, 13)
        Me.frozenBox.TabIndex = 18
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(17, 84)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(42, 13)
        Me.label11.TabIndex = 17
        Me.label11.Text = "Frozen:"
        '
        'TypeBox
        '
        Me.TypeBox.Location = New System.Drawing.Point(139, 149)
        Me.TypeBox.Name = "TypeBox"
        Me.TypeBox.Size = New System.Drawing.Size(95, 13)
        Me.TypeBox.TabIndex = 49
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Location = New System.Drawing.Point(44, 149)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(78, 13)
        Me.TypeLabel.TabIndex = 48
        Me.TypeLabel.Text = "CAD File Type:"
        '
        'VersionBox
        '
        Me.VersionBox.Location = New System.Drawing.Point(139, 125)
        Me.VersionBox.Name = "VersionBox"
        Me.VersionBox.Size = New System.Drawing.Size(95, 13)
        Me.VersionBox.TabIndex = 47
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(44, 125)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(89, 13)
        Me.VersionLabel.TabIndex = 46
        Me.VersionLabel.Text = "CAD File Version:"
        '
        'loadButton
        '
        Me.loadButton.Location = New System.Drawing.Point(634, 638)
        Me.loadButton.Name = "loadButton"
        Me.loadButton.Size = New System.Drawing.Size(111, 23)
        Me.loadButton.TabIndex = 45
        Me.loadButton.Text = "Load CAD Image"
        Me.loadButton.UseVisualStyleBackColor = True
        '
        'LayoutGroupBox
        '
        Me.LayoutGroupBox.Controls.Add(Me.layoutBox)
        Me.LayoutGroupBox.Controls.Add(Me.LayoutNumLabel)
        Me.LayoutGroupBox.Controls.Add(Me.UnitLabel)
        Me.LayoutGroupBox.Controls.Add(Me.WidthLabel)
        Me.LayoutGroupBox.Controls.Add(Me.HeightLabel)
        Me.LayoutGroupBox.Controls.Add(Me.NameLabel)
        Me.LayoutGroupBox.Controls.Add(Me.CountLabel)
        Me.LayoutGroupBox.Controls.Add(Me.CountBox)
        Me.LayoutGroupBox.Controls.Add(Me.NameBox)
        Me.LayoutGroupBox.Controls.Add(Me.HeightBox)
        Me.LayoutGroupBox.Controls.Add(Me.WidthBox)
        Me.LayoutGroupBox.Controls.Add(Me.UnitBox)
        Me.LayoutGroupBox.Enabled = False
        Me.LayoutGroupBox.Location = New System.Drawing.Point(15, 170)
        Me.LayoutGroupBox.Name = "LayoutGroupBox"
        Me.LayoutGroupBox.Size = New System.Drawing.Size(272, 178)
        Me.LayoutGroupBox.TabIndex = 51
        Me.LayoutGroupBox.TabStop = False
        Me.LayoutGroupBox.Text = "Layout"
        '
        'layoutBox
        '
        Me.layoutBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.layoutBox.FormattingEnabled = True
        Me.layoutBox.Location = New System.Drawing.Point(15, 44)
        Me.layoutBox.Name = "layoutBox"
        Me.layoutBox.Size = New System.Drawing.Size(152, 21)
        Me.layoutBox.TabIndex = 17
        '
        'LayoutNumLabel
        '
        Me.LayoutNumLabel.AutoSize = True
        Me.LayoutNumLabel.Location = New System.Drawing.Point(15, 26)
        Me.LayoutNumLabel.Name = "LayoutNumLabel"
        Me.LayoutNumLabel.Size = New System.Drawing.Size(82, 13)
        Me.LayoutNumLabel.TabIndex = 10
        Me.LayoutNumLabel.Text = "Layout Number:"
        '
        'UnitLabel
        '
        Me.UnitLabel.AutoSize = True
        Me.UnitLabel.Location = New System.Drawing.Point(14, 153)
        Me.UnitLabel.Name = "UnitLabel"
        Me.UnitLabel.Size = New System.Drawing.Size(34, 13)
        Me.UnitLabel.TabIndex = 13
        Me.UnitLabel.Text = "Units:"
        '
        'WidthLabel
        '
        Me.WidthLabel.AutoSize = True
        Me.WidthLabel.Location = New System.Drawing.Point(12, 127)
        Me.WidthLabel.Name = "WidthLabel"
        Me.WidthLabel.Size = New System.Drawing.Size(38, 13)
        Me.WidthLabel.TabIndex = 11
        Me.WidthLabel.Text = "Width:"
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Location = New System.Drawing.Point(13, 101)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(41, 13)
        Me.HeightLabel.TabIndex = 7
        Me.HeightLabel.Text = "Height:"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(15, 75)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(38, 13)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "Name:"
        '
        'CountLabel
        '
        Me.CountLabel.AutoSize = True
        Me.CountLabel.Location = New System.Drawing.Point(116, 16)
        Me.CountLabel.Name = "CountLabel"
        Me.CountLabel.Size = New System.Drawing.Size(73, 13)
        Me.CountLabel.TabIndex = 15
        Me.CountLabel.Text = "Layout Count:"
        '
        'CountBox
        '
        Me.CountBox.Location = New System.Drawing.Point(192, 16)
        Me.CountBox.Name = "CountBox"
        Me.CountBox.Size = New System.Drawing.Size(26, 13)
        Me.CountBox.TabIndex = 16
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(56, 75)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(110, 13)
        Me.NameBox.TabIndex = 6
        '
        'HeightBox
        '
        Me.HeightBox.Location = New System.Drawing.Point(57, 101)
        Me.HeightBox.Name = "HeightBox"
        Me.HeightBox.Size = New System.Drawing.Size(110, 13)
        Me.HeightBox.TabIndex = 8
        '
        'WidthBox
        '
        Me.WidthBox.Location = New System.Drawing.Point(57, 127)
        Me.WidthBox.Name = "WidthBox"
        Me.WidthBox.Size = New System.Drawing.Size(110, 13)
        Me.WidthBox.TabIndex = 12
        '
        'UnitBox
        '
        Me.UnitBox.Location = New System.Drawing.Point(57, 153)
        Me.UnitBox.Name = "UnitBox"
        Me.UnitBox.Size = New System.Drawing.Size(110, 13)
        Me.UnitBox.TabIndex = 14
        '
        'CAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 677)
        Me.Controls.Add(Me.labelLastError)
        Me.Controls.Add(Me.imageXView1)
        Me.Controls.Add(Me.labelLastErrorDescription)
        Me.Controls.Add(Me.DescriptionListBox)
        Me.Controls.Add(Me.LayerGroupBox)
        Me.Controls.Add(Me.TypeBox)
        Me.Controls.Add(Me.TypeLabel)
        Me.Controls.Add(Me.VersionBox)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.loadButton)
        Me.Controls.Add(Me.LayoutGroupBox)
        Me.Controls.Add(Me.MainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CAD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAD"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.LayerGroupBox.ResumeLayout(False)
        Me.LayerGroupBox.PerformLayout()
        Me.LayoutGroupBox.ResumeLayout(False)
        Me.LayoutGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
    Private WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Private WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents imagXperssToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents labelLastError As System.Windows.Forms.Label
    Private WithEvents imageXView1 As Accusoft.ImagXpressSdk.ImageXView
    Private WithEvents labelLastErrorDescription As System.Windows.Forms.Label
    Private WithEvents DescriptionListBox As System.Windows.Forms.ListBox
    Private WithEvents LayerGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents layerBox As System.Windows.Forms.ComboBox
    Private WithEvents OffRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents OnRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents PlotBox As System.Windows.Forms.Label
    Private WithEvents label18 As System.Windows.Forms.Label
    Private WithEvents LockBox As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents LayerOnBox As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents LayerNumberBox As System.Windows.Forms.Label
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents LayerNameBox As System.Windows.Forms.Label
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents CountBox2 As System.Windows.Forms.Label
    Private WithEvents layerLabel2 As System.Windows.Forms.Label
    Private WithEvents LayerDBox As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents LayerLabel As System.Windows.Forms.Label
    Private WithEvents inUseBox As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents frozenBox As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents TypeBox As System.Windows.Forms.Label
    Private WithEvents TypeLabel As System.Windows.Forms.Label
    Private WithEvents VersionBox As System.Windows.Forms.Label
    Private WithEvents VersionLabel As System.Windows.Forms.Label
    Private WithEvents loadButton As System.Windows.Forms.Button
    Private WithEvents LayoutGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents layoutBox As System.Windows.Forms.ComboBox
    Private WithEvents LayoutNumLabel As System.Windows.Forms.Label
    Private WithEvents UnitLabel As System.Windows.Forms.Label
    Private WithEvents WidthLabel As System.Windows.Forms.Label
    Private WithEvents HeightLabel As System.Windows.Forms.Label
    Private WithEvents NameLabel As System.Windows.Forms.Label
    Private WithEvents CountLabel As System.Windows.Forms.Label
    Private WithEvents CountBox As System.Windows.Forms.Label
    Private WithEvents NameBox As System.Windows.Forms.Label
    Private WithEvents HeightBox As System.Windows.Forms.Label
    Private WithEvents WidthBox As System.Windows.Forms.Label
    Private WithEvents UnitBox As System.Windows.Forms.Label

End Class
