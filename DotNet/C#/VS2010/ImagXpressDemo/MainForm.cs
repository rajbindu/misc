/********************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.        *
* This sample code is provided to Pegasus licensees "as is"         *
* with no restrictions on use or modification. No warranty for      *
* use of this sample code is provided by Pegasus.                   *
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Accusoft.ImagXpressSdk;
using Accusoft.ISISXpressSdk;
using Accusoft.NotateXpressSdk;
using Accusoft.ThumbnailXpressSdk;
using Accusoft.TwainProSdk;

namespace ImagXpressDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ImageX imageTags;
        #region Fields

        private IsisXpress isisXpress1;

        private PrinterSettings printerSettings = new PrinterSettings();
        private Point pixelSelectionBeginPoint;
        private Point pixelSelectionEndPoint;
        private int printPageCounter = 1;

        private Point viewSelectionBeginPoint;
        private Point viewSelectionEndPoint;

        private ToolStripButton[] viewAndAnnotationToolButtons;
           
        private ChannelSelection histogramChannelSelection = ChannelSelection.Red;

        public Color defaultPhotoProcessingColor = Color.Blue;
        public Color defaultProcessingColor = Color.White;

        private bool currentlyOpenedImageHasBeenEdited;

        private short processingBrightnessBrightnessIntensity = 50;
        private float processingBrightnessGammaGamma = .10f;
        private DeskewType processingClarifyDeskewDeskewType = DeskewType.Normal;
        private Color processingClarifyDeskewBackgroundColor;
        private int processingClarifyDeskewOneBitBackgroundColor;
        private short processingColorBalanceColorBalanceManualColor = 100;
        private int processingColorBalanceColorBalanceManualRed = 50;
        private int processingColorBalanceColorBalanceManualGreen = 20;
        private int processingColorBalanceColorBalanceManualBlue = 40;
        private AdjustType processingColorModifyAdjustHSLAdjustType = AdjustType.AsPercent;
        private int processingColorModifyAdjustHSLHue = 25;
        private int processingColorModifyAdjustHSLSaturation = 50;
        private int processingColorModifyAdjustHSLLuminance = 30;
        private int processingColorModifyAdjustRGBRed = 75;
        private int processingColorModifyAdjustRGBGreen = 10;
        private int processingColorModifyAdjustRGBBlue = 30;
        private AdjustType processingColorModifyAdjustRGBAdjustType = AdjustType.AsPercent;
        private Color processingColorModifyReplaceColorsFromColor = Color.Black;
        private Color processingColorModifyReplaceColorsToColor = Color.Gray;
        private Color processingColorModifyReplaceColorsReplaceColor = Color.Purple;
        private int processingColorModifyColorDepthBpp = 1;
        private PaletteType processingColorModifyColorDepthPaletteType = PaletteType.Optimized;
        private DitherType processingColorModifyColorDepthDitherType = DitherType.NoDither;
        private short processingContrastManualContrastIntensity = 20;
        private short processingContrastManualLightnessShadows = 40;
        private short processingContrastManualLightnessHighlights = 50;
        private Rectangle processingCropManualCrop;
        private float processingCropBorderCropPercentToCrop = 90;
        private CropType processingCropBorderCropCropType = CropType.CropBorderBackgroundColor;
        private Point processingCropAutoCropBorderPoint;
        private float processingCropAutoCropPercentToCrop = 10;
        private double processingOrientationRotateAngle = 60;
        private Color processingOrientationRotateBackgroundColor;
        private int processingOrientationRotateOneBitBackgroundColor;
        private RedeyeGlare processingRedEyeRemovalAutoGlare = RedeyeGlare.None;
        private RedeyeShade processingRedEyeRemovalAutoShade = RedeyeShade.Normal;
        private bool processingRedEyeRemovalAutoUseRedEyeRectangles;
        private RedeyeGlare processingRedEyeRemovalManualGlare = RedeyeGlare.None;
        private RedeyeShade processingRedEyeRemovalManualShade = RedeyeShade.Normal;
        private RedeyePrecision processingRedEyeRemovalManualPrecision = RedeyePrecision.Imprecise;
        private int processingRemoveDustThreshold;
        private int processingRemoveDustFilterAdjustment;
        private int processingRemoveDustSmoothingAdjustment;
        private DefectType processingRemoveDustDefectType = DefectType.LightDefect;
        private Point processingRemoveScratchesStartingPoint;
        private Point processingRemoveScratchesEndingPoint;
        private int processingRemoveScratchesLineWidth = 10;
        private int processingRemoveScratchesThreshold;
        private int processingRemoveScratchesFilterAdjustment;
        private int processingRemoveScratchesSmoothingAdjustment;
        private DefectType processingRemoveScratchesDefectType = DefectType.LightDefect;
        private Size processingResizeNewSize;
        private bool processingResizeScaleToGray;
        private bool processingResizeScaleToPreserveBlack;
        private ResizeType processingResizeResizeType = ResizeType.Quality;
        private int processingResizeSizeSelection = 6;
        private bool processingResizeHasBeenSet;
        private int processingSharpenSharpenIntensity = 10;
        private SharpenFilter processingSharpenSharpenFilter = SharpenFilter.SharpenFilter1;
        private int processingSharpenUnsharpenIntensity = 10;
        private UnsharpenFilter processingSharpenUnsharpenFilter = UnsharpenFilter.UnsharpenFilter1;
        private int processingSharpenSoftenIntensity = 10;
        private SoftenFilter processingSharpenSoftenFilter = SoftenFilter.SoftenFilter0;
        private MergeSize processingAlphaMergeMergeSize = MergeSize.Crop;
        private MergeStyle processingAlphaMergeMergeStyle = MergeStyle.Normal;
        private bool processingAlphaMergeTransparent;
        private Color processingAlphaMergeTransparentColor;
        private int processingAlphaMergePercentHigh;
        private int processingAlphaMergePercentLow;
        private string processingAlphaMergeSourceImage;
        private int processingBlendIntensity = 50;
        private ButtonStyle processingButtonizeButtonStyle = ButtonStyle.Inset;
        private int processingButtonizeBevelIntensity = 100;
        private int processingButtonizeBevelWidth = 100;
        private short[] processingMatrixArray = new short[9] { 0, -1, 0, -1, 5, -1, 0, -1, 0 };
        private short processingMatrixIntensity = 3;
        private short processingMatrixDivisor= 5;
        private int processingMosaicBlockSize = 25;
        private int processingMotionBlurIntensity = 5;
        private int processingMotionBlurVelocityX = 5;
        private int processingMotionBlurVelocityY;
        private int processingNoiseFrequency = 20;
        private int processingNoiseIntensity = 100;
        private ParabolicType processingParabolicType = ParabolicType.Convex;
        private int processingPerspectivePercent;
        private PerspectiveType processingPerspectiveType = PerspectiveType.TopToBottom;
        private Color processingPerspectiveBackgroundColor;
        private int processingPinchIntensity = 50;
        private Point processingPolynomialWarpPoint1;
        private Point processingPolynomialWarpPoint2;
        private Point processingPolynomialWarpPoint3;
        private Point processingPolynomialWarpPoint4;
        private Color processingPolynomialWarpBackgroundColor;
        private bool processingPolynomialWarpHasBeenSet;
        private int processingPosterizeNumberOfLevels = 2;
        private RippleDirection processingRippleDirection = RippleDirection.Horizontal;
        private int processingRippleIntensity = 25;
        private int processingRippleFrequency = 2;
        private int processingSolarizeThreshold;
        private double processingSwirlDegrees = 60;
        private Size processingTileTileSize;
        private bool processingTileSizeHasBeenSet;
        private int processingTwistBlockSize = 15;
        private TwistRotation processingTwistRotation = TwistRotation.Rotate90;

        private BinarizeMode processingBinarizeMode = BinarizeMode.QuickText;
        private int processingBinarizeLowThreshold = 170;
        private int processingBinarizeHighThreshold = 190;
        private int processingBinarizeGridAngle;
        private int processingBinarizeGridPitch = 1;
        private int processingBinarizeEccentricity;
        private int processingBinarizeLceFactor = 1;
        private BinarizeBlur processingBinarizeBlur = BinarizeBlur.NoBlur;
        private double processingDeskewMinimumAngle = .2;
        private short processingDeskewMinimumConfidence = 50;
        private Color processingDeskewPadColor = Color.White;
        private bool processingDeskewMaintainOriginalSize;
        private short processingDeskewQuality = 80;
        private short processingDespeckleWidth = 2;
        private short processingDespeckleHeight= 2;
        private short processingDilateAmount = 1;
        private EnhancementDirection processingDilateDirection = EnhancementDirection.All;
        private short processingErodeAmount = 1;
        private EnhancementDirection processingErodeDirection = EnhancementDirection.All;
        private int processingLineRemovalMinimumLength = 50;
        private short processingLineRemovalMaximumThickness = 20;
        private double processingLineRemovalMinimumAspectRatio = 12;
        private short processingLineRemovalMaximumGap = 1;
        private short processingLineRemovalMaximumCharacterRepairSize = 20;
        private short processingBlobRemovalMinimumDensity = 65;
        private int processingBlobRemovalMinimumPixelCount = 300;
        private int processingBlobRemovalMaximumPixelCount = 10000;

        private SeparationType imageColorSeparationSeparationType = SeparationType.Rgb;
        private bool imageColorSeparationRgbaRed = true;
        private bool imageColorSeparationRgbaBlue, imageColorSeparationRgbaGreen, imageColorSeparationRgbaAlpha;
        private bool imageColorSeparationHslHue = true;
        private bool imageColorSeparationHslSaturation, imageColorSeparationHslLuminance;
        private bool imageColorSeparationCmyCyan = true;
        private bool imageColorSeparationCmyMagenta, imageColorSeparationCmyYellow;
        private bool imageColorSeparationCmykCyan = true;
        private bool imageColorSeparationCmykMagenta, imageColorSeparationCmykYellow, imageColorSeparationCmykBlack;
        private bool imageColorSeparationRgbRed = true;
        private bool imageColorSeparationRgbBlue, imageColorSeparationRgbGreen;

        private Color processingAlphaAlphaFlatten;

        private Helper helper = new Helper();

        private bool twainShowUserInterface = true;
        private DataSourceManagerVersion twainDataSourceManagerVersion;

        private string fontShowSettingsString = ">";
        private string fontHideSettingsString = "^";
        private string hideSettingsString = "-";
        private string showSettingsString = "+";
        private string welcomeString = "Welcome to the ImagXpress Demo!";

        private int defaultAspectXRatio;
        private int defaultAspectYRatio;
        private Font defaultFont;

        private const int openFileAllFilesFilterIndex = 30;
        private int openFileFilterIndex;
        private string openFileInitialDirectory;

        private int openCameraRawFilterIndex;
        private const int openCameraRawAllFilesFilterIndex = 23;
        private string openCameraRawInitialDirectory;

        private int openProfileNameFilterIndex;
        private string openProfileNameInitialDirectory;

        private string scanTwainSaveInitialDirectory;
        private string scanIsisSaveInitialDirectory;

        private int paletteNameFilterIndex;
        private string paletteNameInitialDirectory;

        private int saveFileFilterIndex;
        private string saveFileInitialDirectory;

        private int mergeSourceImageFilterIndex;
        private string mergeSourceImageInitialDirectory;

        private IXResolutionUnit imageInfoResolutionUsed = IXResolutionUnit.Inch;

        private int thumbnailSettingsHiddenSplitterDistance;
        private int thumbnailSettingsShownSplitterDistance;
        private int thumbnailImageSplitterDistance;
        private bool mainFormPreviouslyMaximized;

        #endregion

        [DllImport(Constants.kernel32String)]
        static extern UIntPtr GlobalSize(IntPtr hMem);

        [DllImport(Constants.kernel32String)]
        static extern IntPtr GlobalFree(IntPtr hMem);

        private enum ProfileType
        {
            Monitor = 0,
            Target = 1,
            Printer = 2,
        }

        #if LICENSED
            Licensing license = new Licensing();
        #endif

        #region Event Handlers

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            using (SplashForm splashForm = new SplashForm())
            {
                splashForm.ShowDialog();
            }


            //**The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime**
            //imagXpress1.Licensing.SetSolutionName("YourSolutionName");
            //imagXpress1.Licensing.SetSolutionKey(12345, 12345, 12345, 12345);
            //imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation…");
            //thumbnailXpress1.Licensing.SetSolutionName("YourSolutionName");
            //thumbnailXpress1.Licensing.SetSolutionKey(12345, 12345, 12345, 12345);
            //thumbnailXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformationâ€¦");
            //thumbnailXpress1.Licensing.SetIXSolutionName("YourSolutionName");
            //thumbnailXpress1.Licensing.SetIXSolutionKey(12345, 12345, 12345, 12345);
            //thumbnailXpress1.Licensing.SetIXOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformationâ€¦");
            //twainPro1.Licensing.SetSolutionName("YourSolutionName");
            //twainPro1.Licensing.SetSolutionKey(12345, 12345, 12345, 12345);
            //twainPro1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation…");
            //printPro1.Licensing.SetSolutionName("YourSolutionName");
            //printPro1.Licensing.SetSolutionKey(12345, 12345, 12345, 12345);
            //printPro1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation…");


#if LICENSED
            license.ObtainRuntimeLicensing();

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
                
                thumbnailXpress1.Licensing.SetSolutionName(license.SolutionName);
                if (System.IntPtr.Size == 8)
                {
                    thumbnailXpress1.Licensing.SetSolutionKey(license.Solution64Key1, license.Solution64Key2, license.Solution64Key3, license.Solution64Key4);
                }
                else
                {
                    thumbnailXpress1.Licensing.SetSolutionKey(license.Solution32Key1, license.Solution32Key2, license.Solution32Key3, license.Solution32Key4);
                }
                thumbnailXpress1.Licensing.SetOEMLicenseKey(license.OEMLicenseKeyThumbnailXpress);
                thumbnailXpress1.Licensing.SetIXSolutionName(license.SolutionName);
                if (System.IntPtr.Size == 8)
                {
                    thumbnailXpress1.Licensing.SetIXSolutionKey(license.Solution64Key1, license.Solution64Key2, license.Solution64Key3, license.Solution64Key4);
                }
                else
                {
                    thumbnailXpress1.Licensing.SetIXSolutionKey(license.Solution32Key1, license.Solution32Key2, license.Solution32Key3, license.Solution32Key4);
                }
                thumbnailXpress1.Licensing.SetIXOEMLicenseKey(license.OEMLicenseKeyImagXpress);
                
                twainPro1.Licensing.SetSolutionName(license.SolutionName);
                if (System.IntPtr.Size == 8)
                {
                    twainPro1.Licensing.SetSolutionKey(license.Solution64Key1, license.Solution64Key2, license.Solution64Key3, license.Solution64Key4);
                }
                else
                {
                    twainPro1.Licensing.SetSolutionKey(license.Solution32Key1, license.Solution32Key2, license.Solution32Key3, license.Solution32Key4);
                }
                twainPro1.Licensing.SetOEMLicenseKey(license.OEMLicenseKeyTwainPro);

                printPro1.Licensing.SetSolutionName(license.SolutionName);
                if (System.IntPtr.Size == 8)
                {
                    printPro1.Licensing.SetSolutionKey(license.Solution64Key1, license.Solution64Key2, license.Solution64Key3, license.Solution64Key4);
                }
                else
                {
                    printPro1.Licensing.SetSolutionKey(license.Solution32Key1, license.Solution32Key2, license.Solution32Key3, license.Solution32Key4);
                }
                printPro1.Licensing.SetOEMLicenseKey(license.OEMLicenseKeyPrintPro);
            }
#endif

            defaultFont = thumbnailXpress1.Font;

            notateXpress1.ClientWindow = imageXView1.Handle;
            thumbnailXpress1.NotateXpressInstance = notateXpress1.InstanceHandle;

            SetDefaults();
            SetViewDefaults();
            SetColorDefaults();
            SetThumbnailDefaults();

            thumbnailImageSplitterDistance = ThumbnailImageSplitContainer.SplitterDistance;

            thumbnailSettingsShownSplitterDistance = ThumbnailSettingsSplitContainer.SplitterDistance;
            ThumbnailSettingsSplitContainer.SplitterDistance += ThumbnailSettingsSplitContainer.Panel2.Height - ShowHideSettingsPanel.Height;
            thumbnailSettingsHiddenSplitterDistance = ThumbnailSettingsSplitContainer.SplitterDistance;

            if (IntPtr.Size == 4)
            {
                //ISISXpress only works in a 32-bit context
                isisXpress1 = new IsisXpress();


                //**The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime**
                //isisXpress1.Licensing.SetSolutionName("YourSolutionName");
                //isisXpress1.Licensing.SetSolutionKey(12345, 12345, 12345, 12345);
                //isisXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation…");


#if LICENSED
                if (license.Unlocked)
                {
                    isisXpress1.Licensing.SetSolutionName(license.SolutionName);
                    isisXpress1.Licensing.SetSolutionKey(license.Solution32Key1, license.Solution32Key2, license.Solution32Key3, license.Solution32Key4);
                    isisXpress1.Licensing.SetOEMLicenseKey(license.OEMLicenseKeyISISXpress);
                }
#endif
            }

            //Zoom menu item is first entry and has its own submenu
            for (int contextMenuIndex = 0; contextMenuIndex < imageXView1.ContextMenu.MenuItems[0].MenuItems.Count; contextMenuIndex++)
            {
                imageXView1.ContextMenu.MenuItems[0].MenuItems[contextMenuIndex].Click += new EventHandler(ContextMenuClickEventHandler);
            }
            for (int contextMenuIndex = 1; contextMenuIndex < imageXView1.ContextMenu.MenuItems.Count; contextMenuIndex++)
            {
                imageXView1.ContextMenu.MenuItems[contextMenuIndex].Click += new EventHandler(ContextMenuClickEventHandler);
            }
        }

        private void PropertiesMenuItem_Click(object sender, System.EventArgs e)
        {
            using (ImageInfoForm infoForm = new ImageInfoForm())
            {
                infoForm.FileName = helper.OpenedFileName;
                infoForm.PageNumber = helper.OpenedPageNumber;
                infoForm.PageCount = helper.OpenedPageCount;
                infoForm.ImageWidth = imageXView1.Image.ImageXData.Width;
                infoForm.ImageHeight = imageXView1.Image.ImageXData.Height;
                infoForm.Bpp = imageXView1.Image.ImageXData.BitsPerPixel;

                imageXView1.Image.ImageXData.Resolution.Units = GraphicsUnit.Inch;
                infoForm.Resolution = imageXView1.Image.ImageXData.Resolution.Dimensions;
                infoForm.CurrentResolutionUnit = IXResolutionUnit.Inch;

                infoForm.SetResolutionUnitComboBoxSelectionIndex((int)imageInfoResolutionUsed);

                infoForm.FileSize = helper.OpenedFileSize;
                infoForm.Format = helper.OpenedFormat;
                infoForm.Compression = imageXView1.Image.ImageXData.Compression;

                IntPtr dib = IntPtr.Zero;
                Processor proc = null;
                try
                {
                    if (imageXView1.Image.BitsPerPixel > 8 && imageXView1.Image.BitsPerPixel <= 16)
                    {
                        proc = new Processor(imagXpress1, imageXView1.Image.Copy());
                        Helper.TransformIfGrayscale(proc.Image);

                        dib = proc.Image.ToHdib(false);
                    }
                    else
                    {
                        dib = imageXView1.Image.ToHdib(false);
                    }

                    infoForm.DecompressedSize = GlobalSize(dib);
                }
                catch (ProcessorException ex)
                {
                    MessageBox.Show(ex.Message, Constants.processingErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ImageXException ex)
                {
                    MessageBox.Show(ex.Message, Constants.imageInformationErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    GlobalFree(dib);

                    if (proc != null)
                    {
                        if (proc.Image != null)
                        {
                            proc.Image.Dispose();
                            proc.Image = null;
                        }
                        proc.Dispose();
                        proc = null;
                    }
                }

                infoForm.ShowDialog();

                imageInfoResolutionUsed = infoForm.CurrentResolutionUnit;
            }
        }

        private void CameraRawMenuItem_Click(object sender, System.EventArgs e)
        {
            if (CanCurrentlyOpenedImageBeClosed())
            {
                helper.OpenCameraRawFilterIndex = openCameraRawFilterIndex;
                helper.OpenCameraRawInitialDirectory = openCameraRawInitialDirectory;
                helper.ImagXpress = imagXpress1;

                string previousFilename = helper.OpenedFileName;
                if (helper.OpenCameraRaw() == DialogResult.OK)
                {
                    if (!String.Equals(helper.OpenedFileName, previousFilename))
                    {
                        openCameraRawFilterIndex = helper.OpenCameraRawFilterIndex;
                        openCameraRawInitialDirectory = helper.OpenCameraRawInitialDirectory;
                        LoadImageAndThumbnail(helper.OpenedFileName, true, false, helper.LoadOptionsChosen);
                    }
                }
            }
        }

        private void ImageMenuItem_Click(object sender, System.EventArgs e)
        {
            if (CanCurrentlyOpenedImageBeClosed())
            {
                helper.OpenFileFilterIndex = openFileFilterIndex;
                helper.OpenFileInitialDirectory = openFileInitialDirectory;
                helper.ImagXpress = imagXpress1;
                
                string previousFilename = helper.OpenedFileName;
                if (helper.OpenWithoutOptions() == DialogResult.OK)
                {
                    if (!String.Equals(helper.OpenedFileName, previousFilename))
                    {
                        openFileInitialDirectory = helper.OpenFileInitialDirectory;
                        openFileFilterIndex = helper.OpenFileFilterIndex;
                        LoadImageAndThumbnail(helper.OpenedFileName, false, true, new Accusoft.ImagXpressSdk.LoadOptions());
                    }
                }
            }
        }

        private void ImageWithOptionsMenuItem_Click(object sender, System.EventArgs e)
        {
            if (CanCurrentlyOpenedImageBeClosed())
            {
                helper.OpenFileFilterIndex = openFileFilterIndex;
                helper.OpenFileInitialDirectory = openFileInitialDirectory;
                helper.ImagXpress = imagXpress1;

                string previousFilename = helper.OpenedFileName;

                if (helper.OpenWithOptions() == DialogResult.OK)
                {
                    if (!String.Equals(helper.OpenedFileName, previousFilename))
                    {
                        openFileInitialDirectory = helper.OpenFileInitialDirectory;
                        openFileFilterIndex = helper.OpenFileFilterIndex;
                        LoadImageAndThumbnail(helper.OpenedFileName, false, true, helper.LoadOptionsChosen);
                    }
                }
            }
        }

        private void ExitMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void OnlineHelpMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Constants.accusoftHelpString);
        }

        private void ImagXpressMenuItem_Click(object sender, System.EventArgs e)
        {
            imagXpress1.AboutBox();
        }

        private void PrintProMenuItem_Click(object sender, EventArgs e)
        {
            printPro1.AboutBox();
        }

        private void ThumbnailXpressMenuItem_Click(object sender, System.EventArgs e)
        {
            thumbnailXpress1.AboutBox();
        }

        private void NotateXpressMenuItem_Click(object sender, EventArgs e)
        {
            notateXpress1.AboutBox();
        }

        private void TwainProMenuItem_Click(object sender, EventArgs e)
        {
            twainPro1.AboutBox();
        }

        private void IsisXpressMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckIfIsisIsSupported())
            {
                isisXpress1.AboutBox();
            }
        }

        private void ShowSettingsButton_Click(object sender, System.EventArgs e)
        {
            if (String.Equals(showSettingsString, ShowHideSettingsButton.Text))
            {
                //setting panel is contracted and is now being expanded, set at previous position
                ShowHideSettingsButton.Text = hideSettingsString;
                ViewTabControl.Visible = true;
                ThumbnailSettingsSplitContainer.SplitterDistance = thumbnailSettingsShownSplitterDistance;
                //ThumbnailSettingsSplitContainer.IsSplitterFixed = false;
            }
            else if (String.Equals(hideSettingsString, ShowHideSettingsButton.Text))
            {
                //setting panel is expanded and is now being contracted
                ShowHideSettingsButton.Text = showSettingsString;
                ViewTabControl.Visible = false;
                ThumbnailSettingsSplitContainer.SplitterDistance = thumbnailSettingsHiddenSplitterDistance;
                //ThumbnailSettingsSplitContainer.IsSplitterFixed = true;
            }
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            CloseImage(helper.OpenedFileName);
        }

        private void SaveAsImageMenuItem_Click(object sender, EventArgs e)
        {
            helper.Image = imageXView1.Image;
            helper.SaveFileFilterIndex = saveFileFilterIndex;
            helper.SaveFileInitialDirectory = saveFileInitialDirectory;

            if (helper.SaveWithNoOptions() == DialogResult.OK)
            {
                saveFileFilterIndex = helper.SaveFileFilterIndex;
                saveFileInitialDirectory = helper.SaveFileInitialDirectory;
                SaveImage(helper.SavedFileName, new Accusoft.ImagXpressSdk.SaveOptions());

                LoadImageAndThumbnail(helper.SavedFileName, false, true, new Accusoft.ImagXpressSdk.LoadOptions());
            }
        }

        private DialogResult SaveAsImage(bool shouldLoadNewlySavedImage)
        {
            helper.Image = imageXView1.Image;
            helper.SaveFileFilterIndex = saveFileFilterIndex;
            helper.SaveFileInitialDirectory = saveFileInitialDirectory;

            DialogResult result = helper.SaveWithOptions();
            if (result == DialogResult.OK)
            {
                saveFileFilterIndex = helper.SaveFileFilterIndex;
                saveFileInitialDirectory = helper.SaveFileInitialDirectory;
                SaveImage(helper.SavedFileName, helper.SaveOptionsChosen);

                if (shouldLoadNewlySavedImage)
                {
                    LoadImageAndThumbnail(helper.SavedFileName, false, true, new Accusoft.ImagXpressSdk.LoadOptions());
                }
            }

            return result;
        }

        private void SaveAsImageWithOptionsMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsImage(true);
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            imageXView1.Image.Page++;
            helper.OpenedPageNumber = imageXView1.Image.Page;
            PreviousPageButton.Enabled = true;

            UpdatePageUI();
            UpdateThumbnailUIForPaging();
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            imageXView1.Image.Page--;
            helper.OpenedPageNumber = imageXView1.Image.Page;
            NextPageButton.Enabled = true;

            UpdatePageUI();
            UpdateThumbnailUIForPaging();
        }

        private void PageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if enter key is pressed, enter IF statement
            if (e.KeyChar == (char)Keys.Enter)
            {
                uint pageNumber;
                if (UInt32.TryParse(PageTextBox.Text, out pageNumber) && pageNumber <= imageXView1.Image.PageCount
                    && pageNumber > 0)
                {
                    imageXView1.Image.Page = (int)pageNumber;

                    UpdateThumbnailUIForPaging();
                }
                UpdatePageUI();
            }
        }

        private void thumbnailXpress1_MouseClick(object sender, MouseEventArgs e)
        {
            ThumbnailItem itemSelected = thumbnailXpress1.GetItemFromPoint(e.Location);
            if (itemSelected != null)
            {
                //check first if thumbnail selected represents image already in view
                if ((!String.Equals(itemSelected.Filename, helper.OpenedFileName) || (itemSelected.Page != helper.OpenedPageNumber))
                    && CanCurrentlyOpenedImageBeClosed())
                {
                    //clear off currently selected thumbnail annotations
                    notateXpress1.Layers.Clear();
                    for (int i = 0; i < thumbnailXpress1.Items.Count; i++)
                    {
                        if (thumbnailXpress1.Items[i].Page == helper.OpenedPageNumber)
                        {
                            UpdateThumbnailAnnotations(thumbnailXpress1.Items[i]);
                            break;
                        }
                    }

                    Accusoft.ImagXpressSdk.LoadOptions lo = new Accusoft.ImagXpressSdk.LoadOptions();
                    if (itemSelected.UserTag != null && (string)itemSelected.UserTag == Constants.cameraRawString)
                    {
                        lo.CameraRawEnabled = true;
                    }
                    helper.OpenedFileName = itemSelected.Filename;
                    helper.OpenedPageNumber = itemSelected.Page;
                    LoadImage(itemSelected.Filename, itemSelected.Page, lo);
                }
                else
                {
                    //currently opened image has been edited, user was prompted with dialog to save but cancelled,
                    //but selected thumbnail item has already changed, need to reset it
                    thumbnailXpress1.SelectedItems.Clear();
                    for (int thumbnailIndex = 0; thumbnailIndex < thumbnailXpress1.Items.Count; thumbnailIndex++)
                    {
                        if (String.Equals(thumbnailXpress1.Items[thumbnailIndex].Filename, helper.OpenedFileName)
                            && (thumbnailXpress1.Items[thumbnailIndex].Page == helper.OpenedPageNumber))
                        {
                            thumbnailXpress1.SelectedItems.Add(thumbnailXpress1.Items[thumbnailIndex]);
                            break;
                        }
                    }
                }
            }
        }

        private void ClearImagesButton_Click(object sender, EventArgs e)
        {
            if (CanCurrentlyOpenedImageBeClosed())
            {
                thumbnailXpress1.Items.Clear();
                ResetUI();
            }
        }

        private void ImageButtonMenuItem_Click(object sender, EventArgs e)
        {
            ImageMenuItem_Click(sender, e);
        }

        private void ImageWithOptionsButtonMenuItem_Click(object sender, EventArgs e)
        {
            ImageWithOptionsMenuItem_Click(sender, e);
        }

        private void CameraRawButtonMenuItem_Click(object sender, EventArgs e)
        {
            CameraRawMenuItem_Click(sender, e);
        }

        private void OpenButton_ButtonClick(object sender, EventArgs e)
        {
            ImageButtonMenuItem_Click(sender, e);
        }

        private void SaveAsButton_ButtonClick(object sender, EventArgs e)
        {
            SaveAsImageButtonMenuItem_Click(sender, e);
        }

        private void SaveAsImageButtonMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsImageMenuItem_Click(sender, e);
        }

        private void SaveAsImageWithOptionsButtonMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsImageWithOptionsMenuItem_Click(sender, e);
        }

        private void HorizontalAlingmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imageXView1.AlignHorizontal = (AlignHorizontal)HorizontalAlignmentComboBox.SelectedIndex;
        }

        private void VerticalAlignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imageXView1.AlignVertical = (AlignVertical)VerticalAlignmentComboBox.SelectedIndex;
        }

        private void DisplayModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imageXView1.DisplayMode = (DisplayMode)DisplayModeComboBox.SelectedIndex;
        }

        private void AutoResizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (AutoResizeComboBox.SelectedIndex)
            {
                case 0:
                    {
                        imageXView1.AutoResize = AutoResizeType.ResizeImage;
                        ZoomFactorNumericUpDown.Enabled = false;
                        break;
                    }
                case 1:
                    {
                        imageXView1.AutoResize = AutoResizeType.TileImage;
                        ZoomFactorNumericUpDown.Enabled = true;
                        break;
                    }
                case 2:
                    {
                        imageXView1.AutoResize = AutoResizeType.BestFit;
                        ZoomFactorNumericUpDown.Enabled = false;
                        break;
                    }
                case 3:
                    {
                        imageXView1.AutoResize = AutoResizeType.CropImage;
                        ZoomFactorNumericUpDown.Enabled = true;
                        break;
                    }
                case 4:
                    {
                        imageXView1.AutoResize = AutoResizeType.FitWidth;
                        ZoomFactorNumericUpDown.Enabled = false;
                        break;
                    }
                case 5:
                    {
                        imageXView1.AutoResize = AutoResizeType.FitHeight;
                        ZoomFactorNumericUpDown.Enabled = false;
                        break;
                    }
            }

            //for ResizeImage, the ZoomFactor is irrelevant
            if (imageXView1.AutoResize != AutoResizeType.ResizeImage)
            {
                ZoomFactorNumericUpDown.Value = (decimal)imageXView1.ZoomFactor;
            }
        }

        private void EnableColorManagementUI(bool isVisible)
        {
            Control[] proofingControls = new Control[] { ProofingGroupBox, ColorRenderIntentLabel, 
                ColorRenderIntentComboBox, TargetProfileNameLabel, TargetProfileNameTextBox, TargetProfileNameButton, 
                MonitorProfileNameLabel, MonitorProfileNameTextBox, MonitorProfileNameButton, PrinterProfileNameLabel, 
                PrinterProfileNameTextBox, PrinterProfileNameButton };

            foreach (Control control in proofingControls)
            {
                control.Visible = isVisible;
            }
        }

        private void ICMProofingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                imageXView1.IcmEnabled = imageXView1.IcmProofingEnabled = ICMProofingCheckBox.Checked;

                EnableColorManagementUI(ICMProofingCheckBox.Checked);
            }
            catch (ImageXViewException ex)
            {
                MessageBox.Show(ex.Message, Constants.colorProfileErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProgressiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            imageXView1.Progressive = ProgressiveCheckBox.Checked;
        }

        private void AlphaBlendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            imageXView1.AlphaBlend = AlphaBlendCheckBox.Checked;
        }

        private void AntiAliasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            imageXView1.Antialias = AntiAliasCheckBox.Checked;
        }

        private void PreserveBlackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            imageXView1.PreserveBlack = PreserveBlackCheckBox.Checked;
        }

        private void DitheredCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            imageXView1.Dithered = DitheredCheckBox.Checked;
        }

        private void SmoothingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            imageXView1.Smoothing = SmoothingCheckBox.Checked;
        }

        private void AspectXNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            imageXView1.AspectX = (int)AspectXNumericUpDown.Value;
        }

        private void AspectYNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            imageXView1.AspectY = (int)AspectYNumericUpDown.Value;
        }

        private void ContrastNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            imageXView1.Contrast = (int)ContrastNumericUpDown.Value;
        }

        private void BrightnessNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            imageXView1.Brightness = (int)BrightnessNumericUpDown.Value;
        }

        private void ZoomFactorNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            imageXView1.ZoomFactor = (double)ZoomFactorNumericUpDown.Value;
        }

        private void BackColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.Color = BackColorButton.BackColor;

                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    imageXView1.BackColor = colorDlg.Color;
                    BackColorButton.BackColor = colorDlg.Color;
                }
            }
        }

        private void ColorRenderIntentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imageXView1.ColorRenderIntent = (RenderIntent)ColorRenderIntentComboBox.SelectedIndex;
        }

        private void ContextMenuClickEventHandler(object sender, System.EventArgs e)
        {
            if ((decimal)imageXView1.ZoomFactor <= ZoomFactorNumericUpDown.Maximum && (decimal)imageXView1.ZoomFactor >= ZoomFactorNumericUpDown.Minimum)
            {
                ZoomFactorNumericUpDown.Value = (decimal)imageXView1.ZoomFactor;
            }
            switch (imageXView1.AutoResize)
            {
                case AutoResizeType.BestFit:
                    {
                        AutoResizeComboBox.SelectedIndex = 2;
                        break;
                    }
                case AutoResizeType.CropImage:
                    {
                        AutoResizeComboBox.SelectedIndex = 3;
                        break;
                    }
                case AutoResizeType.FitWidth:
                    {
                        AutoResizeComboBox.SelectedIndex = 4;
                        break;
                    }
                case AutoResizeType.FitHeight:
                    {
                        AutoResizeComboBox.SelectedIndex = 5;
                        break;
                    }
            }
            AntiAliasCheckBox.Checked = imageXView1.Antialias;
            DitheredCheckBox.Checked = imageXView1.Dithered;
            SmoothingCheckBox.Checked = imageXView1.Smoothing;
        }

        private void PrintProfileNameButton_Click(object sender, EventArgs e)
        {
            OpenProfileFile(ProfileType.Printer, PrinterProfileNameTextBox);
        }

        private void TargetProfileNameButton_Click(object sender, EventArgs e)
        {
            OpenProfileFile(ProfileType.Target, TargetProfileNameTextBox);
        }

        private void MonitorProfileNameButton_Click(object sender, EventArgs e)
        {
            OpenProfileFile(ProfileType.Monitor, MonitorProfileNameTextBox);
        }

        private void imageXView1_ZoomFactorChanged(object sender, ZoomFactorChangedEventArgs e)
        {
            if ((decimal)imageXView1.ZoomFactor <= ZoomFactorNumericUpDown.Maximum && (decimal)imageXView1.ZoomFactor >= ZoomFactorNumericUpDown.Minimum)
            {
                ZoomFactorNumericUpDown.Value = (decimal)imageXView1.ZoomFactor;
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            //move the splitter so the tab control doesn't take up too much real estate on the form
            if (mainFormPreviouslyMaximized)
            {
                //form was previously maximized so it must've been restored
                ThumbnailImageSplitContainer.SplitterDistance = thumbnailImageSplitterDistance;
                mainFormPreviouslyMaximized = false;
            }
            if (this.WindowState == FormWindowState.Maximized)
            {
                //form is currently maximized
                ThumbnailImageSplitContainer.SplitterDistance = thumbnailImageSplitterDistance;
                thumbnailSettingsHiddenSplitterDistance = ThumbnailSettingsSplitContainer.Height - ShowHideSettingsPanel.Height - ShowHideSettingsButton.Top;
                mainFormPreviouslyMaximized = true;
            }

            if (String.Equals(hideSettingsString, ShowHideSettingsButton.Text))
            {
                //setting panel is expanded, keep track of splitter position
                thumbnailSettingsShownSplitterDistance = ThumbnailSettingsSplitContainer.SplitterDistance;
            }
        }

        private void PaletteFileNameButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDlg = new OpenFileDialog())
            {
                openDlg.Title = Constants.openPaletteString;
                openDlg.Filter = Constants.allFilesFilterString;
                openDlg.FilterIndex = paletteNameFilterIndex;
                openDlg.InitialDirectory = paletteNameInitialDirectory;

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    paletteNameInitialDirectory = Path.GetDirectoryName(openDlg.FileName);
                    paletteNameFilterIndex = openDlg.FilterIndex;

                    imageXView1.PaletteFilename = openDlg.FileName;
                    PaletteFileNameTextBox.Text = openDlg.FileName;
                }
            }
        }

        private void PaletteTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PaletteTypeComboBox.SelectedIndex == 3)
            {
                PaletteFileNameTextBox.Enabled = true;
                PaletteFileNameButton.Enabled = true;
            }
            else
            {
                PaletteFileNameTextBox.Enabled = false;
                PaletteFileNameButton.Enabled = false;
            }

            imageXView1.PaletteType = (PaletteType)PaletteTypeComboBox.SelectedIndex;
        }

        private void SlideShowMenuItem_Click(object sender, EventArgs e)
        {
            using (SlideShowForm slideForm = new SlideShowForm())
            {
                #if LICENSED
                    slideForm.License = license;
                #endif

                List<string> imageFileNames = new List<string>();
                List<int> imagePageNumbers = new List<int>();
                List<bool> imageIsCameraRawBools = new List<bool>();

                for (int i = 0; i < thumbnailXpress1.Items.Count; i++)
                {
                    imageFileNames.Add(thumbnailXpress1.Items[i].Filename);
                    imagePageNumbers.Add(thumbnailXpress1.Items[i].Page);
                    imageIsCameraRawBools.Add(String.Equals(thumbnailXpress1.Items[i].UserTag, Constants.cameraRawString));
                }

                slideForm.SetImageFileNames(imageFileNames.ToArray());
                slideForm.SetImagePageNumbers(imagePageNumbers.ToArray());
                slideForm.SetImageIsCameraRaw(imageIsCameraRawBools.ToArray());
                
                slideForm.ShowDialog();
            }
        }

        private void ThumbnailSettingsSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (String.Equals(hideSettingsString, ShowHideSettingsButton.Text))
            {
                //setting panel is expanded, keep track of splitter position
                thumbnailSettingsShownSplitterDistance = ThumbnailSettingsSplitContainer.SplitterDistance;
            }

            //deselect the splitter by giving focus to the ImageXView
            this.ActiveControl = imageXView1;
        }

        private void CellBorderWidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            thumbnailXpress1.CellBorderWidth = (int)CellBorderWidthNumericUpDown.Value;
        }

        private void CellHorizontalSpacingNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            thumbnailXpress1.CellHorizontalSpacing = (int)CellHorizontalSpacingNumericUpDown.Value;
        }

        private void CellVerticalSpacingNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            thumbnailXpress1.CellVerticalSpacing = (int)CellVerticalSpacingNumericUpDown.Value;
        }

        private void CellBorderColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.Color = CellBorderColorButton.BackColor;
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    CellBorderColorButton.BackColor = colorDlg.Color;
                    thumbnailXpress1.CellBorderColor = colorDlg.Color;
                }
            }
        }

        private void CellSpacingColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.Color = CellSpacingColorButton.BackColor;
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    CellSpacingColorButton.BackColor = colorDlg.Color;
                    thumbnailXpress1.CellSpacingColor = colorDlg.Color;
                }
            }
        }

        private void SelectBackColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.Color = SelectBackColorButton.BackColor;
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    SelectBackColorButton.BackColor = colorDlg.Color;
                    thumbnailXpress1.SelectBackColor = colorDlg.Color;
                }
            }
        }

        private void ThumbnailBackColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.Color = ThumbnailBackColorButton.BackColor;
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    ThumbnailBackColorButton.BackColor = colorDlg.Color;
                    thumbnailXpress1.BackColor = colorDlg.Color;
                }
            }
        }

        private void ForeColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.Color = ForeColorButton.BackColor;
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    ForeColorButton.BackColor = colorDlg.Color;
                    thumbnailXpress1.ForeColor = colorDlg.Color;
                }
            }
        }

        private void CellWidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            thumbnailXpress1.CellWidth = (int)CellWidthNumericUpDown.Value;
        }

        private void CellHeightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            thumbnailXpress1.CellHeight = (int)CellHeightNumericUpDown.Value;
        }

        private void DescriptorHorizontalAlignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DescriptorHorizontalAlignmentComboBox.SelectedIndex)
            {
                case 0:
                    {
                        thumbnailXpress1.DescriptorAlignment = DescriptorAlignments.AlignLeft;
                        break;
                    }
                case 1:
                    {
                        thumbnailXpress1.DescriptorAlignment = DescriptorAlignments.AlignCenter;
                        break;
                    }
                case 2:
                    {
                        thumbnailXpress1.DescriptorAlignment = DescriptorAlignments.AlignRight;
                        break;
                    }
            }
        }

        private void DescriptorVerticalAlignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DescriptorVerticalAlignmentComboBox.SelectedIndex)
            {
                case 0:
                    {
                        thumbnailXpress1.DescriptorAlignment = DescriptorAlignments.AlignTop;
                        break;
                    }
                case 1:
                    {
                        thumbnailXpress1.DescriptorAlignment = DescriptorAlignments.AlignVCenter;
                        break;
                    }
                case 2:
                    {
                        thumbnailXpress1.DescriptorAlignment = DescriptorAlignments.AlignBottom;
                        break;
                    }
            }
        }

        private void DescriptorDisplayMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DescriptorDisplayMethodComboBox.SelectedIndex)
            {
                case 0:
                    {
                        thumbnailXpress1.DescriptorDisplayMethod = DescriptorDisplayMethods.Default;
                        break;
                    }
                case 1:
                    {
                        thumbnailXpress1.DescriptorDisplayMethod = DescriptorDisplayMethods.IncludePage;
                        break;
                    }
                case 2:
                    {
                        thumbnailXpress1.DescriptorDisplayMethod = DescriptorDisplayMethods.LongFilename;
                        break;
                    }
                case 3:
                    {
                        thumbnailXpress1.DescriptorDisplayMethod = DescriptorDisplayMethods.ShortFilename;
                        break;
                    }
                case 4:
                    {
                        thumbnailXpress1.DescriptorDisplayMethod = DescriptorDisplayMethods.None;
                        break;
                    }
            }
        }

        private void TextBackColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.Color = TextBackColorButton.BackColor;
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    TextBackColorButton.BackColor = colorDlg.Color;
                    thumbnailXpress1.TextBackColor = colorDlg.Color;
                }
            }
        }

        private void FontShowHideButton_Click(object sender, EventArgs e)
        {
            int amountToMoveControlsVertically = FontUnderlineComboBox.Top - FontNameTextBox.Top;
            List<Control> fontControls = new List<Control> { FontNameLabel, FontNameTextBox, FontNameButton, 
                FontSizeLabel, FontSizeNumericUpDown, FontBoldLabel, FontBoldComboBox, FontItalicLabel, FontItalicComboBox, 
                FontStrikeoutLabel, FontStrikeoutComboBox, FontUnderlineLabel, FontUnderlineComboBox };

            if (String.Equals(FontShowHideButton.Text, fontShowSettingsString))
            {
                foreach (Control control in ThumbnailTabPage.Controls)
                {
                    if (!fontControls.Contains(control) && control.GetType() != typeof(GroupBox) && control.Top > FontLabel.Top)
                    {
                        control.Top += amountToMoveControlsVertically;
                    }
                }

                foreach (Control control in DescriptorGroupBox.Controls)
                {
                    if (!fontControls.Contains(control) && control.Top > FontLabel.Top)
                    {
                        control.Top += amountToMoveControlsVertically;
                    }
                }

                DescriptorGroupBox.Height += amountToMoveControlsVertically;

                foreach (Control control in fontControls)
                {
                    control.Visible = true;
                }

                FontShowHideButton.Text = fontHideSettingsString;
            }
            else
            {
                foreach (Control control in ThumbnailTabPage.Controls)
                {
                    if (!fontControls.Contains(control) && control.Visible && control.GetType() != typeof(GroupBox) && control.Top > FontLabel.Top)
                    {
                        control.Top -= amountToMoveControlsVertically;
                    }
                }

                foreach (Control control in DescriptorGroupBox.Controls)
                {
                    if (!fontControls.Contains(control) && control.Top > FontLabel.Top)
                    {
                        control.Top -= amountToMoveControlsVertically;
                    }
                }

                DescriptorGroupBox.Height -= amountToMoveControlsVertically;

                foreach (Control control in fontControls)
                {
                    control.Visible = false;
                }

                FontShowHideButton.Text = fontShowSettingsString;
            }
        }

        private void FontNameButton_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDlg = new FontDialog())
            {
                fontDlg.Font = thumbnailXpress1.Font;
                if (fontDlg.ShowDialog() == DialogResult.OK)
                {
                    thumbnailXpress1.Font = fontDlg.Font;

                    UpdateFontUI();
                }
            }
        }

        private void FontSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Font newFont = new Font(thumbnailXpress1.Font.Name, (float)FontSizeNumericUpDown.Value, thumbnailXpress1.Font.Style);

            thumbnailXpress1.Font = newFont;
        }

        private void FontBoldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFontStyle(FontBoldComboBox.SelectedIndex, FontStyle.Bold);
        }

        private void FontItalicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFontStyle(FontItalicComboBox.SelectedIndex, FontStyle.Italic);
        }

        private void FontUnderlineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFontStyle(FontUnderlineComboBox.SelectedIndex, FontStyle.Underline);
        }

        private void FontStrikeoutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFontStyle(FontStrikeoutComboBox.SelectedIndex, FontStyle.Strikeout);
        }

        private void ScrollDirectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            thumbnailXpress1.ScrollDirection = (ScrollDirection)ScrollDirectionComboBox.SelectedIndex;
        }

        private void ThumbnailPreserveBlackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            thumbnailXpress1.PreserveBlack = PreserveBlackCheckBox.Checked;
        }

        private void ShowImagePlaceholdersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            thumbnailXpress1.ShowImagePlaceholders = ShowImagePlaceholdersCheckBox.Checked;
        }

        private void ShowHourGlassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            thumbnailXpress1.ShowHourglass = ShowWorkingCursorCheckBox.Checked;
        }

        private void ThumbnailDefaultButton_Click(object sender, EventArgs e)
        {
            SetThumbnailDefaults();
        }

        private void imageXView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (imageXView1.Image != null)
            {
                PointF cursorPosition = imageXView1.Translate(e.Location, TranslateType.ViewToPixel);

                //if outside bounds of visible image, only want to report positive coordinates
                if (cursorPosition.X > 0 && cursorPosition.Y > 0)
                {
                    StatusBarLabel.Text = String.Format("Mouse Position: {0}, Color: {{R: {1}, G: {2}, B: {3}}}", cursorPosition,
                        imageXView1.PixelColor.R, imageXView1.PixelColor.G, imageXView1.PixelColor.B);
                }
            }
        }

        private void ColorDefaultButton_Click(object sender, EventArgs e)
        {
            SetColorDefaults();
        }

        private void ViewDefaultButton_Click(object sender, EventArgs e)
        {
            SetViewDefaults();
        }

        private void TwainMenuItem_Click(object sender, EventArgs e)
        {
            if (CanCurrentlyOpenedImageBeClosed())
            {
                try
                {
                    using (TwainScanForm scanForm = new TwainScanForm())
                    {

#if LICENSED
                        scanForm.License = license;
#endif

                        scanForm.TwainProInstance = twainPro1;
                        scanForm.ShowUserInterface = twainShowUserInterface;
                        scanForm.DataSourceManagerVersion = twainDataSourceManagerVersion;
                        scanForm.SaveFileInitialDirectory = scanTwainSaveInitialDirectory;

                        helper.ImagXpress = imagXpress1;
                        scanForm.HelperInstance = helper;

                        if (scanForm.ShowDialog() == DialogResult.OK)
                        {
                            twainShowUserInterface = scanForm.ShowUserInterface;
                            twainDataSourceManagerVersion = scanForm.DataSourceManagerVersion;
                            scanTwainSaveInitialDirectory = Path.GetDirectoryName(scanForm.SavedFileName);

                            helper.OpenedFileName = scanForm.SavedFileName;
                            LoadImageAndThumbnail(scanForm.SavedFileName, false, true, new Accusoft.ImagXpressSdk.LoadOptions());
                        }
                    }
                }
                catch (TwainDllLoadException ex)
                {
                     MessageBox.Show(ex.Message, Constants.dsmErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void imageXView1_MouseLeave(object sender, EventArgs e)
        {
            StatusBarLabel.Text = String.Empty;
        }

        private void ISISMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckIfIsisIsSupported())
            {
                using (IsisScanForm scanForm = new IsisScanForm())
                {

#if LICENSED
                    scanForm.License = license;
#endif

                    helper.ImagXpress = imagXpress1;
                    scanForm.HelperInstance = helper;

                    scanForm.IsisXpressInstance = isisXpress1;
                    scanForm.SaveFileInitialDirectory = scanIsisSaveInitialDirectory;

                    if (scanForm.ShowDialog() == DialogResult.OK)
                    {
                        helper.OpenedFileName = scanForm.SavedFileName;
                        scanIsisSaveInitialDirectory = Path.GetDirectoryName(scanForm.SavedFileName);

                        LoadImageAndThumbnail(scanForm.SavedFileName, false, true, new Accusoft.ImagXpressSdk.LoadOptions());
                    }
                }
            }
        }

        private void ColorModifyReplaceColorsMenuItem_Click(object sender, EventArgs e)
        {
            using (ReplaceColorsForm replaceColorsForm = new ReplaceColorsForm())
            {

#if LICENSED
                replaceColorsForm.License = license;
#endif

                replaceColorsForm.FromColor = processingColorModifyReplaceColorsFromColor;
                replaceColorsForm.ToColor = processingColorModifyReplaceColorsToColor;
                replaceColorsForm.ReplaceColor = processingColorModifyReplaceColorsReplaceColor;

                if (DisplayProcessingForm(replaceColorsForm, false) == DialogResult.OK)
                {
                    processingColorModifyReplaceColorsFromColor = replaceColorsForm.FromColor;
                    processingColorModifyReplaceColorsToColor = replaceColorsForm.ToColor;
                    processingColorModifyReplaceColorsReplaceColor = replaceColorsForm.ReplaceColor;
                }
            }
        }

        private void ColorModifyColorDepthMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDepthForm colorDepthForm = new ColorDepthForm())
            {

#if LICENSED
                colorDepthForm.License = license;
#endif

                colorDepthForm.Bpp = processingColorModifyColorDepthBpp;
                colorDepthForm.PaletteType = processingColorModifyColorDepthPaletteType;
                colorDepthForm.DitherType = processingColorModifyColorDepthDitherType;

                if (DisplayProcessingForm(colorDepthForm, false) == DialogResult.OK)
                {
                    processingColorModifyColorDepthBpp = colorDepthForm.Bpp;
                    processingColorModifyColorDepthPaletteType = colorDepthForm.PaletteType;
                    processingColorModifyColorDepthDitherType = colorDepthForm.DitherType;
                }
            }
        }

        private void ColorModifyAdjustRGBMenuItem_Click(object sender, EventArgs e)
        {
            using (AdjustForm adjustRGBForm = new AdjustForm())
            {

#if LICENSED
                adjustRGBForm.License = license;
#endif

                adjustRGBForm.AdjustAction = AdjustAction.AdjustRGB;
                adjustRGBForm.AdjustType = processingColorModifyAdjustRGBAdjustType;
                adjustRGBForm.Red = processingColorModifyAdjustRGBRed;
                adjustRGBForm.Blue = processingColorModifyAdjustRGBBlue;
                adjustRGBForm.Green = processingColorModifyAdjustRGBGreen;

                if (DisplayProcessingForm(adjustRGBForm, false) == DialogResult.OK)
                {
                    processingColorModifyAdjustRGBAdjustType = adjustRGBForm.AdjustType;
                    processingColorModifyAdjustRGBRed = adjustRGBForm.Red;
                    processingColorModifyAdjustRGBBlue = adjustRGBForm.Blue;
                    processingColorModifyAdjustRGBGreen = adjustRGBForm.Green;
                }
            }
        }

        private void ColorModifyAdjustHSLMenuItem_Click(object sender, EventArgs e)
        {
            using (AdjustForm adjustHSLForm = new AdjustForm())
            {

#if LICENSED
                adjustHSLForm.License = license;
#endif

                adjustHSLForm.AdjustAction = AdjustAction.AdjustHSL;
                adjustHSLForm.AdjustType = processingColorModifyAdjustHSLAdjustType;
                adjustHSLForm.Hue = processingColorModifyAdjustHSLHue;
                adjustHSLForm.Saturation = processingColorModifyAdjustHSLSaturation;
                adjustHSLForm.Luminance = processingColorModifyAdjustHSLLuminance;

                if (DisplayProcessingForm(adjustHSLForm, false) == DialogResult.OK)
                {
                    processingColorModifyAdjustHSLAdjustType = adjustHSLForm.AdjustType;
                    processingColorModifyAdjustHSLHue = adjustHSLForm.Hue;
                    processingColorModifyAdjustHSLSaturation = adjustHSLForm.Saturation;
                    processingColorModifyAdjustHSLLuminance = adjustHSLForm.Luminance;
                }
            }
        }

        private void ColorBalanceAutoMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm autoColorBalanceForm = new ProcessingForm())
            {

#if LICENSED
                autoColorBalanceForm.License = license;
#endif

                autoColorBalanceForm.Text = Constants.autoColorBalanceString;
                autoColorBalanceForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.AutoColorBalance);
                DisplayProcessingForm(autoColorBalanceForm, false);
            }
        }

        private void ColorBalanceLevelMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm autoLevelForm = new ProcessingForm())
            {

#if LICENSED
                autoLevelForm.License = license;
#endif

                autoLevelForm.Text = Constants.autoLevelString;
                autoLevelForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.AutoLevel);
                DisplayProcessingForm(autoLevelForm, false);
            }
        }

        private void ColorBalanceManualMenuItem_Click(object sender, EventArgs e)
        {
            using (AdjustForm adjustColorBalanceForm = new AdjustForm())
            {

#if LICENSED
                adjustColorBalanceForm.License = license;
#endif

                adjustColorBalanceForm.AdjustAction = AdjustAction.AdjustColorBalance;
                adjustColorBalanceForm.Color = processingColorBalanceColorBalanceManualColor;
                adjustColorBalanceForm.Red = processingColorBalanceColorBalanceManualRed;
                adjustColorBalanceForm.Green = processingColorBalanceColorBalanceManualGreen;
                adjustColorBalanceForm.Blue = processingColorBalanceColorBalanceManualBlue;

                if (DisplayProcessingForm(adjustColorBalanceForm, false) == DialogResult.OK)
                {
                    processingColorBalanceColorBalanceManualColor = adjustColorBalanceForm.Color;
                    processingColorBalanceColorBalanceManualRed = adjustColorBalanceForm.Red;
                    processingColorBalanceColorBalanceManualGreen = adjustColorBalanceForm.Green;
                    processingColorBalanceColorBalanceManualBlue = adjustColorBalanceForm.Blue;
                }
            }
        }

        private void ClarifyDeskewMenuItem_Click(object sender, EventArgs e)
        {
            using (SkewForm deskewForm = new SkewForm())
            {

#if LICENSED
                deskewForm.License = license;
#endif

                deskewForm.BitsPerPixel = imageXView1.Image.BitsPerPixel;
                deskewForm.OneBitBackgroundColor = processingClarifyDeskewOneBitBackgroundColor;
                deskewForm.SkewAction = SkewAction.Deskew;
                deskewForm.DeskewType = processingClarifyDeskewDeskewType;
                deskewForm.BackgroundColor = processingClarifyDeskewBackgroundColor;
                if (DisplayProcessingForm(deskewForm, false) == DialogResult.OK)
                {
                    processingClarifyDeskewOneBitBackgroundColor = deskewForm.OneBitBackgroundColor;
                    processingClarifyDeskewDeskewType = deskewForm.DeskewType;
                    processingClarifyDeskewBackgroundColor = deskewForm.BackgroundColor;
                }
            }
        }

        private void ClarifyDespeckleMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm despeckleForm = new ProcessingForm())
            {

#if LICENSED
                despeckleForm.License = license;
#endif

                despeckleForm.Text = Constants.despeckleString;
                despeckleForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.Despeckle);
                DisplayProcessingForm(despeckleForm, false);
            }
        }

        private void ClarifyDilateMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm dilateForm = new ProcessingForm())
            {

#if LICENSED
                dilateForm.License = license;
#endif

                dilateForm.Text = Constants.dilateString;
                dilateForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.Dilate);
                DisplayProcessingForm(dilateForm, false);
            }
        }

        private void ClarifyErodeMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm erodeForm = new ProcessingForm())
            {

#if LICENSED
                erodeForm.License = license;
#endif

                erodeForm.Text = Constants.erodeString;
                erodeForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.Erode);
                DisplayProcessingForm(erodeForm, false);
            }
        }

        private void BrightnessSubMenuItem_Click(object sender, EventArgs e)
        {
            using (IntensityForm brightnessForm = new IntensityForm())
            {

#if LICENSED
                brightnessForm.License = license;
#endif

                brightnessForm.IntensityAction = IntensityAction.Brightness;
                brightnessForm.BrightnessIntensity = processingBrightnessBrightnessIntensity;

                if (DisplayProcessingForm(brightnessForm, false) == DialogResult.OK)
                {
                    processingBrightnessBrightnessIntensity = brightnessForm.BrightnessIntensity;
                }
            }
        }

        private void BrightnessGammaMenuItem_Click(object sender, EventArgs e)
        {
            using (IntensityForm gammaForm = new IntensityForm())
            {

#if LICENSED
                gammaForm.License = license;
#endif

                gammaForm.IntensityAction = IntensityAction.Gamma;
                gammaForm.GammaIntensity = processingBrightnessGammaGamma;

                if (DisplayProcessingForm(gammaForm, false) == DialogResult.OK)
                {
                    processingBrightnessGammaGamma = gammaForm.GammaIntensity;
                }
            }
        }

        private void ContrastAutoMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm autoContrastForm = new ProcessingForm())
            {

#if LICENSED
                autoContrastForm.License = license;
#endif

                autoContrastForm.Text = Constants.autoContrastString;
                autoContrastForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.AutoContrast);
                DisplayProcessingForm(autoContrastForm, false);
            }
        }

        private void ContrastManualMenuItem_Click(object sender, EventArgs e)
        {
            using (IntensityForm contrastForm = new IntensityForm())
            {

#if LICENSED
                contrastForm.License = license;
#endif

                contrastForm.IntensityAction = IntensityAction.Contrast;
                contrastForm.ContrastIntensity = processingContrastManualContrastIntensity;

                if (DisplayProcessingForm(contrastForm, false) == DialogResult.OK)
                {
                    processingContrastManualContrastIntensity = contrastForm.ContrastIntensity;
                }
            }
        }

        private void ContrastEqualizeMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm equalizeForm = new ProcessingForm())
            {

#if LICENSED
                equalizeForm.License = license;
#endif

                equalizeForm.Text = Constants.equalizeString;
                equalizeForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.Equalize);
                DisplayProcessingForm(equalizeForm, false);
            }
        }

        private void ContrastLightnessAutoMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm autoLightnessForm = new ProcessingForm())
            {

#if LICENSED
                autoLightnessForm.License = license;
#endif

                autoLightnessForm.Text = Constants.autoLightnessString;
                autoLightnessForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.AutoLightness);
                DisplayProcessingForm(autoLightnessForm, false);
            }
        }

        private void ContrastLightnessManualMenuItem_Click(object sender, EventArgs e)
        {
            using (DoubleIntensityAndSelectionForm adjustLightnessForm = new DoubleIntensityAndSelectionForm())
            {

#if LICENSED
                adjustLightnessForm.License = license;
#endif

                adjustLightnessForm.DoubleIntensityAction = DoubleIntensityAction.AdjustLightness;
                adjustLightnessForm.AdjustLightnessHighlights = processingContrastManualLightnessHighlights;
                adjustLightnessForm.AdjustLightnessShadows = processingContrastManualLightnessShadows;

                if (DisplayProcessingForm(adjustLightnessForm, false) == DialogResult.OK)
                {
                    processingContrastManualLightnessHighlights = adjustLightnessForm.AdjustLightnessHighlights;
                    processingContrastManualLightnessShadows = adjustLightnessForm.AdjustLightnessShadows;
                } 
            }
        }

        private void CropAutoMenuItem_Click(object sender, EventArgs e)
        {
            using (CropBorderForm cropBorderForm = new CropBorderForm())
            {

#if LICENSED
                cropBorderForm.License = license;
#endif

                cropBorderForm.CropAction = CropAction.AutoCrop;
                cropBorderForm.SetBorderPointMax(new Point(imageXView1.Image.Width, imageXView1.Image.Height));
                cropBorderForm.PercentToCrop = processingCropAutoCropPercentToCrop;
                cropBorderForm.BorderPoint = processingCropAutoCropBorderPoint;

                if (DisplayProcessingForm(cropBorderForm, false) == DialogResult.OK)
                {
                    processingCropAutoCropPercentToCrop = cropBorderForm.PercentToCrop;
                    processingCropAutoCropBorderPoint = cropBorderForm.BorderPoint;
                }
            }
        }

        private void CropManualMenuItem_Click(object sender, EventArgs e)
        {
            using (CropForm cropForm = new CropForm())
            {

#if LICENSED
                cropForm.License = license;
#endif

                cropForm.SetLeftMax(imageXView1.Image.Width);
                cropForm.SetTopMax(imageXView1.Image.Height);
                cropForm.SetWidthMax(imageXView1.Image.Width);
                cropForm.SetHeightMax(imageXView1.Image.Height);
                cropForm.Rectangle = processingCropManualCrop;

                if (DisplayProcessingForm(cropForm, false) == DialogResult.OK)
                {
                    processingCropManualCrop = cropForm.Rectangle;
                }
            }
        }

        private void CropBorderMenuItem_Click(object sender, EventArgs e)
        {
            using (CropBorderForm cropBorderForm = new CropBorderForm())
            {

#if LICENSED
                cropBorderForm.License = license;
#endif

                cropBorderForm.CropAction = CropAction.CropBorder;
                cropBorderForm.PercentToCrop = processingCropBorderCropPercentToCrop;
                cropBorderForm.CropType = processingCropBorderCropCropType;

                if (DisplayProcessingForm(cropBorderForm, false) == DialogResult.OK)
                {
                    processingCropBorderCropPercentToCrop = cropBorderForm.PercentToCrop;
                    processingCropBorderCropCropType = cropBorderForm.CropType;
                }
            }
        }

        private void OrientationFlipMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm flipForm = new ProcessingForm())
            {

#if LICENSED
                flipForm.License = license;
#endif

                flipForm.Text = Constants.flipString;
                flipForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.Flip);
                DisplayProcessingForm(flipForm, false);
            }
        }

        private void OrientationMirrorMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm mirrorForm = new ProcessingForm())
            {

#if LICENSED
                mirrorForm.License = license;
#endif

                mirrorForm.Text = Constants.mirrorString;
                mirrorForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.Mirror);
                DisplayProcessingForm(mirrorForm, false);
            }
        }

        private void OrientationRotateMenuItem_Click(object sender, EventArgs e)
        {
            using (SkewForm rotateForm = new SkewForm())
            {

#if LICENSED
                rotateForm.License = license;
#endif

                rotateForm.BitsPerPixel = imageXView1.Image.BitsPerPixel;
                rotateForm.OneBitBackgroundColor = processingOrientationRotateOneBitBackgroundColor;
                rotateForm.SkewAction = SkewAction.Rotate;
                rotateForm.Angle = processingOrientationRotateAngle;
                rotateForm.BackgroundColor = processingOrientationRotateBackgroundColor;
                if (DisplayProcessingForm(rotateForm, false) == DialogResult.OK)
                {
                    processingOrientationRotateOneBitBackgroundColor = rotateForm.OneBitBackgroundColor;
                    processingOrientationRotateAngle = rotateForm.Angle;
                    processingOrientationRotateBackgroundColor = rotateForm.BackgroundColor;
                }
            }
        }

        private void RedEyeRemovalAutoMenuItem_Click(object sender, EventArgs e)
        {
            using (RemoveRedeyeForm autoRemoveRedeyeForm = new RemoveRedeyeForm())
            {

#if LICENSED
                autoRemoveRedeyeForm.License = license;
#endif

                autoRemoveRedeyeForm.RedEyeAction = RedeyeAction.Auto;
                autoRemoveRedeyeForm.Glare = processingRedEyeRemovalAutoGlare;
                autoRemoveRedeyeForm.Shade = processingRedEyeRemovalAutoShade;
                autoRemoveRedeyeForm.UseRedeyeRectangles = processingRedEyeRemovalAutoUseRedEyeRectangles;

                if (DisplayProcessingForm(autoRemoveRedeyeForm, false) == DialogResult.OK)
                {
                    processingRedEyeRemovalAutoGlare = autoRemoveRedeyeForm.Glare;
                    processingRedEyeRemovalAutoShade = autoRemoveRedeyeForm.Shade;
                    processingRedEyeRemovalAutoUseRedEyeRectangles = autoRemoveRedeyeForm.UseRedeyeRectangles;
                }
            }
        }

        private void RedEyeRemovalManualMenuItem_Click(object sender, EventArgs e)
        {
            using (RemoveRedeyeForm removeRedeyeForm = new RemoveRedeyeForm())
            {

#if LICENSED
                removeRedeyeForm.License = license;
#endif

                removeRedeyeForm.RedEyeAction = RedeyeAction.Manual;
                removeRedeyeForm.Glare = processingRedEyeRemovalManualGlare;
                removeRedeyeForm.Shade = processingRedEyeRemovalManualShade;
                removeRedeyeForm.Precision = processingRedEyeRemovalManualPrecision;

                if (DisplayProcessingForm(removeRedeyeForm, false) == DialogResult.OK)
                {
                    processingRedEyeRemovalManualGlare = removeRedeyeForm.Glare;
                    processingRedEyeRemovalManualShade = removeRedeyeForm.Shade;
                    processingRedEyeRemovalManualPrecision = removeRedeyeForm.Precision;
                }
            }
        }

        private void RemoveDustMenuItem_Click(object sender, EventArgs e)
        {
            using (RemoveDefectForm removeDustForm = new RemoveDefectForm())
            {

#if LICENSED
                removeDustForm.License = license;
#endif

                removeDustForm.DefectRemovalAction = DefectRemovalAction.RemoveDust;
                removeDustForm.FilterAdjustment = processingRemoveDustFilterAdjustment;
                removeDustForm.SmoothingAdjustment = processingRemoveDustSmoothingAdjustment;
                removeDustForm.Threshold = processingRemoveDustThreshold;
                removeDustForm.DefectType = processingRemoveDustDefectType;

                if (DisplayProcessingForm(removeDustForm, false) == DialogResult.OK)
                {
                    processingRemoveDustFilterAdjustment = removeDustForm.FilterAdjustment;
                    processingRemoveDustSmoothingAdjustment = removeDustForm.SmoothingAdjustment;
                    processingRemoveDustThreshold = removeDustForm.Threshold;
                    processingRemoveDustDefectType = removeDustForm.DefectType;
                }
            }
        }

        private void RemoveScratchesMenuItem_Click(object sender, EventArgs e)
        {
            using (RemoveDefectForm removeScratchesForm = new RemoveDefectForm())
            {

#if LICENSED
                removeScratchesForm.License = license;
#endif

                removeScratchesForm.DefectRemovalAction = DefectRemovalAction.RemoveScratches;
                removeScratchesForm.SetScratchPointMax(new Point(imageXView1.Image.Width, imageXView1.Image.Height));
                removeScratchesForm.SetSractchLineWidthMax(Int32.MaxValue);

                removeScratchesForm.ScratchStartingPoint = processingRemoveScratchesStartingPoint;
                removeScratchesForm.ScratchEndingPoint = processingRemoveScratchesEndingPoint;
                removeScratchesForm.ScratchLineWidth = processingRemoveScratchesLineWidth;
                removeScratchesForm.Threshold = processingRemoveScratchesThreshold;
                removeScratchesForm.FilterAdjustment = processingRemoveScratchesFilterAdjustment;
                removeScratchesForm.SmoothingAdjustment = processingRemoveScratchesSmoothingAdjustment;
                removeScratchesForm.DefectType = processingRemoveScratchesDefectType;

                if (DisplayProcessingForm(removeScratchesForm, false) == DialogResult.OK)
                {
                    processingRemoveScratchesStartingPoint = removeScratchesForm.ScratchStartingPoint;
                    processingRemoveScratchesEndingPoint = removeScratchesForm.ScratchEndingPoint;
                    processingRemoveScratchesLineWidth = removeScratchesForm.ScratchLineWidth;
                    processingRemoveScratchesThreshold = removeScratchesForm.Threshold;
                    processingRemoveScratchesFilterAdjustment = removeScratchesForm.FilterAdjustment;
                    processingRemoveScratchesSmoothingAdjustment = removeScratchesForm.SmoothingAdjustment;
                    processingRemoveScratchesDefectType = removeScratchesForm.DefectType;
                }
            }
        }

        private void ResizeMenuItem_Click(object sender, EventArgs e)
        {
            using (ResizeForm resizeForm = new ResizeForm())
            {

#if LICENSED
                resizeForm.License = license;
#endif

                resizeForm.SizeSelection = processingResizeSizeSelection;
                resizeForm.SetNewSizeMax(new Size(Int32.MaxValue, Int32.MaxValue));
                resizeForm.ScaleToGray = processingResizeScaleToGray;
                resizeForm.ScaleToPreserveBlack = processingResizeScaleToPreserveBlack;
                resizeForm.ResizeType = processingResizeResizeType;

                if (processingResizeHasBeenSet)
                {
                    resizeForm.NewSize = processingResizeNewSize;
                }
                else
                {
                    //if size hasn't been set yet, default to original image size
                    resizeForm.NewSize = new Size(imageXView1.Image.Width, imageXView1.Image.Height);
                }

                if (DisplayProcessingForm(resizeForm, false) == DialogResult.OK)
                {
                    processingResizeNewSize = resizeForm.NewSize;
                    processingResizeScaleToGray = resizeForm.ScaleToGray;
                    processingResizeScaleToPreserveBlack = resizeForm.ScaleToPreserveBlack;
                    processingResizeResizeType = resizeForm.ResizeType;
                    processingResizeHasBeenSet = true;
                }
            }
        }

        private void SharpenSubMenuItem_Click(object sender, EventArgs e)
        {
            using (IntensityAndSelectionForm sharpenForm = new IntensityAndSelectionForm())
            {

#if LICENSED
                sharpenForm.License = license;
#endif

                sharpenForm.IntensityAndSelectionAction = IntensityAndSelectionAction.Sharpen;
                sharpenForm.SharpenIntensity = processingSharpenSharpenIntensity;
                sharpenForm.SharpenFilter = processingSharpenSharpenFilter;

                if (DisplayProcessingForm(sharpenForm, false) == DialogResult.OK)
                {
                    processingSharpenSharpenIntensity = sharpenForm.SharpenIntensity;
                    processingSharpenSharpenFilter = sharpenForm.SharpenFilter;
                }
            }
        }

        private void SoftenMenuItem_Click(object sender, EventArgs e)
        {
            using (IntensityAndSelectionForm sharpenForm = new IntensityAndSelectionForm())
            {

#if LICENSED
                sharpenForm.License = license;
#endif

                sharpenForm.IntensityAndSelectionAction = IntensityAndSelectionAction.Soften;
                sharpenForm.SoftenIntensity = processingSharpenSoftenIntensity;
                sharpenForm.SoftenFilter = processingSharpenSoftenFilter;

                if (DisplayProcessingForm(sharpenForm, false) == DialogResult.OK)
                {
                    processingSharpenSoftenIntensity = sharpenForm.SoftenIntensity;
                    processingSharpenSoftenFilter = sharpenForm.SoftenFilter;
                }
            }
        }

        private void UnsharpenMenuItem_Click(object sender, EventArgs e)
        {
            using (IntensityAndSelectionForm sharpenForm = new IntensityAndSelectionForm())
            {
                
#if LICENSED
                sharpenForm.License = license;
#endif

                sharpenForm.IntensityAndSelectionAction = IntensityAndSelectionAction.Unsharpen;
                sharpenForm.UnsharpenIntensity = processingSharpenUnsharpenIntensity;
                sharpenForm.UnsharpenFilter = processingSharpenUnsharpenFilter;

                if (DisplayProcessingForm(sharpenForm, false) == DialogResult.OK)
                {
                    processingSharpenUnsharpenIntensity = sharpenForm.UnsharpenIntensity;
                    processingSharpenUnsharpenFilter = sharpenForm.UnsharpenFilter;
                }
            }
        }

        private void ColorSeparationMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorSeparationForm colorSeparationForm = new ColorSeparationForm())
            {

#if LICENSED
                colorSeparationForm.License = license;
#endif

                colorSeparationForm.SeparationType = imageColorSeparationSeparationType;

                colorSeparationForm.RgbRed = imageColorSeparationRgbRed;
                colorSeparationForm.RgbGreen = imageColorSeparationRgbGreen;
                colorSeparationForm.RgbBlue = imageColorSeparationRgbBlue;
                colorSeparationForm.HslHue = imageColorSeparationHslHue;
                colorSeparationForm.HslLuminance = imageColorSeparationHslLuminance;
                colorSeparationForm.HslSaturation = imageColorSeparationHslSaturation;
                colorSeparationForm.CmyCyan = imageColorSeparationCmyCyan;
                colorSeparationForm.CmyMagenta = imageColorSeparationCmyMagenta;
                colorSeparationForm.CmyYellow = imageColorSeparationCmyYellow;
                colorSeparationForm.CmykCyan = imageColorSeparationCmykCyan;
                colorSeparationForm.CmykMagenta = imageColorSeparationCmykMagenta;
                colorSeparationForm.CmykYellow = imageColorSeparationCmykYellow;
                colorSeparationForm.CmykBlack = imageColorSeparationCmykBlack;
                colorSeparationForm.RgbaRed = imageColorSeparationRgbaRed;
                colorSeparationForm.RgbaBlue = imageColorSeparationRgbaBlue;
                colorSeparationForm.RgbaGreen = imageColorSeparationRgbaGreen;
                colorSeparationForm.RgbaBlue = imageColorSeparationRgbaBlue;
                colorSeparationForm.RgbaAlpha = imageColorSeparationRgbaAlpha;

                if (DisplayProcessingForm(colorSeparationForm, true) == DialogResult.OK)
                {
                    imageColorSeparationSeparationType = colorSeparationForm.SeparationType;

                    imageColorSeparationRgbRed = colorSeparationForm.RgbRed;
                    imageColorSeparationRgbGreen = colorSeparationForm.RgbGreen;
                    imageColorSeparationRgbBlue = colorSeparationForm.RgbBlue;
                    imageColorSeparationHslHue = colorSeparationForm.HslHue;
                    imageColorSeparationHslLuminance = colorSeparationForm.HslLuminance;
                    imageColorSeparationHslSaturation = colorSeparationForm.HslSaturation;
                    imageColorSeparationCmyCyan = colorSeparationForm.CmyCyan;
                    imageColorSeparationCmyMagenta = colorSeparationForm.CmyMagenta;
                    imageColorSeparationCmyYellow = colorSeparationForm.CmyYellow;
                    imageColorSeparationCmykCyan = colorSeparationForm.CmykCyan;
                    imageColorSeparationCmykMagenta = colorSeparationForm.CmykMagenta;
                    imageColorSeparationCmykYellow = colorSeparationForm.CmykYellow;
                    imageColorSeparationCmykBlack = colorSeparationForm.CmykBlack;
                    imageColorSeparationRgbaRed = colorSeparationForm.RgbaRed;
                    imageColorSeparationRgbaGreen = colorSeparationForm.RgbaGreen;
                    imageColorSeparationRgbaBlue = colorSeparationForm.RgbaBlue;
                    imageColorSeparationRgbaAlpha = colorSeparationForm.RgbaAlpha;
                }
            }
        }

        private void AlphaFlattenMenuItem_Click(object sender, EventArgs e)
        {
            using (AlphaFlattenForm alphaFlattenForm = new AlphaFlattenForm())
            {

#if LICENSED
                alphaFlattenForm.License = license;
#endif

                alphaFlattenForm.FlattenColor = processingAlphaAlphaFlatten;

                if (DisplayProcessingForm(alphaFlattenForm, false) == DialogResult.OK)
                {
                    processingAlphaAlphaFlatten = alphaFlattenForm.FlattenColor;

                    AlphaEnableMenu(false);
                }
            }
        }

        private void AlphaReduceToAlphaMenuItem_Click(object sender, EventArgs e)
        {
            using (AlphaReduceForm alphaReduceForm = new AlphaReduceForm())
            {

#if LICENSED
                alphaReduceForm.License = license;
#endif

                if (DisplayProcessingForm(alphaReduceForm, true) == DialogResult.OK)
                {
                    AlphaEnableMenu(false);
                }
            }
        }

        private void AlphaMergeMenuItem_Click(object sender, EventArgs e)
        {
            using (MergeForm mergeForm = new MergeForm())
            {

#if LICENSED
                mergeForm.License = license;
#endif

                mergeForm.SourceImageFilterIndex = mergeSourceImageFilterIndex;
                mergeForm.SourceImageInitialDirectory = mergeSourceImageInitialDirectory;

                mergeForm.SourceImageInitialDirectory = "";
                mergeForm.MergeSize = processingAlphaMergeMergeSize;
                mergeForm.MergeStyle = processingAlphaMergeMergeStyle;
                mergeForm.Transparent = processingAlphaMergeTransparent;
                mergeForm.TransparentColor = processingAlphaMergeTransparentColor;
                mergeForm.MergePercentHigh = processingAlphaMergePercentHigh;
                mergeForm.MergePercentLow = processingAlphaMergePercentLow;
                mergeForm.SourceImage = processingAlphaMergeSourceImage;

                if (DisplayProcessingForm(mergeForm, false) == DialogResult.OK)
                {
                    mergeSourceImageFilterIndex = mergeForm.SourceImageFilterIndex;
                    mergeSourceImageInitialDirectory = mergeForm.SourceImageInitialDirectory;

                    processingAlphaMergeMergeSize = mergeForm.MergeSize;
                    processingAlphaMergeMergeStyle = mergeForm.MergeStyle;
                    processingAlphaMergeTransparent = mergeForm.Transparent;
                    processingAlphaMergeTransparentColor = mergeForm.TransparentColor;
                    processingAlphaMergePercentHigh = mergeForm.MergePercentHigh;
                    processingAlphaMergePercentLow = mergeForm.MergePercentLow;
                    processingAlphaMergeSourceImage = mergeForm.SourceImage;
                }
            }
        }

        private void BlendMenuItem_Click(object sender, EventArgs e)
        {
            using (IntensityForm blendForm = new IntensityForm())
            {

#if LICENSED
                blendForm.License = license;
#endif

                blendForm.IntensityAction = IntensityAction.Blend;
                blendForm.BlendIntensity = processingBlendIntensity;

                if (DisplayProcessingForm(blendForm, false) == DialogResult.OK)
                {
                    processingBlendIntensity = blendForm.BlendIntensity;
                }
            }
        }

        private void BlurMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm blurForm = new ProcessingForm())
            {

#if LICENSED
                blurForm.License = license;
#endif

                blurForm.Text = Constants.blurString;
                blurForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.Blur);
                DisplayProcessingForm(blurForm, false);
            }
        }

        private void ButtonizeMenuItem_Click(object sender, EventArgs e)
        {
            using (DoubleIntensityAndSelectionForm buttonizeForm = new DoubleIntensityAndSelectionForm())
            {

#if LICENSED
                buttonizeForm.License = license;
#endif

                buttonizeForm.DoubleIntensityAction = DoubleIntensityAction.Buttonize;
                buttonizeForm.ButtonStyle = processingButtonizeButtonStyle;
                buttonizeForm.BevelIntensity = processingButtonizeBevelIntensity;
                buttonizeForm.BevelWidth = processingButtonizeBevelWidth;

                if (DisplayProcessingForm(buttonizeForm, false) == DialogResult.OK)
                {
                    processingButtonizeButtonStyle = buttonizeForm.ButtonStyle;
                    processingButtonizeBevelIntensity = buttonizeForm.BevelIntensity;
                    processingButtonizeBevelWidth = buttonizeForm.BevelWidth;
                }
            }
        }

        private void DiffuseMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm diffuseForm = new ProcessingForm())
            {

#if LICENSED
                diffuseForm.License = license;
#endif

                diffuseForm.Text = Constants.diffuseString;
                diffuseForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.Diffuse);
                DisplayProcessingForm(diffuseForm, false);
            }
        }

        private void EmbossMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm embossForm = new ProcessingForm())
            {

#if LICENSED
                embossForm.License = license;
#endif

                embossForm.Text = Constants.embossString;
                embossForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.Emboss);
                DisplayProcessingForm(embossForm, false);
            }
        }

        private void MatrixMenuItem_Click(object sender, EventArgs e)
        {
            using (MatrixForm matrixForm = new MatrixForm())
            {

#if LICENSED
                matrixForm.License = license;
#endif

                matrixForm.SetMatrixArray(processingMatrixArray);
                matrixForm.Intensity = processingMatrixIntensity;
                matrixForm.Divisor = processingMatrixDivisor;

                if (DisplayProcessingForm(matrixForm, false) == DialogResult.OK)
                {
                    processingMatrixArray = matrixForm.GetMatrixArray();
                    processingMatrixIntensity = matrixForm.Intensity;
                    processingMatrixDivisor = matrixForm.Divisor;
                }
            }
        }

        private void MedianMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm medianForm = new ProcessingForm())
            {

#if LICENSED
                medianForm.License = license;
#endif

                medianForm.Text = Constants.medianString;
                medianForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.Median);
                DisplayProcessingForm(medianForm, false);
            }
        }

        private void MosaicMenuItem_Click(object sender, EventArgs e)
        {
            using (IntensityForm mosaicForm = new IntensityForm())
            {

#if LICENSED
                mosaicForm.License = license;
#endif

                mosaicForm.IntensityAction = IntensityAction.Mosaic;
                mosaicForm.MosaicBlockSize = processingMosaicBlockSize;

                if (DisplayProcessingForm(mosaicForm, false) == DialogResult.OK)
                {
                    processingMosaicBlockSize = mosaicForm.MosaicBlockSize;
                }
            }
        }

        private void MotionBlurMenuItem_Click(object sender, EventArgs e)
        {
            using (MotionBlurForm motionBlurForm = new MotionBlurForm())
            {

#if LICENSED
                motionBlurForm.License = license;
#endif

                motionBlurForm.Intensity = processingMotionBlurIntensity;
                motionBlurForm.VelocityX = processingMotionBlurVelocityX;
                motionBlurForm.VelocityY = processingMotionBlurVelocityY;

                if (DisplayProcessingForm(motionBlurForm, false) == DialogResult.OK)
                {
                    processingMotionBlurIntensity = motionBlurForm.Intensity;
                    processingMotionBlurVelocityX = motionBlurForm.VelocityX;
                    processingMotionBlurVelocityY = motionBlurForm.VelocityY;
                }
            }
        }

        private void NegateMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm negateForm = new ProcessingForm())
            {

#if LICENSED
                negateForm.License = license;
#endif

                negateForm.Text = Constants.negateString;
                negateForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.Negate);
                DisplayProcessingForm(negateForm, false);
            }
        }

        private void NoiseMenuItem_Click(object sender, EventArgs e)
        {
            using (DoubleIntensityAndSelectionForm noiseForm = new DoubleIntensityAndSelectionForm())
            {

#if LICENSED
                noiseForm.License = license;
#endif

                noiseForm.DoubleIntensityAction = DoubleIntensityAction.Noise;
                noiseForm.NoiseFrequency = processingNoiseFrequency;
                noiseForm.NoiseIntensity = processingNoiseIntensity;

                if (DisplayProcessingForm(noiseForm, false) == DialogResult.OK)
                {
                    processingNoiseFrequency = noiseForm.NoiseFrequency;
                    processingNoiseIntensity = noiseForm.NoiseIntensity;
                }
            }
        }

        private void OutlineMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm outlineForm = new ProcessingForm())
            {

#if LICENSED
                outlineForm.License = license;
#endif

                outlineForm.Text = Constants.outlineString;
                outlineForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.Outline);
                DisplayProcessingForm(outlineForm, false);
            }
        }

        private void ParabolicMenuItem_Click(object sender, EventArgs e)
        {
            using (DoubleIntensityAndSelectionForm parabolicForm = new DoubleIntensityAndSelectionForm())
            {

#if LICENSED
                parabolicForm.License = license;
#endif

                parabolicForm.DoubleIntensityAction = DoubleIntensityAction.Parabolic;
                parabolicForm.ParabolicType = processingParabolicType;

                if (DisplayProcessingForm(parabolicForm, false) == DialogResult.OK)
                {
                    processingParabolicType = parabolicForm.ParabolicType;
                }
            }
        }

        private void PerspectiveMenuItem_Click(object sender, EventArgs e)
        {
            using (IntensityAndSelectionForm perspectiveForm = new IntensityAndSelectionForm())
            {

#if LICENSED
                perspectiveForm.License = license;
#endif

                perspectiveForm.BackgroundColor = processingPerspectiveBackgroundColor;
                perspectiveForm.IntensityAndSelectionAction = IntensityAndSelectionAction.Perspective;
                perspectiveForm.PerspectivePercent = processingPerspectivePercent;
                perspectiveForm.PerspectiveType = processingPerspectiveType;

                if (DisplayProcessingForm(perspectiveForm, false) == DialogResult.OK)
                {
                    processingPerspectiveBackgroundColor = perspectiveForm.BackgroundColor;
                    processingPerspectivePercent = perspectiveForm.PerspectivePercent;
                    processingPerspectiveType = perspectiveForm.PerspectiveType;
                }
            }
        }

        private void PinchMenuItem_Click(object sender, EventArgs e)
        {
            using (IntensityForm pinchForm = new IntensityForm())
            {

#if LICENSED
                pinchForm.License = license;
#endif

                pinchForm.IntensityAction = IntensityAction.Pinch;
                pinchForm.PinchIntensity = processingPinchIntensity;

                if (DisplayProcessingForm(pinchForm, false) == DialogResult.OK)
                {
                    processingPinchIntensity = pinchForm.PinchIntensity;
                }
            }
        }

        private void PolynomialWarpMenuItem_Click(object sender, EventArgs e)
        {
            using (PolynomialWarpForm polynomialWarpForm = new PolynomialWarpForm())
            {

#if LICENSED
                polynomialWarpForm.License = license;
#endif

                polynomialWarpForm.SetPointMax(new Point(imageXView1.Image.Width, imageXView1.Image.Height));
                polynomialWarpForm.BackgroundColor = processingPolynomialWarpBackgroundColor;

                if (processingPolynomialWarpHasBeenSet) 
                {
                    polynomialWarpForm.Point1 = processingPolynomialWarpPoint1;
                    polynomialWarpForm.Point2 = processingPolynomialWarpPoint2;
                    polynomialWarpForm.Point3 = processingPolynomialWarpPoint3;
                    polynomialWarpForm.Point4 = processingPolynomialWarpPoint4;
                }
                else 
                {
                    //if polynomial warp points haven't been set yet, default to certain points to make effect more clear
                    polynomialWarpForm.Point1 = new Point((int)(imageXView1.Image.Width * .8), (int)(imageXView1.Image.Height * .1));
                    polynomialWarpForm.Point2 = new Point((int)(imageXView1.Image.Width * .1), (int)(imageXView1.Image.Height * .7));
                    polynomialWarpForm.Point3 = new Point((int)(imageXView1.Image.Width * .5), (int)(imageXView1.Image.Height * .9));
                    polynomialWarpForm.Point4 = new Point((int)imageXView1.Image.Width, (int)imageXView1.Image.Height);
                }

                if (DisplayProcessingForm(polynomialWarpForm, false) == DialogResult.OK)
                {
                    processingPolynomialWarpPoint1 = polynomialWarpForm.Point1;
                    processingPolynomialWarpPoint2 = polynomialWarpForm.Point2;
                    processingPolynomialWarpPoint3 = polynomialWarpForm.Point3;
                    processingPolynomialWarpPoint4 = polynomialWarpForm.Point4;
                    processingPolynomialWarpBackgroundColor = polynomialWarpForm.BackgroundColor;
                    processingPolynomialWarpHasBeenSet = true;
                }
            }
        }

        private void PosterizeMenuItem_Click(object sender, EventArgs e)
        {
            using (IntensityForm posterizeForm = new IntensityForm())
            {

#if LICENSED
                posterizeForm.License = license;
#endif

                posterizeForm.IntensityAction = IntensityAction.Posterize;
                posterizeForm.PosterizeNumberOfLevels = processingPosterizeNumberOfLevels;

                if (DisplayProcessingForm(posterizeForm, false) == DialogResult.OK)
                {
                    processingPosterizeNumberOfLevels = posterizeForm.PosterizeNumberOfLevels;
                }
            }
        }

        private void RippleMenuItem_Click(object sender, EventArgs e)
        {
            using (DoubleIntensityAndSelectionForm rippleForm = new DoubleIntensityAndSelectionForm())
            {

#if LICENSED
                rippleForm.License = license;
#endif

                rippleForm.DoubleIntensityAction = DoubleIntensityAction.Ripple;
                rippleForm.RippleDirection = processingRippleDirection;
                rippleForm.RippleIntensity = processingRippleIntensity;
                rippleForm.RippleFrequency = processingRippleFrequency;

                if (DisplayProcessingForm(rippleForm, false) == DialogResult.OK)
                {
                    processingRippleDirection = rippleForm.RippleDirection;
                    processingRippleIntensity = rippleForm.RippleIntensity;
                    processingRippleFrequency = rippleForm.RippleFrequency;
                }
            }
        }

        private void SolarizeMenuItem_Click(object sender, EventArgs e)
        {
            using (IntensityForm solarizeForm = new IntensityForm())
            {

#if LICENSED
                solarizeForm.License = license;
#endif

                solarizeForm.IntensityAction = IntensityAction.Solarize;
                solarizeForm.SolarizeThreshold = processingSolarizeThreshold;

                if (DisplayProcessingForm(solarizeForm, false) == DialogResult.OK)
                {
                    processingSolarizeThreshold = solarizeForm.SolarizeThreshold;
                }
            }
        }

        private void SwirlMenuItem_Click(object sender, EventArgs e)
        {
            using (IntensityForm swirlForm = new IntensityForm())
            {

#if LICENSED
                swirlForm.License = license;
#endif

                swirlForm.IntensityAction = IntensityAction.Swirl;
                swirlForm.SwirlDegrees = processingSwirlDegrees;

                if (DisplayProcessingForm(swirlForm, false) == DialogResult.OK)
                {
                    processingSwirlDegrees = swirlForm.SwirlDegrees;
                }
            }
        }

        private void TileMenuItem_Click(object sender, EventArgs e)
        {
            using (DoubleIntensityAndSelectionForm tileForm = new DoubleIntensityAndSelectionForm())
            {

#if LICENSED
                tileForm.License = license;
#endif

                tileForm.DoubleIntensityAction = DoubleIntensityAction.Tile;
                if (processingTileSizeHasBeenSet)
                {
                    tileForm.TileSize = processingTileTileSize;
                }
                else
                {
                    //if tile size hasn't been set yet, default to 5 times the original size
                    tileForm.TileSize = new Size(imageXView1.Image.Width * 5, imageXView1.Image.Height * 5);
                }

                if (DisplayProcessingForm(tileForm, false) == DialogResult.OK)
                {
                    processingTileTileSize = tileForm.TileSize;
                    processingTileSizeHasBeenSet = true;
                }
            }
        }

        private void TwistMenuItem_Click(object sender, EventArgs e)
        {
            using (IntensityAndSelectionForm twistForm = new IntensityAndSelectionForm())
            {

#if LICENSED
                twistForm.License = license;
#endif

                twistForm.IntensityAndSelectionAction = IntensityAndSelectionAction.Twist;
                twistForm.TwistBlockSize = processingTwistBlockSize;
                twistForm.TwistRotation = processingTwistRotation;

                if (DisplayProcessingForm(twistForm, false) == DialogResult.OK)
                {
                    processingTwistBlockSize = twistForm.TwistBlockSize;
                    processingTwistRotation = twistForm.TwistRotation;
                }
            }
        }

        private void AutoBinarizeMenuItem_Click(object sender, EventArgs e)
        {
            using (ProcessingForm autoBinarizeForm = new ProcessingForm())
            {

#if LICENSED
                autoBinarizeForm.License = license;
#endif

                autoBinarizeForm.Text = Constants.autoBinarizeString;
                autoBinarizeForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.AutoBinarize);
                DisplayProcessingForm(autoBinarizeForm, false);
            }
        }

        private void BinarizeMenuItem_Click(object sender, EventArgs e)
        {
            using (BinarizeForm binarizeForm = new BinarizeForm())
            {

#if LICENSED
                binarizeForm.License = license;
#endif

                binarizeForm.Mode = processingBinarizeMode;
                binarizeForm.LowThreshold = processingBinarizeLowThreshold;
                binarizeForm.HighThreshold = processingBinarizeHighThreshold;
                binarizeForm.GridAngle = processingBinarizeGridAngle;
                binarizeForm.GridPitch = processingBinarizeGridPitch;
                binarizeForm.Eccentricity = processingBinarizeEccentricity;
                binarizeForm.LceFactor = processingBinarizeLceFactor;
                binarizeForm.Blur = processingBinarizeBlur;

                if (DisplayProcessingForm(binarizeForm, false) == DialogResult.OK)
                {
                    processingBinarizeLowThreshold = binarizeForm.LowThreshold;
                    processingBinarizeHighThreshold = binarizeForm.HighThreshold;
                    processingBinarizeGridAngle = binarizeForm.GridAngle;
                    processingBinarizeGridPitch = binarizeForm.GridPitch;
                    processingBinarizeEccentricity = binarizeForm.Eccentricity;
                    processingBinarizeLceFactor = binarizeForm.LceFactor;
                    processingBinarizeBlur = binarizeForm.Blur;
                }
            }
        }

        private void BorderCropMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckIfImageIsDocument())
            {
                using (ProcessingForm documentBorderCropForm = new ProcessingForm())
                {

#if LICENSED
                    documentBorderCropForm.License = license;
#endif

                    documentBorderCropForm.Text = Constants.cropBorderString;
                    documentBorderCropForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.DocumentBorderCrop);
                    DisplayProcessingForm(documentBorderCropForm, false);
                }
            }
        }

        private void DeskewMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckIfImageIsDocument())
            {
                using (DeskewForm deskewForm = new DeskewForm())
                {

#if LICENSED
                    deskewForm.License = license;
#endif

                    deskewForm.MinimumAngle = processingDeskewMinimumAngle;
                    deskewForm.MinimumConfidence = processingDeskewMinimumConfidence;
                    deskewForm.PadColor = processingDeskewPadColor;
                    deskewForm.MaintainOriginalSize = processingDeskewMaintainOriginalSize;
                    deskewForm.Quality = processingDeskewQuality;

                    if (DisplayProcessingForm(deskewForm, false) == DialogResult.OK)
                    {
                        processingDeskewMinimumAngle = deskewForm.MinimumAngle;
                        processingDeskewMinimumConfidence = deskewForm.MinimumConfidence;
                        processingDeskewPadColor = deskewForm.PadColor;
                        processingDeskewMaintainOriginalSize = deskewForm.MaintainOriginalSize;
                        processingDeskewQuality = deskewForm.Quality;
                    }
                }
            }
        }

        private void DespeckleMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckIfImageIsDocument())
            {
                using (DoubleIntensityAndSelectionForm documentDespeckleForm = new DoubleIntensityAndSelectionForm())
                {

#if LICENSED
                    documentDespeckleForm.License = license;
#endif

                    documentDespeckleForm.DoubleIntensityAction = DoubleIntensityAction.DocumentDespeckle;
                    documentDespeckleForm.DespeckleWidth = processingDespeckleWidth;
                    documentDespeckleForm.DespeckleHeight = processingDespeckleHeight;

                    if (DisplayProcessingForm(documentDespeckleForm, false) == DialogResult.OK)
                    {
                        processingDespeckleWidth = documentDespeckleForm.DespeckleWidth;
                        processingDespeckleHeight = documentDespeckleForm.DespeckleHeight;
                    }
                }
            }
        }

        private void DilateMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckIfImageIsDocument())
            {
                using (IntensityAndSelectionForm documentDilateForm = new IntensityAndSelectionForm())
                {

#if LICENSED
                    documentDilateForm.License = license;
#endif

                    documentDilateForm.IntensityAndSelectionAction = IntensityAndSelectionAction.DocumentDilate;
                    documentDilateForm.DilateAmount = processingDilateAmount;
                    documentDilateForm.DilateDirection = processingDilateDirection;

                    if (DisplayProcessingForm(documentDilateForm, false) == DialogResult.OK)
                    {
                        processingDilateAmount = documentDilateForm.DilateAmount;
                        processingDilateDirection = documentDilateForm.DilateDirection;
                    }
                }
            }
        }

        private void ErodeMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckIfImageIsDocument())
            {
                using (IntensityAndSelectionForm documentErodeForm = new IntensityAndSelectionForm())
                {

#if LICENSED
                    documentErodeForm.License = license;
#endif

                    documentErodeForm.IntensityAndSelectionAction = IntensityAndSelectionAction.DocumentErode;
                    documentErodeForm.ErodeAmount = processingErodeAmount;
                    documentErodeForm.ErodeDirection = processingErodeDirection;

                    if (DisplayProcessingForm(documentErodeForm, false) == DialogResult.OK)
                    {
                        processingErodeAmount = documentErodeForm.ErodeAmount;
                        processingErodeDirection = documentErodeForm.ErodeDirection;
                    }
                }
            }
        }

        private void LineRemovalMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckIfImageIsDocument())
            {
                using (LineRemovalForm lineRemovalForm = new LineRemovalForm())
                {

#if LICENSED
                    lineRemovalForm.License = license;
#endif

                    lineRemovalForm.MinimumLength = processingLineRemovalMinimumLength;
                    lineRemovalForm.MaximumThickness = processingLineRemovalMaximumThickness;
                    lineRemovalForm.MinimumAspectRatio = processingLineRemovalMinimumAspectRatio;
                    lineRemovalForm.MaximumGap = processingLineRemovalMaximumGap;
                    lineRemovalForm.MaximumCharacterRepairSize = processingLineRemovalMaximumCharacterRepairSize;

                    if (DisplayProcessingForm(lineRemovalForm, false) == DialogResult.OK)
                    {
                        processingLineRemovalMinimumLength = lineRemovalForm.MinimumLength;
                        processingLineRemovalMaximumThickness = lineRemovalForm.MaximumThickness;
                        processingLineRemovalMinimumAspectRatio = lineRemovalForm.MinimumAspectRatio;
                        processingLineRemovalMaximumGap = lineRemovalForm.MaximumGap;
                        processingLineRemovalMaximumCharacterRepairSize = lineRemovalForm.MaximumCharacterRepairSize;
                    }
                }
            }
        }

        private void SmoothZoomMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckIfImageIsDocument())
            {
                using (ProcessingForm smoothZoomForm = new ProcessingForm())
                {

#if LICENSED
                    smoothZoomForm.License = license;
#endif

                    smoothZoomForm.Text = Constants.smoothZoomString;
                    smoothZoomForm.SetProcessorParameterlessAction(ProcessorParameterlessAction.SmoothZoom);
                    DisplayProcessingForm(smoothZoomForm, false);
                }
            }
        }

        private void BlobRemovalMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckIfImageIsDocument())
            {
                using (BlobRemovalForm blobRemovalForm = new BlobRemovalForm())
                {

#if LICENSED
                    blobRemovalForm.License = license;
#endif

                    blobRemovalForm.SetMaximumPixelCountMax(Int32.MaxValue);
                    blobRemovalForm.SetMinimumPixelCountMax(Int32.MaxValue);

                    blobRemovalForm.MinimumDensity = processingBlobRemovalMinimumDensity;
                    blobRemovalForm.MinimumPixelCount = processingBlobRemovalMinimumPixelCount;
                    blobRemovalForm.MaximumPixelCount = processingBlobRemovalMaximumPixelCount;

                    if (DisplayProcessingForm(blobRemovalForm, false) == DialogResult.OK)
                    {
                        processingBlobRemovalMinimumDensity = blobRemovalForm.MinimumDensity;
                        processingBlobRemovalMinimumPixelCount = blobRemovalForm.MinimumPixelCount;
                        processingBlobRemovalMaximumPixelCount = blobRemovalForm.MaximumPixelCount;
                    }
                }
            }
        }

        private void TwainButtonMenuItem_Click(object sender, EventArgs e)
        {
            TwainMenuItem_Click(sender, e);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintMenuItem_Click(sender, e);
        }

        private void ZoomInButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndViewTool(ZoomInButton, Tool.ZoomIn);
        }

        private void ZoomOutButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndViewTool(ZoomOutButton, Tool.ZoomOut);
        }

        private void MagnifyButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndViewTool(MagnifyButton, Tool.Magnify);
        }

        private void ZoomRectangleButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndViewTool(ZoomRectangleButton, Tool.ZoomRect);
        }

        private void PanButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndViewTool(PanButton, Tool.Hand);
        }

        private void SelectionButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndViewTool(SelectionButton, Tool.Select);
        }

        private void PointerButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndAnnotationTool(PointerButton, AnnotationTool.PointerTool);
        }

        private void ButtonToolButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndAnnotationTool(ButtonToolButton, AnnotationTool.ButtonTool);
        }

        private void EllipseButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndAnnotationTool(EllipseToolButton, AnnotationTool.EllipseTool);
        }

        private void FreehandButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndAnnotationTool(FreehandToolButton, AnnotationTool.FreehandTool);
        }

        private void HighlightButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndAnnotationTool(HighlightToolButton, AnnotationTool.BlockHighlightTool);
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndAnnotationTool(ImageToolButton, AnnotationTool.ImageTool);
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndAnnotationTool(LineToolButton, AnnotationTool.LineTool);
        }

        private void PolygonButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndAnnotationTool(PolygonToolButton, AnnotationTool.PolygonTool);
        }

        private void PolylineButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndAnnotationTool(PolylineToolButton, AnnotationTool.PolyLineTool);
        }

        private void ProtractorButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndAnnotationTool(ProtractorToolButton, AnnotationTool.ProtractorTool);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndAnnotationTool(RectangleToolButton, AnnotationTool.RectangleTool);
        }

        private void RulerButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndAnnotationTool(RulerToolButton, AnnotationTool.RulerTool);
        }

        private void StampButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndAnnotationTool(StampToolButton, AnnotationTool.StampTool);
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndAnnotationTool(TextToolButton, AnnotationTool.TextTool);
        }

        private void NoteToolButton_Click(object sender, EventArgs e)
        {
            SelectButtonAndAnnotationTool(NoteToolButton, AnnotationTool.NoteTool);
        }

        private void notateXpress1_AnnotationsChanged(object sender, AnnotationsChangedEventArgs e)
        {
            UpdateThumbnailAnnotations(GetSelectedThumbnailItem());
        }

        private void HistogramMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (HistogramForm histogramForm = new HistogramForm())
                {
                    histogramForm.Image = imageXView1.Image.Copy();
                    histogramForm.ChannelSelection = histogramChannelSelection;

                    if (histogramForm.ShowDialog() == DialogResult.OK)
                    {
                        histogramChannelSelection = histogramForm.ChannelSelection;
                    }
                }
            }
            catch (ImageXException ex)
            {
                MessageBox.Show(ex.Message, Constants.imageInformationErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IsisButtonMenuItem_Click(object sender, EventArgs e)
        {
            ISISMenuItem_Click(sender, e);
        }

        private void PrintMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument doc = null;
            try
            {
                using (PrintDialog printDialog = new PrintDialog())
                {
                    printPageCounter = 1;

                    //don't enable selection if user hasn't selected anything
                    if (pixelSelectionBeginPoint == pixelSelectionEndPoint)
                    {
                        printDialog.AllowSelection = false;
                    }
                    else
                    {
                        printDialog.AllowSelection = true;
                    }

                    //don't enable 'some pages' unless a multi-page file is opened
                    if (helper.OpenedPageCount > 1)
                    {
                        printDialog.AllowSomePages = true;
                    }
                    else
                    {
                        printDialog.AllowSomePages = false;
                    }

                    // IX-4515 fixes print menu not working on Windows 7 and above
                    printDialog.UseEXDialog = true;

                    printDialog.PrinterSettings = printerSettings;

                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (printerSettings.PrintRange == PrintRange.SomePages)
                        {
                            //check From Page doesn't exceed page count
                            if (printerSettings.FromPage <= helper.OpenedPageCount)
                            {
                                printPageCounter = printerSettings.FromPage;
                            }
                            else
                            {
                                //print range isn't valid, just print all pages
                                printerSettings.PrintRange = PrintRange.AllPages;
                            }
                        }

                        doc = new PrintDocument();
                        doc.PrinterSettings = printerSettings;
                        doc.PrintPage += new PrintPageEventHandler(doc_PrintPage);
                        doc.Print();
                    }
                }
            }
            finally
            {
                if (doc != null)
                {
                    doc.PrintPage -= doc_PrintPage;

                    doc.Dispose();
                    doc = null;
                }
            }
        }

        private void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            ImageX imgCopy = null;
            try
            {
                if (printPageCounter == helper.OpenedPageNumber)
                {
                    using (ImageXView ixView = new ImageXView(imagXpress1))
                    {
                        ixView.Image = imageXView1.Image.Copy();

                        imgCopy = imageXView1.Image.Copy();
                        ImageX grayedImage = Helper.TransformIfGrayscale(imgCopy);

                        if (grayedImage != null)
                        {
                            helper.Image = ixView.Image;
                            helper.DisposeOfImageX();
                            ixView.Image = grayedImage;
                        }

                        int bpp;
                        if (grayedImage == null)
                        {
                            bpp = imageXView1.Image.BitsPerPixel;
                        }
                        else
                        {
                            bpp = ixView.Image.BitsPerPixel;
                        }

                        if (e.PageSettings.PrinterSettings.PrintRange == PrintRange.Selection)
                        {
                            using (ImageXView ixViewTemp = new ImageXView(imagXpress1))
                            {
                                ixViewTemp.Image = ixView.Image.Copy();

                                ixViewTemp.Rubberband.Start(pixelSelectionBeginPoint);
                                ixViewTemp.Rubberband.Update(pixelSelectionEndPoint);

                                if (ixView.Image != null)
                                {
                                    ixView.Image.Dispose();
                                    ixView.Image = null;
                                }
                                ixView.Image = ixViewTemp.Rubberband.Copy();

                                ixViewTemp.Rubberband.Clear();

                                //if there was nothing selected by the user, then the Image should be null, just use the whole image
                                if (ixView.Image == null)
                                {
                                    ixView.Image = ixViewTemp.Image.Copy();
                                }
                            }
                        }

                        if (notateXpress1.Layers[0].Elements.Count > 0)
                        {
                            Helper.BrandImage(ixView,
                                notateXpress1.Layers.SaveToMemoryStream(new Accusoft.NotateXpressSdk.SaveOptions()),
                                bpp);
                        }
                        if (helper.IsWatemarkNeeded())
                        {
                            Helper.WatermarkImage(ixView, bpp);
                        }

                        using (Image imageToPrint = ixView.Image.ToBitmap(true))
                        {
                            e.Graphics.DrawImage(imageToPrint, 0, 0);
                        }
                    }
                }
                else
                {
                    using (ImageX imageXToPrint = ImageX.FromFile(imagXpress1, helper.OpenedFileName, printPageCounter))
                    {
                        using (ImageXView ixView = new ImageXView(imagXpress1))
                        {
                            ixView.Image = imageXToPrint;

                            if (helper.IsWatemarkNeeded())
                            {
                                Helper.WatermarkImage(ixView, imageXToPrint.BitsPerPixel);
                            }

                            using (Image imageToPrint = imageXToPrint.ToBitmap(true))
                            {
                                e.Graphics.DrawImage(imageToPrint, 0, 0);
                            }
                        }
                    }
                }
                printPageCounter++;

                //if 'some pages' enabled and we haven't reached the 'To Page' yet
                //or if printing all pages and haven't reached page count yet, indicate there's more to print
                if (e.PageSettings.PrinterSettings.PrintRange == PrintRange.SomePages && printPageCounter <= e.PageSettings.PrinterSettings.ToPage
                   || (e.PageSettings.PrinterSettings.PrintRange == PrintRange.AllPages && printPageCounter <= helper.OpenedPageCount))
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
            catch (ImageXException ex)
            {
                MessageBox.Show(ex.Message, Constants.printErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (imgCopy != null)
                {
                    imgCopy.Dispose();
                    imgCopy = null;
                }
            }
        }

        private void imageXView1_ToolEvent(object sender, ToolEventArgs e)
        {
            //keep track of the area that the user selects
            if (e.Tool == Tool.Select)
            {
                PointF translatedPointF = imageXView1.Translate(e.Location, TranslateType.ViewToPixel);
                Point translatedPoint = new Point((int)translatedPointF.X, (int)translatedPointF.Y);

                if (e.Action == ToolAction.Begin)
                {
                    viewSelectionBeginPoint = e.Location;
                    pixelSelectionBeginPoint = translatedPoint;
                }
                if (e.Action == ToolAction.End)
                {
                    viewSelectionEndPoint = e.Location;
                    pixelSelectionEndPoint = translatedPoint;
                }
            }
        }

        private void MetadataMenuItem_Click(object sender, EventArgs e)
        {
            using (MetadataForm metaForm = new MetadataForm())
            {
                #if LICENSED
                    metaForm.License = license;
                #endif

                ReadMetadata();

                metaForm.TagsImg = imageTags;
                metaForm.Filename = helper.OpenedFileName;
                metaForm.Image = imageXView1.Image;

                metaForm.ShowDialog();
            }
        }

        private void ThumbnailImageSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ViewTabControl.Invalidate();

            //deselect the splitter by giving focus to the ImageXView
            this.ActiveControl = imageXView1;
        }

        #endregion

        #region Methods

        private bool CanCurrentlyOpenedImageBeClosed()
        {
            if (currentlyOpenedImageHasBeenEdited)
            {
                DialogResult result = MessageBox.Show(Constants.savePromptString, Constants.imageNotSavedString, 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Cancel)
                {
                    //cancelled, so don't proceed with closing
                    return false;
                }
                else if (result == DialogResult.Yes)
                {
                    //false parameter indicates don't load newly saved image in main viewer
                    DialogResult saveAsResult = SaveAsImage(false);

                    if (saveAsResult == DialogResult.Cancel)
                    {
                        //user cancelled saving dialog, so don't proceed with closing
                        return false;
                    }
                }

                //whether the image was saved or not, reset the flag so image is no longer marked as 'edited'
                currentlyOpenedImageHasBeenEdited = false;

                //image was edited and either saved or not, can proceed with close now
                return true;
            }

            //image hasn't been edited, so indicate the image can be losed
            return true;
        }

        private void CloseImage(string filename)
        {
            if (CanCurrentlyOpenedImageBeClosed())
            {
                RemoveThumbnailItem(filename);
                ResetUI();
            }
        }

        private void ResetImage()
        {
            helper.Image = imageXView1.Image;
            helper.DisposeOfImageX();
        }

        private void ResetUI()
        {
            ResetImage();
            IsImageOpenUpdateUI(false);
            ResetPageUI();
        }

        private void LoadImageAndThumbnail(string filename, bool cameraRawEnabled, bool expandMultiPage, Accusoft.ImagXpressSdk.LoadOptions lo)
        {
            LoadImage(filename, 1, lo);

            thumbnailXpress1.CameraRaw = cameraRawEnabled;
            LoadThumb(filename, cameraRawEnabled, expandMultiPage);

            //at this point the image should've loaded, if the Image is null some exception has most likely occured
            //and been handled so disable the UI
            if (imageXView1.Image == null)
            {
                CloseImage(filename);
            }
        }

        private void AlphaEnableMenu(bool isEnabled)
        {
            AlphaMenuItem.Enabled = AlphaFlattenMenuItem.Enabled
                = AlphaMergeMenuItem.Enabled = AlphaReduceToAlphaMenuItem.Enabled
                = isEnabled;
        }

        private void ReadMetadata()
        {
            if (imageTags != null)
            {
                imageTags.Dispose();
                imageTags = null;
            }
            imageTags = ImageX.ReadAllMetaData(imagXpress1, helper.OpenedFileName, helper.OpenedPageNumber);
        }

        private void UpdateUIBasedOnBitDepth()
        {
            //only enable for 32-bit images
            if (imageXView1.Image.BitsPerPixel == 32)
            {
                AlphaEnableMenu(true);
            }
            else
            {
                AlphaEnableMenu(false);
            }

            //certain image processing operations don't support images other than 8-24bpp
            if (imageXView1.Image.BitsPerPixel >= 8 && imageXView1.Image.BitsPerPixel <= 24)
            {
                ColorBalanceAutoMenuItem.Enabled = true;
                ColorBalanceManualMenuItem.Enabled = true;
                LightnessAutoMenuItem.Enabled = true;
                LightnessManualMenuItem.Enabled = true;
            }
            else
            {
                ColorBalanceAutoMenuItem.Enabled = false;
                ColorBalanceManualMenuItem.Enabled = false;
                LightnessAutoMenuItem.Enabled = false;
                LightnessManualMenuItem.Enabled = false;
            }

            /*disable any image procesing actions that won't have any useful effect for 1bpp
            disable histogram for 1bpp*/
            if (imageXView1.Image.BitsPerPixel == 1)
            {
                PosterizeMenuItem.Enabled = SolarizeMenuItem.Enabled = ParabolicMenuItem.Enabled =
                ColorModifyAdjustHSLMenuItem.Enabled = ColorModifyAdjustRGBMenuItem.Enabled = ColorModifyReplaceColorsMenuItem.Enabled =
                HistogramMenuItem.Enabled = false;
            }
            else
            {
                PosterizeMenuItem.Enabled = SolarizeMenuItem.Enabled = ParabolicMenuItem.Enabled =
                ColorModifyAdjustHSLMenuItem.Enabled = ColorModifyAdjustRGBMenuItem.Enabled = ColorModifyReplaceColorsMenuItem.Enabled =
                HistogramMenuItem.Enabled = true;
            }

            //color separation should only be applied to 24 or 32bpp images
            if (imageXView1.Image.BitsPerPixel == 24 || imageXView1.Image.BitsPerPixel == 32)
            {
                ColorSeparationMenuItem.Enabled = true;
            }
            else
            {
                ColorSeparationMenuItem.Enabled = false;
            }
        }

        private void IsImageOpenUpdateUI(bool isImageOpen)
        {
            CloseMenuItem.Enabled = PropertiesMenuItem.Enabled = ColorSeparationMenuItem.Enabled
                = ColorModifyMenuItem.Enabled = FlipMenuItem.Enabled = MirrorMenuItem.Enabled
                = RotateMenuItem.Enabled = ResizeMenuItem.Enabled = SaveAsMenuItem.Enabled
                = SaveAsImageMenuItem.Enabled = SaveAsImageWithOptionsMenuItem.Enabled
                = SaveAsButton.Enabled = PageTextBox.Enabled = PhotoMenu.Enabled
                = DocumentCleanupMenu.Enabled = ZoomInButton.Enabled = ZoomOutButton.Enabled
                = MagnifyButton.Enabled = PanButton.Enabled = SelectionButton.Enabled
                = ZoomRectangleButton.Enabled = PointerButton.Enabled = ButtonToolButton.Enabled 
                = EllipseToolButton.Enabled = FreehandToolButton.Enabled = HighlightToolButton.Enabled 
                = ImageToolButton.Enabled = LineToolButton.Enabled = PolygonToolButton.Enabled 
                = PolylineToolButton.Enabled = ProtractorToolButton.Enabled = RectangleToolButton.Enabled 
                = RulerToolButton.Enabled = StampToolButton.Enabled = TextToolButton.Enabled 
                = NoteToolButton.Enabled = HistogramMenuItem.Enabled = CropMenuItem.Enabled 
                = PrintMenuItem.Enabled = PrintButton.Enabled = MetadataMenuItem.Enabled
                = isImageOpen;

            if (imageXView1.Image != null)
            {             
                if (isImageOpen)
                {
                    ReadMetadata();

                    //disable metadata menu item if there is none
                    if (imageTags.Tags != null || imageXView1.Image.JpegCommentCount > 0 
                        || imageTags.CalTags != null || imageTags.IptcDataSet != null)
                    {
                        MetadataMenuItem.Enabled = true;
                    }
                    else
                    {
                        MetadataMenuItem.Enabled = false;
                    }

                    UpdateUIBasedOnBitDepth();
                }
            }

            //reset tool selection
            SelectButtonAndAnnotationTool(PointerButton, AnnotationTool.PointerTool);
            UpdateThumbnailAnnotations(GetSelectedThumbnailItem());

            if (!isImageOpen)
            {
                helper.OpenedFileName = String.Empty;
            }

            if (isImageOpen)
            {
                SlideShowMenuItem.Enabled = true;
            }
            else
            {
                //Slide Show is available if any images are in the Thumbnail control
                if (thumbnailXpress1.Items.Count == 0)
                {
                    SlideShowMenuItem.Enabled = false;
                }
            }
        }

        private void ResetPageUI()
        {
            PageCountLabel.Text = String.Empty;
            PageTextBox.Text = String.Empty;
            PreviousPageButton.Enabled = false;
            NextPageButton.Enabled = false;
        }

        private ThumbnailItem GetSelectedThumbnailItem()
        {
            if (thumbnailXpress1.SelectedItems.Count > 0)
            {
                return thumbnailXpress1.SelectedItems[0];
            }

            return null;
        }

        private void LoadImage(string filename, int pageNumber, Accusoft.ImagXpressSdk.LoadOptions lo)
        {
            try
            {
                ResetImage();
                ResetPageUI();
                imageXView1.Image = ImageX.FromFile(imagXpress1, filename, pageNumber, lo);

                helper.OpenedFileName = filename;
                helper.OpenedFormat = imageXView1.Image.Format;
                helper.OpenedPageCount = imageXView1.Image.PageCount;
                helper.OpenedPageNumber = pageNumber;
                helper.OpenedFileSize = imageXView1.Image.ImageXData.Size;

                printerSettings.ToPage = helper.OpenedPageCount;
                printerSettings.FromPage = 1;
                pixelSelectionBeginPoint = new Point(0, 0);
                pixelSelectionEndPoint = new Point(0, 0);
                viewSelectionBeginPoint = new Point(0, 0);
                viewSelectionEndPoint = new Point(0, 0);

                notateXpress1.Layers.Clear();
                notateXpress1.Layers.Add(new Layer());

                AspectXNumericUpDown.Value = defaultAspectXRatio = imageXView1.AspectX;
                AspectYNumericUpDown.Value = defaultAspectYRatio = imageXView1.AspectY;

                IsImageOpenUpdateUI(true);

                UpdatePageUI();
            }
            catch (ImageXException ex)
            {
                MessageBox.Show(ex.Message, Constants.loadErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);

                CloseImage(filename);
            }
        }

        private void LoadThumb(string filename, bool cameraRawEnabled, bool expandMultiPage)
        {
            try
            {
                thumbnailXpress1.Items.AddItemsFromFile(filename, 0, expandMultiPage);
                if (cameraRawEnabled)
                {
                    thumbnailXpress1.Items[0].UserTag = Constants.cameraRawString;
                }
                SelectThumbnailItem(thumbnailXpress1.Items[0]);
            }
            catch (ThumbnailXpressException ex)
            {
                if (ex.Number != 16008)
                {
                    MessageBox.Show(ex.Message, Constants.thumbnailErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void WatermarkThenSaveImage(string filename, int openedPageNumber, Accusoft.ImagXpressSdk.SaveOptions so)
        {
            using (ImageXView ixView = new ImageXView(imagXpress1))
            {
                /*if user has selected an area of the image, save only this area
                 *note: high-gray is not supported 
                */
                if (openedPageNumber == imageXView1.Image.Page &&
                    viewSelectionBeginPoint != viewSelectionEndPoint &&
                    viewSelectionBeginPoint != new Point(0, 0) && viewSelectionEndPoint != new Point(0, 0)
                    && (imageXView1.Image.BitsPerPixel <= 8 || imageXView1.Image.BitsPerPixel > 16))
                {
                    imageXView1.Rubberband.Start(viewSelectionBeginPoint);
                    imageXView1.Rubberband.Update(viewSelectionEndPoint);

                    ixView.Image = imageXView1.Rubberband.Copy();

                    imageXView1.Rubberband.Clear();

                    viewSelectionBeginPoint = new Point(0, 0);
                    viewSelectionEndPoint = new Point(0, 0);
                }
                else
                {
                    ixView.Image = imageXView1.Image;
                }
                if (helper.IsWatemarkNeeded())
                {
                    Helper.WatermarkImage(ixView, imageXView1.Image.BitsPerPixel);
                }

                ixView.Image.Save(filename, so);
            }
        }

        private void SaveImage(string filename, Accusoft.ImagXpressSdk.SaveOptions so)
        {
            //don't have ImagXpress save embedded annotations
            so.Annotations.Save = false;

            ImageX imgCopy = null;
            try
            {
                //reset the flag so image is no longer marked as 'edited'
                currentlyOpenedImageHasBeenEdited = false;

                int currentPageNumber = imageXView1.Image.Page;

                if (so.Dcx.MultiPage || so.Icon.MultiPage
                    || so.Tiff.MultiPage)
                {
                    for (int i = 1; i <= imageXView1.Image.PageCount; i++)
                    {
                        imageXView1.Image.Page = i;

                        //only apply annotations to page currently in view because annotations are only supported on a single page
                        //in this demo, also make sure there are annotations to brand
                        if (helper.OpenedPageNumber == imageXView1.Image.Page && notateXpress1.Layers[0].Elements.Count > 0)
                        {
                            using (ImageXView ixView = new ImageXView(imagXpress1))
                            {
                                ixView.Image = imageXView1.Image;
                                Helper.BrandImage(ixView,
                                    notateXpress1.Layers.SaveToMemoryStream(new Accusoft.NotateXpressSdk.SaveOptions()),
                                    imageXView1.Image.BitsPerPixel);
                            }
                        }
                        WatermarkThenSaveImage(filename, currentPageNumber, so);
                    }

                    imageXView1.Image.Page = currentPageNumber;
                }
                else
                {
                    imgCopy = imageXView1.Image.Copy();
                    ImageX grayedImage = Helper.TransformIfGrayscale(imgCopy);

                    if (grayedImage != null)
                    {
                        helper.Image = imageXView1.Image;
                        helper.DisposeOfImageX();
                        imageXView1.Image = grayedImage;
                    }

                    if (notateXpress1.Layers[0].Elements.Count > 0)
                    {
                        using (ImageXView ixView = new ImageXView(imagXpress1))
                        {
                            ixView.Image = imageXView1.Image;
                            Helper.BrandImage(ixView,
                                notateXpress1.Layers.SaveToMemoryStream(new Accusoft.NotateXpressSdk.SaveOptions()),
                                imageXView1.Image.BitsPerPixel);
                        }
                    }

                    WatermarkThenSaveImage(filename, currentPageNumber, so);
                }
            }
            catch (ImageXException ex)
            {
                MessageBox.Show(ex.Message, Constants.saveErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (imgCopy != null)
                {
                    imgCopy.Dispose();
                    imgCopy = null;
                }
            }
        }

        private void RemoveThumbnailItem(string filename)
        {
            for (int thumbnailIndex = 0; thumbnailIndex < thumbnailXpress1.Items.Count; thumbnailIndex++)
            {
                if (thumbnailXpress1.Items[thumbnailIndex].Filename == filename)
                {
                    thumbnailXpress1.Items.RemoveAt(thumbnailIndex);
                    thumbnailIndex--;
                }
            }
        }

        private void UpdateThumbnailUIForPaging()
        {
            for (int thumbnailIndex = 0; thumbnailIndex < thumbnailXpress1.Items.Count; thumbnailIndex++)
            {
                if (thumbnailXpress1.Items[thumbnailIndex].Filename == imageXView1.Image.Filename
                    && thumbnailXpress1.Items[thumbnailIndex].Page == imageXView1.Image.Page)
                {
                    SelectThumbnailItem(thumbnailXpress1.Items[thumbnailIndex]);
                    thumbnailXpress1.EnsureVisible(thumbnailIndex);
                    break;
                }
            }
        }

        private void UpdatePageUI()
        {
            //single-page
            if (imageXView1.Image.PageCount == 1)
            {
                PreviousPageButton.Enabled = false;
                NextPageButton.Enabled = false;
            }
            //multi-page
            else if (imageXView1.Image.PageCount > 1)
            {
                if (imageXView1.Image.Page == 1)
                {
                    //on first page
                    PreviousPageButton.Enabled = false;
                    NextPageButton.Enabled = true;
                }
                else if (imageXView1.Image.Page == imageXView1.Image.PageCount)
                {
                    //on last page
                    PreviousPageButton.Enabled = true;
                    NextPageButton.Enabled = false;
                }
                else
                {
                    //not on first or last page, in the middle
                    PreviousPageButton.Enabled = true;
                    NextPageButton.Enabled = true;
                }
            }

            PageTextBox.Text = imageXView1.Image.Page.ToString();
            PageCountLabel.Text = String.Format(Constants.ofString, imageXView1.Image.PageCount);
        }

        private void SelectThumbnailItem(ThumbnailItem itemToSelect)
        {
            thumbnailXpress1.SelectedItems.Clear();
            thumbnailXpress1.SelectedItems.Add(itemToSelect);
        }

        private void OpenProfileFile(ProfileType profile, TextBox textBox)
        {
            try
            {
                using (OpenFileDialog openDlg = new OpenFileDialog())
                {
                    openDlg.Title = String.Format("Open {0} Profile", profile);
                    openDlg.Filter = Constants.profileFilterString;
                    openDlg.FilterIndex = openProfileNameFilterIndex;
                    openDlg.InitialDirectory = openProfileNameInitialDirectory;

                    if (openDlg.ShowDialog() == DialogResult.OK)
                    {
                        openProfileNameInitialDirectory = Path.GetDirectoryName(openDlg.FileName);
                        openProfileNameFilterIndex = openDlg.FilterIndex;

                        switch (profile)
                        {
                            case ProfileType.Monitor:
                                {
                                    imageXView1.MonitorProfileName = openDlg.FileName;
                                    break;
                                }
                            case ProfileType.Printer:
                                {
                                    imageXView1.PrinterProfileName = openDlg.FileName;
                                    break;
                                }
                            case ProfileType.Target:
                                {
                                    imageXView1.TargetProfileName = openDlg.FileName;
                                    break;
                                }
                        }

                        textBox.Text = openDlg.FileName;
                    }
                }
            }
            catch (ImageXViewException ex)
            {
                MessageBox.Show(ex.Message, Constants.colorProfileErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateFontUI()
        {
            FontNameTextBox.Text = thumbnailXpress1.Font.Name;
            FontSizeNumericUpDown.Value = (decimal)thumbnailXpress1.Font.Size;
            FontBoldComboBox.SelectedIndex = thumbnailXpress1.Font.Bold ? 0 : 1;
            FontItalicComboBox.SelectedIndex = thumbnailXpress1.Font.Italic ? 0 : 1;
            FontStrikeoutComboBox.SelectedIndex = thumbnailXpress1.Font.Strikeout ? 0 : 1;
            FontUnderlineComboBox.SelectedIndex = thumbnailXpress1.Font.Underline ? 0 : 1;
        }

        private void UpdateFontStyle(int comboBoxSelectedIndex, FontStyle style)
        {
            FontStyle styleChosen = thumbnailXpress1.Font.Style;
            //first entry in ComboBox is True, so apply the style
            if (comboBoxSelectedIndex == 0)
            {
                styleChosen |= style;
            }
            else
            {
                //ComboBox entry is False, so remove the style
                styleChosen &= ~style;
            }

            //create a new font in order to change the existing font's attributes
            Font newFont = new Font(thumbnailXpress1.Font.Name, thumbnailXpress1.Font.Size, styleChosen);
            thumbnailXpress1.Font = newFont;
        }

        private void SetThumbnailDefaults()
        {
            CellWidthNumericUpDown.Value = CellHeightNumericUpDown.Value = 130;
            thumbnailXpress1.BackColor = ThumbnailBackColorButton.BackColor
                = CellSpacingColorButton.BackColor = thumbnailXpress1.CellSpacingColor
                = Color.FromKnownColor(KnownColor.Window);
            SelectBackColorButton.BackColor = thumbnailXpress1.SelectBackColor
                = Color.FromKnownColor(KnownColor.Highlight);
            CellBorderWidthNumericUpDown.Value = 1;
            CellBorderColorButton.BackColor = thumbnailXpress1.CellBorderColor
                = Color.FromKnownColor(KnownColor.WindowFrame);
            CellHorizontalSpacingNumericUpDown.Value = CellVerticalSpacingNumericUpDown.Value = 5;
            DescriptorHorizontalAlignmentComboBox.SelectedIndex = 1;
            DescriptorVerticalAlignmentComboBox.SelectedIndex = 2;
            DescriptorDisplayMethodComboBox.SelectedIndex = 0;
            ScrollDirectionComboBox.SelectedIndex = 1;

            thumbnailXpress1.Font = defaultFont;
            UpdateFontUI();

            TextBackColorButton.BackColor = thumbnailXpress1.TextBackColor
                = Color.FromKnownColor(KnownColor.Window);
            ForeColorButton.BackColor = thumbnailXpress1.ForeColor
                = Color.FromKnownColor(KnownColor.WindowText);
            ThumbnailPreserveBlackCheckBox.Checked = false;
            ShowImagePlaceholdersCheckBox.Checked = false;
            ShowWorkingCursorCheckBox.Checked = true;
        }

        private void SetDefaults()
        {
            openFileFilterIndex = mergeSourceImageFilterIndex = openFileAllFilesFilterIndex;
            openCameraRawFilterIndex = openCameraRawAllFilesFilterIndex;

            string commonImagesPath;

            #if LICENSED
	            commonImagesPath = Path.GetFullPath(Constants.changeToCommonImagesPathCompiledExe);
            #else
                commonImagesPath = Path.GetFullPath(Constants.changeToCommonImagesPathSample);
            #endif

            openFileInitialDirectory = openCameraRawInitialDirectory = saveFileInitialDirectory
                = openProfileNameInitialDirectory = paletteNameInitialDirectory = helper.SaveOptionsTifTargetProfileInitialDirectory
                = helper.SaveOptionsJpegTargetProfileInitialDirectory = mergeSourceImageInitialDirectory
                = scanTwainSaveInitialDirectory = scanIsisSaveInitialDirectory
                = (Directory.Exists(commonImagesPath) ? commonImagesPath : String.Empty);

            processingClarifyDeskewBackgroundColor = processingAlphaMergeTransparentColor
                = processingAlphaAlphaFlatten
                = processingPolynomialWarpBackgroundColor = processingPerspectiveBackgroundColor
                = defaultPhotoProcessingColor;
            processingOrientationRotateBackgroundColor = defaultProcessingColor;

            thumbnailXpress1.ThreadHungThreshold = Int32.MaxValue;
            AspectXNumericUpDown.Maximum = Int32.MaxValue;
            AspectYNumericUpDown.Maximum = Int32.MaxValue;

            viewAndAnnotationToolButtons = new ToolStripButton[] { ZoomInButton, ZoomOutButton, 
                MagnifyButton, ZoomRectangleButton, PanButton, SelectionButton, PointerButton,
                ButtonToolButton, EllipseToolButton, FreehandToolButton, HighlightToolButton, 
                ImageToolButton, LineToolButton, PolygonToolButton, PolylineToolButton, 
                ProtractorToolButton, RectangleToolButton, RulerToolButton, StampToolButton, 
                TextToolButton, NoteToolButton };

            Font textFont = new Font(FontFamily.GenericSerif, 32, FontStyle.Bold);

            notateXpress1.ToolbarDefaults.StampToolbarDefaults.BackColor = Color.White;
            notateXpress1.ToolbarDefaults.StampToolbarDefaults.BackStyle = BackStyle.Opaque;
            notateXpress1.ToolbarDefaults.StampToolbarDefaults.Text = Constants.stampString;
            notateXpress1.ToolbarDefaults.StampToolbarDefaults.TextFont = textFont;
            notateXpress1.ToolbarDefaults.StampToolbarDefaults.PenWidth = 3;
            notateXpress1.ToolbarDefaults.StampToolbarDefaults.PenColor = Color.Red;

            notateXpress1.ToolbarDefaults.TextToolbarDefaults.TextFont = textFont;

            using (ImageX imageTool = ImageX.FromBitmap(imagXpress1, Properties.Resources.ImageForImageTool))
            {
                notateXpress1.ToolbarDefaults.ImageToolbarDefaults.DibHandle = imageTool.ToHdib(true);
            }

            ShowHideSettingsButton.Text = showSettingsString;
            ViewTabControl.Visible = false;
            StatusBarLabel.Text = welcomeString;
        }

        private void SetViewDefaults()
        {
            HorizontalAlignmentComboBox.SelectedIndex = 1;
            VerticalAlignmentComboBox.SelectedIndex = 1;
            AutoResizeComboBox.SelectedIndex = 2;
            imageXView1.ZoomFactor = (int)ZoomFactorNumericUpDown.Value;
            BackColorButton.BackColor = imageXView1.BackColor = Color.FromKnownColor(KnownColor.Control);
            AlphaBlendCheckBox.Checked = false;
            PreserveBlackCheckBox.Checked = false;
            DitheredCheckBox.Checked = true;
            ProgressiveCheckBox.Checked = false;
            AntiAliasCheckBox.Checked = true;
            SmoothingCheckBox.Checked = true;
            BrightnessNumericUpDown.Value = 0;
            ContrastNumericUpDown.Value = 0;
            if (imageXView1.Image != null)
            {
                AspectXNumericUpDown.Value = defaultAspectXRatio;
                AspectYNumericUpDown.Value = defaultAspectYRatio;
            }
            else
            {
                AspectXNumericUpDown.Value = 1;
                AspectYNumericUpDown.Value = 1;
            }
        }

        private void SetColorDefaults()
        {
            PaletteTypeComboBox.SelectedIndex = 0;
            DisplayModeComboBox.SelectedIndex = 0;
            ColorRenderIntentComboBox.SelectedIndex = 0;
            MonitorProfileNameTextBox.Text
                = TargetProfileNameTextBox.Text
                = PrinterProfileNameTextBox.Text
                = PaletteFileNameTextBox.Text
                = String.Empty;
            ICMProofingCheckBox.Checked = false;
        }

        private DialogResult DisplayProcessingForm(ProcessingForm processingForm, bool useBitmap)
        {
            try
            {
                /*if user has selected an area of the image, apply image processing action only to this area
                 *note: high-gray is not supported 
                */
                if (viewSelectionBeginPoint != viewSelectionEndPoint && 
                    viewSelectionBeginPoint != new Point(0,0) && viewSelectionEndPoint != new Point(0,0)
                    && (imageXView1.Image.BitsPerPixel <= 8 || imageXView1.Image.BitsPerPixel > 16))
                {
                    imageXView1.Rubberband.Start(viewSelectionBeginPoint);
                    imageXView1.Rubberband.Update(viewSelectionEndPoint);

                    processingForm.SetInputImage(imageXView1.Rubberband.Copy());
                    
                    imageXView1.Rubberband.Clear();
                }
                else
                {
                    processingForm.SetInputImage(imageXView1.Image.Copy());
                }
                if (processingForm.ShowDialog() == DialogResult.OK)
                {
                    ResetImage();
                    if (useBitmap)
                    {
                        imageXView1.Image = ImageX.FromBitmap(imagXpress1, processingForm.OutputBitmap);
                    }
                    else
                    {
                        imageXView1.Image = processingForm.OutputImage.Copy();
                    }

                    currentlyOpenedImageHasBeenEdited = true;
                    viewSelectionBeginPoint = new Point(0, 0);
                    viewSelectionEndPoint = new Point(0, 0);

                    UpdateUIBasedOnBitDepth();

                    return DialogResult.OK;
                }
            }
            catch (ImageXException ex)
            {
                MessageBox.Show(ex.Message, Constants.imageInformationErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return DialogResult.Cancel;
        }

        private bool CheckIfImageIsDocument()
        {
            if (imageXView1.Image.BitsPerPixel != 1)
            {
                MessageBox.Show(Constants.oneBppError, Constants.cleanupError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckIfIsisIsSupported()
        {
            if (IntPtr.Size == 4)
            {
                return true;
            }
            else
            {
                MessageBox.Show(Constants.isisErrorString, Constants.isisString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private static void SelectToolbarButton(ToolStripButton selectedButton, ToolStripButton[] buttons)
        {
            foreach (ToolStripButton button in buttons)
            {
                if (button != selectedButton)
                {
                    button.Checked = false;
                }
                else
                {
                    button.Checked = true;
                }
            }
        }

        private void SelectButtonAndViewTool(ToolStripButton button, Tool tool)
        {
            SelectToolbarButton(button, viewAndAnnotationToolButtons);

            //reset to pointer for annotations
            notateXpress1.Layers[0].Toolbar.Selected = AnnotationTool.PointerTool;
            imageXView1.ToolSet(tool, MouseButtons.Left, Keys.None);
        }

        private void SelectButtonAndAnnotationTool(ToolStripButton button, AnnotationTool tool)
        {
            SelectToolbarButton(button, viewAndAnnotationToolButtons);

            imageXView1.ToolSet(Tool.None, MouseButtons.Left, Keys.None);
            if (notateXpress1.Layers.Count > 0)
            {
                notateXpress1.Layers[0].Toolbar.Selected = tool;
            }
        }

        private void UpdateThumbnailAnnotations(ThumbnailItem itemSelected)
        {
            if (itemSelected != null)
            {
                Accusoft.NotateXpressSdk.SaveOptions so = new Accusoft.NotateXpressSdk.SaveOptions();

                using (MemoryStream ms = notateXpress1.Layers.SaveToThumbnailAnnotationStream(so))
                {
                    itemSelected.LoadAnnotationsFromStream(ms);
                }
            }
        }

        #endregion
    }
}