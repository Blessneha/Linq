using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Q6
    {
        public static void sol6()
        {
            List<Item> list = new List<Item>()
            {
                new Item("FFGS",23),
                new Item("FRGS",23),
                new Item("FPGS",23),
                new Item("BFGS",23),
                new Item("CFGS",23),

            };
            List<Order> o = new List<Order>()
            { new Order(123,"FFGS",new DateTime(2022,1,1),2),
              new Order(223,"AFGS",new DateTime(2022,2,1),3),
              new Order(323,"BFGS",new DateTime(2022,3,1),4),
              new Order(423,"CFGS",new DateTime(2022,4,1),5),
              new Order(523,"DFGS",new DateTime(2022,5,1),6)
            };
            var result = from t in o
                         join e in list on t.ItemName equals e.ItemName
                         orderby t.OrderDate descending
                         select new {NAME= t.ItemName,DateO= t.OrderDate,Price1= e.Price,TOTQUANT= t.Quantity } into es
                         group es by es.DateO;
            foreach (var r in result)
            {
                Console.WriteLine(r.Key);
                foreach (var e in r)
                {
                    Console.WriteLine(e.NAME + ":" + (e.Price1 * e.TOTQUANT));
                }
            }
        }
    }
}
