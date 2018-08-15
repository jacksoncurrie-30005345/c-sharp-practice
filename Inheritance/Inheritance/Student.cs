using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student : Person
    {
        public int StudentID { get; set; }

        public Student(string _fname, string _lname, int _stdID)
        {
            Fname = _fname;
            Lname = _lname;
            StudentID = _stdID;
        }

        public string GetStdDeets() => $"Name       : {Fname} {Lname}\n" +
                                       $"Student ID : {StudentID}";
    }
}
