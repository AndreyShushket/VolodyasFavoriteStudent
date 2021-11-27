using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Bus
    {
        private string destination { get; set; }

        private int busNuber { get; set; }

        private string departureTime { get; set; }

        private int numberOfSeats { get; set; }

        public Bus(string destination, int busNuber, string departureTime, int numberOfSeats)
        {
            this.destination = destination;
            this.busNuber = busNuber;
            this.departureTime = departureTime;
            this.numberOfSeats = numberOfSeats;
        }

        public void GetInfo() => Console.WriteLine($"Destination is {destination}, bus nuber is {busNuber}, departure time is {departureTime}, number of seats is {numberOfSeats}");
    }
}
