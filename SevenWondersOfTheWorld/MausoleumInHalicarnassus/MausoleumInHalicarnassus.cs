using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersOfTheWorld
{
    class MausoleumInHalicarnassus : SevenWondersOfTheWorld
    {
        public string mausoleumInHalicarnassusLocation { get { return location; } }

        public int mausoleumInHalicarnassusBuildTime { get { return buildTime; } }

        public string mausoleumInHalicarnassusName { get { return name; } }

        public MausoleumInHalicarnassus()
        {
            location = "Turkey";
            buildTime = -351;
            name = "Mausoleum in Halicarnassus";
        }
    }
}
