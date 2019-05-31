using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeQucikSort
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeSort mergeSort = new MergeSort();
            MergeSort2 mergeSort2 = new MergeSort2();
            QuickSort quickSort = new QuickSort();
            
            int[] array = PopulateArray(1000);
            DisplayArrayToConsole(array);

            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            int[] sorted = mergeSort.Sort(array);
            sw.Stop();
            long ticksMerge = sw.ElapsedTicks;
            DisplayArrayToConsole(sorted);

            sw = Stopwatch.StartNew();
            sw.Start();
            int[] sorted1 = mergeSort2.MergeSort(array);
            sw.Stop();
            DisplayArrayToConsole(sorted1);
            long ticksMerge2 = sw.ElapsedTicks;

            sw = Stopwatch.StartNew();
            sw.Start();
            int[] sorted2 = quickSort.Sort(array, 0, array.Length - 1);
            sw.Stop();
            long ticksQuick = sw.ElapsedTicks;
            DisplayArrayToConsole(sorted2);

            Console.WriteLine($"\n\nNumber of ticks for merge sort:   {ticksMerge}");
            Console.WriteLine($"Number of ticks for merge sort 2: {ticksMerge2}");
            Console.WriteLine($"Number of ticks for quick sort:   {ticksQuick}");

            Console.ReadKey();
        }

        static int[] PopulateArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1000);
            }
            return array;
        }

        static void DisplayArrayToConsole(int[] array)
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i],3} ");
                if ((i + 1) % 20 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine("\n\n");
        }
    }
}
