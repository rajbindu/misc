/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class SaveOptionsLjpForm : SaveOptionsForm
    {
        public SaveOptionsLjpForm()
        {
            InitializeComponent();
        }

        public LjpType LjpType
        {
            get
            {
                return (LjpType)TypeComboBox.SelectedIndex;
            }
            set
            {
                TypeComboBox.SelectedIndex = (int)value;
            }
        }

        public LjpMethod Method
        {
            get
            {
                return (LjpMethod)MethodComboBox.SelectedIndex;
            }
            set
            {
                MethodComboBox.SelectedIndex = (int)value;
            }
        }

        public int Predictor
        {
            get
            {
                return (int)PredictorNumericUpDown.Value;
            }
            set
            {
                PredictorNumericUpDown.Value = value;
            }
        }

        public int Order
        {
            get
            {
                return (int)OrderNumericUpDown.Value;
            }
            set
            {
                OrderNumericUpDown.Value = value;
            }
        }

        private void SaveOptionsLjpForm_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + heightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
        }
    }
}
