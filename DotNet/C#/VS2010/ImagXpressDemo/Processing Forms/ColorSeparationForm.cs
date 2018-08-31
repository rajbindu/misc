/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System.Windows.Forms;
using System.Drawing;
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class ColorSeparationForm : ProcessingForm
    {
        public ColorSeparationForm()
        {
            InitializeComponent();
        }

        private Bitmap bitmap1, bitmap2, bitmap3, bitmap4;

        public SeparationType SeparationType
        {
            get
            {
                return (SeparationType)SeparationTypeComboBox.SelectedIndex;
            }
            set
            {
                SeparationTypeComboBox.SelectedIndex = (int)value;
            }
        }

        public bool RgbRed
        {
            get
            {
                return RedRgbRadioButton.Checked;
            }
            set
            {
                RedRgbRadioButton.Checked = value;
            }
        }

        public bool RgbGreen
        {
            get
            {
                return GreenRgbRadioButton.Checked;
            }
            set
            {
                GreenRgbRadioButton.Checked = value;
            }
        }

        public bool RgbBlue
        {
            get
            {
                return BlueRgbRadioButton.Checked;
            }
            set
            {
                BlueRgbRadioButton.Checked = value;
            }
        }

        public bool RgbaRed
        {
            get
            {
                return RedRgbaRadioButton.Checked;
            }
            set
            {
                RedRgbaRadioButton.Checked = value;
            }
        }

        public bool RgbaBlue
        {
            get
            {
                return BlueRgbaRadioButton.Checked;
            }
            set
            {
                BlueRgbaRadioButton.Checked = value;
            }
        }

        public bool RgbaGreen
        {
            get
            {
                return GreenRgbaRadioButton.Checked;
            }
            set
            {
                GreenRgbaRadioButton.Checked = value;
            }
        }

        public bool RgbaAlpha
        {
            get
            {
                return AlphaRgbaRadioButton.Checked;
            }
            set
            {
                AlphaRgbaRadioButton.Checked = value;
            }
        }

        public bool HslHue
        {
            get
            {
                return HueRadioButton.Checked;
            }
            set
            {
                HueRadioButton.Checked = value;
            }
        }

        public bool HslSaturation
        {
            get
            {
                return SaturationRadioButton.Checked;
            }
            set
            {
                SaturationRadioButton.Checked = value;
            }
        }

        public bool HslLuminance
        {
            get
            {
                return LuminanceRadioButton.Checked;
            }
            set
            {
                LuminanceRadioButton.Checked = value;
            }
        }

        public bool CmyCyan
        {
            get
            {
                return CyanCmyRadioButton.Checked;
            }
            set
            {
                CyanCmyRadioButton.Checked = value;
            }
        }

        public bool CmyMagenta
        {
            get
            {
                return MagentaCmyRadioButton.Checked;
            }
            set
            {
                MagentaCmyRadioButton.Checked = value;
            }
        }

        public bool CmyYellow
        {
            get
            {
                return YellowCmyRadioButton.Checked;
            }
            set
            {
                YellowCmyRadioButton.Checked = value;
            }
        }

        public bool CmykCyan
        {
            get
            {
                return CyanCmykRadioButton.Checked;
            }
            set
            {
                CyanCmykRadioButton.Checked = value;
            }
        }

        public bool CmykMagenta
        {
            get
            {
                return MagentaCmykRadioButton.Checked;
            }
            set
            {
                MagentaCmykRadioButton.Checked = value;
            }
        }

        public bool CmykYellow
        {
            get
            {
                return YellowCmykRadioButton.Checked;
            }
            set
            {
                YellowCmykRadioButton.Checked = value;
            }
        }

        public bool CmykBlack
        {
            get
            {
                return BlackCmykRadioButton.Checked;
            }
            set
            {
                BlackCmykRadioButton.Checked = value;
            }
        }

        private void DisposeOfOutputBitmaps(Bitmap bitmapToKeep)
        {
            if (bitmapToKeep != bitmap1 && bitmap1 != null)
            {
                bitmap1.Dispose();
                bitmap1 = null;
            }
            if (bitmapToKeep != bitmap2 && bitmap2 != null)
            {
                bitmap2.Dispose();
                bitmap2 = null;
            }
            if (bitmapToKeep != bitmap3 && bitmap3 != null)
            {
                bitmap3.Dispose();
                bitmap3 = null;
            }
            if (bitmapToKeep != bitmap4 && bitmap4 != null)
            {
                bitmap4.Dispose();
                bitmap4 = null;
            }
        }

        protected override bool PerformProcessingAction()
        {
            Processor proc = null;
            try
            {
                proc = new Processor(imagXpress1, imageXView1.Image.Copy());
                Helper.TransformIfGrayscale(proc.Image);
                DisposeOfOutputBitmaps(null);

                Point currentScrollPosition;
                if (imageXView2.Image == null)
                {
                    currentScrollPosition = imageXView1.ScrollPosition;
                }
                else
                {
                    currentScrollPosition = imageXView2.ScrollPosition;
                }

                proc.ColorSeparation((SeparationType)SeparationTypeComboBox.SelectedIndex, out bitmap1, out bitmap2, out bitmap3, out bitmap4);

                switch ((SeparationType)SeparationTypeComboBox.SelectedIndex)
                {
                    case SeparationType.Rgb:
                        {
                            if (RedRgbRadioButton.Checked)
                            {
                                outputBitmap = bitmap1;
                                DisposeOfOutputBitmaps(bitmap1);
                            }
                            else if (GreenRgbRadioButton.Checked)
                            {
                                outputBitmap = bitmap2;
                                DisposeOfOutputBitmaps(bitmap2);
                            }
                            else if (BlueRgbRadioButton.Checked)
                            {
                                outputBitmap = bitmap3;
                                DisposeOfOutputBitmaps(bitmap3);
                            }

                            break;
                        }
                    case SeparationType.Hsl:
                        {
                            if (HueRadioButton.Checked)
                            {
                                outputBitmap = bitmap1;
                                DisposeOfOutputBitmaps(bitmap1);
                            }
                            else if (SaturationRadioButton.Checked)
                            {
                                outputBitmap = bitmap2;
                                DisposeOfOutputBitmaps(bitmap2);
                            }
                            else if (LuminanceRadioButton.Checked)
                            {
                                outputBitmap = bitmap3;
                                DisposeOfOutputBitmaps(bitmap3);
                            }

                            break;
                        }
                    case SeparationType.Cmy:
                        {
                            if (CyanCmyRadioButton.Checked)
                            {
                                outputBitmap = bitmap1;
                                DisposeOfOutputBitmaps(bitmap1);
                            }
                            else if (MagentaCmyRadioButton.Checked)
                            {
                                outputBitmap = bitmap2;
                                DisposeOfOutputBitmaps(bitmap2);
                            }
                            else if (YellowCmyRadioButton.Checked)
                            {
                                outputBitmap = bitmap3;
                                DisposeOfOutputBitmaps(bitmap3);
                            }

                            break;
                        }
                    case SeparationType.Cmyk:
                        {
                            if (CyanCmykRadioButton.Checked)
                            {
                                outputBitmap = bitmap1;
                                DisposeOfOutputBitmaps(bitmap1);
                            }
                            else if (MagentaCmykRadioButton.Checked)
                            {
                                outputBitmap = bitmap2;
                                DisposeOfOutputBitmaps(bitmap2);
                            }
                            else if (YellowCmykRadioButton.Checked)
                            {
                                outputBitmap = bitmap3;
                                DisposeOfOutputBitmaps(bitmap3);
                            }
                            else if (BlackCmykRadioButton.Checked)
                            {
                                outputBitmap = bitmap4;
                                DisposeOfOutputBitmaps(bitmap4);
                            }

                            break;
                        }
                    case SeparationType.Rgba:
                        {
                            if (RedRgbaRadioButton.Checked)
                            {
                                outputBitmap = bitmap1;
                                DisposeOfOutputBitmaps(bitmap1);
                            }
                            else if (GreenRgbaRadioButton.Checked)
                            {
                                outputBitmap = bitmap2;
                                DisposeOfOutputBitmaps(bitmap2);
                            }
                            else if (BlueRgbaRadioButton.Checked)
                            {
                                outputBitmap = bitmap3;
                                DisposeOfOutputBitmaps(bitmap3);
                            }
                            else if (AlphaRgbaRadioButton.Checked)
                            {
                                outputBitmap = bitmap4;
                                DisposeOfOutputBitmaps(bitmap4);
                            }

                            break;
                        }
                }

                using (ImageX img = ImageX.FromBitmap(imagXpress1, outputBitmap))
                {
                    UpdateOutputImage(img.Copy());
                }

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

        private void SeparationTypeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RgbaGroupBox.Visible = HslGroupBox.Visible = CmyGroupBox.Visible = CmykGroupBox.Visible = RgbGroupBox.Visible = false;

            switch ((SeparationType)SeparationTypeComboBox.SelectedIndex)
            {
                case SeparationType.Rgb:
                    {
                        RgbGroupBox.Visible = true;
                        RgbGroupBox.Left = RgbaGroupBox.Left;
                        break;
                    }
                case SeparationType.Hsl:
                    {
                        HslGroupBox.Visible = true;
                        HslGroupBox.Left = RgbaGroupBox.Left;
                        break;
                    }
                case SeparationType.Cmy:
                    {
                        CmyGroupBox.Visible = true;
                        CmyGroupBox.Left = RgbaGroupBox.Left;
                        break;
                    }
                case SeparationType.Cmyk:
                    {
                        CmykGroupBox.Visible = true;
                        CmykGroupBox.Left = RgbaGroupBox.Left;
                        break;
                    }
                case SeparationType.Rgba:
                    {
                        RgbaGroupBox.Visible = true;
                        break;
                    }
            }
        }

        private void ColorSeparationForm_Load(object sender, System.EventArgs e)
        {
            //remove RGBA and CMYK items if not 32bpp, because they only apply to 32bpp image data
            if (imageXView1.Image.BitsPerPixel != 32)
            {
                SeparationTypeComboBox.Items.RemoveAt(4);
                SeparationTypeComboBox.Items.RemoveAt(3);
            }          
        }
    }
}