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
    public partial class DeskewForm : ProcessingForm
    {
        private const int groupBoxSpacer = 10;

        public DeskewForm()
        {
            InitializeComponent();
        }

        public double MinimumAngle
        {
            get
            {
                return (double)MinimumAngleNumericUpDown.Value;
            }
            set
            {
                MinimumAngleNumericUpDown.Value = (decimal)value;
            }
        }

        public short MinimumConfidence
        {
            get
            {
                return (short)MinimumConfidenceNumericUpDown.Value;
            }
            set
            {
                MinimumConfidenceNumericUpDown.Value = value;
            }
        }

        public Color PadColor
        {
            get
            {
                if (PadColorComboBox.SelectedIndex == 0)
                {
                    return Color.Black;
                }
                else
                {
                    return Color.White;
                }
            }
            set
            {
                if (value == Color.Black)
                {
                    PadColorComboBox.SelectedIndex = 0;
                }
                else
                {
                    PadColorComboBox.SelectedIndex = 1;
                }
            }
        }

        public bool MaintainOriginalSize
        {
            get
            {
                return MaintainOriginalizSizeCheckBox.Checked;
            }
            set
            {
                MaintainOriginalizSizeCheckBox.Checked = value;
            }
        }

        public short Quality
        {
            get
            {
                return (short)QualityNumericUpDown.Value;
            }
            set
            {
                QualityNumericUpDown.Value = value;
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

                Color padColor;
                if (PadColorComboBox.SelectedIndex == 0)
                {
                    padColor = Color.Black;
                }
                else
                {
                    padColor = Color.White;
                }

                proc.DocumentDeskew((double)MinimumAngleNumericUpDown.Value, 
                    (short)MinimumConfidenceNumericUpDown.Value, padColor, 
                    MaintainOriginalizSizeCheckBox.Checked, (short)QualityNumericUpDown.Value);
                
                ResultsGroupBox.Visible = true;
                RotationAngleValueLabel.Text = proc.RotationAngle.ToString();
                ConfidenceValueLabel.Text = proc.Confidence.ToString();
                VariationValueLabel.Text = proc.Variation.ToString();
                ImageWasModifiedValueLabel.Text = proc.ImageWasModified.ToString();

                if (RotationAngleValueLabel.Right > ImageWasModifiedValueLabel.Right)
                {
                    ResultsGroupBox.Width = RotationAngleValueLabel.Right + groupBoxSpacer;
                }
                else
                {
                    ResultsGroupBox.Width = ImageWasModifiedValueLabel.Right + groupBoxSpacer;
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