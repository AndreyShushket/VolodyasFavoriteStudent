using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Truck : Auto 
    {
        private bool trailer { get; set; }

        public bool Trailer { get { return trailer; } }

        public Truck(string model, int number, double speed, bool trailer, int liftingCapacity) : base(model, number, speed)
        {
            this.trailer = trailer;
            this.liftingCapacity = liftingCapacity;
            if (trailer == true)
            {
                this.liftingCapacity *= 2;
            }
        }

        public void GetInfo() => Console.WriteLine($"Model is {model}, number is {number},speed is {speed}, lifting capasity is {liftingCapacity}. Have trailer? {trailer}");
    }
}
