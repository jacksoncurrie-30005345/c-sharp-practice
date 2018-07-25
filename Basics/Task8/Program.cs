using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What was your final course mark? ");
            int mark = Int32.Parse(Console.ReadLine());

            if (mark >= 50)
                Console.WriteLine("You passsed");
            else
                Console.WriteLine("You failed");
        }
    }
}
