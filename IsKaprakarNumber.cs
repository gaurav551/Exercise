using System;
using System.Collections.Generic;

namespace HackerRank
{
    public class IsKaprakarNumber
    {
        public static void kaprekarNumbers(int p, int q)
        {
            List<int> res = new List<int>();
            for (int i = p; i <= q; i++)
            {
                if (isKaprekar(i))
                {
                    res.Add(i);
                }
            }
            if(res.Count==0)
            {
                System.Console.WriteLine("INVALID RANGE");
            }
            else{
            string output = string.Join(" ", res.ToArray());
          System.Console.WriteLine(output);
            }
        }
        public static bool isKaprekar(int num)
        {
            long squared = (long)num * num;
            String str = squared.ToString();
            String left = str.Substring(0, str.Length / 2);
            String right = str.Substring(str.Length / 2);
            int numL = (String.IsNullOrEmpty(left) ? 0 : int.Parse(left));
            int numR = (String.IsNullOrEmpty(right)) ? 0 : int.Parse(right);
            if (numL + numR == num)
            {
               
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}