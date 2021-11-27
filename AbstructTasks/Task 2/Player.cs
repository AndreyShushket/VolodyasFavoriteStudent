using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructTasks
{
    abstract class Player : Person
    {
        public abstract string role { get; }

        public int cardCount = 0;

        public Player(string name) : base(name) => Console.WriteLine("Constructor Player");

        public void Pass(Player player) => Console.WriteLine($"{name} отдает пасс {player.name}");

        public void CatchBall() => Console.WriteLine($"{role} {name} берет мяч в руки");

        public void PickBooking()
        {
            if(cardCount < 1)
            {
                Console.WriteLine($"{role} {name} получает желтую карточку");
                cardCount++;
            }
            else
            {
                Console.WriteLine($"{role} {name} получает красную карточку");
            }
        }
    }
}
