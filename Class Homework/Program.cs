using System;

namespace Class_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Square greenSquare = new Square(5, "Green");
            Square blueSquare = new Square(2, "Blue");
            Square lightblueSquare = new Square(15, "Lightblue");

            greenSquare.SquareInfo();
            blueSquare.SquareInfo();
            lightblueSquare.SquareInfo();

            greenSquare.lenght = greenSquare.lenght * 3;

            greenSquare.SquareInfo();
            blueSquare.SquareInfo();
            lightblueSquare.SquareInfo();
        }
    }
}
