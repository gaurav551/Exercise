using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    public class MigratoryBird
    {
     public int migratoryBirds(List<int> arr) {
      var group = arr.GroupBy(x=>x);
      var highCount = group.OrderByDescending(x=>x.Count()).Select(x=>x.Count()).FirstOrDefault();
      var keys = group.Where(x=>x.Count()==highCount).Select(x=>x.Key).OrderByDescending(x=>x).FirstOrDefault();
      return keys;

    }
    }
}