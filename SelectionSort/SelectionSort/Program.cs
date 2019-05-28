using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main()
        {
            int[] randomArray1 = PopulateArray(20000);
            int[] randomArray2 = PopulateArray(20000);
            int[] randomArray3 = PopulateArray(20000);

            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            int[] selectionSortedArray = SelectionSort(randomArray1);
            sw.Stop();
            decimal timeSelection = Convert.ToDecimal(sw.ElapsedMilliseconds);
            DisplayArrayToConsole(selectionSortedArray);

            sw = Stopwatch.StartNew();
            sw.Start();
            int[] bubbleSortedArray = BubbleSort(randomArray2);
            sw.Stop();
            decimal timeBubble = Convert.ToDecimal(sw.ElapsedMilliseconds);
            DisplayArrayToConsole(bubbleSortedArray);

            sw = Stopwatch.StartNew();
            sw.Start();
            int[] insertionSortedArray = InsertionSort(randomArray3);
            sw.Stop();
            decimal timeInsertion = Convert.ToDecimal(sw.ElapsedMilliseconds);
            DisplayArrayToConsole(insertionSortedArray);

            Console.WriteLine($"\n\nTime taken for selection: {timeSelection} ms");
            Console.WriteLine($"Time taken for bubble: {timeBubble} ms");
            Console.WriteLine($"Time taken for insertion: {timeInsertion} ms ");
            Console.ReadKey();
        }

        static int[] PopulateArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1000);
            }
            return array;
        }

        static void DisplayArrayToConsole(int[] array)
        {
            Console.WriteLine("\nArray:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i], 3} ");
                if ((i + 1) % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
            return array;
        }

        static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return array;
        }
    }
}
