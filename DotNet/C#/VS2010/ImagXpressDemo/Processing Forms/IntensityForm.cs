/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System.Drawing;
using System.Windows.Forms;
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public enum IntensityAction
    {
        Blend = 0,
        Brightness = 1,
        Contrast = 2,
        Gamma = 3,
        Mosaic = 4,
        Pinch = 5,
        Posterize = 6,
        Solarize = 7,
        Swirl = 8
    }

    public partial class IntensityForm : ProcessingForm
    {
        public IntensityForm()
        {
            InitializeComponent();
        }

        private const int intensitySpacer = 10;

        private IntensityAction intensityAction;
        public IntensityAction IntensityAction
        {
            get
            {
                return intensityAction;
            }
            set
            {
                intensityAction = value;

                switch (value)
                {
                    case IntensityAction.Blend:
                        {
                            this.Text = IntensityGroupBox.Text = Constants.blendString;
                            IntensityLabel.Text = Constants.percentString;
                            IntensityNumericUpDown.Maximum = 100;
                            IntensityNumericUpDown.Minimum = 0;
                            IntensityNumericUpDown.Increment = 1;
                            IntensityNumericUpDown.DecimalPlaces = 0;
                            break;
                        }
                    case IntensityAction.Brightness:
                        {
                            this.Text = IntensityGroupBox.Text = Constants.brightnessString;
                            IntensityLabel.Text = Constants.intensityString;
                            IntensityNumericUpDown.Maximum = 100;
                            IntensityNumericUpDown.Minimum = -100;
                            IntensityNumericUpDown.Increment = 1;
                            IntensityNumericUpDown.DecimalPlaces = 0;
                            break;
                        }
                    case IntensityAction.Contrast:
                        {
                            this.Text = IntensityGroupBox.Text = Constants.contrastString;
                            IntensityLabel.Text = Constants.intensityString;
                            IntensityNumericUpDown.Maximum = 100;
                            IntensityNumericUpDown.Minimum = -100;
                            IntensityNumericUpDown.Increment = 1;
                            IntensityNumericUpDown.DecimalPlaces = 0;
                            break;
                        }
                    case IntensityAction.Gamma:
                        {
                            this.Text = IntensityGroupBox.Text = Constants.gammaString;
                            IntensityLabel.Text = Constants.intensityString;
                            IntensityNumericUpDown.Maximum = 10;
                            IntensityNumericUpDown.Minimum = .1M;
                            IntensityNumericUpDown.Increment = .01M;
                            IntensityNumericUpDown.DecimalPlaces = 2;
                            break;
                        }
                    case IntensityAction.Mosaic:
                        {
                            this.Text = IntensityGroupBox.Text = Constants.mosaicString;
                            IntensityLabel.Text = Constants.blockSizeString;
                            IntensityNumericUpDown.Maximum = 63;
                            IntensityNumericUpDown.Minimum = 1;
                            IntensityNumericUpDown.Increment = 1;
                            IntensityNumericUpDown.DecimalPlaces = 0;

                            IntensityNumericUpDown.Left += intensitySpacer;
                            IntensityGroupBox.Width += intensitySpacer;
                            break;
                        }
                    case IntensityAction.Pinch:
                        {
                            this.Text = IntensityGroupBox.Text = Constants.pinchString;
                            IntensityLabel.Text = Constants.intensityString;
                            IntensityNumericUpDown.Maximum = 100;
                            IntensityNumericUpDown.Minimum = -100;
                            IntensityNumericUpDown.Increment = 1;
                            IntensityNumericUpDown.DecimalPlaces = 0;
                            break;
                        }
                    case IntensityAction.Posterize:
                        {
                            this.Text = IntensityGroupBox.Text = Constants.posterizeString;
                            IntensityLabel.Text = Constants.numberOfLevelsString;
                            IntensityNumericUpDown.Maximum = 255;
                            IntensityNumericUpDown.Minimum = 2;
                            IntensityNumericUpDown.Increment = 1;
                            IntensityNumericUpDown.DecimalPlaces = 0;

                            IntensityNumericUpDown.Left += intensitySpacer * 4;
                            IntensityGroupBox.Width += intensitySpacer * 4;
                            break;
                        }
                    case IntensityAction.Solarize:
                        {
                            this.Text = IntensityGroupBox.Text = Constants.solarizeString;
                            IntensityLabel.Text = Constants.thresholdString;
                            IntensityNumericUpDown.Maximum = 255;
                            IntensityNumericUpDown.Minimum = 0;
                            IntensityNumericUpDown.Increment = 1;
                            IntensityNumericUpDown.DecimalPlaces = 0;

                            IntensityNumericUpDown.Left += intensitySpacer;
                            IntensityGroupBox.Width += intensitySpacer;
                            break;
                        }
                    case IntensityAction.Swirl:
                        {
                            this.Text = IntensityGroupBox.Text = Constants.swirlString;
                            IntensityLabel.Text = Constants.degreesString;
                            IntensityNumericUpDown.Maximum = 360;
                            IntensityNumericUpDown.Minimum = 0;
                            IntensityNumericUpDown.Increment = .1M;
                            IntensityNumericUpDown.DecimalPlaces = 2;
                            break;
                        }
                }
            }
        }

        public int PinchIntensity
        {
            get
            {
                return (int)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = value;
            }
        }

        public int PosterizeNumberOfLevels
        {
            get
            {
                return (int)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = value;
            }
        }

        public int SolarizeThreshold
        {
            get
            {
                return (int)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = value;
            }
        }

        public double SwirlDegrees
        {
            get
            {
                return (double)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = (decimal)value;
            }
        }

        public int MosaicBlockSize
        {
            get
            {
                return (int)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = value;
            }
        }

        public int BlendIntensity
        {
            get
            {
                return (int)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = value;
            }
        }

        public short BrightnessIntensity
        {
            get
            {
                return (short)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = value;
            }
        }

        public short ContrastIntensity
        {
            get
            {
                return (short)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = value;
            }
        }

        public float GammaIntensity
        {
            get
            {
                return (float)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = (decimal)value;
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

                switch (intensityAction)
                {
                    case IntensityAction.Blend:
                        {
                            proc.Blend((int)IntensityNumericUpDown.Value);
                            break;
                        }
                    case IntensityAction.Brightness:
                        {
                            proc.Brightness((short)IntensityNumericUpDown.Value);
                            break;
                        }
                    case IntensityAction.Contrast:
                        {
                            proc.Contrast((short)IntensityNumericUpDown.Value);
                            break;
                        }
                    case IntensityAction.Gamma:
                        {
                            proc.Gamma((float)IntensityNumericUpDown.Value);
                            break;
                        }
                    case IntensityAction.Mosaic:
                        {
                            proc.Mosaic((int)IntensityNumericUpDown.Value);
                            break;
                        }
                    case IntensityAction.Pinch:
                        {
                            proc.Pinch((int)IntensityNumericUpDown.Value);
                            break;
                        }
                    case IntensityAction.Posterize:
                        {
                            proc.Posterize((int)IntensityNumericUpDown.Value);
                            break;
                        }
                    case IntensityAction.Solarize:
                        {
                            proc.Solarize((int)IntensityNumericUpDown.Value);
                            break;
                        }
                    case IntensityAction.Swirl:
                        {
                            proc.Swirl((double)IntensityNumericUpDown.Value);
                            break;
                        }
                }

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
    }
}
