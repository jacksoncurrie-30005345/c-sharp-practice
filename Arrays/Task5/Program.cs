using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Program
    {
        public static void Main()
        { 
            Person[] people = new Person[5];

            for(int i = 0; i < people.Length; i++)
            {
                people[i] = new Person();

                Console.Write("Enter first name: ");
                people[i].Firstname = Console.ReadLine();

                Console.Write("Enter last name: ");
                people[i].Lastname = Console.ReadLine();

                Console.Write("Enter age: ");
                people[i].Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
            }

            Console.Clear();

            foreach (Person person in people)
                Console.WriteLine
                (
                    $"Name : {person.Firstname} {person.Lastname}\n" +
                    $"Age  : {person.Age}\n"
                );
        }
    }
}
