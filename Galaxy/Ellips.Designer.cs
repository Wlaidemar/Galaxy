namespace Galaxy
{
    partial class Ellips
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ellips));
            this.progressBarEllips = new System.Windows.Forms.ProgressBar();
            this.timerEllips = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBarEllips
            // 
            this.progressBarEllips.BackColor = System.Drawing.Color.Black;
            this.progressBarEllips.ForeColor = System.Drawing.Color.Transparent;
            this.progressBarEllips.Location = new System.Drawing.Point(120, 490);
            this.progressBarEllips.Name = "progressBarEllips";
            this.progressBarEllips.Size = new System.Drawing.Size(328, 10);
            this.progressBarEllips.TabIndex = 0;
            // 
            // Ellips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.progressBarEllips);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ellips";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ellips";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Ellips_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarEllips;
        private System.Windows.Forms.Timer timerEllips;
    }
}