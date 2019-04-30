using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class DisplayCollection<T>
    {
        public void DisplayCollectionData(IEnumerable<T> collection)
        {
            foreach(var i in collection)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
