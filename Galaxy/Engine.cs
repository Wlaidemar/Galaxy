using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    public class Engine
    {
        private static int originX = 300;
        private static int originY = 300;
        public static double Functional(double d, double r)
        {
            double pow = Math.Pow(d, 4) / Math.Pow(r, 2);
            return Math.Exp(-pow);
        }
        public static double DistanceToTheCenter(int x, int y)
        {
            return Math.Sqrt(Math.Pow(originX - x, 2) + Math.Pow(originY - y, 2));
        }
    }
}
