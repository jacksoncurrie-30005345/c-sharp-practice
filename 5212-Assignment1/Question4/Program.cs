using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    public class Program
    {
        public static void Main()
        {
            // List of people
            List<Person> people = new List<Person>();

            bool exit = false;

            do
            {
                Console.Clear();
                Console.WriteLine("\nQuestion 2\n----------\n");

                // Output information
                Console.WriteLine("Enter name of new person below.\n");

                // First name
                Console.Write("Enter first name: ");
                string firstname = Console.ReadLine();

                // Last name
                Console.Write("Enter last name: ");
                string lastname = Console.ReadLine();

                // Creat record
                Person user = new Person(firstname, lastname);

                // Check results
                bool check;
                int input;

                do
                {
                    // Get year of birth
                    Console.Write("Enter year of birth: ");
                    check = Int32.TryParse(Console.ReadLine(), out input);
                    if (check && input <= DateTime.Now.Year)
                        user.YearOfBirth = input;
                    else
                        Console.WriteLine("\nThat is not a valid year.\n");
                }
                while (!check && input <= DateTime.Now.Year);

                // Add person to list
                people.Add(user);

                // Output results
                Console.WriteLine("\nPeople:");   
                foreach(Person person in people)
                    Console.WriteLine("{0} is {1} years old.", person.GetFullName(), person.GetAge());

                // Check value
                ConsoleKeyInfo key;

                do
                {
                    // Get input
                    Console.Write("\nDo you want to enter another person? [Y]/[N]");
                    key = Console.ReadKey(true);

                    // Check key
                    switch (key.Key)
                    {
                        // Y
                        case ConsoleKey.Y:
                            break;

                        // N
                        case ConsoleKey.N:
                            exit = true;
                            break;

                        // Wrong input
                        default:
                            Console.WriteLine("\n\nThat is not an option.\n");
                            break;
                    }
                }
                while (key.Key != ConsoleKey.N && key.Key != ConsoleKey.Y);

                Console.WriteLine('\n');
            }
            while (!exit);
        }
    }
}
