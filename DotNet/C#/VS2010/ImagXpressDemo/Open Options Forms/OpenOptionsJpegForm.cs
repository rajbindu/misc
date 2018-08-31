/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class OpenOptionsJpegForm : OpenOptionsForm
    {
        public OpenOptionsJpegForm()
        {
            InitializeComponent();
        }

        public bool Cosited
        {
            get
            {
                return CositedCheckBox.Checked;
            }
            set
            {
                CositedCheckBox.Checked = value;
            }
        }

        public bool Enhanced
        {
            get
            {
                return EnhancedCheckBox.Checked;
            }
            set
            {
                EnhancedCheckBox.Checked = value;
            }
        }

        public ThumbnailSize ThumbnailSize
        {
            get
            {
                return (ThumbnailSize)ThumbnailSizeComboBox.SelectedIndex;
            }

            set
            {
                ThumbnailSizeComboBox.SelectedIndex = (int)value;
            }
        }

        private void OpenOptionsJpegForm_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + HeightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
        }
    }
}
