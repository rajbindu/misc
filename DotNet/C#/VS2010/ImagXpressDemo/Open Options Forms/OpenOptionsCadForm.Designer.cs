namespace ImagXpressDemo
{
    partial class OpenOptionsCadForm
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
            this.CadGroupBox = new System.Windows.Forms.GroupBox();
            this.PaperResolutionUnitsComboBox = new System.Windows.Forms.ComboBox();
            this.PaperLabel = new System.Windows.Forms.Label();
            this.PaperResolutionUnitsLabel = new System.Windows.Forms.Label();
            this.PaperYResolutionLabel = new System.Windows.Forms.Label();
            this.PaperResolutionXLabel = new System.Windows.Forms.Label();
            this.PaperResolutionYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PaperResolutionXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PaperWidthLabel = new System.Windows.Forms.Label();
            this.PaperWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PaperHeightLabel = new System.Windows.Forms.Label();
            this.PaperBitDepthLabel = new System.Windows.Forms.Label();
            this.PaperHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PaperBitDepthNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LayoutToRenderLabel = new System.Windows.Forms.Label();
            this.LayoutToRenderNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).BeginInit();
            this.CadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaperResolutionYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperResolutionXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperBitDepthNumbericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutToRenderNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.TabIndex = 10;
            // 
            // CancelOptionsButton
            // 
            this.CancelOptionsButton.TabIndex = 11;
            // 
            // RotationComboBox
            // 
            this.RotationComboBox.TabIndex = 6;
            // 
            // RotationLabel
            // 
            this.RotationLabel.TabIndex = 5;
            // 
            // ImageOffsetNumericUpDown
            // 
            this.ImageOffsetNumericUpDown.TabIndex = 8;
            // 
            // CadGroupBox
            // 
            this.CadGroupBox.Controls.Add(this.PaperResolutionUnitsComboBox);
            this.CadGroupBox.Controls.Add(this.PaperLabel);
            this.CadGroupBox.Controls.Add(this.PaperResolutionUnitsLabel);
            this.CadGroupBox.Controls.Add(this.PaperYResolutionLabel);
            this.CadGroupBox.Controls.Add(this.PaperResolutionXLabel);
            this.CadGroupBox.Controls.Add(this.PaperResolutionYNumericUpDown);
            this.CadGroupBox.Controls.Add(this.PaperResolutionXNumericUpDown);
            this.CadGroupBox.Controls.Add(this.PaperWidthLabel);
            this.CadGroupBox.Controls.Add(this.PaperWidthNumericUpDown);
            this.CadGroupBox.Controls.Add(this.PaperHeightLabel);
            this.CadGroupBox.Controls.Add(this.PaperBitDepthLabel);
            this.CadGroupBox.Controls.Add(this.PaperHeightNumericUpDown);
            this.CadGroupBox.Controls.Add(this.PaperBitDepthNumbericUpDown);
            this.CadGroupBox.Controls.Add(this.LayoutToRenderLabel);
            this.CadGroupBox.Controls.Add(this.LayoutToRenderNumericUpDown);
            this.CadGroupBox.Location = new System.Drawing.Point(12, 204);
            this.CadGroupBox.Name = "CadGroupBox";
            this.CadGroupBox.Size = new System.Drawing.Size(387, 159);
            this.CadGroupBox.TabIndex = 9;
            this.CadGroupBox.TabStop = false;
            this.CadGroupBox.Text = "CAD";
            // 
            // PaperResolutionUnitsComboBox
            // 
            this.PaperResolutionUnitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaperResolutionUnitsComboBox.FormattingEnabled = true;
            this.PaperResolutionUnitsComboBox.Items.AddRange(new object[] {
            "None",
            "Inch",
            "Cm"});
            this.PaperResolutionUnitsComboBox.Location = new System.Drawing.Point(285, 93);
            this.PaperResolutionUnitsComboBox.Name = "PaperResolutionUnitsComboBox";
            this.PaperResolutionUnitsComboBox.Size = new System.Drawing.Size(92, 21);
            this.PaperResolutionUnitsComboBox.TabIndex = 12;
            // 
            // PaperLabel
            // 
            this.PaperLabel.AutoSize = true;
            this.PaperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaperLabel.Location = new System.Drawing.Point(19, 16);
            this.PaperLabel.Name = "PaperLabel";
            this.PaperLabel.Size = new System.Drawing.Size(40, 13);
            this.PaperLabel.TabIndex = 0;
            this.PaperLabel.Text = "Paper";
            // 
            // PaperResolutionUnitsLabel
            // 
            this.PaperResolutionUnitsLabel.AutoSize = true;
            this.PaperResolutionUnitsLabel.Location = new System.Drawing.Point(177, 97);
            this.PaperResolutionUnitsLabel.Name = "PaperResolutionUnitsLabel";
            this.PaperResolutionUnitsLabel.Size = new System.Drawing.Size(87, 13);
            this.PaperResolutionUnitsLabel.TabIndex = 11;
            this.PaperResolutionUnitsLabel.Text = "Resolution Units:";
            // 
            // PaperYResolutionLabel
            // 
            this.PaperYResolutionLabel.AutoSize = true;
            this.PaperYResolutionLabel.Location = new System.Drawing.Point(177, 70);
            this.PaperYResolutionLabel.Name = "PaperYResolutionLabel";
            this.PaperYResolutionLabel.Size = new System.Drawing.Size(70, 13);
            this.PaperYResolutionLabel.TabIndex = 7;
            this.PaperYResolutionLabel.Text = "Resolution Y:";
            // 
            // PaperResolutionXLabel
            // 
            this.PaperResolutionXLabel.AutoSize = true;
            this.PaperResolutionXLabel.Location = new System.Drawing.Point(177, 43);
            this.PaperResolutionXLabel.Name = "PaperResolutionXLabel";
            this.PaperResolutionXLabel.Size = new System.Drawing.Size(70, 13);
            this.PaperResolutionXLabel.TabIndex = 3;
            this.PaperResolutionXLabel.Text = "Resolution X:";
            // 
            // PaperResolutionYNumericUpDown
            // 
            this.PaperResolutionYNumericUpDown.Location = new System.Drawing.Point(285, 66);
            this.PaperResolutionYNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PaperResolutionYNumericUpDown.Name = "PaperResolutionYNumericUpDown";
            this.PaperResolutionYNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.PaperResolutionYNumericUpDown.TabIndex = 8;
            // 
            // PaperResolutionXNumericUpDown
            // 
            this.PaperResolutionXNumericUpDown.Location = new System.Drawing.Point(285, 39);
            this.PaperResolutionXNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PaperResolutionXNumericUpDown.Name = "PaperResolutionXNumericUpDown";
            this.PaperResolutionXNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.PaperResolutionXNumericUpDown.TabIndex = 4;
            // 
            // PaperWidthLabel
            // 
            this.PaperWidthLabel.AutoSize = true;
            this.PaperWidthLabel.Location = new System.Drawing.Point(19, 97);
            this.PaperWidthLabel.Name = "PaperWidthLabel";
            this.PaperWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.PaperWidthLabel.TabIndex = 9;
            this.PaperWidthLabel.Text = "Width:";
            // 
            // PaperWidthNumericUpDown
            // 
            this.PaperWidthNumericUpDown.Location = new System.Drawing.Point(127, 93);
            this.PaperWidthNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PaperWidthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PaperWidthNumericUpDown.Name = "PaperWidthNumericUpDown";
            this.PaperWidthNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.PaperWidthNumericUpDown.TabIndex = 10;
            this.PaperWidthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PaperHeightLabel
            // 
            this.PaperHeightLabel.AutoSize = true;
            this.PaperHeightLabel.Location = new System.Drawing.Point(19, 70);
            this.PaperHeightLabel.Name = "PaperHeightLabel";
            this.PaperHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.PaperHeightLabel.TabIndex = 5;
            this.PaperHeightLabel.Text = "Height:";
            // 
            // PaperBitDepthLabel
            // 
            this.PaperBitDepthLabel.AutoSize = true;
            this.PaperBitDepthLabel.Location = new System.Drawing.Point(19, 43);
            this.PaperBitDepthLabel.Name = "PaperBitDepthLabel";
            this.PaperBitDepthLabel.Size = new System.Drawing.Size(54, 13);
            this.PaperBitDepthLabel.TabIndex = 1;
            this.PaperBitDepthLabel.Text = "Bit Depth:";
            // 
            // PaperHeightNumericUpDown
            // 
            this.PaperHeightNumericUpDown.Location = new System.Drawing.Point(127, 66);
            this.PaperHeightNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PaperHeightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PaperHeightNumericUpDown.Name = "PaperHeightNumericUpDown";
            this.PaperHeightNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.PaperHeightNumericUpDown.TabIndex = 6;
            this.PaperHeightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PaperBitDepthNumbericUpDown
            // 
            this.PaperBitDepthNumbericUpDown.Location = new System.Drawing.Point(127, 39);
            this.PaperBitDepthNumbericUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.PaperBitDepthNumbericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PaperBitDepthNumbericUpDown.Name = "PaperBitDepthNumbericUpDown";
            this.PaperBitDepthNumbericUpDown.Size = new System.Drawing.Size(44, 20);
            this.PaperBitDepthNumbericUpDown.TabIndex = 2;
            this.PaperBitDepthNumbericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LayoutToRenderLabel
            // 
            this.LayoutToRenderLabel.AutoSize = true;
            this.LayoutToRenderLabel.Location = new System.Drawing.Point(19, 124);
            this.LayoutToRenderLabel.Name = "LayoutToRenderLabel";
            this.LayoutToRenderLabel.Size = new System.Drawing.Size(96, 13);
            this.LayoutToRenderLabel.TabIndex = 13;
            this.LayoutToRenderLabel.Text = "Layout To Render:";
            // 
            // LayoutToRenderNumericUpDown
            // 
            this.LayoutToRenderNumericUpDown.Location = new System.Drawing.Point(127, 120);
            this.LayoutToRenderNumericUpDown.Name = "LayoutToRenderNumericUpDown";
            this.LayoutToRenderNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.LayoutToRenderNumericUpDown.TabIndex = 14;
            // 
            // OpenOptionsCadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 374);
            this.Controls.Add(this.CadGroupBox);
            this.Name = "OpenOptionsCadForm";
            this.Text = "Open Options - CAD";
            this.Load += new System.EventHandler(this.OpenOptionsCadForm_Load);
            this.Controls.SetChildIndex(this.RotationLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetNumericUpDown, 0);
            this.Controls.SetChildIndex(this.CadGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.RotationComboBox, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).EndInit();
            this.CadGroupBox.ResumeLayout(false);
            this.CadGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaperResolutionYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperResolutionXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperBitDepthNumbericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutToRenderNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CadGroupBox;
        private System.Windows.Forms.Label PaperYResolutionLabel;
        private System.Windows.Forms.Label PaperResolutionXLabel;
        private System.Windows.Forms.NumericUpDown PaperResolutionYNumericUpDown;
        private System.Windows.Forms.NumericUpDown PaperResolutionXNumericUpDown;
        private System.Windows.Forms.Label PaperWidthLabel;
        private System.Windows.Forms.NumericUpDown PaperWidthNumericUpDown;
        private System.Windows.Forms.Label PaperHeightLabel;
        private System.Windows.Forms.Label PaperBitDepthLabel;
        private System.Windows.Forms.NumericUpDown PaperHeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown PaperBitDepthNumbericUpDown;
        private System.Windows.Forms.Label LayoutToRenderLabel;
        private System.Windows.Forms.NumericUpDown LayoutToRenderNumericUpDown;
        private System.Windows.Forms.Label PaperResolutionUnitsLabel;
        private System.Windows.Forms.Label PaperLabel;
        private System.Windows.Forms.ComboBox PaperResolutionUnitsComboBox;
    }
}