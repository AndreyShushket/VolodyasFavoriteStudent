using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Auto
    {
        private protected string model { get; set; }

        private protected int number { get; set; }

        private protected double speed { get; set; }

        private protected int liftingCapacity { get; set; }

        public string Model { get { return model; } }

        public int Number { get { return number; } }

        public double Speed { get { return speed; } }

        public int LiftingCapacity { get { return liftingCapacity; } }

        public Auto()
        {

        }

        public Auto(string model, int number, double speed)
        {
            this.model = model;
            this.number = number;
            this.speed = speed;
            this.liftingCapacity = liftingCapacity;
        }

        public void GetInfo() => Console.WriteLine($"Model is {model}, number is {number},speed is {speed}, lifting capasity is {liftingCapacity}");

        public int GetLiftCapasity(PassengerCar passengerCar) => passengerCar.liftingCapacity;

        public int GetLiftCapasity(Truck truck)
        {
            if(truck.Trailer)
            {
                return truck.liftingCapacity *= 2;
            }
            else
            {
                return truck.liftingCapacity;
            }
        }

        public int GetLiftCapasity(Motorbike motorbike )
        {
            if (motorbike.Stroller)
            {
                return motorbike.liftingCapacity;
            }
            else
            {
                return motorbike.liftingCapacity = 0;
            }
        }
    }
}
