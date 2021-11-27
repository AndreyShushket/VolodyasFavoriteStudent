using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class ElectricBus : Trolleybus
    {
        public ElectricBus()
        {

        }

        public ElectricBus(int numberOFTransport, string destination, int numberOfSeats, double firstVoyage) : base(numberOFTransport, destination, numberOfSeats, firstVoyage)
        {

        }
    }
}
