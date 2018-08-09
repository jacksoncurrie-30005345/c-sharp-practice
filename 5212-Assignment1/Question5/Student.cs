using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Student : Person
    {
        // Properties
        string _campus;
        int _studentID;

        // Getting and setting properties
        public string Campus { get => _campus; private set => _campus = value; }
        public int StudentID { get => _studentID; set => _studentID = value; }

        // Constructor
        public Student(string firstName, string lastName, string campus) : base(firstName, lastName)
        {
            Console.WriteLine("\nCreating new person record...\n");
            Console.WriteLine("Enrolling student at {0} campus...", campus);
            Campus = campus;
        }

        // Enroll
        public int EnrollStudent()
        {
            Random random = new Random();
            return random.Next(1000, 10000);
        }
    }
}
