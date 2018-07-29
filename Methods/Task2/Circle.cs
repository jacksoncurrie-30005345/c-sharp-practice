using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Circle
    {
        public static double GetCircleValues(double area)
        {
            return Math.Sqrt(area) / Math.PI;
        }

        public static double GetCircleArea(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
