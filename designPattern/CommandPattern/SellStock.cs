using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.CommandPattern
{
    public class SellStock : IOrder
    {
        private Stock stock;

        public SellStock(Stock stock)
        {
            this.stock = stock;
        }

        public void Execute()
        {
            stock.Sell();
        }
    }
}
