using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Set : Product
    {
        Product[] products = new Product[] { };

        public Set(string name, double price, Product[] products) : base(name, price) => this.products = products;
    }
}
