using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{ 
    public class Order
    {
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public DateTime OrderDate { get; set; }

        public int Quantity { get; set; }

        public Order(int orderId, string itemName, DateTime orderDate, int quantity)
        {
            OrderId = orderId;
            ItemName = itemName;
            OrderDate = orderDate;
            Quantity = quantity;
        }   
    }
    internal class Q3
    {

        public static void sol3()
        {
            List<Order> o = new List<Order>()
            { new Order(123,"FFGS",new DateTime(2022,1,1),2),
              new Order(223,"AFGS",new DateTime(2022,2,1),3),
              new Order(323,"BFGS",new DateTime(2022,3,1),4),
              new Order(423,"CFGS",new DateTime(2022,4,1),5),
              new Order(523,"DFGS",new DateTime(2022,5,1),6)
            };

            var result=from Order item in o
                       orderby item.OrderDate descending,item.Quantity descending
                       select item;
            foreach(Order it in result)
            {
                Console.WriteLine(it.OrderId+" "+it.ItemName+" "+it.OrderDate.ToShortDateString()+" "+it.Quantity);
            }
                       
        }

    }
}
