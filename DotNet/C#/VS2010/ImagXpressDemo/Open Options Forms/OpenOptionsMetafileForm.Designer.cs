namespace ImagXpressDemo
{
    partial class OpenOptionsMetafileForm
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
            this.MetafileGroupBox = new System.Windows.Forms.GroupBox();
            this.ResolutionUnitsComboBox = new System.Windows.Forms.ComboBox();
            this.ResolutionYLabel = new System.Windows.Forms.Label();
            this.ResolutionXLabel = new System.Windows.Forms.Label();
            this.ResolutionXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ResolutionYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).BeginInit();
            this.MetafileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionYNumericUpDown)).BeginInit();
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
            // MetafileGroupBox
            // 
            this.MetafileGroupBox.Controls.Add(this.ResolutionUnitsComboBox);
            this.MetafileGroupBox.Controls.Add(this.ResolutionYLabel);
            this.MetafileGroupBox.Controls.Add(this.ResolutionXLabel);
            this.MetafileGroupBox.Controls.Add(this.ResolutionXNumericUpDown);
            this.MetafileGroupBox.Controls.Add(this.ResolutionYNumericUpDown);
            this.MetafileGroupBox.Location = new System.Drawing.Point(9, 200);
            this.MetafileGroupBox.Name = "MetafileGroupBox";
            this.MetafileGroupBox.Size = new System.Drawing.Size(266, 56);
            this.MetafileGroupBox.TabIndex = 9;
            this.MetafileGroupBox.TabStop = false;
            this.MetafileGroupBox.Text = "Metafile Resolution";
            // 
            // ResolutionUnitsComboBox
            // 
            this.ResolutionUnitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionUnitsComboBox.FormattingEnabled = true;
            this.ResolutionUnitsComboBox.Items.AddRange(new object[] {
            "Inch",
            "Centimeter",
            "Meter"});
            this.ResolutionUnitsComboBox.Location = new System.Drawing.Point(155, 22);
            this.ResolutionUnitsComboBox.Name = "ResolutionUnitsComboBox";
            this.ResolutionUnitsComboBox.Size = new System.Drawing.Size(96, 21);
            this.ResolutionUnitsComboBox.TabIndex = 4;
            // 
            // ResolutionYLabel
            // 
            this.ResolutionYLabel.AutoSize = true;
            this.ResolutionYLabel.Location = new System.Drawing.Point(83, 26);
            this.ResolutionYLabel.Name = "ResolutionYLabel";
            this.ResolutionYLabel.Size = new System.Drawing.Size(17, 13);
            this.ResolutionYLabel.TabIndex = 2;
            this.ResolutionYLabel.Text = "Y:";
            // 
            // ResolutionXLabel
            // 
            this.ResolutionXLabel.AutoSize = true;
            this.ResolutionXLabel.Location = new System.Drawing.Point(15, 26);
            this.ResolutionXLabel.Name = "ResolutionXLabel";
            this.ResolutionXLabel.Size = new System.Drawing.Size(17, 13);
            this.ResolutionXLabel.TabIndex = 0;
            this.ResolutionXLabel.Text = "X:";
            // 
            // ResolutionXNumericUpDown
            // 
            this.ResolutionXNumericUpDown.Location = new System.Drawing.Point(34, 22);
            this.ResolutionXNumericUpDown.Name = "ResolutionXNumericUpDown";
            this.ResolutionXNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.ResolutionXNumericUpDown.TabIndex = 1;
            // 
            // ResolutionYNumericUpDown
            // 
            this.ResolutionYNumericUpDown.Location = new System.Drawing.Point(102, 22);
            this.ResolutionYNumericUpDown.Name = "ResolutionYNumericUpDown";
            this.ResolutionYNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.ResolutionYNumericUpDown.TabIndex = 3;
            // 
            // OpenOptionsMetafileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 264);
            this.Controls.Add(this.MetafileGroupBox);
            this.Name = "OpenOptionsMetafileForm";
            this.Text = "Open Options - Metafile";
            this.Load += new System.EventHandler(this.OpenOptionsMetafileForm_Load);
            this.Controls.SetChildIndex(this.RotationLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetLabel, 0);
            this.Controls.SetChildIndex(this.ImageOffsetNumericUpDown, 0);
            this.Controls.SetChildIndex(this.MetafileGroupBox, 0);
            this.Controls.SetChildIndex(this.RotationComboBox, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.CropXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CropYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOffsetNumericUpDown)).EndInit();
            this.MetafileGroupBox.ResumeLayout(false);
            this.MetafileGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionYNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MetafileGroupBox;
        private System.Windows.Forms.ComboBox ResolutionUnitsComboBox;
        private System.Windows.Forms.Label ResolutionYLabel;
        private System.Windows.Forms.Label ResolutionXLabel;
        private System.Windows.Forms.NumericUpDown ResolutionXNumericUpDown;
        private System.Windows.Forms.NumericUpDown ResolutionYNumericUpDown;
    }
}