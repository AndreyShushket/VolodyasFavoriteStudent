using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Batch : Product
    {
        private protected int count { get; set; }

        public Batch(string name, double price, int count, DateTime madeDate, DateTime dateOfTheEnd) : base(name, price, madeDate, dateOfTheEnd) => this.count = count;
    }
}
