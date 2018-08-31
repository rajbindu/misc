namespace ImagXpressDemo
{
    partial class RemoveRedeyeForm
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
            if (imageXView1 != null)
            {
                this.imageXView1.MouseDown -= imageXView1_MouseDown;
                this.imageXView1.MouseMove -= imageXView1_MouseMove;
                this.imageXView1.MouseUp -= imageXView1_MouseUp;
            }
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
            this.RemoveRedEyeGroupBox = new System.Windows.Forms.GroupBox();
            this.PrecisionComboBox = new System.Windows.Forms.ComboBox();
            this.PrecisionLabel = new System.Windows.Forms.Label();
            this.UseRedEyeRectanglesCheckBox = new System.Windows.Forms.CheckBox();
            this.ShadeComboBox = new System.Windows.Forms.ComboBox();
            this.GlareComboBox = new System.Windows.Forms.ComboBox();
            this.ShadeLabel = new System.Windows.Forms.Label();
            this.GlareLabel = new System.Windows.Forms.Label();
            this.RedEyesListView = new System.Windows.Forms.ListView();
            this.XColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WidthColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeightColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConfidenceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MouseLabel = new System.Windows.Forms.Label();
            this.RemoveRedEyeGroupBox.SuspendLayout();
            this.SuspendLayout(); 
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(372, 573);
            this.PreviewButton.TabIndex = 5;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 573);
            this.OKButton.TabIndex = 4;
            // 
            // CancelProcessingButton
            // 
            this.CancelProcessingButton.Location = new System.Drawing.Point(652, 573);
            this.CancelProcessingButton.TabIndex = 6;
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.Location = new System.Drawing.Point(592, 433);
            this.RightClickLabel.TabIndex = 7;
            // 
            // RemoveRedEyeGroupBox
            // 
            this.RemoveRedEyeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveRedEyeGroupBox.Controls.Add(this.PrecisionComboBox);
            this.RemoveRedEyeGroupBox.Controls.Add(this.PrecisionLabel);
            this.RemoveRedEyeGroupBox.Controls.Add(this.UseRedEyeRectanglesCheckBox);
            this.RemoveRedEyeGroupBox.Controls.Add(this.ShadeComboBox);
            this.RemoveRedEyeGroupBox.Controls.Add(this.GlareComboBox);
            this.RemoveRedEyeGroupBox.Controls.Add(this.ShadeLabel);
            this.RemoveRedEyeGroupBox.Controls.Add(this.GlareLabel);
            this.RemoveRedEyeGroupBox.Location = new System.Drawing.Point(176, 433);
            this.RemoveRedEyeGroupBox.Name = "RemoveRedEyeGroupBox";
            this.RemoveRedEyeGroupBox.Size = new System.Drawing.Size(220, 137);
            this.RemoveRedEyeGroupBox.TabIndex = 2;
            this.RemoveRedEyeGroupBox.TabStop = false;
            // 
            // PrecisionComboBox
            // 
            this.PrecisionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrecisionComboBox.FormattingEnabled = true;
            this.PrecisionComboBox.Items.AddRange(new object[] {
            "Precise",
            "Imprecise",
            "Imprecise Ruddy"});
            this.PrecisionComboBox.Location = new System.Drawing.Point(84, 108);
            this.PrecisionComboBox.Name = "PrecisionComboBox";
            this.PrecisionComboBox.Size = new System.Drawing.Size(121, 21);
            this.PrecisionComboBox.TabIndex = 6;
            // 
            // PrecisionLabel
            // 
            this.PrecisionLabel.AutoSize = true;
            this.PrecisionLabel.Location = new System.Drawing.Point(17, 112);
            this.PrecisionLabel.Name = "PrecisionLabel";
            this.PrecisionLabel.Size = new System.Drawing.Size(53, 13);
            this.PrecisionLabel.TabIndex = 5;
            this.PrecisionLabel.Text = "Precision:";
            // 
            // UseRedEyeRectanglesCheckBox
            // 
            this.UseRedEyeRectanglesCheckBox.Location = new System.Drawing.Point(20, 75);
            this.UseRedEyeRectanglesCheckBox.Name = "UseRedEyeRectanglesCheckBox";
            this.UseRedEyeRectanglesCheckBox.Size = new System.Drawing.Size(185, 34);
            this.UseRedEyeRectanglesCheckBox.TabIndex = 4;
            this.UseRedEyeRectanglesCheckBox.Text = "Use Previously Detected Red Eye Rectangles";
            this.UseRedEyeRectanglesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShadeComboBox
            // 
            this.ShadeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShadeComboBox.FormattingEnabled = true;
            this.ShadeComboBox.Items.AddRange(new object[] {
            "Normal",
            "Light",
            "Dark"});
            this.ShadeComboBox.Location = new System.Drawing.Point(84, 48);
            this.ShadeComboBox.Name = "ShadeComboBox";
            this.ShadeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ShadeComboBox.TabIndex = 3;
            // 
            // GlareComboBox
            // 
            this.GlareComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GlareComboBox.FormattingEnabled = true;
            this.GlareComboBox.Items.AddRange(new object[] {
            "None",
            "Slight",
            "Full"});
            this.GlareComboBox.Location = new System.Drawing.Point(84, 20);
            this.GlareComboBox.Name = "GlareComboBox";
            this.GlareComboBox.Size = new System.Drawing.Size(121, 21);
            this.GlareComboBox.TabIndex = 1;
            // 
            // ShadeLabel
            // 
            this.ShadeLabel.AutoSize = true;
            this.ShadeLabel.Location = new System.Drawing.Point(17, 52);
            this.ShadeLabel.Name = "ShadeLabel";
            this.ShadeLabel.Size = new System.Drawing.Size(41, 13);
            this.ShadeLabel.TabIndex = 2;
            this.ShadeLabel.Text = "Shade:";
            // 
            // GlareLabel
            // 
            this.GlareLabel.AutoSize = true;
            this.GlareLabel.Location = new System.Drawing.Point(17, 24);
            this.GlareLabel.Name = "GlareLabel";
            this.GlareLabel.Size = new System.Drawing.Size(35, 13);
            this.GlareLabel.TabIndex = 0;
            this.GlareLabel.Text = "Glare:";
            // 
            // RedEyesListView
            // 
            this.RedEyesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RedEyesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.XColumnHeader,
            this.YColumnHeader,
            this.WidthColumnHeader,
            this.HeightColumnHeader,
            this.ConfidenceColumnHeader});
            this.RedEyesListView.Location = new System.Drawing.Point(402, 466);
            this.RedEyesListView.Name = "RedEyesListView";
            this.RedEyesListView.Size = new System.Drawing.Size(323, 102);
            this.RedEyesListView.TabIndex = 3;
            this.RedEyesListView.UseCompatibleStateImageBehavior = false;
            this.RedEyesListView.View = System.Windows.Forms.View.Details;
            // 
            // XColumnHeader
            // 
            this.XColumnHeader.Text = "X";
            // 
            // YColumnHeader
            // 
            this.YColumnHeader.Text = "Y";
            // 
            // WidthColumnHeader
            // 
            this.WidthColumnHeader.Text = "Width";
            // 
            // HeightColumnHeader
            // 
            this.HeightColumnHeader.Text = "Height";
            // 
            // ConfidenceColumnHeader
            // 
            this.ConfidenceColumnHeader.Text = "Confidence";
            this.ConfidenceColumnHeader.Width = 79;
            // 
            // MouseLabel
            // 
            this.MouseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MouseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MouseLabel.Location = new System.Drawing.Point(12, 440);
            this.MouseLabel.Name = "MouseLabel";
            this.MouseLabel.Size = new System.Drawing.Size(147, 28);
            this.MouseLabel.TabIndex = 8;
            this.MouseLabel.Text = "Please use the mouse to select an area.";
            // 
            // RemoveRedeyeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 608);
            this.Controls.Add(this.MouseLabel);
            this.Controls.Add(this.RemoveRedEyeGroupBox);
            this.Controls.Add(this.RedEyesListView);
            this.Name = "RemoveRedeyeForm";
            this.Text = "";
            this.Controls.SetChildIndex(this.RedEyesListView, 0);
            this.Controls.SetChildIndex(this.RemoveRedEyeGroupBox, 0);
            this.Controls.SetChildIndex(this.CancelProcessingButton, 0);
            this.Controls.SetChildIndex(this.PreviewButton, 0);
            this.Controls.SetChildIndex(this.MouseLabel, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.RightClickLabel, 0);
            this.RemoveRedEyeGroupBox.ResumeLayout(false);
            this.RemoveRedEyeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RemoveRedEyeGroupBox;
        private System.Windows.Forms.CheckBox UseRedEyeRectanglesCheckBox;
        private System.Windows.Forms.ComboBox ShadeComboBox;
        private System.Windows.Forms.ComboBox GlareComboBox;
        private System.Windows.Forms.Label ShadeLabel;
        private System.Windows.Forms.Label GlareLabel;
        private System.Windows.Forms.ListView RedEyesListView;
        private System.Windows.Forms.ColumnHeader XColumnHeader;
        private System.Windows.Forms.ColumnHeader YColumnHeader;
        private System.Windows.Forms.ColumnHeader WidthColumnHeader;
        private System.Windows.Forms.ColumnHeader HeightColumnHeader;
        private System.Windows.Forms.ColumnHeader ConfidenceColumnHeader;
        private System.Windows.Forms.ComboBox PrecisionComboBox;
        private System.Windows.Forms.Label PrecisionLabel;
        private System.Windows.Forms.Label MouseLabel;
    }
}