using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belarus;
using Germany;
using Ukraine;

namespace _3Countreis3Capitals
{
    class CompareCountriesClass
    {
        public void ComparePopulation()
        {
            if(new Kiev().population > new Berlin().population)
            {
                Console.WriteLine("Kiev larger then Berlin");
                if(new Kiev().population > new Minsk().population)
                {
                    Console.WriteLine("Kiev larger then Minsk");
                }
                else
                {
                    Console.WriteLine("Kiev smaller then Minsk");
                }
            }
            else
            {
                Console.WriteLine("Kiev smaller then Berlin");
                if (new Berlin().population > new Minsk().population)
                {
                    Console.WriteLine("Berlin larger then Minsk");
                }
                else
                {
                    Console.WriteLine("Berlin smaller then Minsk");
                }
            }
        }
    }
}
