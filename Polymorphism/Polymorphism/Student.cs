using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Student
    {
        public string Name { get; set; }
        public decimal Grade1 { get; set; }
        public decimal Grade2 { get; set; }
        public decimal Grade3 { get; set; }

        public virtual string StudentDetails()
        {
            return $"\n" +
                   $"IT student    : {Name}\n" +
                   $"Grade 1       : {Grade1}%\n" +
                   $"Grade 2       : {Grade2}%\n" +
                   $"Grade 3       : {Grade3}%\n";
        }
    }
}
