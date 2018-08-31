/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.Windows.Forms;
using System.Drawing;
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public enum ProcessorParameterlessAction
    {
        AutoBinarize = 0,
        AutoColorBalance = 1,
        AutoContrast = 2,
        AutoLevel = 3,
        AutoLightness = 4,
        Blur = 5,
        Despeckle = 6,
        Diffuse = 7,
        Dilate = 8,
        DocumentBorderCrop = 9,
        Emboss = 10,
        Equalize = 11,
        Erode = 12,
        Flip = 13,
        Median = 14,
        Mirror = 15,
        Negate = 16,
        Outline = 17,
        SmoothZoom = 18
    }

    public partial class ProcessingForm : Form
    {
        public ProcessingForm()
        {
            InitializeComponent();
        }

        private AutoResizeType currentAutoResizeType = AutoResizeType.BestFit;
        public const int BottomOfFormSpacer = 38;
        public const int HeightSpacer = 15;

        private ProcessorParameterlessAction processorParameterlessAction;
        public void SetProcessorParameterlessAction(ProcessorParameterlessAction action)
        {
            processorParameterlessAction = action;
        }

        public void SetInputImage(ImageX inputImage)
        {
            imageXView1.Image = inputImage;
        }

        public ImageX OutputImage
        {
            get
            {
                return imageXView2.Image;
            }
        }

        protected Bitmap outputBitmap;
        public Bitmap OutputBitmap
        {
            get
            {
                return outputBitmap;
            }
            set
            {
                outputBitmap = value;
            }
        }

        #if LICENSED
            private Licensing license;
            public Licensing License
            {
                set
                {
                    license = value;
                }
            }
        #endif

        protected void UpdateOutputImage(ImageX outputImage)
        {
            if (imageXView2.Image != null)
            {
                imageXView2.Image.Dispose();
                imageXView2.Image = null;
            }
            imageXView2.Image = outputImage;
        }

        private static void DisposeOfProcessorImage(ImageX procImage)
        {
            if (procImage != null)
            {
                procImage.Dispose();
                procImage = null;
            }
        }

        protected virtual bool PerformProcessingAction()
        {
            Processor proc = null;
            try
            {
                proc = new Processor(imagXpress1, imageXView1.Image.Copy());
                Helper.TransformIfGrayscale(proc.Image);

                Point currentScrollPosition;
                if (imageXView2.Image == null)
                {
                    currentScrollPosition = imageXView1.ScrollPosition;
                }
                else
                {
                    currentScrollPosition = imageXView2.ScrollPosition;
                }

                switch (processorParameterlessAction)
                {
                    case ProcessorParameterlessAction.AutoBinarize:
                        {
                            proc.AutoBinarize2();
                            break;
                        }
                    case ProcessorParameterlessAction.AutoColorBalance:
                        {
                            proc.AutoColorBalance();
                            break;
                        }
                    case ProcessorParameterlessAction.AutoContrast:
                        {
                            proc.AutoContrast();
                            break;
                        }
                    case ProcessorParameterlessAction.AutoLevel:
                        {
                            proc.AutoLevel();
                            break;
                        }
                    case ProcessorParameterlessAction.AutoLightness:
                        {
                            proc.AutoLightness();
                            break;
                        }
                    case ProcessorParameterlessAction.Blur:
                        {
                            proc.Blur();
                            break;
                        }
                    case ProcessorParameterlessAction.Despeckle:
                        {
                            proc.Despeckle();
                            break;
                        }
                    case ProcessorParameterlessAction.Diffuse:
                        {
                            proc.Diffuse();
                            break;
                        }
                    case ProcessorParameterlessAction.Dilate:
                        {
                            proc.Dilate();
                            break;
                        }
                    case ProcessorParameterlessAction.DocumentBorderCrop:
                        {
                            proc.DocumentBorderCrop();
                            break;
                        }
                    case ProcessorParameterlessAction.Emboss:
                        {
                            proc.Emboss();
                            break;
                        }
                    case ProcessorParameterlessAction.Equalize:
                        {
                            proc.Equalize();
                            break;
                        }
                    case ProcessorParameterlessAction.Erode:
                        {
                            proc.Erode();
                            break;
                        }
                    case ProcessorParameterlessAction.Flip:
                        {
                            proc.Flip();
                            break;
                        }
                    case ProcessorParameterlessAction.Median:
                        {
                            proc.Median();
                            break;
                        }
                    case ProcessorParameterlessAction.Mirror:
                        {
                            proc.Mirror();
                            break;
                        }
                    case ProcessorParameterlessAction.Negate:
                        {
                            proc.Negate();
                            break;
                        }
                    case ProcessorParameterlessAction.Outline:
                        {
                            proc.Outline();
                            break;
                        }
                    case ProcessorParameterlessAction.SmoothZoom:
                        {
                            proc.DocumentZoomSmooth();
                            break;
                        }
                }

                UpdateOutputImage(proc.Image.Copy());
                
                imageXView2.ScrollPosition = currentScrollPosition;

                return true;
            }
            catch (ProcessorException ex)
            {
                MessageBox.Show(ex.Message, Constants.processingErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (ImageXException ex)
            {
                MessageBox.Show(ex.Message, Constants.processingErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (proc != null)
                {
                    if (proc.Image != null)
                    {
                        proc.Image.Dispose();
                        proc.Image = null;
                    }
                    proc.Dispose();
                    proc = null;
                }
            }
        }

        private void OKButton_Click(object sender, System.EventArgs e)
        {
            if (PerformProcessingAction())
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void CancelProcessingButton_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void PreviewButton_Click(object sender, System.EventArgs e)
        {
            PerformProcessingAction();
        }

        private void AddToolMenu(ImageXView imageXView)
        {
            imageXView.ContextMenu.MenuItems.Add(Constants.toolString);
            imageXView.ContextMenu.MenuItems[imageXView.ContextMenu.MenuItems.Count - 1].MenuItems.Add(Constants.pointerString);
            imageXView.ContextMenu.MenuItems[imageXView.ContextMenu.MenuItems.Count - 1].MenuItems.Add(Constants.zoomRectangleString);

            //check pointer tool menu item by default
            imageXView.ContextMenu.MenuItems[imageXView.ContextMenu.MenuItems.Count - 1].MenuItems[0].Checked = true;

            imageXView.ContextMenu.MenuItems[imageXView.ContextMenu.MenuItems.Count - 1].MenuItems[0].Click += new EventHandler(ContextMenuPointerClickEventHandler);
            imageXView.ContextMenu.MenuItems[imageXView.ContextMenu.MenuItems.Count - 1].MenuItems[1].Click += new EventHandler(ContextMenuZoomRectClickEventHandler);
        }

        private void ProcessingForm_Load(object sender, System.EventArgs e)
        {


            //**The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime**
            //imagXpress1.Licensing.SetSolutionName("YourSolutionName");
            //imagXpress1.Licensing.SetSolutionKey(12345, 12345, 12345, 12345);
            //imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation…");


#if LICENSED
            if (license.Unlocked)
            {
                imagXpress1.Licensing.SetSolutionName(license.SolutionName);
                if (System.IntPtr.Size == 8)
                {
                    imagXpress1.Licensing.SetSolutionKey(license.Solution64Key1, license.Solution64Key2, license.Solution64Key3, license.Solution64Key4);
                }
                else
                {
                    imagXpress1.Licensing.SetSolutionKey(license.Solution32Key1, license.Solution32Key2, license.Solution32Key3, license.Solution32Key4);
                }
                imagXpress1.Licensing.SetOEMLicenseKey(license.OEMLicenseKeyImagXpress);
            }
#endif

            imageXView1.MouseWheelSetAttribute(MouseWheelAttribute.ZoomPercent, 0);
            imageXView2.MouseWheelSetAttribute(MouseWheelAttribute.ZoomPercent, 0);

            AddToolMenu(imageXView1);
            AddToolMenu(imageXView2);
        }

        private void UpdatedCheckedItemsOfToolMenu(bool isChecked)
        {
            imageXView1.ContextMenu.MenuItems[imageXView1.ContextMenu.MenuItems.Count - 1].MenuItems[0].Checked = isChecked;
            imageXView2.ContextMenu.MenuItems[imageXView2.ContextMenu.MenuItems.Count - 1].MenuItems[0].Checked = isChecked;

            imageXView1.ContextMenu.MenuItems[imageXView1.ContextMenu.MenuItems.Count - 1].MenuItems[1].Checked = !isChecked;
            imageXView2.ContextMenu.MenuItems[imageXView2.ContextMenu.MenuItems.Count - 1].MenuItems[1].Checked = !isChecked;
        }

        private void ContextMenuPointerClickEventHandler(object sender, System.EventArgs e)
        {
            imageXView1.ToolSet(Tool.None, MouseButtons.Left, Keys.None);
            imageXView2.ToolSet(Tool.None, MouseButtons.Left, Keys.None);

            UpdatedCheckedItemsOfToolMenu(true);
        }

        private void ContextMenuZoomRectClickEventHandler(object sender, System.EventArgs e)
        {
            imageXView1.ToolSet(Tool.ZoomRect, MouseButtons.Left, Keys.None);
            imageXView2.ToolSet(Tool.ZoomRect, MouseButtons.Left, Keys.None);

            UpdatedCheckedItemsOfToolMenu(false);
        }

        private bool AreImagesOfTheSameSize()
        {
            if (imageXView1.Image != null && imageXView2.Image != null)
            {
                if (imageXView1.Image.Width == imageXView2.Image.Width && imageXView1.Image.Height == imageXView2.Image.Height)
                {
                    return true;
                }
            }

            return false;
        }

        private void imageXView1_ScrollEvent(object sender, Accusoft.ImagXpressSdk.ScrollEventArgs e)
        {
            if (AreImagesOfTheSameSize())
            {
                imageXView2.ScrollPosition = e.NewValue;
            }
        }

        private void imageXView2_ScrollEvent(object sender, Accusoft.ImagXpressSdk.ScrollEventArgs e)
        {
            if (AreImagesOfTheSameSize())
            {
                imageXView1.ScrollPosition = e.NewValue;
            }
        }

        private void imageXView1_ZoomFactorChanged(object sender, ZoomFactorChangedEventArgs e)
        {
            if (AreImagesOfTheSameSize())
            {
                imageXView2.AutoResize = AutoResizeType.CropImage;
                imageXView2.ZoomFactor = imageXView1.ZoomFactor;
                imageXView2.ScrollPosition = imageXView1.ScrollPosition;

                currentAutoResizeType = imageXView1.AutoResize;
            }
        }

        private void imageXView2_ZoomFactorChanged(object sender, ZoomFactorChangedEventArgs e)
        {
            if (AreImagesOfTheSameSize())
            {
                imageXView1.AutoResize = AutoResizeType.CropImage;
                imageXView1.ZoomFactor = imageXView2.ZoomFactor;
                imageXView1.ScrollPosition = imageXView2.ScrollPosition;
            }
        }

        private void ProcessingForm_Resize(object sender, EventArgs e)
        {
            //if form is resized and BestFit was set previously then set it back again
            if (currentAutoResizeType == AutoResizeType.BestFit)
            {
                imageXView1.AutoResize = imageXView2.AutoResize = AutoResizeType.BestFit;
            }
        }
    }
}