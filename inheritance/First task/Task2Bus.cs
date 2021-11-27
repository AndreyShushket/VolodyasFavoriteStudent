using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Task2Bus : Transport
    {
        public Task2Bus()
        {

        }

        public Task2Bus(int numberOFTransport, string destination, int numberOfSeats, double firstVoyage) : base(numberOFTransport, destination, numberOfSeats, firstVoyage)
        {

        }

        public string GetTypeOfTransport() => "Gas";
    }
}
