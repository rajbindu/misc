'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Accusoft.ImagXpressSdk
Namespace Threading

    Public Class ProcessorThread
        Private myReferenceToMyLabel As System.Windows.Forms.Label
        Private myReferenceToMyViewer As Accusoft.ImagXpressSdk.ImageXView
        Private myImageFileName As System.String
        Private myResize As System.Int32
        Private myImage As Accusoft.ImagXpressSdk.ImageX
        Private myProcessor As Accusoft.ImagXpressSdk.Processor
        Private ImagXpress1 As Accusoft.ImagXpressSdk.ImagXpress


        Shared Sub AccusoftError(ByVal e As Accusoft.ImagXpressSdk.ImagXpressException)
            MessageBox.Show(Nothing, e.Message, "ImageXPress Error " + e.Number.ToString)
        End Sub

        Public Sub New(ByVal daImageFileName As System.String, ByVal daViewer As Accusoft.ImagXpressSdk.ImageXView, ByVal daLabel As System.Windows.Forms.Label, ByVal daSize As System.Int32, ByVal ImagXpress1 As ImagXpress)
            Me.myReferenceToMyViewer = daViewer
            Me.myReferenceToMyLabel = daLabel
            Me.myImageFileName = CType(daImageFileName.Clone, String)
            Me.myResize = daSize
            Me.ImagXpress1 = ImagXpress1
        End Sub

        Private Delegate Sub SafeContextImageChanger(ByVal newImage As Accusoft.ImagXpressSdk.ImageX)

        Private Delegate Sub SafeContextLabelChanger(ByVal newText As String)

        Private Delegate Sub SafeContextZoomChanger(ByVal newZoomFitType As Accusoft.ImagXpressSdk.ZoomToFitType)

        Private Sub RealZoomToFitChangerInTheSafeContext(ByVal newZoomFitType As Accusoft.ImagXpressSdk.ZoomToFitType)
            myReferenceToMyViewer.ZoomToFit(newZoomFitType)
        End Sub

        Private Sub RealImageChangerInTheSafeContext(ByVal newImage As Accusoft.ImagXpressSdk.ImageX)
            Dim oldImage As Accusoft.ImagXpressSdk.ImageX = myReferenceToMyViewer.Image
            myReferenceToMyViewer.Image = newImage
            If Not (oldImage Is Nothing) Then
                oldImage.Dispose()
                oldImage = Nothing
            End If
            GC.Collect()
            System.Threading.Thread.Sleep(25)
        End Sub

        Private Sub RealLabelChangerInTheSafeContext(ByVal newText As String)
            myReferenceToMyLabel.Text = newText
        End Sub

        Private Sub ChangeLabelText(ByVal newText As String)
            Dim theArgs As Object() = {newText}
            myReferenceToMyLabel.Invoke(New SafeContextLabelChanger(AddressOf RealLabelChangerInTheSafeContext), theArgs)
        End Sub

        Private Sub ChangeImage(ByVal newImage As Accusoft.ImagXpressSdk.ImageX)
            Dim theArgs As Object() = {newImage.Copy}
            myReferenceToMyViewer.Invoke(New SafeContextImageChanger(AddressOf RealImageChangerInTheSafeContext), theArgs)
        End Sub

        Private Sub ChangeZoomToFitType(ByVal newZoomFitType As Accusoft.ImagXpressSdk.ZoomToFitType)
            Dim theArgs As Object() = {newZoomFitType}
            myReferenceToMyViewer.Invoke(New SafeContextZoomChanger(AddressOf RealZoomToFitChangerInTheSafeContext), theArgs)
        End Sub

        Public Sub Process()
            Dim imageOpened As Boolean = False
            Dim TryCount As Integer = 0
            While (Not imageOpened) AndAlso (TryCount < 25)
                Try
                    myImage = Accusoft.ImagXpressSdk.ImageX.FromFile(ImagXpress1, myImageFileName)
                    imageOpened = True
                Catch ex As ImagXpressException
                    ChangeLabelText("Error opening image - " + ex.Number.ToString + ". Retrying...")
                End Try
                System.Math.Min(System.Threading.Interlocked.Increment(TryCount), TryCount - 1)
            End While
            If TryCount >= 25 Then
                Throw New Exception("Unable to open the image for processing.")
            End If
            System.Threading.Thread.Sleep(10)
            Try
                myProcessor = New Accusoft.ImagXpressSdk.Processor(ImagXpress1, myImage)
            Catch ex As ImagXpressException
                AccusoftError(ex)
            End Try
            System.Threading.Thread.Sleep(10)
            Try
                ChangeImage(myImage)
                ChangeZoomToFitType(Accusoft.ImagXpressSdk.ZoomToFitType.FitBest)
            Catch ex As ImagXpressException
                AccusoftError(ex)
            End Try
            System.Threading.Thread.Sleep(10)
            ChangeLabelText("Processing...")
            System.Threading.Thread.Sleep(10)
            ChangeLabelText("Resizing...")
            Try
                myProcessor.Resize(New System.Drawing.Size(myImage.ImageXData.Width * (myResize), myImage.ImageXData.Height * myResize), Accusoft.ImagXpressSdk.ResizeType.Quality)
            Catch ex As ImagXpressException
                AccusoftError(ex)
            End Try
            System.Threading.Thread.Sleep(10)
            Try
                ChangeImage(myImage)
            Catch ex As ImagXpressException
                AccusoftError(ex)
            End Try
            System.Threading.Thread.Sleep(10)
            ChangeLabelText("Blurring...")
            Try
                myProcessor.Blur()
            Catch ex As ImagXpressException
                AccusoftError(ex)
            End Try
            System.Threading.Thread.Sleep(10)
            Try
                ChangeImage(myImage)
            Catch ex As ImagXpressException
                AccusoftError(ex)
            End Try
            System.Threading.Thread.Sleep(10)
            ChangeLabelText("Negating...")
            Try
                myProcessor.Negate()
            Catch ex As ImagXpressException
                AccusoftError(ex)
            End Try
            System.Threading.Thread.Sleep(10)
            Try
                ChangeImage(myImage)
            Catch ex As ImagXpressException
                AccusoftError(ex)
            End Try
            System.Threading.Thread.Sleep(10)
            ChangeLabelText("Zooming...")
            Try
                ChangeZoomToFitType(Accusoft.ImagXpressSdk.ZoomToFitType.FitWidth)
            Catch ex As ImagXpressException
                AccusoftError(ex)
            End Try
            System.Threading.Thread.Sleep(10)
            Try
                ChangeImage(myImage)
                ChangeZoomToFitType(Accusoft.ImagXpressSdk.ZoomToFitType.FitBest)
            Catch ex As ImagXpressException
                AccusoftError(ex)
            End Try
            System.Threading.Thread.Sleep(10)
            ChangeLabelText("(Un)Negating...")
            Try
                myProcessor.Negate()
            Catch ex As ImagXpressException
                AccusoftError(ex)
            End Try
            System.Threading.Thread.Sleep(10)
            Try
                ChangeImage(myImage)
            Catch ex As ImagXpressException
                AccusoftError(ex)
            End Try
            System.Threading.Thread.Sleep(10)
            ChangeLabelText("Processed.")
            System.Threading.Thread.Sleep(10)
            myProcessor.Dispose()
            myProcessor = Nothing
            myImage.Dispose()
            myImage = Nothing
            GC.Collect()
            System.Threading.Thread.Sleep(100)
        End Sub
    End Class
End Namespace

