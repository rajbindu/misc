/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class SaveOptionsBmpForm : SaveOptionsForm
    {
        public SaveOptionsBmpForm()
        {
            InitializeComponent();
        }

        public Compression Compression
        {
            get
            {
                return (Compression)CompressionComboBox.SelectedIndex;
            }
            set
            {
                CompressionComboBox.SelectedIndex = (int)value;
            }
        }

        private void SaveOptionsBmpForm_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + heightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
        }
    }
}
