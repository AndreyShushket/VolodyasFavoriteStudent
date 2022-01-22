using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Set : Product
    {
        public Product[] products = new Product[] { };

        public Set(string name, params Product[] products) : base(name) => this.products = products;

        public void Price()
        {
            double price = 0.0;
            foreach (Product product in products)
            {
                price = price + product.price;
            }
        }

        public override void GetFrash()
        {
            foreach(Product product in products)
            {
                if (product.dateOfTheEnd > DateTime.Today)
                {
                    Console.WriteLine("Product is fresh");
                }
                else
                {
                    Console.WriteLine("Product is stinky");
                }
            }
        }

        public override void GetInfo()
        {
            Console.WriteLine($" Set {name}");
            foreach(Product product in products)
            {
                Console.WriteLine($"Name {product.name}, price {product.price}, made date {product.madeDate.ToLongDateString()}, date of the end {product.dateOfTheEnd.ToLongDateString()}");
            }
        }
    }
}
