using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaxy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ellipsLabel_MouseHover(object sender, EventArgs e)
        {
            ellipsLabel.ForeColor = Color.DarkGray;
        }

        private void ellipsLabel_MouseLeave(object sender, EventArgs e)
        {
            ellipsLabel.ForeColor = Color.White;
        }

        private void mindalLabel_MouseHover(object sender, EventArgs e)
        {
            mindalLabel.ForeColor = Color.DarkGray;
        }

        private void mindalLabel_MouseLeave(object sender, EventArgs e)
        {
            mindalLabel.ForeColor = Color.White;
        }

        private void spiralLabel_MouseHover(object sender, EventArgs e)
        {
            spiralLabel.ForeColor = Color.DarkGray;
        }

        private void spiralLabel_MouseLeave(object sender, EventArgs e)
        {
            spiralLabel.ForeColor = Color.White;
        }

        private void ellipsLabel_Click(object sender, EventArgs e)
        {
            
            Ellips ellips = new Ellips();
            ellips.Show();
        }
    }
}
