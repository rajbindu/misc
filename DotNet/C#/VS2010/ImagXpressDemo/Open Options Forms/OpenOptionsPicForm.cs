/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class OpenOptionsPicForm : OpenOptionsForm
    {
        public OpenOptionsPicForm()
        {
            InitializeComponent();
        }

        public string PicPassword
        {
            get
            {
                return PicPasswordTextBox.Text;
            }
            set
            {
                PicPasswordTextBox.Text = value;
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

        private void OpenOptionsPicForm_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + HeightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
        }
    }
}
