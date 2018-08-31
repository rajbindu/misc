namespace ImagXpressDemo
{
    partial class IntensityAndSelectionForm
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
            this.IntensityAndSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectionComboBox = new System.Windows.Forms.ComboBox();
            this.IntensityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.IntensityLabel = new System.Windows.Forms.Label();
            this.BackgroundColorLabel = new System.Windows.Forms.Label();
            this.BackgroundColorButton = new System.Windows.Forms.Button();
            this.IntensityAndSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(373, 522);
            this.PreviewButton.TabIndex = 5;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(13, 522);
            this.OKButton.TabIndex = 4;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(653, 522);
            this.CancelProcessingButton.TabIndex = 6;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.TabIndex = 0;
            // 
            // IntensityAndSelectionGroupBox
            // 
            this.IntensityAndSelectionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IntensityAndSelectionGroupBox.Controls.Add(this.SelectionComboBox);
            this.IntensityAndSelectionGroupBox.Controls.Add(this.IntensityNumericUpDown);
            this.IntensityAndSelectionGroupBox.Controls.Add(this.SelectionLabel);
            this.IntensityAndSelectionGroupBox.Controls.Add(this.IntensityLabel);
            this.IntensityAndSelectionGroupBox.Controls.Add(this.BackgroundColorLabel);
            this.IntensityAndSelectionGroupBox.Controls.Add(this.BackgroundColorButton);
            this.IntensityAndSelectionGroupBox.Location = new System.Drawing.Point(12, 433);
            this.IntensityAndSelectionGroupBox.Name = "IntensityAndSelectionGroupBox";
            this.IntensityAndSelectionGroupBox.Size = new System.Drawing.Size(345, 85);
            this.IntensityAndSelectionGroupBox.TabIndex = 3;
            this.IntensityAndSelectionGroupBox.TabStop = false;
            // 
            // SelectionComboBox
            // 
            this.SelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectionComboBox.FormattingEnabled = true;
            this.SelectionComboBox.Location = new System.Drawing.Point(86, 50);
            this.SelectionComboBox.Name = "SelectionComboBox";
            this.SelectionComboBox.Size = new System.Drawing.Size(101, 21);
            this.SelectionComboBox.TabIndex = 3;
            // 
            // IntensityNumericUpDown
            // 
            this.IntensityNumericUpDown.Location = new System.Drawing.Point(138, 18);
            this.IntensityNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.IntensityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntensityNumericUpDown.Name = "IntensityNumericUpDown";
            this.IntensityNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.IntensityNumericUpDown.TabIndex = 1;
            this.IntensityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Location = new System.Drawing.Point(14, 54);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(54, 13);
            this.SelectionLabel.TabIndex = 2;
            this.SelectionLabel.Text = "Selection:";
            // 
            // IntensityLabel
            // 
            this.IntensityLabel.AutoSize = true;
            this.IntensityLabel.Location = new System.Drawing.Point(14, 22);
            this.IntensityLabel.Name = "IntensityLabel";
            this.IntensityLabel.Size = new System.Drawing.Size(49, 13);
            this.IntensityLabel.TabIndex = 0;
            this.IntensityLabel.Text = "Intensity:";
            // 
            // BackgroundColorLabel
            // 
            this.BackgroundColorLabel.AutoSize = true;
            this.BackgroundColorLabel.Location = new System.Drawing.Point(206, 22);
            this.BackgroundColorLabel.Name = "BackgroundColorLabel";
            this.BackgroundColorLabel.Size = new System.Drawing.Size(95, 13);
            this.BackgroundColorLabel.TabIndex = 13;
            this.BackgroundColorLabel.Text = "Background Color:";
            this.BackgroundColorLabel.Visible = false;
            // 
            // BackgroundColorButton
            // 
            this.BackgroundColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackgroundColorButton.Location = new System.Drawing.Point(313, 17);
            this.BackgroundColorButton.Name = "BackgroundColorButton";
            this.BackgroundColorButton.Size = new System.Drawing.Size(20, 23);
            this.BackgroundColorButton.TabIndex = 12;
            this.BackgroundColorButton.UseVisualStyleBackColor = true;
            this.BackgroundColorButton.Visible = false;
            this.BackgroundColorButton.Click += new System.EventHandler(this.BackgroundColorButton_Click);
            // 
            // IntensityAndSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 557);
            this.Controls.Add(this.IntensityAndSelectionGroupBox);
            this.Name = "IntensityAndSelectionForm";
            this.Text = "";
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.IntensityAndSelectionGroupBox, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.IntensityAndSelectionGroupBox.ResumeLayout(false);
            this.IntensityAndSelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox IntensityAndSelectionGroupBox;
        private System.Windows.Forms.ComboBox SelectionComboBox;
        private System.Windows.Forms.NumericUpDown IntensityNumericUpDown;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.Label IntensityLabel;
        private System.Windows.Forms.Label BackgroundColorLabel;
        private System.Windows.Forms.Button BackgroundColorButton;
    }
}