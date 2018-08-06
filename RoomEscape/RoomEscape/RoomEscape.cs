using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomEscape
{
    class RoomEscape
    {
        static void Main(string[] args)
        {
            // Sart new game
            Game game = new Game();

            bool input;

            // Loop until game is complete
            do
            {
                game.DisplayRoom();

                // Ask for direction of move
                Console.Write("Enter direction: ");
                input = Char.TryParse(Console.ReadLine(), out char direction);

                // Check input
                if (!input)
                {
                    Console.Clear();
                    Console.WriteLine("\nThat is not a valid input.");
                }
                else
                {
                    direction = Char.ToUpper(direction);
                    // Move to next room
                    game.Move(direction);

                }
            }
            while (!game.Finish);

            // End program
            Console.Write("\nPress [ENTER] to close...");
            Console.ReadLine();
        }
    }
}
