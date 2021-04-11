using System;

namespace Exercise
{
    class Program
    {
       static int Main(string[] args)
        {
          // Mini_Max_Sum m = new Mini_Max_Sum();
          // int[] arr = {1, 2, 3, 4, 5};
          // m.miniMaxSum(arr);
          // return 0;
        //   TwelveHourToTwentyFour t = new TwelveHourToTwentyFour();
        //   System.Console.WriteLine(t.timeConversion("12:45:54PM"));
          var MinMaxScore = new MinMaxScore();
         foreach (var x in MinMaxScore.breakingRecords())
         {
                 System.Console.WriteLine(x);
         }
        //  var res =  BetweenTwoSets.FindLCM();
        //  System.Console.WriteLine(res);
         

           return 1;
        }
    }
}
