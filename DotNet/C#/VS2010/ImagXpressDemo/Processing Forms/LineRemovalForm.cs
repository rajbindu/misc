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
    public partial class LineRemovalForm : ProcessingForm
    {
        private const int groupBoxSpacer = 10;

        public LineRemovalForm()
        {
            InitializeComponent();
        }

        public int MinimumLength
        {
            get
            {
                return (short)MinimumLengthNumericUpDown.Value;
            }
            set
            {
                MinimumLengthNumericUpDown.Value = value;
            }
        }

        public short MaximumThickness
        {
            get
            {
                return (short)MaximumThicknessNumericUpDown.Value;
            }
            set
            {
                MaximumThicknessNumericUpDown.Value = value;
            }
        }

        public double MinimumAspectRatio
        {
            get
            {
                return (double)MinimumAspectRatioNumericUpDown.Value;
            }
            set
            {
                MinimumAspectRatioNumericUpDown.Value = (decimal)value;
            }
        }

        public short MaximumGap
        {
            get
            {
                return (short)MaximumGapNumericUpDown.Value;
            }
            set
            {
                MaximumGapNumericUpDown.Value = value;
            }
        }

        public short MaximumCharacterRepairSize
        {
            get
            {
                return (short)MaximumCharacterRepairSizeNumericUpDown.Value;
            }
            set
            {
                MaximumCharacterRepairSizeNumericUpDown.Value = value;
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

                proc.DocumentLineRemoval((int)MinimumLengthNumericUpDown.Value, (short)MaximumThicknessNumericUpDown.Value, 
                    (double)MinimumAspectRatioNumericUpDown.Value, (short)MaximumGapNumericUpDown.Value, 
                    (short)MaximumCharacterRepairSizeNumericUpDown.Value);

                CountOfLinesFoundValueLabel.Text = proc.CountOfLinesFound.ToString();
                ImageWasModifiedValueLabel.Text = proc.ImageWasModified.ToString();
                ResultsGroupBox.Visible = true;

                if (CountOfLinesFoundValueLabel.Right > ImageWasModifiedValueLabel.Right)
                {
                    ResultsGroupBox.Width = CountOfLinesFoundValueLabel.Right + groupBoxSpacer;
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