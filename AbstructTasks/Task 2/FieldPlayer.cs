using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructTasks
{
    class FieldPlayer : Player
    {
        public override string role { get => "игрок";}

        public FieldPlayer(string name) : base(name) => Console.WriteLine("Constructor Player");

        public void CatchBall()
        {
            base.CatchBall();
            Console.WriteLine("... и нарушает правила");
        }

        public void KickOnGoal() => Console.WriteLine($"{role} {name} бьет по воротам");
    }
}
