using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionTask
{
    class Triangle : GeometricFigure, ISimpleNAngle
    {
        private double sideA;
        public double SideA { 
            get 
            {
                return sideA;
            } 
            set 
            {
                if( value < 0 )
                {
                    Console.WriteLine("enter correct number");
                }
                else
                {
                    sideA = value;
                }
            } 
        }

        private double sideC;
        public double SideC {
            get
            {
                return sideC;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("enter correct number");
                }
                else
                {
                    sideC = value;
                }
            }
        }

        private double sideB;
        public double SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                if (value < 0 || value > sideA + sideC)
                {
                    Console.WriteLine("enter correct number");
                }
                else
                {
                    sideB = value;
                }
            }
        }

        public double hight { get; set; }

        public double bottom { get; set; }

        public double angleBetweenBaseAndAdjacentSide { get; set; }

        public double numberOfSides { get; set; }

        public double lengthsOfSides { get; set; }

        public double square { get { return 0.5 * SideA * SideB; } }

        public double perimetr { get; }

        public Triangle(double sideA, double sideC, double sideB)
        {
            SideA = sideA;
            SideC = sideC;
            SideB = sideB;
        }
    }
}
