namespace ImagXpressDemo
{
    partial class CommentsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentsListForm));
            this.CommentsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // CommentsListView
            // 
            this.CommentsListView.Location = new System.Drawing.Point(12, 12);
            this.CommentsListView.Name = "CommentsListView";
            this.CommentsListView.Size = new System.Drawing.Size(496, 308);
            this.CommentsListView.TabIndex = 2;
            this.CommentsListView.UseCompatibleStateImageBehavior = false;
            this.CommentsListView.View = System.Windows.Forms.View.Details;
            // 
            // CommentsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 361);
            this.Controls.Add(this.CommentsListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CommentsListForm";
            this.Load += new System.EventHandler(this.CommentsListForm_Load);
            this.Controls.SetChildIndex(this.CommentsListView, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CommentsListView;
    }
}