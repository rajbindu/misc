namespace WindowsApplication1
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
            this.loadButton = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.VersionBox = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.LayoutNumLabel = new System.Windows.Forms.Label();
            this.UnitBox = new System.Windows.Forms.Label();
            this.UnitLabel = new System.Windows.Forms.Label();
            this.WidthBox = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CountBox = new System.Windows.Forms.Label();
            this.CountBox2 = new System.Windows.Forms.Label();
            this.layerLabel2 = new System.Windows.Forms.Label();
            this.LayerDBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LayerLabel = new System.Windows.Forms.Label();
            this.inUseBox = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.frozenBox = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LockBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LayerOnBox = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LayerNumberBox = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LayerNameBox = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.PlotBox = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagXperssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LayoutGroupBox = new System.Windows.Forms.GroupBox();
            this.layoutBox = new System.Windows.Forms.ComboBox();
            this.LayerGroupBox = new System.Windows.Forms.GroupBox();
            this.layerBox = new System.Windows.Forms.ComboBox();
            this.OffRadioButton = new System.Windows.Forms.RadioButton();
            this.OnRadioButton = new System.Windows.Forms.RadioButton();
            this.DescriptionListBox = new System.Windows.Forms.ListBox();
            this.labelLastErrorDescription = new System.Windows.Forms.Label();
            this.labelLastError = new System.Windows.Forms.Label();
            this.imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress(this.components);
            this.imageXView1 = new Accusoft.ImagXpressSdk.ImageXView(this.components);
            this.menuStrip1.SuspendLayout();
            this.LayoutGroupBox.SuspendLayout();
            this.LayerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(631, 638);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(111, 23);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load CAD Image";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(41, 125);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(89, 13);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "CAD File Version:";
            // 
            // VersionBox
            // 
            this.VersionBox.Location = new System.Drawing.Point(136, 125);
            this.VersionBox.Name = "VersionBox";
            this.VersionBox.Size = new System.Drawing.Size(95, 13);
            this.VersionBox.TabIndex = 2;
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(136, 149);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(95, 13);
            this.TypeBox.TabIndex = 4;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(41, 149);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(78, 13);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "CAD File Type:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(56, 75);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(110, 13);
            this.NameBox.TabIndex = 6;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(15, 75);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name:";
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(57, 101);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(110, 13);
            this.HeightBox.TabIndex = 8;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(13, 101);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 7;
            this.HeightLabel.Text = "Height:";
            // 
            // LayoutNumLabel
            // 
            this.LayoutNumLabel.AutoSize = true;
            this.LayoutNumLabel.Location = new System.Drawing.Point(15, 26);
            this.LayoutNumLabel.Name = "LayoutNumLabel";
            this.LayoutNumLabel.Size = new System.Drawing.Size(82, 13);
            this.LayoutNumLabel.TabIndex = 10;
            this.LayoutNumLabel.Text = "Layout Number:";
            // 
            // UnitBox
            // 
            this.UnitBox.Location = new System.Drawing.Point(57, 153);
            this.UnitBox.Name = "UnitBox";
            this.UnitBox.Size = new System.Drawing.Size(110, 13);
            this.UnitBox.TabIndex = 14;
            // 
            // UnitLabel
            // 
            this.UnitLabel.AutoSize = true;
            this.UnitLabel.Location = new System.Drawing.Point(14, 153);
            this.UnitLabel.Name = "UnitLabel";
            this.UnitLabel.Size = new System.Drawing.Size(34, 13);
            this.UnitLabel.TabIndex = 13;
            this.UnitLabel.Text = "Units:";
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(57, 127);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(110, 13);
            this.WidthBox.TabIndex = 12;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(12, 127);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 11;
            this.WidthLabel.Text = "Width:";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(116, 16);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(73, 13);
            this.CountLabel.TabIndex = 15;
            this.CountLabel.Text = "Layout Count:";
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(192, 16);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(26, 13);
            this.CountBox.TabIndex = 16;
            // 
            // CountBox2
            // 
            this.CountBox2.Location = new System.Drawing.Point(212, 48);
            this.CountBox2.Name = "CountBox2";
            this.CountBox2.Size = new System.Drawing.Size(30, 13);
            this.CountBox2.TabIndex = 28;
            // 
            // layerLabel2
            // 
            this.layerLabel2.AutoSize = true;
            this.layerLabel2.Location = new System.Drawing.Point(142, 48);
            this.layerLabel2.Name = "layerLabel2";
            this.layerLabel2.Size = new System.Drawing.Size(67, 13);
            this.layerLabel2.TabIndex = 27;
            this.layerLabel2.Text = "Layer Count:";
            // 
            // LayerDBox
            // 
            this.LayerDBox.Location = new System.Drawing.Point(119, 133);
            this.LayerDBox.Name = "LayerDBox";
            this.LayerDBox.Size = new System.Drawing.Size(110, 13);
            this.LayerDBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Layer Description:";
            // 
            // LayerLabel
            // 
            this.LayerLabel.AutoSize = true;
            this.LayerLabel.Location = new System.Drawing.Point(15, 28);
            this.LayerLabel.Name = "LayerLabel";
            this.LayerLabel.Size = new System.Drawing.Size(76, 13);
            this.LayerLabel.TabIndex = 22;
            this.LayerLabel.Text = "Layer Number:";
            // 
            // inUseBox
            // 
            this.inUseBox.Location = new System.Drawing.Point(119, 110);
            this.inUseBox.Name = "inUseBox";
            this.inUseBox.Size = new System.Drawing.Size(110, 13);
            this.inUseBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "In Use:";
            // 
            // frozenBox
            // 
            this.frozenBox.Location = new System.Drawing.Point(119, 84);
            this.frozenBox.Name = "frozenBox";
            this.frozenBox.Size = new System.Drawing.Size(110, 13);
            this.frozenBox.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Frozen:";
            // 
            // LockBox
            // 
            this.LockBox.Location = new System.Drawing.Point(119, 235);
            this.LockBox.Name = "LockBox";
            this.LockBox.Size = new System.Drawing.Size(110, 13);
            this.LockBox.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Locked:";
            // 
            // LayerOnBox
            // 
            this.LayerOnBox.Location = new System.Drawing.Point(119, 209);
            this.LayerOnBox.Name = "LayerOnBox";
            this.LayerOnBox.Size = new System.Drawing.Size(110, 13);
            this.LayerOnBox.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Layer On:";
            // 
            // LayerNumberBox
            // 
            this.LayerNumberBox.Location = new System.Drawing.Point(119, 183);
            this.LayerNumberBox.Name = "LayerNumberBox";
            this.LayerNumberBox.Size = new System.Drawing.Size(110, 13);
            this.LayerNumberBox.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Layer Number:";
            // 
            // LayerNameBox
            // 
            this.LayerNameBox.Location = new System.Drawing.Point(119, 157);
            this.LayerNameBox.Name = "LayerNameBox";
            this.LayerNameBox.Size = new System.Drawing.Size(110, 13);
            this.LayerNameBox.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Layer Name:";
            // 
            // PlotBox
            // 
            this.PlotBox.Location = new System.Drawing.Point(119, 260);
            this.PlotBox.Name = "PlotBox";
            this.PlotBox.Size = new System.Drawing.Size(110, 13);
            this.PlotBox.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 260);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Plottable:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagXperssToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // imagXperssToolStripMenuItem
            // 
            this.imagXperssToolStripMenuItem.Name = "imagXperssToolStripMenuItem";
            this.imagXperssToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.imagXperssToolStripMenuItem.Text = "Imag&Xpress";
            this.imagXperssToolStripMenuItem.Click += new System.EventHandler(this.imagXperssToolStripMenuItem_Click);
            // 
            // LayoutGroupBox
            // 
            this.LayoutGroupBox.Controls.Add(this.layoutBox);
            this.LayoutGroupBox.Controls.Add(this.LayoutNumLabel);
            this.LayoutGroupBox.Controls.Add(this.UnitLabel);
            this.LayoutGroupBox.Controls.Add(this.WidthLabel);
            this.LayoutGroupBox.Controls.Add(this.HeightLabel);
            this.LayoutGroupBox.Controls.Add(this.NameLabel);
            this.LayoutGroupBox.Controls.Add(this.CountLabel);
            this.LayoutGroupBox.Controls.Add(this.CountBox);
            this.LayoutGroupBox.Controls.Add(this.NameBox);
            this.LayoutGroupBox.Controls.Add(this.HeightBox);
            this.LayoutGroupBox.Controls.Add(this.WidthBox);
            this.LayoutGroupBox.Controls.Add(this.UnitBox);
            this.LayoutGroupBox.Enabled = false;
            this.LayoutGroupBox.Location = new System.Drawing.Point(12, 170);
            this.LayoutGroupBox.Name = "LayoutGroupBox";
            this.LayoutGroupBox.Size = new System.Drawing.Size(272, 178);
            this.LayoutGroupBox.TabIndex = 40;
            this.LayoutGroupBox.TabStop = false;
            this.LayoutGroupBox.Text = "Layout";
            // 
            // layoutBox
            // 
            this.layoutBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layoutBox.FormattingEnabled = true;
            this.layoutBox.Location = new System.Drawing.Point(15, 44);
            this.layoutBox.Name = "layoutBox";
            this.layoutBox.Size = new System.Drawing.Size(152, 21);
            this.layoutBox.TabIndex = 17;
            this.layoutBox.SelectedIndexChanged += new System.EventHandler(this.layoutBox_SelectedIndexChanged);
            // 
            // LayerGroupBox
            // 
            this.LayerGroupBox.Controls.Add(this.layerBox);
            this.LayerGroupBox.Controls.Add(this.OffRadioButton);
            this.LayerGroupBox.Controls.Add(this.OnRadioButton);
            this.LayerGroupBox.Controls.Add(this.PlotBox);
            this.LayerGroupBox.Controls.Add(this.label18);
            this.LayerGroupBox.Controls.Add(this.LockBox);
            this.LayerGroupBox.Controls.Add(this.label2);
            this.LayerGroupBox.Controls.Add(this.LayerOnBox);
            this.LayerGroupBox.Controls.Add(this.label12);
            this.LayerGroupBox.Controls.Add(this.LayerNumberBox);
            this.LayerGroupBox.Controls.Add(this.label14);
            this.LayerGroupBox.Controls.Add(this.LayerNameBox);
            this.LayerGroupBox.Controls.Add(this.label16);
            this.LayerGroupBox.Controls.Add(this.CountBox2);
            this.LayerGroupBox.Controls.Add(this.layerLabel2);
            this.LayerGroupBox.Controls.Add(this.LayerDBox);
            this.LayerGroupBox.Controls.Add(this.label4);
            this.LayerGroupBox.Controls.Add(this.LayerLabel);
            this.LayerGroupBox.Controls.Add(this.inUseBox);
            this.LayerGroupBox.Controls.Add(this.label9);
            this.LayerGroupBox.Controls.Add(this.frozenBox);
            this.LayerGroupBox.Controls.Add(this.label11);
            this.LayerGroupBox.Enabled = false;
            this.LayerGroupBox.Location = new System.Drawing.Point(12, 354);
            this.LayerGroupBox.Name = "LayerGroupBox";
            this.LayerGroupBox.Size = new System.Drawing.Size(272, 308);
            this.LayerGroupBox.TabIndex = 41;
            this.LayerGroupBox.TabStop = false;
            this.LayerGroupBox.Text = "Layer";
            // 
            // layerBox
            // 
            this.layerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layerBox.FormattingEnabled = true;
            this.layerBox.Location = new System.Drawing.Point(15, 45);
            this.layerBox.Name = "layerBox";
            this.layerBox.Size = new System.Drawing.Size(121, 21);
            this.layerBox.TabIndex = 41;
            this.layerBox.SelectedIndexChanged += new System.EventHandler(this.layerBox_SelectedIndexChanged);
            // 
            // OffRadioButton
            // 
            this.OffRadioButton.AutoSize = true;
            this.OffRadioButton.Location = new System.Drawing.Point(164, 19);
            this.OffRadioButton.Name = "OffRadioButton";
            this.OffRadioButton.Size = new System.Drawing.Size(39, 17);
            this.OffRadioButton.TabIndex = 40;
            this.OffRadioButton.Text = "Off";
            this.OffRadioButton.UseVisualStyleBackColor = true;
            this.OffRadioButton.Click += new System.EventHandler(this.OffRadioButton_Click);
            // 
            // OnRadioButton
            // 
            this.OnRadioButton.AutoSize = true;
            this.OnRadioButton.Location = new System.Drawing.Point(119, 19);
            this.OnRadioButton.Name = "OnRadioButton";
            this.OnRadioButton.Size = new System.Drawing.Size(39, 17);
            this.OnRadioButton.TabIndex = 39;
            this.OnRadioButton.Text = "On";
            this.OnRadioButton.UseVisualStyleBackColor = true;
            this.OnRadioButton.Click += new System.EventHandler(this.OnRadioButton_Click);
            // 
            // DescriptionListBox
            // 
            this.DescriptionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionListBox.FormattingEnabled = true;
            this.DescriptionListBox.Items.AddRange(new object[] {
            "ImagXpress CAD sample. The following features are demonstrated:",
            "1) Loading a CAD file into ImagXpress",
            "2) Obtaining information from CAD files",
            "3) Accessing and setting ImagXpress\' CAD-related fields"});
            this.DescriptionListBox.Location = new System.Drawing.Point(9, 27);
            this.DescriptionListBox.Name = "DescriptionListBox";
            this.DescriptionListBox.Size = new System.Drawing.Size(412, 82);
            this.DescriptionListBox.TabIndex = 17;
            // 
            // labelLastErrorDescription
            // 
            this.labelLastErrorDescription.Location = new System.Drawing.Point(438, 50);
            this.labelLastErrorDescription.Name = "labelLastErrorDescription";
            this.labelLastErrorDescription.Size = new System.Drawing.Size(295, 58);
            this.labelLastErrorDescription.TabIndex = 42;
            // 
            // labelLastError
            // 
            this.labelLastError.AutoSize = true;
            this.labelLastError.Location = new System.Drawing.Point(438, 27);
            this.labelLastError.Name = "labelLastError";
            this.labelLastError.Size = new System.Drawing.Size(55, 13);
            this.labelLastError.TabIndex = 44;
            this.labelLastError.Text = "Last Error:";
            // 
            // imageXView1
            // 
            this.imageXView1.AutoResize = Accusoft.ImagXpressSdk.AutoResizeType.BestFit;
            this.imageXView1.Location = new System.Drawing.Point(302, 116);
            this.imageXView1.Name = "imageXView1";
            this.imageXView1.Size = new System.Drawing.Size(440, 516);
            this.imageXView1.TabIndex = 45;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 671);
            this.Controls.Add(this.imageXView1);
            this.Controls.Add(this.labelLastError);
            this.Controls.Add(this.labelLastErrorDescription);
            this.Controls.Add(this.DescriptionListBox);
            this.Controls.Add(this.LayerGroupBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.VersionBox);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LayoutGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LayoutGroupBox.ResumeLayout(false);
            this.LayoutGroupBox.PerformLayout();
            this.LayerGroupBox.ResumeLayout(false);
            this.LayerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label VersionBox;
        private System.Windows.Forms.Label TypeBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label HeightBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label LayoutNumLabel;
        private System.Windows.Forms.Label UnitBox;
        private System.Windows.Forms.Label UnitLabel;
        private System.Windows.Forms.Label WidthBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label CountBox;
        private System.Windows.Forms.Label CountBox2;
        private System.Windows.Forms.Label layerLabel2;
        private System.Windows.Forms.Label LayerDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LayerLabel;
        private System.Windows.Forms.Label inUseBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label frozenBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LockBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LayerOnBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LayerNumberBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LayerNameBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label PlotBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagXperssToolStripMenuItem;
        private System.Windows.Forms.GroupBox LayoutGroupBox;
        private System.Windows.Forms.GroupBox LayerGroupBox;
        private System.Windows.Forms.RadioButton OffRadioButton;
        private System.Windows.Forms.RadioButton OnRadioButton;
        private System.Windows.Forms.ListBox DescriptionListBox;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ComboBox layoutBox;
        private System.Windows.Forms.ComboBox layerBox;
        private System.Windows.Forms.Label labelLastErrorDescription;
        private System.Windows.Forms.Label labelLastError;
        private Accusoft.ImagXpressSdk.ImagXpress imagXpress1;
        private Accusoft.ImagXpressSdk.ImageXView imageXView1;
    }
}

