using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int task = 0;

            do
            {
                bool valid = false;

                do
                {
                    Console.Write(
                        "1. Task 1\n" +
                        "2. Task 2\n" +
                        "3. Task 3\n" +
                        "4. Task 4\n" +
                        "5. Task 5\n" +
                        "6. Task 6\n" +
                        "7. Task 7\n" +
                        "8. Task 8\n" +
                        "9. Task 9\n" +
                        "10. Exit\n" +
                        "\n" +
                        "Enter the program to run: "
                    );

                    try
                    {
                        task = Int32.Parse(Console.ReadLine());
                        valid = true;
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("\nIt has to be a number\n");
                    }
                }
                while (!valid);

                switch (task)
                {
                    case 1:
                        Console.Clear();
                        Task1.Program.Main();
                        break;

                    case 2:
                        Console.Clear();
                        Task2.Program.Main();
                        break;

                    case 3:
                        Console.Clear();
                        Task3.Program.Main();
                        break;

                    case 4:
                        Console.Clear();
                        Task4.Program.Main();
                        break;

                    case 5:
                        Console.Clear();
                        Task5.Program.Main();
                        break;

                    case 6:
                        Console.Clear();
                        Task6.Program.Main();
                        break;

                    case 7:
                        Console.Clear();
                        Task7.Program.Main();
                        break;

                    case 8:
                        Console.Clear();
                        Task8.Program.Main();
                        break;

                    case 9:
                        Console.Clear();
                        Task9.Program.Main();
                        break;

                    case 10:
                        Console.Clear();
                        Console.Write("Press enter key to exit...");
                        Console.Read();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Not a specified number");
                        break;
                }
            }
            while (task != 10);
        }
    }
}
