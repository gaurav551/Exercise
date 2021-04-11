using System;
using System.Linq;

namespace Exercise
{
    public class Mini_Max_Sum
    {
        public void miniMaxSum(int[] arr) {
        
   
    long min = long.MaxValue;
    long max = long.MinValue;
    long sum = 0;
    foreach(long i in arr)
    {
        //Console.WriteLine(i);
        min = Math.Min(min, i);
        max = Math.Max(max, i);
        sum += i;
    }
    Console.WriteLine($"{sum - max} {sum - min}");


         
    }
    }
}