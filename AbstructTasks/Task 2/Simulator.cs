using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructTasks
{
    abstract class Simulator : IMoveble
    {
        public static void Move(string position, Ball ball, params FieldPlayer[] fieldPlayers)
        {
            Console.Write("мяч ");
            foreach(FieldPlayer fieldPlayer in fieldPlayers)
            {
                Console.Write($"{fieldPlayer.name} ");
            }
            if(position == Position.Center)
            {
                Console.WriteLine(Position.Center);
            }
            else
            {
                Console.WriteLine(Position.PenaltyArea);
            }
        }

        public static void Move(string position, params FieldPlayer[] fieldPlayers)
        {
            foreach (FieldPlayer fieldPlayer in fieldPlayers)
            {
                Console.Write($"{fieldPlayer.name} ");
            }
            if (position == Position.Center)
            {
                Console.WriteLine(Position.Center);
            }
            else
            {
                Console.WriteLine(Position.PenaltyArea);
            }
        }

        public static void Move(string position, Ball ball)
        {
            Console.Write("мяч ");

            if (position == Position.Center)
            {
                Console.WriteLine(Position.Center);
            }
            else
            {
                Console.WriteLine(Position.PenaltyArea);
            }
        }
    }
}
