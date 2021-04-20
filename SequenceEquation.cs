using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    public class SequenceEquation
    {
        public static int[] permutationEquation()
        {
           int[] p = {2,3,1};
           var inList = p.ToList();
           
           var order = p.OrderBy(x=>x).ToList();
           List<int> result = new List<int>();
           foreach (var x in order)
           {
               int position = inList.IndexOf(x)+1;
               System.Console.WriteLine("POSITION IS "+ position);
               int inPostition = inList.IndexOf(position)+1;
               result.Add(inPostition);
               System.Console.WriteLine(x +" is " + inPostition);
           }
           return result.ToArray();
         }
         private static int FindPos(int[] arr, int p)
         {
             int result = 0;
               for (int i = 0; i < arr.Length; i++)
               {
                   if(i==p)
                   {
                       result =  i;
                       break;
                   }
               }
               return result;
         }
    }
}