using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher();
            teacher1.Name = "John";
            teacher1.Age = 34;
            teacher1.Login = "j123";

            Teacher teacher2 = new Teacher();
            teacher2.Name = "Jake";
            teacher2.Age = 32;
            teacher2.Login = "j127";

            Teacher teacher3 = new Teacher();
            teacher3.Name = "Sam";
            teacher3.Age = 21;
            teacher3.Login = "s123";

            Teacher teacher4 = new Teacher();
            teacher4.Name = "Sarah";
            teacher4.Age = 38;
            teacher4.Login = "s123";

            Teacher teacher5 = new Teacher();
            teacher5.Name = "Lilly";
            teacher5.Age = 19;
            teacher5.Login = "l123";

            Student student1 = new Student();
            student1.Name = "Matt";
            student1.Age = 16;
            student1.ID = 1234;

            Student student2 = new Student();
            student1.Name = "Kate";
            student1.Age = 17;
            student1.ID = 1235;

            Student student3 = new Student();
            student1.Name = "Kim";
            student1.Age = 18;
            student1.ID = 1224;

            Student student4 = new Student();
            student1.Name = "Luke";
            student1.Age = 12;
            student1.ID = 1239;

            Student student5 = new Student();
            student1.Name = "Nick";
            student1.Age = 15;
            student1.ID = 3234;

            Person[] people = new Person[10];
            people[0] = teacher1;
            people[1] = teacher2;
            people[2] = teacher3;
            people[3] = teacher4;
            people[4] = teacher5;
            people[5] = student1;
            people[6] = student2;
            people[7] = student3;
            people[8] = student4;
            people[9] = student1;

            foreach(Person person in people)
            { 
                Console.WriteLine($"Name: {person.Name}\nAge: {person.Age}\n\n");
            }

            Console.ReadKey();
        }
    }
}
