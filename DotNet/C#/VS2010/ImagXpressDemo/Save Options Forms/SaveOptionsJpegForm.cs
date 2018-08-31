/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.IO;
using System.Windows.Forms;
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class SaveOptionsJpegForm : SaveOptionsForm
    {
        public SaveOptionsJpegForm()
        {
            InitializeComponent();
        }

        private string targetProfileInitialDirectory;
        public string TargetProfileInitialDirectory
        {
            get
            {
                return targetProfileInitialDirectory;
            }
            set
            {
                targetProfileInitialDirectory = value;
            }
        }

        public string TargetProfileName
        {
            get
            {
                return TargetProfileNameTextBox.Text;
            }
            set
            {
                TargetProfileNameTextBox.Text = value;
            }
        }

        public bool TargetProfileNameEnabled
        {
            get
            {
                return TargetProfileNameTextBox.Enabled;
            }
            set
            {
                TargetProfileNameTextBox.Enabled = value;
            }
        }

        public bool TargetProfileNameBrowseEnabled
        {
            get
            {
                return TargetProfileNameBrowseButton.Enabled;
            }
            set
            {
                TargetProfileNameBrowseButton.Enabled = value;
            }
        }

        public RenderIntent ColorRenderIntent
        {
            get
            {
                return (RenderIntent)ColorRenderIntentComboBox.SelectedIndex;
            }
            set
            {
                ColorRenderIntentComboBox.SelectedIndex = (int)value;
            }
        }

        public bool ColorRenderIntentEnabled
        {
            get
            {
                return ColorRenderIntentComboBox.Enabled;
            }
            set
            {
                ColorRenderIntentComboBox.Enabled = value;
            }
        }

        public int Chrominance
        {
            get
            {
                return (int)ChrominanceNumericUpDown.Value;
            }
            set
            {
                ChrominanceNumericUpDown.Value = value;
            }
        }

        public int Luminance
        {
            get
            {
                return (int)LuminanceNumericUpDown.Value;
            }
            set
            {
                LuminanceNumericUpDown.Value = value;
            }
        }

        public ColorSpace ColorSpace
        {
            get
            {
                return (ColorSpace)ColorSpaceComboBox.SelectedIndex;
            }
            set
            {
                ColorSpaceComboBox.SelectedIndex = (int)value;
            }
        }

        public SubSampling SubSampling
        {
            get
            {
                return (SubSampling)SubSamplingComboBox.SelectedIndex;
            }
            set
            {
                SubSamplingComboBox.SelectedIndex = (int)value;
            }
        }

        public bool Cosited
        {
            get
            {
                return CositedCheckBox.Checked;
            }
            set
            {
                CositedCheckBox.Checked = value;
            }
        }

        public bool GrayscaleEnabled
        {
            get
            {
                return GrayscaleCheckBox.Enabled;
            }
            set
            {
                GrayscaleCheckBox.Enabled = value;
            }
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

        public bool Progressive
        {
            get
            {
                return ProgressiveCheckBox.Checked;
            }
            set
            {
                ProgressiveCheckBox.Checked = value;
            }
        }

        private void SaveOptionsJpegForm_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + heightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
        }

        private void DisplayColorManagementUI(bool isEnabled)
        {
            ColorRenderIntentComboBox.Enabled
                    = TargetProfileNameTextBox.Enabled
                    = TargetProfileNameBrowseButton.Enabled = isEnabled;
        }

        private void ColorSpaceComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            if (ColorSpaceComboBox.SelectedIndex == 0)
            {
                //RGB
                DisplayColorManagementUI(false);
                GrayscaleCheckBox.Enabled = true;
            }
            else
            {
                //CMYK
                DisplayColorManagementUI(true);
            }
        }

        private void GrayscaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GrayscaleCheckBox.Checked)
            {
                ColorSpaceComboBox.Enabled = false;
                DisplayColorManagementUI(false);
            }
            else
            {
                ColorSpaceComboBox.Enabled = true;
                //CMYK
                if (ColorSpaceComboBox.SelectedIndex == 1)
                {
                    DisplayColorManagementUI(true);
                }
            }
        }

        private void TargetProfileNameBrowseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDlg = new OpenFileDialog())
            {
                openDlg.Title = "Open Target Profile";
                openDlg.Filter = Constants.profileFilterString;
                openDlg.FilterIndex = 0;
                openDlg.InitialDirectory = targetProfileInitialDirectory;

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    targetProfileInitialDirectory = Path.GetDirectoryName(openDlg.FileName);
                    TargetProfileNameTextBox.Text = openDlg.FileName;
                }
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //must use profile information to save as CMYK
            if (ColorSpaceComboBox.SelectedIndex == 1 && String.IsNullOrEmpty(TargetProfileNameTextBox.Text))
            {
                Helper.ShowBalloonToolTipWarning(
                    TargetProfileNameTextBox.Width - Constants.balloonToolTipHorizontalSpacer,
                    -Constants.balloonToolTipVerticalSpacer, Constants.tooltipInitialDelay,
                    Constants.tooltipDuration, Constants.cmykSaveString, Constants.cmykSaveErrorString,
                    TargetProfileNameTextBox);

                this.DialogResult = DialogResult.None;
            }
        }
    }
}