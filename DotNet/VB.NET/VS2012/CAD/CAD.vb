'/***************************************************************
'* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
'* This sample code is provided to Accusoft licensees "as is"   *
'* with no restrictions on use or modification. No warranty for *
'* use of this sample code is provided by Accusoft.             *
'****************************************************************/
Public Class CAD

    Private fileType As Accusoft.ImagXpressSdk.CadFileType
    Private fileVersion As Accusoft.ImagXpressSdk.CadVersion
    Private fileLayout As Accusoft.ImagXpressSdk.CadLayout
    Private fileLayer As Accusoft.ImagXpressSdk.CadLayer

    Private layerCount As Int32
    Private layoutCount As Int32

    Private data As Accusoft.ImagXpressSdk.ImageXData
    Private lo As Accusoft.ImagXpressSdk.LoadOptions
    Private commonDir As String
    Private filePath As String
    Private Const strDefaultImageFilter As System.String = "CAD Drawing (*.DWG)|*.dwg|Autodesk Design Web Format (*.DWF)|*.dwf|AutoCAD DXF (*.DXF)|*.dxf|All Files (*.*)|*.*"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
        'imagXpress1.Licensing.SetSolutionName("YourSolutionName")
        'imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345)
        'imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�")

        'Because in this sample the ImageX object is always located in the ImageXView
        'tell the ImageXView component to dispose of the ImageX object when itself is
        'disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
        'Dispose method before the components.Dispose() section.
        imageXView1.AutoImageDispose = True

        lo = New Accusoft.ImagXpressSdk.LoadOptions()

        filePath = System.IO.Path.GetFullPath(Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\..\Common\Images\CadImage.dwg")
        commonDir = System.IO.Path.Combine(Application.StartupPath, "..\..\..\..\..\..\..\..\..\..\Common\Images\")

        If System.IO.Directory.Exists(commonDir) Then
            System.IO.Directory.SetCurrentDirectory(commonDir)
        End If

        loadButton_Click(Me, New EventArgs())
    End Sub

    Private Sub imagXperssToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imagXperssToolStripMenuItem.Click
        imagXpress1.AboutBox()
    End Sub

    Private Sub exitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub loadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadButton.Click
        labelLastErrorDescription.Text = ""
        Try
            LayerGroupBox.Enabled = True
            LayoutGroupBox.Enabled = True

            'Call QueryFile (This must be done first)
            data = Accusoft.ImagXpressSdk.ImageX.QueryFile(imagXpress1, filePath)

            lo.Cad.CadData = data

            'Call QueryCadFormat to obtain details about the CAD file
            data.QueryCadFormat(fileType, fileVersion, layerCount, layoutCount)

            'Setup our display
            layoutBox.Items.Clear()
            layerBox.Items.Clear()
            VersionBox.Text = fileVersion.ToString()
            TypeBox.Text = fileType.ToString()

            CountBox.Text = layoutCount.ToString()

            fileLayout = data.Layout(0)
            HeightBox.Text = fileLayout.Height.ToString()
            WidthBox.Text = fileLayout.Width.ToString()
            NameBox.Text = fileLayout.Name
            UnitBox.Text = fileLayout.Unit.ToString()

            For i As Integer = 0 To layoutCount - 1
                fileLayout = data.Layout(i)
                layoutBox.Items.Add(fileLayout.Name)
            Next

            layoutBox.SelectedIndex = 0

            CountBox2.Text = layerCount.ToString()

            fileLayer = data.Layer(0)

            frozenBox.Text = fileLayer.Frozen.ToString()
            inUseBox.Text = fileLayer.InUse.ToString()
            LayerDBox.Text = fileLayer.LayerDescription
            LayerNameBox.Text = fileLayer.LayerName.ToString()
            LayerNumberBox.Text = fileLayer.LayerNumber.ToString()
            LayerOnBox.Text = fileLayer.LayerOn.ToString()
            LockBox.Text = fileLayer.Locked.ToString()
            PlotBox.Text = fileLayer.Plottable.ToString()

            For i As Integer = 0 To layerCount - 1
                fileLayer = data.Layer(i)
                layerBox.Items.Add(fileLayer.LayerName)
            Next
            layerBox.SelectedIndex = 0
            'If CadFileOpen has been previously called, it must be closed explicitly
            If imageXView1.Image IsNot Nothing Then
                imageXView1.Image.CadFileClose()
            End If
            'Load the CAD file
            imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.CadFileOpen(imagXpress1, filePath, lo)
        Catch ex As Exception
            labelLastErrorDescription.Text = ex.Message
        End Try
    End Sub

    Private Sub OffRadioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffRadioButton.Click
        labelLastErrorDescription.Text = ""
        Try
            'Turn the current layer off
            lo.Cad.CadData.Layer(layerBox.SelectedIndex).LayerOn = False

            'Update our display
            LayerOnBox.Text = lo.Cad.CadData.Layer(layerBox.SelectedIndex).LayerOn.ToString()

            'Update the view
            imageXView1.Image.CadFileView(lo)
        Catch ex As Exception
            labelLastErrorDescription.Text = ex.Message
        End Try
    End Sub

    Private Sub OnRadioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnRadioButton.Click
        labelLastErrorDescription.Text = ""
        Try
            'Turn the current layer on
            lo.Cad.CadData.Layer(layerBox.SelectedIndex).LayerOn = True

            'Update the display
            LayerOnBox.Text = lo.Cad.CadData.Layer(layerBox.SelectedIndex).LayerOn.ToString()

            'Update the view
            imageXView1.Image.CadFileView(lo)
        Catch ex As Exception
            labelLastErrorDescription.Text = ex.Message
        End Try
    End Sub

    Private Sub openToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openToolStripMenuItem.Click
        'Select a file to open and then load it into ImagXpress
        Dim dlg As New OpenFileDialog()

        dlg.InitialDirectory = commonDir
        dlg.Filter = strDefaultImageFilter
        dlg.ShowDialog()

        filePath = dlg.FileName

        commonDir = filePath

        loadButton_Click(sender, e)
    End Sub

    Private Sub layoutBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles layoutBox.SelectedIndexChanged
        labelLastErrorDescription.Text = ""
        Try
            'Get the currently selected layout
            fileLayout = data.Layout(layoutBox.SelectedIndex)

            'Update the view with the new details
            HeightBox.Text = fileLayout.Height.ToString()
            WidthBox.Text = fileLayout.Width.ToString()
            NameBox.Text = fileLayout.Name
            UnitBox.Text = fileLayout.Unit.ToString()

            'Prepare to display the newly selected layout
            lo.Cad.LayoutToRender = layoutBox.SelectedIndex

            'Display the layout by updating the view
            If imageXView1.Image IsNot Nothing Then
                imageXView1.Image.CadFileView(lo)
            End If
        Catch ex As Exception
            labelLastErrorDescription.Text = ex.Message
        End Try
    End Sub

    Private Sub layerBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles layerBox.SelectedIndexChanged
        'Get the newly selected layer and update the display accordingly
        fileLayer = data.Layer(layerBox.SelectedIndex)

        frozenBox.Text = fileLayer.Frozen.ToString()
        inUseBox.Text = fileLayer.InUse.ToString()
        LayerDBox.Text = fileLayer.LayerDescription
        LayerNameBox.Text = fileLayer.LayerName.ToString()
        LayerNumberBox.Text = fileLayer.LayerNumber.ToString()
        LayerOnBox.Text = fileLayer.LayerOn.ToString()
        LockBox.Text = fileLayer.Locked.ToString()
        PlotBox.Text = fileLayer.Plottable.ToString()

        If fileLayer.LayerOn = True Then
            OnRadioButton.Checked = True
        Else
            OffRadioButton.Checked = True
        End If
    End Sub
End Class
