using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Program
    {
        public static void Main()
        {
            bool valid = false;
            int num1 = 0;
            int num2 = 0;

            do
            {
                Console.Write("\nEnter first number: ");
                string snum1 = Console.ReadLine();
                Console.Write("Enter second number: ");
                string snum2 = Console.ReadLine();

                try
                {
                    num1 = Int32.Parse(snum1);
                    num2 = Int32.Parse(snum2);
                    valid = true;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("\nMust be numbers");
                }
            }
            while (!valid);

            Console.WriteLine("{0} x {1} = {2}\n", num1, num2, num1 * num2);
        }
    }
}
