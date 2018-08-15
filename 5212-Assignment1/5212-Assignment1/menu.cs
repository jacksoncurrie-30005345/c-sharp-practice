/* 
 * Author      : Jackson Currie - 30005345
 * Date        : 2018-08-16
 * Description : Menu for all assignment questions.
 */

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

            // Loop until exit
            do
            {
                // Output menu
                Console.Clear();
                Console.WriteLine("\nJackson Currie - 5212 Assignment 1");
                Console.WriteLine("----------------------------------\n");

                Console.Write("Question 1 [1]\n" +
                              "Question 2 [2]\n" +
                              "Question 3 [3]\n" +
                              "Question 4 [4]\n" +
                              "Question 5 [5]\n" +
                              "Exit [Esc]\n\n" +
                              "Choose Question..."
                );

                // Get input
                key = Console.ReadKey(true);

                // Check input
                switch (key.Key)
                {
                    // 1
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Console.WriteLine("\nQuestion 1\n----------\n");
                        Question1.Program.Main();
                        break;

                    // 2
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Console.WriteLine("\nQuestion 2\n----------\n");
                        Question2.Program.Main();
                        break;

                    // 3
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        Console.WriteLine("\nQuestion 3\n----------\n");
                        Question3.Program.Main();
                        break;
                    
                    // 4
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        Console.WriteLine("\nQuestion 4\n----------\n");
                        Question4.Program.Main();
                        break;

                    // 5
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.Clear();
                        Console.WriteLine("\nQuestion 5\n----------\n");
                        Question5.Program.Main();
                        break;

                    // Esc
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.Write("\nGoodbye\n-------\n\nPress any key to exit...");
                        Console.ReadKey();
                        return;

                    // Invalid input
                    default:
                        Console.Clear();
                        Console.WriteLine("\nNot a valid input\n");
                        break;
                }

                // When complete
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Escape);
        }
    }
}
