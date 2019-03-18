using System;
using System.Collections;
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
            Console.Write("How many values: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Stack stack = new Stack(n);

            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter vlaue: ");
                stack.Push(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine();

            foreach(int item in stack)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
