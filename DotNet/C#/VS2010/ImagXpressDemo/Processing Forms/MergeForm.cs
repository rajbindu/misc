/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class MergeForm : ProcessingForm
    {
        public MergeForm()
        {
            InitializeComponent();
        }

        private int sourceImageFilterIndex;
        public int SourceImageFilterIndex
        {
            get
            {
                return sourceImageFilterIndex;
            }
            set
            {
                sourceImageFilterIndex = value;
            }
        }

        private string sourceImageInitialDirectory;
        public string SourceImageInitialDirectory
        {
            get
            {
                return sourceImageInitialDirectory;
            }
            set
            {
                sourceImageInitialDirectory = value;
            }
        }

        public string SourceImage
        {
            get
            {
                return SourceImageTextBox.Text;
            }
            set
            {
                SourceImageTextBox.Text = value;
            }
        }

        public bool Transparent
        {
            get
            {
                return TransparentCheckBox.Checked;
            }
            set
            {
                TransparentCheckBox.Checked = value;
            }
        }

        public MergeSize MergeSize
        {
            get
            {
                return (MergeSize)MergeSizeComboBox.SelectedIndex;
            }
            set
            {
                MergeSizeComboBox.SelectedIndex = (int)value;
            }
        }


        public MergeStyle MergeStyle
        {
            get
            {
                return (MergeStyle)MergeStyleComboBox.SelectedIndex;
            }
            set
            {
                MergeStyleComboBox.SelectedIndex = (int)value;
            }
        }

        public Color TransparentColor
        {
            get
            {
                return TransparentColorButton.BackColor;
            }
            set
            {
                TransparentColorButton.BackColor = value;
            }
        }

        public int MergePercentHigh
        {
            get
            {
                return (int)MergePercentHighNumericUpDown.Value;
            }
            set
            {
                MergePercentHighNumericUpDown.Value = value;
            }
        }

        public int MergePercentLow
        {
            get
            {
                return (int)MergePercentLowNumericUpDown.Value;
            }
            set
            {
                MergePercentLowNumericUpDown.Value = value;
            }
        }

        protected override bool PerformProcessingAction()
        {
            Processor proc = null;
            ImageX sourceImage = null;
            try
            {
                if (String.IsNullOrEmpty(SourceImageTextBox.Text))
                {
                    Helper.ShowBalloonToolTipWarning(
                        SourceImageTextBox.Width - Constants.balloonToolTipHorizontalSpacer,
                        -Constants.balloonToolTipVerticalSpacer, Constants.tooltipInitialDelay, 
                        Constants.tooltipDuration, Constants.mergeString, Constants.mergeErrorString, 
                        SourceImageTextBox);

                    this.DialogResult = DialogResult.None;

                    return false;
                }
                else
                {
                    proc = new Processor(imagXpress1, imageXView1.Image.Copy());
                    Helper.TransformIfGrayscale(proc.Image);

                    Point currentScrollPosition;
                    if (imageXView2.Image == null)
                    {
                        currentScrollPosition = imageXView1.ScrollPosition;
                    }
                    else
                    {
                        currentScrollPosition = imageXView2.ScrollPosition;
                    }

                    sourceImage = ImageX.FromFile(imagXpress1, SourceImageTextBox.Text);

                    proc.Merge(ref sourceImage, (MergeSize)MergeSizeComboBox.SelectedIndex,
                        (MergeStyle)MergeStyleComboBox.SelectedIndex, TransparentCheckBox.Checked,
                        TransparentColorButton.BackColor, (int)MergePercentHighNumericUpDown.Value,
                        (int)MergePercentLowNumericUpDown.Value);

                    UpdateOutputImage(proc.Image.Copy());

                    imageXView2.ScrollPosition = currentScrollPosition;

                    return true;
                }
            }
            catch (ProcessorException ex)
            {
                MessageBox.Show(ex.Message, Constants.processingErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (ImageXException ex)
            {
                MessageBox.Show(ex.Message, Constants.processingErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (sourceImage != null)
                {
                    sourceImage.Dispose();
                    sourceImage = null;
                }
                if (proc != null)
                {
                    if (proc.Image != null)
                    {
                        proc.Image.Dispose();
                        proc.Image = null;
                    }
                    proc.Dispose();
                    proc = null;
                }
            }
        }

        private void BrowseButton_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openDlg = new OpenFileDialog())
            {
                openDlg.Title = Constants.openImageString;
                openDlg.Filter = Constants.allFilesFilterString;
                openDlg.FilterIndex = sourceImageFilterIndex;
                openDlg.InitialDirectory = sourceImageInitialDirectory;

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    sourceImageInitialDirectory = Path.GetDirectoryName(openDlg.FileName);
                    sourceImageFilterIndex = openDlg.FilterIndex;

                    imageXView1.PaletteFilename = openDlg.FileName;
                    SourceImageTextBox.Text = openDlg.FileName;
                }
            }
        }

        private void TransparentColorButton_Click(object sender, System.EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.Color = TransparentColorButton.BackColor;
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    TransparentColorButton.BackColor = colorDlg.Color;
                }
            }
        }

        private void MergeStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Merge % only applies to superimpose merge styles
            if (MergeStyleComboBox.SelectedIndex >= 5 && MergeStyleComboBox.SelectedIndex <= 13)
            {
                MergePercentHighNumericUpDown.Enabled = MergePercentLowNumericUpDown.Enabled = true;
            }
            else
            {
                MergePercentHighNumericUpDown.Enabled = MergePercentLowNumericUpDown.Enabled = false;
            }
        }
    }
}
