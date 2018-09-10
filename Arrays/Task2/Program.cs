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
            int[] nums = new int[1000];
            Random random = new Random();

            for(int index = 0; index < nums.Length; index++)
                nums[index] = random.Next(1, 101);

            Dictionary<int, int> occurances = Frequency(nums);
            var ordered = occurances.OrderBy(x => x.Value);

            foreach (KeyValuePair<int, int> value in ordered)
                Console.WriteLine("{0,3} : {1,2}", value.Key, value.Value);

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

            foreach (int value in frequency.Keys.ToList())
            {
                foreach (int y in nums)
                {
                    if (value == y)
                        frequency[value]++;
                }
            }

            return frequency;
        }
    }
}
