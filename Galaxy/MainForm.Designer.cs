namespace Galaxy
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ellipsLabel = new System.Windows.Forms.Label();
            this.mindalLabel = new System.Windows.Forms.Label();
            this.spiralLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ellipsLabel
            // 
            this.ellipsLabel.AutoSize = true;
            this.ellipsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ellipsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellipsLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ellipsLabel.ForeColor = System.Drawing.Color.White;
            this.ellipsLabel.Location = new System.Drawing.Point(50, 66);
            this.ellipsLabel.Name = "ellipsLabel";
            this.ellipsLabel.Size = new System.Drawing.Size(168, 23);
            this.ellipsLabel.TabIndex = 0;
            this.ellipsLabel.Text = "Эллиптическая";
            this.ellipsLabel.Click += new System.EventHandler(this.ellipsLabel_Click);
            this.ellipsLabel.MouseLeave += new System.EventHandler(this.ellipsLabel_MouseLeave);
            this.ellipsLabel.MouseHover += new System.EventHandler(this.ellipsLabel_MouseHover);
            // 
            // mindalLabel
            // 
            this.mindalLabel.AutoSize = true;
            this.mindalLabel.BackColor = System.Drawing.Color.Transparent;
            this.mindalLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mindalLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mindalLabel.ForeColor = System.Drawing.Color.White;
            this.mindalLabel.Location = new System.Drawing.Point(431, 66);
            this.mindalLabel.Name = "mindalLabel";
            this.mindalLabel.Size = new System.Drawing.Size(176, 23);
            this.mindalLabel.TabIndex = 1;
            this.mindalLabel.Text = "Миндалевидная";
            this.mindalLabel.MouseLeave += new System.EventHandler(this.mindalLabel_MouseLeave);
            this.mindalLabel.MouseHover += new System.EventHandler(this.mindalLabel_MouseHover);
            // 
            // spiralLabel
            // 
            this.spiralLabel.AutoSize = true;
            this.spiralLabel.BackColor = System.Drawing.Color.Transparent;
            this.spiralLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spiralLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spiralLabel.ForeColor = System.Drawing.Color.White;
            this.spiralLabel.Location = new System.Drawing.Point(824, 66);
            this.spiralLabel.Name = "spiralLabel";
            this.spiralLabel.Size = new System.Drawing.Size(134, 23);
            this.spiralLabel.TabIndex = 2;
            this.spiralLabel.Text = "Спиральная";
            this.spiralLabel.MouseLeave += new System.EventHandler(this.spiralLabel_MouseLeave);
            this.spiralLabel.MouseHover += new System.EventHandler(this.spiralLabel_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.spiralLabel);
            this.Controls.Add(this.mindalLabel);
            this.Controls.Add(this.ellipsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galaxy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ellipsLabel;
        private System.Windows.Forms.Label mindalLabel;
        private System.Windows.Forms.Label spiralLabel;
    }
}

