using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class ElectricTrain : Metro
    {
        private protected bool intercity { get; set; }

        public bool Intercity { get { return intercity; } }
        public ElectricTrain()
        {

        }

        public ElectricTrain(int numberOFTransport, string destination, int numberOfSeats, double firstVoyage, int numberOfCars, bool intercity) : base(numberOFTransport, destination, numberOfSeats, firstVoyage, numberOfCars) => this.intercity = intercity;

        public string GetTypeOfTransport() => "Rail and electric";
        public void GetInfo() => Console.WriteLine($" Number of transport is {NumberOFTransport}, destination is {Destination}, number of seats is {NumberOfSeats}, first voyage is {FirstVoyage}, number of cars is {NumberOfCars}, intercity{Intercity}");
    }
}
