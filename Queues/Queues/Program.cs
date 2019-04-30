using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue();

            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter name: ");
                q1.Enqueue(Console.ReadLine());
            }

            Console.Write("\nCheck if contains: ");
            Console.WriteLine(q1.Contains(Console.ReadLine()));
            Console.WriteLine();

            string[] arr = new string[q1.Count];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = (string)q1.Dequeue();
            }

            Array.Sort(arr);

            foreach(string name in arr)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
