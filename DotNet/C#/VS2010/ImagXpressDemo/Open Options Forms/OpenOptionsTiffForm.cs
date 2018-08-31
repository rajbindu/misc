/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
namespace ImagXpressDemo
{
    public partial class OpenOptionsTiffForm : OpenOptionsForm
    {
        public OpenOptionsTiffForm()
        {
            InitializeComponent();
        }

        public bool SpecialHandling
        {
            get
            {
                return SpecialHandlingCheckBox.Checked;
            }
            set
            {
                SpecialHandlingCheckBox.Checked = value;
            }
        }

        public int IFDOffset
        {
            get
            {
                return (int)IfdOffsetNumericUpDown.Value;
            }
            set
            {
                IfdOffsetNumericUpDown.Value = value;
            }
        }

        public void SetIFDOffsetMax(int maximum)
        {
            IfdOffsetNumericUpDown.Maximum = maximum;
        }

        private void OpenOptionsTiffForm_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + HeightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
        }
    }
}
