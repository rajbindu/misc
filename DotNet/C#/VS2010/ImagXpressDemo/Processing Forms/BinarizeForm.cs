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
    public partial class BinarizeForm : ProcessingForm
    {
        public BinarizeForm()
        {
            InitializeComponent();
        }

        public BinarizeMode Mode
        {
            get
            {
                return (BinarizeMode)ModeComboBox.SelectedIndex;
            }
            set
            {
                ModeComboBox.SelectedIndex = (int)value;
            }
        }

        public int LowThreshold
        {
            get
            {
                return (int)LowThresholdNumericUpDown.Value;
            }
            set
            {
                LowThresholdNumericUpDown.Value = value;
            }
        }

        public int HighThreshold
        {
            get
            {
                return (int)HighThresholdNumericUpDown.Value;
            }
            set
            {
                HighThresholdNumericUpDown.Value = value;
            }
        }

        public int GridAngle
        {
            get
            {
                return (int)GridAngleNumericUpDown.Value;
            }
            set
            {
                GridAngleNumericUpDown.Value = value;
            }
        }

        public int GridPitch
        {
            get
            {
                return (int)GridPitchNumericUpDown.Value;
            }
            set
            {
                GridPitchNumericUpDown.Value = value;
            }
        }

        public int Eccentricity
        {
            get
            {
                return (int)EccentricityNumericUpDown.Value;
            }
            set
            {
                EccentricityNumericUpDown.Value = value;
            }
        }

        public int LceFactor
        {
            get
            {
                return (int)LceFactorNumericUpDown.Value;
            }
            set
            {
                LceFactorNumericUpDown.Value = value;
            }
        }

        public BinarizeBlur Blur
        {
            get
            {
                return (BinarizeBlur)BlurComboBox.SelectedIndex;
            }
            set
            {
                BlurComboBox.SelectedIndex = (int)value;
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

                proc.Binarize((BinarizeMode)ModeComboBox.SelectedIndex, (int)LowThresholdNumericUpDown.Value,
                    (int)HighThresholdNumericUpDown.Value, (int)GridAngleNumericUpDown.Value,
                    (int)GridPitchNumericUpDown.Value, (int) EccentricityNumericUpDown.Value,
                    (int)LceFactorNumericUpDown.Value, (BinarizeBlur)BlurComboBox.SelectedIndex);

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

        private void ModeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ModeComboBox.SelectedIndex == 0)
            {
                HighThresholdNumericUpDown.Enabled = LowThresholdNumericUpDown.Enabled = true;
                GridAngleNumericUpDown.Enabled = GridPitchNumericUpDown.Enabled = EccentricityNumericUpDown.Enabled = false;
            }
            else if (ModeComboBox.SelectedIndex == 1)
            {
                GridAngleNumericUpDown.Enabled = GridPitchNumericUpDown.Enabled = EccentricityNumericUpDown.Enabled = true;
                HighThresholdNumericUpDown.Enabled = LowThresholdNumericUpDown.Enabled = false;
            }
            else
            {
                HighThresholdNumericUpDown.Enabled = LowThresholdNumericUpDown.Enabled = false;
                GridAngleNumericUpDown.Enabled = GridPitchNumericUpDown.Enabled = EccentricityNumericUpDown.Enabled = false;
            }
        }

        private void HighThresholdNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            if (HighThresholdNumericUpDown.Value < LowThresholdNumericUpDown.Value)
            {
                Helper.ShowBalloonToolTipWarning(
                    HighThresholdNumericUpDown.Width - Constants.balloonToolTipHorizontalSpacer, 
                    -Constants.balloonToolTipVerticalSpacer, Constants.tooltipInitialDelay, 
                    Constants.tooltipDuration, Constants.binarizeError, Constants.highThresholdError, 
                    HighThresholdNumericUpDown);
            }
        }

        private void LowThresholdNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            if (LowThresholdNumericUpDown.Value > HighThresholdNumericUpDown.Value)
            {
                Helper.ShowBalloonToolTipWarning(
                    LowThresholdNumericUpDown.Width - Constants.balloonToolTipHorizontalSpacer,
                    -Constants.balloonToolTipVerticalSpacer, Constants.tooltipInitialDelay,
                    Constants.tooltipDuration, Constants.binarizeError, Constants.lowThresholdError, 
                    LowThresholdNumericUpDown);
            
            }
        }
    }
}