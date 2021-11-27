using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersOfTheWorld
{
     class SevenWondersOfTheWorld
    {
        private protected string location;
        private protected int buildTime;
        private protected string name;
        public void GetInfo()
        {
            Console.WriteLine($"{name}, {location}, { buildTime}");
        }
    }
}
