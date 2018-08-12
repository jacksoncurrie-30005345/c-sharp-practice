using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Person
    {
        // Properties
        string firstName;
        string lastName;
        int age;
        string address;
        int phone;

        // Constructor
        public Person(string fname, string lname, int ag, string add, int ph)
        {
            firstName = fname;
            lastName = lname;
            age = ag;
            address = add;
            phone = ph;
        }

        // Getting and setting properties
        string GetFirstName() => firstName;
        string GetLastName() => lastName;
        int GetAge() => age;
        string GetAddress() => address;
        int GetPhone() => phone;

        // Details
        public string GetDetails() =>
            $"Name    : {GetFirstName()} {GetLastName()}\n" +
            $"Age     : {GetAge()}\n" +
            $"Address : {GetAddress()}\n" +
            $"Phone   : {GetPhone()}";
    }
}
