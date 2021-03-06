using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var bus = new Bus("Minsk", 107, "13:30", 60);
            bus.GetInfo();

            var secondBus = new Task2Bus(62, "Mat", 14, 07.30);
            var electricTrain = new ElectricTrain(12, "Odin", 200, 13.50, 10, true);
            var miniBus = new Minibus(5, "Petrov", 10, 15.16);
            var electricBus = new ElectricBus(78, "Azar", 22, 09.50);
            var trampcar = new Tramcar(77, "Horvar", 20, 13.13, 2);
            var trollebus = new Trolleybus(504, "Deadon", 44, 10.00);
            var metro = new Metro(4, "Kastri", 68, 02.12, 4);
            
            Transport[] transport = new Transport[] {secondBus, electricTrain, miniBus, electricBus, trampcar, trollebus, metro};
            Array.Sort(transport);
            double clientTime = Convert.ToDouble(Console.ReadLine());
            string clientDestination = Console.ReadLine();

            foreach (Transport o in transport)
            {
                if(clientTime == o.FirstVoyage || clientDestination == o.Destination)
                {
                    o.GetInfo();
                }
                if(clientTime < o.FirstVoyage)
                {
                   o.GetInfo();
                   Console.WriteLine(o.GetTypeOfTransport(o));
                }
            }
            
            new TransportService().printTransportType(secondBus);
            new TransportService().printTransportType(electricTrain);
            new TransportService().printTransportType(miniBus);
            new TransportService().printTransportType(electricBus);
            new TransportService().printTransportType(trampcar);
            new TransportService().printTransportType(trollebus);
            new TransportService().printTransportType(metro);

            
            var passengersCar = new PassengerCar("Mazda", 1234, 60.0, 12);
            var passengersCarBig = new PassengerCar("Lada", 4672, 120.0, 24);
            var passengersCarSmall = new PassengerCar("Volovo", 1234, 30.0, 5);
            var truck = new Truck("Volvo", 7236, 50.0, true, 60);
            var truckBig = new Truck("Iveco", 1209, 40.0, true, 200);
            var truckSmall = new Truck("Dav", 9812, 80.0, false, 50);
            var motobike = new Motorbike("Bike", 2479, 90.0, 5, true);
            var motobikeBig = new Motorbike("Sike", 1297, 60.0, 5, true);
            var motobikeSmall = new Motorbike("Trik", 7854, 50.0, 5, false);

            Auto[] cars = new Auto[] { passengersCar, passengersCarBig, passengersCarSmall, truck, truckBig, truckSmall, motobike, motobikeBig, motobikeSmall};
            int clientWeightNeeded = Convert.ToInt32(Console.ReadLine());
            foreach (Auto o in cars)
            {
                if (o is PassengerCar)
                {
                    PassengerCar car = (PassengerCar)o;
                    car.GetInfo();
                }
                else if (o is Truck)
                {
                    Truck car = (Truck)o;
                    car.GetInfo();
                }
                else if (o is Motorbike)
                {
                    Motorbike car = (Motorbike)o;
                    car.GetInfo();
                }
            }
            foreach(Auto o in cars)
            {
                if (o.LiftingCapacity >= clientWeightNeeded)
                {
                    o.GetInfo();
                }
            }
        }
    }
}
