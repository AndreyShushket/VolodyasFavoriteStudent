using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructTasks
{
    class Chicken : Bird, IFly
    {
        public Chicken() : base("hicken")
        {

        }

        public void Fly()
        {
            Console.WriteLine("Chicken is flying");
            Console.WriteLine("but not far");
        }
    }
}
