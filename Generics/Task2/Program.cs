using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            string b = "Hello";
            bool c = true;

            Display<int> displayInt = new Display<int>();
            Display<string> displayString = new Display<string>();
            Display<bool> displayBool = new Display<bool>();

            displayInt.DisplayData(a);
            displayString.DisplayData(b);
            displayBool.DisplayData(c);

            Console.ReadKey();
        }
    }
}
