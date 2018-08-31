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
    public enum ChannelSelection
    {
        Red = 0,
        Green = 1,
        Blue = 2,
        RGB = 3
    }

    public partial class HistogramForm : Form
    {
        public HistogramForm()
        {
            InitializeComponent();
        }

        private const int histogramSize = 256;

        private int[] redValues = new int[histogramSize];
        private int[] greenValues = new int[histogramSize];
        private int[] blueValues = new int[histogramSize];

        private int maximumRedValue;
        private int maximumGreenValue;
        private int maximumBlueValue;

        private ImageX image;
        public ImageX Image
        {
            set
            {
                image = value;
            }
        }

        public ChannelSelection ChannelSelection
        {
            get
            {
                return (ChannelSelection)ChannelComboBox.SelectedIndex;
            }
            set
            {
                ChannelComboBox.SelectedIndex = (int)value;
            }
        }

        private int FindMaximumValue(int[] values)
        {
            int maximumValue = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > maximumValue)
                {
                    maximumValue = values[i];
                }
            }

            return maximumValue;
        }

        private void HistogramForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                using (ImagXpress imagXpress = new ImagXpress())
                {
                    using (Processor processor = new Processor(imagXpress, image))
                    {
                        Helper.TransformIfGrayscale(processor.Image);
                        processor.RGBColorCount(out redValues, out greenValues, out blueValues);
                    }
                }
            }
            catch (ProcessorException ex)
            {
                MessageBox.Show(ex.Message, Constants.processingErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            maximumRedValue = FindMaximumValue(redValues);
            maximumGreenValue = FindMaximumValue(greenValues);
            maximumBlueValue = FindMaximumValue(blueValues);
        }

        private int HistogramValue(int index, int[] data, int maximumValue)
        {
            return HistogramPictureBox.Height - (int)(((double)data[index] / maximumValue) * (HistogramPictureBox.Height - 1));
        }

        private void PlotHistogram(int maximumValue, int[] values, Color color, Graphics g)
        {
            using (Pen pen = new Pen(color))
            {
                for (int histogramIndex = 0; histogramIndex < values.Length; histogramIndex++)
                {
                    g.DrawLine(pen, new Point(histogramIndex, HistogramPictureBox.Height),
                        new Point(histogramIndex, HistogramValue(histogramIndex, values, maximumValue)));
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch (ChannelComboBox.SelectedIndex)
            {
                case 0:
                    {
                        PlotHistogram(maximumRedValue, redValues, Color.Red, e.Graphics);
                        break;
                    }
                case 1:
                    {
                        PlotHistogram(maximumGreenValue, greenValues, Color.Green, e.Graphics);
                        break;
                    }
                case 2:
                    {
                        PlotHistogram(maximumBlueValue, blueValues, Color.Blue, e.Graphics);
                        break;
                    }
                case 3:
                    {
                        PlotHistogram(maximumRedValue, redValues, Color.Black, e.Graphics);
                        PlotHistogram(maximumGreenValue, greenValues, Color.Black, e.Graphics);
                        PlotHistogram(maximumBlueValue, blueValues, Color.Black, e.Graphics);
                        break;
                    }
            }
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ChannelComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            HistogramPictureBox.Invalidate();
            PositionLabel.Text = String.Empty;
        }

        private void HistogramPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            switch (ChannelComboBox.SelectedIndex)
            {
                case 0:
                    {
                        PositionLabel.Text = String.Format(Constants.histogramLocationString, e.X, redValues[e.X]);
                        break;
                    }
                case 1:
                    {
                        PositionLabel.Text = String.Format(Constants.histogramLocationString, e.X, greenValues[e.X]);
                        break;
                    }
                case 2:
                    {
                        PositionLabel.Text = String.Format(Constants.histogramLocationString, e.X, blueValues[e.X]);
                        break;
                    }
                case 3:
                    {
                        PositionLabel.Text = String.Format(Constants.histogramLocationString, e.X, 
                            redValues[e.X] + greenValues[e.X] + blueValues[e.X]);
                        break;
                    }
            }
        }

        private void HistogramPictureBox_MouseLeave(object sender, EventArgs e)
        {
            PositionLabel.Text = String.Empty;
        }
    }
}