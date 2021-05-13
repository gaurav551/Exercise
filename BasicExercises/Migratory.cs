using System.Collections.Generic;
using System.Linq;

namespace Practise
{
    public class Migratory
    {
    public int migratoryBirds(List<int> arr) {
        
       var group = arr.GroupBy(x=>x);
       foreach (var x in group)
       {
           System.Console.WriteLine("Key " + x.Key + " Count " + x.Count());
       } 
       var highCount = group.OrderByDescending(x=>x.Count()).FirstOrDefault().Count();
       System.Console.WriteLine(highCount);
       var keys = group.Where(x=>x.Count()==highCount).Select(x=>x.Key).ToArray();
       System.Console.WriteLine("KEYSSS");
      
       return keys.OrderBy(x=>x).FirstOrDefault();

    }
    }
}