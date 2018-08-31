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
    public partial class BlobRemovalForm : ProcessingForm
    {
        private const int groupBoxSpacer = 10;
        private bool mouseDown;

        public BlobRemovalForm()
        {
            InitializeComponent();

            if (imageXView1 != null)
            {
                this.imageXView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseDown);
                this.imageXView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseMove);
                this.imageXView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseUp);
            }
        }

        public short MinimumDensity
        {
            get
            {
                return (short)MinimumDensityNumericUpDown.Value;
            }
            set
            {
                MinimumDensityNumericUpDown.Value = value;
            }
        }

        public int MinimumPixelCount
        {
            get
            {
                return (int)MinimumPixelCountNumericUpDown.Value;
            }
            set
            {
                MinimumPixelCountNumericUpDown.Value = value;
            }
        }

        public void SetMinimumPixelCountMax(int maximum)
        {
            MinimumPixelCountNumericUpDown.Maximum = maximum;
        }

        public int MaximumPixelCount
        {
            get
            {
                return (int)MaximumPixelCountNumericUpDown.Value;
            }
            set
            {
                MaximumPixelCountNumericUpDown.Value = value;
            }
        }

        public void SetMaximumPixelCountMax(int maximum)
        {
            MaximumPixelCountNumericUpDown.Maximum = maximum;
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

                proc.DocumentBlobRemoval(imageXView1.Rubberband.Dimensions, (int)MinimumPixelCountNumericUpDown.Value,
                    (int)MaximumPixelCountNumericUpDown.Value, (short)MinimumDensityNumericUpDown.Value);

                ResultsGroupBox.Visible = true;
                CountOfBlobsFoundValueLabel.Text = proc.CountOfObjectsFound.ToString();
                ImageWasModifiedValueLabel.Text = proc.ImageWasModified.ToString();

                if (CountOfBlobsFoundValueLabel.Right > ImageWasModifiedValueLabel.Right)
                {
                    ResultsGroupBox.Width = CountOfBlobsFoundValueLabel.Right + groupBoxSpacer;
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

        private void imageXView1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;

            imageXView1.Rubberband.Stop();
            imageXView1.Rubberband.Clear();
            imageXView1.Rubberband.Start(e.Location);
        }

        private void imageXView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                imageXView1.Rubberband.Update(e.Location);
            }
        }

        private void imageXView1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}