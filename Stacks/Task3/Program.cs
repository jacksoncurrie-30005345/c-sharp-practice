using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            Stack stack = new Stack(input.Length);

            foreach(char ch in input)
            {
                stack.Push(ch);
            }

            Console.WriteLine();

            foreach(char item in stack)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
