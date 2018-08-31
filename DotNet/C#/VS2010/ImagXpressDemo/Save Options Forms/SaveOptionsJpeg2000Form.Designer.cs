/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
namespace ImagXpressDemo
{
    partial class SaveOptionsJpeg2000Form
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
            this.Jpeg2000GroupBox = new System.Windows.Forms.GroupBox();
            this.ProgressionOrderLabel = new System.Windows.Forms.Label();
            this.TileGroupBox = new System.Windows.Forms.GroupBox();
            this.TileHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TileHeightLabel = new System.Windows.Forms.Label();
            this.TileWidthLabel = new System.Windows.Forms.Label();
            this.TileWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PeakSignalToNoiseRatioLabel = new System.Windows.Forms.Label();
            this.PeakSignalToNoiseRatioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.ProgressionOrderComboBox = new System.Windows.Forms.ComboBox();
            this.GrayscaleCheckBox = new System.Windows.Forms.CheckBox();
            this.CompressSizeLabel = new System.Windows.Forms.Label();
            this.CompressSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Jpeg2000GroupBox.SuspendLayout();
            this.TileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TileHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeakSignalToNoiseRatioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompressSizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.TabIndex = 2;
            // 
            // CancelOptionsButton
            // 
            this.CancelOptionsButton.TabIndex = 0;
            // 
            // Jpeg2000GroupBox
            // 
            this.Jpeg2000GroupBox.Controls.Add(this.ProgressionOrderLabel);
            this.Jpeg2000GroupBox.Controls.Add(this.TileGroupBox);
            this.Jpeg2000GroupBox.Controls.Add(this.PeakSignalToNoiseRatioLabel);
            this.Jpeg2000GroupBox.Controls.Add(this.PeakSignalToNoiseRatioNumericUpDown);
            this.Jpeg2000GroupBox.Controls.Add(this.TypeLabel);
            this.Jpeg2000GroupBox.Controls.Add(this.TypeComboBox);
            this.Jpeg2000GroupBox.Controls.Add(this.ProgressionOrderComboBox);
            this.Jpeg2000GroupBox.Controls.Add(this.GrayscaleCheckBox);
            this.Jpeg2000GroupBox.Controls.Add(this.CompressSizeLabel);
            this.Jpeg2000GroupBox.Controls.Add(this.CompressSizeNumericUpDown);
            this.Jpeg2000GroupBox.Location = new System.Drawing.Point(9, 12);
            this.Jpeg2000GroupBox.Name = "Jpeg2000GroupBox";
            this.Jpeg2000GroupBox.Size = new System.Drawing.Size(363, 142);
            this.Jpeg2000GroupBox.TabIndex = 1;
            this.Jpeg2000GroupBox.TabStop = false;
            this.Jpeg2000GroupBox.Text = "JPEG2000";
            // 
            // ProgressionOrderLabel
            // 
            this.ProgressionOrderLabel.AutoSize = true;
            this.ProgressionOrderLabel.Location = new System.Drawing.Point(11, 16);
            this.ProgressionOrderLabel.Name = "ProgressionOrderLabel";
            this.ProgressionOrderLabel.Size = new System.Drawing.Size(94, 13);
            this.ProgressionOrderLabel.TabIndex = 0;
            this.ProgressionOrderLabel.Text = "Progression Order:";
            // 
            // TileGroupBox
            // 
            this.TileGroupBox.Controls.Add(this.TileHeightNumericUpDown);
            this.TileGroupBox.Controls.Add(this.TileHeightLabel);
            this.TileGroupBox.Controls.Add(this.TileWidthLabel);
            this.TileGroupBox.Controls.Add(this.TileWidthNumericUpDown);
            this.TileGroupBox.Location = new System.Drawing.Point(232, 66);
            this.TileGroupBox.Name = "TileGroupBox";
            this.TileGroupBox.Size = new System.Drawing.Size(125, 70);
            this.TileGroupBox.TabIndex = 7;
            this.TileGroupBox.TabStop = false;
            this.TileGroupBox.Text = "Tile";
            // 
            // TileHeightNumericUpDown
            // 
            this.TileHeightNumericUpDown.Location = new System.Drawing.Point(55, 42);
            this.TileHeightNumericUpDown.Name = "TileHeightNumericUpDown";
            this.TileHeightNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.TileHeightNumericUpDown.TabIndex = 3;
            // 
            // TileHeightLabel
            // 
            this.TileHeightLabel.AutoSize = true;
            this.TileHeightLabel.Location = new System.Drawing.Point(11, 42);
            this.TileHeightLabel.Name = "TileHeightLabel";
            this.TileHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.TileHeightLabel.TabIndex = 2;
            this.TileHeightLabel.Text = "Height:";
            // 
            // TileWidthLabel
            // 
            this.TileWidthLabel.AutoSize = true;
            this.TileWidthLabel.Location = new System.Drawing.Point(11, 17);
            this.TileWidthLabel.Name = "TileWidthLabel";
            this.TileWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.TileWidthLabel.TabIndex = 0;
            this.TileWidthLabel.Text = "Width:";
            // 
            // TileWidthNumericUpDown
            // 
            this.TileWidthNumericUpDown.Location = new System.Drawing.Point(55, 13);
            this.TileWidthNumericUpDown.Name = "TileWidthNumericUpDown";
            this.TileWidthNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.TileWidthNumericUpDown.TabIndex = 1;
            // 
            // PeakSignalToNoiseRatioLabel
            // 
            this.PeakSignalToNoiseRatioLabel.AutoSize = true;
            this.PeakSignalToNoiseRatioLabel.Location = new System.Drawing.Point(11, 79);
            this.PeakSignalToNoiseRatioLabel.Name = "PeakSignalToNoiseRatioLabel";
            this.PeakSignalToNoiseRatioLabel.Size = new System.Drawing.Size(40, 13);
            this.PeakSignalToNoiseRatioLabel.TabIndex = 5;
            this.PeakSignalToNoiseRatioLabel.Text = "PSNR:";
            // 
            // PeakSignalToNoiseRatioNumericUpDown
            // 
            this.PeakSignalToNoiseRatioNumericUpDown.DecimalPlaces = 2;
            this.PeakSignalToNoiseRatioNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PeakSignalToNoiseRatioNumericUpDown.Location = new System.Drawing.Point(107, 77);
            this.PeakSignalToNoiseRatioNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PeakSignalToNoiseRatioNumericUpDown.Name = "PeakSignalToNoiseRatioNumericUpDown";
            this.PeakSignalToNoiseRatioNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.PeakSignalToNoiseRatioNumericUpDown.TabIndex = 6;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(11, 46);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(34, 13);
            this.TypeLabel.TabIndex = 2;
            this.TypeLabel.Text = "Type:";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Lossy",
            "Lossless"});
            this.TypeComboBox.Location = new System.Drawing.Point(107, 46);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(92, 21);
            this.TypeComboBox.TabIndex = 3;
            // 
            // ProgressionOrderComboBox
            // 
            this.ProgressionOrderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProgressionOrderComboBox.FormattingEnabled = true;
            this.ProgressionOrderComboBox.Items.AddRange(new object[] {
            "Default",
            "Layer, Resolution, Component, Position",
            "Resolution, Layer, Component, Position",
            "Resolution, Position, Component, Layer",
            "Position, Component, Resolution, Layer",
            "Component, Position, Resolution, Layer"});
            this.ProgressionOrderComboBox.Location = new System.Drawing.Point(106, 13);
            this.ProgressionOrderComboBox.Name = "ProgressionOrderComboBox";
            this.ProgressionOrderComboBox.Size = new System.Drawing.Size(240, 21);
            this.ProgressionOrderComboBox.TabIndex = 1;
            // 
            // GrayscaleCheckBox
            // 
            this.GrayscaleCheckBox.AutoSize = true;
            this.GrayscaleCheckBox.Location = new System.Drawing.Point(235, 48);
            this.GrayscaleCheckBox.Name = "GrayscaleCheckBox";
            this.GrayscaleCheckBox.Size = new System.Drawing.Size(73, 17);
            this.GrayscaleCheckBox.TabIndex = 4;
            this.GrayscaleCheckBox.Text = "Grayscale";
            this.GrayscaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // CompressSizeLabel
            // 
            this.CompressSizeLabel.AutoSize = true;
            this.CompressSizeLabel.Location = new System.Drawing.Point(11, 110);
            this.CompressSizeLabel.Name = "CompressSizeLabel";
            this.CompressSizeLabel.Size = new System.Drawing.Size(79, 13);
            this.CompressSizeLabel.TabIndex = 8;
            this.CompressSizeLabel.Text = "Compress Size:";
            // 
            // CompressSizeNumericUpDown
            // 
            this.CompressSizeNumericUpDown.Location = new System.Drawing.Point(107, 108);
            this.CompressSizeNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.CompressSizeNumericUpDown.Name = "CompressSizeNumericUpDown";
            this.CompressSizeNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.CompressSizeNumericUpDown.TabIndex = 9;
            // 
            // SaveOptionsJpeg2000Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 174);
            this.Controls.Add(this.Jpeg2000GroupBox);
            this.Name = "SaveOptionsJpeg2000Form";
            this.Text = "Save Options - JPEG2000";
            this.Load += new System.EventHandler(this.SaveOptionsJpeg2000Form_Load);
            this.Controls.SetChildIndex(this.Jpeg2000GroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.Jpeg2000GroupBox.ResumeLayout(false);
            this.Jpeg2000GroupBox.PerformLayout();
            this.TileGroupBox.ResumeLayout(false);
            this.TileGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TileHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeakSignalToNoiseRatioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompressSizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Jpeg2000GroupBox;
        private System.Windows.Forms.Label ProgressionOrderLabel;
        private System.Windows.Forms.GroupBox TileGroupBox;
        private System.Windows.Forms.NumericUpDown TileHeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown TileWidthNumericUpDown;
        private System.Windows.Forms.Label TileHeightLabel;
        private System.Windows.Forms.Label TileWidthLabel;
        private System.Windows.Forms.Label PeakSignalToNoiseRatioLabel;
        private System.Windows.Forms.NumericUpDown PeakSignalToNoiseRatioNumericUpDown;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox ProgressionOrderComboBox;
        private System.Windows.Forms.CheckBox GrayscaleCheckBox;
        private System.Windows.Forms.Label CompressSizeLabel;
        private System.Windows.Forms.NumericUpDown CompressSizeNumericUpDown;
    }
}