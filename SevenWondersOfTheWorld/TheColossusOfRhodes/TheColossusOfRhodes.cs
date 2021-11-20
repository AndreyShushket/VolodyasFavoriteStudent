using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersOfTheWorld
{
    class TheColossusOfRhodes : SevenWondersOfTheWorld
    {
        public string colossusLocation { get { return location; } }

        public int colossusBuildTime { get { return buildTime; } }

        public string colossusName { get { return name; } }

        public TheColossusOfRhodes()
        {
            location = "Greece";
            buildTime = -294;
            name = "The Colossus of Rhodes";
        }
    }
}
