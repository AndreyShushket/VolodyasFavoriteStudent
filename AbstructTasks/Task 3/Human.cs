using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructTasks
{
    class Human : IDrink,IDrinkTwo
    {
        void IDrink.Sip() => Console.WriteLine("human");
        void IDrinkTwo.Sip() => Console.WriteLine("human");
    }
}
