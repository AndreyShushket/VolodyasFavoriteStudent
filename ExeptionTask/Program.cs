using System;

namespace ExeptionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ISimpleNAngle square = new Square(4.0);
            ISimpleNAngle square1 = new Square(4.0);
            ISimpleNAngle square2 = new Square(4.0);
            ISimpleNAngle square3 = new Square(4.0);

            CompositeFigure compositeFigure = new CompositeFigure(square, square1, square2, square3);

            compositeFigure.GetArea();

            ISimpleNAngle triangle = new Triangle(3, 2, 4);
        }
    }
}
