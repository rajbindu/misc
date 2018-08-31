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
    public enum RedeyeAction
    {
        Manual = 0,
        Auto = 1
    }

    public partial class RemoveRedeyeForm : ProcessingForm
    {
        private const int heightAdjustment = 20;
        private const int groupBoxAdjustment = 8;

        private const int spacer = 10;

        private bool mouseDown;

        public RemoveRedeyeForm()
        {
            InitializeComponent();

            if (imageXView1 != null)
            {
                this.imageXView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseDown);
                this.imageXView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseMove);
                this.imageXView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseUp);
            }
        }

        private void MoveRectanglesCheckBoxIntoView()
        {
            PrecisionLabel.Top = UseRedEyeRectanglesCheckBox.Top;
            PrecisionComboBox.Top = UseRedEyeRectanglesCheckBox.Top;
        }

        private void MoveAutoUIIntoView()
        {
            RemoveRedEyeGroupBox.Left = MouseLabel.Left;

            RedEyesListView.Left = RemoveRedEyeGroupBox.Right + spacer;
        }

        private void EnableAutoUI(bool isEnabled)
        {
            RedEyesListView.Visible = UseRedEyeRectanglesCheckBox.Visible = isEnabled;
        }

        private void EnableManualUI(bool isEnabled)
        {
            PrecisionLabel.Visible = PrecisionComboBox.Visible = MouseLabel.Visible = isEnabled;
        }

        private RedeyeAction redEyeAction;
        public RedeyeAction RedEyeAction
        {
            get
            {
                return redEyeAction;
            }
            set
            {
                redEyeAction = value;

                if (redEyeAction == RedeyeAction.Auto)
                {
                    this.Text = RemoveRedEyeGroupBox.Text = Constants.autoRemoveRedEyeString;

                    MoveAutoUIIntoView();
                    EnableAutoUI(true);
                    EnableManualUI(false);
                }
                else if (redEyeAction == RedeyeAction.Manual)
                {
                    this.Text = RemoveRedEyeGroupBox.Text = Constants.removeRedEyeString;

                    EnableAutoUI(false);
                    EnableManualUI(true);
                    MoveRectanglesCheckBoxIntoView();
                }
            }
        }

        public bool UseRedeyeRectangles
        {
            get
            {
                return UseRedEyeRectanglesCheckBox.Checked;
            }
            set
            {
                UseRedEyeRectanglesCheckBox.Checked = value;
            }
        }

        public RedeyePrecision Precision
        {
            get
            {
                return (RedeyePrecision)PrecisionComboBox.SelectedIndex;
            }
            set
            {
                PrecisionComboBox.SelectedIndex = (int)value;
            }
        }

        public RedeyeGlare Glare
        {
            get
            {
                return (RedeyeGlare)GlareComboBox.SelectedIndex;
            }
            set
            {
                GlareComboBox.SelectedIndex = (int)value;
            }
        }

        public RedeyeShade Shade
        {
            get
            {
                return (RedeyeShade)ShadeComboBox.SelectedIndex;
            }
            set
            {
                ShadeComboBox.SelectedIndex = (int)value;
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

                if (redEyeAction == RedeyeAction.Auto)
                {
                    proc.AutoRemoveRedeye((RedeyeShade)ShadeComboBox.SelectedIndex,
                        (RedeyeGlare)GlareComboBox.SelectedIndex, UseRedEyeRectanglesCheckBox.Checked);

                    RedEyesListView.Items.Clear();
                    foreach (RedeyeRectangle rect in proc.Redeyes)
                    {
                        RedEyesListView.Items.Add(new ListViewItem(new string[]{rect.Xposition.ToString(), 
                            rect.Yposition.ToString(), rect.Width.ToString(), rect.Height.ToString(), 
                            rect.Confidence.ToString()}));
                    }
                }
                else if (redEyeAction == RedeyeAction.Manual)
                {
                    if (imageXView1.Rubberband.Dimensions.Width != 0 && imageXView1.Rubberband.Dimensions.Height != 0)
                    {
                        proc.SetArea(imageXView1.Rubberband.Dimensions);
                    }
                    else
                    {
                        proc.SetArea(new RectangleF(0, 0, imageXView1.Image.Width, imageXView1.Image.Height));
                    }
                    proc.RemoveRedeye((RedeyePrecision)PrecisionComboBox.SelectedIndex,
                        (RedeyeShade)ShadeComboBox.SelectedIndex, (RedeyeGlare)GlareComboBox.SelectedIndex);
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

        private void imageXView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (redEyeAction == RedeyeAction.Manual)
            {
                mouseDown = true;

                imageXView1.Rubberband.Stop();
                imageXView1.Rubberband.Clear();
                imageXView1.Rubberband.Start(e.Location);
            }
        }

        private void imageXView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (redEyeAction == RedeyeAction.Manual)
            {
                if (mouseDown)
                {
                    imageXView1.Rubberband.Update(e.Location);
                }
            }
        }

        private void imageXView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (redEyeAction == RedeyeAction.Manual)
            {
                mouseDown = false;
            }
        }
    }
}