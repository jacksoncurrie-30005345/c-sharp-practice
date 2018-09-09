using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10000];
            Random random = new Random();

            for(int index = 0; index < nums.Length; index++)
                nums[index] = random.Next(10000, 99999);

            Dictionary<int, int> occurances = Frequency(nums);

            foreach(KeyValuePair<int, int> value in occurances)
            {
                if(value.Value > 1)
                    Console.WriteLine("{0} : {1}", value.Key, value.Value);
            }

            Console.ReadKey();

        }

        static Dictionary<int, int> Frequency(int[] nums)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (int value in nums)
            {
                if (!frequency.ContainsKey(value))
                    frequency.Add(value, 0);
            }

            foreach (int x in nums)
            {
                foreach (int y in nums)
                {
                    if (x == y)
                        frequency[x]++;
                }
            }

            return frequency;
        }
    }
}
