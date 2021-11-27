using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructTasks
{
    class Parrot : Bird, IFly
    {
        public Parrot() : base("parrot")
        {

        }
        public void Fly() => Console.WriteLine("Parrot is flying");
    }
}
