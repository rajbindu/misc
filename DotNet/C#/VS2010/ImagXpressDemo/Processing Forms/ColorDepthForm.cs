/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class ColorDepthForm : ProcessingForm
    {
        public ColorDepthForm()
        {
            InitializeComponent();
        }

        public int Bpp
        {
            get
            {
                return GetBpp();
            }
            set
            {
                switch (value)
                {
                    case 1:
                        {
                            BitsPerPixelComboBox.SelectedIndex = 0;
                            break;
                        }
                    case 4:
                        {
                            BitsPerPixelComboBox.SelectedIndex = 1;
                            break;
                        }
                    case 8:
                        {
                            BitsPerPixelComboBox.SelectedIndex = 2;
                            break;
                        }
                    case 24:
                        {
                            BitsPerPixelComboBox.SelectedIndex = 3;
                            break;
                        }
                }
            }
        }

        public PaletteType PaletteType
        {
            get
            {
                return (PaletteType)PaletteTypeComboBox.SelectedIndex;
            }
            set
            {
                PaletteTypeComboBox.SelectedIndex = (int)value;
            }
        }
       
        public DitherType DitherType
        {
            get
            {
                return (DitherType)DitherTypeComboBox.SelectedIndex;
            }
            set
            {
                DitherTypeComboBox.SelectedIndex = (int)value;
            }
        }

        private int GetBpp()
        {
            switch (BitsPerPixelComboBox.SelectedIndex)
            {
                default:
                case 0:
                    {
                        return 1;
                    }
                case 1:
                    {
                        return 4;
                    }
                case 2:
                    {
                        return 8;
                    }
                case 3:
                    {
                        return 24;
                    }
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

                proc.ColorDepth(GetBpp(), (PaletteType)PaletteTypeComboBox.SelectedIndex, (DitherType)DitherTypeComboBox.SelectedIndex);

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

        private void BitsPerPixelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ditherSelectedIndex = DitherTypeComboBox.SelectedIndex;
            DitherTypeComboBox.Items.Clear();

            //DitherType's BinarizeQuickText and HalfTone only apply when changing color depth to be 1bpp
            if (BitsPerPixelComboBox.SelectedIndex == 0)
            {
                DitherTypeComboBox.Items.AddRange(new string[] { Constants.noDitherString, Constants.floydString, 
                    Constants.pegasusString, Constants.binarizeQuickTextString, Constants.binarizeHalfToneString });
            }
            else
            {
                DitherTypeComboBox.Items.AddRange(new string[] { Constants.noDitherString, Constants.floydString, 
                    Constants.pegasusString });
            }

            //reset dither selection if possible
            if (ditherSelectedIndex < DitherTypeComboBox.Items.Count)
            {
                DitherTypeComboBox.SelectedIndex = ditherSelectedIndex;
            }
            else
            {
                DitherTypeComboBox.SelectedIndex = 0;
            }
        }
    }
}