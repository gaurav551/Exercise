using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public class ActiveTraders
    {
        public static List<string> mostActive(List<string> customers)
        {
            var group = customers.GroupBy(x=>x);
            int count = customers.Count();
            System.Console.WriteLine("Count is " + count);
            //3
            foreach (var x in group)
            {
                System.Console.WriteLine(x.Key + " " + x.Count());
                var percent = (float)x.Count() / count * 100;
                System.Console.WriteLine("Percent is " + percent);
                //System.Console.WriteLine();
                if(x.Count() / count * 100 >=5)
                {
                    System.Console.WriteLine(x + "Is Cool");
                }
            }

            var res = group.Where(x=>(float)x.Count() / count * 100 >=5 ).Select(x=>x.Key).OrderBy(x=>x).ToList();
            foreach(var x in res)
            {
                System.Console.WriteLine(x);
            }
            return res;

        }
    }
}