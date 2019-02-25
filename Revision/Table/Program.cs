using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }

            Console.ReadKey();
        }
    }
}
