using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Person
    {
        // Auto implemented properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }

        // Constructor
        public Person(string firstName, string lastName)
        {
            Console.WriteLine("\nCreating new person record...\n");
            FirstName = firstName;
            LastName = lastName;
        }

        // Full name
        public string GetFullName() => FirstName + ' ' + LastName;

        // Age
        public int GetAge() => DateTime.Now.Year - YearOfBirth;
    }
}