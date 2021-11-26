using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructTasks
{
    class Penguin : Bird, ISwimable
    {
        public Penguin() : base("penguin")
        {
            
        }

        public void Swim() => Console.WriteLine("Penguin is swimming");

        public override void Fly(Bird bird) => Console.WriteLine("penguin cannot fly");
    }
}
