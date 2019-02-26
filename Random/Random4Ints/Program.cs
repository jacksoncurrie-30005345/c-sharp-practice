using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random4Ints
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[1000];

            Random random = new Random();

            for(int i = 0; i < 1000; i++)
            {
                ints[i] = random.Next(1000, 10000);
            }

            ints = ints.OrderBy(j => j).ToArray();

            foreach(int num in ints)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
