using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Milk : Product
    {
        public Milk(string name, double price, DateTime madeDate, DateTime dateOfTheEnd) : base(name, price, madeDate, dateOfTheEnd)
        {

        }

        public override void GetInfo()
        {
            Console.WriteLine($"Name {name}, price {price}, made date {madeDate.ToLongDateString()}, date of the end {dateOfTheEnd.ToLongDateString()}");
        }
    }
}
