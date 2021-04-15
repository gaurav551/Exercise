using System.Linq;

namespace Exercise
{
    public class SalesbyMatch
    {
        // Complete the sockMerchant function below.
    public static int sockMerchant(int n = 0, int[] ar = null) {

       int[] arr = {10, 20, 20, 10, 10, 30, 50, 10,20, 20};
        var group = arr.GroupBy(x=>x);
        var count=0;
        foreach(var x in group)
        {
         count += (int)x.Count() / 2;
            
        }
        return count;


    }
        
    }
}