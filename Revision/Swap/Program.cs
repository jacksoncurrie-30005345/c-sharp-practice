using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10,
                b = 20,
                temp = 0;

            Console.WriteLine($"Before swap: A = {a} B = {b}");

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After swap: A = {a} B = {b}");
            Console.ReadKey();
        }
    }
}
