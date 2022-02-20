using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaxy
{
    public class PrintGalaxy
    {
        public static void PrintEllips(PaintEventArgs e, double r)
        {
            Random random = new Random();
            for (int i = 0; i < 599; i++)
            {
                for (int j = 0; j < 599; j++)
                {

                    double result = random.NextDouble();
                    double functional = Engine.FunctionalEllips(i, j, r);
                    if (result <= functional)
                    {
                        e.Graphics.FillRectangle(Brushes.White, i, j, 1, 1);
                    }
                }
            }
        }
        public static void PrintMindal(PaintEventArgs e, double a, double b)
        {
            Random random = new Random();
            for (int i = 0; i < 599; i++)
            {
                for (int j = 0; j < 599; j++)
                {

                    double result = random.NextDouble();
                    double functional = Engine.FunctionalMindal(i, j, a, b);
                    if (result <= functional)
                    {
                        e.Graphics.FillRectangle(Brushes.White, i, j, 1, 1);
                    }
                }
            }
        }

    }
}
