using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Q7
    {
        public static void sol7()
        {
           
            List<Order> o = new List<Order>()
            { new Order(123,"FFGS",new DateTime(2020,1,1),2),
              new Order(223,"AFGS",new DateTime(2022,2,1),3),
              new Order(323,"BFGS",new DateTime(2022,3,1),4),
              new Order(423,"CFGS",new DateTime(2022,4,1),5),
              new Order(523,"DFGS",new DateTime(2022,5,1),6)
            };
            var result = o.Any(r => r.Quantity > 0);
            Console.WriteLine(result);
            var res = o.OrderByDescending(s => s.Quantity).Select(st => st);
            int k = 0;
            foreach(var tem in res)
            {
                if(k==0)
                {
                    Console.WriteLine(tem.OrderId+" "+tem.ItemName+" "+tem.Quantity);
                }
                else
                {
                    break;
                }
                k++;
            }
            var re = o.Any(p => p.OrderDate.Year < 2022);
            Console.WriteLine(re);



        }
    }
}
