using Accusoft.NotateXpressSdk;

namespace ImagXpressDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (isisXpress1 != null)
            {
                isisXpress1.Dispose();
                isisXpress1 = null;
            }
            if (printPro1 != null)
            {
                printPro1.Dispose();
                printPro1 = null;
            }
            if (twainPro1 != null)
            {
                twainPro1.Dispose();
                twainPro1 = null;
            }
            if (notateXpress1 != null)
            {
                foreach(Layer layer in notateXpress1.Layers)
                {
                    layer.Elements.Dispose();
                }
                notateXpress1.Layers.Dispose();
                
                notateXpress1.ClientDisconnect();
                notateXpress1.Dispose();
                notateXpress1 = null;
            }
            if (thumbnailXpress1 != null)
            {
                thumbnailXpress1.Dispose();
                thumbnailXpress1 = null;
            }
            if (imageXView1 != null)
            {
                if (imageXView1.ContextMenu.MenuItems.Count > 0)
                {
                    for (int contextMenuIndex = 0; contextMenuIndex < imageXView1.ContextMenu.MenuItems[0].MenuItems.Count; contextMenuIndex++)
                    {
                        imageXView1.ContextMenu.MenuItems[0].MenuItems[contextMenuIndex].Click -= ContextMenuClickEventHandler;
                    }
                    for (int contextMenuIndex = 1; contextMenuIndex < imageXView1.ContextMenu.MenuItems.Count; contextMenuIndex++)
                    {
                        imageXView1.ContextMenu.MenuItems[contextMenuIndex].Click -= ContextMenuClickEventHandler;
                    }
                }

                if (imageXView1.Image != null)
                {
                    imageXView1.Image.Dispose();
                    imageXView1.Image = null;
                }
                imageXView1.Dispose();
                imageXView1 = null;
            }
            if (imageTags != null)
            {
                imageTags.Dispose();
                imageTags = null;
            }
            if (imagXpress1 != null)
            {
                imagXpress1.Dispose();
                imagXpress1 = null;
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenImageWithOptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenCameraRawMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScanMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TwainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ISISMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsImageWithOptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveExitSeparatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistogramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MetadataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CropMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoCropMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManualCropMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CropBorderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FlipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MirrorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RotateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SlideShowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocumentCleanupMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoBinarizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BinarizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlobRemovalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BorderCropMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeskewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DespeckleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DilateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ErodeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineRemovalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SmoothZoomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhotoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorModifyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorModifyAdjustHSLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorModifyAdjustRGBMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorModifyColorDepthMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorModifyReplaceColorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorSeparationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EffectsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlendMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlurMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiffuseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmbossMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MatrixMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MedianMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MosaicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MotionBlurMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NegateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoiseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OutlineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParabolicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PerspectiveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PinchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PolynomialWarpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PosterizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RippleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SolarizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SwirlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TwistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnhancementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlphaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlphaFlattenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlphaMergeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlphaReduceToAlphaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClarifyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClarifyDeskewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClarifyDespeckleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClarifyDilateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClarifyErodeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorCorrectionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoLevelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrightnessSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorBalanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorBalanceAutoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorBalanceManualMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContrastMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContrastAutoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContrastManualMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrightnessGammaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContrastEqualizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightnessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightnessAutoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightnessManualMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveDefectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveDustMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveScratchesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedEyeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedEyeRemovalAutoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedEyeRemovalManualMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SharpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SharpenSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoftenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnsharpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OnlineHelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagXpressMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IsisXpressMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotateXpressMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintProMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThumbnailXpressMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TwainProMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.OpenButton = new System.Windows.Forms.ToolStripSplitButton();
            this.OpenImageButtonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenImageWithOptionsButtonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenCameraRawButtonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsButton = new System.Windows.Forms.ToolStripSplitButton();
            this.SaveAsImageButtonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsImageWithOptionsButtonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScanButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.TwainButtonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IsisButtonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintButton = new System.Windows.Forms.ToolStripButton();
            this.FileImagXpressSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.PointerButton = new System.Windows.Forms.ToolStripButton();
            this.ZoomInButton = new System.Windows.Forms.ToolStripButton();
            this.ZoomOutButton = new System.Windows.Forms.ToolStripButton();
            this.MagnifyButton = new System.Windows.Forms.ToolStripButton();
            this.ZoomRectangleButton = new System.Windows.Forms.ToolStripButton();
            this.SelectionButton = new System.Windows.Forms.ToolStripButton();
            this.PanButton = new System.Windows.Forms.ToolStripButton();
            this.ImagXpressAnnotationSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonToolButton = new System.Windows.Forms.ToolStripButton();
            this.EllipseToolButton = new System.Windows.Forms.ToolStripButton();
            this.FreehandToolButton = new System.Windows.Forms.ToolStripButton();
            this.HighlightToolButton = new System.Windows.Forms.ToolStripButton();
            this.ImageToolButton = new System.Windows.Forms.ToolStripButton();
            this.LineToolButton = new System.Windows.Forms.ToolStripButton();
            this.PolygonToolButton = new System.Windows.Forms.ToolStripButton();
            this.PolylineToolButton = new System.Windows.Forms.ToolStripButton();
            this.ProtractorToolButton = new System.Windows.Forms.ToolStripButton();
            this.RectangleToolButton = new System.Windows.Forms.ToolStripButton();
            this.RulerToolButton = new System.Windows.Forms.ToolStripButton();
            this.StampToolButton = new System.Windows.Forms.ToolStripButton();
            this.TextToolButton = new System.Windows.Forms.ToolStripButton();
            this.NoteToolButton = new System.Windows.Forms.ToolStripButton();
            this.AnnotationsPageSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.PageLabel = new System.Windows.Forms.ToolStripLabel();
            this.PageTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.PageCountLabel = new System.Windows.Forms.ToolStripLabel();
            this.PreviousPageButton = new System.Windows.Forms.ToolStripButton();
            this.NextPageButton = new System.Windows.Forms.ToolStripButton();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.thumbnailXpress1 = new Accusoft.ThumbnailXpressSdk.ThumbnailXpress();
            this.ThumbnailImageSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ThumbnailSettingsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ClearThumbnailsPanel = new System.Windows.Forms.Panel();
            this.ClearImagesButton = new System.Windows.Forms.Button();
            this.ViewTabControl = new System.Windows.Forms.TabControl();
            this.ViewSettingsTabPage = new System.Windows.Forms.TabPage();
            this.ViewDefaultButton = new System.Windows.Forms.Button();
            this.ZoomFactorLabel = new System.Windows.Forms.Label();
            this.ZoomFactorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SmoothingCheckBox = new System.Windows.Forms.CheckBox();
            this.DitheredCheckBox = new System.Windows.Forms.CheckBox();
            this.AspectYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AspectXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AspectYLabel = new System.Windows.Forms.Label();
            this.AspectXLabel = new System.Windows.Forms.Label();
            this.ContrastNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.BrightnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AlphaBlendCheckBox = new System.Windows.Forms.CheckBox();
            this.ProgressiveCheckBox = new System.Windows.Forms.CheckBox();
            this.PreserveBlackCheckBox = new System.Windows.Forms.CheckBox();
            this.AntiAliasCheckBox = new System.Windows.Forms.CheckBox();
            this.StyleGroupBox = new System.Windows.Forms.GroupBox();
            this.BackColorButton = new System.Windows.Forms.Button();
            this.BackColorLabel = new System.Windows.Forms.Label();
            this.HorizontalAlignmentLabel = new System.Windows.Forms.Label();
            this.VerticalAlignmentLabel = new System.Windows.Forms.Label();
            this.HorizontalAlignmentComboBox = new System.Windows.Forms.ComboBox();
            this.VerticalAlignmentComboBox = new System.Windows.Forms.ComboBox();
            this.AutoResizeComboBox = new System.Windows.Forms.ComboBox();
            this.AutoResizeLabel = new System.Windows.Forms.Label();
            this.ColorManagementTabPage = new System.Windows.Forms.TabPage();
            this.ICMProofingCheckBox = new System.Windows.Forms.CheckBox();
            this.ColorDefaultButton = new System.Windows.Forms.Button();
            this.PaletteGroupBox = new System.Windows.Forms.GroupBox();
            this.PaletteFileNameLabel = new System.Windows.Forms.Label();
            this.PaletteTypeLabel = new System.Windows.Forms.Label();
            this.PaletteTypeComboBox = new System.Windows.Forms.ComboBox();
            this.PaletteFileNameTextBox = new System.Windows.Forms.TextBox();
            this.PaletteFileNameButton = new System.Windows.Forms.Button();
            this.ColorGroupBox = new System.Windows.Forms.GroupBox();
            this.DisplayModeLabel = new System.Windows.Forms.Label();
            this.DisplayModeComboBox = new System.Windows.Forms.ComboBox();
            this.ProofingGroupBox = new System.Windows.Forms.GroupBox();
            this.ColorRenderIntentLabel = new System.Windows.Forms.Label();
            this.MonitorProfileNameButton = new System.Windows.Forms.Button();
            this.TargetProfileNameLabel = new System.Windows.Forms.Label();
            this.TargetProfileNameButton = new System.Windows.Forms.Button();
            this.MonitorProfileNameLabel = new System.Windows.Forms.Label();
            this.ColorRenderIntentComboBox = new System.Windows.Forms.ComboBox();
            this.PrinterProfileNameLabel = new System.Windows.Forms.Label();
            this.MonitorProfileNameTextBox = new System.Windows.Forms.TextBox();
            this.TargetProfileNameTextBox = new System.Windows.Forms.TextBox();
            this.PrinterProfileNameTextBox = new System.Windows.Forms.TextBox();
            this.PrinterProfileNameButton = new System.Windows.Forms.Button();
            this.ThumbnailTabPage = new System.Windows.Forms.TabPage();
            this.ThumbnailDefaultButton = new System.Windows.Forms.Button();
            this.CellBorderGroupBox = new System.Windows.Forms.GroupBox();
            this.CellBorderWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CellBorderWithLabel = new System.Windows.Forms.Label();
            this.CellBorderColor = new System.Windows.Forms.Label();
            this.CellBorderColorButton = new System.Windows.Forms.Button();
            this.ShowImagePlaceholdersCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowWorkingCursorCheckBox = new System.Windows.Forms.CheckBox();
            this.ScrollDirectionLabel = new System.Windows.Forms.Label();
            this.ScrollDirectionComboBox = new System.Windows.Forms.ComboBox();
            this.ThumbnailPreserveBlackCheckBox = new System.Windows.Forms.CheckBox();
            this.CellGroupBox = new System.Windows.Forms.GroupBox();
            this.CellWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CellWidthLabel = new System.Windows.Forms.Label();
            this.CellHeightLabel = new System.Windows.Forms.Label();
            this.SelectBackColorButton = new System.Windows.Forms.Button();
            this.SelectBackColorLabel = new System.Windows.Forms.Label();
            this.CellHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ThumbnailBackColorLabel = new System.Windows.Forms.Label();
            this.ThumbnailBackColorButton = new System.Windows.Forms.Button();
            this.CellSpacingGroupBox = new System.Windows.Forms.GroupBox();
            this.CellHorizontalSpacingLabel = new System.Windows.Forms.Label();
            this.CellSpacingColorButton = new System.Windows.Forms.Button();
            this.CellSpacingColorLabel = new System.Windows.Forms.Label();
            this.CellHorizontalSpacingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CellVerticalSpacingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CellVerticalSpacingLabel = new System.Windows.Forms.Label();
            this.DescriptorGroupBox = new System.Windows.Forms.GroupBox();
            this.FontNameButton = new System.Windows.Forms.Button();
            this.FontSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FontBoldLabel = new System.Windows.Forms.Label();
            this.FontBoldComboBox = new System.Windows.Forms.ComboBox();
            this.FontItalicComboBox = new System.Windows.Forms.ComboBox();
            this.FontStrikeoutComboBox = new System.Windows.Forms.ComboBox();
            this.FontUnderlineComboBox = new System.Windows.Forms.ComboBox();
            this.FontUnderlineLabel = new System.Windows.Forms.Label();
            this.FontStrikeoutLabel = new System.Windows.Forms.Label();
            this.FontItalicLabel = new System.Windows.Forms.Label();
            this.FontSizeLabel = new System.Windows.Forms.Label();
            this.FontNameLabel = new System.Windows.Forms.Label();
            this.FontShowHideButton = new System.Windows.Forms.Button();
            this.DescriptorVerticalAlignmentLabel = new System.Windows.Forms.Label();
            this.TextBackColorLabel = new System.Windows.Forms.Label();
            this.TextBackColorButton = new System.Windows.Forms.Button();
            this.DescriptorVerticalAlignmentComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptorDisplayMethodComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptorDisplayMethodLabel = new System.Windows.Forms.Label();
            this.DescriptorHorizontalAlignmentLabel = new System.Windows.Forms.Label();
            this.DescriptorHorizontalAlignmentComboBox = new System.Windows.Forms.ComboBox();
            this.FontLabel = new System.Windows.Forms.Label();
            this.ForeColorLabel = new System.Windows.Forms.Label();
            this.ForeColorButton = new System.Windows.Forms.Button();
            this.FontNameTextBox = new System.Windows.Forms.TextBox();
            this.ShowHideSettingsPanel = new System.Windows.Forms.Panel();
            this.ShowHideSettingsLabel = new System.Windows.Forms.Label();
            this.ShowHideSettingsButton = new System.Windows.Forms.Button();
            this.twainPro1 = new Accusoft.TwainProSdk.TwainPro(this.components);
            this.notateXpress1 = new Accusoft.NotateXpressSdk.NotateXpress(this.components);
            this.printPro1 = new Accusoft.PrintProSdk.PrintPro(this.components);
            this.MainMenu.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.ThumbnailImageSplitContainer.Panel1.SuspendLayout();
            this.ThumbnailImageSplitContainer.Panel2.SuspendLayout();
            this.ThumbnailImageSplitContainer.SuspendLayout();
            this.ThumbnailSettingsSplitContainer.Panel1.SuspendLayout();
            this.ThumbnailSettingsSplitContainer.Panel2.SuspendLayout();
            this.ThumbnailSettingsSplitContainer.SuspendLayout();
            this.ClearThumbnailsPanel.SuspendLayout();
            this.ViewTabControl.SuspendLayout();
            this.ViewSettingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomFactorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AspectYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AspectXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessNumericUpDown)).BeginInit();
            this.StyleGroupBox.SuspendLayout();
            this.ColorManagementTabPage.SuspendLayout();
            this.PaletteGroupBox.SuspendLayout();
            this.ColorGroupBox.SuspendLayout();
            this.ProofingGroupBox.SuspendLayout();
            this.ThumbnailTabPage.SuspendLayout();
            this.CellBorderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CellBorderWidthNumericUpDown)).BeginInit();
            this.CellGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CellWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellHeightNumericUpDown)).BeginInit();
            this.CellSpacingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CellHorizontalSpacingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellVerticalSpacingNumericUpDown)).BeginInit();
            this.DescriptorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeNumericUpDown)).BeginInit();
            this.ShowHideSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.ImageMenu,
            this.DocumentCleanupMenu,
            this.PhotoMenu,
            this.HelpMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(868, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.CloseMenuItem,
            this.ScanMenuItem,
            this.PrintMenuItem,
            this.SaveAsMenuItem,
            this.SaveExitSeparatorMenuItem,
            this.ExitMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "&File";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenImageMenuItem,
            this.OpenImageWithOptionsMenuItem,
            this.OpenCameraRawMenuItem});
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(114, 22);
            this.OpenMenuItem.Text = "&Open";
            // 
            // OpenImageMenuItem
            // 
            this.OpenImageMenuItem.Name = "OpenImageMenuItem";
            this.OpenImageMenuItem.Size = new System.Drawing.Size(178, 22);
            this.OpenImageMenuItem.Text = "&Image";
            this.OpenImageMenuItem.Click += new System.EventHandler(this.ImageMenuItem_Click);
            // 
            // OpenImageWithOptionsMenuItem
            // 
            this.OpenImageWithOptionsMenuItem.Name = "OpenImageWithOptionsMenuItem";
            this.OpenImageWithOptionsMenuItem.Size = new System.Drawing.Size(178, 22);
            this.OpenImageWithOptionsMenuItem.Text = "Image with &Options";
            this.OpenImageWithOptionsMenuItem.Click += new System.EventHandler(this.ImageWithOptionsMenuItem_Click);
            // 
            // OpenCameraRawMenuItem
            // 
            this.OpenCameraRawMenuItem.Name = "OpenCameraRawMenuItem";
            this.OpenCameraRawMenuItem.Size = new System.Drawing.Size(178, 22);
            this.OpenCameraRawMenuItem.Text = "&Camera Raw";
            this.OpenCameraRawMenuItem.Click += new System.EventHandler(this.CameraRawMenuItem_Click);
            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.Enabled = false;
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new System.Drawing.Size(114, 22);
            this.CloseMenuItem.Text = "C&lose";
            this.CloseMenuItem.Click += new System.EventHandler(this.CloseMenuItem_Click);
            // 
            // ScanMenuItem
            // 
            this.ScanMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TwainMenuItem,
            this.ISISMenuItem});
            this.ScanMenuItem.Name = "ScanMenuItem";
            this.ScanMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ScanMenuItem.Text = "S&can";
            // 
            // TwainMenuItem
            // 
            this.TwainMenuItem.Name = "TwainMenuItem";
            this.TwainMenuItem.Size = new System.Drawing.Size(112, 22);
            this.TwainMenuItem.Text = "T&WAIN";
            this.TwainMenuItem.Click += new System.EventHandler(this.TwainMenuItem_Click);
            // 
            // ISISMenuItem
            // 
            this.ISISMenuItem.Name = "ISISMenuItem";
            this.ISISMenuItem.Size = new System.Drawing.Size(112, 22);
            this.ISISMenuItem.Text = "&ISIS";
            this.ISISMenuItem.Click += new System.EventHandler(this.ISISMenuItem_Click);
            // 
            // PrintMenuItem
            // 
            this.PrintMenuItem.Enabled = false;
            this.PrintMenuItem.Name = "PrintMenuItem";
            this.PrintMenuItem.Size = new System.Drawing.Size(114, 22);
            this.PrintMenuItem.Text = "&Print";
            this.PrintMenuItem.Click += new System.EventHandler(this.PrintMenuItem_Click);
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAsImageMenuItem,
            this.SaveAsImageWithOptionsMenuItem});
            this.SaveAsMenuItem.Enabled = false;
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.Size = new System.Drawing.Size(114, 22);
            this.SaveAsMenuItem.Text = "Save &As";
            // 
            // SaveAsImageMenuItem
            // 
            this.SaveAsImageMenuItem.Enabled = false;
            this.SaveAsImageMenuItem.Name = "SaveAsImageMenuItem";
            this.SaveAsImageMenuItem.Size = new System.Drawing.Size(178, 22);
            this.SaveAsImageMenuItem.Text = "&Image";
            this.SaveAsImageMenuItem.Click += new System.EventHandler(this.SaveAsImageMenuItem_Click);
            // 
            // SaveAsImageWithOptionsMenuItem
            // 
            this.SaveAsImageWithOptionsMenuItem.Enabled = false;
            this.SaveAsImageWithOptionsMenuItem.Name = "SaveAsImageWithOptionsMenuItem";
            this.SaveAsImageWithOptionsMenuItem.Size = new System.Drawing.Size(178, 22);
            this.SaveAsImageWithOptionsMenuItem.Text = "Image with &Options";
            this.SaveAsImageWithOptionsMenuItem.Click += new System.EventHandler(this.SaveAsImageWithOptionsMenuItem_Click);
            // 
            // SaveExitSeparatorMenuItem
            // 
            this.SaveExitSeparatorMenuItem.Name = "SaveExitSeparatorMenuItem";
            this.SaveExitSeparatorMenuItem.Size = new System.Drawing.Size(111, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ExitMenuItem.Text = "E&xit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // ImageMenu
            // 
            this.ImageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PropertiesMenuItem,
            this.HistogramMenuItem,
            this.MetadataMenuItem,
            this.CropMenuItem,
            this.FlipMenuItem,
            this.MirrorMenuItem,
            this.RotateMenuItem,
            this.ResizeMenuItem,
            this.SlideShowMenuItem});
            this.ImageMenu.Name = "ImageMenu";
            this.ImageMenu.Size = new System.Drawing.Size(52, 20);
            this.ImageMenu.Text = "&Image";
            // 
            // PropertiesMenuItem
            // 
            this.PropertiesMenuItem.Enabled = false;
            this.PropertiesMenuItem.Name = "PropertiesMenuItem";
            this.PropertiesMenuItem.Size = new System.Drawing.Size(131, 22);
            this.PropertiesMenuItem.Text = "Pr&operties";
            this.PropertiesMenuItem.Click += new System.EventHandler(this.PropertiesMenuItem_Click);
            // 
            // HistogramMenuItem
            // 
            this.HistogramMenuItem.Enabled = false;
            this.HistogramMenuItem.Name = "HistogramMenuItem";
            this.HistogramMenuItem.Size = new System.Drawing.Size(131, 22);
            this.HistogramMenuItem.Text = "&Histogram";
            this.HistogramMenuItem.Click += new System.EventHandler(this.HistogramMenuItem_Click);
            // 
            // MetadataMenuItem
            // 
            this.MetadataMenuItem.Enabled = false;
            this.MetadataMenuItem.Name = "MetadataMenuItem";
            this.MetadataMenuItem.Size = new System.Drawing.Size(131, 22);
            this.MetadataMenuItem.Text = "Meta&data";
            this.MetadataMenuItem.Click += new System.EventHandler(this.MetadataMenuItem_Click);
            // 
            // CropMenuItem
            // 
            this.CropMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoCropMenuItem,
            this.ManualCropMenuItem,
            this.CropBorderMenuItem});
            this.CropMenuItem.Enabled = false;
            this.CropMenuItem.Name = "CropMenuItem";
            this.CropMenuItem.Size = new System.Drawing.Size(131, 22);
            this.CropMenuItem.Text = "C&rop";
            // 
            // AutoCropMenuItem
            // 
            this.AutoCropMenuItem.Name = "AutoCropMenuItem";
            this.AutoCropMenuItem.Size = new System.Drawing.Size(151, 22);
            this.AutoCropMenuItem.Text = "Crop (&Auto)";
            this.AutoCropMenuItem.Click += new System.EventHandler(this.CropAutoMenuItem_Click);
            // 
            // ManualCropMenuItem
            // 
            this.ManualCropMenuItem.Name = "ManualCropMenuItem";
            this.ManualCropMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ManualCropMenuItem.Text = "Crop (&Manual)";
            this.ManualCropMenuItem.Click += new System.EventHandler(this.CropManualMenuItem_Click);
            // 
            // CropBorderMenuItem
            // 
            this.CropBorderMenuItem.Name = "CropBorderMenuItem";
            this.CropBorderMenuItem.Size = new System.Drawing.Size(151, 22);
            this.CropBorderMenuItem.Text = "Crop &Border";
            this.CropBorderMenuItem.Click += new System.EventHandler(this.CropBorderMenuItem_Click);
            // 
            // FlipMenuItem
            // 
            this.FlipMenuItem.Enabled = false;
            this.FlipMenuItem.Name = "FlipMenuItem";
            this.FlipMenuItem.Size = new System.Drawing.Size(131, 22);
            this.FlipMenuItem.Text = "Fli&p";
            this.FlipMenuItem.Click += new System.EventHandler(this.OrientationFlipMenuItem_Click);
            // 
            // MirrorMenuItem
            // 
            this.MirrorMenuItem.Enabled = false;
            this.MirrorMenuItem.Name = "MirrorMenuItem";
            this.MirrorMenuItem.Size = new System.Drawing.Size(131, 22);
            this.MirrorMenuItem.Text = "&Mirror";
            this.MirrorMenuItem.Click += new System.EventHandler(this.OrientationMirrorMenuItem_Click);
            // 
            // RotateMenuItem
            // 
            this.RotateMenuItem.Enabled = false;
            this.RotateMenuItem.Name = "RotateMenuItem";
            this.RotateMenuItem.Size = new System.Drawing.Size(131, 22);
            this.RotateMenuItem.Text = "Rota&te";
            this.RotateMenuItem.Click += new System.EventHandler(this.OrientationRotateMenuItem_Click);
            // 
            // ResizeMenuItem
            // 
            this.ResizeMenuItem.Enabled = false;
            this.ResizeMenuItem.Name = "ResizeMenuItem";
            this.ResizeMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ResizeMenuItem.Text = "Resi&ze";
            this.ResizeMenuItem.Click += new System.EventHandler(this.ResizeMenuItem_Click);
            // 
            // SlideShowMenuItem
            // 
            this.SlideShowMenuItem.Enabled = false;
            this.SlideShowMenuItem.Name = "SlideShowMenuItem";
            this.SlideShowMenuItem.Size = new System.Drawing.Size(131, 22);
            this.SlideShowMenuItem.Text = "&Slide Show";
            this.SlideShowMenuItem.Click += new System.EventHandler(this.SlideShowMenuItem_Click);
            // 
            // DocumentCleanupMenu
            // 
            this.DocumentCleanupMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoBinarizeMenuItem,
            this.BinarizeMenuItem,
            this.BlobRemovalMenuItem,
            this.BorderCropMenuItem,
            this.DeskewMenuItem,
            this.DespeckleMenuItem,
            this.DilateMenuItem,
            this.ErodeMenuItem,
            this.LineRemovalMenuItem,
            this.SmoothZoomMenuItem});
            this.DocumentCleanupMenu.Enabled = false;
            this.DocumentCleanupMenu.Name = "DocumentCleanupMenu";
            this.DocumentCleanupMenu.Size = new System.Drawing.Size(122, 20);
            this.DocumentCleanupMenu.Text = "&Document Cleanup";
            // 
            // AutoBinarizeMenuItem
            // 
            this.AutoBinarizeMenuItem.Name = "AutoBinarizeMenuItem";
            this.AutoBinarizeMenuItem.Size = new System.Drawing.Size(164, 22);
            this.AutoBinarizeMenuItem.Text = "&Auto Binarize";
            this.AutoBinarizeMenuItem.Click += new System.EventHandler(this.AutoBinarizeMenuItem_Click);
            // 
            // BinarizeMenuItem
            // 
            this.BinarizeMenuItem.Name = "BinarizeMenuItem";
            this.BinarizeMenuItem.Size = new System.Drawing.Size(164, 22);
            this.BinarizeMenuItem.Text = "&Binarize";
            this.BinarizeMenuItem.Click += new System.EventHandler(this.BinarizeMenuItem_Click);
            // 
            // BlobRemovalMenuItem
            // 
            this.BlobRemovalMenuItem.Name = "BlobRemovalMenuItem";
            this.BlobRemovalMenuItem.Size = new System.Drawing.Size(164, 22);
            this.BlobRemovalMenuItem.Text = "Blob &Removal";
            this.BlobRemovalMenuItem.Click += new System.EventHandler(this.BlobRemovalMenuItem_Click);
            // 
            // BorderCropMenuItem
            // 
            this.BorderCropMenuItem.Name = "BorderCropMenuItem";
            this.BorderCropMenuItem.Size = new System.Drawing.Size(164, 22);
            this.BorderCropMenuItem.Text = "Border &Crop";
            this.BorderCropMenuItem.Click += new System.EventHandler(this.BorderCropMenuItem_Click);
            // 
            // DeskewMenuItem
            // 
            this.DeskewMenuItem.Name = "DeskewMenuItem";
            this.DeskewMenuItem.Size = new System.Drawing.Size(164, 22);
            this.DeskewMenuItem.Text = "&Deskew";
            this.DeskewMenuItem.Click += new System.EventHandler(this.DeskewMenuItem_Click);
            // 
            // DespeckleMenuItem
            // 
            this.DespeckleMenuItem.Name = "DespeckleMenuItem";
            this.DespeckleMenuItem.Size = new System.Drawing.Size(164, 22);
            this.DespeckleMenuItem.Text = "D&especkle";
            this.DespeckleMenuItem.Click += new System.EventHandler(this.DespeckleMenuItem_Click);
            // 
            // DilateMenuItem
            // 
            this.DilateMenuItem.Name = "DilateMenuItem";
            this.DilateMenuItem.Size = new System.Drawing.Size(164, 22);
            this.DilateMenuItem.Text = "D&ilate";
            this.DilateMenuItem.Click += new System.EventHandler(this.DilateMenuItem_Click);
            // 
            // ErodeMenuItem
            // 
            this.ErodeMenuItem.Name = "ErodeMenuItem";
            this.ErodeMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ErodeMenuItem.Text = "Er&ode";
            this.ErodeMenuItem.Click += new System.EventHandler(this.ErodeMenuItem_Click);
            // 
            // LineRemovalMenuItem
            // 
            this.LineRemovalMenuItem.Name = "LineRemovalMenuItem";
            this.LineRemovalMenuItem.Size = new System.Drawing.Size(164, 22);
            this.LineRemovalMenuItem.Text = "&Line Removal";
            this.LineRemovalMenuItem.Click += new System.EventHandler(this.LineRemovalMenuItem_Click);
            // 
            // SmoothZoomMenuItem
            // 
            this.SmoothZoomMenuItem.Name = "SmoothZoomMenuItem";
            this.SmoothZoomMenuItem.Size = new System.Drawing.Size(164, 22);
            this.SmoothZoomMenuItem.Text = "Smooth && &Zoom";
            this.SmoothZoomMenuItem.Click += new System.EventHandler(this.SmoothZoomMenuItem_Click);
            // 
            // PhotoMenu
            // 
            this.PhotoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorModifyMenuItem,
            this.ColorSeparationMenuItem,
            this.EffectsMenuItem,
            this.EnhancementMenuItem});
            this.PhotoMenu.Enabled = false;
            this.PhotoMenu.Name = "PhotoMenu";
            this.PhotoMenu.Size = new System.Drawing.Size(51, 20);
            this.PhotoMenu.Text = "&Photo";
            // 
            // ColorModifyMenuItem
            // 
            this.ColorModifyMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorModifyAdjustHSLMenuItem,
            this.ColorModifyAdjustRGBMenuItem,
            this.ColorModifyColorDepthMenuItem,
            this.ColorModifyReplaceColorsMenuItem});
            this.ColorModifyMenuItem.Name = "ColorModifyMenuItem";
            this.ColorModifyMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ColorModifyMenuItem.Text = "Color &Modify";
            // 
            // ColorModifyAdjustHSLMenuItem
            // 
            this.ColorModifyAdjustHSLMenuItem.Name = "ColorModifyAdjustHSLMenuItem";
            this.ColorModifyAdjustHSLMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ColorModifyAdjustHSLMenuItem.Text = "&Adjust HSL";
            this.ColorModifyAdjustHSLMenuItem.Click += new System.EventHandler(this.ColorModifyAdjustHSLMenuItem_Click);
            // 
            // ColorModifyAdjustRGBMenuItem
            // 
            this.ColorModifyAdjustRGBMenuItem.Name = "ColorModifyAdjustRGBMenuItem";
            this.ColorModifyAdjustRGBMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ColorModifyAdjustRGBMenuItem.Text = "Adjust &RGB";
            this.ColorModifyAdjustRGBMenuItem.Click += new System.EventHandler(this.ColorModifyAdjustRGBMenuItem_Click);
            // 
            // ColorModifyColorDepthMenuItem
            // 
            this.ColorModifyColorDepthMenuItem.Name = "ColorModifyColorDepthMenuItem";
            this.ColorModifyColorDepthMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ColorModifyColorDepthMenuItem.Text = "Color &Depth";
            this.ColorModifyColorDepthMenuItem.Click += new System.EventHandler(this.ColorModifyColorDepthMenuItem_Click);
            // 
            // ColorModifyReplaceColorsMenuItem
            // 
            this.ColorModifyReplaceColorsMenuItem.Name = "ColorModifyReplaceColorsMenuItem";
            this.ColorModifyReplaceColorsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ColorModifyReplaceColorsMenuItem.Text = "Replace &Colors";
            this.ColorModifyReplaceColorsMenuItem.Click += new System.EventHandler(this.ColorModifyReplaceColorsMenuItem_Click);
            // 
            // ColorSeparationMenuItem
            // 
            this.ColorSeparationMenuItem.Name = "ColorSeparationMenuItem";
            this.ColorSeparationMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ColorSeparationMenuItem.Text = "&Color Separation";
            this.ColorSeparationMenuItem.Click += new System.EventHandler(this.ColorSeparationMenuItem_Click);
            // 
            // EffectsMenuItem
            // 
            this.EffectsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BlendMenuItem,
            this.BlurMenuItem,
            this.ButtonizeMenuItem,
            this.DiffuseMenuItem,
            this.EmbossMenuItem,
            this.MatrixMenuItem,
            this.MedianMenuItem,
            this.MosaicMenuItem,
            this.MotionBlurMenuItem,
            this.NegateMenuItem,
            this.NoiseMenuItem,
            this.OutlineMenuItem,
            this.ParabolicMenuItem,
            this.PerspectiveMenuItem,
            this.PinchMenuItem,
            this.PolynomialWarpMenuItem,
            this.PosterizeMenuItem,
            this.RippleMenuItem,
            this.SolarizeMenuItem,
            this.SwirlMenuItem,
            this.TileMenuItem,
            this.TwistMenuItem});
            this.EffectsMenuItem.Name = "EffectsMenuItem";
            this.EffectsMenuItem.Size = new System.Drawing.Size(162, 22);
            this.EffectsMenuItem.Text = "&Effects";
            // 
            // BlendMenuItem
            // 
            this.BlendMenuItem.Name = "BlendMenuItem";
            this.BlendMenuItem.Size = new System.Drawing.Size(165, 22);
            this.BlendMenuItem.Text = "Bl&end";
            this.BlendMenuItem.Click += new System.EventHandler(this.BlendMenuItem_Click);
            // 
            // BlurMenuItem
            // 
            this.BlurMenuItem.Name = "BlurMenuItem";
            this.BlurMenuItem.Size = new System.Drawing.Size(165, 22);
            this.BlurMenuItem.Text = "Bl&ur";
            this.BlurMenuItem.Click += new System.EventHandler(this.BlurMenuItem_Click);
            // 
            // ButtonizeMenuItem
            // 
            this.ButtonizeMenuItem.Name = "ButtonizeMenuItem";
            this.ButtonizeMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ButtonizeMenuItem.Text = "Butto&nize";
            this.ButtonizeMenuItem.Click += new System.EventHandler(this.ButtonizeMenuItem_Click);
            // 
            // DiffuseMenuItem
            // 
            this.DiffuseMenuItem.Name = "DiffuseMenuItem";
            this.DiffuseMenuItem.Size = new System.Drawing.Size(165, 22);
            this.DiffuseMenuItem.Text = "Di&ffuse";
            this.DiffuseMenuItem.Click += new System.EventHandler(this.DiffuseMenuItem_Click);
            // 
            // EmbossMenuItem
            // 
            this.EmbossMenuItem.Name = "EmbossMenuItem";
            this.EmbossMenuItem.Size = new System.Drawing.Size(165, 22);
            this.EmbossMenuItem.Text = "E&mboss";
            this.EmbossMenuItem.Click += new System.EventHandler(this.EmbossMenuItem_Click);
            // 
            // MatrixMenuItem
            // 
            this.MatrixMenuItem.Name = "MatrixMenuItem";
            this.MatrixMenuItem.Size = new System.Drawing.Size(165, 22);
            this.MatrixMenuItem.Text = "Matri&x";
            this.MatrixMenuItem.Click += new System.EventHandler(this.MatrixMenuItem_Click);
            // 
            // MedianMenuItem
            // 
            this.MedianMenuItem.Name = "MedianMenuItem";
            this.MedianMenuItem.Size = new System.Drawing.Size(165, 22);
            this.MedianMenuItem.Text = "Me&dian";
            this.MedianMenuItem.Click += new System.EventHandler(this.MedianMenuItem_Click);
            // 
            // MosaicMenuItem
            // 
            this.MosaicMenuItem.Name = "MosaicMenuItem";
            this.MosaicMenuItem.Size = new System.Drawing.Size(165, 22);
            this.MosaicMenuItem.Text = "Mos&aic";
            this.MosaicMenuItem.Click += new System.EventHandler(this.MosaicMenuItem_Click);
            // 
            // MotionBlurMenuItem
            // 
            this.MotionBlurMenuItem.Name = "MotionBlurMenuItem";
            this.MotionBlurMenuItem.Size = new System.Drawing.Size(165, 22);
            this.MotionBlurMenuItem.Text = "Motion &Blur";
            this.MotionBlurMenuItem.Click += new System.EventHandler(this.MotionBlurMenuItem_Click);
            // 
            // NegateMenuItem
            // 
            this.NegateMenuItem.Name = "NegateMenuItem";
            this.NegateMenuItem.Size = new System.Drawing.Size(165, 22);
            this.NegateMenuItem.Text = "Ne&gate";
            this.NegateMenuItem.Click += new System.EventHandler(this.NegateMenuItem_Click);
            // 
            // NoiseMenuItem
            // 
            this.NoiseMenuItem.Name = "NoiseMenuItem";
            this.NoiseMenuItem.Size = new System.Drawing.Size(165, 22);
            this.NoiseMenuItem.Text = "Noi&se";
            this.NoiseMenuItem.Click += new System.EventHandler(this.NoiseMenuItem_Click);
            // 
            // OutlineMenuItem
            // 
            this.OutlineMenuItem.Name = "OutlineMenuItem";
            this.OutlineMenuItem.Size = new System.Drawing.Size(165, 22);
            this.OutlineMenuItem.Text = "&Outline";
            this.OutlineMenuItem.Click += new System.EventHandler(this.OutlineMenuItem_Click);
            // 
            // ParabolicMenuItem
            // 
            this.ParabolicMenuItem.Name = "ParabolicMenuItem";
            this.ParabolicMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ParabolicMenuItem.Text = "Paraboli&c";
            this.ParabolicMenuItem.Click += new System.EventHandler(this.ParabolicMenuItem_Click);
            // 
            // PerspectiveMenuItem
            // 
            this.PerspectiveMenuItem.Name = "PerspectiveMenuItem";
            this.PerspectiveMenuItem.Size = new System.Drawing.Size(165, 22);
            this.PerspectiveMenuItem.Text = "Pe&rspective";
            this.PerspectiveMenuItem.Click += new System.EventHandler(this.PerspectiveMenuItem_Click);
            // 
            // PinchMenuItem
            // 
            this.PinchMenuItem.Name = "PinchMenuItem";
            this.PinchMenuItem.Size = new System.Drawing.Size(165, 22);
            this.PinchMenuItem.Text = "P&inch";
            this.PinchMenuItem.Click += new System.EventHandler(this.PinchMenuItem_Click);
            // 
            // PolynomialWarpMenuItem
            // 
            this.PolynomialWarpMenuItem.Name = "PolynomialWarpMenuItem";
            this.PolynomialWarpMenuItem.Size = new System.Drawing.Size(165, 22);
            this.PolynomialWarpMenuItem.Text = "Pol&ynomial Warp";
            this.PolynomialWarpMenuItem.Click += new System.EventHandler(this.PolynomialWarpMenuItem_Click);
            // 
            // PosterizeMenuItem
            // 
            this.PosterizeMenuItem.Name = "PosterizeMenuItem";
            this.PosterizeMenuItem.Size = new System.Drawing.Size(165, 22);
            this.PosterizeMenuItem.Text = "Po&sterize";
            this.PosterizeMenuItem.Click += new System.EventHandler(this.PosterizeMenuItem_Click);
            // 
            // RippleMenuItem
            // 
            this.RippleMenuItem.Name = "RippleMenuItem";
            this.RippleMenuItem.Size = new System.Drawing.Size(165, 22);
            this.RippleMenuItem.Text = "Ri&pple";
            this.RippleMenuItem.Click += new System.EventHandler(this.RippleMenuItem_Click);
            // 
            // SolarizeMenuItem
            // 
            this.SolarizeMenuItem.Name = "SolarizeMenuItem";
            this.SolarizeMenuItem.Size = new System.Drawing.Size(165, 22);
            this.SolarizeMenuItem.Text = "Solari&ze";
            this.SolarizeMenuItem.Click += new System.EventHandler(this.SolarizeMenuItem_Click);
            // 
            // SwirlMenuItem
            // 
            this.SwirlMenuItem.Name = "SwirlMenuItem";
            this.SwirlMenuItem.Size = new System.Drawing.Size(165, 22);
            this.SwirlMenuItem.Text = "S&wirl";
            this.SwirlMenuItem.Click += new System.EventHandler(this.SwirlMenuItem_Click);
            // 
            // TileMenuItem
            // 
            this.TileMenuItem.Name = "TileMenuItem";
            this.TileMenuItem.Size = new System.Drawing.Size(165, 22);
            this.TileMenuItem.Text = "Ti&le";
            this.TileMenuItem.Click += new System.EventHandler(this.TileMenuItem_Click);
            // 
            // TwistMenuItem
            // 
            this.TwistMenuItem.Name = "TwistMenuItem";
            this.TwistMenuItem.Size = new System.Drawing.Size(165, 22);
            this.TwistMenuItem.Text = "&Twist";
            this.TwistMenuItem.Click += new System.EventHandler(this.TwistMenuItem_Click);
            // 
            // EnhancementMenuItem
            // 
            this.EnhancementMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlphaMenuItem,
            this.ClarifyMenuItem,
            this.ColorCorrectionMenuItem,
            this.RemoveDefectMenuItem,
            this.SharpenMenuItem});
            this.EnhancementMenuItem.Name = "EnhancementMenuItem";
            this.EnhancementMenuItem.Size = new System.Drawing.Size(162, 22);
            this.EnhancementMenuItem.Text = "En&hancement";
            // 
            // AlphaMenuItem
            // 
            this.AlphaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlphaFlattenMenuItem,
            this.AlphaMergeMenuItem,
            this.AlphaReduceToAlphaMenuItem});
            this.AlphaMenuItem.Name = "AlphaMenuItem";
            this.AlphaMenuItem.Size = new System.Drawing.Size(162, 22);
            this.AlphaMenuItem.Text = "&Alpha";
            // 
            // AlphaFlattenMenuItem
            // 
            this.AlphaFlattenMenuItem.Name = "AlphaFlattenMenuItem";
            this.AlphaFlattenMenuItem.Size = new System.Drawing.Size(161, 22);
            this.AlphaFlattenMenuItem.Text = "&Flatten";
            this.AlphaFlattenMenuItem.Click += new System.EventHandler(this.AlphaFlattenMenuItem_Click);
            // 
            // AlphaMergeMenuItem
            // 
            this.AlphaMergeMenuItem.Name = "AlphaMergeMenuItem";
            this.AlphaMergeMenuItem.Size = new System.Drawing.Size(161, 22);
            this.AlphaMergeMenuItem.Text = "&Merge";
            this.AlphaMergeMenuItem.Click += new System.EventHandler(this.AlphaMergeMenuItem_Click);
            // 
            // AlphaReduceToAlphaMenuItem
            // 
            this.AlphaReduceToAlphaMenuItem.Name = "AlphaReduceToAlphaMenuItem";
            this.AlphaReduceToAlphaMenuItem.Size = new System.Drawing.Size(161, 22);
            this.AlphaReduceToAlphaMenuItem.Text = "&Reduce to Alpha";
            this.AlphaReduceToAlphaMenuItem.Click += new System.EventHandler(this.AlphaReduceToAlphaMenuItem_Click);
            // 
            // ClarifyMenuItem
            // 
            this.ClarifyMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClarifyDeskewMenuItem,
            this.ClarifyDespeckleMenuItem,
            this.ClarifyDilateMenuItem,
            this.ClarifyErodeMenuItem});
            this.ClarifyMenuItem.Name = "ClarifyMenuItem";
            this.ClarifyMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ClarifyMenuItem.Text = "C&larify";
            // 
            // ClarifyDeskewMenuItem
            // 
            this.ClarifyDeskewMenuItem.Name = "ClarifyDeskewMenuItem";
            this.ClarifyDeskewMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ClarifyDeskewMenuItem.Text = "Des&kew";
            this.ClarifyDeskewMenuItem.Click += new System.EventHandler(this.ClarifyDeskewMenuItem_Click);
            // 
            // ClarifyDespeckleMenuItem
            // 
            this.ClarifyDespeckleMenuItem.Name = "ClarifyDespeckleMenuItem";
            this.ClarifyDespeckleMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ClarifyDespeckleMenuItem.Text = "Des&peckle";
            this.ClarifyDespeckleMenuItem.Click += new System.EventHandler(this.ClarifyDespeckleMenuItem_Click);
            // 
            // ClarifyDilateMenuItem
            // 
            this.ClarifyDilateMenuItem.Name = "ClarifyDilateMenuItem";
            this.ClarifyDilateMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ClarifyDilateMenuItem.Text = "D&ilate";
            this.ClarifyDilateMenuItem.Click += new System.EventHandler(this.ClarifyDilateMenuItem_Click);
            // 
            // ClarifyErodeMenuItem
            // 
            this.ClarifyErodeMenuItem.Name = "ClarifyErodeMenuItem";
            this.ClarifyErodeMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ClarifyErodeMenuItem.Text = "Er&ode";
            this.ClarifyErodeMenuItem.Click += new System.EventHandler(this.ClarifyErodeMenuItem_Click);
            // 
            // ColorCorrectionMenuItem
            // 
            this.ColorCorrectionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoLevelMenuItem,
            this.BrightnessSubMenuItem,
            this.ColorBalanceMenuItem,
            this.ContrastMenuItem,
            this.BrightnessGammaMenuItem,
            this.ContrastEqualizeMenuItem,
            this.LightnessMenuItem});
            this.ColorCorrectionMenuItem.Name = "ColorCorrectionMenuItem";
            this.ColorCorrectionMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ColorCorrectionMenuItem.Text = "C&olor Correction";
            // 
            // AutoLevelMenuItem
            // 
            this.AutoLevelMenuItem.Name = "AutoLevelMenuItem";
            this.AutoLevelMenuItem.Size = new System.Drawing.Size(147, 22);
            this.AutoLevelMenuItem.Text = "&Auto Level";
            this.AutoLevelMenuItem.Click += new System.EventHandler(this.ColorBalanceLevelMenuItem_Click);
            // 
            // BrightnessSubMenuItem
            // 
            this.BrightnessSubMenuItem.Name = "BrightnessSubMenuItem";
            this.BrightnessSubMenuItem.Size = new System.Drawing.Size(147, 22);
            this.BrightnessSubMenuItem.Text = "Brig&htness";
            this.BrightnessSubMenuItem.Click += new System.EventHandler(this.BrightnessSubMenuItem_Click);
            // 
            // ColorBalanceMenuItem
            // 
            this.ColorBalanceMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorBalanceAutoMenuItem,
            this.ColorBalanceManualMenuItem});
            this.ColorBalanceMenuItem.Name = "ColorBalanceMenuItem";
            this.ColorBalanceMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ColorBalanceMenuItem.Text = "&Color Balance";
            // 
            // ColorBalanceAutoMenuItem
            // 
            this.ColorBalanceAutoMenuItem.Name = "ColorBalanceAutoMenuItem";
            this.ColorBalanceAutoMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ColorBalanceAutoMenuItem.Text = "&Auto";
            this.ColorBalanceAutoMenuItem.Click += new System.EventHandler(this.ColorBalanceAutoMenuItem_Click);
            // 
            // ColorBalanceManualMenuItem
            // 
            this.ColorBalanceManualMenuItem.Name = "ColorBalanceManualMenuItem";
            this.ColorBalanceManualMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ColorBalanceManualMenuItem.Text = "&Manual";
            this.ColorBalanceManualMenuItem.Click += new System.EventHandler(this.ColorBalanceManualMenuItem_Click);
            // 
            // ContrastMenuItem
            // 
            this.ContrastMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContrastAutoMenuItem,
            this.ContrastManualMenuItem});
            this.ContrastMenuItem.Name = "ContrastMenuItem";
            this.ContrastMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ContrastMenuItem.Text = "Con&trast";
            // 
            // ContrastAutoMenuItem
            // 
            this.ContrastAutoMenuItem.Name = "ContrastAutoMenuItem";
            this.ContrastAutoMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ContrastAutoMenuItem.Text = "&Auto";
            this.ContrastAutoMenuItem.Click += new System.EventHandler(this.ContrastAutoMenuItem_Click);
            // 
            // ContrastManualMenuItem
            // 
            this.ContrastManualMenuItem.Name = "ContrastManualMenuItem";
            this.ContrastManualMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ContrastManualMenuItem.Text = "&Manual";
            this.ContrastManualMenuItem.Click += new System.EventHandler(this.ContrastManualMenuItem_Click);
            // 
            // BrightnessGammaMenuItem
            // 
            this.BrightnessGammaMenuItem.Name = "BrightnessGammaMenuItem";
            this.BrightnessGammaMenuItem.Size = new System.Drawing.Size(147, 22);
            this.BrightnessGammaMenuItem.Text = "&Gamma";
            this.BrightnessGammaMenuItem.Click += new System.EventHandler(this.BrightnessGammaMenuItem_Click);
            // 
            // ContrastEqualizeMenuItem
            // 
            this.ContrastEqualizeMenuItem.Name = "ContrastEqualizeMenuItem";
            this.ContrastEqualizeMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ContrastEqualizeMenuItem.Text = "E&qualize";
            this.ContrastEqualizeMenuItem.Click += new System.EventHandler(this.ContrastEqualizeMenuItem_Click);
            // 
            // LightnessMenuItem
            // 
            this.LightnessMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LightnessAutoMenuItem,
            this.LightnessManualMenuItem});
            this.LightnessMenuItem.Name = "LightnessMenuItem";
            this.LightnessMenuItem.Size = new System.Drawing.Size(147, 22);
            this.LightnessMenuItem.Text = "L&ightness";
            // 
            // LightnessAutoMenuItem
            // 
            this.LightnessAutoMenuItem.Name = "LightnessAutoMenuItem";
            this.LightnessAutoMenuItem.Size = new System.Drawing.Size(114, 22);
            this.LightnessAutoMenuItem.Text = "&Auto";
            this.LightnessAutoMenuItem.Click += new System.EventHandler(this.ContrastLightnessAutoMenuItem_Click);
            // 
            // LightnessManualMenuItem
            // 
            this.LightnessManualMenuItem.Name = "LightnessManualMenuItem";
            this.LightnessManualMenuItem.Size = new System.Drawing.Size(114, 22);
            this.LightnessManualMenuItem.Text = "&Manual";
            this.LightnessManualMenuItem.Click += new System.EventHandler(this.ContrastLightnessManualMenuItem_Click);
            // 
            // RemoveDefectMenuItem
            // 
            this.RemoveDefectMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveDustMenuItem,
            this.RemoveScratchesMenuItem,
            this.RedEyeMenuItem});
            this.RemoveDefectMenuItem.Name = "RemoveDefectMenuItem";
            this.RemoveDefectMenuItem.Size = new System.Drawing.Size(162, 22);
            this.RemoveDefectMenuItem.Text = "Remove &Defect";
            // 
            // RemoveDustMenuItem
            // 
            this.RemoveDustMenuItem.Name = "RemoveDustMenuItem";
            this.RemoveDustMenuItem.Size = new System.Drawing.Size(124, 22);
            this.RemoveDustMenuItem.Text = "D&ust";
            this.RemoveDustMenuItem.Click += new System.EventHandler(this.RemoveDustMenuItem_Click);
            // 
            // RemoveScratchesMenuItem
            // 
            this.RemoveScratchesMenuItem.Name = "RemoveScratchesMenuItem";
            this.RemoveScratchesMenuItem.Size = new System.Drawing.Size(124, 22);
            this.RemoveScratchesMenuItem.Text = "&Scratches";
            this.RemoveScratchesMenuItem.Click += new System.EventHandler(this.RemoveScratchesMenuItem_Click);
            // 
            // RedEyeMenuItem
            // 
            this.RedEyeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RedEyeRemovalAutoMenuItem,
            this.RedEyeRemovalManualMenuItem});
            this.RedEyeMenuItem.Name = "RedEyeMenuItem";
            this.RedEyeMenuItem.Size = new System.Drawing.Size(124, 22);
            this.RedEyeMenuItem.Text = "Red &Eye";
            // 
            // RedEyeRemovalAutoMenuItem
            // 
            this.RedEyeRemovalAutoMenuItem.Name = "RedEyeRemovalAutoMenuItem";
            this.RedEyeRemovalAutoMenuItem.Size = new System.Drawing.Size(114, 22);
            this.RedEyeRemovalAutoMenuItem.Text = "&Auto";
            this.RedEyeRemovalAutoMenuItem.Click += new System.EventHandler(this.RedEyeRemovalAutoMenuItem_Click);
            // 
            // RedEyeRemovalManualMenuItem
            // 
            this.RedEyeRemovalManualMenuItem.Name = "RedEyeRemovalManualMenuItem";
            this.RedEyeRemovalManualMenuItem.Size = new System.Drawing.Size(114, 22);
            this.RedEyeRemovalManualMenuItem.Text = "&Manual";
            this.RedEyeRemovalManualMenuItem.Click += new System.EventHandler(this.RedEyeRemovalManualMenuItem_Click);
            // 
            // SharpenMenuItem
            // 
            this.SharpenMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SharpenSubMenuItem,
            this.SoftenMenuItem,
            this.UnsharpenMenuItem});
            this.SharpenMenuItem.Name = "SharpenMenuItem";
            this.SharpenMenuItem.Size = new System.Drawing.Size(162, 22);
            this.SharpenMenuItem.Text = "S&harpen";
            // 
            // SharpenSubMenuItem
            // 
            this.SharpenSubMenuItem.Name = "SharpenSubMenuItem";
            this.SharpenSubMenuItem.Size = new System.Drawing.Size(131, 22);
            this.SharpenSubMenuItem.Text = "S&harpen";
            this.SharpenSubMenuItem.Click += new System.EventHandler(this.SharpenSubMenuItem_Click);
            // 
            // SoftenMenuItem
            // 
            this.SoftenMenuItem.Name = "SoftenMenuItem";
            this.SoftenMenuItem.Size = new System.Drawing.Size(131, 22);
            this.SoftenMenuItem.Text = "S&often";
            this.SoftenMenuItem.Click += new System.EventHandler(this.SoftenMenuItem_Click);
            // 
            // UnsharpenMenuItem
            // 
            this.UnsharpenMenuItem.Name = "UnsharpenMenuItem";
            this.UnsharpenMenuItem.Size = new System.Drawing.Size(131, 22);
            this.UnsharpenMenuItem.Text = "&Unsharpen";
            this.UnsharpenMenuItem.Click += new System.EventHandler(this.UnsharpenMenuItem_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnlineHelpMenuItem,
            this.ImagXpressMenuItem,
            this.IsisXpressMenuItem,
            this.NotateXpressMenuItem,
            this.PrintProMenuItem,
            this.ThumbnailXpressMenuItem,
            this.TwainProMenuItem});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(52, 20);
            this.HelpMenu.Text = "&About";
            // 
            // OnlineHelpMenuItem
            // 
            this.OnlineHelpMenuItem.Name = "OnlineHelpMenuItem";
            this.OnlineHelpMenuItem.Size = new System.Drawing.Size(221, 22);
            this.OnlineHelpMenuItem.Text = "&Online Developer\'s Manuals";
            this.OnlineHelpMenuItem.Click += new System.EventHandler(this.OnlineHelpMenuItem_Click);
            // 
            // ImagXpressMenuItem
            // 
            this.ImagXpressMenuItem.Name = "ImagXpressMenuItem";
            this.ImagXpressMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ImagXpressMenuItem.Text = "Ima&gXpress";
            this.ImagXpressMenuItem.Click += new System.EventHandler(this.ImagXpressMenuItem_Click);
            // 
            // IsisXpressMenuItem
            // 
            this.IsisXpressMenuItem.Name = "IsisXpressMenuItem";
            this.IsisXpressMenuItem.Size = new System.Drawing.Size(221, 22);
            this.IsisXpressMenuItem.Text = "ISI&S Xpress";
            this.IsisXpressMenuItem.Click += new System.EventHandler(this.IsisXpressMenuItem_Click);
            // 
            // NotateXpressMenuItem
            // 
            this.NotateXpressMenuItem.Name = "NotateXpressMenuItem";
            this.NotateXpressMenuItem.Size = new System.Drawing.Size(221, 22);
            this.NotateXpressMenuItem.Text = "&NotateXpress";
            this.NotateXpressMenuItem.Click += new System.EventHandler(this.NotateXpressMenuItem_Click);
            // 
            // PrintProMenuItem
            // 
            this.PrintProMenuItem.Name = "PrintProMenuItem";
            this.PrintProMenuItem.Size = new System.Drawing.Size(221, 22);
            this.PrintProMenuItem.Text = "&PrintPRO";
            this.PrintProMenuItem.Click += new System.EventHandler(this.PrintProMenuItem_Click);
            // 
            // ThumbnailXpressMenuItem
            // 
            this.ThumbnailXpressMenuItem.Name = "ThumbnailXpressMenuItem";
            this.ThumbnailXpressMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ThumbnailXpressMenuItem.Text = "T&humbnailXpress";
            this.ThumbnailXpressMenuItem.Click += new System.EventHandler(this.ThumbnailXpressMenuItem_Click);
            // 
            // TwainProMenuItem
            // 
            this.TwainProMenuItem.Name = "TwainProMenuItem";
            this.TwainProMenuItem.Size = new System.Drawing.Size(221, 22);
            this.TwainProMenuItem.Text = "T&wainPRO";
            this.TwainProMenuItem.Click += new System.EventHandler(this.TwainProMenuItem_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 584);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(868, 22);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenButton,
            this.SaveAsButton,
            this.ScanButton,
            this.PrintButton,
            this.FileImagXpressSeparator,
            this.PointerButton,
            this.ZoomInButton,
            this.ZoomOutButton,
            this.MagnifyButton,
            this.ZoomRectangleButton,
            this.SelectionButton,
            this.PanButton,
            this.ImagXpressAnnotationSeparator,
            this.ButtonToolButton,
            this.EllipseToolButton,
            this.FreehandToolButton,
            this.HighlightToolButton,
            this.ImageToolButton,
            this.LineToolButton,
            this.PolygonToolButton,
            this.PolylineToolButton,
            this.ProtractorToolButton,
            this.RectangleToolButton,
            this.RulerToolButton,
            this.StampToolButton,
            this.TextToolButton,
            this.NoteToolButton,
            this.AnnotationsPageSeparator,
            this.PageLabel,
            this.PageTextBox,
            this.PageCountLabel,
            this.PreviousPageButton,
            this.NextPageButton});
            this.ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(868, 25);
            this.ToolBar.TabIndex = 1;
            this.ToolBar.Text = "toolStrip1";
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.SystemColors.Control;
            this.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenImageButtonMenuItem,
            this.OpenImageWithOptionsButtonMenuItem,
            this.OpenCameraRawButtonMenuItem});
            this.OpenButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenButton.Image")));
            this.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(32, 22);
            this.OpenButton.Text = "Open";
            this.OpenButton.ButtonClick += new System.EventHandler(this.OpenButton_ButtonClick);
            // 
            // OpenImageButtonMenuItem
            // 
            this.OpenImageButtonMenuItem.Name = "OpenImageButtonMenuItem";
            this.OpenImageButtonMenuItem.Size = new System.Drawing.Size(178, 22);
            this.OpenImageButtonMenuItem.Text = "Image";
            this.OpenImageButtonMenuItem.Click += new System.EventHandler(this.ImageButtonMenuItem_Click);
            // 
            // OpenImageWithOptionsButtonMenuItem
            // 
            this.OpenImageWithOptionsButtonMenuItem.Name = "OpenImageWithOptionsButtonMenuItem";
            this.OpenImageWithOptionsButtonMenuItem.Size = new System.Drawing.Size(178, 22);
            this.OpenImageWithOptionsButtonMenuItem.Text = "Image with Options";
            this.OpenImageWithOptionsButtonMenuItem.Click += new System.EventHandler(this.ImageWithOptionsButtonMenuItem_Click);
            // 
            // OpenCameraRawButtonMenuItem
            // 
            this.OpenCameraRawButtonMenuItem.Name = "OpenCameraRawButtonMenuItem";
            this.OpenCameraRawButtonMenuItem.Size = new System.Drawing.Size(178, 22);
            this.OpenCameraRawButtonMenuItem.Text = "Camera Raw";
            this.OpenCameraRawButtonMenuItem.Click += new System.EventHandler(this.CameraRawButtonMenuItem_Click);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAsImageButtonMenuItem,
            this.SaveAsImageWithOptionsButtonMenuItem});
            this.SaveAsButton.Enabled = false;
            this.SaveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsButton.Image")));
            this.SaveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(32, 22);
            this.SaveAsButton.Text = "Save";
            this.SaveAsButton.ButtonClick += new System.EventHandler(this.SaveAsButton_ButtonClick);
            // 
            // SaveAsImageButtonMenuItem
            // 
            this.SaveAsImageButtonMenuItem.Name = "SaveAsImageButtonMenuItem";
            this.SaveAsImageButtonMenuItem.Size = new System.Drawing.Size(178, 22);
            this.SaveAsImageButtonMenuItem.Text = "Image";
            this.SaveAsImageButtonMenuItem.Click += new System.EventHandler(this.SaveAsImageButtonMenuItem_Click);
            // 
            // SaveAsImageWithOptionsButtonMenuItem
            // 
            this.SaveAsImageWithOptionsButtonMenuItem.Name = "SaveAsImageWithOptionsButtonMenuItem";
            this.SaveAsImageWithOptionsButtonMenuItem.Size = new System.Drawing.Size(178, 22);
            this.SaveAsImageWithOptionsButtonMenuItem.Text = "Image with Options";
            this.SaveAsImageWithOptionsButtonMenuItem.Click += new System.EventHandler(this.SaveAsImageWithOptionsButtonMenuItem_Click);
            // 
            // ScanButton
            // 
            this.ScanButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ScanButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TwainButtonMenuItem,
            this.IsisButtonMenuItem});
            this.ScanButton.Image = ((System.Drawing.Image)(resources.GetObject("ScanButton.Image")));
            this.ScanButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(29, 22);
            this.ScanButton.Text = "Scan";
            // 
            // TwainButtonMenuItem
            // 
            this.TwainButtonMenuItem.Name = "TwainButtonMenuItem";
            this.TwainButtonMenuItem.Size = new System.Drawing.Size(112, 22);
            this.TwainButtonMenuItem.Text = "TWAIN";
            this.TwainButtonMenuItem.Click += new System.EventHandler(this.TwainButtonMenuItem_Click);
            // 
            // IsisButtonMenuItem
            // 
            this.IsisButtonMenuItem.Name = "IsisButtonMenuItem";
            this.IsisButtonMenuItem.Size = new System.Drawing.Size(112, 22);
            this.IsisButtonMenuItem.Text = "ISIS";
            this.IsisButtonMenuItem.Click += new System.EventHandler(this.IsisButtonMenuItem_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintButton.Enabled = false;
            this.PrintButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintButton.Image")));
            this.PrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(23, 22);
            this.PrintButton.Text = "Print";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // FileImagXpressSeparator
            // 
            this.FileImagXpressSeparator.Name = "FileImagXpressSeparator";
            this.FileImagXpressSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // PointerButton
            // 
            this.PointerButton.Checked = true;
            this.PointerButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PointerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PointerButton.Enabled = false;
            this.PointerButton.Image = ((System.Drawing.Image)(resources.GetObject("PointerButton.Image")));
            this.PointerButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.PointerButton.Name = "PointerButton";
            this.PointerButton.Size = new System.Drawing.Size(23, 22);
            this.PointerButton.Text = "Pointer";
            this.PointerButton.Click += new System.EventHandler(this.PointerButton_Click);
            // 
            // ZoomInButton
            // 
            this.ZoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomInButton.Enabled = false;
            this.ZoomInButton.Image = ((System.Drawing.Image)(resources.GetObject("ZoomInButton.Image")));
            this.ZoomInButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.ZoomInButton.Name = "ZoomInButton";
            this.ZoomInButton.Size = new System.Drawing.Size(23, 22);
            this.ZoomInButton.Text = "Zoom In";
            this.ZoomInButton.Click += new System.EventHandler(this.ZoomInButton_Click);
            // 
            // ZoomOutButton
            // 
            this.ZoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomOutButton.Enabled = false;
            this.ZoomOutButton.Image = ((System.Drawing.Image)(resources.GetObject("ZoomOutButton.Image")));
            this.ZoomOutButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.ZoomOutButton.Name = "ZoomOutButton";
            this.ZoomOutButton.Size = new System.Drawing.Size(23, 22);
            this.ZoomOutButton.Text = "Zoom Out";
            this.ZoomOutButton.Click += new System.EventHandler(this.ZoomOutButton_Click);
            // 
            // MagnifyButton
            // 
            this.MagnifyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MagnifyButton.Enabled = false;
            this.MagnifyButton.Image = ((System.Drawing.Image)(resources.GetObject("MagnifyButton.Image")));
            this.MagnifyButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.MagnifyButton.Name = "MagnifyButton";
            this.MagnifyButton.Size = new System.Drawing.Size(23, 22);
            this.MagnifyButton.Text = "Magnify";
            this.MagnifyButton.Click += new System.EventHandler(this.MagnifyButton_Click);
            // 
            // ZoomRectangleButton
            // 
            this.ZoomRectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomRectangleButton.Enabled = false;
            this.ZoomRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("ZoomRectangleButton.Image")));
            this.ZoomRectangleButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.ZoomRectangleButton.Name = "ZoomRectangleButton";
            this.ZoomRectangleButton.Size = new System.Drawing.Size(23, 22);
            this.ZoomRectangleButton.Text = "Zoom Rectangle";
            this.ZoomRectangleButton.Click += new System.EventHandler(this.ZoomRectangleButton_Click);
            // 
            // SelectionButton
            // 
            this.SelectionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SelectionButton.Enabled = false;
            this.SelectionButton.Image = ((System.Drawing.Image)(resources.GetObject("SelectionButton.Image")));
            this.SelectionButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.SelectionButton.Name = "SelectionButton";
            this.SelectionButton.Size = new System.Drawing.Size(23, 22);
            this.SelectionButton.Text = "Selection";
            this.SelectionButton.Click += new System.EventHandler(this.SelectionButton_Click);
            // 
            // PanButton
            // 
            this.PanButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PanButton.Enabled = false;
            this.PanButton.Image = ((System.Drawing.Image)(resources.GetObject("PanButton.Image")));
            this.PanButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.PanButton.Name = "PanButton";
            this.PanButton.Size = new System.Drawing.Size(23, 22);
            this.PanButton.Text = "Pan";
            this.PanButton.Click += new System.EventHandler(this.PanButton_Click);
            // 
            // ImagXpressAnnotationSeparator
            // 
            this.ImagXpressAnnotationSeparator.Name = "ImagXpressAnnotationSeparator";
            this.ImagXpressAnnotationSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ButtonToolButton
            // 
            this.ButtonToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonToolButton.Enabled = false;
            this.ButtonToolButton.Image = ((System.Drawing.Image)(resources.GetObject("ButtonToolButton.Image")));
            this.ButtonToolButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.ButtonToolButton.Name = "ButtonToolButton";
            this.ButtonToolButton.Size = new System.Drawing.Size(23, 22);
            this.ButtonToolButton.Text = "Button";
            this.ButtonToolButton.Click += new System.EventHandler(this.ButtonToolButton_Click);
            // 
            // EllipseToolButton
            // 
            this.EllipseToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EllipseToolButton.Enabled = false;
            this.EllipseToolButton.Image = ((System.Drawing.Image)(resources.GetObject("EllipseToolButton.Image")));
            this.EllipseToolButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.EllipseToolButton.Name = "EllipseToolButton";
            this.EllipseToolButton.Size = new System.Drawing.Size(23, 22);
            this.EllipseToolButton.Text = "Ellipse";
            this.EllipseToolButton.Click += new System.EventHandler(this.EllipseButton_Click);
            // 
            // FreehandToolButton
            // 
            this.FreehandToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FreehandToolButton.Enabled = false;
            this.FreehandToolButton.Image = ((System.Drawing.Image)(resources.GetObject("FreehandToolButton.Image")));
            this.FreehandToolButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.FreehandToolButton.Name = "FreehandToolButton";
            this.FreehandToolButton.Size = new System.Drawing.Size(23, 22);
            this.FreehandToolButton.Text = "Freehand";
            this.FreehandToolButton.Click += new System.EventHandler(this.FreehandButton_Click);
            // 
            // HighlightToolButton
            // 
            this.HighlightToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HighlightToolButton.Enabled = false;
            this.HighlightToolButton.Image = ((System.Drawing.Image)(resources.GetObject("HighlightToolButton.Image")));
            this.HighlightToolButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.HighlightToolButton.Name = "HighlightToolButton";
            this.HighlightToolButton.Size = new System.Drawing.Size(23, 22);
            this.HighlightToolButton.Text = "Highlight";
            this.HighlightToolButton.Click += new System.EventHandler(this.HighlightButton_Click);
            // 
            // ImageToolButton
            // 
            this.ImageToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ImageToolButton.Enabled = false;
            this.ImageToolButton.Image = ((System.Drawing.Image)(resources.GetObject("ImageToolButton.Image")));
            this.ImageToolButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.ImageToolButton.Name = "ImageToolButton";
            this.ImageToolButton.Size = new System.Drawing.Size(23, 22);
            this.ImageToolButton.Text = "Image";
            this.ImageToolButton.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // LineToolButton
            // 
            this.LineToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineToolButton.Enabled = false;
            this.LineToolButton.Image = ((System.Drawing.Image)(resources.GetObject("LineToolButton.Image")));
            this.LineToolButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.LineToolButton.Name = "LineToolButton";
            this.LineToolButton.Size = new System.Drawing.Size(23, 22);
            this.LineToolButton.Text = "Line";
            this.LineToolButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // PolygonToolButton
            // 
            this.PolygonToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PolygonToolButton.Enabled = false;
            this.PolygonToolButton.Image = ((System.Drawing.Image)(resources.GetObject("PolygonToolButton.Image")));
            this.PolygonToolButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.PolygonToolButton.Name = "PolygonToolButton";
            this.PolygonToolButton.Size = new System.Drawing.Size(23, 22);
            this.PolygonToolButton.Text = "Polygon";
            this.PolygonToolButton.Click += new System.EventHandler(this.PolygonButton_Click);
            // 
            // PolylineToolButton
            // 
            this.PolylineToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PolylineToolButton.Enabled = false;
            this.PolylineToolButton.Image = ((System.Drawing.Image)(resources.GetObject("PolylineToolButton.Image")));
            this.PolylineToolButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.PolylineToolButton.Name = "PolylineToolButton";
            this.PolylineToolButton.Size = new System.Drawing.Size(23, 22);
            this.PolylineToolButton.Text = "Polyline";
            this.PolylineToolButton.Click += new System.EventHandler(this.PolylineButton_Click);
            // 
            // ProtractorToolButton
            // 
            this.ProtractorToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ProtractorToolButton.Enabled = false;
            this.ProtractorToolButton.Image = ((System.Drawing.Image)(resources.GetObject("ProtractorToolButton.Image")));
            this.ProtractorToolButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.ProtractorToolButton.Name = "ProtractorToolButton";
            this.ProtractorToolButton.Size = new System.Drawing.Size(23, 22);
            this.ProtractorToolButton.Text = "Protractor";
            this.ProtractorToolButton.Click += new System.EventHandler(this.ProtractorButton_Click);
            // 
            // RectangleToolButton
            // 
            this.RectangleToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleToolButton.Enabled = false;
            this.RectangleToolButton.Image = ((System.Drawing.Image)(resources.GetObject("RectangleToolButton.Image")));
            this.RectangleToolButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.RectangleToolButton.Name = "RectangleToolButton";
            this.RectangleToolButton.Size = new System.Drawing.Size(23, 22);
            this.RectangleToolButton.Text = "Rectangle";
            this.RectangleToolButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // RulerToolButton
            // 
            this.RulerToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RulerToolButton.Enabled = false;
            this.RulerToolButton.Image = ((System.Drawing.Image)(resources.GetObject("RulerToolButton.Image")));
            this.RulerToolButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.RulerToolButton.Name = "RulerToolButton";
            this.RulerToolButton.Size = new System.Drawing.Size(23, 22);
            this.RulerToolButton.Text = "Ruler";
            this.RulerToolButton.Click += new System.EventHandler(this.RulerButton_Click);
            // 
            // StampToolButton
            // 
            this.StampToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StampToolButton.Enabled = false;
            this.StampToolButton.Image = ((System.Drawing.Image)(resources.GetObject("StampToolButton.Image")));
            this.StampToolButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.StampToolButton.Name = "StampToolButton";
            this.StampToolButton.Size = new System.Drawing.Size(23, 22);
            this.StampToolButton.Text = "Stamp";
            this.StampToolButton.Click += new System.EventHandler(this.StampButton_Click);
            // 
            // TextToolButton
            // 
            this.TextToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TextToolButton.Enabled = false;
            this.TextToolButton.Image = ((System.Drawing.Image)(resources.GetObject("TextToolButton.Image")));
            this.TextToolButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.TextToolButton.Name = "TextToolButton";
            this.TextToolButton.Size = new System.Drawing.Size(23, 22);
            this.TextToolButton.Text = "Text";
            this.TextToolButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // NoteToolButton
            // 
            this.NoteToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NoteToolButton.Enabled = false;
            this.NoteToolButton.Image = ((System.Drawing.Image)(resources.GetObject("NoteToolButton.Image")));
            this.NoteToolButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.NoteToolButton.Name = "NoteToolButton";
            this.NoteToolButton.Size = new System.Drawing.Size(23, 22);
            this.NoteToolButton.Text = "Note";
            this.NoteToolButton.Click += new System.EventHandler(this.NoteToolButton_Click);
            // 
            // AnnotationsPageSeparator
            // 
            this.AnnotationsPageSeparator.Name = "AnnotationsPageSeparator";
            this.AnnotationsPageSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // PageLabel
            // 
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(33, 22);
            this.PageLabel.Text = "Page";
            // 
            // PageTextBox
            // 
            this.PageTextBox.Enabled = false;
            this.PageTextBox.Name = "PageTextBox";
            this.PageTextBox.Size = new System.Drawing.Size(30, 25);
            this.PageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PageTextBox_KeyPress);
            // 
            // PageCountLabel
            // 
            this.PageCountLabel.Name = "PageCountLabel";
            this.PageCountLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // PreviousPageButton
            // 
            this.PreviousPageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PreviousPageButton.Enabled = false;
            this.PreviousPageButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousPageButton.Image")));
            this.PreviousPageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousPageButton.Name = "PreviousPageButton";
            this.PreviousPageButton.Size = new System.Drawing.Size(23, 22);
            this.PreviousPageButton.Text = "Previous Page";
            this.PreviousPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // NextPageButton
            // 
            this.NextPageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextPageButton.Enabled = false;
            this.NextPageButton.Image = ((System.Drawing.Image)(resources.GetObject("NextPageButton.Image")));
            this.NextPageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(23, 22);
            this.NextPageButton.Text = "Next Page";
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // imageXView1
            // 
            this.imageXView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageXView1.Location = new System.Drawing.Point(0, 0);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(566, 533);
            this.imageXView1.TabIndex = 0;
            this.imageXView1.ZoomFactorChanged += new Accusoft.ImagXpressSdk.ImageXView.ZoomFactorChangedEventHandler(this.imageXView1_ZoomFactorChanged);
            this.imageXView1.ToolEvent += new Accusoft.ImagXpressSdk.ImageXView.ToolEventHandler(this.imageXView1_ToolEvent);
            this.imageXView1.MouseLeave += new System.EventHandler(this.imageXView1_MouseLeave);
            this.imageXView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageXView1_MouseMove);
            // 
            // thumbnailXpress1
            // 
            this.thumbnailXpress1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thumbnailXpress1.BottomMargin = 5;
            this.thumbnailXpress1.CameraRaw = false;
            this.thumbnailXpress1.CellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.thumbnailXpress1.CellBorderWidth = 1;
            this.thumbnailXpress1.CellHeight = 130;
            this.thumbnailXpress1.CellHorizontalSpacing = 5;
            this.thumbnailXpress1.CellSpacingColor = System.Drawing.Color.White;
            this.thumbnailXpress1.CellVerticalSpacing = 5;
            this.thumbnailXpress1.CellWidth = 130;
            this.thumbnailXpress1.DblClickDirectoryDrillDown = false;
            this.thumbnailXpress1.DescriptorAlignment = ((Accusoft.ThumbnailXpressSdk.DescriptorAlignments)((Accusoft.ThumbnailXpressSdk.DescriptorAlignments.AlignCenter | Accusoft.ThumbnailXpressSdk.DescriptorAlignments.AlignBottom)));
            this.thumbnailXpress1.DescriptorDisplayMethod = Accusoft.ThumbnailXpressSdk.DescriptorDisplayMethods.Default;
            this.thumbnailXpress1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thumbnailXpress1.EnableAsDragSourceForExternalDragDrop = false;
            this.thumbnailXpress1.EnableAsDropTargetForExternalDragDrop = false;
            this.thumbnailXpress1.ErrorAction = Accusoft.ThumbnailXpressSdk.ErrorAction.UseErrorIcon;
            this.thumbnailXpress1.FtpPassword = "";
            this.thumbnailXpress1.FtpUserName = "";
            this.thumbnailXpress1.InterComponentThumbnailDragDropEnabled = false;
            this.thumbnailXpress1.IntraComponentThumbnailDragDropEnabled = false;
            this.thumbnailXpress1.LeftMargin = 5;
            this.thumbnailXpress1.Location = new System.Drawing.Point(0, 0);
            this.thumbnailXpress1.MaximumThumbnailBitDepth = 24;
            this.thumbnailXpress1.Name = "thumbnailXpress1";
            // TODO: Code generation for 'this.thumbnailXpress1.NotateXpressInstance' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.thumbnailXpress1.PreserveBlack = false;
            this.thumbnailXpress1.ProxyServer = "";
            this.thumbnailXpress1.RightMargin = 5;
            this.thumbnailXpress1.ScrollDirection = Accusoft.ThumbnailXpressSdk.ScrollDirection.Vertical;
            this.thumbnailXpress1.SelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.thumbnailXpress1.SelectionMode = Accusoft.ThumbnailXpressSdk.SelectionMode.Single;
            this.thumbnailXpress1.ShowHourglass = true;
            this.thumbnailXpress1.ShowImagePlaceholders = false;
            this.thumbnailXpress1.Size = new System.Drawing.Size(294, 246);
            this.thumbnailXpress1.TabIndex = 0;
            this.thumbnailXpress1.TextBackColor = System.Drawing.Color.White;
            this.thumbnailXpress1.TopMargin = 5;
            this.thumbnailXpress1.UseCameraRawThumbnail = false;
            this.thumbnailXpress1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.thumbnailXpress1_MouseClick);
            // 
            // ThumbnailImageSplitContainer
            // 
            this.ThumbnailImageSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThumbnailImageSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThumbnailImageSplitContainer.Location = new System.Drawing.Point(0, 49);
            this.ThumbnailImageSplitContainer.Name = "ThumbnailImageSplitContainer";
            // 
            // ThumbnailImageSplitContainer.Panel1
            // 
            this.ThumbnailImageSplitContainer.Panel1.Controls.Add(this.ThumbnailSettingsSplitContainer);
            // 
            // ThumbnailImageSplitContainer.Panel2
            // 
            this.ThumbnailImageSplitContainer.Panel2.Controls.Add(this.imageXView1);
            this.ThumbnailImageSplitContainer.Size = new System.Drawing.Size(868, 535);
            this.ThumbnailImageSplitContainer.SplitterDistance = 296;
            this.ThumbnailImageSplitContainer.TabIndex = 5;
            this.ThumbnailImageSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.ThumbnailImageSplitContainer_SplitterMoved);
            // 
            // ThumbnailSettingsSplitContainer
            // 
            this.ThumbnailSettingsSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThumbnailSettingsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThumbnailSettingsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ThumbnailSettingsSplitContainer.Name = "ThumbnailSettingsSplitContainer";
            this.ThumbnailSettingsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ThumbnailSettingsSplitContainer.Panel1
            // 
            this.ThumbnailSettingsSplitContainer.Panel1.Controls.Add(this.thumbnailXpress1);
            this.ThumbnailSettingsSplitContainer.Panel1.Controls.Add(this.ClearThumbnailsPanel);
            // 
            // ThumbnailSettingsSplitContainer.Panel2
            // 
            this.ThumbnailSettingsSplitContainer.Panel2.Controls.Add(this.ViewTabControl);
            this.ThumbnailSettingsSplitContainer.Panel2.Controls.Add(this.ShowHideSettingsPanel);
            this.ThumbnailSettingsSplitContainer.Size = new System.Drawing.Size(296, 535);
            this.ThumbnailSettingsSplitContainer.SplitterDistance = 279;
            this.ThumbnailSettingsSplitContainer.TabIndex = 5;
            this.ThumbnailSettingsSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.ThumbnailSettingsSplitContainer_SplitterMoved);
            // 
            // ClearThumbnailsPanel
            // 
            this.ClearThumbnailsPanel.Controls.Add(this.ClearImagesButton);
            this.ClearThumbnailsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ClearThumbnailsPanel.Location = new System.Drawing.Point(0, 246);
            this.ClearThumbnailsPanel.Name = "ClearThumbnailsPanel";
            this.ClearThumbnailsPanel.Size = new System.Drawing.Size(294, 31);
            this.ClearThumbnailsPanel.TabIndex = 1;
            // 
            // ClearImagesButton
            // 
            this.ClearImagesButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ClearImagesButton.Location = new System.Drawing.Point(92, 5);
            this.ClearImagesButton.Name = "ClearImagesButton";
            this.ClearImagesButton.Size = new System.Drawing.Size(107, 23);
            this.ClearImagesButton.TabIndex = 0;
            this.ClearImagesButton.Text = "Clear Images";
            this.ClearImagesButton.UseVisualStyleBackColor = true;
            this.ClearImagesButton.Click += new System.EventHandler(this.ClearImagesButton_Click);
            // 
            // ViewTabControl
            // 
            this.ViewTabControl.Controls.Add(this.ViewSettingsTabPage);
            this.ViewTabControl.Controls.Add(this.ColorManagementTabPage);
            this.ViewTabControl.Controls.Add(this.ThumbnailTabPage);
            this.ViewTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewTabControl.Location = new System.Drawing.Point(0, 0);
            this.ViewTabControl.Name = "ViewTabControl";
            this.ViewTabControl.SelectedIndex = 0;
            this.ViewTabControl.Size = new System.Drawing.Size(294, 212);
            this.ViewTabControl.TabIndex = 0;
            // 
            // ViewSettingsTabPage
            // 
            this.ViewSettingsTabPage.AutoScroll = true;
            this.ViewSettingsTabPage.Controls.Add(this.ViewDefaultButton);
            this.ViewSettingsTabPage.Controls.Add(this.ZoomFactorLabel);
            this.ViewSettingsTabPage.Controls.Add(this.ZoomFactorNumericUpDown);
            this.ViewSettingsTabPage.Controls.Add(this.SmoothingCheckBox);
            this.ViewSettingsTabPage.Controls.Add(this.DitheredCheckBox);
            this.ViewSettingsTabPage.Controls.Add(this.AspectYNumericUpDown);
            this.ViewSettingsTabPage.Controls.Add(this.AspectXNumericUpDown);
            this.ViewSettingsTabPage.Controls.Add(this.AspectYLabel);
            this.ViewSettingsTabPage.Controls.Add(this.AspectXLabel);
            this.ViewSettingsTabPage.Controls.Add(this.ContrastNumericUpDown);
            this.ViewSettingsTabPage.Controls.Add(this.ContrastLabel);
            this.ViewSettingsTabPage.Controls.Add(this.BrightnessLabel);
            this.ViewSettingsTabPage.Controls.Add(this.BrightnessNumericUpDown);
            this.ViewSettingsTabPage.Controls.Add(this.AlphaBlendCheckBox);
            this.ViewSettingsTabPage.Controls.Add(this.ProgressiveCheckBox);
            this.ViewSettingsTabPage.Controls.Add(this.PreserveBlackCheckBox);
            this.ViewSettingsTabPage.Controls.Add(this.AntiAliasCheckBox);
            this.ViewSettingsTabPage.Controls.Add(this.StyleGroupBox);
            this.ViewSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ViewSettingsTabPage.Name = "ViewSettingsTabPage";
            this.ViewSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ViewSettingsTabPage.Size = new System.Drawing.Size(286, 186);
            this.ViewSettingsTabPage.TabIndex = 0;
            this.ViewSettingsTabPage.Text = "View";
            this.ViewSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // ViewDefaultButton
            // 
            this.ViewDefaultButton.Location = new System.Drawing.Point(188, 268);
            this.ViewDefaultButton.Name = "ViewDefaultButton";
            this.ViewDefaultButton.Size = new System.Drawing.Size(75, 23);
            this.ViewDefaultButton.TabIndex = 17;
            this.ViewDefaultButton.Text = "Defaults";
            this.ViewDefaultButton.UseVisualStyleBackColor = true;
            this.ViewDefaultButton.Click += new System.EventHandler(this.ViewDefaultButton_Click);
            // 
            // ZoomFactorLabel
            // 
            this.ZoomFactorLabel.AutoSize = true;
            this.ZoomFactorLabel.Location = new System.Drawing.Point(15, 275);
            this.ZoomFactorLabel.Name = "ZoomFactorLabel";
            this.ZoomFactorLabel.Size = new System.Drawing.Size(70, 13);
            this.ZoomFactorLabel.TabIndex = 15;
            this.ZoomFactorLabel.Text = "Zoom Factor:";
            // 
            // ZoomFactorNumericUpDown
            // 
            this.ZoomFactorNumericUpDown.DecimalPlaces = 2;
            this.ZoomFactorNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ZoomFactorNumericUpDown.Location = new System.Drawing.Point(88, 271);
            this.ZoomFactorNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            524288});
            this.ZoomFactorNumericUpDown.Name = "ZoomFactorNumericUpDown";
            this.ZoomFactorNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.ZoomFactorNumericUpDown.TabIndex = 16;
            this.ZoomFactorNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ZoomFactorNumericUpDown.ValueChanged += new System.EventHandler(this.ZoomFactorNumericUpDown_ValueChanged);
            // 
            // SmoothingCheckBox
            // 
            this.SmoothingCheckBox.AutoSize = true;
            this.SmoothingCheckBox.Checked = true;
            this.SmoothingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SmoothingCheckBox.Location = new System.Drawing.Point(149, 188);
            this.SmoothingCheckBox.Name = "SmoothingCheckBox";
            this.SmoothingCheckBox.Size = new System.Drawing.Size(76, 17);
            this.SmoothingCheckBox.TabIndex = 6;
            this.SmoothingCheckBox.Text = "Smoothing";
            this.SmoothingCheckBox.UseVisualStyleBackColor = true;
            this.SmoothingCheckBox.CheckedChanged += new System.EventHandler(this.SmoothingCheckBox_CheckedChanged);
            // 
            // DitheredCheckBox
            // 
            this.DitheredCheckBox.AutoSize = true;
            this.DitheredCheckBox.Checked = true;
            this.DitheredCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DitheredCheckBox.Location = new System.Drawing.Point(16, 188);
            this.DitheredCheckBox.Name = "DitheredCheckBox";
            this.DitheredCheckBox.Size = new System.Drawing.Size(66, 17);
            this.DitheredCheckBox.TabIndex = 5;
            this.DitheredCheckBox.Text = "Dithered";
            this.DitheredCheckBox.UseVisualStyleBackColor = true;
            this.DitheredCheckBox.CheckedChanged += new System.EventHandler(this.DitheredCheckBox_CheckedChanged);
            // 
            // AspectYNumericUpDown
            // 
            this.AspectYNumericUpDown.Location = new System.Drawing.Point(207, 215);
            this.AspectYNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AspectYNumericUpDown.Name = "AspectYNumericUpDown";
            this.AspectYNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.AspectYNumericUpDown.TabIndex = 10;
            this.AspectYNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AspectYNumericUpDown.ValueChanged += new System.EventHandler(this.AspectYNumericUpDown_ValueChanged);
            // 
            // AspectXNumericUpDown
            // 
            this.AspectXNumericUpDown.Location = new System.Drawing.Point(88, 215);
            this.AspectXNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AspectXNumericUpDown.Name = "AspectXNumericUpDown";
            this.AspectXNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.AspectXNumericUpDown.TabIndex = 8;
            this.AspectXNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AspectXNumericUpDown.ValueChanged += new System.EventHandler(this.AspectXNumericUpDown_ValueChanged);
            // 
            // AspectYLabel
            // 
            this.AspectYLabel.AutoSize = true;
            this.AspectYLabel.Location = new System.Drawing.Point(148, 219);
            this.AspectYLabel.Name = "AspectYLabel";
            this.AspectYLabel.Size = new System.Drawing.Size(53, 13);
            this.AspectYLabel.TabIndex = 9;
            this.AspectYLabel.Text = "Aspect Y:";
            // 
            // AspectXLabel
            // 
            this.AspectXLabel.AutoSize = true;
            this.AspectXLabel.Location = new System.Drawing.Point(15, 219);
            this.AspectXLabel.Name = "AspectXLabel";
            this.AspectXLabel.Size = new System.Drawing.Size(53, 13);
            this.AspectXLabel.TabIndex = 7;
            this.AspectXLabel.Text = "Aspect X:";
            // 
            // ContrastNumericUpDown
            // 
            this.ContrastNumericUpDown.Location = new System.Drawing.Point(207, 243);
            this.ContrastNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ContrastNumericUpDown.Name = "ContrastNumericUpDown";
            this.ContrastNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.ContrastNumericUpDown.TabIndex = 14;
            this.ContrastNumericUpDown.ValueChanged += new System.EventHandler(this.ContrastNumericUpDown_ValueChanged);
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.Location = new System.Drawing.Point(148, 247);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(49, 13);
            this.ContrastLabel.TabIndex = 13;
            this.ContrastLabel.Text = "Contrast:";
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.Location = new System.Drawing.Point(15, 247);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(59, 13);
            this.BrightnessLabel.TabIndex = 11;
            this.BrightnessLabel.Text = "Brightness:";
            // 
            // BrightnessNumericUpDown
            // 
            this.BrightnessNumericUpDown.Location = new System.Drawing.Point(88, 243);
            this.BrightnessNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.BrightnessNumericUpDown.Name = "BrightnessNumericUpDown";
            this.BrightnessNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.BrightnessNumericUpDown.TabIndex = 12;
            this.BrightnessNumericUpDown.ValueChanged += new System.EventHandler(this.BrightnessNumericUpDown_ValueChanged);
            // 
            // AlphaBlendCheckBox
            // 
            this.AlphaBlendCheckBox.AutoSize = true;
            this.AlphaBlendCheckBox.Location = new System.Drawing.Point(16, 139);
            this.AlphaBlendCheckBox.Name = "AlphaBlendCheckBox";
            this.AlphaBlendCheckBox.Size = new System.Drawing.Size(83, 17);
            this.AlphaBlendCheckBox.TabIndex = 1;
            this.AlphaBlendCheckBox.Text = "Alpha Blend";
            this.AlphaBlendCheckBox.UseVisualStyleBackColor = true;
            this.AlphaBlendCheckBox.CheckedChanged += new System.EventHandler(this.AlphaBlendCheckBox_CheckedChanged);
            // 
            // ProgressiveCheckBox
            // 
            this.ProgressiveCheckBox.AutoSize = true;
            this.ProgressiveCheckBox.Location = new System.Drawing.Point(149, 139);
            this.ProgressiveCheckBox.Name = "ProgressiveCheckBox";
            this.ProgressiveCheckBox.Size = new System.Drawing.Size(81, 17);
            this.ProgressiveCheckBox.TabIndex = 2;
            this.ProgressiveCheckBox.Text = "Progressive";
            this.ProgressiveCheckBox.UseVisualStyleBackColor = true;
            this.ProgressiveCheckBox.CheckedChanged += new System.EventHandler(this.ProgressiveCheckBox_CheckedChanged);
            // 
            // PreserveBlackCheckBox
            // 
            this.PreserveBlackCheckBox.AutoSize = true;
            this.PreserveBlackCheckBox.Location = new System.Drawing.Point(16, 164);
            this.PreserveBlackCheckBox.Name = "PreserveBlackCheckBox";
            this.PreserveBlackCheckBox.Size = new System.Drawing.Size(98, 17);
            this.PreserveBlackCheckBox.TabIndex = 3;
            this.PreserveBlackCheckBox.Text = "Preserve Black";
            this.PreserveBlackCheckBox.UseVisualStyleBackColor = true;
            this.PreserveBlackCheckBox.CheckedChanged += new System.EventHandler(this.PreserveBlackCheckBox_CheckedChanged);
            // 
            // AntiAliasCheckBox
            // 
            this.AntiAliasCheckBox.AutoSize = true;
            this.AntiAliasCheckBox.Checked = true;
            this.AntiAliasCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AntiAliasCheckBox.Location = new System.Drawing.Point(149, 164);
            this.AntiAliasCheckBox.Name = "AntiAliasCheckBox";
            this.AntiAliasCheckBox.Size = new System.Drawing.Size(66, 17);
            this.AntiAliasCheckBox.TabIndex = 4;
            this.AntiAliasCheckBox.Text = "AntiAlias";
            this.AntiAliasCheckBox.UseVisualStyleBackColor = true;
            this.AntiAliasCheckBox.CheckedChanged += new System.EventHandler(this.AntiAliasCheckBox_CheckedChanged);
            // 
            // StyleGroupBox
            // 
            this.StyleGroupBox.Controls.Add(this.BackColorButton);
            this.StyleGroupBox.Controls.Add(this.BackColorLabel);
            this.StyleGroupBox.Controls.Add(this.HorizontalAlignmentLabel);
            this.StyleGroupBox.Controls.Add(this.VerticalAlignmentLabel);
            this.StyleGroupBox.Controls.Add(this.HorizontalAlignmentComboBox);
            this.StyleGroupBox.Controls.Add(this.VerticalAlignmentComboBox);
            this.StyleGroupBox.Controls.Add(this.AutoResizeComboBox);
            this.StyleGroupBox.Controls.Add(this.AutoResizeLabel);
            this.StyleGroupBox.Location = new System.Drawing.Point(7, 3);
            this.StyleGroupBox.Name = "StyleGroupBox";
            this.StyleGroupBox.Size = new System.Drawing.Size(250, 130);
            this.StyleGroupBox.TabIndex = 0;
            this.StyleGroupBox.TabStop = false;
            this.StyleGroupBox.Text = "Style";
            // 
            // BackColorButton
            // 
            this.BackColorButton.BackColor = System.Drawing.SystemColors.Control;
            this.BackColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackColorButton.Location = new System.Drawing.Point(125, 97);
            this.BackColorButton.Name = "BackColorButton";
            this.BackColorButton.Size = new System.Drawing.Size(22, 23);
            this.BackColorButton.TabIndex = 7;
            this.BackColorButton.UseVisualStyleBackColor = false;
            this.BackColorButton.Click += new System.EventHandler(this.BackColorButton_Click);
            // 
            // BackColorLabel
            // 
            this.BackColorLabel.AutoSize = true;
            this.BackColorLabel.Location = new System.Drawing.Point(6, 102);
            this.BackColorLabel.Name = "BackColorLabel";
            this.BackColorLabel.Size = new System.Drawing.Size(62, 13);
            this.BackColorLabel.TabIndex = 6;
            this.BackColorLabel.Text = "Back Color:";
            // 
            // HorizontalAlignmentLabel
            // 
            this.HorizontalAlignmentLabel.AutoSize = true;
            this.HorizontalAlignmentLabel.Location = new System.Drawing.Point(6, 16);
            this.HorizontalAlignmentLabel.Name = "HorizontalAlignmentLabel";
            this.HorizontalAlignmentLabel.Size = new System.Drawing.Size(106, 13);
            this.HorizontalAlignmentLabel.TabIndex = 0;
            this.HorizontalAlignmentLabel.Text = "Horizontal Alignment:";
            // 
            // VerticalAlignmentLabel
            // 
            this.VerticalAlignmentLabel.AutoSize = true;
            this.VerticalAlignmentLabel.Location = new System.Drawing.Point(6, 44);
            this.VerticalAlignmentLabel.Name = "VerticalAlignmentLabel";
            this.VerticalAlignmentLabel.Size = new System.Drawing.Size(94, 13);
            this.VerticalAlignmentLabel.TabIndex = 2;
            this.VerticalAlignmentLabel.Text = "Vertical Alignment:";
            // 
            // HorizontalAlignmentComboBox
            // 
            this.HorizontalAlignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HorizontalAlignmentComboBox.FormattingEnabled = true;
            this.HorizontalAlignmentComboBox.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.HorizontalAlignmentComboBox.Location = new System.Drawing.Point(125, 13);
            this.HorizontalAlignmentComboBox.Name = "HorizontalAlignmentComboBox";
            this.HorizontalAlignmentComboBox.Size = new System.Drawing.Size(116, 21);
            this.HorizontalAlignmentComboBox.TabIndex = 1;
            this.HorizontalAlignmentComboBox.SelectedIndexChanged += new System.EventHandler(this.HorizontalAlingmentComboBox_SelectedIndexChanged);
            // 
            // VerticalAlignmentComboBox
            // 
            this.VerticalAlignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VerticalAlignmentComboBox.FormattingEnabled = true;
            this.VerticalAlignmentComboBox.Items.AddRange(new object[] {
            "Top",
            "Center",
            "Bottom"});
            this.VerticalAlignmentComboBox.Location = new System.Drawing.Point(125, 41);
            this.VerticalAlignmentComboBox.Name = "VerticalAlignmentComboBox";
            this.VerticalAlignmentComboBox.Size = new System.Drawing.Size(116, 21);
            this.VerticalAlignmentComboBox.TabIndex = 3;
            this.VerticalAlignmentComboBox.SelectedIndexChanged += new System.EventHandler(this.VerticalAlignmentComboBox_SelectedIndexChanged);
            // 
            // AutoResizeComboBox
            // 
            this.AutoResizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AutoResizeComboBox.FormattingEnabled = true;
            this.AutoResizeComboBox.Items.AddRange(new object[] {
            "Resize Image",
            "Tile Image",
            "Best Fit",
            "Crop Image",
            "Fit Width",
            "Fit Height"});
            this.AutoResizeComboBox.Location = new System.Drawing.Point(125, 71);
            this.AutoResizeComboBox.Name = "AutoResizeComboBox";
            this.AutoResizeComboBox.Size = new System.Drawing.Size(116, 21);
            this.AutoResizeComboBox.TabIndex = 5;
            this.AutoResizeComboBox.SelectedIndexChanged += new System.EventHandler(this.AutoResizeComboBox_SelectedIndexChanged);
            // 
            // AutoResizeLabel
            // 
            this.AutoResizeLabel.AutoSize = true;
            this.AutoResizeLabel.Location = new System.Drawing.Point(6, 75);
            this.AutoResizeLabel.Name = "AutoResizeLabel";
            this.AutoResizeLabel.Size = new System.Drawing.Size(94, 13);
            this.AutoResizeLabel.TabIndex = 4;
            this.AutoResizeLabel.Text = "Auto Resize Type:";
            // 
            // ColorManagementTabPage
            // 
            this.ColorManagementTabPage.AutoScroll = true;
            this.ColorManagementTabPage.Controls.Add(this.ICMProofingCheckBox);
            this.ColorManagementTabPage.Controls.Add(this.ColorDefaultButton);
            this.ColorManagementTabPage.Controls.Add(this.PaletteGroupBox);
            this.ColorManagementTabPage.Controls.Add(this.ColorGroupBox);
            this.ColorManagementTabPage.Controls.Add(this.ProofingGroupBox);
            this.ColorManagementTabPage.Location = new System.Drawing.Point(4, 22);
            this.ColorManagementTabPage.Name = "ColorManagementTabPage";
            this.ColorManagementTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ColorManagementTabPage.Size = new System.Drawing.Size(286, 186);
            this.ColorManagementTabPage.TabIndex = 1;
            this.ColorManagementTabPage.Text = "Color Management";
            this.ColorManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // ICMProofingCheckBox
            // 
            this.ICMProofingCheckBox.AutoSize = true;
            this.ICMProofingCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ICMProofingCheckBox.Location = new System.Drawing.Point(16, 139);
            this.ICMProofingCheckBox.Name = "ICMProofingCheckBox";
            this.ICMProofingCheckBox.Size = new System.Drawing.Size(65, 17);
            this.ICMProofingCheckBox.TabIndex = 2;
            this.ICMProofingCheckBox.Text = "Proofing";
            this.ICMProofingCheckBox.UseVisualStyleBackColor = false;
            this.ICMProofingCheckBox.CheckedChanged += new System.EventHandler(this.ICMProofingCheckBox_CheckedChanged);
            // 
            // ColorDefaultButton
            // 
            this.ColorDefaultButton.Location = new System.Drawing.Point(185, 136);
            this.ColorDefaultButton.Name = "ColorDefaultButton";
            this.ColorDefaultButton.Size = new System.Drawing.Size(75, 23);
            this.ColorDefaultButton.TabIndex = 3;
            this.ColorDefaultButton.Text = "Defaults";
            this.ColorDefaultButton.UseVisualStyleBackColor = true;
            this.ColorDefaultButton.Click += new System.EventHandler(this.ColorDefaultButton_Click);
            // 
            // PaletteGroupBox
            // 
            this.PaletteGroupBox.Controls.Add(this.PaletteFileNameLabel);
            this.PaletteGroupBox.Controls.Add(this.PaletteTypeLabel);
            this.PaletteGroupBox.Controls.Add(this.PaletteTypeComboBox);
            this.PaletteGroupBox.Controls.Add(this.PaletteFileNameTextBox);
            this.PaletteGroupBox.Controls.Add(this.PaletteFileNameButton);
            this.PaletteGroupBox.Location = new System.Drawing.Point(7, 6);
            this.PaletteGroupBox.Name = "PaletteGroupBox";
            this.PaletteGroupBox.Size = new System.Drawing.Size(220, 76);
            this.PaletteGroupBox.TabIndex = 0;
            this.PaletteGroupBox.TabStop = false;
            this.PaletteGroupBox.Text = "Palette";
            // 
            // PaletteFileNameLabel
            // 
            this.PaletteFileNameLabel.AutoSize = true;
            this.PaletteFileNameLabel.Location = new System.Drawing.Point(6, 27);
            this.PaletteFileNameLabel.Name = "PaletteFileNameLabel";
            this.PaletteFileNameLabel.Size = new System.Drawing.Size(57, 13);
            this.PaletteFileNameLabel.TabIndex = 0;
            this.PaletteFileNameLabel.Text = "File Name:";
            // 
            // PaletteTypeLabel
            // 
            this.PaletteTypeLabel.AutoSize = true;
            this.PaletteTypeLabel.Location = new System.Drawing.Point(6, 50);
            this.PaletteTypeLabel.Name = "PaletteTypeLabel";
            this.PaletteTypeLabel.Size = new System.Drawing.Size(34, 13);
            this.PaletteTypeLabel.TabIndex = 3;
            this.PaletteTypeLabel.Text = "Type:";
            // 
            // PaletteTypeComboBox
            // 
            this.PaletteTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaletteTypeComboBox.FormattingEnabled = true;
            this.PaletteTypeComboBox.Items.AddRange(new object[] {
            "Optimized",
            "Fixed",
            "Gray",
            "PalFile"});
            this.PaletteTypeComboBox.Location = new System.Drawing.Point(65, 47);
            this.PaletteTypeComboBox.Name = "PaletteTypeComboBox";
            this.PaletteTypeComboBox.Size = new System.Drawing.Size(112, 21);
            this.PaletteTypeComboBox.TabIndex = 4;
            this.PaletteTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.PaletteTypeComboBox_SelectedIndexChanged);
            // 
            // PaletteFileNameTextBox
            // 
            this.PaletteFileNameTextBox.Enabled = false;
            this.PaletteFileNameTextBox.Location = new System.Drawing.Point(65, 24);
            this.PaletteFileNameTextBox.Name = "PaletteFileNameTextBox";
            this.PaletteFileNameTextBox.ReadOnly = true;
            this.PaletteFileNameTextBox.Size = new System.Drawing.Size(112, 20);
            this.PaletteFileNameTextBox.TabIndex = 1;
            // 
            // PaletteFileNameButton
            // 
            this.PaletteFileNameButton.Enabled = false;
            this.PaletteFileNameButton.Location = new System.Drawing.Point(183, 22);
            this.PaletteFileNameButton.Name = "PaletteFileNameButton";
            this.PaletteFileNameButton.Size = new System.Drawing.Size(27, 23);
            this.PaletteFileNameButton.TabIndex = 2;
            this.PaletteFileNameButton.Text = "...";
            this.PaletteFileNameButton.UseVisualStyleBackColor = true;
            this.PaletteFileNameButton.Click += new System.EventHandler(this.PaletteFileNameButton_Click);
            // 
            // ColorGroupBox
            // 
            this.ColorGroupBox.Controls.Add(this.DisplayModeLabel);
            this.ColorGroupBox.Controls.Add(this.DisplayModeComboBox);
            this.ColorGroupBox.Location = new System.Drawing.Point(7, 80);
            this.ColorGroupBox.Name = "ColorGroupBox";
            this.ColorGroupBox.Size = new System.Drawing.Size(253, 50);
            this.ColorGroupBox.TabIndex = 1;
            this.ColorGroupBox.TabStop = false;
            this.ColorGroupBox.Text = "Color";
            // 
            // DisplayModeLabel
            // 
            this.DisplayModeLabel.AutoSize = true;
            this.DisplayModeLabel.Location = new System.Drawing.Point(6, 23);
            this.DisplayModeLabel.Name = "DisplayModeLabel";
            this.DisplayModeLabel.Size = new System.Drawing.Size(74, 13);
            this.DisplayModeLabel.TabIndex = 0;
            this.DisplayModeLabel.Text = "Display Mode:";
            // 
            // DisplayModeComboBox
            // 
            this.DisplayModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DisplayModeComboBox.FormattingEnabled = true;
            this.DisplayModeComboBox.Items.AddRange(new object[] {
            "True Color",
            "Palette Color",
            "VGA Color"});
            this.DisplayModeComboBox.Location = new System.Drawing.Point(115, 19);
            this.DisplayModeComboBox.Name = "DisplayModeComboBox";
            this.DisplayModeComboBox.Size = new System.Drawing.Size(133, 21);
            this.DisplayModeComboBox.TabIndex = 1;
            this.DisplayModeComboBox.SelectedIndexChanged += new System.EventHandler(this.DisplayModeComboBox_SelectedIndexChanged);
            // 
            // ProofingGroupBox
            // 
            this.ProofingGroupBox.Controls.Add(this.ColorRenderIntentLabel);
            this.ProofingGroupBox.Controls.Add(this.MonitorProfileNameButton);
            this.ProofingGroupBox.Controls.Add(this.TargetProfileNameLabel);
            this.ProofingGroupBox.Controls.Add(this.TargetProfileNameButton);
            this.ProofingGroupBox.Controls.Add(this.MonitorProfileNameLabel);
            this.ProofingGroupBox.Controls.Add(this.ColorRenderIntentComboBox);
            this.ProofingGroupBox.Controls.Add(this.PrinterProfileNameLabel);
            this.ProofingGroupBox.Controls.Add(this.MonitorProfileNameTextBox);
            this.ProofingGroupBox.Controls.Add(this.TargetProfileNameTextBox);
            this.ProofingGroupBox.Controls.Add(this.PrinterProfileNameTextBox);
            this.ProofingGroupBox.Controls.Add(this.PrinterProfileNameButton);
            this.ProofingGroupBox.Location = new System.Drawing.Point(7, 162);
            this.ProofingGroupBox.Name = "ProofingGroupBox";
            this.ProofingGroupBox.Size = new System.Drawing.Size(253, 129);
            this.ProofingGroupBox.TabIndex = 4;
            this.ProofingGroupBox.TabStop = false;
            this.ProofingGroupBox.Visible = false;
            // 
            // ColorRenderIntentLabel
            // 
            this.ColorRenderIntentLabel.AutoSize = true;
            this.ColorRenderIntentLabel.Location = new System.Drawing.Point(3, 24);
            this.ColorRenderIntentLabel.Name = "ColorRenderIntentLabel";
            this.ColorRenderIntentLabel.Size = new System.Drawing.Size(102, 13);
            this.ColorRenderIntentLabel.TabIndex = 0;
            this.ColorRenderIntentLabel.Text = "Color Render Intent:";
            this.ColorRenderIntentLabel.Visible = false;
            // 
            // MonitorProfileNameButton
            // 
            this.MonitorProfileNameButton.Location = new System.Drawing.Point(221, 97);
            this.MonitorProfileNameButton.Name = "MonitorProfileNameButton";
            this.MonitorProfileNameButton.Size = new System.Drawing.Size(27, 23);
            this.MonitorProfileNameButton.TabIndex = 10;
            this.MonitorProfileNameButton.Text = "...";
            this.MonitorProfileNameButton.UseVisualStyleBackColor = true;
            this.MonitorProfileNameButton.Visible = false;
            this.MonitorProfileNameButton.Click += new System.EventHandler(this.MonitorProfileNameButton_Click);
            // 
            // TargetProfileNameLabel
            // 
            this.TargetProfileNameLabel.AutoSize = true;
            this.TargetProfileNameLabel.Location = new System.Drawing.Point(3, 75);
            this.TargetProfileNameLabel.Name = "TargetProfileNameLabel";
            this.TargetProfileNameLabel.Size = new System.Drawing.Size(104, 13);
            this.TargetProfileNameLabel.TabIndex = 5;
            this.TargetProfileNameLabel.Text = "Target Profile Name:";
            this.TargetProfileNameLabel.Visible = false;
            // 
            // TargetProfileNameButton
            // 
            this.TargetProfileNameButton.Location = new System.Drawing.Point(221, 71);
            this.TargetProfileNameButton.Name = "TargetProfileNameButton";
            this.TargetProfileNameButton.Size = new System.Drawing.Size(27, 23);
            this.TargetProfileNameButton.TabIndex = 7;
            this.TargetProfileNameButton.Text = "...";
            this.TargetProfileNameButton.UseVisualStyleBackColor = true;
            this.TargetProfileNameButton.Visible = false;
            this.TargetProfileNameButton.Click += new System.EventHandler(this.TargetProfileNameButton_Click);
            // 
            // MonitorProfileNameLabel
            // 
            this.MonitorProfileNameLabel.AutoSize = true;
            this.MonitorProfileNameLabel.Location = new System.Drawing.Point(3, 99);
            this.MonitorProfileNameLabel.Name = "MonitorProfileNameLabel";
            this.MonitorProfileNameLabel.Size = new System.Drawing.Size(108, 13);
            this.MonitorProfileNameLabel.TabIndex = 8;
            this.MonitorProfileNameLabel.Text = "Monitor Profile Name:";
            this.MonitorProfileNameLabel.Visible = false;
            // 
            // ColorRenderIntentComboBox
            // 
            this.ColorRenderIntentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorRenderIntentComboBox.FormattingEnabled = true;
            this.ColorRenderIntentComboBox.Items.AddRange(new object[] {
            "Images",
            "Business",
            "Graphics",
            "Absolute ColorMetric"});
            this.ColorRenderIntentComboBox.Location = new System.Drawing.Point(115, 21);
            this.ColorRenderIntentComboBox.Name = "ColorRenderIntentComboBox";
            this.ColorRenderIntentComboBox.Size = new System.Drawing.Size(133, 21);
            this.ColorRenderIntentComboBox.TabIndex = 1;
            this.ColorRenderIntentComboBox.Visible = false;
            this.ColorRenderIntentComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorRenderIntentComboBox_SelectedIndexChanged);
            // 
            // PrinterProfileNameLabel
            // 
            this.PrinterProfileNameLabel.AutoSize = true;
            this.PrinterProfileNameLabel.Location = new System.Drawing.Point(3, 51);
            this.PrinterProfileNameLabel.Name = "PrinterProfileNameLabel";
            this.PrinterProfileNameLabel.Size = new System.Drawing.Size(103, 13);
            this.PrinterProfileNameLabel.TabIndex = 2;
            this.PrinterProfileNameLabel.Text = "Printer Profile Name:";
            this.PrinterProfileNameLabel.Visible = false;
            // 
            // MonitorProfileNameTextBox
            // 
            this.MonitorProfileNameTextBox.Location = new System.Drawing.Point(115, 100);
            this.MonitorProfileNameTextBox.Name = "MonitorProfileNameTextBox";
            this.MonitorProfileNameTextBox.ReadOnly = true;
            this.MonitorProfileNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.MonitorProfileNameTextBox.TabIndex = 9;
            this.MonitorProfileNameTextBox.Visible = false;
            // 
            // TargetProfileNameTextBox
            // 
            this.TargetProfileNameTextBox.Location = new System.Drawing.Point(115, 73);
            this.TargetProfileNameTextBox.Name = "TargetProfileNameTextBox";
            this.TargetProfileNameTextBox.ReadOnly = true;
            this.TargetProfileNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.TargetProfileNameTextBox.TabIndex = 6;
            this.TargetProfileNameTextBox.Visible = false;
            // 
            // PrinterProfileNameTextBox
            // 
            this.PrinterProfileNameTextBox.Location = new System.Drawing.Point(115, 49);
            this.PrinterProfileNameTextBox.Name = "PrinterProfileNameTextBox";
            this.PrinterProfileNameTextBox.ReadOnly = true;
            this.PrinterProfileNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrinterProfileNameTextBox.TabIndex = 3;
            this.PrinterProfileNameTextBox.Visible = false;
            // 
            // PrinterProfileNameButton
            // 
            this.PrinterProfileNameButton.Location = new System.Drawing.Point(221, 47);
            this.PrinterProfileNameButton.Name = "PrinterProfileNameButton";
            this.PrinterProfileNameButton.Size = new System.Drawing.Size(27, 23);
            this.PrinterProfileNameButton.TabIndex = 4;
            this.PrinterProfileNameButton.Text = "...";
            this.PrinterProfileNameButton.UseVisualStyleBackColor = true;
            this.PrinterProfileNameButton.Visible = false;
            this.PrinterProfileNameButton.Click += new System.EventHandler(this.PrintProfileNameButton_Click);
            // 
            // ThumbnailTabPage
            // 
            this.ThumbnailTabPage.AutoScroll = true;
            this.ThumbnailTabPage.Controls.Add(this.ThumbnailDefaultButton);
            this.ThumbnailTabPage.Controls.Add(this.CellBorderGroupBox);
            this.ThumbnailTabPage.Controls.Add(this.ShowImagePlaceholdersCheckBox);
            this.ThumbnailTabPage.Controls.Add(this.ShowWorkingCursorCheckBox);
            this.ThumbnailTabPage.Controls.Add(this.ScrollDirectionLabel);
            this.ThumbnailTabPage.Controls.Add(this.ScrollDirectionComboBox);
            this.ThumbnailTabPage.Controls.Add(this.ThumbnailPreserveBlackCheckBox);
            this.ThumbnailTabPage.Controls.Add(this.CellGroupBox);
            this.ThumbnailTabPage.Controls.Add(this.CellSpacingGroupBox);
            this.ThumbnailTabPage.Controls.Add(this.DescriptorGroupBox);
            this.ThumbnailTabPage.Location = new System.Drawing.Point(4, 22);
            this.ThumbnailTabPage.Name = "ThumbnailTabPage";
            this.ThumbnailTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ThumbnailTabPage.Size = new System.Drawing.Size(286, 186);
            this.ThumbnailTabPage.TabIndex = 3;
            this.ThumbnailTabPage.Text = "Thumbnail";
            this.ThumbnailTabPage.UseVisualStyleBackColor = true;
            // 
            // ThumbnailDefaultButton
            // 
            this.ThumbnailDefaultButton.Location = new System.Drawing.Point(169, 491);
            this.ThumbnailDefaultButton.Name = "ThumbnailDefaultButton";
            this.ThumbnailDefaultButton.Size = new System.Drawing.Size(75, 23);
            this.ThumbnailDefaultButton.TabIndex = 9;
            this.ThumbnailDefaultButton.Text = "Defaults";
            this.ThumbnailDefaultButton.UseVisualStyleBackColor = true;
            this.ThumbnailDefaultButton.Click += new System.EventHandler(this.ThumbnailDefaultButton_Click);
            // 
            // CellBorderGroupBox
            // 
            this.CellBorderGroupBox.Controls.Add(this.CellBorderWidthNumericUpDown);
            this.CellBorderGroupBox.Controls.Add(this.CellBorderWithLabel);
            this.CellBorderGroupBox.Controls.Add(this.CellBorderColor);
            this.CellBorderGroupBox.Controls.Add(this.CellBorderColorButton);
            this.CellBorderGroupBox.Location = new System.Drawing.Point(154, 6);
            this.CellBorderGroupBox.Name = "CellBorderGroupBox";
            this.CellBorderGroupBox.Size = new System.Drawing.Size(106, 74);
            this.CellBorderGroupBox.TabIndex = 1;
            this.CellBorderGroupBox.TabStop = false;
            this.CellBorderGroupBox.Text = "Cell Border";
            // 
            // CellBorderWidthNumericUpDown
            // 
            this.CellBorderWidthNumericUpDown.Location = new System.Drawing.Point(49, 14);
            this.CellBorderWidthNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.CellBorderWidthNumericUpDown.Name = "CellBorderWidthNumericUpDown";
            this.CellBorderWidthNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.CellBorderWidthNumericUpDown.TabIndex = 1;
            this.CellBorderWidthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CellBorderWidthNumericUpDown.ValueChanged += new System.EventHandler(this.CellBorderWidthNumericUpDown_ValueChanged);
            // 
            // CellBorderWithLabel
            // 
            this.CellBorderWithLabel.AutoSize = true;
            this.CellBorderWithLabel.Location = new System.Drawing.Point(9, 18);
            this.CellBorderWithLabel.Name = "CellBorderWithLabel";
            this.CellBorderWithLabel.Size = new System.Drawing.Size(38, 13);
            this.CellBorderWithLabel.TabIndex = 0;
            this.CellBorderWithLabel.Text = "Width:";
            // 
            // CellBorderColor
            // 
            this.CellBorderColor.AutoSize = true;
            this.CellBorderColor.Location = new System.Drawing.Point(9, 44);
            this.CellBorderColor.Name = "CellBorderColor";
            this.CellBorderColor.Size = new System.Drawing.Size(34, 13);
            this.CellBorderColor.TabIndex = 2;
            this.CellBorderColor.Text = "Color:";
            // 
            // CellBorderColorButton
            // 
            this.CellBorderColorButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CellBorderColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CellBorderColorButton.Location = new System.Drawing.Point(49, 40);
            this.CellBorderColorButton.Name = "CellBorderColorButton";
            this.CellBorderColorButton.Size = new System.Drawing.Size(22, 23);
            this.CellBorderColorButton.TabIndex = 3;
            this.CellBorderColorButton.UseVisualStyleBackColor = false;
            this.CellBorderColorButton.Click += new System.EventHandler(this.CellBorderColorButton_Click);
            // 
            // ShowImagePlaceholdersCheckBox
            // 
            this.ShowImagePlaceholdersCheckBox.AutoSize = true;
            this.ShowImagePlaceholdersCheckBox.Location = new System.Drawing.Point(125, 473);
            this.ShowImagePlaceholdersCheckBox.Name = "ShowImagePlaceholdersCheckBox";
            this.ShowImagePlaceholdersCheckBox.Size = new System.Drawing.Size(119, 17);
            this.ShowImagePlaceholdersCheckBox.TabIndex = 7;
            this.ShowImagePlaceholdersCheckBox.Text = "Image Placeholders";
            this.ShowImagePlaceholdersCheckBox.UseVisualStyleBackColor = true;
            this.ShowImagePlaceholdersCheckBox.CheckedChanged += new System.EventHandler(this.ShowImagePlaceholdersCheckBox_CheckedChanged);
            // 
            // ShowWorkingCursorCheckBox
            // 
            this.ShowWorkingCursorCheckBox.AutoSize = true;
            this.ShowWorkingCursorCheckBox.Checked = true;
            this.ShowWorkingCursorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowWorkingCursorCheckBox.Location = new System.Drawing.Point(16, 497);
            this.ShowWorkingCursorCheckBox.Name = "ShowWorkingCursorCheckBox";
            this.ShowWorkingCursorCheckBox.Size = new System.Drawing.Size(99, 17);
            this.ShowWorkingCursorCheckBox.TabIndex = 8;
            this.ShowWorkingCursorCheckBox.Text = "Working Cursor";
            this.ShowWorkingCursorCheckBox.UseVisualStyleBackColor = true;
            this.ShowWorkingCursorCheckBox.CheckedChanged += new System.EventHandler(this.ShowHourGlassCheckBox_CheckedChanged);
            // 
            // ScrollDirectionLabel
            // 
            this.ScrollDirectionLabel.AutoSize = true;
            this.ScrollDirectionLabel.Location = new System.Drawing.Point(13, 449);
            this.ScrollDirectionLabel.Name = "ScrollDirectionLabel";
            this.ScrollDirectionLabel.Size = new System.Drawing.Size(81, 13);
            this.ScrollDirectionLabel.TabIndex = 4;
            this.ScrollDirectionLabel.Text = "Scroll Direction:";
            // 
            // ScrollDirectionComboBox
            // 
            this.ScrollDirectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScrollDirectionComboBox.FormattingEnabled = true;
            this.ScrollDirectionComboBox.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.ScrollDirectionComboBox.Location = new System.Drawing.Point(125, 446);
            this.ScrollDirectionComboBox.Name = "ScrollDirectionComboBox";
            this.ScrollDirectionComboBox.Size = new System.Drawing.Size(111, 21);
            this.ScrollDirectionComboBox.TabIndex = 5;
            this.ScrollDirectionComboBox.SelectedIndexChanged += new System.EventHandler(this.ScrollDirectionComboBox_SelectedIndexChanged);
            // 
            // ThumbnailPreserveBlackCheckBox
            // 
            this.ThumbnailPreserveBlackCheckBox.AutoSize = true;
            this.ThumbnailPreserveBlackCheckBox.Location = new System.Drawing.Point(16, 473);
            this.ThumbnailPreserveBlackCheckBox.Name = "ThumbnailPreserveBlackCheckBox";
            this.ThumbnailPreserveBlackCheckBox.Size = new System.Drawing.Size(98, 17);
            this.ThumbnailPreserveBlackCheckBox.TabIndex = 6;
            this.ThumbnailPreserveBlackCheckBox.Text = "Preserve Black";
            this.ThumbnailPreserveBlackCheckBox.UseVisualStyleBackColor = true;
            this.ThumbnailPreserveBlackCheckBox.CheckedChanged += new System.EventHandler(this.ThumbnailPreserveBlackCheckBox_CheckedChanged);
            // 
            // CellGroupBox
            // 
            this.CellGroupBox.Controls.Add(this.CellWidthNumericUpDown);
            this.CellGroupBox.Controls.Add(this.CellWidthLabel);
            this.CellGroupBox.Controls.Add(this.CellHeightLabel);
            this.CellGroupBox.Controls.Add(this.SelectBackColorButton);
            this.CellGroupBox.Controls.Add(this.SelectBackColorLabel);
            this.CellGroupBox.Controls.Add(this.CellHeightNumericUpDown);
            this.CellGroupBox.Controls.Add(this.ThumbnailBackColorLabel);
            this.CellGroupBox.Controls.Add(this.ThumbnailBackColorButton);
            this.CellGroupBox.Location = new System.Drawing.Point(6, 6);
            this.CellGroupBox.Name = "CellGroupBox";
            this.CellGroupBox.Size = new System.Drawing.Size(142, 125);
            this.CellGroupBox.TabIndex = 0;
            this.CellGroupBox.TabStop = false;
            this.CellGroupBox.Text = "Cell";
            // 
            // CellWidthNumericUpDown
            // 
            this.CellWidthNumericUpDown.Location = new System.Drawing.Point(76, 14);
            this.CellWidthNumericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.CellWidthNumericUpDown.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.CellWidthNumericUpDown.Name = "CellWidthNumericUpDown";
            this.CellWidthNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.CellWidthNumericUpDown.TabIndex = 1;
            this.CellWidthNumericUpDown.Value = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.CellWidthNumericUpDown.ValueChanged += new System.EventHandler(this.CellWidthNumericUpDown_ValueChanged);
            // 
            // CellWidthLabel
            // 
            this.CellWidthLabel.AutoSize = true;
            this.CellWidthLabel.Location = new System.Drawing.Point(2, 18);
            this.CellWidthLabel.Name = "CellWidthLabel";
            this.CellWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.CellWidthLabel.TabIndex = 0;
            this.CellWidthLabel.Text = "Width:";
            // 
            // CellHeightLabel
            // 
            this.CellHeightLabel.AutoSize = true;
            this.CellHeightLabel.Location = new System.Drawing.Point(2, 44);
            this.CellHeightLabel.Name = "CellHeightLabel";
            this.CellHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.CellHeightLabel.TabIndex = 2;
            this.CellHeightLabel.Text = "Height:";
            // 
            // SelectBackColorButton
            // 
            this.SelectBackColorButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SelectBackColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectBackColorButton.Location = new System.Drawing.Point(103, 95);
            this.SelectBackColorButton.Name = "SelectBackColorButton";
            this.SelectBackColorButton.Size = new System.Drawing.Size(22, 23);
            this.SelectBackColorButton.TabIndex = 7;
            this.SelectBackColorButton.UseVisualStyleBackColor = false;
            this.SelectBackColorButton.Click += new System.EventHandler(this.SelectBackColorButton_Click);
            // 
            // SelectBackColorLabel
            // 
            this.SelectBackColorLabel.AutoSize = true;
            this.SelectBackColorLabel.Location = new System.Drawing.Point(2, 100);
            this.SelectBackColorLabel.Name = "SelectBackColorLabel";
            this.SelectBackColorLabel.Size = new System.Drawing.Size(95, 13);
            this.SelectBackColorLabel.TabIndex = 6;
            this.SelectBackColorLabel.Text = "Select Back Color:";
            // 
            // CellHeightNumericUpDown
            // 
            this.CellHeightNumericUpDown.Location = new System.Drawing.Point(76, 40);
            this.CellHeightNumericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.CellHeightNumericUpDown.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.CellHeightNumericUpDown.Name = "CellHeightNumericUpDown";
            this.CellHeightNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.CellHeightNumericUpDown.TabIndex = 3;
            this.CellHeightNumericUpDown.Value = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.CellHeightNumericUpDown.ValueChanged += new System.EventHandler(this.CellHeightNumericUpDown_ValueChanged);
            // 
            // ThumbnailBackColorLabel
            // 
            this.ThumbnailBackColorLabel.AutoSize = true;
            this.ThumbnailBackColorLabel.Location = new System.Drawing.Point(2, 71);
            this.ThumbnailBackColorLabel.Name = "ThumbnailBackColorLabel";
            this.ThumbnailBackColorLabel.Size = new System.Drawing.Size(62, 13);
            this.ThumbnailBackColorLabel.TabIndex = 4;
            this.ThumbnailBackColorLabel.Text = "Back Color:";
            // 
            // ThumbnailBackColorButton
            // 
            this.ThumbnailBackColorButton.BackColor = System.Drawing.SystemColors.Window;
            this.ThumbnailBackColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThumbnailBackColorButton.Location = new System.Drawing.Point(103, 66);
            this.ThumbnailBackColorButton.Name = "ThumbnailBackColorButton";
            this.ThumbnailBackColorButton.Size = new System.Drawing.Size(22, 23);
            this.ThumbnailBackColorButton.TabIndex = 5;
            this.ThumbnailBackColorButton.UseVisualStyleBackColor = false;
            this.ThumbnailBackColorButton.Click += new System.EventHandler(this.ThumbnailBackColorButton_Click);
            // 
            // CellSpacingGroupBox
            // 
            this.CellSpacingGroupBox.Controls.Add(this.CellHorizontalSpacingLabel);
            this.CellSpacingGroupBox.Controls.Add(this.CellSpacingColorButton);
            this.CellSpacingGroupBox.Controls.Add(this.CellSpacingColorLabel);
            this.CellSpacingGroupBox.Controls.Add(this.CellHorizontalSpacingNumericUpDown);
            this.CellSpacingGroupBox.Controls.Add(this.CellVerticalSpacingNumericUpDown);
            this.CellSpacingGroupBox.Controls.Add(this.CellVerticalSpacingLabel);
            this.CellSpacingGroupBox.Location = new System.Drawing.Point(6, 137);
            this.CellSpacingGroupBox.Name = "CellSpacingGroupBox";
            this.CellSpacingGroupBox.Size = new System.Drawing.Size(142, 97);
            this.CellSpacingGroupBox.TabIndex = 2;
            this.CellSpacingGroupBox.TabStop = false;
            this.CellSpacingGroupBox.Text = "Cell Spacing";
            // 
            // CellHorizontalSpacingLabel
            // 
            this.CellHorizontalSpacingLabel.AutoSize = true;
            this.CellHorizontalSpacingLabel.Location = new System.Drawing.Point(7, 16);
            this.CellHorizontalSpacingLabel.Name = "CellHorizontalSpacingLabel";
            this.CellHorizontalSpacingLabel.Size = new System.Drawing.Size(57, 13);
            this.CellHorizontalSpacingLabel.TabIndex = 0;
            this.CellHorizontalSpacingLabel.Text = "Horizontal:";
            // 
            // CellSpacingColorButton
            // 
            this.CellSpacingColorButton.BackColor = System.Drawing.SystemColors.Window;
            this.CellSpacingColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CellSpacingColorButton.Location = new System.Drawing.Point(104, 64);
            this.CellSpacingColorButton.Name = "CellSpacingColorButton";
            this.CellSpacingColorButton.Size = new System.Drawing.Size(22, 23);
            this.CellSpacingColorButton.TabIndex = 5;
            this.CellSpacingColorButton.UseVisualStyleBackColor = false;
            this.CellSpacingColorButton.Click += new System.EventHandler(this.CellSpacingColorButton_Click);
            // 
            // CellSpacingColorLabel
            // 
            this.CellSpacingColorLabel.AutoSize = true;
            this.CellSpacingColorLabel.Location = new System.Drawing.Point(7, 69);
            this.CellSpacingColorLabel.Name = "CellSpacingColorLabel";
            this.CellSpacingColorLabel.Size = new System.Drawing.Size(34, 13);
            this.CellSpacingColorLabel.TabIndex = 4;
            this.CellSpacingColorLabel.Text = "Color:";
            // 
            // CellHorizontalSpacingNumericUpDown
            // 
            this.CellHorizontalSpacingNumericUpDown.Location = new System.Drawing.Point(77, 14);
            this.CellHorizontalSpacingNumericUpDown.Name = "CellHorizontalSpacingNumericUpDown";
            this.CellHorizontalSpacingNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.CellHorizontalSpacingNumericUpDown.TabIndex = 1;
            this.CellHorizontalSpacingNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CellHorizontalSpacingNumericUpDown.ValueChanged += new System.EventHandler(this.CellHorizontalSpacingNumericUpDown_ValueChanged);
            // 
            // CellVerticalSpacingNumericUpDown
            // 
            this.CellVerticalSpacingNumericUpDown.Location = new System.Drawing.Point(77, 39);
            this.CellVerticalSpacingNumericUpDown.Name = "CellVerticalSpacingNumericUpDown";
            this.CellVerticalSpacingNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.CellVerticalSpacingNumericUpDown.TabIndex = 3;
            this.CellVerticalSpacingNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CellVerticalSpacingNumericUpDown.ValueChanged += new System.EventHandler(this.CellVerticalSpacingNumericUpDown_ValueChanged);
            // 
            // CellVerticalSpacingLabel
            // 
            this.CellVerticalSpacingLabel.AutoSize = true;
            this.CellVerticalSpacingLabel.Location = new System.Drawing.Point(7, 40);
            this.CellVerticalSpacingLabel.Name = "CellVerticalSpacingLabel";
            this.CellVerticalSpacingLabel.Size = new System.Drawing.Size(45, 13);
            this.CellVerticalSpacingLabel.TabIndex = 2;
            this.CellVerticalSpacingLabel.Text = "Vertical:";
            // 
            // DescriptorGroupBox
            // 
            this.DescriptorGroupBox.Controls.Add(this.FontNameButton);
            this.DescriptorGroupBox.Controls.Add(this.FontSizeNumericUpDown);
            this.DescriptorGroupBox.Controls.Add(this.FontBoldLabel);
            this.DescriptorGroupBox.Controls.Add(this.FontBoldComboBox);
            this.DescriptorGroupBox.Controls.Add(this.FontItalicComboBox);
            this.DescriptorGroupBox.Controls.Add(this.FontStrikeoutComboBox);
            this.DescriptorGroupBox.Controls.Add(this.FontUnderlineComboBox);
            this.DescriptorGroupBox.Controls.Add(this.FontUnderlineLabel);
            this.DescriptorGroupBox.Controls.Add(this.FontStrikeoutLabel);
            this.DescriptorGroupBox.Controls.Add(this.FontItalicLabel);
            this.DescriptorGroupBox.Controls.Add(this.FontSizeLabel);
            this.DescriptorGroupBox.Controls.Add(this.FontNameLabel);
            this.DescriptorGroupBox.Controls.Add(this.FontShowHideButton);
            this.DescriptorGroupBox.Controls.Add(this.DescriptorVerticalAlignmentLabel);
            this.DescriptorGroupBox.Controls.Add(this.TextBackColorLabel);
            this.DescriptorGroupBox.Controls.Add(this.TextBackColorButton);
            this.DescriptorGroupBox.Controls.Add(this.DescriptorVerticalAlignmentComboBox);
            this.DescriptorGroupBox.Controls.Add(this.DescriptorDisplayMethodComboBox);
            this.DescriptorGroupBox.Controls.Add(this.DescriptorDisplayMethodLabel);
            this.DescriptorGroupBox.Controls.Add(this.DescriptorHorizontalAlignmentLabel);
            this.DescriptorGroupBox.Controls.Add(this.DescriptorHorizontalAlignmentComboBox);
            this.DescriptorGroupBox.Controls.Add(this.FontLabel);
            this.DescriptorGroupBox.Controls.Add(this.ForeColorLabel);
            this.DescriptorGroupBox.Controls.Add(this.ForeColorButton);
            this.DescriptorGroupBox.Controls.Add(this.FontNameTextBox);
            this.DescriptorGroupBox.Location = new System.Drawing.Point(6, 240);
            this.DescriptorGroupBox.Name = "DescriptorGroupBox";
            this.DescriptorGroupBox.Size = new System.Drawing.Size(233, 194);
            this.DescriptorGroupBox.TabIndex = 3;
            this.DescriptorGroupBox.TabStop = false;
            this.DescriptorGroupBox.Text = "Descriptor";
            // 
            // FontNameButton
            // 
            this.FontNameButton.Font = new System.Drawing.Font("Courier New", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontNameButton.Location = new System.Drawing.Point(197, 106);
            this.FontNameButton.Name = "FontNameButton";
            this.FontNameButton.Size = new System.Drawing.Size(19, 19);
            this.FontNameButton.TabIndex = 10;
            this.FontNameButton.Text = "...";
            this.FontNameButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FontNameButton.UseVisualStyleBackColor = true;
            this.FontNameButton.Visible = false;
            this.FontNameButton.Click += new System.EventHandler(this.FontNameButton_Click);
            // 
            // FontSizeNumericUpDown
            // 
            this.FontSizeNumericUpDown.Location = new System.Drawing.Point(159, 131);
            this.FontSizeNumericUpDown.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.FontSizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FontSizeNumericUpDown.Name = "FontSizeNumericUpDown";
            this.FontSizeNumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.FontSizeNumericUpDown.TabIndex = 13;
            this.FontSizeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FontSizeNumericUpDown.Visible = false;
            this.FontSizeNumericUpDown.ValueChanged += new System.EventHandler(this.FontSizeNumericUpDown_ValueChanged);
            // 
            // FontBoldLabel
            // 
            this.FontBoldLabel.AutoSize = true;
            this.FontBoldLabel.Location = new System.Drawing.Point(64, 161);
            this.FontBoldLabel.Name = "FontBoldLabel";
            this.FontBoldLabel.Size = new System.Drawing.Size(31, 13);
            this.FontBoldLabel.TabIndex = 15;
            this.FontBoldLabel.Text = "Bold:";
            this.FontBoldLabel.Visible = false;
            // 
            // FontBoldComboBox
            // 
            this.FontBoldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontBoldComboBox.FormattingEnabled = true;
            this.FontBoldComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.FontBoldComboBox.Location = new System.Drawing.Point(120, 157);
            this.FontBoldComboBox.Name = "FontBoldComboBox";
            this.FontBoldComboBox.Size = new System.Drawing.Size(97, 21);
            this.FontBoldComboBox.TabIndex = 16;
            this.FontBoldComboBox.Visible = false;
            this.FontBoldComboBox.SelectedIndexChanged += new System.EventHandler(this.FontBoldComboBox_SelectedIndexChanged);
            // 
            // FontItalicComboBox
            // 
            this.FontItalicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontItalicComboBox.FormattingEnabled = true;
            this.FontItalicComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.FontItalicComboBox.Location = new System.Drawing.Point(120, 183);
            this.FontItalicComboBox.Name = "FontItalicComboBox";
            this.FontItalicComboBox.Size = new System.Drawing.Size(97, 21);
            this.FontItalicComboBox.TabIndex = 18;
            this.FontItalicComboBox.Visible = false;
            this.FontItalicComboBox.SelectedIndexChanged += new System.EventHandler(this.FontItalicComboBox_SelectedIndexChanged);
            // 
            // FontStrikeoutComboBox
            // 
            this.FontStrikeoutComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontStrikeoutComboBox.FormattingEnabled = true;
            this.FontStrikeoutComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.FontStrikeoutComboBox.Location = new System.Drawing.Point(120, 209);
            this.FontStrikeoutComboBox.Name = "FontStrikeoutComboBox";
            this.FontStrikeoutComboBox.Size = new System.Drawing.Size(97, 21);
            this.FontStrikeoutComboBox.TabIndex = 20;
            this.FontStrikeoutComboBox.Visible = false;
            this.FontStrikeoutComboBox.SelectedIndexChanged += new System.EventHandler(this.FontStrikeoutComboBox_SelectedIndexChanged);
            // 
            // FontUnderlineComboBox
            // 
            this.FontUnderlineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontUnderlineComboBox.FormattingEnabled = true;
            this.FontUnderlineComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.FontUnderlineComboBox.Location = new System.Drawing.Point(120, 235);
            this.FontUnderlineComboBox.Name = "FontUnderlineComboBox";
            this.FontUnderlineComboBox.Size = new System.Drawing.Size(97, 21);
            this.FontUnderlineComboBox.TabIndex = 22;
            this.FontUnderlineComboBox.Visible = false;
            this.FontUnderlineComboBox.SelectedIndexChanged += new System.EventHandler(this.FontUnderlineComboBox_SelectedIndexChanged);
            // 
            // FontUnderlineLabel
            // 
            this.FontUnderlineLabel.AutoSize = true;
            this.FontUnderlineLabel.Location = new System.Drawing.Point(64, 239);
            this.FontUnderlineLabel.Name = "FontUnderlineLabel";
            this.FontUnderlineLabel.Size = new System.Drawing.Size(55, 13);
            this.FontUnderlineLabel.TabIndex = 21;
            this.FontUnderlineLabel.Text = "Underline:";
            this.FontUnderlineLabel.Visible = false;
            // 
            // FontStrikeoutLabel
            // 
            this.FontStrikeoutLabel.AutoSize = true;
            this.FontStrikeoutLabel.Location = new System.Drawing.Point(64, 213);
            this.FontStrikeoutLabel.Name = "FontStrikeoutLabel";
            this.FontStrikeoutLabel.Size = new System.Drawing.Size(52, 13);
            this.FontStrikeoutLabel.TabIndex = 19;
            this.FontStrikeoutLabel.Text = "Strikeout:";
            this.FontStrikeoutLabel.Visible = false;
            // 
            // FontItalicLabel
            // 
            this.FontItalicLabel.AutoSize = true;
            this.FontItalicLabel.Location = new System.Drawing.Point(64, 187);
            this.FontItalicLabel.Name = "FontItalicLabel";
            this.FontItalicLabel.Size = new System.Drawing.Size(32, 13);
            this.FontItalicLabel.TabIndex = 17;
            this.FontItalicLabel.Text = "Italic:";
            this.FontItalicLabel.Visible = false;
            // 
            // FontSizeLabel
            // 
            this.FontSizeLabel.AutoSize = true;
            this.FontSizeLabel.Location = new System.Drawing.Point(64, 135);
            this.FontSizeLabel.Name = "FontSizeLabel";
            this.FontSizeLabel.Size = new System.Drawing.Size(30, 13);
            this.FontSizeLabel.TabIndex = 12;
            this.FontSizeLabel.Text = "Size:";
            this.FontSizeLabel.Visible = false;
            // 
            // FontNameLabel
            // 
            this.FontNameLabel.AutoSize = true;
            this.FontNameLabel.Location = new System.Drawing.Point(64, 109);
            this.FontNameLabel.Name = "FontNameLabel";
            this.FontNameLabel.Size = new System.Drawing.Size(38, 13);
            this.FontNameLabel.TabIndex = 7;
            this.FontNameLabel.Text = "Name:";
            this.FontNameLabel.Visible = false;
            // 
            // FontShowHideButton
            // 
            this.FontShowHideButton.Location = new System.Drawing.Point(39, 104);
            this.FontShowHideButton.Name = "FontShowHideButton";
            this.FontShowHideButton.Size = new System.Drawing.Size(18, 23);
            this.FontShowHideButton.TabIndex = 8;
            this.FontShowHideButton.Text = ">";
            this.FontShowHideButton.UseVisualStyleBackColor = true;
            this.FontShowHideButton.Click += new System.EventHandler(this.FontShowHideButton_Click);
            // 
            // DescriptorVerticalAlignmentLabel
            // 
            this.DescriptorVerticalAlignmentLabel.AutoSize = true;
            this.DescriptorVerticalAlignmentLabel.Location = new System.Drawing.Point(8, 55);
            this.DescriptorVerticalAlignmentLabel.Name = "DescriptorVerticalAlignmentLabel";
            this.DescriptorVerticalAlignmentLabel.Size = new System.Drawing.Size(94, 13);
            this.DescriptorVerticalAlignmentLabel.TabIndex = 2;
            this.DescriptorVerticalAlignmentLabel.Text = "Vertical Alignment:";
            // 
            // TextBackColorLabel
            // 
            this.TextBackColorLabel.AutoSize = true;
            this.TextBackColorLabel.Location = new System.Drawing.Point(8, 137);
            this.TextBackColorLabel.Name = "TextBackColorLabel";
            this.TextBackColorLabel.Size = new System.Drawing.Size(86, 13);
            this.TextBackColorLabel.TabIndex = 23;
            this.TextBackColorLabel.Text = "Text Back Color:";
            // 
            // TextBackColorButton
            // 
            this.TextBackColorButton.BackColor = System.Drawing.SystemColors.Window;
            this.TextBackColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextBackColorButton.Location = new System.Drawing.Point(120, 132);
            this.TextBackColorButton.Name = "TextBackColorButton";
            this.TextBackColorButton.Size = new System.Drawing.Size(22, 23);
            this.TextBackColorButton.TabIndex = 24;
            this.TextBackColorButton.UseVisualStyleBackColor = false;
            this.TextBackColorButton.Click += new System.EventHandler(this.TextBackColorButton_Click);
            // 
            // DescriptorVerticalAlignmentComboBox
            // 
            this.DescriptorVerticalAlignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DescriptorVerticalAlignmentComboBox.FormattingEnabled = true;
            this.DescriptorVerticalAlignmentComboBox.Items.AddRange(new object[] {
            "Top",
            "Center",
            "Bottom"});
            this.DescriptorVerticalAlignmentComboBox.Location = new System.Drawing.Point(120, 50);
            this.DescriptorVerticalAlignmentComboBox.Name = "DescriptorVerticalAlignmentComboBox";
            this.DescriptorVerticalAlignmentComboBox.Size = new System.Drawing.Size(97, 21);
            this.DescriptorVerticalAlignmentComboBox.TabIndex = 3;
            this.DescriptorVerticalAlignmentComboBox.SelectedIndexChanged += new System.EventHandler(this.DescriptorVerticalAlignmentComboBox_SelectedIndexChanged);
            // 
            // DescriptorDisplayMethodComboBox
            // 
            this.DescriptorDisplayMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DescriptorDisplayMethodComboBox.FormattingEnabled = true;
            this.DescriptorDisplayMethodComboBox.Items.AddRange(new object[] {
            "Default",
            "Include Page",
            "Long Filename",
            "Short Filename",
            "None"});
            this.DescriptorDisplayMethodComboBox.Location = new System.Drawing.Point(120, 79);
            this.DescriptorDisplayMethodComboBox.Name = "DescriptorDisplayMethodComboBox";
            this.DescriptorDisplayMethodComboBox.Size = new System.Drawing.Size(97, 21);
            this.DescriptorDisplayMethodComboBox.TabIndex = 5;
            this.DescriptorDisplayMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.DescriptorDisplayMethodComboBox_SelectedIndexChanged);
            // 
            // DescriptorDisplayMethodLabel
            // 
            this.DescriptorDisplayMethodLabel.AutoSize = true;
            this.DescriptorDisplayMethodLabel.Location = new System.Drawing.Point(8, 84);
            this.DescriptorDisplayMethodLabel.Name = "DescriptorDisplayMethodLabel";
            this.DescriptorDisplayMethodLabel.Size = new System.Drawing.Size(83, 13);
            this.DescriptorDisplayMethodLabel.TabIndex = 4;
            this.DescriptorDisplayMethodLabel.Text = "Display Method:";
            // 
            // DescriptorHorizontalAlignmentLabel
            // 
            this.DescriptorHorizontalAlignmentLabel.AutoSize = true;
            this.DescriptorHorizontalAlignmentLabel.Location = new System.Drawing.Point(8, 25);
            this.DescriptorHorizontalAlignmentLabel.Name = "DescriptorHorizontalAlignmentLabel";
            this.DescriptorHorizontalAlignmentLabel.Size = new System.Drawing.Size(106, 13);
            this.DescriptorHorizontalAlignmentLabel.TabIndex = 0;
            this.DescriptorHorizontalAlignmentLabel.Text = "Horizontal Alignment:";
            // 
            // DescriptorHorizontalAlignmentComboBox
            // 
            this.DescriptorHorizontalAlignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DescriptorHorizontalAlignmentComboBox.FormattingEnabled = true;
            this.DescriptorHorizontalAlignmentComboBox.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.DescriptorHorizontalAlignmentComboBox.Location = new System.Drawing.Point(120, 21);
            this.DescriptorHorizontalAlignmentComboBox.Name = "DescriptorHorizontalAlignmentComboBox";
            this.DescriptorHorizontalAlignmentComboBox.Size = new System.Drawing.Size(97, 21);
            this.DescriptorHorizontalAlignmentComboBox.TabIndex = 1;
            this.DescriptorHorizontalAlignmentComboBox.SelectedIndexChanged += new System.EventHandler(this.DescriptorHorizontalAlignmentComboBox_SelectedIndexChanged);
            // 
            // FontLabel
            // 
            this.FontLabel.AutoSize = true;
            this.FontLabel.Location = new System.Drawing.Point(8, 109);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(31, 13);
            this.FontLabel.TabIndex = 6;
            this.FontLabel.Text = "Font:";
            // 
            // ForeColorLabel
            // 
            this.ForeColorLabel.AutoSize = true;
            this.ForeColorLabel.Location = new System.Drawing.Point(8, 168);
            this.ForeColorLabel.Name = "ForeColorLabel";
            this.ForeColorLabel.Size = new System.Drawing.Size(58, 13);
            this.ForeColorLabel.TabIndex = 25;
            this.ForeColorLabel.Text = "Fore Color:";
            // 
            // ForeColorButton
            // 
            this.ForeColorButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.ForeColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForeColorButton.Location = new System.Drawing.Point(120, 163);
            this.ForeColorButton.Name = "ForeColorButton";
            this.ForeColorButton.Size = new System.Drawing.Size(22, 23);
            this.ForeColorButton.TabIndex = 26;
            this.ForeColorButton.UseVisualStyleBackColor = false;
            this.ForeColorButton.Click += new System.EventHandler(this.ForeColorButton_Click);
            // 
            // FontNameTextBox
            // 
            this.FontNameTextBox.Location = new System.Drawing.Point(120, 105);
            this.FontNameTextBox.Name = "FontNameTextBox";
            this.FontNameTextBox.ReadOnly = true;
            this.FontNameTextBox.Size = new System.Drawing.Size(76, 20);
            this.FontNameTextBox.TabIndex = 9;
            this.FontNameTextBox.Visible = false;
            // 
            // ShowHideSettingsPanel
            // 
            this.ShowHideSettingsPanel.Controls.Add(this.ShowHideSettingsLabel);
            this.ShowHideSettingsPanel.Controls.Add(this.ShowHideSettingsButton);
            this.ShowHideSettingsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShowHideSettingsPanel.Location = new System.Drawing.Point(0, 212);
            this.ShowHideSettingsPanel.Name = "ShowHideSettingsPanel";
            this.ShowHideSettingsPanel.Size = new System.Drawing.Size(294, 38);
            this.ShowHideSettingsPanel.TabIndex = 1;
            // 
            // ShowHideSettingsLabel
            // 
            this.ShowHideSettingsLabel.AutoSize = true;
            this.ShowHideSettingsLabel.Location = new System.Drawing.Point(27, 16);
            this.ShowHideSettingsLabel.Name = "ShowHideSettingsLabel";
            this.ShowHideSettingsLabel.Size = new System.Drawing.Size(45, 13);
            this.ShowHideSettingsLabel.TabIndex = 1;
            this.ShowHideSettingsLabel.Text = "Settings";
            // 
            // ShowHideSettingsButton
            // 
            this.ShowHideSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowHideSettingsButton.Location = new System.Drawing.Point(4, 9);
            this.ShowHideSettingsButton.Name = "ShowHideSettingsButton";
            this.ShowHideSettingsButton.Size = new System.Drawing.Size(23, 25);
            this.ShowHideSettingsButton.TabIndex = 0;
            this.ShowHideSettingsButton.Text = "+";
            this.ShowHideSettingsButton.UseVisualStyleBackColor = true;
            this.ShowHideSettingsButton.Click += new System.EventHandler(this.ShowSettingsButton_Click);
            // 
            // notateXpress1
            // 
            this.notateXpress1.AllowPaint = true;
            this.notateXpress1.FontScaling = Accusoft.NotateXpressSdk.FontScaling.Normal;
            this.notateXpress1.ImagXpressLoad = true;
            this.notateXpress1.ImagXpressSave = true;
            this.notateXpress1.InteractMode = Accusoft.NotateXpressSdk.AnnotationMode.Edit;
            this.notateXpress1.LineScaling = Accusoft.NotateXpressSdk.LineScaling.Normal;
            this.notateXpress1.MultiLineEdit = false;
            this.notateXpress1.RecalibrateXdpi = -1;
            this.notateXpress1.RecalibrateYdpi = -1;
            this.notateXpress1.ToolTipTimeEdit = 0;
            this.notateXpress1.ToolTipTimeInteractive = 0;
            this.notateXpress1.AnnotationsChanged += new Accusoft.NotateXpressSdk.NotateXpress.AnnotationsChangedEventHandler(this.notateXpress1_AnnotationsChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 606);
            this.Controls.Add(this.ThumbnailImageSplitContainer);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImagXpress Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ThumbnailImageSplitContainer.Panel1.ResumeLayout(false);
            this.ThumbnailImageSplitContainer.Panel2.ResumeLayout(false);
            this.ThumbnailImageSplitContainer.ResumeLayout(false);
            this.ThumbnailSettingsSplitContainer.Panel1.ResumeLayout(false);
            this.ThumbnailSettingsSplitContainer.Panel2.ResumeLayout(false);
            this.ThumbnailSettingsSplitContainer.ResumeLayout(false);
            this.ClearThumbnailsPanel.ResumeLayout(false);
            this.ViewTabControl.ResumeLayout(false);
            this.ViewSettingsTabPage.ResumeLayout(false);
            this.ViewSettingsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomFactorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AspectYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AspectXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessNumericUpDown)).EndInit();
            this.StyleGroupBox.ResumeLayout(false);
            this.StyleGroupBox.PerformLayout();
            this.ColorManagementTabPage.ResumeLayout(false);
            this.ColorManagementTabPage.PerformLayout();
            this.PaletteGroupBox.ResumeLayout(false);
            this.PaletteGroupBox.PerformLayout();
            this.ColorGroupBox.ResumeLayout(false);
            this.ColorGroupBox.PerformLayout();
            this.ProofingGroupBox.ResumeLayout(false);
            this.ProofingGroupBox.PerformLayout();
            this.ThumbnailTabPage.ResumeLayout(false);
            this.ThumbnailTabPage.PerformLayout();
            this.CellBorderGroupBox.ResumeLayout(false);
            this.CellBorderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CellBorderWidthNumericUpDown)).EndInit();
            this.CellGroupBox.ResumeLayout(false);
            this.CellGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CellWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellHeightNumericUpDown)).EndInit();
            this.CellSpacingGroupBox.ResumeLayout(false);
            this.CellSpacingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CellHorizontalSpacingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellVerticalSpacingNumericUpDown)).EndInit();
            this.DescriptorGroupBox.ResumeLayout(false);
            this.DescriptorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeNumericUpDown)).EndInit();
            this.ShowHideSettingsPanel.ResumeLayout(false);
            this.ShowHideSettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator SaveExitSeparatorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem ImagXpressMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IsisXpressMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NotateXpressMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintProMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThumbnailXpressMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TwainProMenuItem;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripMenuItem ScanMenuItem;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton PointerButton;
        private System.Windows.Forms.ToolStripButton ZoomInButton;
        private System.Windows.Forms.ToolStripButton ZoomOutButton;
        private System.Windows.Forms.ToolStripButton ZoomRectangleButton;
        private System.Windows.Forms.ToolStripButton PanButton;
        private System.Windows.Forms.ToolStripSeparator FileImagXpressSeparator;
        private System.Windows.Forms.ToolStripButton PrintButton;
        private System.Windows.Forms.ToolStripMenuItem PrintMenuItem;
        private System.Windows.Forms.ToolStripSeparator ImagXpressAnnotationSeparator;
        private System.Windows.Forms.ToolStripButton ButtonToolButton;
        private System.Windows.Forms.ToolStripButton EllipseToolButton;
        private System.Windows.Forms.ToolStripButton FreehandToolButton;
        private System.Windows.Forms.ToolStripButton HighlightToolButton;
        private System.Windows.Forms.ToolStripButton ImageToolButton;
        private System.Windows.Forms.ToolStripButton LineToolButton;
        private System.Windows.Forms.ToolStripButton PolygonToolButton;
        private System.Windows.Forms.ToolStripButton PolylineToolButton;
        private System.Windows.Forms.ToolStripButton ProtractorToolButton;
        private System.Windows.Forms.ToolStripButton RectangleToolButton;
        private System.Windows.Forms.ToolStripButton RulerToolButton;
        private System.Windows.Forms.ToolStripButton StampToolButton;
        private System.Windows.Forms.ToolStripButton TextToolButton;
        private Accusoft.ImagXpressSdk.ImagXpress imagXpress1;
        private Accusoft.ImagXpressSdk.ImageXView imageXView1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarLabel;
        private Accusoft.ThumbnailXpressSdk.ThumbnailXpress thumbnailXpress1;
        private System.Windows.Forms.SplitContainer ThumbnailImageSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem ImageMenu;
        private System.Windows.Forms.ToolStripMenuItem PropertiesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HistogramMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MetadataMenuItem;
        private System.Windows.Forms.ToolStripSeparator AnnotationsPageSeparator;
        private System.Windows.Forms.ToolStripLabel PageLabel;
        private System.Windows.Forms.ToolStripTextBox PageTextBox;
        private System.Windows.Forms.ToolStripLabel PageCountLabel;
        private System.Windows.Forms.ToolStripButton PreviousPageButton;
        private System.Windows.Forms.ToolStripButton NextPageButton;
        private System.Windows.Forms.ToolStripMenuItem OpenCameraRawMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TwainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ISISMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenImageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenImageWithOptionsMenuItem;
        private System.Windows.Forms.SplitContainer ThumbnailSettingsSplitContainer;
        private System.Windows.Forms.TabControl ViewTabControl;
        private System.Windows.Forms.TabPage ViewSettingsTabPage;
        private System.Windows.Forms.Panel ShowHideSettingsPanel;
        private System.Windows.Forms.Button ShowHideSettingsButton;
        private System.Windows.Forms.ToolStripMenuItem SaveAsImageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsImageWithOptionsMenuItem;
        private System.Windows.Forms.Panel ClearThumbnailsPanel;
        private System.Windows.Forms.Button ClearImagesButton;
        private System.Windows.Forms.ToolStripSplitButton OpenButton;
        private System.Windows.Forms.ToolStripMenuItem OpenImageButtonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenImageWithOptionsButtonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenCameraRawButtonMenuItem;
        private System.Windows.Forms.ToolStripSplitButton SaveAsButton;
        private System.Windows.Forms.ToolStripMenuItem SaveAsImageButtonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsImageWithOptionsButtonMenuItem;
        private System.Windows.Forms.Label ShowHideSettingsLabel;
        private System.Windows.Forms.ComboBox VerticalAlignmentComboBox;
        private System.Windows.Forms.Label VerticalAlignmentLabel;
        private System.Windows.Forms.CheckBox AlphaBlendCheckBox;
        private System.Windows.Forms.CheckBox ProgressiveCheckBox;
        private System.Windows.Forms.NumericUpDown ContrastNumericUpDown;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.Label AutoResizeLabel;
        private System.Windows.Forms.ComboBox AutoResizeComboBox;
        private System.Windows.Forms.NumericUpDown AspectYNumericUpDown;
        private System.Windows.Forms.NumericUpDown AspectXNumericUpDown;
        private System.Windows.Forms.Label AspectYLabel;
        private System.Windows.Forms.Label AspectXLabel;
        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.NumericUpDown BrightnessNumericUpDown;
        private System.Windows.Forms.ComboBox HorizontalAlignmentComboBox;
        private System.Windows.Forms.Label HorizontalAlignmentLabel;
        private System.Windows.Forms.CheckBox DitheredCheckBox;
        private System.Windows.Forms.Label ZoomFactorLabel;
        private System.Windows.Forms.NumericUpDown ZoomFactorNumericUpDown;
        private System.Windows.Forms.CheckBox SmoothingCheckBox;
        private System.Windows.Forms.CheckBox PreserveBlackCheckBox;
        private System.Windows.Forms.CheckBox AntiAliasCheckBox;
        private System.Windows.Forms.TabPage ColorManagementTabPage;
        private System.Windows.Forms.Button TargetProfileNameButton;
        private System.Windows.Forms.TextBox TargetProfileNameTextBox;
        private System.Windows.Forms.Label TargetProfileNameLabel;
        private System.Windows.Forms.Button PrinterProfileNameButton;
        private System.Windows.Forms.TextBox PrinterProfileNameTextBox;
        private System.Windows.Forms.Label PrinterProfileNameLabel;
        private System.Windows.Forms.GroupBox PaletteGroupBox;
        private System.Windows.Forms.Label PaletteFileNameLabel;
        private System.Windows.Forms.Label PaletteTypeLabel;
        private System.Windows.Forms.ComboBox PaletteTypeComboBox;
        private System.Windows.Forms.TextBox PaletteFileNameTextBox;
        private System.Windows.Forms.Button PaletteFileNameButton;
        private System.Windows.Forms.GroupBox StyleGroupBox;
        private System.Windows.Forms.Button BackColorButton;
        private System.Windows.Forms.Label BackColorLabel;
        private System.Windows.Forms.GroupBox ColorGroupBox;
        private System.Windows.Forms.CheckBox ICMProofingCheckBox;
        private System.Windows.Forms.Label ColorRenderIntentLabel;
        private System.Windows.Forms.ComboBox ColorRenderIntentComboBox;
        private System.Windows.Forms.Label DisplayModeLabel;
        private System.Windows.Forms.ComboBox DisplayModeComboBox;
        private System.Windows.Forms.Button MonitorProfileNameButton;
        private System.Windows.Forms.TextBox MonitorProfileNameTextBox;
        private System.Windows.Forms.Label MonitorProfileNameLabel;
        private System.Windows.Forms.ToolStripMenuItem DocumentCleanupMenu;
        private System.Windows.Forms.ToolStripMenuItem BinarizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlobRemovalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BorderCropMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeskewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DespeckleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DilateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ErodeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LineRemovalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SmoothZoomMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlphaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlphaFlattenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlphaMergeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlphaReduceToAlphaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClarifyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClarifyDeskewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClarifyDespeckleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClarifyDilateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClarifyErodeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SharpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SharpenSubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SoftenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnsharpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhotoMenu;
        private System.Windows.Forms.ToolStripMenuItem BlendMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlurMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ButtonizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiffuseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmbossMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MatrixMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MedianMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MosaicMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MotionBlurMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NegateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NoiseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OutlineMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParabolicMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PerspectiveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PinchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PolynomialWarpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PosterizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RippleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SolarizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SwirlMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TwistMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SlideShowMenuItem;
        private System.Windows.Forms.TabPage ThumbnailTabPage;
        private System.Windows.Forms.Label ThumbnailBackColorLabel;
        private System.Windows.Forms.Button ThumbnailBackColorButton;
        private System.Windows.Forms.Label CellHeightLabel;
        private System.Windows.Forms.Label CellBorderWithLabel;
        private System.Windows.Forms.NumericUpDown CellHeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown CellBorderWidthNumericUpDown;
        private System.Windows.Forms.Label CellBorderColor;
        private System.Windows.Forms.Button CellBorderColorButton;
        private System.Windows.Forms.GroupBox CellGroupBox;
        private System.Windows.Forms.Label CellSpacingColorLabel;
        private System.Windows.Forms.NumericUpDown CellHorizontalSpacingNumericUpDown;
        private System.Windows.Forms.Button CellSpacingColorButton;
        private System.Windows.Forms.Label CellHorizontalSpacingLabel;
        private System.Windows.Forms.NumericUpDown CellWidthNumericUpDown;
        private System.Windows.Forms.Label CellWidthLabel;
        private System.Windows.Forms.Label DescriptorHorizontalAlignmentLabel;
        private System.Windows.Forms.ComboBox DescriptorHorizontalAlignmentComboBox;
        private System.Windows.Forms.ComboBox DescriptorDisplayMethodComboBox;
        private System.Windows.Forms.Label DescriptorDisplayMethodLabel;
        private System.Windows.Forms.Label FontLabel;
        private System.Windows.Forms.Label ForeColorLabel;
        private System.Windows.Forms.Button ForeColorButton;
        private System.Windows.Forms.Label SelectBackColorLabel;
        private System.Windows.Forms.Button SelectBackColorButton;
        private System.Windows.Forms.Label ScrollDirectionLabel;
        private System.Windows.Forms.ComboBox ScrollDirectionComboBox;
        private System.Windows.Forms.CheckBox ThumbnailPreserveBlackCheckBox;
        private System.Windows.Forms.CheckBox ShowImagePlaceholdersCheckBox;
        private System.Windows.Forms.CheckBox ShowWorkingCursorCheckBox;
        private System.Windows.Forms.Button TextBackColorButton;
        private System.Windows.Forms.Label TextBackColorLabel;
        private System.Windows.Forms.GroupBox DescriptorGroupBox;
        private System.Windows.Forms.Label DescriptorVerticalAlignmentLabel;
        private System.Windows.Forms.ComboBox DescriptorVerticalAlignmentComboBox;
        private System.Windows.Forms.Label CellVerticalSpacingLabel;
        private System.Windows.Forms.NumericUpDown CellVerticalSpacingNumericUpDown;
        private System.Windows.Forms.GroupBox CellBorderGroupBox;
        private System.Windows.Forms.GroupBox CellSpacingGroupBox;
        private System.Windows.Forms.GroupBox ProofingGroupBox;
        private System.Windows.Forms.Label FontSizeLabel;
        private System.Windows.Forms.Label FontNameLabel;
        private System.Windows.Forms.TextBox FontNameTextBox;
        private System.Windows.Forms.Button FontShowHideButton;
        private System.Windows.Forms.Label FontItalicLabel;
        private System.Windows.Forms.Label FontUnderlineLabel;
        private System.Windows.Forms.Label FontStrikeoutLabel;
        private System.Windows.Forms.ComboBox FontStrikeoutComboBox;
        private System.Windows.Forms.ComboBox FontUnderlineComboBox;
        private System.Windows.Forms.ComboBox FontItalicComboBox;
        private System.Windows.Forms.Button FontNameButton;
        private System.Windows.Forms.NumericUpDown FontSizeNumericUpDown;
        private System.Windows.Forms.Label FontBoldLabel;
        private System.Windows.Forms.ComboBox FontBoldComboBox;
        private System.Windows.Forms.Button ViewDefaultButton;
        private System.Windows.Forms.Button ColorDefaultButton;
        private System.Windows.Forms.Button ThumbnailDefaultButton;
        private Accusoft.TwainProSdk.TwainPro twainPro1;
        private System.Windows.Forms.ToolStripMenuItem AutoBinarizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EffectsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnhancementMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FlipMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MirrorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RotateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorModifyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorModifyAdjustHSLMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorModifyAdjustRGBMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorModifyColorDepthMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorModifyReplaceColorsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorSeparationMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ScanButton;
        private System.Windows.Forms.ToolStripMenuItem TwainButtonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IsisButtonMenuItem;
        private Accusoft.NotateXpressSdk.NotateXpress notateXpress1;
        private System.Windows.Forms.ToolStripButton NoteToolButton;
        private System.Windows.Forms.ToolStripButton MagnifyButton;
        private System.Windows.Forms.ToolStripMenuItem CropMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoCropMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManualCropMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CropBorderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorCorrectionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BrightnessSubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BrightnessGammaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContrastEqualizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoLevelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContrastMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContrastAutoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContrastManualMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LightnessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LightnessManualMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LightnessAutoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorBalanceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorBalanceAutoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorBalanceManualMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveDefectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveDustMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveScratchesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedEyeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedEyeRemovalAutoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedEyeRemovalManualMenuItem;
        private Accusoft.PrintProSdk.PrintPro printPro1;
        private System.Windows.Forms.ToolStripButton SelectionButton;
        private System.Windows.Forms.ToolStripMenuItem OnlineHelpMenuItem;
    }
}

