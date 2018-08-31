/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
namespace ImagXpressDemo
{
    public partial class SaveOptionsWsqForm : SaveOptionsForm
    {
        public SaveOptionsWsqForm()
        {
            InitializeComponent();
        }

        public int Black
        {
            get
            {
                return (int)BlackNumericUpDown.Value;
            }
            set
            {
                BlackNumericUpDown.Value = value;
            }
        }

        public int White
        {
            get
            {
                return (int)WhiteNumericUpDown.Value;
            }
            set
            {
                WhiteNumericUpDown.Value = value;
            }
        }

        public double Quantization
        {
            get
            {
                return (double)QuantizationNumericUpDown.Value;
            }
            set
            {
                QuantizationNumericUpDown.Value = (decimal)value;
            }
        }

        private void SaveOptionsWsqForm_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + heightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;        
        }
    }
}
