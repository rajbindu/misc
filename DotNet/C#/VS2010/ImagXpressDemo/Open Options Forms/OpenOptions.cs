/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.Windows.Forms;
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class OpenOptionsForm : Form
    {
        public const int BottomOfFormSpacer = 38;
        public const int HeightSpacer = 15;

        public OpenOptionsForm()
        {
            InitializeComponent();
        }

        public int CropX
        {
            get
            {
                return (int)CropXNumericUpDown.Value;
            }
            set
            {
                CropXNumericUpDown.Value = value;
            }
        }

        public void SetCropXMax(int maximum)
        {
            CropXNumericUpDown.Maximum = maximum;
        }

        public int CropY
        {
            get
            {
                return (int)CropYNumericUpDown.Value;
            }
            set
            {
                CropYNumericUpDown.Value = value;
            }
        }

        public void SetCropYMax(int maximum)
        {
            CropYNumericUpDown.Maximum = maximum;
        }

        public int CropWidth
        {
            get
            {
                return (int)CropWidthNumericUpDown.Value;
            }
            set
            {
                CropWidthNumericUpDown.Value = value;
            }
        }

        public void SetCropWidthMax(int maximum)
        {
            CropWidthNumericUpDown.Maximum = maximum;
        }

        public int CropHeight
        {
            get
            {
                return (int)CropHeightNumericUpDown.Value;
            }
            set
            {
                CropHeightNumericUpDown.Value = value;
            }
        }

        public void SetCropHeightMax(int maximum)
        {
            CropHeightNumericUpDown.Maximum = maximum;
        }

        public int ResizeWidth
        {
            get
            {
                return (int)ResizeWidthNumericUpDown.Value;
            }
            set
            {
                ResizeWidthNumericUpDown.Value = value;
            }
        }

        public int ResizeHeight
        {
            get
            {
                return (int)ResizeHeightNumericUpDown.Value;
            }
            set
            {
                ResizeHeightNumericUpDown.Value = value;
            }
        }

        public bool ResizeAntiAlias
        {
            get
            {
                return ResizeAntiAliasCheckBox.Checked;
            }
            set
            {
                ResizeAntiAliasCheckBox.Checked = value;
            }
        }

        public bool MaintainApsectRatio
        {
            get
            {
                return MaintainAspectRatioCheckBox.Checked;
            }
            set
            {
                MaintainAspectRatioCheckBox.Checked = value;
            }
        }

        public bool PreserveBlack
        {
            get
            {
                return PreserveBlackCheckBox.Checked;
            }
            set
            {
                PreserveBlackCheckBox.Checked = value;
            }
        }

        public bool AlphaChannel
        {
            get
            {
                return AlphaChannelCheckBox.Checked;
            }
            set
            {
                AlphaChannelCheckBox.Checked = value;
            }
        }

        public bool ScaleToGray
        {
            get
            {
                return ScaleToGrayCheckBox.Checked;
            }
            set
            {
                ScaleToGrayCheckBox.Checked = value;
            }
        }

        public bool ScaleToGrayEnabled
        {
            get
            {
                return ScaleToGrayCheckBox.Enabled;
            }
            set
            {
                ScaleToGrayCheckBox.Enabled = value;
            }
        }

        public RotateAngle Rotation
        {
            get
            {
                return (RotateAngle)RotationComboBox.SelectedIndex;
            }
            set
            {
                RotationComboBox.SelectedIndex = (int)value;
            }

        }

        public int ImageOffset
        {
            get
            {
                return (int)ImageOffsetNumericUpDown.Value;
            }
            set
            {
                ImageOffsetNumericUpDown.Value = value;
            }
        }

        public int ImageOffsetMax
        {
            get
            {
                return (int)ImageOffsetNumericUpDown.Maximum;
            }
            set
            {
                ImageOffsetNumericUpDown.Maximum = value;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CancelOptionsButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}