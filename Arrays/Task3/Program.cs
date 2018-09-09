using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] nums = new int[100];

            for(int index = 0; index < nums.Length; index++)
            {
                int num;
                bool check = true;
                do
                {
                    num = random.Next(1, 101);
                    if (!nums.Contains(num))
                    {
                        nums[index] = num;
                        check = false;
                    }
                        
                }
                while (check);
            }

            foreach(int value in nums)
                Console.WriteLine(value);

            Console.ReadKey();
        }
    }
}
