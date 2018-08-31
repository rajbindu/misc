namespace ImagXpressDemo
{
    partial class SaveOptionsLjpForm
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
            this.LjpGroupBox = new System.Windows.Forms.GroupBox();
            this.PredictorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PredictorLabel = new System.Windows.Forms.Label();
            this.MethodLabel = new System.Windows.Forms.Label();
            this.OrderNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.MethodComboBox = new System.Windows.Forms.ComboBox();
            this.LjpGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderNumericUpDown)).BeginInit();
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
            // LjpGroupBox
            // 
            this.LjpGroupBox.Controls.Add(this.PredictorNumericUpDown);
            this.LjpGroupBox.Controls.Add(this.PredictorLabel);
            this.LjpGroupBox.Controls.Add(this.MethodLabel);
            this.LjpGroupBox.Controls.Add(this.OrderNumericUpDown);
            this.LjpGroupBox.Controls.Add(this.TypeLabel);
            this.LjpGroupBox.Controls.Add(this.OrderLabel);
            this.LjpGroupBox.Controls.Add(this.TypeComboBox);
            this.LjpGroupBox.Controls.Add(this.MethodComboBox);
            this.LjpGroupBox.Location = new System.Drawing.Point(12, 12);
            this.LjpGroupBox.Name = "LjpGroupBox";
            this.LjpGroupBox.Size = new System.Drawing.Size(293, 94);
            this.LjpGroupBox.TabIndex = 0;
            this.LjpGroupBox.TabStop = false;
            this.LjpGroupBox.Text = "Lossless JPEG";
            // 
            // PredictorNumericUpDown
            // 
            this.PredictorNumericUpDown.Location = new System.Drawing.Point(221, 59);
            this.PredictorNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.PredictorNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PredictorNumericUpDown.Name = "PredictorNumericUpDown";
            this.PredictorNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.PredictorNumericUpDown.TabIndex = 7;
            this.PredictorNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PredictorLabel
            // 
            this.PredictorLabel.AutoSize = true;
            this.PredictorLabel.Location = new System.Drawing.Point(161, 61);
            this.PredictorLabel.Name = "PredictorLabel";
            this.PredictorLabel.Size = new System.Drawing.Size(52, 13);
            this.PredictorLabel.TabIndex = 6;
            this.PredictorLabel.Text = "Predictor:";
            // 
            // MethodLabel
            // 
            this.MethodLabel.AutoSize = true;
            this.MethodLabel.Location = new System.Drawing.Point(15, 27);
            this.MethodLabel.Name = "MethodLabel";
            this.MethodLabel.Size = new System.Drawing.Size(46, 13);
            this.MethodLabel.TabIndex = 0;
            this.MethodLabel.Text = "Method:";
            // 
            // OrderNumericUpDown
            // 
            this.OrderNumericUpDown.Location = new System.Drawing.Point(221, 25);
            this.OrderNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.OrderNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OrderNumericUpDown.Name = "OrderNumericUpDown";
            this.OrderNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.OrderNumericUpDown.TabIndex = 3;
            this.OrderNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(15, 61);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(34, 13);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "Type:";
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Location = new System.Drawing.Point(161, 27);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(36, 13);
            this.OrderLabel.TabIndex = 2;
            this.OrderLabel.Text = "Order:";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "RGB",
            "YCbCr"});
            this.TypeComboBox.Location = new System.Drawing.Point(64, 57);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(82, 21);
            this.TypeComboBox.TabIndex = 5;
            // 
            // MethodComboBox
            // 
            this.MethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MethodComboBox.FormattingEnabled = true;
            this.MethodComboBox.Items.AddRange(new object[] {
            "Jpeg",
            "Loco",
            "Ppmd"});
            this.MethodComboBox.Location = new System.Drawing.Point(64, 23);
            this.MethodComboBox.Name = "MethodComboBox";
            this.MethodComboBox.Size = new System.Drawing.Size(82, 21);
            this.MethodComboBox.TabIndex = 1;
            // 
            // SaveOptionsLjpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 117);
            this.Controls.Add(this.LjpGroupBox);
            this.Name = "SaveOptionsLjpForm";
            this.Text = "Save Options - Lossless JPEG";
            this.Load += new System.EventHandler(this.SaveOptionsLjpForm_Load);
            this.Controls.SetChildIndex(this.LjpGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.LjpGroupBox.ResumeLayout(false);
            this.LjpGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LjpGroupBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox MethodComboBox;
        private System.Windows.Forms.NumericUpDown PredictorNumericUpDown;
        private System.Windows.Forms.Label PredictorLabel;
        private System.Windows.Forms.Label MethodLabel;
        private System.Windows.Forms.NumericUpDown OrderNumericUpDown;
    }
}