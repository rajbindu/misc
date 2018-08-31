/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
namespace ImagXpressDemo
{
    public partial class SaveOptionsJlsForm : SaveOptionsForm
    {
        public SaveOptionsJlsForm()
        {
            InitializeComponent();
        }

        public int Interleave
        {
            get
            {
                return InterleaveComboBox.SelectedIndex;
            }
            set
            {
                InterleaveComboBox.SelectedIndex = value;
            }
        }

        public int MaxValue
        {
            get
            {
                return (int)MaxValueNumericUpDown.Value;
            }
            set
            {
                MaxValueNumericUpDown.Value = value;
            }
        }

        public int PointPrecision
        {
            get
            {
                return (int)PointPrecisionNumericUpDown.Value;
            }
            set
            {
                PointPrecisionNumericUpDown.Value = value;
            }
        }

        public int Near
        {
            get
            {
                return (int)NearNumericUpDown.Value;
            }
            set
            {
                NearNumericUpDown.Value = value;
            }
        }

        private void SaveOptionsJlsForm_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + heightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
        }
    }
}
