using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.BasicExercises
{
    public class CutTheSticks
    {
        public static int[] cutTheSticks()
        {

            int[] arr = { 1, 2, 3, 4, 3, 3, 2, 1 };
            Array.Sort(arr);

            int min = arr[0];
            List<int> res = new List<int>();
            res.Add(arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > min)
                {
                    min = arr[i];
                    res.Add((arr.Length - i));
                }
            }
            return res.ToArray();
        }
    }


}