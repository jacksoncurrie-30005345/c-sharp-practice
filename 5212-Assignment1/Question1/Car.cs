using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Car
    {
        // Properties
        string colour;
        string make;
        string gearbox;

        // Colour
        public string GetColour() => colour;
        public void SetColour(string col) => colour = col;

        // Make
        public string GetMake() => make;
        public void SetMake(string mk) => make = mk;

        // Gearbox
        public string GetGearbox() => gearbox;
        public void SetGearbox(string gbox) => gearbox = gbox;
    }
}
