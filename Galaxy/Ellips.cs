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
        }
        Random random = new Random();
        private void Ellips_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 599; i++)
            {
                for (int j = 0; j < 599; j++)
                {
                    double result = random.NextDouble();
                    if (result <= Engine.Functional(Engine.DistanceToTheCenter(i, j), 13000))
                    {
                        e.Graphics.FillRectangle(Brushes.White, i, j, 1, 1);
                    }
                }
            }
        }
    }
}
