using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Person
    {
        // Properties
        string _firstName;
        string _lastName;
        int _yearOfBirth;

        // Geting and setting properties
        public string FirstName { get => _firstName; private set => _firstName = value; }
        public string LastName { get => _lastName; private set => _lastName = value; }
        public int YearOfBirth { get => _yearOfBirth; set => _yearOfBirth = value; }

        // Constructor
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Full name
        public string GetFullName() => FirstName + ' ' + LastName;

        // Age
        public int GetAge() => DateTime.Now.Year - YearOfBirth;
    }
}
