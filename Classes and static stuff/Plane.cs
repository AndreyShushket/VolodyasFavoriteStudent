using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_static_stuff
{
    class Plane
    {
        private int Maxspeed { get; set; }

        private string colour { get; set; }

        private float cost { get; set; }

        private string name { get; set; }

        private double tankCapacity { get; set; }

        private bool abilityToFly = true;
        private double durability = 100.0;
        public static string MadeInCountry = "UK";
        public static bool blackBox;
        static Plane()
        {
            blackBox = true;
        }

        public Plane() : this(0)
        {

        }

        public Plane(int Maxspeed) : this(Maxspeed, "Unknown colour")
        {

        }

        public Plane(int Maxspeed, string colour) : this(Maxspeed, colour, 0f)
        {

        }

        public Plane(int Maxspeed, string colour, float cost) : this(Maxspeed, colour, cost, "Unknown name")
        {

        }

        public Plane(int Maxspeed, string colour, float cost, string name) : this(Maxspeed, colour, cost, name, 0)
        {

        }

        public Plane(int Maxspeed, string colour, float cost, string name, double tankCapacity)
        {
            this.Maxspeed = Maxspeed;
            this.colour = colour;
            this.cost = cost;
            this.name = name;
            this.tankCapacity = tankCapacity;
        }

        public double Fly()
        {
            if( durability > 30.0)
            {
                return durability = durability - 5.0;
            }
            else if(durability <= 30 && durability > 5)
            {
                Console.WriteLine($"Your plane has less then 30 durability({durability}, its may be dangerous to fly)");
                return durability = durability - 5.0;
            }
            else if(durability <= 5)
            {
                Console.WriteLine("Your plane is boken ");
                abilityToFly = false;
                return durability;
                
            }
            return durability;
        }

        public void GetRepair()
        {
            durability = 100.0;
            abilityToFly = true;
        }

        public void GetInfo() => Console.WriteLine($"{Maxspeed}, {colour}, {cost}, {name}, {tankCapacity}, {durability}, {abilityToFly}");
    }
}
