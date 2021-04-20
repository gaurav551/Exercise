using System;

namespace Exercise
{
    public class ViralAdvertisement
    {
        public static int viralAdvertising(int n)
        {
            int firstDay = 5;
            int day = firstDay;
            int res = 0;
            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine("Day " + i);
                if (i >= 2)
                {
                    day = (day / 2) * 3;
                }
                res += day / 2;
                System.Console.WriteLine(day);
            }
            System.Console.WriteLine(res);
            return res;
        }
    }
}