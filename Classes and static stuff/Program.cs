using System;

namespace Classes_and_static_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var civilPlane = new Plane(400, "White", 4000000f, "Mach", 10000.0);
            var battlePlane = new Plane(1200, "Blue", 120000000f, "SQRT-7", 5000.0);
            var farmPlane = new Plane(300, "Red", 300000f, "FarmFF", 3000.0);
            var boing787 = new Plane(550, "White", 50000000f, "B 787", 20000.0);
            var firstEverPlane = new Plane(200, "Brown", 120f, "First plane", 20.0);
            object[] planes = new object[5] { civilPlane, battlePlane, farmPlane, boing787, firstEverPlane };
        }
    }
}
