/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;
using System.Windows.Forms;
using System.Drawing;

namespace ImagXpressDemo
{
    public partial class ResizeForm : ProcessingForm
    {
        public ResizeForm()
        {
            InitializeComponent();
        }

        public int SizeSelection
        {
            get
            {
                return SizesComboBox.SelectedIndex;
            }
            set
            {
                SizesComboBox.SelectedIndex = value;
            }
        }

        public Size NewSize
        {
            get 
            {
                return new Size((int)SizeWidthNumericUpDown.Value, (int)SizeHeightNumericUpDown.Value);
            }
            set
            {
                SizeWidthNumericUpDown.Value = value.Width;
                SizeHeightNumericUpDown.Value = value.Height;
            }
        }

        public void SetNewSizeMax(Size max)
        {
            SizeWidthNumericUpDown.Maximum = max.Width;
            SizeHeightNumericUpDown.Maximum = max.Height;
        }
        
        public bool ScaleToGray
        {
            get
            {
                return ScaleResizeToGrayCheckBox.Checked;
            }
            set
            {
                ScaleResizeToGrayCheckBox.Checked = value;
            }
        }

        public bool ScaleToPreserveBlack
        {
            get
            {
                return PreserveBlackResizeCheckBox.Checked;
            }
            set
            {
                PreserveBlackResizeCheckBox.Checked = value;
            }
        }

        public ResizeType ResizeType
        {
            get
            {
                return (ResizeType)ResizeTypeComboBox.SelectedIndex;
            }
            set
            {
                ResizeTypeComboBox.SelectedIndex = (int)value;
            }
        }

        protected override bool PerformProcessingAction()
        {
            Processor proc = null;
            try
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

                int newWidth = 0;
                int newHeight = 0;

                if (SizesComboBox.SelectedIndex == 8)
                {
                    newWidth = (int)SizeWidthNumericUpDown.Value;
                    newHeight = (int)SizeHeightNumericUpDown.Value;
                }
                else
                {
                    switch (SizesComboBox.SelectedIndex)
                    {
                        case 0:
                            {
                                newWidth = 320;
                                newHeight = 240;
                                break;
                            }
                        case 1:
                            {
                                newWidth = 640;
                                newHeight = 480;
                                break;
                            }
                        case 2:
                            {
                                newWidth = 800;
                                newHeight = 600;
                                break;
                            }
                        case 3:
                            {
                                newWidth = 1024;
                                newHeight = 768;
                                break;
                            }
                        case 4:
                            {
                                newWidth = 1280;
                                newHeight = 720;
                                break;
                            }
                        case 5:
                            {
                                newWidth = 1280;
                                newHeight = 1024;
                                break;
                            }
                        case 6:
                            {
                                newWidth = (int)(imageXView1.Image.Width * .5);
                                newHeight = (int)(imageXView1.Image.Height * .5);
                                break;
                            }
                        case 7:
                            {
                                newWidth = imageXView1.Image.Width * 2;
                                newHeight = imageXView1.Image.Height * 2;
                                break;
                            }
                    }
                }

                proc.Resize(new Size(newWidth, newHeight),
                    (ResizeType)ResizeTypeComboBox.SelectedIndex,
                    ScaleResizeToGrayCheckBox.Checked, PreserveBlackResizeCheckBox.Checked);

                UpdateOutputImage(proc.Image.Copy());

                imageXView2.ScrollPosition = currentScrollPosition;

                return true;
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

        private void ResizeForm_Load(object sender, System.EventArgs e)
        {
            //scale to gray only applies to 1-bit or 8-bit
            if (imageXView1.Image.BitsPerPixel == 1 || imageXView1.Image.BitsPerPixel == 8)
            {
                ScaleResizeToGrayCheckBox.Enabled = true;
            }
            else
            {
                ScaleResizeToGrayCheckBox.Enabled = false;
            }
        }

        private void EnableCustomSizeUI(bool isVisible)
        {
            SizeWidthLabel.Visible = SizeWidthNumericUpDown.Visible
                = SizeHeightLabel.Visible = SizeHeightNumericUpDown.Visible = isVisible;
        }

        private void SizesComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (SizesComboBox.SelectedIndex == 8)
            {
                EnableCustomSizeUI(true);
            }
            else
            {
                EnableCustomSizeUI(false);
            }
        }
    }
}