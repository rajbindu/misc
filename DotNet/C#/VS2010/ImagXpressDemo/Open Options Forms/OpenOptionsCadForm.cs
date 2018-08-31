/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class OpenOptionsCadForm : OpenOptionsForm
    {
        public OpenOptionsCadForm()
        {
            InitializeComponent();
        }

        public int LayoutToRender
        {
            get
            {
                return (int)LayoutToRenderNumericUpDown.Value;
            }
            set
            {
                LayoutToRenderNumericUpDown.Value = value;
            }
        }

        public int PaperBitDepth
        {
            get
            {
                return (int)PaperBitDepthNumbericUpDown.Value;
            }
            set
            {
                PaperBitDepthNumbericUpDown.Value = value;
            }
        }

        public double PaperWidth
        {
            get
            {
                return (double)PaperWidthNumericUpDown.Value;
            }
            set
            {
                PaperWidthNumericUpDown.Value = (decimal)value;
            }
        }

        public double PaperHeight
        {
            get
            {
                return (double)PaperHeightNumericUpDown.Value;
            }
            set
            {
                PaperHeightNumericUpDown.Value = (decimal)value;
            }
        }


        public double PaperResolutionX
        {
            get
            {
                return (double)PaperResolutionXNumericUpDown.Value;
            }
            set
            {
                PaperResolutionXNumericUpDown.Value = (decimal)value;
            }
        }

        public double PaperResolutionY
        {
            get
            {
                return (double)PaperResolutionYNumericUpDown.Value;
            }
            set
            {
                PaperResolutionYNumericUpDown.Value = (decimal)value;
            }
        }


        public ResolutionUnits PaperResolutionUnits
        {
            get
            {
                switch (PaperResolutionUnitsComboBox.SelectedIndex)
                {
                    default:
                    case 0:
                        {
                            return ResolutionUnits.None;
                        }
                    case 1:
                        {
                            return ResolutionUnits.Inch;
                        }
                    case 2:
                        {
                            return ResolutionUnits.Cm;
                        }
                }
            }
            set
            {
                switch (value)
                {
                    case ResolutionUnits.None:
                        {
                            PaperResolutionUnitsComboBox.SelectedIndex = 0;
                            break;
                        }
                    case ResolutionUnits.Inch:
                        {
                            PaperResolutionUnitsComboBox.SelectedIndex = 1;
                            break;
                        }
                    case ResolutionUnits.Cm:
                        {
                            PaperResolutionUnitsComboBox.SelectedIndex = 2;
                            break;
                        }
                }
            }
        }

        private void OpenOptionsCadForm_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + HeightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
        }
    }
}