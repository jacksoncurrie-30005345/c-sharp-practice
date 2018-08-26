using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class ITStudent : Student
    {
        public decimal GradeAverage()
        {
            decimal sum = Grade1 + Grade2 + Grade3;
            return sum / 3;
        }

        public override string StudentDetails()
        {
            return base.StudentDetails() + $"Average Grade : {GradeAverage():F2}%\n";
        }
    }
}
