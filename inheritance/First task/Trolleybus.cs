using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Trolleybus : Task2Bus
    {
        public Trolleybus()
        {

        }

        public Trolleybus(int numberOFTransport, string destination, int numberOfSeats, double firstVoyage) : base(numberOFTransport, destination, numberOfSeats, firstVoyage)
        {

        }

        public string GetTypeOfTransport() => "Electric";
    }
}
