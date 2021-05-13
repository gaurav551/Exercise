using System;
using System.Collections.Generic;
using System.Linq;
using Practise;

namespace HackerRank.BasicExercises
{
    class Program
    {
        static void Main(string[] args)
        {
        //    List<int> n = new List<int>(){1,3,5,66,66,66};
        //   // System.Console.WriteLine(Math.Abs(4-19));
        //   var a =BirthdayCandle.birthdayCakeCandles(n);
        //   System.Console.WriteLine(a);
        var migratoryBird = new Migratory();
        int[] arr = {1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4};
        int s = migratoryBird.migratoryBirds(arr.ToList());
        System.Console.WriteLine(s);
        }
    }
}
