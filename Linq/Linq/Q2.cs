using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{  
    public class Tennis
    { 
        public string Name { get; set; }
        public string Country { get; set; }

        public Tennis(string name,string country)
        {
            Name = name;
            Country = country;
        }
    }

    public class TennisDivide
    {
       public  string Name1 { get;set; }
       public  string Name2 { get;set; }
        public TennisDivide(string name1,string name2)
        {
            Name1 = name1;
            Name2 = name2;

        }
    }
    internal class Q2
    {
        public static void sol2()
        {
            List<Tennis> tenn = new List<Tennis>()
            {
                new Tennis("Blessy","India"),
                new Tennis("Zian","Germany"),
                new Tennis("Meenan","Canada"),
                new Tennis("Dan","India"),
                new Tennis("Mia","Germany"),
                new Tennis("NANI","Canada"),







            };

            List<Tennis>t1 = new List<Tennis>();
            List<Tennis> t2 = new List<Tennis>();

            for(int i=0;i<tenn.Count;i++)
            {
                if(i%2==0)
                {
                    t1.Add(tenn[i]);
                }
                else
                {
                    t2.Add(tenn[i]);
                }

            }

            var result = from Tennis f1 in t1
                         from Tennis f2 in t2
                         where f1.Country != f2.Country
                         select new TennisDivide(f1.Name, f2.Name);
            foreach(TennisDivide s in result)
            {
                Console.WriteLine(s.Name1 + ":" + s.Name2);
            }
                          


        }
    }
}
