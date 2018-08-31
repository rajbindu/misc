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
    public partial class CropForm : ProcessingForm
    {
        public CropForm()
        {
            InitializeComponent();

            if (imageXView1 != null)
            {
                this.imageXView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseDown);
                this.imageXView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseMove);
                this.imageXView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseUp);
            }
        }

        private bool mouseDown;

        public void SetLeftMax(int maximum)
        {
            LeftNumericUpDown.Maximum = maximum;
        }

        public void SetTopMax(int maximum)
        {
            TopNumericUpDown.Maximum = maximum;
        }

        public void SetWidthMax(int maximum)
        {
            WidthNumericUpDown.Maximum = maximum;
        }

        public void SetHeightMax(int maximum)
        {
            HeightNumericUpDown.Maximum = maximum;
        }

        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)LeftNumericUpDown.Value, (int)TopNumericUpDown.Value,
                    (int)WidthNumericUpDown.Value, (int)HeightNumericUpDown.Value);
            }
            set
            {
                if (value.Left < LeftNumericUpDown.Maximum)
                {
                    LeftNumericUpDown.Value = value.Left;
                }
                if (value.Top < TopNumericUpDown.Maximum)
                {
                    TopNumericUpDown.Value = value.Top;
                }
                if (value.Width < WidthNumericUpDown.Maximum)
                {
                    WidthNumericUpDown.Value = value.Width;
                }
                if (value.Height < HeightNumericUpDown.Maximum)
                {
                    HeightNumericUpDown.Value = value.Height;
                }
            }
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

            LeftNumericUpDown.Value = imageXView1.Rubberband.Dimensions.Left;
            TopNumericUpDown.Value = imageXView1.Rubberband.Dimensions.Top;
            if (imageXView1.Rubberband.Dimensions.Width > 0)
            {
                WidthNumericUpDown.Value = imageXView1.Rubberband.Dimensions.Width;
            }
            else
            {
                WidthNumericUpDown.Value = WidthNumericUpDown.Maximum - LeftNumericUpDown.Value;
            }
            if (imageXView1.Rubberband.Dimensions.Height > 0)
            {
                HeightNumericUpDown.Value = imageXView1.Rubberband.Dimensions.Height;
            }
            else
            {
                HeightNumericUpDown.Value = HeightNumericUpDown.Maximum - TopNumericUpDown.Value;
            }
        }

        private void imageXView1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;

            imageXView1.Rubberband.Stop();
            imageXView1.Rubberband.Clear();
            imageXView1.Rubberband.Start(e.Location);
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

                if (WidthNumericUpDown.Value == 0)
                {
                    WidthNumericUpDown.Value = WidthNumericUpDown.Maximum;
                }
                if (HeightNumericUpDown.Value == 0)
                {
                    HeightNumericUpDown.Value = HeightNumericUpDown.Maximum;
                }
                proc.Crop(new Rectangle((int)LeftNumericUpDown.Value, (int)TopNumericUpDown.Value,
                    (int)WidthNumericUpDown.Value, (int)HeightNumericUpDown.Value));

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
