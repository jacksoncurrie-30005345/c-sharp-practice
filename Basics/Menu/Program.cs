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
            int task;

            do
            {
                Console.Write(
                    "1. Task 1\n" +
                    "5. Task 5\n" +
                    "6. Task 6\n" +
                    "7. Task 7\n" +
                    "8. Task 8\n" +
                    "9. Task 9\n" +
                    "10. Exit\n" +
                    "Enter the program to run: "
                );

                task = Int32.Parse(Console.ReadLine());

                switch (task)
                {
                    case 1:
                        Task1.Program.Main();
                        break;

                    case 5:
                        Task5.Program.Main();
                        break;

                    case 6:
                        Task6.Program.Main();
                        break;

                    case 7:
                        Task7.Program.Main();
                        break;

                    case 8:
                        Task8.Program.Main();
                        break;

                    case 9:
                        Task9.Program.Main();
                        break;

                    case 10:
                        Console.WriteLine("Goodbye");
                        break;

                    default:
                        Console.WriteLine("Not a specified number");
                        break;
                }
            }
            while (task != 10);
        }
    }
}
