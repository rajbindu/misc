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
    public partial class MatrixForm : ProcessingForm
    {
        public MatrixForm()
        {
            InitializeComponent();
        }

        public short[] GetMatrixArray()
        {
            return new short[] { (short)Array1NumericUpDown.Value, (short)Array2NumericUpDown.Value,
                    (short)Array3NumericUpDown.Value, (short)Array4NumericUpDown.Value, 
                    (short)Array5NumericUpDown.Value, (short)Array6NumericUpDown.Value, 
                    (short)Array7NumericUpDown.Value, (short)Array8NumericUpDown.Value, 
                    (short)Array9NumericUpDown.Value };
        }

        public void SetMatrixArray(short[] array)
        {
            Array1NumericUpDown.Value = array[0];
            Array2NumericUpDown.Value = array[1];
            Array3NumericUpDown.Value = array[2];
            Array4NumericUpDown.Value = array[3];
            Array5NumericUpDown.Value = array[4];
            Array6NumericUpDown.Value = array[5];
            Array7NumericUpDown.Value = array[6];
            Array8NumericUpDown.Value = array[7];
            Array9NumericUpDown.Value = array[8];
        }

        public short Intensity
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

        public short Divisor
        {
            get
            {
                return (short)DivisorNumericUpDown.Value;
            }
            set
            {
                DivisorNumericUpDown.Value = value;
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

                proc.Matrix(new short[] { (short)Array1NumericUpDown.Value, (short)Array2NumericUpDown.Value,
                    (short)Array3NumericUpDown.Value, (short)Array4NumericUpDown.Value, 
                    (short)Array5NumericUpDown.Value, (short)Array6NumericUpDown.Value, 
                    (short)Array7NumericUpDown.Value, (short)Array8NumericUpDown.Value, 
                    (short)Array9NumericUpDown.Value }, 
                    (short)DivisorNumericUpDown.Value, (short)IntensityNumericUpDown.Value);

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

        private void DivisorNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            if (DivisorNumericUpDown.Value == 0)
            {
                Helper.ShowBalloonToolTipWarning(
                    DivisorNumericUpDown.Width - Constants.balloonToolTipHorizontalSpacer, 
                    -Constants.balloonToolTipVerticalSpacer, 
                    Constants.tooltipInitialDelay, Constants.tooltipDuration, 
                    Constants.matrixError, Constants.divisorError, DivisorNumericUpDown);
            }
        }
    }
}