/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class OpenOptionsJpegXRForm : OpenOptionsForm
    {
        public OpenOptionsJpegXRForm()
        {
            InitializeComponent();
        }

        public JpegXRPostProcessFilter PostProcessingFilter
        {
            get
            {
                return (JpegXRPostProcessFilter)PostProcessingFilterComboBox.SelectedIndex;
            }
            set
            {
                PostProcessingFilterComboBox.SelectedIndex = (int)value;
            }
        }

        private void OpenOptionsJpegXRForm_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + HeightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
        }
    }
}