using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Q9
    {
        public static void sol9()
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, };

            List<Order> o = new List<Order>()
            { new Order(123,"FFGS",new DateTime(2022,1,1),2),
              new Order(223,"BFGS",new DateTime(2022,2,1),3),
              new Order(323,"BFGS",new DateTime(2022,3,1),4),
              new Order(423,"BFGS",new DateTime(2022,4,1),5),
              new Order(523,"DFGS",new DateTime(2022,5,1),6)
            };

            var retr = (from j in num
                        where j % 2 == 0
                        select j).Count();
            Console.WriteLine(retr);

            var es = o.Sum(er => er.Quantity);
            Console.WriteLine(es);

            var bbbs = o.GroupBy(ee => ee.ItemName)
                .OrderByDescending(ee=>ee.Count())
                .First().Key;
            Console.WriteLine(bbbs);



            
                     


                     
            

        }
    }
}


            
           