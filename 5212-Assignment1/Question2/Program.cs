/* 
 * Author      : Jackson Currie - 30005345
 * Date        : 2018-08-16
 * Description : Question 2 UML class diagram.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("+---------------------------------------------------------------+\n" +
                              "|                             Car                               |\n" +
                              "|---------------------------------------------------------------|\n" +
                              "| + <<property>> Colour: string                                 |\n" +
                              "| + <<property>> Make: string                                   |\n" +
                              "| + <<property>> Gearbox: string                                |\n" +
                              "|---------------------------------------------------------------|\n" +
                              "|                                                               |\n" +
                              "+---------------------------------------------------------------+\n"
            );
        }
    }
}
