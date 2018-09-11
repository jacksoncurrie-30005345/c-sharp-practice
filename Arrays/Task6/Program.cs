using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class Program
    {
        public static void Main()
        {
            Random random = new Random();
            int[] nums = new int[100];

            for(int i = 0; i < nums.Length; i++)
                nums[i] = random.Next(1, 1000);

            Array.Sort(nums);

            Console.WriteLine
            (
                $"Second Highest : {nums[1]}\n" +
                $"Second Lowest  : {nums[98]}"
            );
        }
    }
}
