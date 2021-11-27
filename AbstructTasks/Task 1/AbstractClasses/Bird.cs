using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructTasks
{
    abstract class Bird : Animal
    {
        public string Name;

        public Bird(string Name) => this.Name = Name;
    }
}
