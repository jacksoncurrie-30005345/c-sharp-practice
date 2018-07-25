using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("\nEnter number between 1-12: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            for (int i = 1; i <= 12; i++)
                Console.WriteLine("{0} x {1} = {2}", number, i, number * i);

            Console.WriteLine();
        }
    }
}
