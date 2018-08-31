//*********************************************************************'
//* Copyright 2005-2016 - Accusoft Corporation, Tampa Florida.        *'
//* This sample code is provided to Accusoft licensees "as is"        *'
//* with no restrictions on use or modification. No warranty for      *'
//* use of this sample code is provided by Accusoft.                  *'
//*********************************************************************'
using System.Windows.Forms;
using Accusoft.ImagXpressSdk;

namespace ImageReduce
{
    public partial class OptionsForm : Form
    {
        private TransformMode _tranformMode = TransformMode.None;
        public TransformMode TransformMode
        {
            get
            {
                return _tranformMode;
            }
            set
            {
                _tranformMode = value;
            }
        }

        private System.Int32 _jpegQualityFactor = 22;
        public System.Int32 JpegQualityFactor
        {
            get
            { 
                return _jpegQualityFactor; 
            }
            set
            {   
                _jpegQualityFactor = value; 
            }
        }

        public OptionsForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            _jpegQualityFactor = (int)jpegQualityFactorNumericUpDown.Value;
            _tranformMode = (TransformMode)TransformModeComboBox.SelectedIndex;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OptionsForm_Load(object sender, System.EventArgs e)
        {
            jpegQualityFactorNumericUpDown.Value = _jpegQualityFactor;
            TransformModeComboBox.SelectedIndex = (int)_tranformMode;
        }
    }
}
