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
    public partial class SaveOptionsTifForm : SaveOptionsForm
    {
        public SaveOptionsTifForm()
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

        private int bitsPerPixel;
        public int BitsPerPixel
        {
            get 
            {
                return bitsPerPixel;
            }
            set
            {
                bitsPerPixel = value;
            }
        }

        public ByteOrder ByteOrder
        {
            get
            {
                return (ByteOrder)ByteOrderComboBox.SelectedIndex;
            }
            set
            {
                ByteOrderComboBox.SelectedIndex = (int)value;
            }
        }

        public void SetColorSpaceEnabled(bool enabled)
        {
            ColorSpaceComboBox.Enabled = enabled;
        }

        public void SetCompressionEntries(string[] entries)
        {
            CompressionComboBox.Items.AddRange(entries);
        }

        public Compression Compression
        {
            get
            {
                if (bitsPerPixel == 1)
                {
                    switch (CompressionComboBox.SelectedIndex)
                    {
                        case 0:
                        default:
                            {
                                return Accusoft.ImagXpressSdk.Compression.NoCompression;
                            }
                        case 1:
                            {
                                return Accusoft.ImagXpressSdk.Compression.Rle;
                            }
                        case 2:
                            {
                                return Accusoft.ImagXpressSdk.Compression.Lzw;
                            }
                        case 3:
                            {
                                return Accusoft.ImagXpressSdk.Compression.PackBits;
                            }
                        case 4:
                            {
                                return Accusoft.ImagXpressSdk.Compression.Group3Fax1d;
                            }
                        case 5:
                            {
                                return Accusoft.ImagXpressSdk.Compression.Group3Fax2d;
                            }
                        case 6:
                            {
                                return Accusoft.ImagXpressSdk.Compression.Group4;
                            }
                    }
                }
                else
                {
                    switch (CompressionComboBox.SelectedIndex)
                    {
                        case 0:
                        default:
                            {
                                return Accusoft.ImagXpressSdk.Compression.NoCompression;
                            }
                        case 1:
                            {
                                return Accusoft.ImagXpressSdk.Compression.Lzw;
                            }
                        case 2:
                            {
                                return Accusoft.ImagXpressSdk.Compression.PackBits;
                            }
                        case 3:
                            {
                                return Accusoft.ImagXpressSdk.Compression.Deflate;
                            }
                        case 4:
                            {
                                return Accusoft.ImagXpressSdk.Compression.Jpeg;
                            }
                        case 5:
                            {
                                return Accusoft.ImagXpressSdk.Compression.Jpeg7;
                            }
                    }
                }
            }
            set
            {
                if (bitsPerPixel == 1)
                {
                    switch (value)
                    {
                        case Accusoft.ImagXpressSdk.Compression.NoCompression:
                            {
                                CompressionComboBox.SelectedIndex = 0;
                                break;
                            }
                        case Accusoft.ImagXpressSdk.Compression.Rle:
                            {
                                CompressionComboBox.SelectedIndex = 1;
                                break;
                            }
                        case Accusoft.ImagXpressSdk.Compression.Lzw:
                            {
                                CompressionComboBox.SelectedIndex = 2;
                                break;
                            }
                        case Accusoft.ImagXpressSdk.Compression.PackBits:
                            {
                                CompressionComboBox.SelectedIndex = 3;
                                break;
                            }
                        case Accusoft.ImagXpressSdk.Compression.Group3Fax1d:
                            {
                                CompressionComboBox.SelectedIndex = 4;
                                break;
                            }
                        case Accusoft.ImagXpressSdk.Compression.Group3Fax2d:
                            {
                                CompressionComboBox.SelectedIndex = 5;
                                break;
                            }
                        case Accusoft.ImagXpressSdk.Compression.Group4:
                            {
                                CompressionComboBox.SelectedIndex = 6;
                                break;
                            }
                    }
                }
                else
                {
                    switch (value)
                    {
                        case Accusoft.ImagXpressSdk.Compression.NoCompression:
                            {
                                CompressionComboBox.SelectedIndex = 0;
                                break;
                            }
                        case Accusoft.ImagXpressSdk.Compression.Lzw:
                            {
                                CompressionComboBox.SelectedIndex = 1;
                                break;
                            }
                        case Accusoft.ImagXpressSdk.Compression.PackBits:
                            {
                                CompressionComboBox.SelectedIndex = 2;
                                break;
                            }
                        case Accusoft.ImagXpressSdk.Compression.Deflate:
                            {
                                CompressionComboBox.SelectedIndex = 3;
                                break;
                            }
                        case Accusoft.ImagXpressSdk.Compression.Jpeg:
                            {
                                CompressionComboBox.SelectedIndex = 4;
                                break;
                            }
                        case Accusoft.ImagXpressSdk.Compression.Jpeg7:
                            {
                                CompressionComboBox.SelectedIndex = 5;
                                break;
                            }
                    }
                }
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

        public bool MultiPageEnabled
        {
            get
            {
                return MultiPageCheckBox.Enabled;
            }
            set
            {
                MultiPageCheckBox.Enabled = value;
            }
        }

        public bool MultiPage
        {
            get
            {
                return MultiPageCheckBox.Checked;
            }
            set
            {
                MultiPageCheckBox.Checked = value;
            }
        }

        public bool UseIFDOffset
        {
            get
            {
                return UseIFDOffsetCheckBox.Checked;
            }
            set
            {
                UseIFDOffsetCheckBox.Checked = value;
            }
        }

        public int IFDOffset
        {
            get
            {
                return (int)IFDOffsetNumericUpDown.Value;
            }
            set
            {
                IFDOffsetNumericUpDown.Value = value;
            }
        }

        public void SetIFDOffsetMax(int maximum)
        {
            IFDOffsetNumericUpDown.Maximum = maximum;
        }

        public int RowsPerStrip
        {
            get
            {
                return (int)RowsPerStripNumericUpDown.Value;
            }
            set
            {
                RowsPerStripNumericUpDown.Value = value;
            }
        }

        private void SaveOptionsTifForm_Load(object sender, System.EventArgs e)
       { 
            this.Height += OKButton.Height + heightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
        }

        private void CompressionComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //no compression selected and not 1bpp
            if (CompressionComboBox.SelectedIndex == 0 && bitsPerPixel != 1)
            {
                ColorSpaceComboBox.Enabled = true;

                //CMYK
                if (ColorSpaceComboBox.SelectedIndex == 1)
                {                    
                    DisplayColorManagementUI(true);
                }
            }
            else
            {
                ColorSpaceComboBox.Enabled = false;
                DisplayColorManagementUI(false);
            }
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
            }
            else
            {
                //CMYK
                DisplayColorManagementUI(true);
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