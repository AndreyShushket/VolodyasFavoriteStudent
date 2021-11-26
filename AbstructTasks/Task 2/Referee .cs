using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructTasks
{
    class Referee : Person
    {
        public Referee(string name) : base(name) => Console.WriteLine("Constructor Referee");

        public void Whistle() => Console.WriteLine($"Арбитр {name} свистит");
    }
}
