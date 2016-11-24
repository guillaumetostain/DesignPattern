using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.CommandPattern
{
    public class Stock
    {
        string name;
        int quantity;

        public Stock(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }

        public void Buy()
        {
            Console.WriteLine("Buy " + quantity + " " + name);
        }

        public void Sell()
        {
            Console.WriteLine("Sell " + quantity + " " + name);
        }
    }
}
