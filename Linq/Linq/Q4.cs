using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{

    
    internal class Q4
    {
        public static void sol4()
        {
            List<Order> m = new List<Order>()
            { new Order(123,"FFGS",new DateTime(2022,1,1),2),
              new Order(223,"AFGS",new DateTime(2022,2,1),3),
              new Order(323,"BFGS",new DateTime(2022,1,1),4),
              new Order(423,"CFGS",new DateTime(2022,2,1),5),
              new Order(523,"DFGS",new DateTime(2022,5,1),6)
            };

            var result = from Order item in m
                         orderby item.OrderDate descending, item.Quantity descending
                         group item by item.OrderDate.Month;
            foreach (var it in result)
            {
                Console.WriteLine(it.Key + ":");
                    foreach(var order in it)
                {
                    Console.WriteLine(order.OrderId + " " + order.ItemName + " " + order.OrderDate.Date + " " + order.Quantity);
                }
            }
        }
    }
}
