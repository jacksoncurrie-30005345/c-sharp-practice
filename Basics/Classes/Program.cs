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
            Person person1 = new Person("Jackson", 19, 'm', 76.5);
            Console.WriteLine("Name: {0}\nAge: {1}\nGender: {2}\nMass: {3}", person1.Name, person1.Age, person1.Gender, person1.Mass);
        }
    }
}
