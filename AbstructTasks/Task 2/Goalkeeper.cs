using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructTasks
{
    class Goalkeeper : Player
    {
        public override string role { get => "вратарь"; }

        public Goalkeeper(string name) : base(name) => Console.WriteLine("Constructor Goalkeeper");

        public void MissBall() => Console.WriteLine("ГОООООООООООООООООООЛ");
    }
}
