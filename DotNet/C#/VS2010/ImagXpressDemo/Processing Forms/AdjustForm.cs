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
    public enum AdjustAction
    {
        AdjustRGB = 0,
        AdjustHSL = 1,
        AdjustColorBalance = 2
    }

    public partial class AdjustForm : ProcessingForm
    {
        private const int groupBoxSpacer = 10;

        public AdjustForm()
        {
            InitializeComponent();
        }

        private void EnableAdjustUI(bool isEnabled)
        {
            AdjustTypeLabel.Visible = AdjustTypeComboBox.Visible = isEnabled;
        }

        private void EnableHslUI(bool isEnabled)
        {
            HueLabel.Visible = HueNumericUpDown.Visible = SaturationLabel.Visible
                = SaturationNumericUpDown.Visible = LuminanceLabel.Visible
                = LuminanceNumericUpDown.Visible = isEnabled;
        }

        private void EnableRgbUI(bool isEnabled)
        {
            RedLabel.Visible = RedNumericUpDown.Visible = GreenLabel.Visible
                = GreenNumericUpDown.Visible = BlueLabel.Visible = BlueNumericUpDown.Visible
                = isEnabled;
        }

        private void EnableColorBalanceUI(bool isEnabled)
        {
            ColorLabel.Visible = ColorNumericUpDown.Visible = isEnabled;
        }

        private void MoveRgbUIIntoView()
        {
            RedLabel.Left = GreenLabel.Left = BlueLabel.Left = HueLabel.Left;
            RedNumericUpDown.Left = GreenNumericUpDown.Left = BlueNumericUpDown.Left = HueNumericUpDown.Left;
        }

        private void MoveColorBalanceUIIntoView()
        {
            ColorLabel.Left = AdjustTypeLabel.Left;
            ColorNumericUpDown.Left = AdjustTypeComboBox.Left;
        }

        private AdjustAction adjustAction;
        public AdjustAction AdjustAction
        {
            get
            {
                return adjustAction;
            }
            set
            {
                adjustAction = value;

                if (adjustAction == AdjustAction.AdjustHSL)
                {
                    this.Text = AdjustGroupBox.Text = Constants.adjustHSLString;
                    EnableHslUI(true);
                    EnableRgbUI(false);
                    EnableAdjustUI(true);
                    EnableColorBalanceUI(false);
                }
                else if (adjustAction == AdjustAction.AdjustRGB)
                {
                    this.Text = AdjustGroupBox.Text = Constants.adjustRGBString;
                    EnableHslUI(false);
                    EnableRgbUI(true);
                    MoveRgbUIIntoView();
                    EnableAdjustUI(true);
                    EnableColorBalanceUI(false);
                }
                else if (adjustAction == AdjustAction.AdjustColorBalance)
                {
                    this.Text = AdjustGroupBox.Text = Constants.adjustColorBalanceString;
                    EnableHslUI(false);
                    EnableRgbUI(true);
                    MoveRgbUIIntoView();
                    EnableAdjustUI(false);
                    EnableColorBalanceUI(true);
                    MoveColorBalanceUIIntoView();

                    SetRGBBounds(Constants.boundaryPercent, -Constants.boundaryPercent);
                }
            }
        }

        private void SetRGBBounds(int maximum, int minimum)
        {
            RedNumericUpDown.Maximum = GreenNumericUpDown.Maximum = BlueNumericUpDown.Maximum = maximum;
            RedNumericUpDown.Minimum = GreenNumericUpDown.Minimum = BlueNumericUpDown.Minimum = minimum;
        }
                
        private void SetHSLBounds(int maximum, int minimum)
        {
            HueNumericUpDown.Maximum = SaturationNumericUpDown.Maximum = LuminanceNumericUpDown.Maximum = maximum;
            HueNumericUpDown.Minimum = SaturationNumericUpDown.Minimum = LuminanceNumericUpDown.Minimum = minimum;
        }

        public short Color
        {
            get
            {
                return (short)ColorNumericUpDown.Value;
            }
            set
            {
                ColorNumericUpDown.Value = value;
            }
        }

        public int Red
        {
            get
            {
                return (int)RedNumericUpDown.Value;
            }
            set
            {
                RedNumericUpDown.Value = value;
            }
        }

        public int Blue
        {
            get
            {
                return (int)BlueNumericUpDown.Value;
            }
            set
            {
                BlueNumericUpDown.Value = value;
            }
        }

        public int Green
        {
            get
            {
                return (int)GreenNumericUpDown.Value;
            }
            set
            {
                GreenNumericUpDown.Value = value;
            }
        }

        public int Hue
        {
            get
            {
                return (int)HueNumericUpDown.Value;
            }
            set 
            {
                HueNumericUpDown.Value = value;
            }
        }

        public int Saturation
        {
            get
            {
                return (int)SaturationNumericUpDown.Value;
            }
            set
            {
                SaturationNumericUpDown.Value = value;
            }
        }

        public int Luminance
        {
            get
            {
                return (int)LuminanceNumericUpDown.Value;
            }
            set
            {
                LuminanceNumericUpDown.Value = value;
            }
        }

        public AdjustType AdjustType
        {
            get
            {
                return (AdjustType)AdjustTypeComboBox.SelectedIndex;
            }
            set
            {
                AdjustTypeComboBox.SelectedIndex = (int)value;
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

                if (adjustAction == AdjustAction.AdjustHSL)
                {
                    proc.AdjustHSL((AdjustType)AdjustTypeComboBox.SelectedIndex,
                        (int)HueNumericUpDown.Value, (int)SaturationNumericUpDown.Value, 
                        (int)LuminanceNumericUpDown.Value);
                }
                else if (adjustAction == AdjustAction.AdjustRGB)
                {
                    proc.AdjustRGB((AdjustType)AdjustTypeComboBox.SelectedIndex, (int)RedNumericUpDown.Value, 
                        (int)GreenNumericUpDown.Value, (int)BlueNumericUpDown.Value);
                }
                else if (adjustAction == AdjustAction.AdjustColorBalance)
                {
                    proc.AdjustColorBalance((short)ColorNumericUpDown.Value, (short)RedNumericUpDown.Value, 
                        (short)GreenNumericUpDown.Value, (short)BlueNumericUpDown.Value);
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

        private void AdjustHSLForm_Load(object sender, System.EventArgs e)
        {
            AdjustGroupBox.Width = AdjustTypeComboBox.Right + groupBoxSpacer;
        }

        private void AdjustTypeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (AdjustTypeComboBox.SelectedIndex == 0)
            {
                SetRGBBounds(Constants.boundaryPercent, -Constants.boundaryPercent);
                SetHSLBounds(Constants.boundaryPercent, -Constants.boundaryPercent);
            }
            else
            {
                if (adjustAction == AdjustAction.AdjustRGB)
                {
                    SetRGBBounds(Constants.boundaryUnits, -Constants.boundaryUnits);
                }
                else if (adjustAction == AdjustAction.AdjustHSL)
                {
                    SetHSLBounds(Constants.boundaryHSLUnits, -Constants.boundaryHSLUnits);
                }
            }
        }
    }
}