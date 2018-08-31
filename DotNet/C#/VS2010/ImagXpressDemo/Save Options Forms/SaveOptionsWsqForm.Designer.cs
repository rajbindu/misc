namespace ImagXpressDemo
{
    partial class SaveOptionsWsqForm
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
            this.WsqGroupBox = new System.Windows.Forms.GroupBox();
            this.WhiteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BlackNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.QuantizationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.QuantizationLabel = new System.Windows.Forms.Label();
            this.BlackLabel = new System.Windows.Forms.Label();
            this.WhiteLabel = new System.Windows.Forms.Label();
            this.WsqGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantizationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.TabIndex = 1;
            // 
            // CancelOptionsButton
            // 
            this.CancelOptionsButton.TabIndex = 2;
            // 
            // WsqGroupBox
            // 
            this.WsqGroupBox.Controls.Add(this.WhiteNumericUpDown);
            this.WsqGroupBox.Controls.Add(this.BlackNumericUpDown);
            this.WsqGroupBox.Controls.Add(this.QuantizationNumericUpDown);
            this.WsqGroupBox.Controls.Add(this.QuantizationLabel);
            this.WsqGroupBox.Controls.Add(this.BlackLabel);
            this.WsqGroupBox.Controls.Add(this.WhiteLabel);
            this.WsqGroupBox.Location = new System.Drawing.Point(12, 12);
            this.WsqGroupBox.Name = "WsqGroupBox";
            this.WsqGroupBox.Size = new System.Drawing.Size(360, 52);
            this.WsqGroupBox.TabIndex = 0;
            this.WsqGroupBox.TabStop = false;
            this.WsqGroupBox.Text = "WSQ";
            // 
            // WhiteNumericUpDown
            // 
            this.WhiteNumericUpDown.Location = new System.Drawing.Point(56, 19);
            this.WhiteNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.WhiteNumericUpDown.Name = "WhiteNumericUpDown";
            this.WhiteNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.WhiteNumericUpDown.TabIndex = 1;
            this.WhiteNumericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // BlackNumericUpDown
            // 
            this.BlackNumericUpDown.Location = new System.Drawing.Point(159, 19);
            this.BlackNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlackNumericUpDown.Name = "BlackNumericUpDown";
            this.BlackNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.BlackNumericUpDown.TabIndex = 3;
            // 
            // QuantizationNumericUpDown
            // 
            this.QuantizationNumericUpDown.DecimalPlaces = 2;
            this.QuantizationNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.QuantizationNumericUpDown.Location = new System.Drawing.Point(294, 19);
            this.QuantizationNumericUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.QuantizationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.QuantizationNumericUpDown.Name = "QuantizationNumericUpDown";
            this.QuantizationNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.QuantizationNumericUpDown.TabIndex = 5;
            this.QuantizationNumericUpDown.Value = new decimal(new int[] {
            75,
            0,
            0,
            131072});
            // 
            // QuantizationLabel
            // 
            this.QuantizationLabel.AutoSize = true;
            this.QuantizationLabel.Location = new System.Drawing.Point(219, 23);
            this.QuantizationLabel.Name = "QuantizationLabel";
            this.QuantizationLabel.Size = new System.Drawing.Size(69, 13);
            this.QuantizationLabel.TabIndex = 4;
            this.QuantizationLabel.Text = "Quanitzation:";
            // 
            // BlackLabel
            // 
            this.BlackLabel.AutoSize = true;
            this.BlackLabel.Location = new System.Drawing.Point(116, 23);
            this.BlackLabel.Name = "BlackLabel";
            this.BlackLabel.Size = new System.Drawing.Size(37, 13);
            this.BlackLabel.TabIndex = 2;
            this.BlackLabel.Text = "Black:";
            // 
            // WhiteLabel
            // 
            this.WhiteLabel.AutoSize = true;
            this.WhiteLabel.Location = new System.Drawing.Point(12, 23);
            this.WhiteLabel.Name = "WhiteLabel";
            this.WhiteLabel.Size = new System.Drawing.Size(38, 13);
            this.WhiteLabel.TabIndex = 0;
            this.WhiteLabel.Text = "White:";
            // 
            // SaveOptionsWsqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 77);
            this.Controls.Add(this.WsqGroupBox);
            this.Name = "SaveOptionsWsqForm";
            this.Text = "Save Options - WSQ";
            this.Load += new System.EventHandler(this.SaveOptionsWsqForm_Load);
            this.Controls.SetChildIndex(this.WsqGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.WsqGroupBox.ResumeLayout(false);
            this.WsqGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantizationNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox WsqGroupBox;
        private System.Windows.Forms.NumericUpDown WhiteNumericUpDown;
        private System.Windows.Forms.NumericUpDown BlackNumericUpDown;
        private System.Windows.Forms.NumericUpDown QuantizationNumericUpDown;
        private System.Windows.Forms.Label QuantizationLabel;
        private System.Windows.Forms.Label BlackLabel;
        private System.Windows.Forms.Label WhiteLabel;
    }
}