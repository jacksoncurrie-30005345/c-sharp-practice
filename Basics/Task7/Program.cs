using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter first number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = Int32.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                    Console.WriteLine("Largest is {0}", num1);
                else
                    Console.WriteLine("Largest is {0}", num3);
            }
            else
            {
                if (num2 > num3)
                    Console.WriteLine("Largest is {0}", num2);
                else
                    Console.WriteLine("Largest is {0}", num3);
            }
        }
    }
}
