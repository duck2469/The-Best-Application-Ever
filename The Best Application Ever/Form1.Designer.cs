namespace The_Best_Application_Ever
{
    partial class BestWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestWindow));
            this.best_textlable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // best_textlable
            // 
            this.best_textlable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.best_textlable.Location = new System.Drawing.Point(0, 0);
            this.best_textlable.Name = "best_textlable";
            this.best_textlable.Size = new System.Drawing.Size(239, 176);
            this.best_textlable.TabIndex = 0;
            this.best_textlable.Text = "the name of this application is true you know.\r\n";
            this.best_textlable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(239, 176);
            this.Controls.Add(this.best_textlable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "BestWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Best Application Ever";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label best_textlable;
    }
}