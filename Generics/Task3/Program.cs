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
            int[] a = { 1, 2, 3, 4 };
            DisplayCollection<int> displayInts = new DisplayCollection<int>();
            displayInts.DisplayCollectionData(a);

            string[] b = { "a", "b", "c", "d" };
            DisplayCollection<string> displayStrings = new DisplayCollection<string>();
            displayStrings.DisplayCollectionData(b);

            List<int> c = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            DisplayCollection<int> displayList = new DisplayCollection<int>();
            displayList.DisplayCollectionData(c);

            Console.ReadKey()
        }
    }
}
