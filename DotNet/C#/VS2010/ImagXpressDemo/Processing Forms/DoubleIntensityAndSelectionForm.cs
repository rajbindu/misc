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
    public enum DoubleIntensityAction
    {
        AdjustLightness = 0,
        Buttonize = 1,
        DocumentDespeckle = 2,
        Noise = 3,
        Parabolic = 4,
        Ripple = 5,
        Tile = 6
    }

    public partial class DoubleIntensityAndSelectionForm : ProcessingForm
    {
        public const int verticalAdjustment = 20;
        public const int widthExpansion = 10;

        public DoubleIntensityAndSelectionForm()
        {
            InitializeComponent();
        }

        private void HideSelectionUI()
        {
            SelectionLabel.Visible = SelectionComboBox.Visible = false;
            Intensity2Label.Top = Intensity2NumericUpDown.Top = IntensityLabel.Top;
            IntensityLabel.Top = IntensityNumericUpDown.Top = SelectionLabel.Top;
            DoubleIntensityAndSelectionGroupBox.Height -= (SelectionLabel.Height + verticalAdjustment);
            this.Height -= (SelectionLabel.Height + verticalAdjustment);
        }

        private DoubleIntensityAction doubleIntensityAction;
        public DoubleIntensityAction DoubleIntensityAction
        {
            get
            {
                return doubleIntensityAction;
            }
            set
            {
                doubleIntensityAction = value;

                switch (value)
                {
                    case DoubleIntensityAction.AdjustLightness:
                        {
                            this.Text = DoubleIntensityAndSelectionGroupBox.Text = Constants.adjustLightnessString;
                            IntensityLabel.Text = Constants.shadowsString;
                            IntensityNumericUpDown.Maximum = 100;
                            IntensityNumericUpDown.Minimum = 0;
                            Intensity2Label.Text = Constants.highlightsString;
                            Intensity2NumericUpDown.Maximum = 100;
                            Intensity2NumericUpDown.Minimum = 0;

                            HideSelectionUI();
                            break;
                        }
                    case DoubleIntensityAction.Buttonize:
                        {
                            this.Text = DoubleIntensityAndSelectionGroupBox.Text = Constants.buttonizeString;
                            SelectionLabel.Text = Constants.styleString;
                            IntensityNumericUpDown.Maximum = 100;
                            IntensityNumericUpDown.Minimum = 1;
                            Intensity2Label.Text = Constants.widthString;
                            Intensity2NumericUpDown.Maximum = Int32.MaxValue;
                            Intensity2NumericUpDown.Minimum = 0;
                            SelectionComboBox.Items.AddRange(new string[] { Constants.insetString, Constants.raisedString });                            
                            break;
                        }
                    case DoubleIntensityAction.DocumentDespeckle:
                        {
                            this.Text = DoubleIntensityAndSelectionGroupBox.Text = Constants.despeckleString;
                            IntensityLabel.Text = Constants.widthString;
                            IntensityNumericUpDown.Maximum = 100;
                            IntensityNumericUpDown.Minimum = 1;
                            Intensity2Label.Text = Constants.heightString;
                            Intensity2NumericUpDown.Maximum = 100;
                            Intensity2NumericUpDown.Minimum = 1;

                            HideSelectionUI();
                            break;
                        }
                    case DoubleIntensityAction.Noise:
                        {
                            this.Text = DoubleIntensityAndSelectionGroupBox.Text = Constants.noiseString;
                            IntensityNumericUpDown.Maximum = 255;
                            IntensityNumericUpDown.Minimum = 1;
                            Intensity2Label.Text = Constants.frequencyString;
                            Intensity2NumericUpDown.Maximum = 20;
                            Intensity2NumericUpDown.Minimum = 1;

                            HideSelectionUI();
                            break;
                        }
                    case DoubleIntensityAction.Parabolic:
                        {
                            this.Text = DoubleIntensityAndSelectionGroupBox.Text = Constants.parabolicString;
                            SelectionLabel.Text = Constants.typeString;
                            SelectionComboBox.Items.AddRange(new string[] { Constants.convexString, Constants.concaveString });

                            IntensityLabel.Visible = IntensityNumericUpDown.Visible 
                                = Intensity2Label.Visible = Intensity2NumericUpDown.Visible 
                                = false;

                            DoubleIntensityAndSelectionGroupBox.Height -= (IntensityLabel.Height + Intensity2Label.Height + verticalAdjustment*2);
                            this.Height -= (IntensityLabel.Height + Intensity2Label.Height + verticalAdjustment*2);
                            break;
                        }
                    case DoubleIntensityAction.Ripple:
                        {
                            this.Text = DoubleIntensityAndSelectionGroupBox.Text = Constants.rippleString;
                            SelectionLabel.Text = Constants.directionString;
                            IntensityNumericUpDown.Maximum = 100;
                            IntensityNumericUpDown.Minimum = -100;
                            Intensity2Label.Text = Constants.frequencyString;
                            Intensity2NumericUpDown.Maximum = 100;
                            Intensity2NumericUpDown.Minimum = 1;
                            SelectionComboBox.Items.AddRange(new string[] { Constants.horizontalString, Constants.verticalString, Constants.bothString });     
                            break;
                        }
                    case DoubleIntensityAction.Tile:
                        {
                            this.Text = DoubleIntensityAndSelectionGroupBox.Text = Constants.tileString;
                            IntensityLabel.Text = Constants.widthString;
                            IntensityNumericUpDown.Maximum = Int32.MaxValue;
                            IntensityNumericUpDown.Minimum = 0;
                            Intensity2Label.Text = Constants.heightString;
                            Intensity2NumericUpDown.Maximum = Int32.MaxValue;
                            Intensity2NumericUpDown.Minimum = 0;

                            HideSelectionUI();
                            break;
                        }
                }
            }
        }

        public short DespeckleWidth
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

        public short DespeckleHeight
        {
            get
            {
                return (short)Intensity2NumericUpDown.Value;
            }
            set
            {
                Intensity2NumericUpDown.Value = value;
            }
        }

        private void ExpandNumericUpDownControl(int value, NumericUpDown control)
        {
            string valueString = value.ToString();
            if (valueString.Length > 4)
            {
                control.Width += widthExpansion;                
            }
        }

        public Size TileSize
        {
            get
            {
                return new Size((int)IntensityNumericUpDown.Value, (int)Intensity2NumericUpDown.Value);
            }
            set
            {
                IntensityNumericUpDown.Value = value.Width;
                Intensity2NumericUpDown.Value = value.Height;

                ExpandNumericUpDownControl(value.Width, IntensityNumericUpDown);
                ExpandNumericUpDownControl(value.Height, Intensity2NumericUpDown);
            }
        }

        public short AdjustLightnessShadows
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

        public short AdjustLightnessHighlights
        {
            get
            {
                return (short)Intensity2NumericUpDown.Value;
            }
            set
            {
                Intensity2NumericUpDown.Value = value;
            }
        }

        public ParabolicType ParabolicType
        {
            get
            {
                return (ParabolicType)SelectionComboBox.SelectedIndex;
            }
            set
            {
                SelectionComboBox.SelectedIndex = (int)value;
            }
        }

        public int NoiseIntensity
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

        public int NoiseFrequency
        {
            get
            {
                return (int)Intensity2NumericUpDown.Value;
            }
            set
            {
                Intensity2NumericUpDown.Value = value;
            }
        }

        public RippleDirection RippleDirection
        {
            get
            {
                return (RippleDirection)SelectionComboBox.SelectedIndex;
            }
            set
            {
                SelectionComboBox.SelectedIndex = (int)value;
            }
        }

        public int RippleIntensity
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

        public int RippleFrequency
        {
            get
            {
                return (int)Intensity2NumericUpDown.Value;
            }
            set
            {
                Intensity2NumericUpDown.Value = value;
            }
        }

        public ButtonStyle ButtonStyle
        {
            get
            {
                return (ButtonStyle)SelectionComboBox.SelectedIndex;
            }
            set
            {
                SelectionComboBox.SelectedIndex = (int)value;
            }
        }

        public int BevelIntensity
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

        public int BevelWidth
        {
            get
            {
                return (int)Intensity2NumericUpDown.Value;
            }
            set
            {
                Intensity2NumericUpDown.Value = value;
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

                switch (doubleIntensityAction)
                {
                    case DoubleIntensityAction.AdjustLightness:
                        {
                            proc.AdjustLightness((short)IntensityNumericUpDown.Value, (short)Intensity2NumericUpDown.Value);
                            break;
                        }
                    case DoubleIntensityAction.Buttonize:
                        {
                            proc.Buttonize((ButtonStyle)SelectionComboBox.SelectedIndex,
                                (int)Intensity2NumericUpDown.Value, (int)IntensityNumericUpDown.Value);
                            break;
                        }
                    case DoubleIntensityAction.DocumentDespeckle:
                        {
                            proc.DocumentDespeckle((short)IntensityNumericUpDown.Value, (short)Intensity2NumericUpDown.Value);

                            CountOfSpecksFoundValueLabel.Text = proc.CountOfSpecsFound.ToString();
                            ImageWasModifiedValueLabel.Text = proc.ImageWasModified.ToString();

                            if (CountOfSpecksFoundValueLabel.Right > ImageWasModifiedValueLabel.Right)
                            {
                                ResultsGroupBox.Width = CountOfSpecksFoundValueLabel.Right + widthExpansion;
                            }
                            else
                            {
                                ResultsGroupBox.Width = ImageWasModifiedValueLabel.Right + widthExpansion;
                            }

                            ResultsGroupBox.Visible = true;
                            CountOfSpecksFoundLabel.Top = IntensityLabel.Top;
                            CountOfSpecksFoundValueLabel.Top = IntensityNumericUpDown.Top;
                            ImageWasModifiedLabel.Top = Intensity2Label.Top;
                            ImageWasModifiedValueLabel.Top = Intensity2NumericUpDown.Top;
                            ResultsGroupBox.Height = DoubleIntensityAndSelectionGroupBox.Height;
                            break;
                        }
                    case DoubleIntensityAction.Noise:
                        {
                            proc.Noise((int)Intensity2NumericUpDown.Value, (int)IntensityNumericUpDown.Value);
                            break;
                        }
                    case DoubleIntensityAction.Parabolic:
                        {
                            proc.Parabolic((ParabolicType)SelectionComboBox.SelectedIndex);
                            break;
                        }
                    case DoubleIntensityAction.Ripple:
                        {
                            proc.Ripple((int)Intensity2NumericUpDown.Value, (int)IntensityNumericUpDown.Value, 
                                (RippleDirection)SelectionComboBox.SelectedIndex);
                            break;
                        }
                    case DoubleIntensityAction.Tile:
                        {
                            proc.Tile(new Size((int)IntensityNumericUpDown.Value, (int)Intensity2NumericUpDown.Value));
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
    }
}