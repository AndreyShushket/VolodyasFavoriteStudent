using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructTasks
{
    class Penguin : Bird, ISwimable, IFly
    {
        public Penguin() : base("penguin")
        {
            
        }

        public void Swim() => Console.WriteLine("Penguin is swimming");

        public void Fly() => Console.WriteLine("penguin cannot fly");
    }
}
