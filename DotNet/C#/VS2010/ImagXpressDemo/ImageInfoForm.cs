/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    public enum IXResolutionUnit
    {
        Inch = 0,
        Centimeter = 1,
        Meter = 2,
    }

    public partial class ImageInfoForm : Form
    {
        private const string fileSizeLabel = "File Size:";
        private const int bottomOfFormSpacer = 42;

        private string fileName;
        private int pageNumber, pageCount, imageWidth, imageHeight, bpp, filesize;
        private SizeF resolution;
        private ImageXFormat format;
        private Compression compression;
        private UIntPtr decompressedSize;

        private IXResolutionUnit currentResolutionUnit;

        public UIntPtr DecompressedSize
        {
            get
            {
                return decompressedSize;
            }
            set
            {
                decompressedSize = value;
            }
        }

        public string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
            }
        }

        public int PageNumber
        {
            get
            {
                return pageNumber;
            }
            set
            {
                pageNumber = value;
            }
        }

        public int PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                pageCount = value;
            }
        }

        public int ImageWidth
        {
            get
            {
                return imageWidth;
            }
            set
            {
                imageWidth = value;
            }
        }

        public int ImageHeight
        {
            get
            {
                return imageHeight;
            }
            set
            {
                imageHeight = value;
            }
        }

        public int Bpp
        {
            get
            {
                return bpp;
            }
            set
            {
                bpp = value;
            }
        }

        public int FileSize
        {
            get
            {
                return filesize;
            }
            set
            {
                filesize = value;
            }
        }

        public SizeF Resolution
        {
            get
            {
                return resolution;
            }
            set
            {
                resolution = value;
            }
        }

        public IXResolutionUnit CurrentResolutionUnit
        {
            get
            {
                return currentResolutionUnit;
            }
            set
            {
                currentResolutionUnit = value;
            }
        }

        public void SetResolutionUnitComboBoxSelectionIndex(int index)
        {
            ResolutionUnitComboBox.SelectedIndex = index;
        }

        public ImageXFormat Format
        {
            get
            {
                return format;
            }
            set
            {
                format = value;
            }
        }

        public Compression Compression
        {
            get
            {
                return compression;
            }
            set
            {
                compression = value;
            }
        }

        public ImageInfoForm()
        {
            InitializeComponent();
        }

        private static string CompressionFormatString(Compression compression)
        {
            switch (compression)
            {
                default:
                case Accusoft.ImagXpressSdk.Compression.NoCompression:
                    {
                        return Constants.noneString;
                    }
                case Accusoft.ImagXpressSdk.Compression.Lzw:
                    {
                        return Constants.lzwString;
                    }
                case Accusoft.ImagXpressSdk.Compression.Deflate:
                    {
                        return Constants.deflateString;
                    }
                case Accusoft.ImagXpressSdk.Compression.Group3Fax1d:
                    {
                        return Constants.group31DString;
                    }
                case Accusoft.ImagXpressSdk.Compression.Group3Fax2d:
                    {
                        return Constants.group32DString;
                    }
                case Accusoft.ImagXpressSdk.Compression.Group4:
                    {
                        return Constants.group4String;
                    }
                case Accusoft.ImagXpressSdk.Compression.Jpeg:
                    {
                        return Constants.jpegString;
                    }
                case Accusoft.ImagXpressSdk.Compression.Jpeg7:
                    {
                        return Constants.jpeg7String;
                    }
                case Accusoft.ImagXpressSdk.Compression.PackBits:
                    {
                        return Constants.packBitsString;
                    }
                case Accusoft.ImagXpressSdk.Compression.Rle:
                    {
                        return Constants.rleString;
                    }
            }
        }

        private static string ImageFormatString(ImageXFormat format)
        {
            switch (format)
            {
                case ImageXFormat.Dib:
                case ImageXFormat.Bmp:
                    {
                        return "Bitmap";
                    }
                case ImageXFormat.C4:
                    {
                        return "JEDMICS C4";
                    }
                case ImageXFormat.Cad:
                    {
                        return "CAD";
                    }
                case ImageXFormat.Cals:
                    {
                        return "CALS Raster";
                    }
                case ImageXFormat.CameraRaw:
                    {
                        return "Camera Raw";
                    }
                case ImageXFormat.Dcx:
                    {
                        return "DCX";
                    }
                case ImageXFormat.Emf:
                    {
                        return "EMF";
                    }
                case ImageXFormat.Epic:
                    {
                        return "Enhanced PIC";
                    }
                case ImageXFormat.Exif:
                    {
                        return "EXIF";
                    }
                case ImageXFormat.Gif:
                    {
                        return "GIF";
                    }
                case ImageXFormat.Ico:
                    {
                        return "ICON";
                    }
                case ImageXFormat.Ioca:
                    {
                        return "IOCA";
                    }
                case ImageXFormat.Jbig2:
                    {
                        return "JBIG2";
                    }
                case ImageXFormat.Jpeg:
                    {
                        return "JPEG";
                    }
                case ImageXFormat.Jpeg2000:
                    {
                        return "JPEG2000";
                    }
                case ImageXFormat.JpegLs:
                    {
                        return "JPEG LS";
                    }
                case ImageXFormat.JpegXR:
                    {
                        return "JPEG XR";
                    }
                case ImageXFormat.LosslessJpeg:
                    {
                        return "Lossless Jpeg";
                    }
                case ImageXFormat.Modca:
                    {
                        return "MO:DCA";
                    }
                case ImageXFormat.Pbm:
                    {
                        return "PBM";
                    }
                case ImageXFormat.Pcx:
                    {
                        return "PCX";
                    }
                case ImageXFormat.Pdf:
                    {
                        return "PDF";
                    }
                case ImageXFormat.Pgm:
                    {
                        return "PGM";
                    }
                case ImageXFormat.Pic:
                    {
                        return "PIC";
                    }
                case ImageXFormat.Png:
                    {
                        return "PNG";
                    }
                case ImageXFormat.Ppm:
                    {
                        return "PPM";
                    }
                case ImageXFormat.Tga:
                    {
                        return "Targa";
                    }
                case ImageXFormat.Tiff:
                    {
                        return "TIFF";
                    }
                case ImageXFormat.WirelessBmp:
                    {
                        return "Wireless Bitmap";
                    }
                case ImageXFormat.Wmf:
                    {
                        return "WMF";
                    }
                case ImageXFormat.Wsq:
                    {
                        return "WSQ";
                    }
                default:
                    {
                        return String.Empty;
                    }
            }
        }

        private void ImageInfoForm_Load(object sender, EventArgs e)
        {
            FileNameValueTextBox.Text = fileName;
            PageNumberValueTextBox.Text = pageNumber.ToString();
            WidthValueTextBox.Text = String.Format("{0} pixels", imageWidth.ToString());
            HeightValueTextBox.Text = String.Format("{0} pixels", imageHeight.ToString());
            BitsPerPixelValueTextBox.Text = bpp.ToString();

            FileSizeValueTextBox.Text = String.Format("{0} bytes", filesize);

            string formatString;
            int compressionInt = (int)compression;
            if ((compressionInt > 0 && compressionInt < 9) && (format == ImageXFormat.Tiff))
            {
                formatString = String.Format("{0} {1}", ImageFormatString(format), CompressionFormatString(compression));
            }
            else
            {
                formatString = String.Format("{0}", ImageFormatString(format));
            }
            FormatValueTextBox.Text = formatString;

            ResolutionUnitComboBox.SelectedIndex = (int)currentResolutionUnit;

            //for multi-page files we don't have a way to obtain the compressed page size so we
            //can't really provide a compression ratio
            if (pageCount == 1)
            {
                DecompresedSizeValueTextBox.Text = String.Format("{0} bytes", decompressedSize);

                double compressionRatio = (double)decompressedSize.ToUInt32() / filesize;
                CompressionRatioValueTextBox.Text = String.Format("{0:F2} : 1", compressionRatio);

                FileSizeLabel.Text = fileSizeLabel;
            }
            else
            {
                FileSizeLabel.Text = "Total " + fileSizeLabel;
                int heightDecrement = DecompressedSizeLabel.Height + CompressionRatioLabel.Height + bottomOfFormSpacer;

                ImageInfoGroupBox.Height -= heightDecrement;
                this.Height -= heightDecrement;
                OkButton.Top -= heightDecrement;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void ResolutionUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            const float cmToInch = 2.54F;
            const float cmToMeter = 100.0F;
            string resolutionUnitString = String.Empty;
            float conversionFactor = 1.0F;
            SizeF physicalDimensions;

            switch (ResolutionUnitComboBox.SelectedIndex)
            {
                case 0:
                    {
                        resolutionUnitString = "Inch";
                        if (currentResolutionUnit == IXResolutionUnit.Centimeter)
                        {
                            conversionFactor = 1 / cmToInch;
                        }
                        else if (currentResolutionUnit == IXResolutionUnit.Meter)
                        {
                            conversionFactor = cmToMeter / cmToInch;
                        }
                        currentResolutionUnit = IXResolutionUnit.Inch;
                        break;
                    }
                case 1:
                    {
                        resolutionUnitString = "Centimeter";
                        if (currentResolutionUnit == IXResolutionUnit.Inch)
                        {
                            conversionFactor = cmToInch;
                        }
                        else if (currentResolutionUnit == IXResolutionUnit.Meter)
                        {
                            conversionFactor = cmToMeter;
                        }
                        currentResolutionUnit = IXResolutionUnit.Centimeter;
                        break;
                    }
                case 2:
                    {
                        resolutionUnitString = "Meter";
                        if (currentResolutionUnit == IXResolutionUnit.Inch)
                        {
                            conversionFactor = cmToInch / cmToMeter;
                        }
                        else if (currentResolutionUnit == IXResolutionUnit.Centimeter)
                        {
                            conversionFactor = 1 / cmToMeter;
                        }
                        currentResolutionUnit = IXResolutionUnit.Meter;
                        break;
                    }
            }

            if (resolution.Width > 0 && resolution.Height > 0)
            {
                resolution = new SizeF(resolution.Width / conversionFactor, resolution.Height / conversionFactor);
                physicalDimensions = new SizeF(imageWidth / resolution.Width, imageHeight / resolution.Height);
                PhysicalDimensionsValueTextBox.Text = String.Format("{0} {1}", physicalDimensions, currentResolutionUnit);
            }

            ResolutionValueTextBox.Text = String.Format("{0} dots per {1}", resolution.ToString(), resolutionUnitString);           
        }
    }
}
