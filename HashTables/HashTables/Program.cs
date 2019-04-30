using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter name: ");
                dict.Add(i, Console.ReadLine());
            }

            Console.Write("\nCheck if contains: ");
            Console.WriteLine(dict.ContainsValue(Console.ReadLine()) + "\n");

            string[] names = new string[dict.Count];

            for(int i = 0; i < names.Length; i++)
            {
                names[i] = dict[i];
            }

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
