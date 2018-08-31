namespace ImageReduce
{
    partial class OptionsForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.jpegQualityFactorLabel = new System.Windows.Forms.Label();
            this.jpegQualityFactorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TransformModeComboBox = new System.Windows.Forms.ComboBox();
            this.TransformModeLabel = new System.Windows.Forms.Label();
            this.jpegGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.jpegQualityFactorNumericUpDown)).BeginInit();
            this.jpegGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(88, 136);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(169, 136);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // jpegQualityFactorLabel
            // 
            this.jpegQualityFactorLabel.Location = new System.Drawing.Point(16, 25);
            this.jpegQualityFactorLabel.Name = "jpegQualityFactorLabel";
            this.jpegQualityFactorLabel.Size = new System.Drawing.Size(123, 13);
            this.jpegQualityFactorLabel.TabIndex = 14;
            this.jpegQualityFactorLabel.Text = "Quality Factor";
            // 
            // jpegQualityFactorNumericUpDown
            // 
            this.jpegQualityFactorNumericUpDown.Location = new System.Drawing.Point(19, 41);
            this.jpegQualityFactorNumericUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.jpegQualityFactorNumericUpDown.Name = "jpegQualityFactorNumericUpDown";
            this.jpegQualityFactorNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.jpegQualityFactorNumericUpDown.TabIndex = 15;
            this.jpegQualityFactorNumericUpDown.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // TransformModeComboBox
            // 
            this.TransformModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransformModeComboBox.FormattingEnabled = true;
            this.TransformModeComboBox.Items.AddRange(new object[] {
            "Do not transform",
            "To Progressive JPEG",
            "To Sequential JPEG"});
            this.TransformModeComboBox.Location = new System.Drawing.Point(19, 87);
            this.TransformModeComboBox.Name = "TransformModeComboBox";
            this.TransformModeComboBox.Size = new System.Drawing.Size(151, 21);
            this.TransformModeComboBox.TabIndex = 16;
            // 
            // TransformModeLabel
            // 
            this.TransformModeLabel.AutoSize = true;
            this.TransformModeLabel.Location = new System.Drawing.Point(16, 71);
            this.TransformModeLabel.Name = "TransformModeLabel";
            this.TransformModeLabel.Size = new System.Drawing.Size(87, 13);
            this.TransformModeLabel.TabIndex = 17;
            this.TransformModeLabel.Text = "Transform Mode:";
            // 
            // jpegGroupBox
            // 
            this.jpegGroupBox.Controls.Add(this.jpegQualityFactorNumericUpDown);
            this.jpegGroupBox.Controls.Add(this.TransformModeComboBox);
            this.jpegGroupBox.Controls.Add(this.jpegQualityFactorLabel);
            this.jpegGroupBox.Controls.Add(this.TransformModeLabel);
            this.jpegGroupBox.Location = new System.Drawing.Point(12, 12);
            this.jpegGroupBox.Name = "jpegGroupBox";
            this.jpegGroupBox.Size = new System.Drawing.Size(232, 118);
            this.jpegGroupBox.TabIndex = 16;
            this.jpegGroupBox.TabStop = false;
            this.jpegGroupBox.Text = "JPEG";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(256, 171);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.jpegGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jpegQualityFactorNumericUpDown)).EndInit();
            this.jpegGroupBox.ResumeLayout(false);
            this.jpegGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label jpegQualityFactorLabel;
        private System.Windows.Forms.NumericUpDown jpegQualityFactorNumericUpDown;
        private System.Windows.Forms.ComboBox TransformModeComboBox;
        private System.Windows.Forms.Label TransformModeLabel;
        private System.Windows.Forms.GroupBox jpegGroupBox;

    }
}