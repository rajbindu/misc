'*********************************************************************'
'* Copyright 2005-2016 - Accusoft Corporation, Tampa Florida.        *'
'* This sample code is provided to Accusoft licensees "as is"        *'
'* with no restrictions on use or modification. No warranty for      *'
'* use of this sample code is provided by Accusoft.                  *'
'*********************************************************************'
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports Accusoft.ImagXpressSdk

Public Partial Class MainForm
	Inherits Form
    Private _transformMode As TransformMode = TransformMode.None
    Shared _jpegQualityFactor As Int32 = 22

    Dim lastFilterIndex As Integer

	Public Sub New()
		InitializeComponent()
	End Sub

    Const TITLE As String = "ImageReduce"
    Const COLUMN_FILENAME As Int32 = 0
    Const COLUMN_FILESIZE As Int32 = 1
    Const COLUMN_REDUCEDSIZE As Int32 = 2
    Const COLUMN_SAVINGSSIZE As Int32 = 3
    Const COLUMN_REMARKS As Int32 = 4

    Public Class ReduceOptions
        Public inputPath As String
        Public outputPath As String
    End Class

    Public Class JpegReduceOptions
        Inherits ReduceOptions
		Public transformMode As TransformMode
        Public jpegQualityFactor As Int32
    End Class

    Public Class ReduceResult
        Public inputPath As String
        Public outputPath As String
        Public isErrorEncountered As Boolean
        Public remarks As String
    End Class

    Public Class JpegReduceResult
        Inherits ReduceResult

        Public Sub New()
        End Sub

        Public Sub New(baseResult As ReduceResult)
            inputPath = baseResult.inputPath
            outputPath = baseResult.outputPath
            isErrorEncountered = baseResult.isErrorEncountered
            remarks = baseResult.remarks
            jpegQualityFactor = _jpegQualityFactor
        End Sub

        Public jpegQualityFactor As Int32
        Public transformMode As TransformMode
    End Class

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
        '_ix.Licensing.SetSolutionName("YourSolutionName");
        '_ix.Licensing.SetSolutionKey(12345,12345,12345,12345);
        '_ix.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation…");

        ' Bind ImagXpress Hand tool to left mouse button.
        inputImageXView.ToolSet(Tool.Hand, MouseButtons.Left, Keys.None)
        outputImageXView.ToolSet(Tool.Hand, MouseButtons.Left, Keys.None)
    End Sub

    Private Function DisplayFileSize(fileLength As Long) As String
        Dim fileLengthDisplayed As String = String.Empty

        If System.Math.Abs(fileLength) < 1024 Then
            fileLengthDisplayed = String.Format("{0:N0} Bytes", fileLength)
        Else
            fileLengthDisplayed = String.Format("{0:N0} KB", CDbl(fileLength) / 1024)
        End If

        Return fileLengthDisplayed
    End Function

    Private Sub AddFileToReduce(filename As String)
        If 0 = listView.Items.Find(filename, True).Length Then
            Dim fileLengthDisplayed As String = DisplayFileSize(New FileInfo(filename).Length)
            Dim fullPath As String = Path.GetFullPath(filename)

            Dim item As New ListViewItem(New String() {fullPath, fileLengthDisplayed, String.Empty, String.Empty, String.Empty})
            item.Name = fullPath
            listView.Items.Add(item)

            reduceButton.Enabled = True
        End If
    End Sub

    Private Sub openFileToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles addFilesToolStripMenuItem.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Multiselect = True
            openFileDialog.Filter = "JPEG|*.jpe;*.jpg;*.jpeg|PNG|*.png"
            openFileDialog.FilterIndex = lastFilterIndex

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                lastFilterIndex = openFileDialog.FilterIndex

                For Each path As String In openFileDialog.FileNames
                    AddFileToReduce(path)
                Next
            End If
        End Using
    End Sub

    Private Sub openDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addDirectoryToolStripMenuItem.Click
        Using folderBrowseDialog As New FolderBrowserDialog()
            If folderBrowseDialog.ShowDialog() = DialogResult.OK Then
                Dim files As String() = Directory.GetFiles(folderBrowseDialog.SelectedPath)

                For Each file As String In files
                    If file.EndsWith(".jpe", StringComparison.OrdinalIgnoreCase) OrElse file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) OrElse file.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) _
                        OrElse file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) Then
                        AddFileToReduce(file)
                    End If
                Next
            End If
        End Using
    End Sub

    Private Sub imagXpressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles imagXpressToolStripMenuItem.Click
        imagXpress1.AboutBox()
    End Sub

    Private Sub reduceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles reduceToolStripMenuItem.Click
        reduceImagesAsync()
    End Sub

    Private Sub buttonReduce_Click(sender As Object, e As EventArgs) Handles reduceButton.Click
        reduceImagesAsync()
    End Sub

    Private Function IsFileExtensionJpeg(filename As String) As Boolean
        Dim extension As String = Path.GetExtension(filename)

        If (String.Equals(extension, ".jpg", StringComparison.OrdinalIgnoreCase) Or String.Equals(extension, ".jpeg", StringComparison.OrdinalIgnoreCase) Or String.Equals(extension, ".jpe", StringComparison.OrdinalIgnoreCase)) Then
            Return True
        End If

        Return False
    End Function

    Private Function IsFileExtensionPng(filename As String) As Boolean
        Dim extension As String = Path.GetExtension(filename)

        If (String.Equals(extension, ".png", StringComparison.OrdinalIgnoreCase)) Then
            Return True
        End If

        Return False
    End Function

    Private Sub reduceImagesAsync()
        DisableUIForRun()
        Dim optionsList As New List(Of ReduceOptions)()
        For Each item As ListViewItem In listView.Items
            ' Save reduced file to a subdirectory called "Reduced" in the same location 
            ' as the input. 
            ' e.g. c:\users\public\Accusoft\Common\Images\akuma.jpg -> c:\users\public\Accusoft\Common\Images\Reduced\akuma.jpg
            '
            Dim inputPath As String = item.SubItems(COLUMN_FILENAME).Text
            Dim inputFileName As String = Path.GetFileName(inputPath)
            Dim inputDirectory As String = Path.GetDirectoryName(inputPath)
            Dim outputDirectory As String = Path.Combine(inputDirectory, "Reduced")

            If (IsFileExtensionJpeg(inputPath)) Then
                Dim options As JpegReduceOptions = New JpegReduceOptions()
                options.inputPath = inputPath
                options.outputPath = Path.Combine(outputDirectory, inputFileName)
				options.transformMode = _transformMode
                options.jpegQualityFactor = _jpegQualityFactor

                optionsList.Add(options)
            ElseIf (IsFileExtensionPng(inputPath)) Then
                Dim options As ReduceOptions = New ReduceOptions()
                options.inputPath = inputPath
                options.outputPath = Path.Combine(outputDirectory, inputFileName)

                optionsList.Add(options)
            End If
        Next
        backgroundWorker.RunWorkerAsync(optionsList)
    End Sub

    Private Sub backgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles backgroundWorker.DoWork
        Dim optionsList As List(Of ReduceOptions) = DirectCast(e.Argument, List(Of ReduceOptions))
        Dim remaining As Int32 = optionsList.Count
        For Each options As ReduceOptions In optionsList
            If backgroundWorker.CancellationPending Then
                Exit For
            End If

            ' Prepare to save reduced image: 
            ' - Delete the target file if it already exists
            ' - Ensure the host directory exists.
            deleteFileWhenExists(options.outputPath)
            Directory.CreateDirectory(Path.GetDirectoryName(options.outputPath))

            Dim jpegReduceOptions As JpegReduceOptions = New JpegReduceOptions()
            Dim jpegLatestResult As JpegReduceResult = New JpegReduceResult()

            Dim latestResult As New ReduceResult()

            ' Perform reduction and prepare to report results
            latestResult.inputPath = options.inputPath
            latestResult.outputPath = options.outputPath
            latestResult.isErrorEncountered = False
            latestResult.remarks = String.Empty

            Dim areOptionsForJpeg As Boolean

            If (TypeOf options Is JpegReduceOptions) Then
                areOptionsForJpeg = True
            Else
                areOptionsForJpeg = False
            End If

            If (areOptionsForJpeg) Then                
                jpegReduceOptions = CType(options, JpegReduceOptions)
                jpegLatestResult = New JpegReduceResult(latestResult)
                jpegLatestResult.jpegQualityFactor = jpegReduceOptions.jpegQualityFactor
				jpegLatestResult.transformMode = jpegReduceOptions.transformMode
            End If

            Try
                If (areOptionsForJpeg) Then                                     
                    Accusoft.ImagXpressSdk.ImageReduce.JpegReduce(imagXpress1, jpegReduceOptions.inputPath, jpegReduceOptions.outputPath, jpegReduceOptions.jpegQualityFactor)
                Else
                    Accusoft.ImagXpressSdk.ImageReduce.PngReduce(imagXpress1, options.inputPath, options.outputPath)
                End If
            Catch ex As ImagXpressException
                latestResult.isErrorEncountered = True
                latestResult.remarks = ex.Message
            Catch ex As Exception
                latestResult.isErrorEncountered = True
                latestResult.remarks = ex.ToString()
            End Try

            ' Notify UI of a progress update
            Dim percentComplete As Integer = CInt(Math.Truncate(CSng(optionsList.Count - remaining) / optionsList.Count * 100))
            If (areOptionsForJpeg) Then
                backgroundWorker.ReportProgress(percentComplete, jpegLatestResult)
            Else                
                backgroundWorker.ReportProgress(percentComplete, latestResult)
            End If
            remaining -= 1
        Next
    End Sub

    Private Sub backgroundWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles backgroundWorker.ProgressChanged
        ' Interpret results
        Dim latestResult As ReduceResult = CType(e.UserState, ReduceResult)
        Dim inputFileLength As Long = 0
        If File.Exists(latestResult.inputPath) Then
            inputFileLength = New FileInfo(latestResult.inputPath).Length
        End If
        Dim outputFileLength As Long = 0
        If File.Exists(latestResult.outputPath) Then
            outputFileLength = New FileInfo(latestResult.outputPath).Length
        End If
        Dim savingsBytes As Long = 0
        If 0 <> inputFileLength AndAlso 0 <> outputFileLength Then
            savingsBytes = inputFileLength - outputFileLength
        End If
        Dim savingsPercentage As Double = 0
        If 0 <> inputFileLength Then
            savingsPercentage = CDbl(savingsBytes) / inputFileLength
        End If
        Dim savingsPercentageString As String = String.Format("{1} ({0:0 %})", savingsPercentage, DisplayFileSize(savingsBytes))
        Dim outputFileLengthString As String = DisplayFileSize(outputFileLength)

        Dim reductionColor As Color = Color.FromArgb(255, 0, 232, 0)
        Dim growthColor As Color = Color.Red
        Try
            listView.SuspendLayout()

            For Each item As ListViewItem In listView.Items.Find(latestResult.inputPath, True)
                ' Update list view details
                ' Note: For convenience, the path to the reduced image will be carried
                '      in the Tag property of the file name column.
                item.SubItems(COLUMN_FILENAME).Tag = latestResult.outputPath
                item.SubItems(COLUMN_REDUCEDSIZE).Text = outputFileLengthString
                item.SubItems(COLUMN_SAVINGSSIZE).Text = savingsPercentageString
                item.SubItems(COLUMN_REMARKS).Text = latestResult.remarks
                If savingsPercentage > 0 Then
                    item.SubItems(COLUMN_SAVINGSSIZE).BackColor = reductionColor
                ElseIf savingsPercentage < 0 Then
                    item.SubItems(COLUMN_SAVINGSSIZE).BackColor = growthColor
                End If

                ' Refresh previously selected row
                If item.Selected Then
                    refreshSideBySideComparison(item)
                End If
            Next
        Finally
            listView.ResumeLayout()
        End Try

        ' Report Progress to user
        Text = String.Format("{0}% - {1}", New Object() {e.ProgressPercentage, TITLE})
    End Sub

    Private Sub refreshSideBySideComparison(item As ListViewItem)
        Dim lastCursor As Cursor = Cursor.Current
        Try
            Cursor.Current = Cursors.WaitCursor
            inputImageXView.SuspendLayout()
            outputImageXView.SuspendLayout()

            inputFileNameLabel.Text = String.Format("{0}, {1}", New Object() {item.SubItems(COLUMN_FILENAME).Text, item.SubItems(COLUMN_FILESIZE).Text})
            inputImageXView.Image = Nothing
            If File.Exists(item.SubItems(COLUMN_FILENAME).Text) Then
                inputImageXView.Image = ImageX.FromFile(imagXpress1, item.SubItems(COLUMN_FILENAME).Text)
            End If

            outputFileNameLabel.Text = String.Format("{0}, {1}", New Object() {item.SubItems(COLUMN_FILENAME).Tag, item.SubItems(COLUMN_REDUCEDSIZE).Text})
            outputImageXView.Image = Nothing
            If File.Exists(DirectCast(item.SubItems(COLUMN_FILENAME).Tag, String)) Then
                outputImageXView.Image = ImageX.FromFile(imagXpress1, DirectCast(item.SubItems(COLUMN_FILENAME).Tag, String))
            End If
        Catch ex As ImageXException
            MessageBox.Show(ex.Message)
        Finally
            inputImageXView.ResumeLayout()
            outputImageXView.ResumeLayout()
            Cursor.Current = lastCursor
        End Try
    End Sub

    Private Sub listView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listView.SelectedIndexChanged
        For Each index As Int32 In listView.SelectedIndices
            refreshSideBySideComparison(listView.Items(index))
        Next
    End Sub

    Private Sub backgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles backgroundWorker.RunWorkerCompleted
        ReenableUIForAnotherRun()
    End Sub

    Private Sub buttonCancel_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        backgroundWorker.CancelAsync()
    End Sub

    Private Sub closeFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles clearFilesToolStripMenuItem.Click
        ReenableUIForAnotherRun()
        ResetUI()
    End Sub

    Private Sub optionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles optionsToolStripMenuItem.Click
        Using optionsForm As New OptionsForm()
            optionsForm.JpegQualityFactor = _jpegQualityFactor
            optionsForm.TransformMode = _transformMode
            If DialogResult.OK = optionsForm.ShowDialog() Then
                _jpegQualityFactor = optionsForm.JpegQualityFactor
                _transformMode = optionsForm.TransformMode
            End If
        End Using
    End Sub

    Private Sub inputImageXView_ScrollEvent(sender As Object, e As Accusoft.ImagXpressSdk.ScrollEventArgs) Handles inputImageXView.ScrollEvent
        ' Sync view between before and after iamges
        outputImageXView.ScrollPosition = inputImageXView.ScrollPosition
    End Sub
    Private Sub outputImageXView_ScrollEvent(sender As Object, e As Accusoft.ImagXpressSdk.ScrollEventArgs) Handles outputImageXView.ScrollEvent
        ' Sync view between before and after iamges
        inputImageXView.ScrollPosition = outputImageXView.ScrollPosition
    End Sub
    Private Sub inputImageXView_ZoomFactorChanged(sender As Object, e As ZoomFactorChangedEventArgs) Handles inputImageXView.ZoomFactorChanged
        ' Sync view between before and after iamges
        outputImageXView.ZoomFactor = inputImageXView.ZoomFactor
    End Sub
    Private Sub outputImageXView_ZoomFactorChanged(sender As Object, e As ZoomFactorChangedEventArgs) Handles outputImageXView.ZoomFactorChanged
        ' Sync view between before and after iamges
        inputImageXView.ZoomFactor = outputImageXView.ZoomFactor
    End Sub

    Private Sub ResetUI()
        listView.Items.Clear()
        reduceButton.Enabled = False
        inputImageXView.Image = Nothing
        outputImageXView.Image = Nothing
        inputFileNameLabel.Text = "Input FileName:"
        outputFileNameLabel.Text = "Output FileName:"
        Text = TITLE
    End Sub

    Private Sub DisableUIForRun()
        reduceButton.Enabled = False
        stopButton.Visible = True
        menuStrip.Enabled = False
    End Sub

    Private Sub ReenableUIForAnotherRun()
        Text = TITLE
        reduceButton.Enabled = True
        stopButton.Visible = False
        menuStrip.Enabled = True
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles exitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub deleteFileWhenExists(filePath As String)
        If File.Exists(filePath) Then
            Dim attributes As FileAttributes = File.GetAttributes(filePath)
            File.SetAttributes(filePath, attributes And Not FileAttributes.ReadOnly)
            File.Delete(filePath)
        End If
    End Sub

End Class
