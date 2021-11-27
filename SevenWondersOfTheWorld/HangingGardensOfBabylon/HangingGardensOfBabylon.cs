using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersOfTheWorld
{
    class HangingGardensOfBabylon : SevenWondersOfTheWorld
    {
        public string hangingGardensOfBabylonLocation { get { return location; } }

        public int hangingGardensOfBabylonBuildTime { get { return buildTime; } }

        public string hangingGardensOfBabylonName { get { return name; } }

        public HangingGardensOfBabylon()
        {
            location = "Iraq, El Hilla or Mosul";
            buildTime = -605;
            name = "Hanging Gardens of Babylon";
        }
    }
}
