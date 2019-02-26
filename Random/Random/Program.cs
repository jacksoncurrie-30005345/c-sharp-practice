using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] randomBytes = new byte[1000];

            Random random = new Random();
            random.NextBytes(randomBytes);

            randomBytes = randomBytes.OrderByDescending(c => c).ToArray();

            foreach (byte num in randomBytes)
            {
                Console.Write($"{num, 4}");
            }

            Console.ReadKey();
        }
    }
}
