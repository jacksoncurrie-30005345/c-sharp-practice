using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomEscape
{
    class Game
    {
        static Room[,] MAP = new Room[,]
        {
            {
                new Room("Entrance", false, true, true, false),
                new Room("Master Bedroom", false, false, false, true),
                new Room("Bathroom", false, true, true, false),
                new Room("Exit", false, false, false, true)
            },
            {
                new Room("Library", true, false, true, false),
                new Room("Store Room", false, true, false, true),
                new Room("Janitor's Closet", true, false, true, false),
                new Room("Staircase", false, true, false, true)
            },
            {
                new Room("Child's Bedroom", false, true, true, false),
                new Room("Shrine", true, false, true, true),
                new Room("Hallway", false, false, true, true),
                new Room("Conservatory", true, false, false, true)
            },
            {
                new Room("Court Hall", true, false, true, false),
                new Room("Treasure Room", false, false, true, true),
                new Room("Labatory", false, false, true, true),
                new Room("Garage", false, false, false, true)
            }
        };

        static Room currentRoom;
        static int xpos;
        static int ypos;
        static int turns;
        static bool hasKey;
        bool finish;

        public bool Finish { get => finish; private set => finish = value; }

        public Game()
        {
            // Setting start values
            MAP[0, 3].IsEnd = true;
            MAP[3, 1].IsKey = true;
            xpos = 0;
            ypos = 0;
            currentRoom = MAP[ypos, xpos];
            turns = 0;
            hasKey = false;
            Finish = false;
        }

        public void Move(char direction)
        {
            Console.Clear();

            // Add a turn


            // Change by dirrection
            if (direction == 'N' && currentRoom.IsNorth)
            {
                ypos--;
                turns++;
            }
            else if (direction == 'S' && currentRoom.IsSouth)
            {
                ypos++;
                turns++;
            }
            else if (direction == 'E' && currentRoom.IsEast)
            {
                xpos++;
                turns++;
            }
            else if (direction == 'W' && currentRoom.IsWest)
            {
                xpos--;
                turns++;
            }

            // Not valid direction
            else
                Console.WriteLine("\nYou can't move that way.");

            // Set the new current Room
            currentRoom = MAP[ypos, xpos];

            // Check for key
            if (currentRoom.IsKey)
            {
                Console.WriteLine("\nYou have found the key!");
                hasKey = true;
                currentRoom.IsKey = false;
            }

            // Check for key
            if (currentRoom.IsEnd && hasKey)
            {
                Console.WriteLine("\nYou have found the {0}!", currentRoom.Name);
                Console.WriteLine("\nNumber of moves: {0}", turns);
                Finish = true;
            }
        }

        public void DisplayRoom()
        {
            Console.WriteLine();

            // Loop through map
            for (int y = 0; y < MAP.GetLength(0); y++)
            {
                Console.Write("-------------\n|");
                for (int x = 0; x < MAP.GetLength(1); x++)
                {
                    // Add x when current room
                    Console.Write("{0} |", MAP[y, x] == currentRoom ? 'x' : ' ');
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------\n");

            // Name room
            Console.WriteLine("You are in the {0}\n", currentRoom.Name);
            Console.WriteLine("Number of moves: {0}\n", turns);

            // Display directions
            if (currentRoom.IsNorth)
                Console.WriteLine("You can travel North (N)");
            if (currentRoom.IsSouth)
                Console.WriteLine("You can travel South (S)");
            if (currentRoom.IsEast)
                Console.WriteLine("You can travel East (E)");
            if (currentRoom.IsWest)
                Console.WriteLine("You can travel West (W)");

            Console.WriteLine();
        }
    }
}
