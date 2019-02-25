using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1000];

            Random random = new Random();

            for(int i = 0; i < 1000; i++)
            {
                array[i] = random.Next(1000, 10000);
            }

            foreach(int item in array)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
