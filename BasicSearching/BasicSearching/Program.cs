using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSearching
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();
            int[] array = Populate(1000);
            Array.Sort(array);
            Console.WriteLine("Sorted array:");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");

            Random random = new Random();
            int find = random.Next(1000);
            Console.WriteLine("Number to find: " + find);

            sw1.Start();
            Console.WriteLine("Standard search {0}", FindInArray(array, find) ? "did find number" : "did not find number");
            sw1.Stop();

            sw2.Start();
            Console.WriteLine("Binary search {0}", BinaryFind(array, find) ? "did find number" : "did not find number");
            sw2.Stop();

            Console.WriteLine($"\nNormal find ticks: {sw1.ElapsedTicks}");
            Console.WriteLine($"Binary find ticks: {sw2.ElapsedTicks}");
            Console.ReadKey();
        }

        static int[] Populate(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            for(int i = 0; i < size; i++)
            {
                array[i] = random.Next(1000);
            }
            return array;
        }

        static bool FindInArray(int[] array, int find)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == find)
                {
                    return true;
                }
            }
            return false;
        }

        static bool BinaryFind(int[] array, int find)
        {
            int upper, mid, lower;
            upper = array.Length;
            lower = 0;
            while(lower <= upper)
            {
                mid = lower + (upper - lower) / 2;

                if (array[mid] == find)
                {
                    return true;
                }
                else if(array[mid] > find)
                {
                    upper = mid - 1;
                }
                else
                {
                    lower = mid + 1;
                }
            }
            return false;
        }
    }
}
