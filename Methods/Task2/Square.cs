using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Square
    {
        public static double GetSquareValues(double area)
        {
            return Math.Sqrt(area);
        }

        public static double GetSquareArea(double width)
        {
            return Math.Pow(width, 2);
        }
    }
}
