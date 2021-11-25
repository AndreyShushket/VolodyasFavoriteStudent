using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Product
    {
        public string name { get; set; }

        public double price { get; set; }

        public DateTime madeDate { get; set; }

        public DateTime dateOfTheEnd { get; set; }

        public Product(string name, double price, DateTime madeDate, DateTime dateOfTheEnd)
        {
            this.name = name;
            this.price = price;
            this.madeDate = madeDate;
            this.dateOfTheEnd = dateOfTheEnd;
        }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public void GetInfo() => Console.WriteLine($"Name is {name}, price is {price}, date of manufacture is {madeDate}, expiration date is {dateOfTheEnd}");

        public void GetFrash(Product product)
        {
            if(product.dateOfTheEnd > DateTime.Today)
            {
                Console.WriteLine("Product is fresh");
            }
            else
            {
                Console.WriteLine("Product is stinky");
            }
        }
    }
}
