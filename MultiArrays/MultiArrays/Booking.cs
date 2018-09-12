using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArrays
{
    class Booking
    {
        public string Name { get; private set; }
        public int Ticket { get; private set; }

        public static bool[,] seats = new bool[15, 10];

        public Booking(string name, bool adult)
        {
            Name = name;
            Ticket = SetTicket(adult);
        }

        int SetTicket(bool adult)
        {
            return adult ? 20 : 10;
        }

        public static bool CheckSeats()
        {
            for(int row = 0; row < seats.GetLength(0); row++)
                for (int col = 0; col < seats.GetLength(1); col++)
                    if(seats[row, col])
                        return true;
            return false;
        }
    }
}
