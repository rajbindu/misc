/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using Accusoft.ImagXpressSdk;

namespace ImagXpressDemo
{
    partial class ColorDepthForm
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
            this.BitsPerPixelComboBox = new System.Windows.Forms.ComboBox();
            this.PaletteTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DitherTypeComboBox = new System.Windows.Forms.ComboBox();
            this.BitsPerPixelLabel = new System.Windows.Forms.Label();
            this.PaletteTypeLabel = new System.Windows.Forms.Label();
            this.DitherTypeLabel = new System.Windows.Forms.Label();
            this.ColorDepthGroupBox = new System.Windows.Forms.GroupBox();
            this.ColorDepthGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(373, 507);
            this.PreviewButton.TabIndex = 5;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(13, 507);
            this.OKButton.TabIndex = 4;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(653, 507);
            this.CancelProcessingButton.TabIndex = 6;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.TabIndex = 3;
            // 
            // BitsPerPixelComboBox
            // 
            this.BitsPerPixelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitsPerPixelComboBox.FormattingEnabled = true;
            this.BitsPerPixelComboBox.Items.AddRange(new object[] {
            "1",
            "4",
            "8",
            "24"});
            this.BitsPerPixelComboBox.Location = new System.Drawing.Point(12, 34);
            this.BitsPerPixelComboBox.Name = "BitsPerPixelComboBox";
            this.BitsPerPixelComboBox.Size = new System.Drawing.Size(121, 21);
            this.BitsPerPixelComboBox.TabIndex = 3;
            this.BitsPerPixelComboBox.SelectedIndexChanged += new System.EventHandler(this.BitsPerPixelComboBox_SelectedIndexChanged);
            // 
            // PaletteTypeComboBox
            // 
            this.PaletteTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaletteTypeComboBox.FormattingEnabled = true;
            this.PaletteTypeComboBox.Items.AddRange(new object[] {
            "Optimized",
            "Fixed",
            "Gray"});
            this.PaletteTypeComboBox.Location = new System.Drawing.Point(158, 34);
            this.PaletteTypeComboBox.Name = "PaletteTypeComboBox";
            this.PaletteTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.PaletteTypeComboBox.TabIndex = 4;
            // 
            // DitherTypeComboBox
            // 
            this.DitherTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DitherTypeComboBox.FormattingEnabled = true;
            this.DitherTypeComboBox.Location = new System.Drawing.Point(304, 34);
            this.DitherTypeComboBox.Name = "DitherTypeComboBox";
            this.DitherTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.DitherTypeComboBox.TabIndex = 5;
            // 
            // BitsPerPixelLabel
            // 
            this.BitsPerPixelLabel.AutoSize = true;
            this.BitsPerPixelLabel.Location = new System.Drawing.Point(13, 15);
            this.BitsPerPixelLabel.Name = "BitsPerPixelLabel";
            this.BitsPerPixelLabel.Size = new System.Drawing.Size(71, 13);
            this.BitsPerPixelLabel.TabIndex = 0;
            this.BitsPerPixelLabel.Text = "Bits Per Pixel:";
            // 
            // PaletteTypeLabel
            // 
            this.PaletteTypeLabel.AutoSize = true;
            this.PaletteTypeLabel.Location = new System.Drawing.Point(155, 15);
            this.PaletteTypeLabel.Name = "PaletteTypeLabel";
            this.PaletteTypeLabel.Size = new System.Drawing.Size(70, 13);
            this.PaletteTypeLabel.TabIndex = 1;
            this.PaletteTypeLabel.Text = "Palette Type:";
            // 
            // DitherTypeLabel
            // 
            this.DitherTypeLabel.AutoSize = true;
            this.DitherTypeLabel.Location = new System.Drawing.Point(301, 15);
            this.DitherTypeLabel.Name = "DitherTypeLabel";
            this.DitherTypeLabel.Size = new System.Drawing.Size(65, 13);
            this.DitherTypeLabel.TabIndex = 2;
            this.DitherTypeLabel.Text = "Dither Type:";
            // 
            // ColorDepthGroupBox
            // 
            this.ColorDepthGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ColorDepthGroupBox.Controls.Add(this.BitsPerPixelLabel);
            this.ColorDepthGroupBox.Controls.Add(this.PaletteTypeComboBox);
            this.ColorDepthGroupBox.Controls.Add(this.DitherTypeComboBox);
            this.ColorDepthGroupBox.Controls.Add(this.BitsPerPixelComboBox);
            this.ColorDepthGroupBox.Controls.Add(this.PaletteTypeLabel);
            this.ColorDepthGroupBox.Controls.Add(this.DitherTypeLabel);
            this.ColorDepthGroupBox.Location = new System.Drawing.Point(12, 430);
            this.ColorDepthGroupBox.Name = "ColorDepthGroupBox";
            this.ColorDepthGroupBox.Size = new System.Drawing.Size(436, 71);
            this.ColorDepthGroupBox.TabIndex = 2;
            this.ColorDepthGroupBox.TabStop = false;
            this.ColorDepthGroupBox.Text = "Change Color Depth";
            // 
            // ColorDepthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 539);
            this.Controls.Add(this.ColorDepthGroupBox);
            this.Name = "ColorDepthForm";
            this.Text = "Color Depth";
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.ColorDepthGroupBox, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.ColorDepthGroupBox.ResumeLayout(false);
            this.ColorDepthGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BitsPerPixelComboBox;
        private System.Windows.Forms.ComboBox PaletteTypeComboBox;
        private System.Windows.Forms.ComboBox DitherTypeComboBox;
        private System.Windows.Forms.Label BitsPerPixelLabel;
        private System.Windows.Forms.Label PaletteTypeLabel;
        private System.Windows.Forms.Label DitherTypeLabel;
        private System.Windows.Forms.GroupBox ColorDepthGroupBox;
    }
}