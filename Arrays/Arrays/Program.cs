using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Menu
    {
        static void Main()
        {
            ConsoleKeyInfo key;

            // Loop until exit
            do
            {
                // Output menu
                Console.Clear();
                Console.WriteLine
                (
                    "\n" +
                    "Arrays\n" +
                    "------\n"
                );
                Console.Write
                (
                    "Task 1 [1]\n" +
                    "Task 2 [2]\n" +
                    "Task 3 [3]\n" +
                    "Task 4 [4]\n" +
                    "Task 5 [5]\n" +
                    "Task 6 [6]\n" +
                    "Exit [Esc]\n" +
                    "\n" +
                    "Choose Task..."
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
                        Console.WriteLine
                        (
                            "\n" +
                            "Task 1\n" +
                            "----------\n"
                        );
                        Task1.Program.Main();
                        break;

                    // 2
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Console.WriteLine
                        (
                            "\n" +
                            "Task 2\n" +
                            "----------\n"
                        );
                        Task2.Program.Main();
                        break;

                    // 3
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        Console.WriteLine
                        (
                            "\n" +
                            "Task 3\n" +
                            "----------\n"
                        );
                        Task3.Program.Main();
                        break;

                    // 4
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        Console.WriteLine
                        (
                            "\n" +
                            "Task 4\n" +
                            "----------\n"
                        );
                        Task4.Program.Main();
                        break;

                    // 5
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.Clear();
                        Console.WriteLine
                        (
                            "\n" +
                            "Task 5\n" +
                            "----------\n"
                        );
                        Task5.Program.Main();
                        break;

                    // 6
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Console.Clear();
                        Console.WriteLine
                        (
                            "\n" +
                            "Task 6\n" +
                            "----------\n"
                        );
                        Task6.Program.Main();
                        break;

                    // Esc
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.Write
                        (
                            "\n" +
                            "Goodbye\n" +
                            "-------\n" +
                            "\n" +
                            "Press any key to exit..."
                        );
                        Console.ReadKey(true);
                        return;

                    // Invalid input
                    default:
                        Console.Clear();
                        Console.WriteLine("\nNot a valid input\n");
                        break;
                }

                // When complete
                Console.Write("\nPress any key to continue...");
                Console.ReadKey(true);
            }
            while (key.Key != ConsoleKey.Escape);
        }
    }
}

