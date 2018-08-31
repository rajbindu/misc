/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class OpenOptionsCameraRawForm : OpenOptionsForm
    {
        public OpenOptionsCameraRawForm()
        {
            InitializeComponent();
        }

        public bool BlueFactorEnabled
        {
            get
            {
                return BlueFactorCheckBox.Checked;
            }
            set
            {
                BlueFactorCheckBox.Checked = value;
            }
        }

        public double BlueFactor
        {
            get
            {
                return (double)BlueFactorNumericUpDown.Value;
            }
            set
            {
                BlueFactorNumericUpDown.Value = (decimal)value;
            }
        }

        public double RedFactor
        {
            get
            {
                return (double)RedFactorNumericUpDown.Value;
            }
            set
            {
                RedFactorNumericUpDown.Value = (decimal)value;
            }
        }

        public bool RedFactorEnabled
        {
            get
            {
                return RedFactorCheckBox.Checked;
            }
            set
            {
                RedFactorCheckBox.Checked = value;
            }
        }

        public double BrightnessFactor
        {
            get
            {
                return (double)BrightnessFactorNumericUpDown.Value;
            }
            set
            {
                BrightnessFactorNumericUpDown.Value = (decimal)value;
            }
        }

        public bool BrightnessFactorEnabled
        {
            get
            {
                return BrightnessCheckBox.Checked;
            }
            set
            {
                BrightnessCheckBox.Checked = value;
            }
        }

        public double GammaCorrection
        {
            get
            {
                return (double)GammaCorrectionNumericUpDown.Value;
            }
            set
            {
                GammaCorrectionNumericUpDown.Value = (decimal)value;
            }
        }

        public WhiteBalanceMethod WhiteBalanceMethod
        {
            get
            {
                return (WhiteBalanceMethod)WhiteBalanceMethodComboBox.SelectedIndex;
            }
            set
            {
                WhiteBalanceMethodComboBox.SelectedIndex = (int)value;
            }
        }

        public bool AutoBrightnessAndContrast
        {
            get
            {
                return AutoBrightnessAndContrastCheckBox.Checked;
            }
            set
            {
                AutoBrightnessAndContrastCheckBox.Checked = value;
            }
        }

        public bool ClipHighlightsToWhite
        {
            get
            {
                return ClipHighlightsToWhiteCheckBox.Checked;
            }
            set
            {
                ClipHighlightsToWhiteCheckBox.Checked = value;
            }
        }

        public bool ConvertTosRGB
        {
            get
            {
                return ConvertTosRGBCheckBox.Checked;
            }
            set
            {
                ConvertTosRGBCheckBox.Checked = value;
            }
        }

        public bool RemoveRotation
        {
            get
            {
                return RemoveRotationCheckBox.Checked;
            }
            set
            {
                RemoveRotationCheckBox.Checked = value;
            }
        }

        public bool ReturnThumbnail
        {
            get
            {
                return ReturnThumbnailCheckBox.Checked;
            }
            set
            {
                ReturnThumbnailCheckBox.Checked = value;
            }
        }

        public bool UseFastInterpolationMethod
        {
            get
            {
                return UseFastInterpolationMethodCheckBox.Checked;
            }
            set
            {
                UseFastInterpolationMethodCheckBox.Checked = value;
            }
        }

        public bool UseHalfSizeImage
        {
            get
            {
                return UseHalfSizeImageCheckBox.Checked;
            }
            set
            {
                UseHalfSizeImageCheckBox.Checked = value;
            }
        }

        public bool UseSecondaryPixels
        {
            get
            {
                return UseSecondaryPixelsCheckBox.Checked;
            }
            set
            {
                UseSecondaryPixelsCheckBox.Checked = value;
            }
        }

        private void OpenOptionsCameraRawForm_Load(object sender, System.EventArgs e)
        {
            //crop, rotate, and resize are not supported for camera raw
            CropXNumericUpDown.Enabled = false;
            CropYNumericUpDown.Enabled = false;
            CropWidthNumericUpDown.Enabled = false;
            CropHeightNumericUpDown.Enabled = false;
            ResizeWidthNumericUpDown.Enabled = false;
            ResizeHeightNumericUpDown.Enabled = false;
            RotationComboBox.Enabled = false;

            //anti-alias only applies to a resize which isn't supported by camera raw
            ResizeAntiAliasCheckBox.Enabled = false;

            this.Height += OKButton.Height + HeightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - BottomOfFormSpacer;
        }

        private void BlueFactorCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (BlueFactorCheckBox.Checked == false)
            {
                BlueFactorNumericUpDown.Enabled = false;
            }
            else
            {
                BlueFactorNumericUpDown.Enabled = true;
            }
        }

        private void BrightnessCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (BrightnessCheckBox.Checked == false)
            {
                BrightnessFactorNumericUpDown.Enabled = false;
            }
            else
            {
                BrightnessFactorNumericUpDown.Enabled = true;
            }
        }

        private void RedFactorCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (RedFactorCheckBox.Checked == false)
            {
                RedFactorNumericUpDown.Enabled = false;
            }
            else
            {
                RedFactorNumericUpDown.Enabled = true;
            }
        }

        private void BlueFactorLabel_Click(object sender, System.EventArgs e)
        {
            if (BlueFactorCheckBox.Checked == false)
            {
                BlueFactorCheckBox.Checked = true;
            }
            else
            {
                BlueFactorCheckBox.Checked = false;
            }
        }

        private void RedFactorLabel_Click(object sender, System.EventArgs e)
        {
            if (RedFactorCheckBox.Checked == false)
            {
                RedFactorCheckBox.Checked = true;
            }
            else
            {
                RedFactorCheckBox.Checked = false;
            }
        }

        private void BrightnessFactorLabel_Click(object sender, System.EventArgs e)
        {
            if (BrightnessCheckBox.Checked == false)
            {
                BrightnessCheckBox.Checked = true;
            }
            else
            {
                BrightnessCheckBox.Checked = false;
            }
        }
    }
}