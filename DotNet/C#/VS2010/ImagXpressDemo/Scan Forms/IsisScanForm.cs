/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using Accusoft.ImagXpressSdk;
using Accusoft.ISISXpressSdk;

namespace ImagXpressDemo
{
    public partial class IsisScanForm : ScanForm
    {
        private IsisXpress isisXpressInstance;
        public IsisXpress IsisXpressInstance
        {
            get
            {
                return isisXpressInstance;
            }
            set
            {
                isisXpressInstance = value;
            }
        }

        public IsisScanForm()
        {
            InitializeComponent();
        }

        private void SelectSourceButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                AcquireButton.Enabled = false;

                isisXpressInstance.Scanner.Select(this.Handle);

                AcquireButton.Enabled = true;
            }
            catch (CancelException ex)
            {
                StatusBarLabel.Text = ex.Message;
            }
            catch (IsisDriverException ex)
            {
                StatusBarLabel.Text = ex.Message;
            }
        }

        private void AcquireButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                isisXpressInstance.Output.CreateFiles = false;
                isisXpressInstance.Output.CreateDib = true;

                isisXpressInstance.Scanner.ScanSingle();

                if (imageXView1.Image != null)
                {
                    AcceptImageButton.Enabled = PageTextBox.Enabled = true;
                }
            }
            catch (IsisDriverException ex)
            {
                StatusBarLabel.Text = ex.Message;
            }
        }

        private void IsisScanForm_Load(object sender, System.EventArgs e)
        {


            //**The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime**
            //isisXpressInstance.Licensing.SetSolutionName("YourSolutionName");
            //isisXpressInstance.Licensing.SetSolutionKey(12345, 12345, 12345, 12345);
            //isisXpressInstance.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation…");


#if LICENSED
            if (license.Unlocked)
            {
                isisXpressInstance.Licensing.SetSolutionName(license.SolutionName);
                isisXpressInstance.Licensing.SetSolutionKey(license.Solution32Key1, license.Solution32Key2, license.Solution32Key3, license.Solution32Key4);
                isisXpressInstance.Licensing.SetOEMLicenseKey(license.OEMLicenseKeyISISXpress);
            }
#endif

            isisXpressInstance.Scanned += new IsisXpress.ScannedEventHandler(isisXpressInstance_Scanned);
        }

        private void isisXpressInstance_Scanned(object sender, ScannedEventArgs e)
        {
            IntPtr hdib = isisXpressInstance.Output.ToHdib();

            //must set last parameter to true so Hdib will be cleaned up
            using (ImageX scannedImage = ImageX.FromHdib(imagXpress1, hdib, true))
            {
                imagesScanned.Add(scannedImage.Copy());
            }

            imagesScannedCount = imagesScanned.Count;
            imagesScannedIndex++;

            UpdatePageUI();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            try
            {
                isisXpressInstance.Scanner.Setup(this.Handle.ToInt32(), SetupOptions.Normal);
            }
            catch (CancelException ex)
            {
                StatusBarLabel.Text = ex.Message;
            }
            catch (IsisDriverException ex)
            {
                StatusBarLabel.Text = ex.Message;
            }
        }
    }
}