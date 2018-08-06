using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomEscape
{
    class Game
    {
        static Room[,] rooms;
        static Room currentRoom;
        static int xpos;
        static int ypos;

        static void Main(string[] args)
        {
            // Creating map

            rooms = new Room[,]
            {
                {
                    new Room("Entrance", false, true, true, false, false, false),
                    new Room("Master Bedroom", false, false, false, true, false, false),
                    new Room("Bathroom", false, true, true, false, false, false),
                    new Room("Exit", false, false, false, true, false, true)
                },
                {
                    new Room("Library", true, false, true, false, false, false),
                    new Room("Store Room", false, true, false, true, false, false),
                    new Room("Janitor Closet", true, false, true, false, false, false),
                    new Room("Staircase", false, true, false, true, false, false)
                },
                {
                    new Room("Child's Bedroom", false, true, true, false, false, false),
                    new Room("Shrine", true, false, true, true, false, false),
                    new Room("Hallway", false, false, true, true, false, false),
                    new Room("Conservatory", true, false, false, true, false, false)
                },
                {
                    new Room("Court Hall", true, false, true, false, false, false),
                    new Room("Treasure Room", false, false, true, true, true, false),
                    new Room("Labatory", false, false, true, true, false, false),
                    new Room("Garage", false, false, false, true, false, false)
                }
            };

            // Start of game instructions
            Console.WriteLine("Start");

            // Set Starting values
            xpos = 0;
            ypos = 0;
            currentRoom = rooms[xpos, ypos];
            bool hasKey = false;
            char input;

            // Loop until complete
            do
            {
                // Display room infomation
                DisplayRoom();

                // Ask for direction of move
                Console.Write("Enter direction: ");
                input = Char.Parse(Console.ReadLine());

                // Move to next room
                ChangeRoom(input);

                // Check for Key
                hasKey = currentRoom.Key;
                if(hasKey) Console.WriteLine("You have found the key");
            }
            while (!hasKey || !currentRoom.End);

            // Display end of game information
            Console.WriteLine("Finish");
        }

        static void ChangeRoom(char direction)
        {
            // Change by dirrection
            if (direction == 'n' && currentRoom.North)
                ypos--;

            else if (direction == 's' && currentRoom.South)
                ypos++;

            else if (direction == 'e' && currentRoom.East)
                xpos++;

            else if (direction == 'w' && currentRoom.West)
                xpos--;

            // Not valid direction
            else
                Console.WriteLine("You can't move that way");

            // Set the new current Room
            currentRoom = rooms[ypos, xpos];
        }

        static void DisplayRoom()
        {
            // Loop through array
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    // Add x when current room
                    Console.Write("[{0}]", rooms[i, j] == currentRoom ? 'x' : ' ');
                }
                Console.Write('\n');
            }
        }
    }
}
