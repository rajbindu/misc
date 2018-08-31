﻿/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
namespace ImagXpressDemo
{
    static class Constants
    {
        public const int tooltipInitialDelay = 100;
        public const int tooltipDuration = 5000;
        public const int balloonToolTipHorizontalSpacer = 20;
        public const int balloonToolTipVerticalSpacer = 75;
        public const int boundaryPercent = 100;
        public const int boundaryUnits = 255;
        public const int boundaryHSLUnits = 360;

        public const float defaultFontSize = 90;
        public const float defaultFontIncrementSize = 5;
        public const float watermarkWidthPercentage = .65F;
        public const float watermarkDimensionPercentage = .85F;

        public const string namespaceString = "ImagXpressDemo.";
        public const string license32DLLString = "ImagXpressDemoLicense32.dll";
        public const string license64DLLString = "ImagXpressDemoLicense64.dll";
        public const string imageString = "Image";
        public const string thumbnailString = "Thumbnail";
        public const string exifString = "Exif";
        public const string customString = "Custom";
        public const string spaceString = " ";
        public const string demoString = "ImagXpress DEMO\r\n";
        public const string accusoftString = "www.accusoft.com";
        public const string accusoftHelpString = "www.accusoft.com/manuals.htm";
        public const string kernel32String = "kernel32.dll";
        public const string user32String = "user32.dll";
        public const string savePromptString = "Do you want to save your changes to the image?";
        public const string histogramLocationString = "Index: {0}, Intensity: {1}";
        public const string x86String = "x86";
        public const string x64String = "x64";
        public const string stampString = "Accusoft Corporation www.Accusoft.com";
        public const string isisString = "ISIS Scan";
        public const string saveScannedImageString = "Would you like to save the scanned image to disk?";
        public const string saveImageString = "Save Image";

        public const string commentsErrorString = "Error acquiring JPEG Comments.";
        public const string colorProfileErrorString = "Error setting Color Profile.";
        public const string acquireErrorString = "Error acquiring image.";
        public const string saveErrorString = "Error saving image.";
        public const string loadErrorString = "Error loading image.";
        public const string printErrorString = "Error printing image.";
        public const string watermarkErrorString = "Error watermarking image.";
        public const string brandingErrorString = "Error branding annotations.";
        public const string imageInformationErrorString = "Error getting image information.";
        public const string thumbnailErrorString = "Error thumbnailing image.";
        public const string exifThumbnailErrorString = "Error getting Exif thumbnail.";
        public const string processingErrorString = "Error processing image.";
        public const string mergeErrorString = "You must specify a source image to merge with.";
        public const string imageNotSavedString = "Image not Saved"; 
        public const string cmykSaveErrorString = "You must select a Target Profile to save as CMYK.";
        public const string dsmErrorString = "Error Selecting DSM";
        public const string matrixError = "Matrix Error";
        public const string divisorError = "Divisor can't be 0.";
        public const string binarizeError = "Binarize Error";
        public const string highThresholdError = "The High Threshold can't be less than the Low Threshold.";
        public const string lowThresholdError = "The Low Threshold can't be greater than the High Threshold.";
        public const string oneBppError = "This method only works with 1 Bit Per Pixel images, please choose either Binarize or AutoBinarize from the Document Cleanup menu first.";
        public const string cleanupError = "Cleanup Error";
        public const string twainErrorString = "TWAIN error, Condition Code: {0}, Condition Description: {1}";
        public const string isisErrorString = "ISISXpress can't run in a 64-bit context, application must be recompiled to target x86.";

        public const string cameraRawString = "CameraRaw";
        public const string noneString = "None";
        public const string lzwString = "LZW";
        public const string rleString = "Rle";
        public const string packBitsString = "PackBits";
        public const string group31DString = "Group 3 1D";
        public const string group32DString = "Group 3 2D";
        public const string group4String = "Group 4";
        public const string deflateString = "Deflate";
        public const string jpegString = "Jpeg";
        public const string jpeg7String = "Jpeg7";

