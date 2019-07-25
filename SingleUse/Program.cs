using System;
using System.Collections.Generic;

namespace SingleUse
{
    class Program
    {
        static void Main()
        {
            People people = new People();

            Console.WriteLine(Messages.listOfNames);
            Console.WriteLine(people.ListOfNames());

            Console.WriteLine(Messages.numberOfPeople);
            Console.WriteLine(people.CountNames());

            Console.WriteLine(Messages.addPerson);
            string name = Console.ReadLine();
            people.AddName(name);

            Console.WriteLine(Messages.listOfNames);
            Console.WriteLine(people.ListOfNames());

            Console.WriteLine(Messages.numberOfPeople);
            Console.WriteLine(people.CountNames());
        }
    }
}
