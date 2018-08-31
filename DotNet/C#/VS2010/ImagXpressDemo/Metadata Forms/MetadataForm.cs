/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace ImagXpressDemo
{
    public partial class MetadataForm : Form
    {
        private const int tagNumberRow = 1;
        private string jpegComments;
        private string calsData;
        private List<string[]> iptcData;

        public MetadataForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private ImageX tagsImg;
        public ImageX TagsImg
        {
            set
            {
                tagsImg = value;
            }
        }

        private string filename;
        public string Filename
        {
            set
            {
                filename = value;
            }
        }

        private ImageX image;
        public ImageX Image
        {
            set
            {
                image = value;
            }
        }

        #if LICENSED
            private Licensing license;
            public Licensing License
            {
                set
                {
                    license = value;
                }
            }
        #endif

        private void MetadataForm_Load(object sender, System.EventArgs e)
        {


            //**The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime**
            //imagXpress1.Licensing.SetSolutionName("YourSolutionName");
            //imagXpress1.Licensing.SetSolutionKey(12345, 12345, 12345, 12345);
            //imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation…");


#if LICENSED
            if (license.Unlocked)
            {
                imagXpress1.Licensing.SetSolutionName(license.SolutionName);
                if (System.IntPtr.Size == 8)
                {
                    imagXpress1.Licensing.SetSolutionKey(license.Solution64Key1, license.Solution64Key2, license.Solution64Key3, license.Solution64Key4);
                }
                else
                {
                    imagXpress1.Licensing.SetSolutionKey(license.Solution32Key1, license.Solution32Key2, license.Solution32Key3, license.Solution32Key4);
                }
                imagXpress1.Licensing.SetOEMLicenseKey(license.OEMLicenseKeyImagXpress);
            }
#endif

            ShowTags();
            ShowComments();
            ShowCals();
            ShowIPTC();
        }

        private void ShowIPTC()
        {
            if (tagsImg.IptcDataSet != null)
            {
                iptcData = new List<string[]>(tagsImg.IptcDataSet.Count);
                for (int iptcIndex = 0; iptcIndex < tagsImg.IptcDataSet.Count; iptcIndex++)
                {                    
                    ImageXIptcData tag = tagsImg.IptcDataSet[iptcIndex];

                    iptcData.Add(new string[]{tag.Record.ToString(), tag.DataSetType.ToString(), 
                        tag.DataSet.ToString(), tag.DataFieldString});
                }

                if (tagsImg.IptcDataSet.Count > 0)
                {
                    IptcButton.Visible = true;
                }
            }
        }

        private void ShowCals()
        {
            if (tagsImg.CalTags != null)
            {
                for (int calsIndex = 0; calsIndex < tagsImg.CalTags.Count; calsIndex++)
                {
                    ImageCalsTag tag = tagsImg.CalTags[calsIndex];

                    calsData += String.Format("ID: {0}, Data: {1}", tag.CalsId, tag.CalsData) + "\r\n";
                }

                if (!String.IsNullOrEmpty(calsData))
                {
                    CalsButton.Visible = true;
                    CalsButton.Left = IptcButton.Left;
                }
            }
        }

        private void ShowComments()
        {
            try
            {
                for (int commentIndex = 0; commentIndex < image.JpegCommentCount; commentIndex++)
                {
                    jpegComments += image.ReturnJpegComment(commentIndex + 1) + "\r\n";
                }

                if (!String.IsNullOrEmpty(jpegComments))
                {
                    JpegCommentsButton.Visible = true;
                }
            }
            catch (ImageXException ex)
            {
                MessageBox.Show(ex.Message, Constants.commentsErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TagLevel(int tagLevel)
        {
            ListViewItem item = null;

            string levelString = String.Empty;
            switch (tagLevel)
            {
                case 0:
                    {
                        levelString = Constants.imageString;
                        break;
                    }
                case 1:
                    {
                        levelString = Constants.thumbnailString;
                        break;
                    }
                case 2:
                    {
                        levelString = Constants.exifString;
                        break;
                    }
                case 3:
                    {
                        levelString = Constants.customString;
                        break;
                    }
            }
            item = new ListViewItem(levelString);

            item.BackColor = Color.Black;
            item.ForeColor = Color.White;

            TagsListView.Items.Add(item);
        }

        private void GetThumbnailIfItExists(ImageXTag tag)
        {
            //At Thumbnail Level 1, Tag #513 - JPEGInterchangeFormat
            if (tag.TagLevel == 1 && tag.TagNumber == 513)
            {
                long thumbnailOffset = tag.GetTagUInt32()[0];

                LoadOptions lo = new LoadOptions();
                lo.ImageOffset = (int)thumbnailOffset;

                try
                {
                    if (imageXView1.Image != null)
                    {
                        imageXView1.Image.Dispose();
                        imageXView1.Image = null;
                    }
                    imageXView1.Image = ImageX.FromFile(imagXpress1, filename, lo);

                    ThumbnailLabel.Visible = true;
                    imageXView1.Visible = true;
                }
                catch (ImageXException ex)
                {
                    MessageBox.Show(ex.Message, Constants.exifThumbnailErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowTags()
        {
            if (tagsImg.Tags != null)
            {
                int currentTagLevel = -1;

                for (int tagIndex = 0; tagIndex < tagsImg.Tags.Count; tagIndex++)
                {
                    ImageXTag tag = tagsImg.Tags[tagIndex];

                    if (currentTagLevel != tag.TagLevel)
                    {
                        TagLevel(tag.TagLevel);
                        currentTagLevel = tag.TagLevel;
                    }

                    GetThumbnailIfItExists(tag);

                    string tagString = String.Empty;

                    switch (tag.TagType)
                    {
                        case TagTypes.Ascii:
                        case TagTypes.Byte:
                        case TagTypes.Undefine:
                            {
                                byte[] data = tag.GetTagBytes();

                                List<byte> newData = new List<byte>(data.Length);
                                for (int dataIndex = 0; dataIndex < data.Length; dataIndex++)
                                {
                                    if (data[dataIndex] != 0)
                                    {
                                        newData.Add(data[dataIndex]);
                                    }
                                    else
                                    {
                                        //replace 0 with space (32) so string isn't prematurely cut off                                       
                                        newData.Add(32);
                                    }
                                }

                                tagString = Encoding.ASCII.GetString(newData.ToArray());

                                break;
                            }
                        case TagTypes.Double:
                            {
                                double[] doubleData = tag.GetTagDouble();

                                for (int dataIndex = 0; dataIndex < doubleData.Length; dataIndex++)
                                {
                                    tagString += doubleData[dataIndex].ToString() + Constants.spaceString;
                                }

                                break;
                            }
                        case TagTypes.Float:
                            {
                                float[] floatData = tag.GetTagFloat();

                                for (int dataIndex = 0; dataIndex < floatData.Length; dataIndex++)
                                {
                                    tagString += floatData[dataIndex].ToString() + Constants.spaceString;
                                }

                                break;
                            }
                        case TagTypes.Long:
                            {
                                long[] longData = tag.GetTagUInt32();

                                for (int dataIndex = 0; dataIndex < longData.Length; dataIndex++)
                                {
                                    tagString += longData[dataIndex].ToString() + Constants.spaceString;
                                }

                                break;
                            }
                        case TagTypes.Rational:
                            {
                                long[] rationalData = tag.GetTagRational();

                                for (int dataIndex = 0; dataIndex < rationalData.Length; dataIndex += 2)
                                {
                                    tagString += rationalData[dataIndex].ToString() + "/" + rationalData[dataIndex + 1];
                                }

                                break;
                            }
                        case TagTypes.Sbyte:
                            {
                                short[] sByteData = tag.GetTagSBytes();

                                for (int dataIndex = 0; dataIndex < sByteData.Length; dataIndex++)
                                {
                                    tagString += sByteData[dataIndex].ToString() + Constants.spaceString;
                                }

                                break;
                            }
                        case TagTypes.Short:
                            {
                                int[] shortData = tag.GetTagUInt16();

                                for (int dataIndex = 0; dataIndex < shortData.Length; dataIndex++)
                                {
                                    tagString += shortData[dataIndex].ToString() + Constants.spaceString;
                                }

                                break;
                            }
                        case TagTypes.Slong:
                            {
                                int[] sLongData = tag.GetTagInt32();

                                for (int dataIndex = 0; dataIndex < sLongData.Length; dataIndex++)
                                {
                                    tagString += sLongData[dataIndex].ToString() + Constants.spaceString;
                                }

                                break;
                            }
                        case TagTypes.Srational:
                            {
                                int[] sRationalData = tag.GetTagSRational();

                                for (int dataIndex = 0; dataIndex < sRationalData.Length; dataIndex += 2)
                                {
                                    tagString += sRationalData[dataIndex].ToString() + "/" + sRationalData[dataIndex + 1];
                                }

                                break;
                            }
                        case TagTypes.Sshort:
                            {
                                short[] sShortData = tag.GetTagInt16();

                                for (int dataIndex = 0; dataIndex < sShortData.Length; dataIndex++)
                                {
                                    tagString += sShortData[dataIndex].ToString() + Constants.spaceString;
                                }

                                break;
                            }
                    }

                    TagsListView.Items.Add(new ListViewItem(new string[] { 
                        tag.TagLevel.ToString(), tag.TagNumber.ToString(),
                        tag.TagType.ToString(), tag.TagElementsCount.ToString(),
                        tagString}));
                }
            }
        }
        
        private void FormatTagNumber(bool shouldConvertToHex)
        {
            foreach (ListViewItem item in TagsListView.Items)
            {
                int tagNumber;

                if (item.SubItems.Count > 1)
                {
                    if (shouldConvertToHex)
                    {
                        tagNumber = Int32.Parse(item.SubItems[tagNumberRow].Text);

                        item.SubItems[tagNumberRow].Text = String.Format("0x{0:X4}", tagNumber);
                    }
                    else
                    {
                        string hexTagNumberMinusPrefix = item.SubItems[tagNumberRow].Text.Remove(0, 2);
                        tagNumber = Int32.Parse(hexTagNumberMinusPrefix, NumberStyles.HexNumber);

                        item.SubItems[tagNumberRow].Text = tagNumber.ToString();
                    }
                }
            }
        }

        private void HexRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HexRadioButton.Checked)
            {
                FormatTagNumber(true);
            }
        }

        private void DecimalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DecimalRadioButton.Checked)
            {
                FormatTagNumber(false);
            }
        }

        private void JpegCommentsButton_Click(object sender, EventArgs e)
        {
            using (CommentsTextForm commentsForm = new CommentsTextForm())
            {
                commentsForm.Text = "JPEG Comments";
                commentsForm.Comments = jpegComments;
                commentsForm.ShowDialog();
            }
        }

        private void IptcButton_Click(object sender, EventArgs e)
        {
            using (CommentsListForm commentsForm = new CommentsListForm())
            {
                commentsForm.Text = "IPTC";
                commentsForm.Comments = iptcData;
                commentsForm.ShowDialog();
            }
        }

        private void CalsButton_Click(object sender, EventArgs e)
        {
            using (CommentsTextForm commentsForm = new CommentsTextForm())
            {
                commentsForm.Text = "CALS";
                commentsForm.Comments = calsData;
                commentsForm.ShowDialog();
            }
        }
    }
}