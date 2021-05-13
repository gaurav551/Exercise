using System;
using System.Collections.Generic;

namespace Practise
{
    public class DiagnolDiff
    {
         public static int diagonalDifference(List<List<int>> arr)
    {

          int d1 = arr[0][0] + arr[1][1]+ arr[2][2];
          int d2 = arr[0][2] + arr[1][1]+ arr[2][0];
          return Math.Abs(d1-d2);
    }
    }
}