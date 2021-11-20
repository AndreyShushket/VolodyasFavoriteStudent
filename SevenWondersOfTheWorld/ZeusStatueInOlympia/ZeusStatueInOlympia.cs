using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersOfTheWorld
{
    class ZeusStatueInOlympia : SevenWondersOfTheWorld
    {
        public string zeusLocation { get { return location; } }

        public int zeusBuildTime { get { return buildTime; } }

        public string zeusName { get { return name; } }

        public ZeusStatueInOlympia()
        {
            location = "Greece";
            buildTime = -430;
            name = "Zeus Statue in Olympia";
        }
    }
}
