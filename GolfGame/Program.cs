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
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            do
            {
                
                grid = new char[40, 121];

                grid[37, hole-1] = '<';
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
                if(hasWon)
                    Console.Write("It took {0} shots.", shots);

                Console.ReadLine();

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

            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");
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
        }
    }
}

