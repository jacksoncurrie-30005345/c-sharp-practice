using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomEscape
{
    class Room
    {
        string name;
        bool north;
        bool south;
        bool east;
        bool west;
        bool key;
        bool end;

        public string Name { get => name; set => name = value; }
        public bool North { get => north; set => north = value; }
        public bool South { get => south; set => south = value; }
        public bool East { get => east; set => east = value; }
        public bool West { get => west; set => west = value; }
        public bool Key { get => key; set => key = value; }
        public bool End { get => end; set => end = value; }

        public Room(string _name, bool _north, bool _south, bool _east, bool _west, bool _key, bool _end)
        {
            Name = _name;
            North = _north;
            South = _south;
            East = _east;
            West = _west;
            Key = _key;
            End = _end;
        }
    }
}
