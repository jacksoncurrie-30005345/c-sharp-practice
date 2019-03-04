using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] array = new double[1000];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble() * 10;
            }

            for(int i = 0; i < array.Length / 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write($"{array[i * j]:N5} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            double[] array2 = new double[array.Length];

            array.CopyTo(array2, 0);

            IEnumerable<double> biggerThan2 = from names in array2 where names > 2 select names;

            foreach(double num in biggerThan2)
            {
                Console.Write($"{num:N5} ");
            }

            double[] array3 = biggerThan2.ToArray();

            Array.Sort(array3);

            Console.WriteLine('\n');

            foreach(double num in array3)
            {
                Console.Write($"{num:N5} ");
            }

            Array.Reverse(array3);

            Console.WriteLine('\n');

            foreach (double num in array3)
            {
                Console.Write($"{num:N5} ");
            }

            Console.ReadKey();
        }
    }
}