        public const string autoColorBalanceString = "Auto Color Balance";
        public const string autoLevelString = "Auto Level";
        public const string despeckleString = "Despeckle";
        public const string dilateString = "Dilate";
        public const string erodeString = "Erode";
        public const string autoContrastString = "Auto Contrast";
        public const string equalizeString = "Equalize";
        public const string autoLightnessString = "Auto Lightness";
        public const string autoCropString = "Auto Crop";
        public const string cropBorderString = "Crop Border";
        public const string flipString = "Flip";
        public const string mirrorString = "Mirror";
        public const string sharpenString = "Sharpen";
        public const string unsharpenString = "Unsharpen";
        public const string softenString = "Soften";
        public const string sharpenFilter1 = "Sharpen 1";
        public const string sharpenFilter2 = "Sharpen 2";
        public const string sharpenFilter3 = "Sharpen 3";
        public const string softenFilter0 = "Soften 0";
        public const string softenFilter1 = "Soften 1";
        public const string softenFilter2 = "Soften 2";
        public const string softenFilter3 = "Soften 3";
        public const string unsharpenFilter1 = "Unsharpen 1";
        public const string unsharpenFilter2 = "Unsharpen 2";
        public const string unsharpenFilter3 = "Unsharpen 3";
        public const string brightnessString = "Brightness";
        public const string contrastString = "Contrast";
        public const string gammaString = "Gamma";
        public const string noDitherString = "No Dither";
        public const string floydString = "Floyd";
        public const string orderedString ="Ordered";
        public const string pegasusString = "Pegasus";
        public const string binarizeQuickTextString = "Binarize Quick Text";
        public const string binarizeHalfToneString = "Binarize Half Tone";
        public const string adjustRGBString = "Adjust RGB";
        public const string adjustHSLString = "Adjust HSL";
        public const string adjustColorBalanceString = "Adjust Color Balance";
        public const string autoRemoveRedEyeString = "Auto Remove Red Eye";
        public const string removeRedEyeString = "Remove Red Eye";
        public const string deskewString = "Deskew";
        public const string rotateString = "Rotate";
        public const string mergeString = "Merge";
        public const string blendString = "Blend";
        public const string blurString = "Blur";
        public const string diffuseString = "Diffuse";
        public const string embossString = "Emboss";
        public const string medianString = "Median";
        public const string negateString = "Negate";
        public const string mosaicString = "Mosaic";
        public const string outlineString = "Outline";
        public const string swirlString = "Swirl";
        public const string solarizeString = "Solarize";
        public const string posterizeString = "Posterize";
        public const string pinchString = "Pinch";
        public const string twistString = "Twist";
        public const string topToBottomString = "Top to Bottom";
        public const string bottomToTopString = "Bottom to Top";
        public const string leftToRightString = "Left to Right";
        public const string rightToLeftString = "Right to Left";
        public const string convexString = "Convex";
        public const string concaveString = "Concave";
        public const string buttonizeString = "Buttonize";
        public const string insetString = "Inset";
        public const string raisedString = "Raised";
        public const string rippleString = "Ripple";
        public const string tileString = "Tile";
        public const string horizontalString = "Horizontal";
        public const string verticalString = "Vertical";
        public const string bothString = "Both";
        public const string noiseString = "Noise";
        public const string parabolicString = "Parabolic";
        public const string adjustLightnessString = "Adjust Lightness";
        public const string removeDustString = "Remove Dust";
        public const string removeScratchesString = "Remove Scratches";
        public const string autoBinarizeString = "Auto Binarize";
        public const string allString = "All";
        public const string upString = "Up";
        public const string leftString = "Left";
        public const string rightString = "Right";
        public const string downString = "Down";
        public const string leftAndUpString = "Left and Up";
        public const string leftAndDownString = "Left and Down";
        public const string rightAndUpString = "Right and Up";
        public const string rightAndDownString = "Right and Down";
        public const string smoothZoomString = "Smooth Zoom";

        public const string percentString = "Percent:";
        public const string intensityString = "Intensity:";
        public const string blockSizeString = "Block Size:";
        public const string degreesString = "Degrees:";
        public const string numberOfLevelsString = "Number of Levels:";
        public const string filterString = "Filter:";
        public const string rotate90String = "90 Degrees";
        public const string rotate180String = "180 Degrees";
        public const string rotate270String = "270 Degrees";
        public const string rotateRandomString = "Randomly";
        public const string perspectiveString = "Perspective";
        public const string thresholdString = "Threshold:";
        public const string rotationString = "Rotation:";
        public const string typeString = "Type:";
        public const string styleString = "Style:";
        public const string widthString = "Width:";
        public const string directionString = "Direction:";
        public const string frequencyString = "Frequency:";
        public const string shadowsString = "Shadows:";
        public const string highlightsString = "Highlights:";
        public const string heightString = "Height:";
        public const string amountString = "Amount:";
        public const string tagString = "Tag";
        public const string tagTypeString = "Type";
        public const string recordString = "Record";
        public const string dataString = "Data";
        public const string pointerString = "Pointer";
        public const string toolString = "Tool";
        public const string zoomRectangleString = "Zoom Rectangle";

        public const string ofString = "of {0}";
        public const string changeToCommonImagesPathCompiledExe = "..\\..\\..\\..\\..\\..\\Common\\Images\\";
        public const string changeToCommonImagesPathSample = "..\\..\\..\\..\\..\\..\\..\\..\\..\\Common\\Images\\";
        public const string saveImageAsString = "Save Image As";
        public const string openImageString = "Open Image";
        public const string openPaletteString = "Open Palette";
        public const string openCameraRawString = "Open Camera Raw Image";
        public const string cmykSaveString = "Save to CMYK";
        
