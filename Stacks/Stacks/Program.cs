using System;
using System.Collections;
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
            Stack stack = new Stack(5);
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter value: ");
                stack.Push(Console.ReadLine());
            }

            Console.Write("Bring to top: ");
            string value = Console.ReadLine();

            while(stack.Peek().ToString() != value)
            {
                stack.Pop();
            }

            Console.WriteLine("Top of the stack is " + stack.Peek());
            Console.ReadKey();
        }
    }
}
