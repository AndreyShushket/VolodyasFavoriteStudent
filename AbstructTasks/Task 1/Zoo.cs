using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructTasks
{
    static class Zoo
    {
        public static void Swim(ISwimable swimable) => swimable.Swim();
    }
}
