using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];

            Random random = new Random();

            for(int i = 0; i < 100; i++)
            {
                bool unique;

                int test;

                do
                {
                    unique = true;

                    test = random.Next(100, 1000);

                    for (int j = 0; j < 100; j++)
                    {
                        if (test == array[j])
                        {
                            unique = false;
                        }
                    }
                } while (!unique);

                array[i] = test;
            }

            foreach(int value in array)
            {
                Console.Write(value + " ");
            }

            Console.ReadKey();
        }
    }
}
