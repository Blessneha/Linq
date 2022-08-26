using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Q1
    {
        public static void sol1()
        {
            int[] numb = {101, 201, 301, 401, 501};
            
            var result=from f in numb
                       where f>100 && f<1000
                       let k=f*f*f
                       select k;
            foreach(var item in result)
            {
                Console.WriteLine(item);



            }
                       
        }
    }
}
