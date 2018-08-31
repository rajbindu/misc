/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
namespace ImagXpressDemo
{
    public partial class SaveOptionsPicForm : SaveOptionsForm
    {
        public SaveOptionsPicForm()
        {
            InitializeComponent();
        }

        public string PicPassword
        {
            get
            {
                return PicPasswordTextBox.Text;
            }
            set
            {
                PicPasswordTextBox.Text = value;
            }
        }

        private void SaveOptionsPicForm_Load(object sender, System.EventArgs e)
        {
            this.Height += OKButton.Height + heightSpacer; 
            OKButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
            CancelOptionsButton.Top = this.Size.Height - OKButton.Height - bottomOfFormSpacer;
        }
    }
}
