using System;
using System.Linq;

namespace Exercise
{
    public class StairCase
    {
         public  void staircase(int n) {
            
             int count = n-1;

             for (int i = 0 ; i<n; i++)
             {
                 
                 System.Console.WriteLine(new string(Enumerable.Range(1, count).Select(i=>' ').ToArray()) +""+ new String('#', i+1)  );
                 count --;
             }


    }
        
    }
}

// Sample Input

// 6 
// Sample Output

//      #
//     ##
//    ###
//   ####
//  #####
// ######
