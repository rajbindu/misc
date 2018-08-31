/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
namespace ImagXpressDemo
{
    public partial class OpenOptionsJbig2Form : OpenOptionsForm
    {
        public OpenOptionsJbig2Form()
        {
            InitializeComponent();
        }

        public bool SwapBlackAndWhite
        {
            get
            {
                return SwapBlackAndWhiteCheckBox.Checked;
            }
            set
            {
                SwapBlackAndWhiteCheckBox.Checked = value;
            }
        }

        private void OpenOptionsJbig2Form_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + HeightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
        }
    }
}