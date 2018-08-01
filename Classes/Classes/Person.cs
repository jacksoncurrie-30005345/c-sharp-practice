using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        string fname;
        string lname;
        double payRate;
        double tax;
        int accNum;

        public string Fname
        {
            get => fname;
            set => fname = value;
        }

        public string Lname
        {
            get => lname;
            set => lname = value;
        }

        public double PayRate
        {
            get => payRate;
            set => payRate = value;
        }

        public double Tax
        {
            get => tax;
            set => tax = value;
        }

        public int AccNum
        {
            get => accNum;
            set => accNum = value;
        }

        public Person(string _fname, string _lname, double _payRate, double _tax, int _accNum)
        {
            Fname = _fname;
            Lname = _lname;
            PayRate = _payRate;
            Tax = _tax;
            AccNum = _accNum;
        }

        public Person() { }
    }
}
