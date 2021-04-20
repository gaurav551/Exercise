using System;

namespace Exercise
{
    public class FindSquareInRange
    {
        public static int squares(int a=17, int b=24) {
            var start = Math.Ceiling(Math.Sqrt(a));
            System.Console.WriteLine(start);
    var end = Math.Floor(Math.Sqrt(b));
    var res = (Convert.ToInt32(end - start + 1));
    System.Console.WriteLine(res);
    return res;

           


    }
    }
}