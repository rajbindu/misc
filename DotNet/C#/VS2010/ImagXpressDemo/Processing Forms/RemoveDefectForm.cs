/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System.Drawing;
using System.Windows.Forms;
using Accusoft.ImagXpressSdk;
using Accusoft.NotateXpressSdk;

namespace ImagXpressDemo
{
    public enum DefectRemovalAction
    {
        RemoveScratches = 0,
        RemoveDust = 1
    }

    public partial class RemoveDefectForm : ProcessingForm
    {
        private NotateXpress notateXpress;
        private bool annotationPresent;

        private const int spacer = 10;

        private bool mouseDown;

        public RemoveDefectForm()
        {
            InitializeComponent();

            if (imageXView1 != null)
            {
                this.imageXView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseDown);
                this.imageXView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseMove);
                this.imageXView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseUp);
            }
        }

        private DefectRemovalAction defectRemovalAction;
        public DefectRemovalAction DefectRemovalAction
        {
            get
            {
                return defectRemovalAction;
            }
            set
            {
                defectRemovalAction = value;

                switch (value)
                {
                    case DefectRemovalAction.RemoveScratches:
                        {
                            this.Text = RemoveDefectGroupBox.Text = Constants.removeScratchesString;
                            
                            StartingPointLabel.Left = EndingPointLabel.Left 
                                = LineWidthLabel.Left 
                                = ThresholdLabel.Left;
                            StartingPointXNumericUpDown.Left = EndingPointXNumericUpDown.Left
                                = LineWidthNumericUpDown.Left
                                = ThresholdNumericUpDown.Left;

                            StartingPointXLabel.Left = StartingPointXNumericUpDown.Left - spacer * 3;
                            EndingPointXLabel.Left = StartingPointXNumericUpDown.Left - spacer * 3;

                            StartingPointYLabel.Left = StartingPointXNumericUpDown.Right + spacer;
                            StartingPointYNumericUpDown.Left = StartingPointYLabel.Right + spacer;
                            
                            EndingPointYLabel.Left = StartingPointYLabel.Left;
                            EndingPointYNumericUpDown.Left = StartingPointYNumericUpDown.Left;

                            RemoveDefectGroupBox.Width = EndingPointYNumericUpDown.Right + spacer;

                            this.MouseLabel.Text = "Please use the mouse to draw a line to remove scratches along.";
                            break;
                        }
                    case DefectRemovalAction.RemoveDust:
                        {
                            this.Text = RemoveDefectGroupBox.Text = Constants.removeDustString;
                            
                            DefectTypeLabel.Top = DefectTypeComboBox.Top = ThresholdLabel.Top;
                            ThresholdLabel.Top = ThresholdNumericUpDown.Top = StartingPointLabel.Top;
                            FilterAdjustmentLabel.Top = FilterAdjustmentNumericUpDown.Top = EndingPointLabel.Top;
                            SmoothingAdjustmentLabel.Top = SmoothingAdjustmentNumericUpDown.Top = LineWidthLabel.Top;

                            RemoveDefectGroupBox.Width = DefectTypeComboBox.Right + spacer;
                            RemoveDefectGroupBox.Height = DefectTypeComboBox.Bottom + spacer;

                            this.MouseLabel.Text = "Please use the mouse to select an area to remove dust from.";
                            break;
                        }
                }
            }
        }

        public Point ScratchStartingPoint
        {
            get
            {
                return new Point((int)StartingPointXNumericUpDown.Value, (int)StartingPointYNumericUpDown.Value);
            }
            set
            {
                StartingPointXNumericUpDown.Value = value.X;
                StartingPointYNumericUpDown.Value = value.Y;
            }
        }

        public void SetScratchPointMax(Point max)
        {
            StartingPointXNumericUpDown.Maximum = EndingPointXNumericUpDown.Maximum = max.X;
            StartingPointYNumericUpDown.Maximum = EndingPointYNumericUpDown.Maximum = max.Y;
        }

        public Point ScratchEndingPoint
        {
            get
            {
                return new Point((int)EndingPointXNumericUpDown.Value, (int)EndingPointYNumericUpDown.Value);
            }
            set
            {
                EndingPointXNumericUpDown.Value = value.X;
                EndingPointYNumericUpDown.Value = value.Y;
            }
        }

        public int ScratchLineWidth
        {
            get
            {
                return (int)LineWidthNumericUpDown.Value;
            }
            set
            {
                LineWidthNumericUpDown.Value = value;
            }
        }

        public void SetSractchLineWidthMax(int maximum)
        {
            LineWidthNumericUpDown.Maximum = maximum;
        }

        public int Threshold
        {
            get
            {
                return (int)ThresholdNumericUpDown.Value;
            }
            set
            {
                ThresholdNumericUpDown.Value = value;
            }
        }

        public int FilterAdjustment
        {
            get
            {
                return (int)FilterAdjustmentNumericUpDown.Value;
            }
            set
            {
                FilterAdjustmentNumericUpDown.Value = value;
            }
        }
        
        public int SmoothingAdjustment
        {
            get
            {
                return (int)SmoothingAdjustmentNumericUpDown.Value;
            }
            set
            {
                SmoothingAdjustmentNumericUpDown.Value = value;
            }
        }

        public DefectType DefectType
        {
            get
            {
                return (DefectType)DefectTypeComboBox.SelectedIndex;
            }
            set
            {
                DefectTypeComboBox.SelectedIndex = (int)value;
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

                switch (defectRemovalAction)
                {
                    case DefectRemovalAction.RemoveScratches:
                        {
                            proc.SetArea(new RectangleF(0, 0, imageXView1.Image.Width, imageXView1.Image.Height));
                            proc.RemoveScratches(
                                new Point((int)StartingPointXNumericUpDown.Value, (int)StartingPointYNumericUpDown.Value),
                                new Point((int)EndingPointXNumericUpDown.Value, (int)EndingPointYNumericUpDown.Value),
                                (int)LineWidthNumericUpDown.Value, (int)ThresholdNumericUpDown.Value,
                                (int)FilterAdjustmentNumericUpDown.Value, (int)SmoothingAdjustmentNumericUpDown.Value,
                                (DefectType)DefectTypeComboBox.SelectedIndex);
                            break;
                        }
                    case DefectRemovalAction.RemoveDust:
                        {
                            if (imageXView1.Rubberband.Dimensions.Width != 0 && imageXView1.Rubberband.Dimensions.Height != 0)
                            {
                                proc.SetArea(imageXView1.Rubberband.Dimensions);
                            }
                            else
                            {
                                proc.SetArea(new RectangleF(0, 0, imageXView1.Image.Width, imageXView1.Image.Height));
                            }
                            proc.RemoveDust((int)ThresholdNumericUpDown.Value,
                                (int)FilterAdjustmentNumericUpDown.Value,
                                (int)SmoothingAdjustmentNumericUpDown.Value,
                                (DefectType)DefectTypeComboBox.SelectedIndex);
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

        private void imageXView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (defectRemovalAction == DefectRemovalAction.RemoveDust)
            {
                mouseDown = true;

                imageXView1.Rubberband.Stop();
                imageXView1.Rubberband.Clear();
                imageXView1.Rubberband.Start(e.Location);
            }
        }

        private void imageXView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (defectRemovalAction == DefectRemovalAction.RemoveDust)
            {
                if (mouseDown)
                {
                    imageXView1.Rubberband.Update(e.Location);
                }
            }
        }

        private void imageXView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (defectRemovalAction == DefectRemovalAction.RemoveDust)
            {
                mouseDown = false;

                if (defectRemovalAction == DefectRemovalAction.RemoveScratches)
                {
                    StartingPointXNumericUpDown.Value = imageXView1.Rubberband.Dimensions.Left;
                    StartingPointYNumericUpDown.Value = imageXView1.Rubberband.Dimensions.Top;
                    EndingPointXNumericUpDown.Value = imageXView1.Rubberband.Dimensions.Right;
                    EndingPointYNumericUpDown.Value = imageXView1.Rubberband.Dimensions.Bottom;
                }
            }
        }

        private void RemoveDefectForm_Load(object sender, System.EventArgs e)
        {
            if (defectRemovalAction == DefectRemovalAction.RemoveScratches)
            {
                notateXpress = new NotateXpress();

                notateXpress.ClientWindow = imageXView1.Handle;
                using (Layer layer = new Layer())
                {
                    notateXpress.Layers.Add(layer);

                    notateXpress.ToolbarDefaults.LineToolbarDefaults.PenFillStyle = PenFillStyle.Translucent;
                    notateXpress.ToolbarDefaults.LineToolbarDefaults.PenWidth = (int)LineWidthNumericUpDown.Value;
                    notateXpress.Layers[0].Toolbar.Selected = AnnotationTool.LineTool;

                    notateXpress.AnnotationAdded += new NotateXpress.AnnotationAddedEventHandler(annotationAdded);
                }
            }
        }

        private void UpdateLineElementFromUI()
        {
            if (notateXpress != null && notateXpress.Layers.Count > 0)
            {
                LineTool lineElement = (LineTool)notateXpress.Layers[0].Elements[0];

                Point[] points = lineElement.GetPoints();
                points[0].X = (int)StartingPointXNumericUpDown.Value;
                points[0].Y = (int)StartingPointYNumericUpDown.Value;
                points[1].X = (int)EndingPointXNumericUpDown.Value;
                points[1].Y = (int)EndingPointYNumericUpDown.Value;

                lineElement.SetPoints(points);

                lineElement.PenWidth = (int)LineWidthNumericUpDown.Value;
                notateXpress.ToolbarDefaults.LineToolbarDefaults.PenWidth = (int)LineWidthNumericUpDown.Value;
            }
        }

        private void annotationAdded(object sender, AnnotationAddedEventArgs e)
        {
            if (annotationPresent == true)
            {
                notateXpress.Layers[0].Elements.RemoveAt(0);
            }

            annotationPresent = true;

            Point[] linePoints = ((LineTool)notateXpress.Layers[0].Elements[0]).GetPoints();
            StartingPointXNumericUpDown.Value = linePoints[0].X;
            StartingPointYNumericUpDown.Value = linePoints[0].Y;
            EndingPointXNumericUpDown.Value = linePoints[1].X;
            EndingPointYNumericUpDown.Value = linePoints[1].Y;
        }

        private void LineWidthNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            UpdateLineElementFromUI();
        }

        private void StartingPointXNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            UpdateLineElementFromUI();
        }

        private void StartingPointYNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            UpdateLineElementFromUI();
        }

        private void EndingPointYNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            UpdateLineElementFromUI();
        }

        private void EndingPointXNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            UpdateLineElementFromUI();
        }
    }
}