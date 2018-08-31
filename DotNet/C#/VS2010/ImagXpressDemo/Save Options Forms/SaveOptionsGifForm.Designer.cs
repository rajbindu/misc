namespace ImagXpressDemo
{
    partial class SaveOptionsGifForm
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
            this.GifGroupBox = new System.Windows.Forms.GroupBox();
            this.TransparencyColorLabel = new System.Windows.Forms.Label();
            this.TransparencyColorButton = new System.Windows.Forms.Button();
            this.GifTypeLabel = new System.Windows.Forms.Label();
            this.GifTypeComboBox = new System.Windows.Forms.ComboBox();
            this.TransparencyMatchLabel = new System.Windows.Forms.Label();
            this.TransparencyMatchComboBox = new System.Windows.Forms.ComboBox();
            this.InterlacedCheckBox = new System.Windows.Forms.CheckBox();
            this.GifGroupBox.SuspendLayout();
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
            // GifGroupBox
            // 
            this.GifGroupBox.Controls.Add(this.TransparencyColorLabel);
            this.GifGroupBox.Controls.Add(this.TransparencyColorButton);
            this.GifGroupBox.Controls.Add(this.GifTypeLabel);
            this.GifGroupBox.Controls.Add(this.GifTypeComboBox);
            this.GifGroupBox.Controls.Add(this.TransparencyMatchLabel);
            this.GifGroupBox.Controls.Add(this.TransparencyMatchComboBox);
            this.GifGroupBox.Controls.Add(this.InterlacedCheckBox);
            this.GifGroupBox.Location = new System.Drawing.Point(12, 12);
            this.GifGroupBox.Name = "GifGroupBox";
            this.GifGroupBox.Size = new System.Drawing.Size(366, 76);
            this.GifGroupBox.TabIndex = 0;
            this.GifGroupBox.TabStop = false;
            this.GifGroupBox.Text = "GIF";
            // 
            // TransparencyColorLabel
            // 
            this.TransparencyColorLabel.AutoSize = true;
            this.TransparencyColorLabel.Location = new System.Drawing.Point(220, 16);
            this.TransparencyColorLabel.Name = "TransparencyColorLabel";
            this.TransparencyColorLabel.Size = new System.Drawing.Size(102, 13);
            this.TransparencyColorLabel.TabIndex = 2;
            this.TransparencyColorLabel.Text = "Transparency Color:";
            // 
            // TransparencyColorButton
            // 
            this.TransparencyColorButton.BackColor = System.Drawing.Color.Turquoise;
            this.TransparencyColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransparencyColorButton.Location = new System.Drawing.Point(334, 11);
            this.TransparencyColorButton.Name = "TransparencyColorButton";
            this.TransparencyColorButton.Size = new System.Drawing.Size(23, 23);
            this.TransparencyColorButton.TabIndex = 3;
            this.TransparencyColorButton.UseVisualStyleBackColor = false;
            this.TransparencyColorButton.Click += new System.EventHandler(this.TransparencyColorButton_Click);
            // 
            // GifTypeLabel
            // 
            this.GifTypeLabel.AutoSize = true;
            this.GifTypeLabel.Location = new System.Drawing.Point(6, 45);
            this.GifTypeLabel.Name = "GifTypeLabel";
            this.GifTypeLabel.Size = new System.Drawing.Size(50, 13);
            this.GifTypeLabel.TabIndex = 4;
            this.GifTypeLabel.Text = "Gif Type:";
            // 
            // GifTypeComboBox
            // 
            this.GifTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GifTypeComboBox.FormattingEnabled = true;
            this.GifTypeComboBox.Items.AddRange(new object[] {
            "Gif89a",
            "Gif87a"});
            this.GifTypeComboBox.Location = new System.Drawing.Point(120, 41);
            this.GifTypeComboBox.Name = "GifTypeComboBox";
            this.GifTypeComboBox.Size = new System.Drawing.Size(85, 21);
            this.GifTypeComboBox.TabIndex = 5;
            // 
            // TransparencyMatchLabel
            // 
            this.TransparencyMatchLabel.AutoSize = true;
            this.TransparencyMatchLabel.Location = new System.Drawing.Point(6, 16);
            this.TransparencyMatchLabel.Name = "TransparencyMatchLabel";
            this.TransparencyMatchLabel.Size = new System.Drawing.Size(108, 13);
            this.TransparencyMatchLabel.TabIndex = 0;
            this.TransparencyMatchLabel.Text = "Transparency Match:";
            // 
            // TransparencyMatchComboBox
            // 
            this.TransparencyMatchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransparencyMatchComboBox.FormattingEnabled = true;
            this.TransparencyMatchComboBox.Items.AddRange(new object[] {
            "None",
            "Closeset",
            "Exact"});
            this.TransparencyMatchComboBox.Location = new System.Drawing.Point(120, 12);
            this.TransparencyMatchComboBox.Name = "TransparencyMatchComboBox";
            this.TransparencyMatchComboBox.Size = new System.Drawing.Size(85, 21);
            this.TransparencyMatchComboBox.TabIndex = 1;
            // 
            // InterlacedCheckBox
            // 
            this.InterlacedCheckBox.AutoSize = true;
            this.InterlacedCheckBox.Location = new System.Drawing.Point(223, 41);
            this.InterlacedCheckBox.Name = "InterlacedCheckBox";
            this.InterlacedCheckBox.Size = new System.Drawing.Size(73, 17);
            this.InterlacedCheckBox.TabIndex = 6;
            this.InterlacedCheckBox.Text = "Interlaced";
            this.InterlacedCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveOptionsGifForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 100);
            this.Controls.Add(this.GifGroupBox);
            this.Name = "SaveOptionsGifForm";
            this.Text = "Save Options - GIF";
            this.Load += new System.EventHandler(this.SaveOptionsGifForm_Load);
            this.Controls.SetChildIndex(this.GifGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelOptionsButton, 0);
            this.GifGroupBox.ResumeLayout(false);
            this.GifGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GifGroupBox;
        private System.Windows.Forms.Label GifTypeLabel;
        private System.Windows.Forms.ComboBox GifTypeComboBox;
        private System.Windows.Forms.Label TransparencyMatchLabel;
        private System.Windows.Forms.ComboBox TransparencyMatchComboBox;
        private System.Windows.Forms.CheckBox InterlacedCheckBox;
        private System.Windows.Forms.Label TransparencyColorLabel;
        private System.Windows.Forms.Button TransparencyColorButton;
    }
}