using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 * num2);
            Console.ReadKey();
        }
    }
}
