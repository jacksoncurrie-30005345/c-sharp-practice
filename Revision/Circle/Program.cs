using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
           double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Perimetre = " + 2 * Math.PI * r);
            Console.WriteLine("Area = " + Math.PI * r * r);
            Console.ReadKey();
        }
    }
}
