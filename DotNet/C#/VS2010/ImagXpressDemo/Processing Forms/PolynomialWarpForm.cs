/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImagXpressDemo
{
    public partial class PolynomialWarpForm : ProcessingForm
    {
        public PolynomialWarpForm()
        {
            InitializeComponent();
        }

        public Point Point1
        {
            get
            {
                return new Point((int)Point1XNumericUpDown.Value, (int)Point1YNumericUpDown.Value);
            }
            set
            {
                if (value.X <= Point1XNumericUpDown.Maximum && value.Y <= Point1YNumericUpDown.Maximum)
                {
                    Point1XNumericUpDown.Value = value.X;
                    Point1YNumericUpDown.Value = value.Y;
                }
            }
        }

        public void SetPointMax(Point max)
        {
            Point1XNumericUpDown.Maximum = Point2XNumericUpDown.Maximum
                = Point3XNumericUpDown.Maximum = Point4XNumericUpDown.Maximum
                = max.X;
            Point1YNumericUpDown.Maximum = Point2YNumericUpDown.Maximum
                = Point3YNumericUpDown.Maximum = Point4YNumericUpDown.Maximum
                = max.Y;
        }

        public Point Point2
        {
            get
            {
                return new Point((int)Point2XNumericUpDown.Value, (int)Point2YNumericUpDown.Value);
            }
            set
            {
                if (value.X <= Point2XNumericUpDown.Maximum && value.Y <= Point2YNumericUpDown.Maximum)
                {
                    Point2XNumericUpDown.Value = value.X;
                    Point2YNumericUpDown.Value = value.Y;
                }
            }
        }

        public Point Point3
        {
            get
            {
                return new Point((int)Point3XNumericUpDown.Value, (int)Point3YNumericUpDown.Value);
            }
            set
            {
                if (value.X <= Point3XNumericUpDown.Maximum && value.Y <= Point3YNumericUpDown.Maximum)
                {
                    Point3XNumericUpDown.Value = value.X;
                    Point3YNumericUpDown.Value = value.Y;
                }
            }
        }

        public Point Point4
        {
            get
            {
                return new Point((int)Point4XNumericUpDown.Value, (int)Point4YNumericUpDown.Value);
            }
            set
            {
                if (value.X <= Point4XNumericUpDown.Maximum && value.Y <= Point4YNumericUpDown.Maximum)
                {
                    Point4XNumericUpDown.Value = value.X;
                    Point4YNumericUpDown.Value = value.Y;
                }
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

        protected override bool PerformProcessingAction()
        {
            Processor proc = null;
            try
            {
                proc = new Processor(imagXpress1, imageXView1.Image.Copy());
                proc.BackgroundColor = BackgroundColorButton.BackColor;
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

                proc.PolynomialWarp(new Point((int)Point1XNumericUpDown.Value, (int)Point1YNumericUpDown.Value),
                    new Point((int)Point2XNumericUpDown.Value, (int)Point2YNumericUpDown.Value),
                    new Point((int)Point3XNumericUpDown.Value, (int)Point3YNumericUpDown.Value), 
                    new Point((int)Point4XNumericUpDown.Value, (int)Point4YNumericUpDown.Value));

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

        private void BackgroundColorButton_Click(object sender, EventArgs e)
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