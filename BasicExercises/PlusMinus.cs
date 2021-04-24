using System;
using System.Linq;

namespace Exercise
{
    public class PlusMinus
    {
        public static void plusMinus(int[] arr) {
        int n = arr.Count();
        int neg = arr.Where(x=>x < 0).Count();
        int pos = arr.Where(x=>x > 0).Count();
        int zero = arr.Where(x=>x == 0).Count();

        Console.WriteLine(Math.Round((decimal)pos/n, 6));
         Console.WriteLine(Math.Round((decimal)neg/n, 6));
          Console.WriteLine(Math.Round((decimal)zero/n, 6));


      }
        
    }
}
// Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal.

// Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to  are acceptable.

// Example

// There are  elements, two positive, two negative and one zero. Their ratios are ,  and . Results are printed as: