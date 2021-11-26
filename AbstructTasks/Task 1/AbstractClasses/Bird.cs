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

        public virtual void Fly(Bird bird)
        {
            if(bird is Chicken)
            {
                Console.WriteLine("chicken is flying");
            }
            else if(bird is  Penguin)
            {
                Console.WriteLine("penguin is flying");
            }
            else if(bird is Parrot)
            {
                Console.WriteLine("parrot is flying");
            }
        }
    }
}
