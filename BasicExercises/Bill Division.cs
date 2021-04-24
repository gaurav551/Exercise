using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    public class BillDivision
    {
          public static void bonAppetit() {
             int[] bill = {3, 10, 2, 9};
             int b =7;
             int k=1;
              var sharedFoodItemsBill = bill.Where(x=>x!=bill[k]).Sum(x=>x);
                 
        System.Console.WriteLine(sharedFoodItemsBill);
        //Share The Bill

        var annasShare = sharedFoodItemsBill / 2;
        if(b == annasShare){
        System.Console.WriteLine("Bon Appetit");
        } else {
            System.Console.WriteLine(b - annasShare);}
            
         }
        
    }
}
//Complete the bonAppetit function in the editor below. It should print Bon Appetit if the bill is fairly split. 
// Otherwise, it should print the integer amount of money that Brian owes Anna.

// bonAppetit has the following parameter(s):

// bill: an array of integers representing the cost of each item ordered
// k: an integer representing the zero-based index of the item Anna doesn't eat
// b: the amount of money that Anna contributed to the bill