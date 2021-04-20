using System;
using System.Linq;

namespace Exercise
{
    public class AngryProfessor
    {
        public static string angryProfessor()

        { 
           int[] a = {-2,-1,6,-1,-2,0,2};
           int k = 3;
           int c = 0;
           for (int h = 0; h < a.Length; h++)
           {
               if(a[h]<=0)
               {
                  c++;
               }
           }
           
          int i = a.Count(x => x <= 0);
          System.Console.WriteLine(i +" " + c);
            if (i >= k) {
                return "NO";
            } else {
                return "YES";
            }
          

        }
    }
}