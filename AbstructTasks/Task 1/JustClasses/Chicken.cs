using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructTasks
{
    class Chicken : Bird
    {
        public Chicken() : base("hicken")
        {

        }

        public override void Fly(Bird bird)
        {
            base.Fly(bird);
            Console.WriteLine("but not far");
        }
    }
}
