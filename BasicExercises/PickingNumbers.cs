using System.Collections.Generic;
using System.Linq;

namespace HackerRank.BasicExercises
{
    public class PickingNumbers
    {
        public static int pickingNumbers()
        {
            var a = new List<int> { 1, 1, 2, 2,2,1, 4, 4, 5, 5, 5 };
            int[] b = new int[101];
            int i;

            for (i = 0; i < a.Count; i++)
            {
                int j = a[i];
                b[j]++;
            }

            int max = 0;
            for (i = 1; i < 101; i++)
            {
                if (b[i] == 0) continue;
                if (b[i] + b[i + 1] > max) max = b[i] + b[i + 1];
            }
            System.Console.WriteLine(max);
            return max;

        }
    }
}