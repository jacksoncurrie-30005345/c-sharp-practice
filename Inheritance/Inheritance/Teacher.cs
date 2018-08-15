using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Teacher : Employee
    {
        public string Office { get; set; }

        public Teacher(string _fname, string _lname, string _empID, string _office)
        {
            Fname = _fname;
            Lname = _lname;
            EmployeeID = _empID;
            Office = _office;
        }

        public string GetTeacherDeets() => $"Name        : {Fname} {Lname}\n" +
                                           $"Employee ID : {EmployeeID}\n" +
                                           $"Office      : {Office}";
    }
}
