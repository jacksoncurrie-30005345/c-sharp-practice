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
            Console.WriteLine("\n+-------------------------------------------------------------------------+\n" +
                                "|                                  Car                                    |\n" +
                                "|-------------------------------------------------------------------------|\n" +
                                "| - colour: string                                                        |\n" +
                                "| - make: string                                                          |\n" +
                                "| - gearbox: string                                                       |\n" +
                                "|-------------------------------------------------------------------------|\n" +
                                "| + GetColour(): string                                                   |\n" +
                                "| - SetColour(col: string)                                                |\n" +
                                "| + GetMake(): string                                                     |\n" +
                                "| - SetMake(mk: string)                                                   |\n" +
                                "| + GetGearbox(): string                                                  |\n" +
                                "| - SetGearbox(gbox: string)                                              |\n" +
                                "| + <<constructor>> Car(_colour: string, _make: string, _gearbox: string) |\n" +
                                "+-------------------------------------------------------------------------+\n"
            );
        }
    }
}
