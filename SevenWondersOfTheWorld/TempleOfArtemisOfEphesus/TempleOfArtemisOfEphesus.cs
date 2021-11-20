using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersOfTheWorld
{
    class TempleOfArtemisOfEphesus : SevenWondersOfTheWorld
    {
        public string templeOfArtemisLocation { get { return location; } }

        public int templeOfArtemisBuildTime { get { return buildTime; } }

        public string templeOfArtemisName { get { return name; } }

        public TempleOfArtemisOfEphesus()
        {
            location = "Turkey";
            buildTime = -550;
            name = "Temple of Artemis of Ephesus";
        }
    }
}
