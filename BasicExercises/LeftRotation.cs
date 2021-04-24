using System.Collections.Generic;
using System.Linq;

namespace HackerRank.BasicExercises
{
    public class LeftRotation
    {
       public static int[] RotateArray(int[] arr, int d)
       {
           var taked = arr.Take(d);
          // System.Console.WriteLine(string.Join(',',taked));
           var skipd = arr.Take(arr.Length).Skip(d);
          

            
            var res = skipd.Concat(taked).ToArray();
            System.Console.WriteLine(string.Join(',',res));
           
          
           return res;
       }
    }
}