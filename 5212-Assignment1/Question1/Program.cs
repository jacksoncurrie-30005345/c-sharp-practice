using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Program
    {
        public static void Main()
        {
            // New car
            Car usersCar = new Car();
            Console.WriteLine("Enter car details below");

            // Set Colour
            Console.Write("\nEnter car's colour: ");
            usersCar.SetColour(Console.ReadLine());

            // Set Make
            Console.Write("Enter car's make: ");
            usersCar.SetMake(Console.ReadLine());

            // Set Gearbox
            Console.Write("Enter car's gearbox: ");
            usersCar.SetGearbox(Console.ReadLine());

            // Output result
            Console.WriteLine("\nThis car is a {0} {1} with a {2} transmission.\n", usersCar.GetColour(), usersCar.GetMake(), usersCar.GetGearbox());
        }
    }
}
