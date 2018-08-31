/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class SaveOptionsJpegXRForm : SaveOptionsForm
    {
        public SaveOptionsJpegXRForm()
        {
            InitializeComponent();
        }

        public bool FrequencyOrdering
        {
            get
            {
                return FrequencyOrderingCheckBox.Checked;
            }
            set
            {
                FrequencyOrderingCheckBox.Checked = value;
            }
        }

        public int Quantization
        {
            get
            {
                return (int)QuantizationNumericUpDown.Value;
            }
            set
            {
                QuantizationNumericUpDown.Value = value;
            }
        }

        public JpegXRSubSampling ChromaSubSampling
        {
            get
            {
                switch (ChromaSubSamplingComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            return JpegXRSubSampling.ChromaSubSampling400;
                        }
                    case 1:
                        {
                            return JpegXRSubSampling.ChromaSubSampling420;
                        }
                    case 2:
                        {
                            return JpegXRSubSampling.ChromaSubSampling422;
                        }
                    case 3:
                    default:
                        {
                            return JpegXRSubSampling.ChromaSubSampling444;
                        }
                }
            }
            set
            {
                switch (value)
                {
                    case JpegXRSubSampling.ChromaSubSampling400:
                        {
                            ChromaSubSamplingComboBox.SelectedIndex = 0;
                            break;
                        }
                    case JpegXRSubSampling.ChromaSubSampling420:
                        {
                            ChromaSubSamplingComboBox.SelectedIndex = 1;
                            break;
                        }
                    case JpegXRSubSampling.ChromaSubSampling422:
                        {
                            ChromaSubSamplingComboBox.SelectedIndex = 2;
                            break;
                        }
                    case JpegXRSubSampling.ChromaSubSampling444:
                        {
                            ChromaSubSamplingComboBox.SelectedIndex = 3;
                            break;
                        }
                }
            }
        }

        private void SaveOptionsJpegXRForm_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + heightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
        }
    }
}
