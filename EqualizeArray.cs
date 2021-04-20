using System.Linq;

namespace Exercise
{
    public class EqualizeArray
    {
       public static int equalizeArray() {
           int[] arr = {3,3,2,1,3};
           var group = arr.GroupBy(x=>x);
           var high = group.OrderByDescending(x=>x.Count()).Select(x=>x.Key).FirstOrDefault();
           System.Console.WriteLine("High " + high);
           var arrNext = arr.Where(x=>x==high).ToArray();
           System.Console.WriteLine("Original " + arr.Length);
           System.Console.WriteLine("Next Arrya " + arrNext.Length);
           var result = arr.Length - arrNext.Length;
           System.Console.WriteLine("Result is " + result);
           
           return result;



    }
    }
}