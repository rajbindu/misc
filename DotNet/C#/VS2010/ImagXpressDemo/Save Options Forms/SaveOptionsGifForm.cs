/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System.Windows.Forms;
using System.Drawing;
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public partial class SaveOptionsGifForm : SaveOptionsForm
    {
        public SaveOptionsGifForm()
        {
            InitializeComponent();
        }

        public bool Interlaced
        {
            get
            {
                return InterlacedCheckBox.Checked;
            }
            set
            {
                InterlacedCheckBox.Checked = value;
            }

        }

        public TransparencyMatch TransparencyMatch
        {
            get
            {
                return (TransparencyMatch)TransparencyMatchComboBox.SelectedIndex;
            }
            set
            {
                TransparencyMatchComboBox.SelectedIndex = (int)value;
            }
        }

        public GifType GifType
        {
            get
            {
                return (GifType)GifTypeComboBox.SelectedIndex;
            }
            set
            {
                GifTypeComboBox.SelectedIndex = (int)value;
            }
        }

        public Color TransparencyColor
        {
            get
            {
                return TransparencyColorButton.BackColor;
            }
            set
            {
                TransparencyColorButton.BackColor = value;
            }
        }

        private void SaveOptionsGifForm_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + heightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
        }

        private void TransparencyColorButton_Click(object sender, System.EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    TransparencyColorButton.BackColor = colorDlg.Color;
                }
            }
        }
    }
}
