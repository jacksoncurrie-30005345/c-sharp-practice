using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class DeathStar : SpaceStation
    {
        public DeathStar(string _power)
        {
            Console.WriteLine("Power: " + Laser(_power));
        }

        protected override object Laser(object power)
        {
            return (string)power;
        }
    }
}
