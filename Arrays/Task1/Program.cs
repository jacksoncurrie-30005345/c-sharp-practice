using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            int[] nums = new int[10];

            for(int index = 0; index < nums.Length; index++)
            {
                Console.Write("Enter number: ");
                nums[index] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            foreach (int num in nums)
                Console.Write(num + " ");

            Console.WriteLine();
        }
    }
}
