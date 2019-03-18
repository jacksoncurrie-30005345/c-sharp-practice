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
            Console.Write("How many values: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Stack stack = new Stack(n);
            for(int i = 0; i < n; i++)
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
