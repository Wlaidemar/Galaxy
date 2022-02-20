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
    public partial class Mindal : Form
    {
        public Mindal()
        {
            InitializeComponent();
        }

        private void Mindal_Paint(object sender, PaintEventArgs e)
        {
            PrintGalaxy.PrintMindal(e, 20, 120);
        }
    }
}
