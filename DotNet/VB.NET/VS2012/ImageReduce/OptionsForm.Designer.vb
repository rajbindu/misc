Partial Class OptionsForm
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
        Me.buttonOK = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.jpegQualityFactorLabel = New System.Windows.Forms.Label()
        Me.jpegQualityFactorNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.TransformModeLabel = New System.Windows.Forms.Label()
        Me.TransformModeComboBox = New System.Windows.Forms.ComboBox()
        Me.jpegGroupBox = New System.Windows.Forms.GroupBox()
        CType(Me.jpegQualityFactorNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.jpegGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonOK
        '
        Me.buttonOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.buttonOK.Location = New System.Drawing.Point(88, 131)
        Me.buttonOK.Name = "buttonOK"
        Me.buttonOK.Size = New System.Drawing.Size(75, 23)
        Me.buttonOK.TabIndex = 10
        Me.buttonOK.Text = "OK"
        Me.buttonOK.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Location = New System.Drawing.Point(169, 131)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancel.TabIndex = 11
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'jpegQualityFactorLabel
        '
        Me.jpegQualityFactorLabel.Location = New System.Drawing.Point(22, 26)
        Me.jpegQualityFactorLabel.Name = "jpegQualityFactorLabel"
        Me.jpegQualityFactorLabel.Size = New System.Drawing.Size(123, 13)
        Me.jpegQualityFactorLabel.TabIndex = 14
        Me.jpegQualityFactorLabel.Text = "Quality Factor"
        '
        'jpegQualityFactorNumericUpDown
        '
        Me.jpegQualityFactorNumericUpDown.Location = New System.Drawing.Point(25, 42)
        Me.jpegQualityFactorNumericUpDown.Maximum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.jpegQualityFactorNumericUpDown.Name = "jpegQualityFactorNumericUpDown"
        Me.jpegQualityFactorNumericUpDown.Size = New System.Drawing.Size(50, 20)
        Me.jpegQualityFactorNumericUpDown.TabIndex = 15
        Me.jpegQualityFactorNumericUpDown.Value = New Decimal(New Integer() {22, 0, 0, 0})
        '
        'TransformModeLabel
        '
        Me.TransformModeLabel.AutoSize = True
        Me.TransformModeLabel.Location = New System.Drawing.Point(22, 70)
        Me.TransformModeLabel.Name = "TransformModeLabel"
        Me.TransformModeLabel.Size = New System.Drawing.Size(87, 13)
        Me.TransformModeLabel.TabIndex = 19
        Me.TransformModeLabel.Text = "Transform Mode:"
        '
        'TransformModeComboBox
        '
        Me.TransformModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TransformModeComboBox.FormattingEnabled = True
        Me.TransformModeComboBox.Items.AddRange(New Object() {"Do not transform", "To Progressive JPEG", "To Sequential JPEG"})
        Me.TransformModeComboBox.Location = New System.Drawing.Point(25, 86)
        Me.TransformModeComboBox.Name = "TransformModeComboBox"
        Me.TransformModeComboBox.Size = New System.Drawing.Size(151, 21)
        Me.TransformModeComboBox.TabIndex = 18
        '
        'jpegGroupBox
        '
        Me.jpegGroupBox.Controls.Add(Me.jpegQualityFactorLabel)
        Me.jpegGroupBox.Controls.Add(Me.jpegQualityFactorNumericUpDown)
        Me.jpegGroupBox.Controls.Add(Me.TransformModeComboBox)
        Me.jpegGroupBox.Controls.Add(Me.TransformModeLabel)
        Me.jpegGroupBox.Location = New System.Drawing.Point(13, 12)
        Me.jpegGroupBox.Name = "jpegGroupBox"
        Me.jpegGroupBox.Size = New System.Drawing.Size(231, 113)
        Me.jpegGroupBox.TabIndex = 16
        Me.jpegGroupBox.TabStop = False
        Me.jpegGroupBox.Text = "JPEG"
        '
        'OptionsForm
        '
        Me.AcceptButton = Me.buttonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(256, 168)
        Me.Controls.Add(Me.buttonOK)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.jpegGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        CType(Me.jpegQualityFactorNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.jpegGroupBox.ResumeLayout(False)
        Me.jpegGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents TransformModeLabel As System.Windows.Forms.Label
    Private WithEvents TransformModeComboBox As System.Windows.Forms.ComboBox
    Private WithEvents buttonOK As System.Windows.Forms.Button
	Private buttonCancel As System.Windows.Forms.Button
	Private jpegQualityFactorLabel As System.Windows.Forms.Label
    Private jpegQualityFactorNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents jpegGroupBox As System.Windows.Forms.GroupBox

End Class
