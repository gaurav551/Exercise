using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    public class MostExpensiveOption
    {
        public static int getMoneySpent(int[] keyboards, int[] drives, int b) {
        /*
         * Write your code here.
         
         */
         int res = 0;
         List<int> f = new List<int>();
         for (int i = 0; i < keyboards.Length; i++)
         {
           foreach (var x in drives)
           {
              res = keyboards[i] + x;
              f.Add(res);
            }
                  
         }
        var ordered = f.OrderByDescending(x=>x);
        if(ordered.All(x=>x>b))
        {
            return -1;
        }
        var result = ordered.Where(x=>x<=b).FirstOrDefault();
       
      
        // System.Console.WriteLine(ordered.Where(x=>x<b).FirstOrDefault());


         return result;

    }
    }
}