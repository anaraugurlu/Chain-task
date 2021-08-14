using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_task
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Product(string name, double price, string desc)
        {
            Description = desc;
            Price = price;
            Name = name;
        }
    }
}
