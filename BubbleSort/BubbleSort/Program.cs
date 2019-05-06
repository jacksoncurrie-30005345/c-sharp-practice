using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayStandard = Populate(1000);
            int[] arrayImporved = Populate(1000);
            Stopwatch watchStandard = Stopwatch.StartNew();
            Stopwatch watchImproved = Stopwatch.StartNew();

            watchStandard.Start();
            arrayStandard = StandardBubbleSort(arrayStandard);
            watchStandard.Stop();

            watchImproved.Start();
            arrayImporved = StandardBubbleSort(arrayImporved);
            watchImproved.Stop();

            Console.WriteLine("Standard sorting method:");
            foreach (int value in arrayStandard)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("\n\nImproved sorting method:");
            foreach (int value in arrayImporved)
            {
                Console.Write(value + " ");
            }

            decimal ticksStandard = Convert.ToDecimal(watchStandard.ElapsedTicks);
            decimal ticksImproved = Convert.ToDecimal(watchImproved.ElapsedTicks);
            Console.WriteLine($"\n\nTicks taken for standard: {ticksStandard}");
            Console.WriteLine($"Ticks taken for improved: {ticksImproved}");
            Console.WriteLine($"Improvment: {(ticksStandard/ticksImproved)*100:N2}%");
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

        static int[] StandardBubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        static int[] ImprovedBubbleSort(int[] array)
        {
            int lengthToCheck = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                bool complete = true;
                for (int j = 0; j < lengthToCheck - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                        complete = false;
                    }
                }
                if (complete)
                    break;
                lengthToCheck--;
            }
            return array;
        }
    }
}
