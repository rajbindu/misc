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
    public partial class MotionBlurForm : ProcessingForm
    {
        public MotionBlurForm()
        {
            InitializeComponent();
        }

        public int Intensity
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

        public int VelocityX
        {
            get
            {
                return (int)VelocityXNumericUpDown.Value;
            }
            set
            {
                VelocityXNumericUpDown.Value = value;
            }
        }

        public int VelocityY
        {
            get
            {
                return (int)VelocityYNumericUpDown.Value;
            }
            set
            {
                VelocityYNumericUpDown.Value = value;
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

                proc.MotionBlur((int)IntensityNumericUpDown.Value, (int)VelocityXNumericUpDown.Value, (int)VelocityYNumericUpDown.Value);               

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