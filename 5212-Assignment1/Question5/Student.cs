/* 
 * Author      : Jackson Currie - 30005345
 * Date        : 2018-08-16
 * Description : Student class for Question 5.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Student : Person
    {
        // Auto implementing properties
        public string Campus { get; set; }
        public int StudentID { get; set; }

        // Constructor
        public Student(string firstName, string lastName, string campus) : base(firstName, lastName)
        {
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
