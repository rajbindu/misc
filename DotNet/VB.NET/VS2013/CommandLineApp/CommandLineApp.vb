'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Imports Accusoft.ImagXpressSdk

Module CommandLineApp

    Private imagX1 As Accusoft.ImagXpressSdk.ImageX
    Private imagXpress1 As Accusoft.ImagXpressSdk.ImagXpress
    Private imagProcessor As Accusoft.ImagXpressSdk.Processor
    Private sInputFileName As String
    Private sOutputFileName As String
    Private soSaveOptions As Accusoft.ImagXpressSdk.SaveOptions

    Sub Main()

        UnlockIXandProcessImg()

    End Sub

    Sub UnlockIXandProcessImg()

        Try

            Dim strCurrentDir As String = System.IO.Directory.GetCurrentDirectory()

            imagXpress1 = New Accusoft.ImagXpressSdk.ImagXpress()

            '***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
            'imagXpress1.Licensing.SetSolutionName("YourSolutionName")
            'imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345)
            'imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�")
            'System.Console.WriteLine("ImagXpress successfully licensed.")

            imagProcessor = New Accusoft.ImagXpressSdk.Processor(imagXpress1)
            soSaveOptions = New Accusoft.ImagXpressSdk.SaveOptions()

            soSaveOptions.Format = ImageXFormat.Tiff
            soSaveOptions.Tiff.Compression = Compression.Group4

            sInputFileName = System.IO.Path.Combine(strCurrentDir, "..\..\..\..\..\..\..\..\..\..\Common\Images\Benefits.tif")
            sOutputFileName = strCurrentDir + "\BenefitsRotated.tif"

            imagX1 = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, sInputFileName)
            imagProcessor.Image = imagX1

            imagProcessor.Rotate(180)

            imagX1 = imagProcessor.Image
            imagX1.Save(sOutputFileName, soSaveOptions)
            Dispose()


            System.Console.WriteLine("Rotated TIFF saved to file " + sOutputFileName)
            System.Console.ReadLine()


        Catch ex As Accusoft.ImagXpressSdk.ImagXpressException

            Dispose()
            System.Console.WriteLine(ex.Message)
            System.Console.WriteLine(ex.Source)
            System.Console.ReadLine()

        Catch ex As System.Exception

            Dispose()
            System.Console.WriteLine(ex.Message)
            System.Console.WriteLine(ex.Source)
            System.Console.ReadLine()

        End Try


    End Sub

    'Don't forget to Dispose ImagXpress
    Sub Dispose()

        If Not (imagXpress1 Is Nothing) Then

            imagXpress1.Dispose()
            imagXpress1 = Nothing

        End If

        If Not (imagProcessor Is Nothing) Then

            imagProcessor.Dispose()
            imagProcessor = Nothing

        End If

        If Not (imagX1 Is Nothing) Then

            imagX1.Dispose()
            imagX1 = Nothing

        End If

    End Sub

End Module
