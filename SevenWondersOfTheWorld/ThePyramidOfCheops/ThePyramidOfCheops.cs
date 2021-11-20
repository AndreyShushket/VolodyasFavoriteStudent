using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersOfTheWorld
{
    class ThePyramidOfCheops : SevenWondersOfTheWorld
    {
        public string pyramidLocation { get { return location; } }

        public int pyramidBuildTime { get { return buildTime; } }

        public string pyramidName { get { return name; } }

        public ThePyramidOfCheops()
        {
            location = "Giza";
            buildTime = -2600;
            name = "The Pyramid of Cheops";
        }
    }
}
