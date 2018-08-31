/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class SaveOptionsJpeg2000Form : SaveOptionsForm
    {
        public SaveOptionsJpeg2000Form()
        {
            InitializeComponent();
        }

        public bool Grayscale
        {
            get
            {
                return GrayscaleCheckBox.Checked;
            }
            set
            {
                GrayscaleCheckBox.Checked = value;
            }
        }

        public int CompressSize
        {
            get
            {
                return (int)CompressSizeNumericUpDown.Value;
            }
            set
            {
                CompressSizeNumericUpDown.Value = value;
            }
        }

        public ProgressionOrder ProgressionOrder
        {
            get
            {
                return (ProgressionOrder)ProgressionOrderComboBox.SelectedIndex;
            }
            set
            {
                ProgressionOrderComboBox.SelectedIndex = (int)value;
            }
        }

        public Jp2Type Jp2Type
        {
            get
            {
                return (Jp2Type)TypeComboBox.SelectedIndex;
            }
            set
            {
                TypeComboBox.SelectedIndex = (int)value;
            }
        }

        public double PeakSignalToNoiseRatio
        {
            get
            {
                return (double)PeakSignalToNoiseRatioNumericUpDown.Value;
            }
            set
            {
                PeakSignalToNoiseRatioNumericUpDown.Value = (decimal)value;
            }
        }

        public int TileWidth
        {
            get
            {
                return (int)TileWidthNumericUpDown.Value;
            }
            set
            {
                TileWidthNumericUpDown.Value = value;
            }
        }

        public int TileHeight
        {
            get
            {
                return (int)TileHeightNumericUpDown.Value;
            }
            set
            {
                TileHeightNumericUpDown.Value = value;
            }
        }

        public void SetTileWidthMax(int maximum)
        {
            TileWidthNumericUpDown.Maximum = maximum;
        }

        public void SetTileHeightMax(int maximum)
        {
            TileHeightNumericUpDown.Maximum = maximum;
        }

        private void SaveOptionsJpeg2000Form_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + heightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
        }
    }
}
