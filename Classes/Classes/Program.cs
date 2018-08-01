using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person employee1 = new Person
            {
                Fname = "Jake",
                Lname = "Mansel",
                PayRate = 50000.00,
                Tax = 17.5,
                AccNum = 34567
            };

            Person employee2 = new Person
            {
                Fname = "Sarah",
                Lname = "Clark",
                PayRate = 100000.00,
                Tax = 33,
                AccNum = 34117
            };

            Person employee3 = new Person
            {
                Fname = "Jacob",
                Lname = "Jackson",
                PayRate = 30000.00,
                Tax = 10.5,
                AccNum = 11123
            };

            Person employee4 = new Person
            {
                Fname = "Sam",
                Lname = "King",
                PayRate = 990000.00,
                Tax = 48.9,
                AccNum = 98423
            };

            Person employee5 = new Person
            {
                Fname = "Mike",
                Lname = "Hunt",
                PayRate = 40000.50,
                Tax = 15.1,
                AccNum = 84763
            };

            List<Person> employees = new List<Person>
            {
                employee1,
                employee2,
                employee3,
                employee4,
                employee5,
                new Person("John", "Banks", 30000, 15, 93756),
                new Person("Brad", "Bond", 100000, 15.6, 18563),
                new Person("James", "Hitch", 45000, 18, 29563),
                new Person("Connor", "Farrent", 35000, 22, 32342),
                new Person("Laura", "Watt", 70000, 10.5, 11232)
            };

            double total;

            foreach (Person employee in employees)
            {
                total = (1 - (employee.Tax / 100)) * employee.PayRate;

                Console.WriteLine($"------------------------------------\n" +
                                  $"Account Number :  {employee.AccNum}\n" +
                                  $"First Name     :  {employee.Fname}\n" +
                                  $"Last Name      :  {employee.Lname}\n" +
                                  $"Pay Rate       :  {employee.PayRate:C}\n" +
                                  $"Tax            :  {employee.Tax}%\n" +
                                  $"------------------------------------\n" +
                                  $"Total Income   :  {total:C}\n" +
                                  $"------------------------------------\n\n");
            }
        }
    }
}
