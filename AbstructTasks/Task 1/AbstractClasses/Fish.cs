using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructTasks
{
    abstract class Fish : Animal, ISwimable
    {
        public void Swim() => Console.WriteLine("Fish is swimming");
    }
}
