using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            string b = "5";
            Console.WriteLine("Values [{0}] and [{1}] are {2}", a, b, Compare(a, b) ? "the same" : "different");
            Console.ReadKey();
        }

        static bool Compare<T1, T2>(T1 value1, T2 value2) => value1.ToString() == value2.ToString();
    }
}
