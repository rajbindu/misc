/***************************************************************
* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Accusoft.ImagXpressSdk.CadFileType fileType;
        private Accusoft.ImagXpressSdk.CadVersion fileVersion;
        private Accusoft.ImagXpressSdk.CadLayout fileLayout;
        private Accusoft.ImagXpressSdk.CadLayer fileLayer;
        
        private int layerCount, layoutCount;

        private Accusoft.ImagXpressSdk.ImageXData data;

        private Accusoft.ImagXpressSdk.LoadOptions lo;

        private string commonDir, filePath;
        private const System.String strDefaultImageFilter = "CAD Drawing (*.DWG)|*.dwg|Autodesk Design Web Format (*.DWF)|*.dwf|AutoCAD DXF (*.DXF)|*.dxf|All Files (*.*)|*.*";

        private void MainForm_Load(object sender, EventArgs e)
        {
            //***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
            //imagXpress1.Licensing.SetSolutionName("YourSolutionName");
            //imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345);
            //imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�");

            // Because in this sample the ImageX object is always located in the ImageXView
            // tell the ImageXView component to dispose of the ImageX object when itself is
            // disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
            // Dispose method before the components.Dispose() section.
            imageXView1.AutoImageDispose = true;

            lo = new Accusoft.ImagXpressSdk.LoadOptions();

            filePath = Path.GetFullPath(Application.StartupPath + "..\\..\\..\\..\\..\\..\\..\\..\\..\\..\\..\\Common\\Images\\CadImage.dwg");
            commonDir = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\");

            if (System.IO.Directory.Exists(commonDir))
                System.IO.Directory.SetCurrentDirectory(commonDir);

            loadButton_Click(this, new EventArgs());
        }

        private void imagXperssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagXpress1.AboutBox();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            labelLastErrorDescription.Text = "";
            try
            {
                LayerGroupBox.Enabled = true;
                LayoutGroupBox.Enabled = true;

                //Call QueryFile (This must be done first)
                data = Accusoft.ImagXpressSdk.ImageX.QueryFile(imagXpress1, filePath);

                lo.Cad.CadData = data;

                //Call QueryCadFormat to obtain details about the CAD file
                data.QueryCadFormat(out fileType, out fileVersion, out layerCount, out layoutCount);

                //If CadFileOpen has been previously called, it must be closed explicitly
                if (imageXView1.Image != null)
                {
                    imageXView1.Image.CadFileClose();
                    imageXView1.Image.Dispose();
                    imageXView1.Image = null;
                }

                //Setup our display
                layoutBox.Items.Clear();
                layerBox.Items.Clear();
                VersionBox.Text = fileVersion.ToString();
                TypeBox.Text = fileType.ToString();

                CountBox.Text = layoutCount.ToString();

                fileLayout = data.Layout(0);
                HeightBox.Text = fileLayout.Height.ToString();
                WidthBox.Text = fileLayout.Width.ToString();
                NameBox.Text = fileLayout.Name;
                UnitBox.Text = fileLayout.Unit.ToString();

                for (int i = 0; i < layoutCount; i++)
                {
                    fileLayout = data.Layout(i);
                    layoutBox.Items.Add(fileLayout.Name);
                }

                layoutBox.SelectedIndex = 0;

                CountBox2.Text = layerCount.ToString();
                
                fileLayer = data.Layer(0);

                frozenBox.Text = fileLayer.Frozen.ToString();
                inUseBox.Text = fileLayer.InUse.ToString();
                LayerDBox.Text = fileLayer.LayerDescription;
                LayerNameBox.Text = fileLayer.LayerName.ToString();
                LayerNumberBox.Text = fileLayer.LayerNumber.ToString();
                LayerOnBox.Text = fileLayer.LayerOn.ToString();
                LockBox.Text = fileLayer.Locked.ToString();
                PlotBox.Text = fileLayer.Plottable.ToString();

                for (int i = 0; i < layerCount; i++)
                {
                    fileLayer = data.Layer(i);
                    layerBox.Items.Add(fileLayer.LayerName);
                }

                layerBox.SelectedIndex = 0;

                //Load the CAD file
                imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.CadFileOpen(imagXpress1, filePath, lo);
            }
            catch (Exception ex)
            {
                labelLastErrorDescription.Text = ex.Message;
            }
        }

        private void OffRadioButton_Click(object sender, EventArgs e)
        {
            labelLastErrorDescription.Text = "";
            try
            {
                //Turn the current layer off
                lo.Cad.CadData.Layer(layerBox.SelectedIndex).LayerOn = false;

                //Update our display
                LayerOnBox.Text = lo.Cad.CadData.Layer(layerBox.SelectedIndex).LayerOn.ToString();

                //Update the view
                imageXView1.Image.CadFileView(lo);
            }
            catch(Exception ex)
            {
                labelLastErrorDescription.Text = ex.Message;
            }
        }

        private void OnRadioButton_Click(object sender, EventArgs e)
        {
            labelLastErrorDescription.Text = "";
            try
            {
                //Turn the current layer on
                lo.Cad.CadData.Layer(layerBox.SelectedIndex).LayerOn = true;

                //Update the display
                LayerOnBox.Text = lo.Cad.CadData.Layer(layerBox.SelectedIndex).LayerOn.ToString();

                //Update the view
                imageXView1.Image.CadFileView(lo);
            }
            catch (Exception ex)
            {
                labelLastErrorDescription.Text = ex.Message;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Select a file to open and then load it into ImagXpress
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = commonDir;
            dlg.Filter = strDefaultImageFilter;
            dlg.ShowDialog();

            filePath = dlg.FileName;

            commonDir = filePath;

            loadButton_Click(sender, e);
        }

        private void layoutBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelLastErrorDescription.Text = "";
            try
            {
                //Get the currently selected layout
                fileLayout = data.Layout(layoutBox.SelectedIndex);

                //Update the view with the new details
                HeightBox.Text = fileLayout.Height.ToString();
                WidthBox.Text = fileLayout.Width.ToString();
                NameBox.Text = fileLayout.Name;
                UnitBox.Text = fileLayout.Unit.ToString();

                //Prepare to display the newly selected layout
                lo.Cad.LayoutToRender = layoutBox.SelectedIndex;

                //Display the layout by updating the view
                if(imageXView1.Image != null)
                    imageXView1.Image.CadFileView(lo);
            }
            catch (Exception ex)
            {
                labelLastErrorDescription.Text = ex.Message;
            }
        }

        private void layerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the newly selected layer and update the display accordingly
            fileLayer = data.Layer(layerBox.SelectedIndex);

            frozenBox.Text = fileLayer.Frozen.ToString();
            inUseBox.Text = fileLayer.InUse.ToString();
            LayerDBox.Text = fileLayer.LayerDescription;
            LayerNameBox.Text = fileLayer.LayerName.ToString();
            LayerNumberBox.Text = fileLayer.LayerNumber.ToString();
            LayerOnBox.Text = fileLayer.LayerOn.ToString();
            LockBox.Text = fileLayer.Locked.ToString();
            PlotBox.Text = fileLayer.Plottable.ToString();

            if (fileLayer.LayerOn == true)
            {
                OnRadioButton.Checked = true;
            }
            else
            {
                OffRadioButton.Checked = true;
            }
        }
    }
}