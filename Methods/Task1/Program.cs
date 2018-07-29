using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = Double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Double.Parse(Console.ReadLine());
            Console.Write("Would you like to (1) Add (2) Subtract (3) Multiply (4) Divide: ");
            int choice = Int32.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine(Math.AddNums(num1, num2));
                    break;
                case 2:
                    Console.WriteLine(Math.SubtractNums(num1, num2));
                    break;
                case 3:
                    Console.WriteLine(Math.MultiplyNums(num1, num2));
                    break;
                case 4:
                    Console.WriteLine(Math.DivideNums(num1, num2));
                    break;
            }
        }
    }
}
