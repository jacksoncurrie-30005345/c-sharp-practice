using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    public class Program
    {
        public static void Main()
        {
            // Car details
            Console.WriteLine("Enter car details below");

            // Set Colour
            Console.Write("\nEnter car's colour: ");
            string colour = Console.ReadLine();

            // Set Make
            Console.Write("Enter car's make: ");
            string make = Console.ReadLine();

            // Set Gearbox
            Console.Write("Enter car's gearbox: ");
            string gearbox = Console.ReadLine();

            // New car
            Car usersCar = new Car(colour, make, gearbox);

            // Output result
            Console.WriteLine("\nThis car is a {0} {1} with a {2} transmission.\n", usersCar.GetColour(), usersCar.GetMake(), usersCar.GetGearbox());
        }
    }
}
