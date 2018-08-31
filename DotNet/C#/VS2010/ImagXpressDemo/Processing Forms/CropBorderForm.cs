/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System.Windows.Forms;
using System.Drawing;
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public enum CropAction
    {
        CropBorder = 0,
        AutoCrop = 1
    }

    public partial class CropBorderForm : ProcessingForm
    {
        public CropBorderForm()
        {
            InitializeComponent();
        }
        
        private int spacer = 10;

        private void AutoCropUIVisible(bool isVisible)
        {
            LeftLabel.Visible = LeftNumericUpDown.Visible = UpperLeftLabel.Visible 
                        = TopLabel.Visible = TopNumericUpDown.Visible = isVisible;
        }

        private void CropBorderUIVisible(bool isVisible)
        {
            CropTypeLabel.Visible = CropTypeComboBox.Visible 
                = isVisible;
        }

        private void SetGroupBoxSize(Control control)
        {
            CropGroupBox.Width = control.Right + spacer;
            CropGroupBox.Height = control.Bottom + spacer;
        }

        private void MoveAutoCropUIIntoView()
        {
            LeftLabel.Top = LeftNumericUpDown.Top = spacer;
            TopLabel.Top = TopNumericUpDown.Top = LeftLabel.Bottom + spacer;
        }

        private CropAction cropAction;
        public CropAction CropAction
        {
            get
            {
                return cropAction;
            }
            set
            {
                cropAction = value;
                if (cropAction == CropAction.AutoCrop)
                {
                    this.Text = CropGroupBox.Text = Constants.autoCropString;
                    AutoCropUIVisible(true);
                    MoveAutoCropUIIntoView();
                    CropBorderUIVisible(false);
                    SetGroupBoxSize(TopNumericUpDown);
                }
                else if (cropAction == CropAction.CropBorder)
                {
                    this.Text = CropGroupBox.Text = Constants.cropBorderString;
                    AutoCropUIVisible(false);
                    CropBorderUIVisible(true);
                    SetGroupBoxSize(CropTypeComboBox);
                }
            }
        }

        public Point BorderPoint
        {
            get
            {
                return new Point((int)LeftNumericUpDown.Value, (int)TopNumericUpDown.Value);
            }
            set
            {
                if (value.X < LeftNumericUpDown.Maximum)
                {
                    LeftNumericUpDown.Value = value.X;
                }
                if (value.Y < TopNumericUpDown.Maximum)
                {
                    TopNumericUpDown.Value = value.Y;
                }
            }
        }


        public void SetBorderPointMax(Point max)
        {
            LeftNumericUpDown.Maximum = max.X;
            TopNumericUpDown.Maximum = max.Y;
        }

        public float PercentToCrop
        {
            get
            {
                return (float)PercentToCropNumericUpDown.Value;
            }
            set
            {
                PercentToCropNumericUpDown.Value = (decimal)value;
            }
        }

        public CropType CropType
        {
            get
            {
                return (CropType)CropTypeComboBox.SelectedIndex;
            }
            set
            {
                CropTypeComboBox.SelectedIndex = (int)value;
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

                if (cropAction == CropAction.AutoCrop)
                {
                    proc.AutoCrop((float)PercentToCropNumericUpDown.Value / 100, new Point((int)LeftNumericUpDown.Value, (int)TopNumericUpDown.Value));
                }
                else if (cropAction == CropAction.CropBorder)
                {
                    proc.CropBorder((float)PercentToCropNumericUpDown.Value / 100, (CropType)CropTypeComboBox.SelectedIndex);
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
