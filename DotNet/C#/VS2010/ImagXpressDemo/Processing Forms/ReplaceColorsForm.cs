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
    public partial class ReplaceColorsForm : ProcessingForm
    {
        public ReplaceColorsForm()
        {
            InitializeComponent();
        }

        public Color FromColor
        {
            get
            {
                return FromColorButton.BackColor;
            }
            set
            {
                FromColorButton.BackColor = value;
            }
        }

        public Color ToColor
        {
            get
            {
                return ToColorButton.BackColor;
            }
            set
            {
                ToColorButton.BackColor = value;
            }
        }

        public Color ReplaceColor
        {
            get
            {
                return ReplaceColorButton.BackColor;
            }
            set
            {
                ReplaceColorButton.BackColor = value;
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

                proc.ReplaceColors(FromColorButton.BackColor, ToColorButton.BackColor, ReplaceColorButton.BackColor);

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

        private static void UpdateColor(Button ColorButton)
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

        private void ReplaceColorButton_Click(object sender, System.EventArgs e)
        {
            UpdateColor(ReplaceColorButton);
        }

        private void ToColorButton_Click(object sender, System.EventArgs e)
        {
            UpdateColor(ToColorButton);
        }

        private void FromColorButton_Click(object sender, System.EventArgs e)
        {
            UpdateColor(FromColorButton);
        }   
    }
}