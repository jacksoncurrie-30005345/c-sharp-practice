using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Car
    {
        // Properties
        string colour;
        string make;
        string gearbox;

        // Colour
        public string GetColour() => colour;
        private void SetColour(string col) => colour = col;

        // Make
        public string GetMake() => make;
        private void SetMake(string mk) => make = mk;

        // Gearbox
        public string GetGearbox() => gearbox;
        private void SetGearbox(string gbox) => gearbox = gbox;

        // Constructor
        public Car(string _colour, string _make, string _gearbox)
        {
            SetColour(_colour);
            SetMake(_make);
            SetGearbox(_gearbox);
        }
    }
}
