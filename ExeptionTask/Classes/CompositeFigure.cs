using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionTask
{
    class CompositeFigure
    {
        public ISimpleNAngle[] simpleNAngles1;

        public CompositeFigure(params ISimpleNAngle[] simpleNAngles)
        {
            this.simpleNAngles1 = simpleNAngles;
        }

        public void GetArea()
        {
            //double area = 0.0;
            foreach( ISimpleNAngle s in simpleNAngles1)
            {
                if(s is Square)
                {
                    Square square = (Square)s;
                    Console.WriteLine(s.square * (simpleNAngles1.Length));
                    break;
                }
                else if (s is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)s;
                    Console.WriteLine(s.square * (simpleNAngles1.Length));
                    break;
                }
                else if (s is Triangle)
                {
                    Triangle triangle = (Triangle)s;
                    Console.WriteLine(s.square * (simpleNAngles1.Length));
                    break;
                }
                else
                {
                    Console.WriteLine("isnt a simle angke");
                    break;
                }
            }
        }

        public override string ToString()
        {
            return $"made from {simpleNAngles1.Length + 1} figures";
        }

        public override bool Equals(object obj)
        {
            if(obj.GetType() != this.GetType())
            {
                return false;
            }

            CompositeFigure compositeFigure = (CompositeFigure)obj;
            return (this.simpleNAngles1.Length + 1 == compositeFigure.simpleNAngles1.Length + 1);
        }
    }
}
