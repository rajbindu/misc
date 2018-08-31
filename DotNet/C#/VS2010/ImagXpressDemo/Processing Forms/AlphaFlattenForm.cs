/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;
using System.Drawing;
using System.Windows.Forms;

namespace ImagXpressDemo
{
    public partial class AlphaFlattenForm : ProcessingForm
    {
        public AlphaFlattenForm()
        {
            InitializeComponent();
        }

        public Color FlattenColor
        {
            get
            {
                return ColorButton.BackColor;
            }
            set
            {
                ColorButton.BackColor = value;
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

                proc.AlphaFlatten(ColorButton.BackColor);

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

        private void ColorButton_Click(object sender, System.EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.Color = ColorButton.BackColor;
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    ColorButton.BackColor = colorDlg.Color;
                }
            }
        }
    }
}