using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = new double[1000];

            Random random = new Random();

            for(int i = 0; i < 1000; i++)
            {
                nums[i] = random.NextDouble() * 10;
            }

            nums = nums.OrderBy(x => x).ToArray();

            foreach(double num in nums)
            {
                Console.WriteLine($"{num:N4}");
            }

            Console.ReadKey();
        }
    }
}
