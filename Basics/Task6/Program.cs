using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int temp = num2;
            num2 = num1;
            num1 = temp;

            Console.WriteLine("First number is {0}", num1);
            Console.WriteLine("Second number is {0}", num2);
        }
    }
}
