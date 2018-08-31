Partial Class MainForm
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.backgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clearFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.reduceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparatorExit = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.optionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imagXpressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.listView = New System.Windows.Forms.ListView()
        Me.columnHeaderFilename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeaderSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeaderReducedSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeaderSavings = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnRemarks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.selectLabel = New System.Windows.Forms.Label()
        Me.stopButton = New System.Windows.Forms.Button()
        Me.reduceButton = New System.Windows.Forms.Button()
        Me.splitter2 = New System.Windows.Forms.Splitter()
        Me.imagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress(Me.components)
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.outputPanel = New System.Windows.Forms.Panel()
        Me.outputImageXView = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.outputFileNameLabel = New System.Windows.Forms.Label()
        Me.inputPanel = New System.Windows.Forms.Panel()
        Me.inputImageXView = New Accusoft.ImagXpressSdk.ImageXView(Me.components)
        Me.inputFileNameLabel = New System.Windows.Forms.Label()
        Me.menuStrip.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.outputPanel.SuspendLayout()
        Me.inputPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'backgroundWorker
        '
        Me.backgroundWorker.WorkerReportsProgress = True
        Me.backgroundWorker.WorkerSupportsCancellation = True
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.editToolStripMenuItem, Me.aboutToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(936, 24)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addFilesToolStripMenuItem, Me.addDirectoryToolStripMenuItem, Me.clearFilesToolStripMenuItem, Me.toolStripSeparator1, Me.reduceToolStripMenuItem, Me.stopToolStripMenuItem, Me.toolStripSeparatorExit, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'addFilesToolStripMenuItem
        '
        Me.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem"
        Me.addFilesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.addFilesToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.addFilesToolStripMenuItem.Text = "&Add File(s)..."
        '
        'addDirectoryToolStripMenuItem
        '
        Me.addDirectoryToolStripMenuItem.Name = "addDirectoryToolStripMenuItem"
        Me.addDirectoryToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.addDirectoryToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.addDirectoryToolStripMenuItem.Text = "Add &Directory"
        '
        'clearFilesToolStripMenuItem
        '
        Me.clearFilesToolStripMenuItem.Name = "clearFilesToolStripMenuItem"
        Me.clearFilesToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.clearFilesToolStripMenuItem.Text = "Clear"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(219, 6)
        '
        'reduceToolStripMenuItem
        '
        Me.reduceToolStripMenuItem.Name = "reduceToolStripMenuItem"
        Me.reduceToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.reduceToolStripMenuItem.Text = "Reduce"
        '
        'stopToolStripMenuItem
        '
        Me.stopToolStripMenuItem.Name = "stopToolStripMenuItem"
        Me.stopToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.stopToolStripMenuItem.Text = "Stop"
        '
        'toolStripSeparatorExit
        '
        Me.toolStripSeparatorExit.Name = "toolStripSeparatorExit"
        Me.toolStripSeparatorExit.Size = New System.Drawing.Size(219, 6)
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.exitToolStripMenuItem.Text = "E&xit"
        '
        'editToolStripMenuItem
        '
        Me.editToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.optionsToolStripMenuItem})
        Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
        Me.editToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.editToolStripMenuItem.Text = "&Edit"
        '
        'optionsToolStripMenuItem
        '
        Me.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem"
        Me.optionsToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.optionsToolStripMenuItem.Text = "Options..."
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.imagXpressToolStripMenuItem})
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.aboutToolStripMenuItem.Text = "&About"
        '
        'imagXpressToolStripMenuItem
        '
        Me.imagXpressToolStripMenuItem.Name = "imagXpressToolStripMenuItem"
        Me.imagXpressToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.imagXpressToolStripMenuItem.Text = "&ImagXpress..."
        '
        'listView
        '
        Me.listView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeaderFilename, Me.columnHeaderSize, Me.columnHeaderReducedSize, Me.columnHeaderSavings, Me.columnRemarks})
        Me.listView.Dock = System.Windows.Forms.DockStyle.Top
        Me.listView.FullRowSelect = True
        Me.listView.HideSelection = False
        Me.listView.Location = New System.Drawing.Point(0, 24)
        Me.listView.MultiSelect = False
        Me.listView.Name = "listView"
        Me.listView.ShowGroups = False
        Me.listView.Size = New System.Drawing.Size(936, 113)
        Me.listView.TabIndex = 1
        Me.listView.UseCompatibleStateImageBehavior = False
        Me.listView.View = System.Windows.Forms.View.Details
        '
        'columnHeaderFilename
        '
        Me.columnHeaderFilename.Text = "File"
        Me.columnHeaderFilename.Width = 400
        '
        'columnHeaderSize
        '
        Me.columnHeaderSize.Text = "Original"
        Me.columnHeaderSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.columnHeaderSize.Width = 100
        '
        'columnHeaderReducedSize
        '
        Me.columnHeaderReducedSize.Text = "Reduced"
        Me.columnHeaderReducedSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.columnHeaderReducedSize.Width = 100
        '
        'columnHeaderSavings
        '
        Me.columnHeaderSavings.Text = "Savings"
        Me.columnHeaderSavings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.columnHeaderSavings.Width = 110
        '
        'columnRemarks
        '
        Me.columnRemarks.Text = "Remarks"
        Me.columnRemarks.Width = 200
        '
        'panel4
        '
        Me.panel4.Controls.Add(Me.selectLabel)
        Me.panel4.Controls.Add(Me.stopButton)
        Me.panel4.Controls.Add(Me.reduceButton)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel4.Location = New System.Drawing.Point(0, 140)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(936, 29)
        Me.panel4.TabIndex = 9
        '
        'selectLabel
        '
        Me.selectLabel.AutoSize = True
        Me.selectLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.selectLabel.Location = New System.Drawing.Point(0, 0)
        Me.selectLabel.Name = "selectLabel"
        Me.selectLabel.Size = New System.Drawing.Size(282, 13)
        Me.selectLabel.TabIndex = 7
        Me.selectLabel.Text = "Select a row to see the results once reduction is complete."
        '
        'stopButton
        '
        Me.stopButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stopButton.Location = New System.Drawing.Point(777, 3)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(75, 23)
        Me.stopButton.TabIndex = 8
        Me.stopButton.Text = "&Stop"
        Me.stopButton.UseVisualStyleBackColor = True
        Me.stopButton.Visible = False
        '
        'reduceButton
        '
        Me.reduceButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reduceButton.Enabled = False
        Me.reduceButton.Location = New System.Drawing.Point(858, 3)
        Me.reduceButton.Name = "reduceButton"
        Me.reduceButton.Size = New System.Drawing.Size(75, 23)
        Me.reduceButton.TabIndex = 9
        Me.reduceButton.Text = "&Reduce"
        Me.reduceButton.UseVisualStyleBackColor = True
        '
        'splitter2
        '
        Me.splitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.splitter2.Location = New System.Drawing.Point(0, 137)
        Me.splitter2.Name = "splitter2"
        Me.splitter2.Size = New System.Drawing.Size(936, 3)
        Me.splitter2.TabIndex = 10
        Me.splitter2.TabStop = False
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.outputPanel, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.inputPanel, 0, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 169)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 1
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(936, 403)
        Me.tableLayoutPanel1.TabIndex = 12
        '
        'outputPanel
        '
        Me.outputPanel.Controls.Add(Me.outputImageXView)
        Me.outputPanel.Controls.Add(Me.outputFileNameLabel)
        Me.outputPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.outputPanel.Location = New System.Drawing.Point(471, 3)
        Me.outputPanel.Name = "outputPanel"
        Me.outputPanel.Size = New System.Drawing.Size(462, 397)
        Me.outputPanel.TabIndex = 17
        '
        'outputImageXView
        '
        Me.outputImageXView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.outputImageXView.Location = New System.Drawing.Point(0, 13)
        Me.outputImageXView.Name = "outputImageXView"
        Me.outputImageXView.Size = New System.Drawing.Size(462, 384)
        Me.outputImageXView.TabIndex = 2
        '
        'outputFileNameLabel
        '
        Me.outputFileNameLabel.AutoSize = True
        Me.outputFileNameLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.outputFileNameLabel.Location = New System.Drawing.Point(0, 0)
        Me.outputFileNameLabel.Name = "outputFileNameLabel"
        Me.outputFileNameLabel.Size = New System.Drawing.Size(87, 13)
        Me.outputFileNameLabel.TabIndex = 0
        Me.outputFileNameLabel.Text = "Output Filename:"
        '
        'inputPanel
        '
        Me.inputPanel.Controls.Add(Me.inputImageXView)
        Me.inputPanel.Controls.Add(Me.inputFileNameLabel)
        Me.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputPanel.Location = New System.Drawing.Point(3, 3)
        Me.inputPanel.Name = "inputPanel"
        Me.inputPanel.Size = New System.Drawing.Size(462, 397)
        Me.inputPanel.TabIndex = 14
        '
        'inputImageXView
        '
        Me.inputImageXView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputImageXView.Location = New System.Drawing.Point(0, 13)
        Me.inputImageXView.Name = "inputImageXView"
        Me.inputImageXView.Size = New System.Drawing.Size(462, 384)
        Me.inputImageXView.TabIndex = 1
        '
        'inputFileNameLabel
        '
        Me.inputFileNameLabel.AutoSize = True
        Me.inputFileNameLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputFileNameLabel.Location = New System.Drawing.Point(0, 0)
        Me.inputFileNameLabel.Name = "inputFileNameLabel"
        Me.inputFileNameLabel.Size = New System.Drawing.Size(79, 13)
        Me.inputFileNameLabel.TabIndex = 0
        Me.inputFileNameLabel.Text = "Input Filename:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 572)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.panel4)
        Me.Controls.Add(Me.splitter2)
        Me.Controls.Add(Me.listView)
        Me.Controls.Add(Me.menuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip
        Me.MinimumSize = New System.Drawing.Size(952, 611)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImageReduce"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.outputPanel.ResumeLayout(False)
        Me.outputPanel.PerformLayout()
        Me.inputPanel.ResumeLayout(False)
        Me.inputPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

	#End Region

    Private WithEvents backgroundWorker As System.ComponentModel.BackgroundWorker
	Private menuStrip As System.Windows.Forms.MenuStrip
	Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents imagXpressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents addFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents addDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents listView As System.Windows.Forms.ListView
	Private columnHeaderFilename As System.Windows.Forms.ColumnHeader
	Private columnHeaderSize As System.Windows.Forms.ColumnHeader
	Private columnHeaderReducedSize As System.Windows.Forms.ColumnHeader
	Private columnHeaderSavings As System.Windows.Forms.ColumnHeader
    Private WithEvents clearFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparatorExit As System.Windows.Forms.ToolStripSeparator
	Private editToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents reduceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents optionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private stopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private panel4 As System.Windows.Forms.Panel
	Private selectLabel As System.Windows.Forms.Label
    Private WithEvents stopButton As System.Windows.Forms.Button
    Private WithEvents reduceButton As System.Windows.Forms.Button
	Private splitter2 As System.Windows.Forms.Splitter
	Private imagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private outputPanel As System.Windows.Forms.Panel
    Private WithEvents outputImageXView As Accusoft.ImagXpressSdk.ImageXView
	Private outputFileNameLabel As System.Windows.Forms.Label
	Private inputPanel As System.Windows.Forms.Panel
    Private WithEvents inputImageXView As Accusoft.ImagXpressSdk.ImageXView
	Private inputFileNameLabel As System.Windows.Forms.Label
	Private columnRemarks As System.Windows.Forms.ColumnHeader
End Class

