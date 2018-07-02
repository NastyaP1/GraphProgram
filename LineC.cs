using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGraphsProgram
{
    class LineC
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public LineC(int x0, int y0, int x1,int y1)
        {
            A = y1 - y0;
            B = x0 - x1;
            C = -(y0 * B + x0 * A);
        }
        public LineC(double x, double y, LineC normline)
        {
            A = -(1/normline.A);
            B = normline.B;
            C = -(A * x + B * y);
        }

        public int ReturnBetweenes(double x, double y)
        {
            double q = (A * x + B * y + C);
            if (q < 0)
                return -1;
            else if (q > 0)
                return 1;
            return 0;
        }
        public static bool IsBetweenLines(double x, double y, LineC l1, LineC l2)
        {
            int a = l1.ReturnBetweenes(x,y);
            int b = l2.ReturnBetweenes(x,y);
            return ((a >0 && b < 0) || (a < 0 && b >0));
        }
        public static bool IsOnLine(double x, double y, int delta, LineC l)
        {
            double line = l.A * x + l.B * y + l.C;
            return -delta < line && line < delta;
        }

    }
}
