using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfGame
{
    class Program
    {
        static char[,] grid;
        static bool hasWon;

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int hole = rnd.Next(50, 120);
            int shots = 0;
            hasWon = false;

            Console.BufferHeight = 45;
            Console.WindowHeight = 46;
            Console.BufferWidth = 121;
            Console.WindowWidth = 122;

            do
            {

                grid = new char[40, 121];

                grid[37, hole - 1] = '<';
                grid[37, hole] = '|';
                grid[38, hole] = '|';
                grid[39, hole] = '|';

                DisplayHole();

                Console.Write("Enter power (1-100): ");
                bool input = Int32.TryParse(Console.ReadLine(), out int power);

                if (!input)
                    continue;

                Console.Write("What Club (3, 5, 7, or 9 iron): ");
                double club;
                input = Int32.TryParse(Console.ReadLine(), out int clubValue);

                if (!input)
                    continue;

                switch (clubValue)
                {
                    case 3:
                        club = 0.002;
                        power += 30;
                        break;
                    case 5:
                        club = 0.006;
                        power += 20;
                        break;
                    case 7:
                        club = 0.01;
                        power += 10;
                        break;
                    case 9:
                        club = 0.014;
                        break;
                    default:
                        continue;
                }

                shots++;

                Path(club, power);

                DisplayHole();

                Console.Write(CheckLanding(hole));
                if (hasWon)
                    Console.Write("It took {0} shots.", shots);

                Console.ReadKey();

            }
            while (!hasWon);
        }

        static void DisplayHole()
        {
            Console.Clear();

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 121; j++)
                    Console.Write(grid[i, j]);

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static string CheckLanding(int hole)
        {
            for (int i = 120; i > 4; i--)

                if (grid[39, i] == '*')

                    if (i == hole)
                    {
                        hasWon = true;
                        return "You won!\n\n";
                    }
                    else if (i > hole)
                        return "Too far\n\nNext Shot?";

                    else if (i < hole)
                        return "Too short\n\nNext Shot?";

            return "Out of bounds\n\nNext Shot?";
        }

        static void Path(double club, int power)
        {
            for (int x = 0; x < 121; x++)
            {
                int y = Convert.ToInt32(Math.Round((club * x * (x - power) + 39), 0));
                if (y <= 39 && y > 0)
                    grid[y, x] = '*';
            }

            bool start = false;
            

            for (int y = 0; y < 40; y++)
            {
                int check = 0;

                for (int x = 0; x < 120; x++)
                    if (grid[y, x] == '*')
                    {
                        start = true;
                        check++;
                    }

                if (check == 0 && start)
                {
                    int xValue1 = Convert.ToInt32(Math.Round((0.5 * power) + Math.Sqrt((y + (0.25 * club * power * power) - 39) / club), 0));
                    int xValue2 = Convert.ToInt32(Math.Round((0.5 * power) - Math.Sqrt((y + (0.25 * club * power * power) - 39) / club), 0));

                    if (xValue1 >= 0 && xValue1 <= 120)
                        grid[y, xValue1] = '*';

                    if (xValue2 >= 0 && xValue2 <= 120)
                        grid[y, xValue2] = '*';
                }
            }
        }
    }
}
