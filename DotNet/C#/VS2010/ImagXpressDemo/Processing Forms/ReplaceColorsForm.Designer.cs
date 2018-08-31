namespace ImagXpressDemo
{
    partial class ReplaceColorsForm
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
            this.FromColorButton = new System.Windows.Forms.Button();
            this.ToColorButton = new System.Windows.Forms.Button();
            this.ReplaceColorButton = new System.Windows.Forms.Button();
            this.FromColorLabel = new System.Windows.Forms.Label();
            this.ToColorLabel = new System.Windows.Forms.Label();
            this.WithColorLabel = new System.Windows.Forms.Label();
            this.ReplaceColorsGroupBox = new System.Windows.Forms.GroupBox();
            this.ReplaceColorsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(373, 509);
            this.PreviewButton.TabIndex = 4;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(13, 509);
            this.OKButton.TabIndex = 3;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(653, 509);
            this.CancelProcessingButton.TabIndex = 5;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.Location = new System.Drawing.Point(592, 456);
            this.RightClickLabel.TabIndex = 6;
            // 
            // FromColorButton
            // 
            this.FromColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FromColorButton.Location = new System.Drawing.Point(9, 32);
            this.FromColorButton.Name = "FromColorButton";
            this.FromColorButton.Size = new System.Drawing.Size(20, 23);
            this.FromColorButton.TabIndex = 3;
            this.FromColorButton.UseVisualStyleBackColor = true;
            this.FromColorButton.Click += new System.EventHandler(this.FromColorButton_Click);
            // 
            // ToColorButton
            // 
            this.ToColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToColorButton.Location = new System.Drawing.Point(57, 32);
            this.ToColorButton.Name = "ToColorButton";
            this.ToColorButton.Size = new System.Drawing.Size(20, 23);
            this.ToColorButton.TabIndex = 4;
            this.ToColorButton.UseVisualStyleBackColor = true;
            this.ToColorButton.Click += new System.EventHandler(this.ToColorButton_Click);
            // 
            // ReplaceColorButton
            // 
            this.ReplaceColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplaceColorButton.Location = new System.Drawing.Point(105, 32);
            this.ReplaceColorButton.Name = "ReplaceColorButton";
            this.ReplaceColorButton.Size = new System.Drawing.Size(20, 23);
            this.ReplaceColorButton.TabIndex = 5;
            this.ReplaceColorButton.UseVisualStyleBackColor = true;
            this.ReplaceColorButton.Click += new System.EventHandler(this.ReplaceColorButton_Click);
            // 
            // FromColorLabel
            // 
            this.FromColorLabel.AutoSize = true;
            this.FromColorLabel.Location = new System.Drawing.Point(6, 16);
            this.FromColorLabel.Name = "FromColorLabel";
            this.FromColorLabel.Size = new System.Drawing.Size(33, 13);
            this.FromColorLabel.TabIndex = 0;
            this.FromColorLabel.Text = "From:";
            // 
            // ToColorLabel
            // 
            this.ToColorLabel.AutoSize = true;
            this.ToColorLabel.Location = new System.Drawing.Point(53, 16);
            this.ToColorLabel.Name = "ToColorLabel";
            this.ToColorLabel.Size = new System.Drawing.Size(23, 13);
            this.ToColorLabel.TabIndex = 1;
            this.ToColorLabel.Text = "To:";
            // 
            // WithColorLabel
            // 
            this.WithColorLabel.AutoSize = true;
            this.WithColorLabel.Location = new System.Drawing.Point(102, 16);
            this.WithColorLabel.Name = "WithColorLabel";
            this.WithColorLabel.Size = new System.Drawing.Size(32, 13);
            this.WithColorLabel.TabIndex = 2;
            this.WithColorLabel.Text = "With:";
            // 
            // ReplaceColorsGroupBox
            // 
            this.ReplaceColorsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReplaceColorsGroupBox.Controls.Add(this.FromColorLabel);
            this.ReplaceColorsGroupBox.Controls.Add(this.FromColorButton);
            this.ReplaceColorsGroupBox.Controls.Add(this.WithColorLabel);
            this.ReplaceColorsGroupBox.Controls.Add(this.ToColorLabel);
            this.ReplaceColorsGroupBox.Controls.Add(this.ReplaceColorButton);
            this.ReplaceColorsGroupBox.Controls.Add(this.ToColorButton);
            this.ReplaceColorsGroupBox.Location = new System.Drawing.Point(12, 433);
            this.ReplaceColorsGroupBox.Name = "ReplaceColorsGroupBox";
            this.ReplaceColorsGroupBox.Size = new System.Drawing.Size(138, 65);
            this.ReplaceColorsGroupBox.TabIndex = 2;
            this.ReplaceColorsGroupBox.TabStop = false;
            this.ReplaceColorsGroupBox.Text = "Replace Color Range";
            // 
            // ReplaceColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 544);
            this.Controls.Add(this.ReplaceColorsGroupBox);
            this.Name = "ReplaceColorsForm";
            this.Text = "Replace Colors";
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.ReplaceColorsGroupBox, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.ReplaceColorsGroupBox.ResumeLayout(false);
            this.ReplaceColorsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FromColorButton;
        private System.Windows.Forms.Button ToColorButton;
        private System.Windows.Forms.Button ReplaceColorButton;
        private System.Windows.Forms.Label FromColorLabel;
        private System.Windows.Forms.Label ToColorLabel;
        private System.Windows.Forms.Label WithColorLabel;
        private System.Windows.Forms.GroupBox ReplaceColorsGroupBox;
    }
}