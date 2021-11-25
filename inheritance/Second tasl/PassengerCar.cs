using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class PassengerCar : Auto
    {
        public PassengerCar(string model, int number, double speed, int liftingCapacity) : base(model, number, speed)
        {
            this.liftingCapacity = liftingCapacity;
        }
    }
}
