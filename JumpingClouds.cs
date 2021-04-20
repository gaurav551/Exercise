using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise
{
    public class StringRepitition
    {
      public static long repeatedString(string s="a", long n=1000000000000) {
        //   char[] c = s.ToCharArray();
        //  // var str = new StringBuilder(s);
        //   List<char> cha = c.ToList();
        //   int len =  c.Length;
        //    int charIndex = 0;
        //   for (int i = len+1; i <= n; i++)
        //   {
        //       System.Console.WriteLine("Running "+ i);
        //       cha.Add(c[charIndex]);
        //       if(charIndex==len-1)
        //       {
        //           charIndex = 0;
        //       }
        //       else
        //       {
        //           charIndex++;
        //       }
        //    }
        //    string final = (new string(cha.ToArray()));
         
        //   var count = final.ToCharArray().Where(s=>s=='a').Count();
        //     System.Console.WriteLine(count);
        //   return count;
        long size = s.Length, repeated = n/size;
        long left = n - (size * repeated);
        int extra = 0;

        int count = 0;
        for(int i = 0; i < size; i++){
            if(s.ElementAt(i) == 'a'){
                ++count;
            }
        }

        for(int i = 0; i < left; i++){
            if(s.ElementAt(i) == 'a'){
                ++extra;
            }
        }

        repeated = (repeated * count) + extra;
        System.Console.WriteLine(repeated);

        return repeated;


    }

    }
}