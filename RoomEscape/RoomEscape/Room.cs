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
        bool isNorth;
        bool isSouth;
        bool isEast;
        bool isWest;
        bool isKey;
        bool isEnd;

        public string Name { get => name; set => name = value; }
        public bool IsNorth { get => isNorth; set => isNorth = value; }
        public bool IsSouth { get => isSouth; set => isSouth = value; }
        public bool IsEast { get => isEast; set => isEast = value; }
        public bool IsWest { get => isWest; set => isWest = value; }
        public bool IsKey { get => isKey; set => isKey = value; }
        public bool IsEnd { get => isEnd; set => isEnd = value; }

        public Room(string _name, bool _isNorth, bool _isSouth, bool _isEast, bool _isWest)
        {
            Name = _name;
            IsNorth = _isNorth;
            IsSouth = _isSouth;
            IsEast = _isEast;
            IsWest = _isWest;
            IsKey = false;
            IsEnd = false;
        }
    }
}