        public const string openFilterString = "Bitmap (*.bmp)|*.bmp|CALS Raster (*.cal)|*.cal|Design Web Format (*.dwf)|*.dwf|Drawing (*.dwg)|*.dwg|Drawing Exchange Format (*.dxf)|*.dxf|Enhanced MetaFile Format (*.emf)|*.emf|Graphics Interchange Format (*.gif)|*.gif|ICON (*.ico)|*.ico|Image Object Content Architecture (*.ica)|*.ica|JBIG2 (*.jb2)|*.jb2|JEDMICS C4 (*.c4)|*.c4|JFIF Compliant JPEG (*.jpg, *.jpeg)|*.jpg;*.jpeg;*.jif|JPEG2000 (*.jp2, *.j2k)|*.jp2;*.j2k|JPEG LS (*.jls)|*.jls|JPEG XR (*.hdp, *.wdp, *.jxr)|*.hdp;*.wdp;*.jxr|Lossless JPEG (*.ljp)|*.ljp|MO:DCA (*.dca, *.mod)|*.dca;*.mod|PIC or Enhanced PIC (*.pic, *.epic)|*.pic;*.epic|Portable Bitmap (*.pbm)|*.pbm|Portable Graymap (*.pgm)|*.pgm|Portable Network Graphics (*.png)|*.png|Portable Pixmap (*.ppm)|*.ppm|Tagged Image Format (*.tif, *.tiff)|*.tif;*.tiff|Truevision TARGA (*.tga)|*.tga|Wavelet Scalar Quantization (*.wsq)|*.wsq|Windows Metafile Format (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|ZSoft Multiple Page (*.dcx)|*.dcx|ZSoft PaintBrush (*.pcx)|*.pcx|All Files (*.*)|*.*";       
        public const string saveFilterString = "Bitmap (*.bmp)|*.bmp|CALS Raster (*.cal)|*.cal|Enhanced PIC (*.epic)|*.epic|EXIF JPEG (*.jpg)|*.jpg|Graphics Interchange Format (*.gif)|*.gif|ICON (*.ico)|*.ico|JBIG2 (*.jb2)|*.jb2|JFIF Compliant JPEG (*.jpg)|*.jpg;|JPEG2000 (*.jp2)|*.jp2|JPEG LS (*.jls)|*.jls|JPEG XR (*.jxr)|*.jxr|Lossless JPEG (*.ljp)|*.ljp|MO:DCA (*.dca)|*.dca|Portable Bitmap (*.pbm)|*.pbm|Portable Graymap (*.pgm)|*.pgm|Portable Network Graphics (*.png)|*.png|Portable Pixmap (*.ppm)|*.ppm|Tagged Image Format (*.tif)|*.tif;|Truevision TARGA (*.tga)|*.tga|Wavelet Scalar Quantization (*.wsq)|*.wsq|Wireless Bitmap (*.wbmp)|*.wbmp|ZSoft Multiple Page (*.dcx)|*.dcx|ZSoft PaintBrush (*.pcx)|*.pcx";
        public const string openCameraRawFilterString = "Adobe (*.dng)|*.dng|Apple (*.qtk)|*.qtk|Canon (*.cr2, *.crw)|*.cr2;*.crw|Casio (*.bay)|*.bay|Epson (*.erf)|*.erf|Fuji (*.raf)|*.raf|Hasselblad (*.3fr)|*.3fr|Imacom Ixpress (*.fff)|*.fff|Kodak (*.dcr,*.dcs,*.drf,*.k25,*.kc2,*.kdc)|*.dcr;*.dcs;*.drf;*.k25;*.kc2;*.kdc|Leaf (*.mos)|*.mos|Leica (*.dng)|*.dng|Logitech (*.pxn)|*.pxn|Mamiya (*.mef)|*.mef|Minolta (*.mrw)|*.mrw|Nikon (*.nef,*.nrw)|*.nef;*.nrw|Olympus (*.orf)|*.orf|Panasonic (*.rw2)|*.rw2|Pentax (*.pef)|*.pef|Rawzor (*.rwz)|*.rwz|Samsung (*.srw)|*.srw|Sinar (*.cs1, *.sti)|*.cs1;*.sti|Sony (*.arw, *.sr2, *.srf)|*.arw;*.sr2;*.srf|All Files (*.*)|*.*";        
        public const string profileFilterString = "ICC Profile (*.icc)|*.icc|ICM Profile (*.icm)|*.icm|All Files (*.*)|*.*";
        public const string allFilesFilterString = "All Files (*.*)|*.*";
    }
}