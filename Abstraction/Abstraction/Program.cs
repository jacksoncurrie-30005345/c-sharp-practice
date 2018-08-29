using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main()
        {
            Console.Write("Dark Side Death Star - ");
            SpaceStation darkSide = new DeathStar("Massive");

            Console.Write("\nNASA Space Shuttle   - ");
            SpaceStation nasa = new SpaceShuttle(100);

            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
