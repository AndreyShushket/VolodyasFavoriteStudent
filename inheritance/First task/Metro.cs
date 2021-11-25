using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Metro : Transport
    {
        private protected int numberOfCars { get; set; }

        public int NumberOfCars { get { return numberOfCars; } }
        public Metro()
        {

        }

        public Metro(int numberOFTransport, string destination, int numberOfSeats, double firstVoyage, int numberOfCars) : base(numberOFTransport, destination, numberOfSeats, firstVoyage) => this.numberOfCars = numberOfCars;
        public string GetTypeOfTransport() => "Rail";
        public void GetInfo() => Console.WriteLine($" Number of transport is {NumberOFTransport}, destination is {Destination}, number of seats is {NumberOfSeats}, first voyage is {FirstVoyage}, number of cars is {NumberOfCars}");
    }
}
