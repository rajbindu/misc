/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
namespace ImagXpressDemo
{
    public partial class SaveOptionsIconForm : SaveOptionsForm
    {
        public SaveOptionsIconForm()
        {
            InitializeComponent();
        }

        public bool MultiPageEnabled
        {
            get
            {
                return MultiPageCheckBox.Enabled;
            }
            set
            {
                MultiPageCheckBox.Enabled = value;
            }
        }

        public bool MultiPage
        {
            get
            {
                return MultiPageCheckBox.Checked;
            }
            set
            {
                MultiPageCheckBox.Checked = value;
            }
        }

        private void SaveOptionsIconForm_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + heightSpacer;
            OKButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
        }
    }
}
