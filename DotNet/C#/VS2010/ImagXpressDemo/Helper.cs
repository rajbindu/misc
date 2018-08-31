/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;
using Accusoft.NotateXpressSdk;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImagXpressDemo
{
    public class Helper
    {
        private ImageX image;
        public ImageX Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }

        private int scannedImagePageCount;
        public int ScannedImagePageCount
        {
            get
            {
                return scannedImagePageCount;
            }
            set
            {
                scannedImagePageCount = value;
            }
        }

        private ImagXpress imagXpress;
        public ImagXpress ImagXpress
        {
            get
            {
                return imagXpress;
            }
            set
            {
                imagXpress = value;
            }
        }

        private string openCameraRawInitialDirectory;
        public string OpenCameraRawInitialDirectory
        {
            get
            {
                return openCameraRawInitialDirectory;
            }
            set
            {
                openCameraRawInitialDirectory = value;
            }
        }

        private int openCameraRawFilterIndex;
        public int OpenCameraRawFilterIndex
        {
            get
            {
                return openCameraRawFilterIndex;
            }
            set
            {
                openCameraRawFilterIndex = value;
            }
        }

        private int openFileFilterIndex;
        public int OpenFileFilterIndex
        {
            get
            {
                return openFileFilterIndex;
            }
            set
            {
                openFileFilterIndex = value;
            }
        }

        private string openFileInitialDirectory;
        public string OpenFileInitialDirectory
        {
            get
            {
                return openFileInitialDirectory;
            }
            set
            {
                openFileInitialDirectory = value;
            }
        }

        private string openedFileName;
        public string OpenedFileName
        {
            get
            {
                return openedFileName;
            }
            set
            {
                openedFileName = value;
            }
        }

        private int openedPageNumber = 1;
        public int OpenedPageNumber
        {
            get
            {
                return openedPageNumber;
            }
            set
            {
                openedPageNumber = value;
            }
        }

        private int openedPageCount = 1;
        public int OpenedPageCount
        {
            get
            {
                return openedPageCount;
            }
            set
            {
                openedPageCount = value;
            }
        }

        private ImageXFormat openedFormat;
        public ImageXFormat OpenedFormat
        {
            get
            {
                return openedFormat;
            }
            set
            {
                openedFormat = value;
            }
        }

        private int openedFileSize;
        public int OpenedFileSize
        {
            get
            {
                return openedFileSize;
            }
            set
            {
                openedFileSize = value;
            }
        }

        private Accusoft.ImagXpressSdk.LoadOptions loadOptionsChosen;
        public Accusoft.ImagXpressSdk.LoadOptions LoadOptionsChosen
        {
            get
            {
                return loadOptionsChosen;
            }
        }

        private bool openOptionsJpegCosited, openOptionsJpegEnhanced;
        private ThumbnailSize openOptionsJpegThumbnailSize = ThumbnailSize.None;
        private JpegXRPostProcessFilter openOptionsJpegXRPostProcessingFilter = JpegXRPostProcessFilter.None;
        private bool openOptionsJbig2SwapBlackAndWhite;
        private Resolution openOptionsMetafileResolution = new Resolution();
        private IXResolutionUnit openOptionsMetafileResolutionUnits = IXResolutionUnit.Inch;
        private string openOptionsPicPassword;
        private ThumbnailSize openOptionsPicThumbnailSize = ThumbnailSize.None;
        private int openOptionsTifIFDOffset;
        private bool openOptionsTifSpecialHandling;
        private int openOptionsCadLayoutToRender;
        private int openOptionsCadPaperBitDepth = 8;
        private double openOptionsCadPaperHeight = 17;
        private ResolutionUnits openOptionsCadPaperResolutionUnits = ResolutionUnits.Inch;
        private double openOptionsCadPaperResolutionX = 100;
        private double openOptionsCadPaperResolutionY = 100;
        private double openOptionsCadPaperWidth = 22;

        private int openOptionsCropX;
        private int openOptionsCropY;
        private int openOptionsCropWidth;
        private int openOptionsCropHeight;
        private int openOptionsResizeWidth;
        private int openOptionsResizeHeight;
        private bool openOptionsResizeAntiAlias;
        private bool openOptionsMaintainApsectRatio;
        private bool openOptionsPreserveBlack;
        private bool openOptionsAlphaChannel;
        private bool openOptionsScaleToGray;
        private RotateAngle openOptionsRotation = RotateAngle.Rotate0;
        private int openOptionsImageOffset;

        private bool openOptionsCameraRawAutoBrightnessAndContrast = true;
        private bool openOptionsCameraRawBlueFactorEnabled = false;
        private double openOptionsCameraRawBlueFactor;
        private double openOptionsCameraRawBrightnessFactor;
        private bool openOptionsCameraRawBrightnessFactorEnabled = false;
        private bool openOptionsCameraRawClipHighlightsToWhite = true;
        private bool openOptionsCameraRawConvertTosRGB = true;
        private double openOptionsCameraRawGammaCorrection;
        private double openOptionsCameraRawRedFactor;
        private bool openOptionsCameraRawRedFactorEnabled = false;
        private bool openOptionsCameraRawRemoveRotation = true;
        private bool openOptionsCameraRawReturnThumbnail;
        private bool openOptionsCameraRawUseFastInterpolationMethod;
        private bool openOptionsCameraRawUseHalfSizeImage;
        private bool openOptionsCameraRawUseSecondaryPixels;
        private WhiteBalanceMethod openOptionsCameraRawWhiteBalanceMethod = WhiteBalanceMethod.Camera;

        private string savedFileName;
        public string SavedFileName
        {
            get
            {
                return savedFileName;
            }
        }

        private string saveOptionsJpegTargetProfileInitialDirectory;
        public string SaveOptionsJpegTargetProfileInitialDirectory
        {
            get
            {
                return saveOptionsJpegTargetProfileInitialDirectory;
            }
            set
            {
                saveOptionsJpegTargetProfileInitialDirectory = value;
            }
        }

        private string saveOptionsTifTargetProfileInitialDirectory;
        public string SaveOptionsTifTargetProfileInitialDirectory
        {
            get
            {
                return saveOptionsTifTargetProfileInitialDirectory;
            }
            set
            {
                saveOptionsTifTargetProfileInitialDirectory = value;
            }
        }

        private string saveFileInitialDirectory;
        public string SaveFileInitialDirectory
        {
            get
            {
                return saveFileInitialDirectory;
            }
            set
            {
                saveFileInitialDirectory = value;
            }
        }

        private int saveFileFilterIndex;
        public int SaveFileFilterIndex
        {
            get
            {
                return saveFileFilterIndex;
            }
            set
            {
                saveFileFilterIndex = value;
            }
        }

        private Accusoft.ImagXpressSdk.SaveOptions saveOptionsChosen;
        public Accusoft.ImagXpressSdk.SaveOptions SaveOptionsChosen
        {
            get
            {
                return saveOptionsChosen;
            }
        }

        private Compression saveOptionsBmpCompression = Compression.NoCompression;
        private bool saveOptionsDcxMultiPage;
        private int saveOptionsExifThumbnailSize;
        private bool saveOptionsGifInterlaced;
        private GifType saveOptionsGifType = GifType.Gif89a;
        private TransparencyMatch saveOptionsGifTransparencyMatch = TransparencyMatch.None;
        private Color saveOptionsGifTransparencyColor = Color.Turquoise;
        private bool saveOptionsIconMultiPage;
        private Jbig2EncodeModeCompression saveOptionsJbig2EncodeModeCompression = Jbig2EncodeModeCompression.AutoDetect;
        private Jbig2FileOrganization saveOptionsJbig2FileOrganization = Jbig2FileOrganization.Default;
        private int saveOptionsJbig2LoosesnessCompression;
        private bool saveOptionsJbig2InvertedRegion;
        private int saveOptionsJlsInterleave;
        private int saveOptionsJlsMaxValue;
        private int saveOptionsJlsPointPrecision;
        private int saveOptionsJlsNear;
        private bool saveOptionsJp2Grayscale;
        private int saveOptionsJp2CompressSize;
        private ProgressionOrder saveOptionsJp2ProgressionOrder = ProgressionOrder.Default;
        private Jp2Type saveOptionsJp2Type = Jp2Type.Lossy;
        private double saveOptionsJp2PeakSignalToNoiseRatio;
        private int saveOptionsJp2TileWidth;
        private int saveOptionsJp2TileHeight;
        private int saveOptionsJpegChrominance;
        private int saveOptionsJpegLuminance;
        private ColorSpace saveOptionsJpegColorSpace = ColorSpace.Rgb;
        private Accusoft.ImagXpressSdk.SubSampling saveOptionsJpegSubSampling = Accusoft.ImagXpressSdk.SubSampling.SubSampling411;
        private bool saveOptionsJpegCosited;
        private bool saveOptionsJpegGrayscale;
        private bool saveOptionsJpegProgressive;
        private RenderIntent saveOptionsJpegColorRenderIntent = RenderIntent.Images;
        private string saveOptionsJpegTargetProfileName;
        private bool saveOptionsJpegXRFrequencyOrdering;
        private int saveOptionsJpegXRQuantization = 1;
        private JpegXRSubSampling saveOptionsJpegXRChromaSubSampling = JpegXRSubSampling.ChromaSubSampling444;
        private LjpMethod saveOptionsLjpMethod = LjpMethod.Jpeg;
        private LjpType saveOptionsLjpType = LjpType.Rgb;
        private int saveOptionsLjpPredictor = 1;
        private int saveOptionsLjpOrder = 1;
        private string saveOptionsModcaDocumentName;
        private string saveOptionsPicPassword;
        private bool saveOptionsPngInterlaced;
        private Color saveOptionsPngTransparencyColor = Color.Turquoise;
        private TransparencyMatch saveOptionsPngTransparencyMatch = TransparencyMatch.None;
        private RenderIntent saveOptionsTifColorRenderIntent = RenderIntent.Images;
        private string saveOptionsTifTargetProfileName;
        //private bool saveOptionsTifTargetProfileNameEnabled;
        private ByteOrder saveOptionsTifByteOrder = ByteOrder.Intel;
        private Compression saveOptionsTif1BppCompression = Compression.NoCompression;
        private Compression saveOptionsTifNon1BppCompression = Compression.NoCompression;
        private ColorSpace saveOptionsTifColorSpace = ColorSpace.Rgb;
        private int saveOptionsTifIFDOffset;
        private int saveOptionsTifRowsPerStrip;
        private bool saveOptionsTifMultiPage;
        private bool saveOptionsTifUseIFDOffset;
        private int saveOptionsWsqBlack;
        private int saveOptionsWsqWhite = 255;
        private double saveOptionsWsqQuantization = 1.0;

        private void SetCameraRawOpenOptions(OpenOptionsCameraRawForm cameraRawForm, Accusoft.ImagXpressSdk.LoadOptions lo)
        {
            //set camera raw options according to what was last selected by the user
            openOptionsCameraRawAutoBrightnessAndContrast = lo.CameraRaw.AutoBrightnessAndContrast = cameraRawForm.AutoBrightnessAndContrast;
            
            if (cameraRawForm.BlueFactorEnabled)
            {
                openOptionsCameraRawBlueFactor = lo.CameraRaw.BlueFactor = cameraRawForm.BlueFactor;
            }
            openOptionsCameraRawBlueFactorEnabled = cameraRawForm.BlueFactorEnabled;
            
            if (cameraRawForm.BrightnessFactorEnabled)
            {
                openOptionsCameraRawBrightnessFactor = lo.CameraRaw.BrightnessFactor = cameraRawForm.BrightnessFactor;
            }
            openOptionsCameraRawBrightnessFactorEnabled = cameraRawForm.BrightnessFactorEnabled;
            
            openOptionsCameraRawClipHighlightsToWhite = lo.CameraRaw.ClipHighlightsToWhite = cameraRawForm.ClipHighlightsToWhite;
            openOptionsCameraRawConvertTosRGB = lo.CameraRaw.ConvertTosRGB = cameraRawForm.ConvertTosRGB;
            openOptionsCameraRawGammaCorrection = lo.CameraRaw.GammaCorrection = cameraRawForm.GammaCorrection;
            
            if (cameraRawForm.RedFactorEnabled)
            {
                openOptionsCameraRawRedFactor = lo.CameraRaw.RedFactor = cameraRawForm.RedFactor;
            }
            openOptionsCameraRawRedFactorEnabled = cameraRawForm.RedFactorEnabled;

            openOptionsCameraRawRemoveRotation = lo.CameraRaw.RemoveRotation = cameraRawForm.RemoveRotation;
            openOptionsCameraRawReturnThumbnail = lo.CameraRaw.ReturnThumbnail = cameraRawForm.ReturnThumbnail;
            openOptionsCameraRawUseFastInterpolationMethod = lo.CameraRaw.UseFastInterpolationMethod = cameraRawForm.UseFastInterpolationMethod;
            openOptionsCameraRawUseHalfSizeImage = lo.CameraRaw.UseHalfSizeImage = cameraRawForm.UseHalfSizeImage;
            openOptionsCameraRawUseSecondaryPixels = lo.CameraRaw.UseSecondaryPixels = cameraRawForm.UseSecondaryPixels;
            openOptionsCameraRawWhiteBalanceMethod = lo.CameraRaw.WhiteBalanceMethod = cameraRawForm.WhiteBalanceMethod;
        }

        private void SetCameraRawFormOpenOptions(OpenOptionsCameraRawForm cameraRawForm)
        {
            //set camera raw form options according to what was last selected by the user
            cameraRawForm.AutoBrightnessAndContrast = openOptionsCameraRawAutoBrightnessAndContrast;
            
            if (openOptionsCameraRawBlueFactorEnabled == true)
            {
                cameraRawForm.BlueFactor = openOptionsCameraRawBlueFactor;
            }
            cameraRawForm.BlueFactorEnabled = openOptionsCameraRawBlueFactorEnabled;

            if (openOptionsCameraRawBrightnessFactorEnabled == true)
            {
                cameraRawForm.BrightnessFactor = openOptionsCameraRawBrightnessFactor;
            }
            cameraRawForm.BrightnessFactorEnabled = openOptionsCameraRawBrightnessFactorEnabled;

            cameraRawForm.ClipHighlightsToWhite = openOptionsCameraRawClipHighlightsToWhite;
            cameraRawForm.ConvertTosRGB = openOptionsCameraRawConvertTosRGB;
            cameraRawForm.GammaCorrection = openOptionsCameraRawGammaCorrection;
            
            if (openOptionsCameraRawRedFactorEnabled == true)
            {
                cameraRawForm.RedFactor = openOptionsCameraRawRedFactor;
            }
            cameraRawForm.RedFactorEnabled = openOptionsCameraRawRedFactorEnabled;

            cameraRawForm.RemoveRotation = openOptionsCameraRawRemoveRotation;
            cameraRawForm.ReturnThumbnail = openOptionsCameraRawReturnThumbnail;
            cameraRawForm.UseFastInterpolationMethod = openOptionsCameraRawUseFastInterpolationMethod;
            cameraRawForm.UseHalfSizeImage = openOptionsCameraRawUseHalfSizeImage;
            cameraRawForm.UseSecondaryPixels = openOptionsCameraRawUseSecondaryPixels;
            cameraRawForm.WhiteBalanceMethod = openOptionsCameraRawWhiteBalanceMethod;

            //scale to gray does not apply to Camera Raw
            cameraRawForm.ScaleToGrayEnabled = false;
        }

        private void SetGenericOpenOptions(Accusoft.ImagXpressSdk.LoadOptions lo, OpenOptionsForm openOptionsForm)
        {
            //keep track of options selected by user for next time
            lo.CropRectangle = new Rectangle(openOptionsForm.CropX, openOptionsForm.CropY, openOptionsForm.CropWidth, openOptionsForm.CropHeight);
            openOptionsCropX = openOptionsForm.CropX;
            openOptionsCropY = openOptionsForm.CropY;
            openOptionsCropWidth = openOptionsForm.CropWidth;
            openOptionsCropHeight = openOptionsForm.CropHeight;

            lo.Resize = new Size(openOptionsForm.ResizeWidth, openOptionsForm.ResizeHeight);
            openOptionsResizeWidth = openOptionsForm.ResizeWidth;
            openOptionsResizeHeight = openOptionsForm.ResizeHeight;

            openOptionsResizeAntiAlias = lo.LoadResizeAntiAlias = openOptionsForm.ResizeAntiAlias;
            openOptionsMaintainApsectRatio = lo.MaintainAspectRatio = openOptionsForm.MaintainApsectRatio;
            openOptionsPreserveBlack = lo.PreserveBlack = openOptionsForm.PreserveBlack;
            openOptionsAlphaChannel = lo.LoadAlphaChannel = openOptionsForm.AlphaChannel;
            openOptionsScaleToGray = lo.ScaleToGray = openOptionsForm.ScaleToGray;
            openOptionsRotation = lo.Rotation = openOptionsForm.Rotation;
            openOptionsImageOffset = lo.ImageOffset = openOptionsForm.ImageOffset;
        }

        private void SetGenericOpenFormOptions(OpenOptionsForm openOptionsForm, ImageXData imageData)
        {
            //set open options according to what was last selected by user
            openOptionsForm.CropX = openOptionsCropX;
            openOptionsForm.CropY = openOptionsCropY;
            openOptionsForm.CropWidth = openOptionsCropWidth;
            openOptionsForm.CropHeight = openOptionsCropHeight;
            openOptionsForm.ResizeWidth = openOptionsResizeWidth;
            openOptionsForm.ResizeHeight = openOptionsResizeHeight;
            openOptionsForm.ResizeAntiAlias = openOptionsResizeAntiAlias;
            openOptionsForm.MaintainApsectRatio = openOptionsMaintainApsectRatio;
            openOptionsForm.PreserveBlack = openOptionsPreserveBlack;
            openOptionsForm.AlphaChannel = openOptionsAlphaChannel;
            openOptionsForm.Rotation = openOptionsRotation;
            openOptionsForm.ImageOffset = openOptionsImageOffset;

            if (imageData != null)
            {
                //scale to gray only applied to 1bpp images
                if (imageData.BitsPerPixel == 1)
                {
                    openOptionsForm.ScaleToGrayEnabled = true;
                    openOptionsForm.ScaleToGray = openOptionsScaleToGray;
                }
                else
                {
                    openOptionsForm.ScaleToGrayEnabled = false;
                }

                //set maximum values of numeric up down controls
                openOptionsForm.SetCropXMax(imageData.Width);
                openOptionsForm.SetCropYMax(imageData.Height);
                openOptionsForm.SetCropWidthMax(imageData.Width);
                openOptionsForm.SetCropHeightMax(imageData.Height);

                openOptionsForm.ImageOffsetMax = imageData.Size;
            }
        }

        public DialogResult OpenWithOptions()
        {
            Accusoft.ImagXpressSdk.LoadOptions lo = new Accusoft.ImagXpressSdk.LoadOptions();

            using (OpenFileDialog openDlg = new OpenFileDialog())
            {
                openDlg.Title = Constants.openImageString;
                openDlg.Filter = Constants.openFilterString;
                openDlg.FilterIndex = openFileFilterIndex;
                openDlg.InitialDirectory = openFileInitialDirectory;

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    openFileInitialDirectory = Path.GetDirectoryName(openDlg.FileName);
                    openFileFilterIndex = openDlg.FilterIndex;

                    using (ImageXData imageData = ImageX.QueryFile(imagXpress, openDlg.FileName))
                    {
                        bool dialogCancelled = true;

                        switch (imageData.Format)
                        {
                            case ImageXFormat.Jbig2:
                                {
                                    using (OpenOptionsJbig2Form jbig2Form = new OpenOptionsJbig2Form())
                                    {
                                        SetGenericOpenFormOptions(jbig2Form, imageData);

                                        jbig2Form.SwapBlackAndWhite = openOptionsJbig2SwapBlackAndWhite;

                                        if (jbig2Form.ShowDialog() == DialogResult.OK)
                                        {
                                            openOptionsJbig2SwapBlackAndWhite = lo.Jbig2.SwapBlackAndWhite = jbig2Form.SwapBlackAndWhite;

                                            SetGenericOpenOptions(lo, jbig2Form);
                                            dialogCancelled = false;
                                        }
                                    }
                                    break;
                                }
                            case ImageXFormat.Jpeg:
                                {
                                    using (OpenOptionsJpegForm jpegForm = new OpenOptionsJpegForm())
                                    {
                                        SetGenericOpenFormOptions(jpegForm, imageData);

                                        jpegForm.Cosited = openOptionsJpegCosited;
                                        jpegForm.Enhanced = openOptionsJpegEnhanced;
                                        jpegForm.ThumbnailSize = openOptionsJpegThumbnailSize;

                                        if (jpegForm.ShowDialog() == DialogResult.OK)
                                        {
                                            openOptionsJpegCosited = lo.Jpeg.Cosited = jpegForm.Cosited;
                                            openOptionsJpegEnhanced = lo.Jpeg.Enhanced = jpegForm.Enhanced;
                                            openOptionsJpegThumbnailSize = lo.ThumbnailSize = jpegForm.ThumbnailSize;

                                            SetGenericOpenOptions(lo, jpegForm);
                                            dialogCancelled = false;
                                        }
                                    }
                                    break;
                                }
                            case ImageXFormat.JpegXR:
                                {
                                    using (OpenOptionsJpegXRForm jpegXRForm = new OpenOptionsJpegXRForm())
                                    {
                                        SetGenericOpenFormOptions(jpegXRForm, imageData);

                                        jpegXRForm.PostProcessingFilter = openOptionsJpegXRPostProcessingFilter;

                                        if (jpegXRForm.ShowDialog() == DialogResult.OK)
                                        {
                                            openOptionsJpegXRPostProcessingFilter = lo.JpegXR.PostProcessingFilter = jpegXRForm.PostProcessingFilter;

                                            SetGenericOpenOptions(lo, jpegXRForm);
                                            dialogCancelled = false;
                                        }
                                    }
                                    break;
                                }
                            case ImageXFormat.Emf:
                            case ImageXFormat.Wmf:
                                {
                                    using (OpenOptionsMetafileForm metafileForm = new OpenOptionsMetafileForm())
                                    {
                                        SetGenericOpenFormOptions(metafileForm, imageData);

                                        metafileForm.SetResolutionXMax(Int32.MaxValue);
                                        metafileForm.SetResolutionYMax(Int32.MaxValue);
                                        metafileForm.ResolutionX = (int)openOptionsMetafileResolution.Dimensions.Width;
                                        metafileForm.ResolutionY = (int)openOptionsMetafileResolution.Dimensions.Height;
                                        metafileForm.ResolutionUnit = openOptionsMetafileResolutionUnits;

                                        if (metafileForm.ShowDialog() == DialogResult.OK)
                                        {
                                            Resolution newResolution = new Resolution();
                                            switch (metafileForm.ResolutionUnit)
                                            {
                                                case IXResolutionUnit.Inch:
                                                    {
                                                        newResolution.Dimensions = new SizeF(metafileForm.ResolutionX, metafileForm.ResolutionY);
                                                        newResolution.Units = GraphicsUnit.Inch;
                                                        break;
                                                    }
                                                case IXResolutionUnit.Centimeter:
                                                    {
                                                        newResolution.Dimensions = new SizeF(metafileForm.ResolutionX / 10, metafileForm.ResolutionY / 10);
                                                        newResolution.Units = GraphicsUnit.Millimeter;
                                                        break;
                                                    }
                                                case IXResolutionUnit.Meter:
                                                    {
                                                        newResolution.Dimensions = new SizeF(metafileForm.ResolutionX * 100, metafileForm.ResolutionY / 100);
                                                        newResolution.Units = GraphicsUnit.Millimeter;
                                                        break;
                                                    }
                                            }

                                            openOptionsMetafileResolution = lo.Metafile.Resolution = newResolution;

                                            SetGenericOpenOptions(lo, metafileForm);
                                            dialogCancelled = false;
                                        }
                                    }
                                    break;
                                }
                            case ImageXFormat.Pic:
                            case ImageXFormat.Epic:
                                {
                                    using (OpenOptionsPicForm picForm = new OpenOptionsPicForm())
                                    {
                                        SetGenericOpenFormOptions(picForm, imageData);

                                        picForm.PicPassword = openOptionsPicPassword;
                                        picForm.ThumbnailSize = openOptionsPicThumbnailSize;

                                        if (picForm.ShowDialog() == DialogResult.OK)
                                        {
                                            openOptionsPicPassword = lo.Pic.Password = picForm.PicPassword;

                                            openOptionsPicThumbnailSize = lo.ThumbnailSize = picForm.ThumbnailSize;

                                            SetGenericOpenOptions(lo, picForm);
                                            dialogCancelled = false;
                                        }
                                    }
                                    break;
                                }
                            case ImageXFormat.Tiff:
                                {
                                    using (OpenOptionsTiffForm tiffForm = new OpenOptionsTiffForm())
                                    {
                                        SetGenericOpenFormOptions(tiffForm, imageData);
                                        tiffForm.SetIFDOffsetMax(imageData.Size);

                                        tiffForm.IFDOffset = openOptionsTifIFDOffset;
                                        tiffForm.SpecialHandling = openOptionsTifSpecialHandling;

                                        if (tiffForm.ShowDialog() == DialogResult.OK)
                                        {
                                            openOptionsTifIFDOffset = lo.Tiff.IFDOffset = tiffForm.IFDOffset;
                                            openOptionsTifSpecialHandling = lo.Tiff.SpecialHandling = tiffForm.SpecialHandling;

                                            SetGenericOpenOptions(lo, tiffForm);
                                            dialogCancelled = false;
                                        }
                                    }
                                    break;
                                }
                            case ImageXFormat.Cad:
                                {
                                    using (OpenOptionsCadForm cadForm = new OpenOptionsCadForm())
                                    {
                                        SetGenericOpenFormOptions(cadForm, imageData);

                                        cadForm.LayoutToRender = openOptionsCadLayoutToRender;
                                        cadForm.PaperBitDepth = openOptionsCadPaperBitDepth;
                                        cadForm.PaperHeight = openOptionsCadPaperHeight;
                                        cadForm.PaperResolutionUnits = openOptionsCadPaperResolutionUnits;
                                        cadForm.PaperResolutionX = openOptionsCadPaperResolutionX;
                                        cadForm.PaperResolutionY = openOptionsCadPaperResolutionY;
                                        cadForm.PaperWidth = openOptionsCadPaperWidth;

                                        if (cadForm.ShowDialog() == DialogResult.OK)
                                        {
                                            openOptionsCadLayoutToRender = lo.Cad.LayoutToRender = cadForm.LayoutToRender;
                                            openOptionsCadPaperBitDepth = lo.Cad.PaperBitDepth = cadForm.PaperBitDepth;
                                            openOptionsCadPaperHeight = lo.Cad.PaperHeight = cadForm.PaperHeight;
                                            openOptionsCadPaperResolutionUnits = lo.Cad.PaperResolutionUnits = cadForm.PaperResolutionUnits;
                                            openOptionsCadPaperResolutionX = lo.Cad.PaperResolutionX = cadForm.PaperResolutionX;
                                            openOptionsCadPaperResolutionY = lo.Cad.PaperResolutionY = cadForm.PaperResolutionY;
                                            openOptionsCadPaperWidth = lo.Cad.PaperWidth = cadForm.PaperWidth;

                                            SetGenericOpenOptions(lo, cadForm);
                                            dialogCancelled = false;
                                        }
                                    }
                                    break;
                                }
                            default:
                                {
                                    //don't know the image format, so just present load options that apply to any format
                                    using (OpenOptionsForm openForm = new OpenOptionsForm())
                                    {
                                        SetGenericOpenFormOptions(openForm, imageData);

                                        if (openForm.ShowDialog() == DialogResult.OK)
                                        {
                                            SetGenericOpenOptions(lo, openForm);
                                            dialogCancelled = false;
                                        }
                                    }
                                    break;
                                }
                        }

                        //only proceed if user didn't cancel the open options dialog
                        if (dialogCancelled == false)
                        {
                            openedFileName = openDlg.FileName;
                            loadOptionsChosen = lo;

                            return DialogResult.OK;
                        }
                    }
                }

                return DialogResult.Cancel;
            }
        }

        public DialogResult OpenWithoutOptions()
        {
            using (OpenFileDialog openDlg = new OpenFileDialog())
            {
                openDlg.Title = Constants.openImageString;
                openDlg.Filter = Constants.openFilterString;
                openDlg.FilterIndex = openFileFilterIndex;
                openDlg.InitialDirectory = openFileInitialDirectory;

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    openFileInitialDirectory = Path.GetDirectoryName(openDlg.FileName);
                    openFileFilterIndex = openDlg.FilterIndex;

                    openedFileName = openDlg.FileName;

                    return DialogResult.OK;
                }

                return DialogResult.Cancel;
            }
        }

        public DialogResult OpenCameraRaw()
        {
            using (OpenFileDialog openDlg = new OpenFileDialog())
            {
                openDlg.Title = Constants.openCameraRawString;
                openDlg.Filter = Constants.openCameraRawFilterString;
                openDlg.FilterIndex = openCameraRawFilterIndex;
                openDlg.InitialDirectory = openCameraRawInitialDirectory;

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    openCameraRawInitialDirectory = Path.GetDirectoryName(openDlg.FileName);
                    openCameraRawFilterIndex = openDlg.FilterIndex;

                    using (OpenOptionsCameraRawForm cameraRawForm = new OpenOptionsCameraRawForm())
                    {
                        SetGenericOpenFormOptions(cameraRawForm, null);
                        SetCameraRawFormOpenOptions(cameraRawForm);

                        if (cameraRawForm.ShowDialog() == DialogResult.OK)
                        {
                            Accusoft.ImagXpressSdk.LoadOptions lo = new Accusoft.ImagXpressSdk.LoadOptions();
                            lo.CameraRawEnabled = true;
                            SetCameraRawOpenOptions(cameraRawForm, lo);
                            SetGenericOpenOptions(lo, cameraRawForm);

                            openedFileName = openDlg.FileName;
                            loadOptionsChosen = lo;

                            return DialogResult.OK;
                        }
                    }
                }

                return DialogResult.Cancel;
            }
        }

        public DialogResult SaveWithOptions()
        {
            using (SaveFileDialog saveDlg = new SaveFileDialog())
            {
                saveDlg.Title = Constants.saveImageAsString;
                saveDlg.Filter = Constants.saveFilterString;
                saveDlg.FilterIndex = saveFileFilterIndex;
                saveDlg.InitialDirectory = saveFileInitialDirectory;

                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    saveFileInitialDirectory = Path.GetDirectoryName(saveDlg.FileName);
                    saveFileFilterIndex = saveDlg.FilterIndex;

                    Accusoft.ImagXpressSdk.SaveOptions so = new Accusoft.ImagXpressSdk.SaveOptions();
                    bool dialogCancelled = true;

                    switch (saveDlg.FilterIndex)
                    {
                        case 1:
                            {
                                so.Format = ImageXFormat.Bmp;

                                using (SaveOptionsBmpForm bmpForm = new SaveOptionsBmpForm())
                                {
                                    bmpForm.Compression = saveOptionsBmpCompression;

                                    if (bmpForm.ShowDialog() == DialogResult.OK)
                                    {
                                        saveOptionsBmpCompression = so.Bmp.Compression = bmpForm.Compression;

                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 3:
                            {
                                so.Format = ImageXFormat.Pic;

                                using (SaveOptionsPicForm picForm = new SaveOptionsPicForm())
                                {
                                    picForm.PicPassword = saveOptionsPicPassword;

                                    if (picForm.ShowDialog() == DialogResult.OK)
                                    {
                                        saveOptionsPicPassword = so.Pic.Password = picForm.PicPassword;
                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 4:
                            {
                                so.Format = ImageXFormat.Exif;

                                using (SaveOptionsExifForm exifForm = new SaveOptionsExifForm())
                                {
                                    exifForm.ThumbnailSize = saveOptionsExifThumbnailSize;

                                    if (exifForm.ShowDialog() == DialogResult.OK)
                                    {
                                        saveOptionsExifThumbnailSize = so.Exif.ThumbnailSize = exifForm.ThumbnailSize;

                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 5:
                            {
                                so.Format = ImageXFormat.Gif;

                                using (SaveOptionsGifForm gifForm = new SaveOptionsGifForm())
                                {
                                    gifForm.Interlaced = saveOptionsGifInterlaced;
                                    gifForm.TransparencyMatch = saveOptionsGifTransparencyMatch;
                                    gifForm.GifType = saveOptionsGifType;
                                    gifForm.TransparencyColor = saveOptionsGifTransparencyColor;

                                    if (gifForm.ShowDialog() == DialogResult.OK)
                                    {
                                        saveOptionsGifInterlaced = so.Gif.Interlaced = gifForm.Interlaced;
                                        saveOptionsGifTransparencyMatch = so.Gif.TransparencyMatch = gifForm.TransparencyMatch;
                                        saveOptionsGifType = so.Gif.Type = gifForm.GifType;
                                        saveOptionsGifTransparencyColor = so.Gif.TransparencyColor = gifForm.TransparencyColor;

                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 6:
                            {
                                so.Format = ImageXFormat.Ico;

                                using (SaveOptionsIconForm iconForm = new SaveOptionsIconForm())
                                {
                                    iconForm.MultiPage = saveOptionsIconMultiPage;

                                    if (image.PageCount > 1 || scannedImagePageCount > 1)
                                    {
                                        iconForm.MultiPageEnabled = true;
                                    }
                                    else
                                    {
                                        iconForm.MultiPageEnabled = false;
                                    }

                                    if (iconForm.ShowDialog() == DialogResult.OK)
                                    {
                                        saveOptionsIconMultiPage = so.Icon.MultiPage = iconForm.MultiPage;

                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 7:
                            {
                                so.Format = ImageXFormat.Jbig2;

                                using (SaveOptionsJbig2Form jbig2Form = new SaveOptionsJbig2Form())
                                {
                                    jbig2Form.EncodeModeCompression = saveOptionsJbig2EncodeModeCompression;
                                    jbig2Form.FileOrganization = saveOptionsJbig2FileOrganization;
                                    jbig2Form.InvertedRegion = saveOptionsJbig2InvertedRegion;
                                    jbig2Form.LoosenessCompression = saveOptionsJbig2LoosesnessCompression;

                                    if (jbig2Form.ShowDialog() == DialogResult.OK)
                                    {
                                        saveOptionsJbig2EncodeModeCompression = so.Jbig2.EncodeModeCompression = jbig2Form.EncodeModeCompression;
                                        saveOptionsJbig2FileOrganization = so.Jbig2.FileOrganization = jbig2Form.FileOrganization;
                                        saveOptionsJbig2InvertedRegion = so.Jbig2.InvertedRegion = jbig2Form.InvertedRegion;
                                        saveOptionsJbig2LoosesnessCompression = so.Jbig2.LoosenessCompression = jbig2Form.LoosenessCompression;

                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 8:
                            {
                                so.Format = ImageXFormat.Jpeg;

                                using (SaveOptionsJpegForm jpegForm = new SaveOptionsJpegForm())
                                {
                                    jpegForm.ColorRenderIntent = saveOptionsJpegColorRenderIntent;
                                    jpegForm.TargetProfileName = saveOptionsJpegTargetProfileName;
                                    jpegForm.TargetProfileInitialDirectory = saveOptionsJpegTargetProfileInitialDirectory;

                                    jpegForm.Chrominance = saveOptionsJpegChrominance;
                                    jpegForm.ColorSpace = saveOptionsJpegColorSpace;
                                    jpegForm.Cosited = saveOptionsJpegCosited;
                                    jpegForm.Grayscale = saveOptionsJpegGrayscale;
                                    jpegForm.Luminance = saveOptionsJpegLuminance;
                                    jpegForm.Progressive = saveOptionsJpegProgressive;
                                    jpegForm.SubSampling = saveOptionsJpegSubSampling;

                                    if (jpegForm.ShowDialog() == DialogResult.OK)
                                    {
                                        saveOptionsJpegChrominance = so.Jpeg.Chrominance = jpegForm.Chrominance;
                                        saveOptionsJpegColorSpace = so.Jpeg.ColorSpace = jpegForm.ColorSpace;
                                        saveOptionsJpegCosited = so.Jpeg.Cosited = jpegForm.Cosited;

                                        saveOptionsJpegLuminance = so.Jpeg.Luminance = jpegForm.Luminance;
                                        saveOptionsJpegProgressive = so.Jpeg.Progressive = jpegForm.Progressive;
                                        saveOptionsJpegSubSampling = so.Jpeg.SubSampling = jpegForm.SubSampling;

                                        if (jpegForm.GrayscaleEnabled)
                                        {
                                            saveOptionsJpegGrayscale = so.Jpeg.Grayscale = jpegForm.Grayscale;
                                        }

                                        saveOptionsJpegColorRenderIntent = so.ColorRenderIntent = jpegForm.ColorRenderIntent;
                                        saveOptionsJpegTargetProfileName = so.TargetProfileName = jpegForm.TargetProfileName;
                                        saveOptionsJpegTargetProfileInitialDirectory = jpegForm.TargetProfileInitialDirectory;

                                        if (!String.IsNullOrEmpty(jpegForm.TargetProfileName))
                                        {
                                            so.UseEmbeddedColorManagement = true;
                                        }

                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 9:
                            {
                                so.Format = ImageXFormat.Jpeg2000;

                                using (SaveOptionsJpeg2000Form jpeg2000Form = new SaveOptionsJpeg2000Form())
                                {
                                    jpeg2000Form.SetTileWidthMax(image.Width);
                                    jpeg2000Form.SetTileHeightMax(image.Height);

                                    jpeg2000Form.Grayscale = saveOptionsJp2Grayscale;
                                    jpeg2000Form.CompressSize = saveOptionsJp2CompressSize;
                                    jpeg2000Form.ProgressionOrder = saveOptionsJp2ProgressionOrder;
                                    jpeg2000Form.PeakSignalToNoiseRatio = saveOptionsJp2PeakSignalToNoiseRatio;
                                    jpeg2000Form.TileWidth = saveOptionsJp2TileWidth;
                                    jpeg2000Form.TileHeight = saveOptionsJp2TileHeight;
                                    jpeg2000Form.Jp2Type = saveOptionsJp2Type;

                                    if (jpeg2000Form.ShowDialog() == DialogResult.OK)
                                    {
                                        saveOptionsJp2CompressSize = so.Jp2.CompressSize = jpeg2000Form.CompressSize;
                                        saveOptionsJp2Grayscale = so.Jp2.Grayscale = jpeg2000Form.Grayscale;
                                        saveOptionsJp2ProgressionOrder = so.Jp2.Order = jpeg2000Form.ProgressionOrder;
                                        saveOptionsJp2PeakSignalToNoiseRatio = so.Jp2.PeakSignalToNoiseRatio = jpeg2000Form.PeakSignalToNoiseRatio;
                                        saveOptionsJp2TileWidth = jpeg2000Form.TileWidth;
                                        saveOptionsJp2TileHeight = jpeg2000Form.TileHeight;
                                        so.Jp2.TileSize = new Size(jpeg2000Form.TileWidth, jpeg2000Form.TileHeight);
                                        saveOptionsJp2Type = so.Jp2.Type = jpeg2000Form.Jp2Type;

                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 10:
                            {
                                so.Format = ImageXFormat.JpegLs;

                                using (SaveOptionsJlsForm jlsForm = new SaveOptionsJlsForm())
                                {
                                    jlsForm.Interleave = saveOptionsJlsInterleave;
                                    jlsForm.MaxValue = saveOptionsJlsMaxValue;
                                    jlsForm.Near = saveOptionsJlsNear;
                                    jlsForm.PointPrecision = saveOptionsJlsPointPrecision;

                                    if (jlsForm.ShowDialog() == DialogResult.OK)
                                    {
                                        saveOptionsJlsInterleave = so.Jls.Interleave = jlsForm.Interleave;
                                        saveOptionsJlsMaxValue = so.Jls.MaxValue = jlsForm.MaxValue;
                                        saveOptionsJlsNear = so.Jls.Near = jlsForm.Near;
                                        saveOptionsJlsPointPrecision = so.Jls.Point = jlsForm.PointPrecision;

                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 11:
                            {
                                so.Format = ImageXFormat.JpegXR;

                                using (SaveOptionsJpegXRForm jpegXRForm = new SaveOptionsJpegXRForm())
                                {
                                    jpegXRForm.FrequencyOrdering = saveOptionsJpegXRFrequencyOrdering;
                                    jpegXRForm.Quantization = saveOptionsJpegXRQuantization;
                                    jpegXRForm.ChromaSubSampling = saveOptionsJpegXRChromaSubSampling;

                                    if (jpegXRForm.ShowDialog() == DialogResult.OK)
                                    {
                                        saveOptionsJpegXRChromaSubSampling = so.JpegXR.ChromaSubSampling = jpegXRForm.ChromaSubSampling;
                                        saveOptionsJpegXRFrequencyOrdering = so.JpegXR.FrequencyOrdering = jpegXRForm.FrequencyOrdering;
                                        saveOptionsJpegXRQuantization = so.JpegXR.Quantization = jpegXRForm.Quantization;

                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 12:
                            {
                                so.Format = ImageXFormat.LosslessJpeg;

                                using (SaveOptionsLjpForm ljpForm = new SaveOptionsLjpForm())
                                {
                                    ljpForm.Method = saveOptionsLjpMethod;
                                    ljpForm.Order = saveOptionsLjpOrder;
                                    ljpForm.Predictor = saveOptionsLjpPredictor;
                                    ljpForm.LjpType = saveOptionsLjpType;

                                    if (ljpForm.ShowDialog() == DialogResult.OK)
                                    {
                                        saveOptionsLjpMethod = so.Ljp.Method = ljpForm.Method;
                                        saveOptionsLjpOrder = so.Ljp.Order = ljpForm.Order;
                                        saveOptionsLjpPredictor = so.Ljp.Predictor = ljpForm.Predictor;
                                        saveOptionsLjpType = so.Ljp.Type = ljpForm.LjpType;

                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 13:
                            {
                                so.Format = ImageXFormat.Modca;

                                using (SaveOptionsModcaForm modcaForm = new SaveOptionsModcaForm())
                                {
                                    modcaForm.DocumentName = saveOptionsModcaDocumentName;

                                    if (modcaForm.ShowDialog() == DialogResult.OK)
                                    {
                                        saveOptionsModcaDocumentName = so.Modca.DocumentName = modcaForm.DocumentName;

                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 14:
                        case 15:
                        case 17:
                            {
                                switch (saveDlg.FilterIndex)
                                {
                                    case 15:
                                        {
                                            so.Format = ImageXFormat.Pbm;
                                            break;
                                        }
                                    case 16:
                                        {
                                            so.Format = ImageXFormat.Pgm;
                                            break;
                                        }
                                    case 18:
                                        {
                                            so.Format = ImageXFormat.Ppm;
                                            break;
                                        }
                                }

                                goto default;
                            }
                        case 16:
                            {
                                so.Format = ImageXFormat.Png;

                                using (SaveOptionsPngForm pngForm = new SaveOptionsPngForm())
                                {
                                    pngForm.Interlaced = saveOptionsPngInterlaced;
                                    pngForm.TransparencyMatch = saveOptionsPngTransparencyMatch;
                                    pngForm.TransparencyColor = saveOptionsPngTransparencyColor;

                                    if (pngForm.ShowDialog() == DialogResult.OK)
                                    {
                                        saveOptionsPngInterlaced = so.Png.Interlaced = pngForm.Interlaced;
                                        saveOptionsPngTransparencyColor = so.Png.TransparencyColor = pngForm.TransparencyColor;
                                        saveOptionsPngTransparencyMatch = so.Png.TransparencyMatch = pngForm.TransparencyMatch;

                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 18:
                            {
                                so.Format = ImageXFormat.Tiff;

                                using (SaveOptionsTifForm tifForm = new SaveOptionsTifForm())
                                {
                                    tifForm.ColorRenderIntent = saveOptionsTifColorRenderIntent;
                                    tifForm.TargetProfileName = saveOptionsTifTargetProfileName;
                                    tifForm.TargetProfileInitialDirectory = saveOptionsTifTargetProfileInitialDirectory;

                                    tifForm.SetIFDOffsetMax(image.ImageXData.Size);

                                    tifForm.ByteOrder = saveOptionsTifByteOrder;
                                    tifForm.ColorSpace = saveOptionsTifColorSpace;
                                    tifForm.BitsPerPixel = image.BitsPerPixel;

                                    if (image.BitsPerPixel == 1)
                                    {
                                        tifForm.SetCompressionEntries(new string[] { 
                                        Constants.noneString, Constants.rleString, Constants.lzwString, 
                                        Constants.packBitsString, Constants.group31DString, Constants.group32DString, 
                                        Constants.group4String });
                                        tifForm.Compression = saveOptionsTif1BppCompression;
                                    }
                                    else
                                    {
                                        tifForm.SetCompressionEntries(new string[] { 
                                        Constants.noneString, Constants.lzwString, Constants.packBitsString, 
                                        Constants.deflateString, Constants.jpegString, Constants.jpeg7String });
                                        tifForm.Compression = saveOptionsTifNon1BppCompression;
                                    }

                                    tifForm.IFDOffset = saveOptionsTifIFDOffset;
                                    tifForm.MultiPage = saveOptionsTifMultiPage;

                                    if (image.PageCount > 1 || scannedImagePageCount > 1)
                                    {
                                        tifForm.MultiPageEnabled = true;
                                    }
                                    else
                                    {
                                        tifForm.MultiPageEnabled = false;
                                    }

                                    tifForm.RowsPerStrip = saveOptionsTifRowsPerStrip;
                                    tifForm.UseIFDOffset = saveOptionsTifUseIFDOffset;

                                    if (tifForm.ShowDialog() == DialogResult.OK)
                                    {
                                        saveOptionsTifByteOrder = so.Tiff.ByteOrder = tifForm.ByteOrder;
                                        saveOptionsTifColorSpace = so.Tiff.ColorSpace = tifForm.ColorSpace;
                                        if (image.BitsPerPixel == 1)
                                        {
                                            saveOptionsTif1BppCompression = so.Tiff.Compression = tifForm.Compression;
                                        }
                                        else
                                        {
                                            saveOptionsTifNon1BppCompression = so.Tiff.Compression = tifForm.Compression;
                                        }
                                        saveOptionsTifIFDOffset = so.Tiff.IFDOffset = tifForm.IFDOffset;
                                        if (tifForm.MultiPageEnabled)
                                        {
                                            saveOptionsTifMultiPage = so.Tiff.MultiPage = tifForm.MultiPage;
                                        }
                                        saveOptionsTifRowsPerStrip = so.Tiff.RowsPerStrip = tifForm.RowsPerStrip;
                                        saveOptionsTifUseIFDOffset = so.Tiff.UseIFDOffset = tifForm.UseIFDOffset;

                                        saveOptionsTifColorRenderIntent = so.ColorRenderIntent = tifForm.ColorRenderIntent;
                                        saveOptionsTifTargetProfileName = so.TargetProfileName = tifForm.TargetProfileName;
                                        saveOptionsTifTargetProfileInitialDirectory = tifForm.TargetProfileInitialDirectory;

                                        if (!String.IsNullOrEmpty(tifForm.TargetProfileName))
                                        {
                                            so.UseEmbeddedColorManagement = true;
                                        }

                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 20:
                            {
                                so.Format = ImageXFormat.Wsq;

                                using (SaveOptionsWsqForm wsqForm = new SaveOptionsWsqForm())
                                {
                                    wsqForm.Black = saveOptionsWsqBlack;
                                    wsqForm.White = saveOptionsWsqWhite;
                                    wsqForm.Quantization = saveOptionsWsqQuantization;

                                    if (wsqForm.ShowDialog() == DialogResult.OK)
                                    {
                                        saveOptionsWsqBlack = so.Wsq.Black = wsqForm.Black;
                                        saveOptionsWsqQuantization = so.Wsq.Quantization = wsqForm.Quantization;
                                        saveOptionsWsqWhite = so.Wsq.White = wsqForm.White;

                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 21:
                            {
                                so.Format = ImageXFormat.WirelessBmp;

                                goto default;
                            }
                        case 22:
                            {
                                so.Format = ImageXFormat.Dcx;

                                using (SaveOptionsDcxForm dcxForm = new SaveOptionsDcxForm())
                                {
                                    dcxForm.MultiPage = saveOptionsDcxMultiPage;

                                    if (image.PageCount > 1 || scannedImagePageCount > 1)
                                    {
                                        dcxForm.MultiPageEnabled = true;
                                    }
                                    else
                                    {
                                        dcxForm.MultiPageEnabled = false;
                                    }

                                    if (dcxForm.ShowDialog() == DialogResult.OK)
                                    {
                                        if (dcxForm.MultiPageEnabled)
                                        {
                                            saveOptionsDcxMultiPage = so.Dcx.MultiPage = dcxForm.MultiPage;
                                        }

                                        dialogCancelled = false;
                                    }
                                }
                                break;
                            }
                        case 23:
                            {
                                so.Format = ImageXFormat.Pcx;

                                goto default;
                            }
                        default:
                            {
                                dialogCancelled = false;

                                break;
                            }
                    }

                    if (dialogCancelled == false)
                    {
                        savedFileName = saveDlg.FileName;
                        saveOptionsChosen = so;

                        return DialogResult.OK;
                    }
                }

                return DialogResult.Cancel;
            }
        }

        public DialogResult SaveWithNoOptions()
        {
            using (SaveFileDialog saveDlg = new SaveFileDialog())
            {
                saveDlg.Title = Constants.saveImageAsString;
                saveDlg.Filter = Constants.saveFilterString;
                saveDlg.FilterIndex = saveFileFilterIndex;
                saveDlg.InitialDirectory = saveFileInitialDirectory;

                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    saveFileInitialDirectory = Path.GetDirectoryName(saveDlg.FileName);
                    saveFileFilterIndex = saveDlg.FilterIndex;
                    savedFileName = saveDlg.FileName;

                    return DialogResult.OK;
                }
                else
                {
                    return DialogResult.Cancel;
                }
            }
        }

        public void DisposeOfImageX()
        {
            if (image != null)
            {
                image.Dispose();
                image = null;
            }
        }

        public static void ShowBalloonToolTipWarning(int controlLocationRight, int controlLocationTop, 
            int tooltipInitialDelay, int tooltipDuration, string title, 
            string warning, IWin32Window window)
        {
            ToolTip cmykToolTip = new ToolTip();
            cmykToolTip.IsBalloon = true;
            cmykToolTip.ToolTipIcon = ToolTipIcon.Warning;
            cmykToolTip.ToolTipTitle = title;
            cmykToolTip.InitialDelay = tooltipInitialDelay;
            cmykToolTip.Show(warning, window,
                new Point(controlLocationRight, controlLocationTop), tooltipDuration);
        }

        public static ImageX TransformIfGrayscale(ImageX image)
        {
            //if grayscale image, then apply transform so it will be 8-bit so we can work with the image (edit, copy, save, etc.)
            if (image.BitsPerPixel > 8 && image.BitsPerPixel <= 16)
            {
                using (ImagXpress ix = new ImagXpress())
                {
                    using (Processor proc = new Processor(ix, image))
                    {
                        proc.ApplyGrayscaleTransform(0, 0);

                        return proc.Image;
                    }
                }
            }

            return null;
        }

        public static void AdjustFontSizeToFit(string text, ref float fontSize, bool? shouldSizeIncrease, Size imageSize)
        {
            Font font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold | FontStyle.Underline);
            Size actualSize = TextRenderer.MeasureText(text, font);

            bool shouldSizeIncreaseBool = false;
            if (shouldSizeIncrease != null)
            {
                shouldSizeIncreaseBool = (bool)shouldSizeIncrease;
            }

            if ((!shouldSizeIncreaseBool || shouldSizeIncrease == null)
                && (actualSize.Width >= Constants.watermarkDimensionPercentage * imageSize.Width 
                || actualSize.Height >= Constants.watermarkDimensionPercentage * imageSize.Height))
            {
                if (fontSize > Constants.defaultFontIncrementSize)
                {
                    //the watermark at the current size won't fit, so decrement font size and test to see if it fits
                    shouldSizeIncreaseBool = false;
                    fontSize -= Constants.defaultFontIncrementSize;
                    if (font != null)
                    {
                        font.Dispose();
                        font = null;
                    }
                    font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold | FontStyle.Underline);

                    AdjustFontSizeToFit(text, ref fontSize, shouldSizeIncreaseBool, imageSize);
                }
                else
                {
                    //image is so small we could possibly add a watermark that would fit but it isn't going to be legible
                    //so set the size to 0 to indicate a watermark should be skipped
                    fontSize = 0;
                }
            }
            else if ((shouldSizeIncreaseBool || shouldSizeIncrease == null)
                && (actualSize.Width < imageSize.Width * Constants.watermarkWidthPercentage))
            {
                //the watermark at the current size will be too small, increment font size and test to see if it fits
                shouldSizeIncreaseBool = true;
                fontSize += Constants.defaultFontIncrementSize;
                if (font != null)
                {
                    font.Dispose();
                    font = null;
                }
                font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold | FontStyle.Underline);

                AdjustFontSizeToFit(text, ref fontSize, shouldSizeIncreaseBool, imageSize);
            }
        }

        public static void BrandImage(ImageXView imageView, MemoryStream data, int bpp)
        {
            try
            {
                using (NotateXpress nx = new NotateXpress())
                {
                    //connect ImagXpress and NoteXpress
                    nx.ClientWindow = imageView.Handle;
                    using (Layer layer = new Layer())
                    {
                        //load the annotation data and brand the image
                        nx.Layers.Add(layer);
                        nx.Layers.FromMemoryStream(data, new Accusoft.NotateXpressSdk.LoadOptions());
                        nx.Layers.Brand(bpp);
                    }
                }
            }
            catch (BrandingException ex)
            {
                MessageBox.Show(ex.Message, Constants.brandingErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsWatemarkNeeded()
        {
            /*LICENSED is only defined for a special bulid of the demo compiled into a standalone exe
             * where watermarking limits functionality.  If you're building the Demo yourself LICENSED
             * won't be defined (unless you explicitly add a preprocessor definition for it).  The only
             * trial behavior you will see will depend on if you have a trial license for the toolkits on
             * your machine.
             */
            #if LICENSED
                return true;
            #else
                return false;
            #endif
        }

        public static void WatermarkImage(ImageXView imageView, int bpp)
        {
            try
            {
                using (NotateXpress nx = new NotateXpress())
                {
                    //connect ImagXpress and NoteXpress
                    nx.ClientWindow = imageView.Handle;
                    using (Layer layer = new Layer())
                    {
                        nx.Layers.Add(layer);

                        using (TextTool textElement = new TextTool())
                        {
                            textElement.Text = Constants.demoString + Constants.accusoftString;
                            //center image
                            textElement.BoundingRectangle =
                                new Rectangle(imageView.Image.ImageXData.Width / 6, imageView.Image.ImageXData.Height * 2 / 5, 0, 0);
                            textElement.BackStyle = BackStyle.Translucent;
                            textElement.TextColor = Color.Red;
                            textElement.AutoSize = Accusoft.NotateXpressSdk.AutoSize.ToContents;
                            textElement.TextJustification = TextJustification.Center;

                            Size imageSize = new Size(imageView.Image.ImageXData.Width, imageView.Image.ImageXData.Height);

                            float fontSize = Constants.defaultFontSize;
                            AdjustFontSizeToFit(textElement.Text, ref fontSize, null, imageSize);

                            //for very small images a watermark won't fit legibly, this is indicated by a size of 0 being returned, 
                            //in this case don't apply the watermark
                            if (fontSize > 0)
                            {
                                textElement.TextFont = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold | FontStyle.Underline);

                                //add the watermark and brand the image
                                nx.Layers[0].Elements.Add(textElement);
                                nx.Layers.Brand(bpp);
                            }
                        }
                    }
                }
            }
            catch (BrandingException ex)
            {
                MessageBox.Show(ex.Message, Constants.watermarkErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}