using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            double choice;

            do
            {
                Console.Write("(1) Cicle (2) Square (3) Exit: ");
                value = Int32.Parse(Console.ReadLine());
                Console.Clear();

                if (value == 1)
                {
                    Console.Write("(1) Area (2) Radius: ");
                    choice = Double.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.Write("Enter radius: ");
                        Console.WriteLine(Circle.GetCircleArea(Double.Parse(Console.ReadLine())));

                    }
                    else if (choice == 2)
                    {
                        Console.Write("Enter area: ");
                        Console.WriteLine(Circle.GetCircleValues(Double.Parse(Console.ReadLine())));
                    }
                }
                else if (value == 2)
                {
                    Console.Write("(1) Area (2) Width: ");
                    choice = Double.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.Write("Enter width: ");
                        Console.WriteLine(Square.GetSquareArea(Double.Parse(Console.ReadLine())));
                    }
                    else if (choice == 2)
                    {
                        Console.Write("Enter area: ");
                        Console.WriteLine(Square.GetSquareValues(Double.Parse(Console.ReadLine())));
                    }
                }

            }
            while (value != 3);
        }
    }
}
