using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Homework
{
    class Square
    {
        public int lenght;
        public string colour;
        public double area;

        public Square(int lenght, string colour)
        {
            this.lenght = lenght;
            this.colour = colour;

            area = lenght * lenght;
        }

        public void SquareInfo()
        {
            Console.WriteLine($"Square lenght is {lenght}, colour is {colour}, area is {area}.");
        }
    }
}
