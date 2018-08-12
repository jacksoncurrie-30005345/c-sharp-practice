using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Bus
    {
        // Properties
        string colour;
        string rego;
        int doors;
        int seats;

        // Getting and setting properties
        public string GetColour() => colour;
        public void SetColour(string col) => colour = col;
        public string GetRego() => rego;
        public void SetRego(string reg) => rego = reg;
        public int GetDoors() => doors;
        public void SetDoors(int door) => doors = door;
        public int GetSeats() => seats;
        public void SetSeats(int seat) => seats = seat;
    }
}
