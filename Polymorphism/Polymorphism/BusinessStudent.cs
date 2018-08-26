using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class BusinessStudent : Student
    {
        public decimal HighestGrade()
        {
            return Grade1 > Grade2 ? (Grade1 > Grade3 ? Grade1 : Grade3) : (Grade2 > Grade3 ? Grade2 : Grade3);
        }

        public override string StudentDetails()
        {
            return base.StudentDetails() + $"Highest Grade : {HighestGrade():F2}%\n";
        }
    }
}
