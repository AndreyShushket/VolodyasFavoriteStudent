using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Motorbike : Auto
    {
        private bool stroller { get; set; }

        public bool Stroller { get { return stroller; } }
        public Motorbike(string model, int number, double speed, int liftingCapacity, bool stroller) : base(model, number, speed)
        {
            this.stroller = stroller;
            this.liftingCapacity = liftingCapacity;
            if (stroller == false)
            {
                this.liftingCapacity = 0;
            }
        }

        public void GetInfo() => Console.WriteLine($"Model is {Model}, number is {Number},speed is {Speed}, lifting capasity is {LiftingCapacity}. Have stroller? {stroller}");
    }
}
