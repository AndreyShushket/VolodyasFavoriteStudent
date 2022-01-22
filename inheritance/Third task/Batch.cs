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
        public Product product;

        public Batch(Product product, int count, DateTime madeDate, DateTime dateOfTheEnd) : base(madeDate, dateOfTheEnd)
        {
            this.count = count;
            this.product = product;
        }

        public override void GetFrash()
        {
            if (dateOfTheEnd > DateTime.Today)
            {
                Console.WriteLine("Product is fresh");
            }
            else
            {
                Console.WriteLine("Product is stinky");
            }
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Name {product.name}, price {product.price}, made date {product.madeDate.ToLongDateString()}, date of the end {product.dateOfTheEnd.ToLongDateString()}");
            Console.WriteLine($"Amount of products {count}");
        }
    }
}
