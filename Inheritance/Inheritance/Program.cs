using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            // New teacher
            Console.WriteLine("\nTeacher Details:\n");
            Teacher teacher;

            // Get teacher first name
            Console.Write("Enter first name: ");
            string fname = Console.ReadLine();

            // Get teachers last name
            Console.Write("Enter last name: ");
            string lname = Console.ReadLine();

            // Get employees ID
            Console.Write("Enter employee ID: ");
            string id = Console.ReadLine();

            // Get office
            Console.Write("Enter office: ");
            string office = Console.ReadLine();

            // Output teacher
            teacher = new Teacher(fname, lname, id, office);
            Console.WriteLine("\n" + teacher.GetTeacherDeets());

            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // New Student
            Console.WriteLine("\nStudent Details:\n");
            Student student;

            // Get student first name
            Console.Write("Enter first name: ");
            fname = Console.ReadLine();

            // Get student last name
            Console.Write("Enter last name: ");
            lname = Console.ReadLine();

            bool num = false;
            int stdID;

            do
            {
                // Get student ID
                Console.Write("Enter student ID: ");
                if (Int32.TryParse(Console.ReadLine(), out stdID))
                    num = true;
                else
                    Console.WriteLine("\nNot a number.\n");
            }
            while (!num);

            // Output student
            student = new Student(fname, lname, stdID);
            Console.WriteLine("\n" + student.GetStdDeets());

            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
