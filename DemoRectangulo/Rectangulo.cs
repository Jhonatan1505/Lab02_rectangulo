using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    public class Rectangulo
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;
        private double x3;
        private double y3;
        private double x4;
        private double y4;

        public Rectangulo(double vx1,double vy1,double vx2,double vy2,double vx3,double vy3,double vx4,double vy4)
        {
            x1 = vx1;
            y1 = vy1;
            x2 = vx2;
            y2 = vy2;
            x3 = vy3;
            y3 = vx3;
            x4 = vx4;
            y4 = vy4;
        }
            
        public double Perimetro()
        {
            double p1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double p2 = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            double p3 = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));
            double p4 = Math.Sqrt(Math.Pow(x4 - x1, 2) + Math.Pow(y4 - y1, 2));
            double peri=p1+p2+p3+p4;

            return peri;
        }
        public double Area()
        {
            double ar = Math.Abs((x1 * y2 + x2 * y3 + x3 * y4 + x4 * y1) - (x1 * y4 + x4 * y3 + x3 * y2 + x2 * y1));
            double area = (ar / 2);

            return area;
        }
    }
}
