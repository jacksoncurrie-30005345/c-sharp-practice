using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomIntegers = new int[1000];

            Random random = new Random();

            for(int i = 0; i < 1000; i++)
            {
                randomIntegers[i] = random.Next();
            }

            foreach(int num in randomIntegers)
            {
                Console.WriteLine(num + " ");
            }

            Console.ReadKey();
        }
    }
}
