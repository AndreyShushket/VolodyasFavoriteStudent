using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructTasks
{
    abstract class Person
    {
        public string name { get; set; }

        public Person(string name)
        {
            this.name = name;
            Console.WriteLine("Constructor Person");
        }
    }
}
