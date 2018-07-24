using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person
    {
        private string name;
        private int age;
        private char gender;
        private double mass;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public char Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public double Mass
        {
            get { return this.mass; }
            set { this.mass = value; }
        }

        public Person(string name, int age, char gender, double mass)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Mass = mass;
        }
    }
}
