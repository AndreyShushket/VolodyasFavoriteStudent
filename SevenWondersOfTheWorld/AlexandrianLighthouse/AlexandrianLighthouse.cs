using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersOfTheWorld
{
    class AlexandrianLighthouse : SevenWondersOfTheWorld
    {
        public string alexandrianLighthouseLocation { get { return location; } }

        public int alexandrianLighthouseBuildTime { get { return buildTime; } }

        public string alexandrianLighthouseName { get { return name; } }

        public AlexandrianLighthouse()
        {
            location = "Egypt, Alexandria";
            buildTime = -279;
            name = "Alexandrian Lighthouse";
        }
    }
}
