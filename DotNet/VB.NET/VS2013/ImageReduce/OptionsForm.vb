'*********************************************************************'
'* Copyright 2005-2016 - Accusoft Corporation, Tampa Florida.        *'
'* This sample code is provided to Accusoft licensees "as is"        *'
'* with no restrictions on use or modification. No warranty for      *'
'* use of this sample code is provided by Accusoft.                  *'
'*********************************************************************'
Imports System.Windows.Forms
Imports Accusoft.ImagXpressSdk

Partial Public Class OptionsForm
    Inherits Form
    Private _jpegQualityFactor As System.Int32 = 22
    Public Property JpegQualityFactor() As System.Int32
        Get
            Return _jpegQualityFactor
        End Get
        Set(value As System.Int32)
            _jpegQualityFactor = value
        End Set
    End Property

    Private _transformMode As TransformMode = Accusoft.ImagXpressSdk.TransformMode.None
    Public Property TransformMode() As TransformMode
        Get
            Return _transformMode
        End Get
        Set(value As TransformMode)
            _transformMode = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub buttonCancel_Click(sender As Object, e As System.EventArgs)
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub buttonOK_Click(sender As Object, e As System.EventArgs) Handles buttonOK.Click
        _jpegQualityFactor = CInt(Math.Truncate(jpegQualityFactorNumericUpDown.Value))
        _transformMode = CType(TransformModeComboBox.SelectedIndex, TransformMode)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub OptionsForm_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        jpegQualityFactorNumericUpDown.Value = _jpegQualityFactor
        TransformModeComboBox.SelectedIndex = _transformMode
    End Sub
End Class
