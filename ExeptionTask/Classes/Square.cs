using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionTask
{
    class Square : GeometricFigure, ISimpleNAngle
    {
        private double sideA;
        public double SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("enter correct number");
                }
                else
                {
                    sideA = value;
                }
            }
        }

        public double hight { get; set; }

        public double bottom { get; set; }

        public double angleBetweenBaseAndAdjacentSide { get; set; }

        public double numberOfSides { get; set; }

        public double lengthsOfSides { get; set; }

        public double square { get { return SideA * SideA; } }

        public double perimetr { get; set; }

        public Square(double sideA)
        {
            SideA = sideA;
        }
    }
}
