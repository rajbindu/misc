/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
namespace ImagXpressDemo
{
    public partial class CommentsTextForm : CommentsForm
    {
        public string Comments
        {
            set
            {
                CommentsTextBox.Text = value;
            }
        }

        public CommentsTextForm()
        {
            InitializeComponent();
        }

        private void CommentsTextForm_Load(object sender, System.EventArgs e)
        {
            //don't select any text
            this.CommentsTextBox.Select(0, 0);
        }
    }
}
