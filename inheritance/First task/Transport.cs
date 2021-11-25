using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Transport : IComparable<Transport>
    {
        private protected int numberOFTransport { get; set; }

        private protected string destination { get; set; }

        private protected int numberOfSeats { get; set; }

        private protected double firstVoyage { get; set; }

        public int NumberOFTransport { get { return numberOfSeats; } }

        public string Destination { get { return destination; } }

        public int NumberOfSeats { get { return numberOfSeats; } }

        public double FirstVoyage { get { return firstVoyage; } }

        public Transport()
        {

        }

        public Transport(int numberOFTransport, string destination, int numberOfSeats, double firstVoyage)
        {
            this.numberOFTransport = numberOFTransport;
            this.destination = destination;
            this.numberOfSeats = numberOfSeats;
            this.firstVoyage = firstVoyage;
        }

        public string GetTypeOfTransport(Transport transport)
        {
            if(transport is ElectricBus)
            {
                ElectricBus car = (ElectricBus)transport;
                return car.GetTypeOfTransport();
            }
            else if(transport is ElectricTrain)
            {
                ElectricTrain car = (ElectricTrain)transport;
                return car.GetTypeOfTransport();
            }
            else if (transport is Tramcar)
            {
                Tramcar car = (Tramcar)transport;
                return car.GetTypeOfTransport();
            }
            else if (transport is Minibus)
            {
                Minibus car = (Minibus)transport;
                return car.GetTypeOfTransport();
            }
            else if (transport is Trolleybus)
            {
                Trolleybus car = (Trolleybus)transport;
                return car.GetTypeOfTransport();
            }
            else if (transport is Metro)
            {
                Metro car = (Metro)transport;
                return car.GetTypeOfTransport();
            }
            else if (transport is Task2Bus)
            {
                Task2Bus car = (Task2Bus)transport;
                return car.GetTypeOfTransport();
            }
            else
            {
                return "Unknown";
            }

        }

        //public static void GetFkcd() => Console.WriteLine("Method GetFkcd");
        public int CompareTo(Transport transport) => this.numberOfSeats.CompareTo(transport.numberOfSeats);
        public void GetInfo() => Console.WriteLine($" Number of transport is {NumberOFTransport}, destination is {Destination}, number of seats is {NumberOfSeats}, first voyage is {FirstVoyage}");
    }
}
