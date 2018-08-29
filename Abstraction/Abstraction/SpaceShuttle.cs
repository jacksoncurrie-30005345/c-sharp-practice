using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class SpaceShuttle : SpaceStation
    {
        public SpaceShuttle(int _power)
        {
            Console.WriteLine("Power: " + Laser(_power));
        }

        protected override object Laser(object power)
        {
            return (int)power;
        }
    }
}
