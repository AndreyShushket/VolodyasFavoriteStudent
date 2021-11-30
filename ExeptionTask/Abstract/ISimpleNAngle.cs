using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionTask
{
    interface ISimpleNAngle
    {
        double hight { get; set; }
        double bottom { get; set; }
        double angleBetweenBaseAndAdjacentSide { get; set; }
        double numberOfSides { get; set; }
        double lengthsOfSides { get; set; }
        double square { get; }
        double perimetr { get; }
    }
}
