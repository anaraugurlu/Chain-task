using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_task
{

    public class Order
    {
        public string Name { get; set; }
        public decimal Price { get; set; }


        public Order(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }



}
