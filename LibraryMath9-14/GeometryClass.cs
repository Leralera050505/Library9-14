using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMath9_14
{
    public class GeometryClass
    {
        public static double kvadrat(double a)
        {
            return a * a;
        }
        public static double pryamoygolnic(double widh, double hight)
        {
            return widh * hight;
        }
        public static double Circle(double R)
        {
            return 3.14 * (R * R) / R;
        }
        public static double Romb(double d1, double d2)
        {
            return (d1 * d2) / 2;
        }
        public static double treygolnic(double a, double h)
        {
            return 1 / 2 * a * h;
        }
    }
}
