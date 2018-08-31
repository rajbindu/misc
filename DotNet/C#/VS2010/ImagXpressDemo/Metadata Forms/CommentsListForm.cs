/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System.Collections.Generic;
using System.Windows.Forms;

namespace ImagXpressDemo
{
    public partial class CommentsListForm : CommentsForm
    {
        private const int widthExpander = 235;

        public List<string[]> Comments
        {
            set
            {
                for (int commentIndex = 0; commentIndex < value.Count; commentIndex++)
                {
                    CommentsListView.Items.Add(new ListViewItem(value[commentIndex]));
                }
            }
        }

        public CommentsListForm()
        {
            InitializeComponent();
        }

        private void CommentsListForm_Load(object sender, System.EventArgs e)
        {
            CommentsListView.Columns.Add(Constants.recordString);
            CommentsListView.Columns.Add(Constants.tagTypeString);
            CommentsListView.Columns.Add(Constants.tagString);
            CommentsListView.Columns.Add(Constants.dataString);
            CommentsListView.Columns[3].Width += widthExpander;
        }
    }
}