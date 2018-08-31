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
    public enum SkewAction
    { 
        Deskew = 0,
        Rotate = 1
    }

    public partial class SkewForm : ProcessingForm
    {
        private const int spacer = 10;

        public SkewForm()
        {
            InitializeComponent();
        }

        private void MoveRotateUIIntoView()
        {
            AngleLabel.Left = DeskewTypeLabel.Left;
            AngleNumericUpDown.Left = AngleLabel.Right + spacer;
        }

        private void EnableDeskewUI(bool isEnabled)
        {
            DeskewTypeLabel.Visible = DeskewTypeComboBox.Visible = isEnabled;
        }

        private void EnableRotateUI(bool isEnabled)
        {
            AngleLabel.Visible = AngleNumericUpDown.Visible = isEnabled;
        }

        private SkewAction skewAction;
        public SkewAction SkewAction
        {
            get
            {
                return skewAction;
            }
            set
            {
                skewAction = value;

                if (skewAction == SkewAction.Deskew)
                {
                    this.Text = SkewGroupBox.Text = Constants.deskewString;
                    SkewGroupBox.Width = DeskewTypeComboBox.Right + spacer;

                    EnableDeskewUI(true);
                    EnableRotateUI(false);
                }
                else if (skewAction == SkewAction.Rotate)
                {
                    this.Text = SkewGroupBox.Text = Constants.rotateString;

                    EnableDeskewUI(false);
                    EnableRotateUI(true);
                    MoveRotateUIIntoView();
                    SkewGroupBox.Width = AngleNumericUpDown.Right + spacer;
                }
            }
        }

        private int bitsPerPixel;
        public int BitsPerPixel
        {
            get
            {
                return bitsPerPixel;
            }
            set
            {
                bitsPerPixel = value;
            }
        }

        public int OneBitBackgroundColor
        {
            get
            {
                return OneBitBackgroundColorComboBox.SelectedIndex;
            }
            set
            {
                OneBitBackgroundColorComboBox.SelectedIndex = value;
            }
        }

        public double Angle
        {
            get
            {
                return (double)AngleNumericUpDown.Value;
            }
            set
            {
                AngleNumericUpDown.Value = (decimal)value;
            }
        }

        public Color BackgroundColor
        {
            get
            {
                return BackgroundColorButton.BackColor;
            }
            set
            {
                BackgroundColorButton.BackColor = value;
            }
        }

        public DeskewType DeskewType
        {
            get
            {
                return (DeskewType)DeskewTypeComboBox.SelectedIndex;
            }
            set
            {
                DeskewTypeComboBox.SelectedIndex = (int)value;
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

                if (bitsPerPixel == 1)
                {
                    if (OneBitBackgroundColorComboBox.SelectedIndex == 0)
                    {
                        proc.BackgroundColor = Color.Black;
                    }
                    else
                    {
                        proc.BackgroundColor = Color.White;
                    }
                }
                else
                {
                    proc.BackgroundColor = BackgroundColorButton.BackColor;
                }

                if (skewAction == SkewAction.Deskew)
                {
                    proc.Deskew((DeskewType)DeskewTypeComboBox.SelectedIndex);
                }
                else if (skewAction == SkewAction.Rotate)
                {
                    proc.Rotate((double)AngleNumericUpDown.Value);
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

        private void DeskewForm_Load(object sender, System.EventArgs e)
        {
            if (bitsPerPixel == 1)
            {
                OneBitBackgroundColorComboBox.Visible = true;
                BackgroundColorButton.Visible = false;
                OneBitBackgroundColorComboBox.Left = BackgroundColorButton.Left;
                int amount = 50;
                if (skewAction == SkewAction.Deskew)
                {
                    DeskewTypeLabel.Left += amount;
                    DeskewTypeComboBox.Left += amount;
                    SkewGroupBox.Width += amount;
                }
                else if (skewAction == SkewAction.Rotate)
                {
                    AngleLabel.Left += amount;
                    AngleNumericUpDown.Left += amount;
                    SkewGroupBox.Width += amount;
                }
            }
            else
            {
                OneBitBackgroundColorComboBox.Visible = false;
                BackgroundColorButton.Visible = true;
            }  
        }

        private void BackgroundColorButton_Click(object sender, System.EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.Color = BackgroundColorButton.BackColor;
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    BackgroundColorButton.BackColor = colorDlg.Color;
                }
            }
        }
    }
}
