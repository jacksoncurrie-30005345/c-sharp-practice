using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main()
        {
            // List of IT students
            List<Student> itStudents = new List<Student>()
            {
                new ITStudent(),
                new ITStudent(),
                new ITStudent(),
                new ITStudent(),
                new ITStudent()
            };

            // Get IT student input
            Console.WriteLine("Enter IT students:");

            // Loop through list
            foreach(ITStudent student in itStudents)
            {
                // Get name
                Console.Write("\nEnter name: ");
                student.Name = Console.ReadLine();

                bool valid;

                // Get grade 1
                do
                {
                    Console.Write("\nEnter Grade 1: ");

                    // Check grade 1
                    if (Decimal.TryParse(Console.ReadLine(), out decimal grade))
                    {
                        student.Grade1 = grade;
                        valid = true;
                    }
                    // invalid input
                    else
                    {
                        valid = false;
                        Console.WriteLine("\nNot a valid input");
                    }
                }
                while (!valid);

                // Get grade 2
                do
                {
                    Console.Write("\nEnter Grade 2: ");

                    // Check grade 2
                    if (Decimal.TryParse(Console.ReadLine(), out decimal grade))
                    {
                        student.Grade2 = grade;
                        valid = true;
                    }
                    // invalid input
                    else
                    {
                        valid = false;
                        Console.WriteLine("\nNot a valid input");
                    }   
                }
                while (!valid);

                // Get grade 3
                do
                {
                    Console.Write("\nEnter Grade 3: ");

                    // Check grade 3
                    if (Decimal.TryParse(Console.ReadLine(), out decimal grade))
                    {
                        student.Grade3 = grade;
                        valid = true;
                    }
                    // Invlaid input
                    else
                    {
                        valid = false;
                        Console.WriteLine("\nNot a valid input");
                    }
                }
                while (!valid);
            }

            // Output IT students
            foreach(ITStudent student in itStudents)
                Console.WriteLine(student.StudentDetails());

            // Continue
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // List of business students
            List<Student> businessStudents = new List<Student>()
            {
                new BusinessStudent(),
                new BusinessStudent(),
                new BusinessStudent(),
                new BusinessStudent(),
                new BusinessStudent()
            };

            // Get student input
            Console.WriteLine("Enter Business students:");

            foreach (BusinessStudent student in businessStudents)
            {
                // Get name
                Console.Write("\nEnter name: ");
                student.Name = Console.ReadLine();

                bool valid;

                // Get Grade 1
                do
                {
                    Console.Write("\nEnter Grade 1: ");

                    // Check grade 1
                    if (Decimal.TryParse(Console.ReadLine(), out decimal grade))
                    {
                        student.Grade1 = grade;
                        valid = true;
                    }
                    // Invlaid input
                    else
                    {
                        valid = false;
                        Console.WriteLine("\nNot a valid input");
                    }
                }
                while (!valid);

                // Get grade 2
                do
                {
                    Console.Write("\nEnter Grade 2: ");

                    // Check grade 2
                    if (Decimal.TryParse(Console.ReadLine(), out decimal grade))
                    {
                        student.Grade2 = grade;
                        valid = true;
                    }
                    // Invalid input
                    else
                    {
                        valid = false;
                        Console.WriteLine("\nNot a valid input");
                    }
                }
                while (!valid);

                // Get grade 3
                do
                {
                    Console.Write("\nEnter Grade 3: ");

                    // Check grade 3
                    if (Decimal.TryParse(Console.ReadLine(), out decimal grade))
                    {
                        student.Grade3 = grade;
                        valid = true;
                    }
                    // Invlaid input
                    else
                    {
                        valid = false;
                        Console.WriteLine("\nNot a valid input");
                    }
                }
                while (!valid);
            }

            // Output business students
            foreach (BusinessStudent student in businessStudents)
                Console.WriteLine(student.StudentDetails());

            // Exit
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
