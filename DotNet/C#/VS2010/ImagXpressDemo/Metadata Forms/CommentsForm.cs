/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System.Windows.Forms;

namespace ImagXpressDemo
{
    public partial class CommentsForm : Form
    {
        public CommentsForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}