/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.Security.Permissions;
using System.Windows.Forms;
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class SlideShowForm : Form
    {
        public SlideShowForm()
        {
            InitializeComponent();
        }

        private Timer slideShowTimer;

        private int imageFileNameIndex;

        private string[] imageFileNames;
        public void SetImageFileNames(string[] filenames)
        {
            imageFileNames = filenames;
        }

        private int[] imagePageNumbers;
        public void SetImagePageNumbers(int[] pageNumbers)
        {
            imagePageNumbers = pageNumbers;
        }

        private bool[] imageIsCameraRaw;
        public void SetImageIsCameraRaw(bool[] isCameraRaw)
        {
            imageIsCameraRaw = isCameraRaw;
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

        private void SlideShowForm_Load(object sender, EventArgs e)
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

            slideShowTimer = new Timer();
            slideShowTimer.Interval = 100;
            slideShowTimer.Tick += new EventHandler(slideShowTimer_Tick);

            //disable context menu
            imageXView1.ContextMenu.MenuItems.Clear();

            slideShowTimer.Start();
        }

        private void slideShowTimer_Tick(object sender, EventArgs e)
        {           
            DisplayImage();
        }

        private void DisplayImage()
        {
            try
            {
                //check if we've reached the end of the images to show
                if (imageFileNameIndex >= imageFileNames.Length)
                {
                    slideShowTimer.Stop();
                    this.DialogResult = DialogResult.OK;
                }

                if (slideShowTimer.Enabled)
                {
                    LoadOptions lo = new LoadOptions();
                    if (imageIsCameraRaw[imageFileNameIndex])
                    {
                        lo.CameraRawEnabled = true;
                    }
                    
                    if (imageXView1.Image != null)
                    {
                        imageXView1.Image.Dispose();
                        imageXView1.Image = null;
                    }
                    imageXView1.Image = ImageX.FromFile(imagXpress1, imageFileNames[imageFileNameIndex], imagePageNumbers[imageFileNameIndex], lo);
                    
                    ImageLabel.Text = String.Format("{0}, Page: {1}, Image {2} of {3}", imageFileNames[imageFileNameIndex],
                        imagePageNumbers[imageFileNameIndex], imageFileNameIndex + 1, imageFileNames.Length);
                    //center label
                    ImageLabel.Left = this.Width / 2 - ImageLabel.Width / 2;
                    ImageLabel.Visible = true;

                    imageFileNameIndex++;
                    slideShowTimer.Interval = 3000;
                }
            }
            catch (ImageXException)
            {
                //error loading image, don't interrupt slide show
                imageFileNameIndex++;
            }
        }

        //must override ProcessCmdKey to capture Left and Right arrow keys being pressed on keyboard
        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                if (imageFileNameIndex > 1)
                {
                    imageFileNameIndex -= 2;

                    DisplayImage();
                }

                return true;
            }
            else if (keyData == Keys.Right)
            {
                DisplayImage();

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SlideShowForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //user wants to end slide show early
            if (e.KeyChar == (char)Keys.Escape)
            {
                slideShowTimer.Stop();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}