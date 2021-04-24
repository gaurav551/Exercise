using System.Collections.Generic;

namespace Exercise
{
    public class ReverseArray
    {
       public static void reverseArray() {
           int[] arr = {1,2,3,4,5};
           List<int> res = new List<int>();
           for (int i = arr.Length-1; i >=0 ; i--)
           {
               res.Add(arr[i]);
           }
         //  return res.ToArray();


    }
    }
}