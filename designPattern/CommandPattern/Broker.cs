using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.CommandPattern
{
    public class Broker
    {
        private List<IOrder> orders = new List<IOrder>();

        public void TakeOrder(IOrder order)
        {
            orders.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (IOrder order in orders)
            {
                order.Execute();
            }
            orders.Clear();
        }
    }
}
