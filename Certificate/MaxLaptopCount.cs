using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public class MaxLaptopCount
    {
        public static int maxCost(List<int> cost, List<string> labels, int dailyCount)
        {
           int i = 0;
           int legalCount = 0;
           List<int> c = new List<int>();
           foreach (var x in cost)
           {
              
               if(labels[i]=="legal")
               {
                   legalCount++;
                   
                      
               }
               if(legalCount==dailyCount)
               {
                 
                  legalCount = 0;
                  c.Add(CountCost(i,cost));
                 
                 // System.Console.WriteLine(co);
                  System.Console.WriteLine($"Count reached at index {i} with {CountCost(i,cost)}");
               }
               i++;
           }
           var rrr = c.OrderByDescending(x=>x).FirstOrDefault();
           System.Console.WriteLine(rrr);
           return rrr;
        }
        public static int CountCost(int index, List<int> cost)
        {
            int con = 0;
            for (int i = 0; i <= index; i++)
            {
                con += cost[i];
            }
            return con;
        }
    }
}