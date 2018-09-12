using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArrays
{
    class Program
    {
        static void Main()
        {
            for (int row = 0; row < Booking.seats.GetLength(0); row++)
                for (int col = 0; col < Booking.seats.GetLength(1); col++)
                    Booking.seats[row, col] = false;

            while (true)
            {
                Console.WriteLine("Cinema\n------\n");

                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write
                (
                    "\n" +
                    "Adult  [1]\n" +
                    "Child  [2]\n" +
                    "Senior [3]\n" +
                    "\nSelect ticket..."
                );
                ConsoleKeyInfo key = Console.ReadKey(true);
                bool adult = key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1;

                Booking booking = new Booking(name, adult);
                Console.Clear();

                Console.WriteLine
                (
                    $"\n" +
                    $"Welcome {booking.Name}\n" +
                    $"\n" +
                    $"Available Seats\n" +
                    $"---------------\n"
                );       

                Console.Write("  ");
                for (int i = 0; i < Booking.seats.GetLength(1); i++)
                    Console.Write($"{i + 1, 3}");

                Console.WriteLine('\n');

                for (int row = 0; row < Booking.seats.GetLength(0); row++)
                {
                    Console.Write($"{row + 1, 2}  ");
                    for (int col = 0; col < Booking.seats.GetLength(1); col++)
                    {
                        Console.Write(Booking.seats[row, col] ? "#  " : "X  ");
                    }
                    Console.WriteLine('\n');
                }

                if (!Booking.CheckSeats())
                {
                    Console.WriteLine("No seats...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                Console.Write("Pick a row: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Pick a column: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Booking.seats[y-1, x-1] = false;

                Console.Write($"\nCharged ${booking.Ticket}...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
