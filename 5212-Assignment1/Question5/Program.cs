/* 
 * Author      : Jackson Currie - 30005345
 * Date        : 2018-08-16
 * Description : Main program for Question 5.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    public class Program
    {
        public static void Main()
        {
            // Output information
            Console.WriteLine("Enter name of new student below.\n");

            // First name
            Console.Write("Enter first name: ");
            string firstname = Console.ReadLine();

            // Last name
            Console.Write("Enter last name: ");
            string lastname = Console.ReadLine();

            // Campus
            Console.Write("Enter campus: ");
            string campus = Console.ReadLine();

            // Creat record
            Student user = new Student(firstname, lastname, campus);
            user.StudentID = user.EnrollStudent();

            // Output result
            Console.WriteLine
            (
                "\n{0} of {1} campus has a student ID of {2}.\n",
                user.GetFullName(),
                user.Campus,
                user.StudentID
            );
        }
    }
}
