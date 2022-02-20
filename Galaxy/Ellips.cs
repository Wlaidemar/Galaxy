using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galaxy;

namespace Galaxy
{
    public partial class Ellips : Form
    {
        public Ellips()
        {
            InitializeComponent();
            timerEllips.Interval = 50; 
            timerEllips.Enabled = true;
            timerEllips.Tick += timer1_Tick;
        }
        
        void timer1_Tick(object sender, EventArgs e)
        {
            progressBarEllips.PerformStep();
        }

        private void Ellips_Paint(object sender, PaintEventArgs e)
        {
            PrintGalaxy.PrintEllips(e, 12000);
        }
    }
}
