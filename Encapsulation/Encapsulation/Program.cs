using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // New bus
            Console.WriteLine("\nBus details:\n");
            Bus bus = new Bus();

            // Colour
            Console.Write("Enter colour of bus: ");
            bus.SetColour(Console.ReadLine());

            // Rego
            Console.Write("Enter rego of bus: ");
            bus.SetRego(Console.ReadLine());

            // Doors
            Console.Write("Enter number of doors: ");
            bus.SetDoors(Convert.ToInt32(Console.ReadLine()));

            // Seats
            Console.Write("Enter number of seats: ");
            bus.SetSeats(Convert.ToInt32(Console.ReadLine()));

            // Output
            Console.WriteLine(
                "\nBus:\n\n" +
                $"Colour : {bus.GetColour()}\n" +
                $"Rego   : {bus.GetRego()}\n" +
                $"Doors  : {bus.GetDoors()}\n" +
                $"Seats  : {bus.GetSeats()}\n");

            // End of bus
            Console.Write("Press any key to continue...");
            Console.ReadKey();

            // New person
            Console.Clear();
            Console.WriteLine("\nPerson details:\n");

            // Firstname
            Console.Write("Enter firstname: ");
            string firstname = Console.ReadLine();

            // Lastname
            Console.Write("Enter lastname: ");
            string lastname = Console.ReadLine();

            // Age
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Address
            Console.Write("Enter address: ");
            string address = Console.ReadLine();

            // Phone
            Console.Write("Enter phone: ");
            int phone = Convert.ToInt32(Console.ReadLine());

            // Create person
            Person person = new Person(firstname, lastname, age, address, phone);

            // Output
            Console.WriteLine('\n' + person.GetDetails());

            // End of person
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
