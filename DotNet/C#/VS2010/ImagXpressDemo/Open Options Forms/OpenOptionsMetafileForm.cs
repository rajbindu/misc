/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
namespace ImagXpressDemo
{
    public partial class OpenOptionsMetafileForm : OpenOptionsForm
    {
        public OpenOptionsMetafileForm()
        {
            InitializeComponent();
        }

        public float ResolutionX
        {
            get
            {
                return (float)ResolutionXNumericUpDown.Value;
            }
            set
            {
                ResolutionXNumericUpDown.Value = (decimal)value;
            }
        }

        public void SetResolutionXMax(int maximum)
        {
            ResolutionXNumericUpDown.Maximum = maximum;
        }

        public float ResolutionY
        {
            get
            {
                return (float)ResolutionYNumericUpDown.Value;
            }
            set
            {
                ResolutionYNumericUpDown.Value = (decimal)value;
            }
        }

        public void SetResolutionYMax(int maximum)
        {
            ResolutionYNumericUpDown.Maximum = maximum;
        }

        public IXResolutionUnit ResolutionUnit
        {
            get
            {
                return (IXResolutionUnit)ResolutionUnitsComboBox.SelectedIndex;
            }
            set
            {
                ResolutionUnitsComboBox.SelectedIndex = (int)value;
            }
        }

        private void OpenOptionsMetafileForm_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + HeightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
        }
    }
}
