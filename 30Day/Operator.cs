using System;

namespace ExerciseDay
{
    public class Operator
    {
        public static void solve(double meal_cost=15.50, int tip_percent=15, int tax_percent=10) {
          
          var tip = (float)tip_percent/100 * meal_cost ;
          var tax = (float)tax_percent/100 * meal_cost;
          var result = (double)tax+tip + meal_cost;
          System.Console.WriteLine(Math.Round(result,0));
         // System.Console.WriteLine(tax);

         }
        
    }
}