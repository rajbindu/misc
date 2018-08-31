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
    public partial class AlphaReduceForm : ProcessingForm
    {
        public AlphaReduceForm()
        {
            InitializeComponent();
        }

        protected override bool PerformProcessingAction()
        {
            Processor proc = null;
            try
            {
                Point currentScrollPosition;
                if (imageXView2.Image == null)
                {
                    currentScrollPosition = imageXView1.ScrollPosition;
                }
                else
                {
                    currentScrollPosition = imageXView2.ScrollPosition;
                }

                proc = new Processor(imagXpress1, imageXView1.Image.Copy());
                outputBitmap = proc.GetAlphaChannelAsBitmap();

                imageXView2.ScrollPosition = currentScrollPosition;

                using (ImageX img = ImageX.FromBitmap(imagXpress1, outputBitmap))
                {
                    UpdateOutputImage(img.Copy());
                }

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
