using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 10000;
            int[] array = PopulateArray(SIZE);
            DisplayArrayToConsole(array);

            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            int[] sortedArray = SortArray(array);
            sw.Stop();
            decimal ticksInsertion = Convert.ToDecimal(sw.ElapsedTicks);
            DisplayArrayToConsole(sortedArray);

            sw = Stopwatch.StartNew();
            sw.Start();
            int[] bubbleSort = BubbleSort(array);
            sw.Stop();
            decimal ticksBubble = Convert.ToDecimal(sw.ElapsedTicks);
            DisplayArrayToConsole(bubbleSort);
            
            Console.WriteLine($"\n\nTicks taken for insertion: {ticksInsertion}");
            Console.WriteLine($"Ticks taken for bubble: {ticksBubble}");
            Console.WriteLine($"Improvment: {((ticksBubble - ticksInsertion) / ticksBubble) * 100:N2}%");
            Console.ReadKey();
        }

        static int[] PopulateArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            for(int i = 0; i < size; i++)
            {
                array[i] = random.Next(1000);
            }
            return array;
        }

        static int[] SortArray(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    if(array[j] < array[j - 1])
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

        static void DisplayArrayToConsole(int[] array)
        {
            Console.WriteLine("\nArray:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i],3} ");
                if((i + 1) % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
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
    }
}
