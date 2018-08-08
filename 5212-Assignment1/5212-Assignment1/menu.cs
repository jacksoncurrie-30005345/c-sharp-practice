using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Menu
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;

            do
            {
                Console.Clear();
                Console.WriteLine("\nJackson Currie - 5212 Assignment 1");
                Console.WriteLine("----------------------------------\n");

                Console.Write("Question 1 [1]\n" +
                              "Question 3 [3]\n" +
                              "Question 4 [4]\n" +
                              "Question 5 [5]\n" +
                              "Exit [Esc]\n\n" +
                              "Choose Question..."
                );

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Console.WriteLine("\nQuestion 1");
                        Console.WriteLine("----------\n");
                        Question1.Program.Main();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        Console.WriteLine("\nQuestion 3");
                        Console.WriteLine("----------\n");
                        Question3.Program.Main();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        Console.WriteLine("\nQuestion 4");
                        Console.WriteLine("----------\n");
                        Question4.Program.Main();
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.Clear();
                        Console.WriteLine("\nQuestion 5");
                        Console.WriteLine("----------\n");
                        break;

                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine("\nGoodbye");
                        Console.WriteLine("-------\n");
                        Console.Write("Press any key to exit...");
                        Console.ReadKey();
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("\nNot a valid input\n");
                        break;
                }

                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Escape);
        }
    }
}
