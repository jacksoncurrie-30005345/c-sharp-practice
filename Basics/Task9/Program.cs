using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class Program
    {
        public static void Main()
        {
            string[] names = { "Jack", "John", "Luke", "Lisa", "Mary" };
            Console.WriteLine("Names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
