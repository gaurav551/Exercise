using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    public class PickingNumber
    {
        public static int pickingNumbers(List<int> a)
        {
            foreach (var x in a.OrderBy(x=>x))
            {
                System.Console.WriteLine(x);
            }
            return 1;
        }
    }
}