/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class ScanForm : Form
    {
        public ScanForm()
        {
            InitializeComponent();
        }

        protected List<ImageX> imagesScanned = new List<ImageX>();
        protected int imagesScannedIndex;
        protected int imagesScannedCount;

        private string savedFileName;
        public string SavedFileName
        {
            get
            {
                return savedFileName;
            }
        }

        private string saveFileInitialDirectory;
        public string SaveFileInitialDirectory
        {
            get
            {
                return saveFileInitialDirectory;
            }
            set
            {
                saveFileInitialDirectory = value;
            }
        }

        private Helper helperInstance;
        public Helper HelperInstance
        {
            get
            {
                return helperInstance;
            }
            set
            {
                helperInstance = value;
            }
        }

        #if LICENSED
            protected Licensing license;
            public Licensing License
            {
                set
                {
                    license = value;
                }
            }
        #endif

        #region Event Handlers

        private void UpdateImage()
        {
            imageXView1.Image = imagesScanned[imagesScannedIndex - 1];
        }

        protected void UpdatePageUI()
        {
            UpdateImage();

            //single-page
            if (imagesScannedCount == 1)
            {
                PreviousButton.Enabled = false;
                NextButton.Enabled = false;
            }
            //multi-page
            else if (imagesScannedCount > 1)
            {
                if (imagesScannedIndex == 1)
                {
                    //on first page
                    PreviousButton.Enabled = false;
                    NextButton.Enabled = true;
                }
                else if (imagesScannedIndex == imagesScannedCount)
                {
                    //on last page
                    PreviousButton.Enabled = true;
                    NextButton.Enabled = false;
                }
                else
                {
                    //not on first or last page, in the middle
                    PreviousButton.Enabled = true;
                    NextButton.Enabled = true;
                }
            }

            PageTextBox.Text = imagesScannedIndex.ToString();
            PageCountLabel.Text = String.Format("of {0}", imagesScannedCount);
        }

        private static bool IsMultiPageEnabledForSaveOptions(Accusoft.ImagXpressSdk.SaveOptions so)
        {
            if (so.Format == ImageXFormat.Dcx && so.Dcx.MultiPage)
            {
                return true;
            }
            else if (so.Format == ImageXFormat.Tiff && so.Tiff.MultiPage)
            {
                return true;
            }
            else if (so.Format == ImageXFormat.Ico && so.Icon.MultiPage)
            {
                return true;
            }

            return false;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Constants.saveScannedImageString, Constants.saveImageString, 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                try
                {
                    //helperInstance.DisposeOfImageX();
                    helperInstance.Image = imageXView1.Image;
                    
                    //if we scanned multiple images we need to make sure it's available to save Multi-Page in the Save Options
                    helperInstance.ScannedImagePageCount = imagesScannedCount;
                    helperInstance.SaveFileInitialDirectory = saveFileInitialDirectory;

                    if (helperInstance.SaveWithOptions() == DialogResult.OK)
                    {
                        //if image is multi-page and user selected the multi-page save option
                        if (imagesScannedCount > 1 && IsMultiPageEnabledForSaveOptions(helperInstance.SaveOptionsChosen))
                        {
                            foreach (ImageX img in imagesScanned)
                            {
                                using (ImageXView imageView = new ImageXView(imagXpress1))
                                {
                                    imageView.Image = img;
                                    if (helperInstance.IsWatemarkNeeded())
                                    {
                                        Helper.WatermarkImage(imageView, img.BitsPerPixel);
                                    }
                                }
                                img.Save(helperInstance.SavedFileName, helperInstance.SaveOptionsChosen);
                            }
                        }
                        else
                        {
                            //single-page or user didn't choose the multi-page save option so use current image, 
                            //brand image with watermark and save
                            if (helperInstance.IsWatemarkNeeded())
                            {
                                Helper.WatermarkImage(imageXView1, imageXView1.Image.BitsPerPixel);
                            }
                            imageXView1.Image.Save(helperInstance.SavedFileName, helperInstance.SaveOptionsChosen);
                        }

                        savedFileName = helperInstance.SavedFileName;

                        this.DialogResult = DialogResult.OK;
                    }                   
                }
                catch (ImageXException ex)
                {
                    MessageBox.Show(ex.Message, Constants.saveErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void CancelScanButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        
        #endregion        
       
        private void NextButton_Click(object sender, EventArgs e)
        {
            imagesScannedIndex++;
            PreviousButton.Enabled = true;

            UpdatePageUI();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            imagesScannedIndex--;
            NextButton.Enabled = true;

            UpdatePageUI();
        }

        private void ScanForm_Load(object sender, EventArgs e)
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

        }
    }
}