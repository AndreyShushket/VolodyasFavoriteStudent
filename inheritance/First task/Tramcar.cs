using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Tramcar : Metro
    {
        public Tramcar()
        {

        }

        public Tramcar(int numberOFTransport, string destination, int numberOfSeats, double firstVoyage, int numberOfCars) : base(numberOFTransport, destination, numberOfSeats, firstVoyage, numberOfCars)
        {

        }

        public string GetTypeOfTransport() => "Rail and electric";
        public void GetInfo() => Console.WriteLine($" Number of transport is {NumberOFTransport}, destination is {Destination}, number of seats is {NumberOfSeats}, first voyage is {FirstVoyage}, number of cars is {NumberOfCars}");
    }
}
