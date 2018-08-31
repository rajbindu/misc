/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class SaveOptionsJbig2Form : SaveOptionsForm
    {
        public SaveOptionsJbig2Form()
        {
            InitializeComponent();
        }

        public Jbig2EncodeModeCompression EncodeModeCompression
        {
            get
            {
                return (Jbig2EncodeModeCompression)EncodeModeCompressionComboBox.SelectedIndex;
            }
            set
            {
                EncodeModeCompressionComboBox.SelectedIndex = (int)value;
            }
        }

        public Jbig2FileOrganization FileOrganization
        {
            get
            {
                return (Jbig2FileOrganization)FileOrganizationComboBox.SelectedIndex;
            }
            set
            {
                FileOrganizationComboBox.SelectedIndex = (int)value;
            }
        }

        public int LoosenessCompression
        {
            get
            {
                return (int)LoosenessCompresionNumericUpDown.Value;
            }
            set
            {
                LoosenessCompresionNumericUpDown.Value = value;
            }
        }

        public bool InvertedRegion
        {
            get
            {
                return InvertedRegionCheckBox.Checked;
            }
            set
            {
                InvertedRegionCheckBox.Checked = value;
            }
        }

        private void SaveOptionsJbig2Form_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + heightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
        }
    }
}
