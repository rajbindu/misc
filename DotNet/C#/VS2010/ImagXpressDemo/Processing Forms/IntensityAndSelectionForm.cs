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
    public enum IntensityAndSelectionAction
    {
        DocumentDilate = 0,
        DocumentErode = 1,
        Perspective = 2,
        Sharpen = 3,
        Soften = 4,
        Twist = 5,
        Unsharpen = 6
    }

    public partial class IntensityAndSelectionForm : ProcessingForm
    {
        public IntensityAndSelectionForm()
        {
            InitializeComponent();
        }

        private void HideBackgroundColorUI()
        {
            IntensityAndSelectionGroupBox.Width = SelectionComboBox.Right + 10;
        }

        private const int spacer = 10;

        private void MoveBackgroundColorUIIntoView()
        {
            BackgroundColorLabel.Visible = BackgroundColorButton.Visible = true;
            BackgroundColorLabel.Left = SelectionLabel.Left;
            BackgroundColorButton.Left = BackgroundColorLabel.Right + spacer;

            IntensityLabel.Left = SelectionLabel.Left = BackgroundColorButton.Right + 10;
            IntensityNumericUpDown.Left = SelectionComboBox.Left = IntensityLabel.Right + spacer;
            IntensityAndSelectionGroupBox.Width = SelectionComboBox.Right + spacer;
        }

        private IntensityAndSelectionAction intensityAndSelectionAction;
        public IntensityAndSelectionAction IntensityAndSelectionAction
        {
            get
            {
                return intensityAndSelectionAction;
            }
            set
            {
                intensityAndSelectionAction = value;

                SelectionComboBox.Items.Clear();

                switch (value)
                {
                    case IntensityAndSelectionAction.DocumentDilate:
                        {
                            this.Text = IntensityAndSelectionGroupBox.Text = Constants.dilateString;
                            IntensityLabel.Text = Constants.amountString;
                            SelectionLabel.Text = Constants.directionString;
                            IntensityNumericUpDown.Maximum = 500;
                            IntensityNumericUpDown.Minimum = 1;
                            SelectionComboBox.Items.AddRange(new string[] { Constants.allString, 
                                Constants.leftString, Constants.rightString, Constants.upString, 
                                Constants.downString, Constants.leftAndUpString, 
                                Constants.leftAndDownString, Constants.rightAndUpString, 
                                Constants.rightAndDownString});
                            HideBackgroundColorUI();
                            break;
                        }
                    case IntensityAndSelectionAction.DocumentErode:
                        {
                            this.Text = IntensityAndSelectionGroupBox.Text = Constants.erodeString;
                            IntensityLabel.Text = Constants.amountString;
                            SelectionLabel.Text = Constants.directionString;
                            IntensityNumericUpDown.Maximum = 500;
                            IntensityNumericUpDown.Minimum = 1;
                            SelectionComboBox.Items.AddRange(new string[] { Constants.allString, 
                                Constants.leftString, Constants.rightString, Constants.upString, 
                                Constants.downString, Constants.leftAndUpString, 
                                Constants.leftAndDownString, Constants.rightAndUpString, 
                                Constants.rightAndDownString});
                            HideBackgroundColorUI();
                            break;
                        }
                    case IntensityAndSelectionAction.Perspective:
                        {
                            this.Text = IntensityAndSelectionGroupBox.Text = Constants.perspectiveString;
                            IntensityLabel.Text = Constants.percentString;
                            SelectionLabel.Text = Constants.typeString;
                            IntensityNumericUpDown.Maximum = 100;
                            IntensityNumericUpDown.Minimum = 0;
                            SelectionComboBox.Items.AddRange(new string[] { Constants.topToBottomString, Constants.bottomToTopString, Constants.leftToRightString, Constants.rightToLeftString });
                            MoveBackgroundColorUIIntoView();                           
                            break;
                        }
                    case IntensityAndSelectionAction.Sharpen:
                        {
                            this.Text = IntensityAndSelectionGroupBox.Text = Constants.sharpenString;
                            SelectionLabel.Text = Constants.filterString;
                            IntensityNumericUpDown.Maximum = 10;
                            IntensityNumericUpDown.Minimum = 1;
                            SelectionComboBox.Items.AddRange(new string[] {Constants.sharpenFilter1, Constants.sharpenFilter2, Constants.sharpenFilter3 });
                            HideBackgroundColorUI();
                            break;
                        }
                    case IntensityAndSelectionAction.Soften:
                        {
                            this.Text = IntensityAndSelectionGroupBox.Text = Constants.softenString;
                            SelectionLabel.Text = Constants.filterString;
                            IntensityLabel.Text = Constants.blockSizeString;
                            IntensityNumericUpDown.Maximum = 10;
                            IntensityNumericUpDown.Minimum = 1;
                            SelectionComboBox.Items.AddRange(new string[] { Constants.softenFilter0, Constants.softenFilter1, Constants.softenFilter2, Constants.softenFilter3 });
                            HideBackgroundColorUI();
                            break;
                        }
                    case IntensityAndSelectionAction.Twist:
                        {
                            this.Text = IntensityAndSelectionGroupBox.Text = Constants.twistString;
                            IntensityLabel.Text = Constants.blockSizeString;
                            SelectionLabel.Text = Constants.rotationString;
                            IntensityNumericUpDown.Maximum = 63;
                            IntensityNumericUpDown.Minimum = 2;
                            SelectionComboBox.Items.AddRange(new string[] { Constants.rotate90String, Constants.rotate180String, Constants.rotate270String, Constants.rotateRandomString });
                            HideBackgroundColorUI();
                            break;
                        }
                    case IntensityAndSelectionAction.Unsharpen:
                        {
                            this.Text = IntensityAndSelectionGroupBox.Text = Constants.unsharpenString;
                            SelectionLabel.Text = Constants.filterString;
                            IntensityNumericUpDown.Maximum = 10;
                            IntensityNumericUpDown.Minimum = 1;
                            SelectionComboBox.Items.AddRange(new string[] { Constants.unsharpenFilter1, Constants.unsharpenFilter2, Constants.unsharpenFilter3 });
                            HideBackgroundColorUI();
                            break;
                        }
                }
            }
        }

        public short DilateAmount
        {
            get
            {
                return (short)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = value;
            }
        }

        public EnhancementDirection DilateDirection
        {
            get
            {
                return (EnhancementDirection)SelectionComboBox.SelectedIndex;
            }
            set
            {
                SelectionComboBox.SelectedIndex = (int)value;
            }
        }

        public short ErodeAmount
        {
            get
            {
                return (short)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = value;
            }
        }

        public EnhancementDirection ErodeDirection
        {
            get
            {
                return (EnhancementDirection)SelectionComboBox.SelectedIndex;
            }
            set
            {
                SelectionComboBox.SelectedIndex = (int)value;
            }
        }

        public int PerspectivePercent
        {
            get
            {
                return (int)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = value;
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

        public PerspectiveType PerspectiveType
        {
            get
            {
                return (PerspectiveType)SelectionComboBox.SelectedIndex;
            }
            set
            {
                SelectionComboBox.SelectedIndex = (int)value;
            }
        }

        public int TwistBlockSize
        {
            get
            {
                return (int)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = value;
            }
        }

        public TwistRotation TwistRotation
        {
            get
            {
                return (TwistRotation)SelectionComboBox.SelectedIndex;
            }
            set
            {
                SelectionComboBox.SelectedIndex = (int)value;
            }
        }

        public int SharpenIntensity
        {
            get
            {
                return (int)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = value;
            }
        }

        public SharpenFilter SharpenFilter
        {
            get
            {
                return (SharpenFilter)SelectionComboBox.SelectedIndex;
            }
            set
            {
                SelectionComboBox.SelectedIndex = (int)value;
            }
        }

        public int UnsharpenIntensity
        {
            get
            {
                return (int)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = value;
            }
        }

        public UnsharpenFilter UnsharpenFilter
        {
            get
            {
                return (UnsharpenFilter)SelectionComboBox.SelectedIndex;
            }
            set
            {
                SelectionComboBox.SelectedIndex = (int)value;
            }
        }

        public int SoftenIntensity
        {
            get
            {
                return (int)IntensityNumericUpDown.Value;
            }
            set
            {
                IntensityNumericUpDown.Value = value;
            }
        }

        public SoftenFilter SoftenFilter
        {
            get
            {
                return (SoftenFilter)SelectionComboBox.SelectedIndex;
            }
            set
            {
                SelectionComboBox.SelectedIndex = (int)value;
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

                switch (intensityAndSelectionAction)
                {
                    case IntensityAndSelectionAction.DocumentDilate:
                        {
                            proc.DocumentDilate((short)IntensityNumericUpDown.Value, (EnhancementDirection)SelectionComboBox.SelectedIndex);
                            break;
                        }
                    case IntensityAndSelectionAction.DocumentErode:
                        {
                            proc.DocumentErode((short)IntensityNumericUpDown.Value, (EnhancementDirection)SelectionComboBox.SelectedIndex);
                            break;
                        }
                    case IntensityAndSelectionAction.Perspective:
                        {
                            proc.BackgroundColor = BackgroundColorButton.BackColor;
                            proc.Perspective((PerspectiveType)SelectionComboBox.SelectedIndex, (int)IntensityNumericUpDown.Value);
                            break;
                        }
                    case IntensityAndSelectionAction.Sharpen:
                        {
                            proc.Sharpen((int)IntensityNumericUpDown.Value, (SharpenFilter)SelectionComboBox.SelectedIndex);
                            break;
                        }
                    case IntensityAndSelectionAction.Soften:
                        {
                            proc.Soften((int)IntensityNumericUpDown.Value, (SoftenFilter)SelectionComboBox.SelectedIndex);
                            break;
                        }
                    case IntensityAndSelectionAction.Twist:
                        {
                            proc.Twist((int)IntensityNumericUpDown.Value, (TwistRotation)SelectionComboBox.SelectedIndex);
                            break;
                        }
                    case IntensityAndSelectionAction.Unsharpen:
                        {
                            proc.Unsharpen((int)IntensityNumericUpDown.Value, (UnsharpenFilter)SelectionComboBox.SelectedIndex);
                            break;
                        }
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
