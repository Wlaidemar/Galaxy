using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaxy
{
    public class Engine
    {
        private static int originX = 300;
        private static int originY = 300;
        public static double FunctionalEllips(int x, int y, double r)
        {
            double d = DistanceToTheCenterEllips(x, y);
            double pow = Math.Pow(d, 4) / Math.Pow(r, 2);
            return Math.Exp(-pow);
        }
        public static double FunctionalMindal(int x, int y, double a, double b)
        {
            double p = DistanceToTheCenterMindal(x, y, a, b);
            double pow = Math.Pow(p, 1.1);
            return Math.Exp(-pow);
        }
        private static double DistanceToTheCenterEllips(int x, int y)
        {
            return Math.Sqrt(Math.Pow(originX - x, 2) + Math.Pow(originY - y, 2));        
        }
        private static double DistanceToTheCenterMindal(int x, int y, double a, double b)
        {
            return Math.Pow(originX - x, 2) / Math.Pow(a, 2) + Math.Pow(originY - y, 2) / Math.Pow(b, 2);             
        }
    }
}
