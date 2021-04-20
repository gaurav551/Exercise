namespace Exercise
{
    public class SaveThePrisoners
    {
        // Complete the saveThePrisoner function below.
        // n =  Prisoner, m = candy, s = seats
    public static int saveThePrisoner(int n = 4 , int m = 1212, int s =2) {
        // 2 3 4 1 2 3
        int seat = s;
        int i = 1;

         while (i <= m)
         {
             if(i>1)
             {
               
                if(seat == n)
                {
                    seat = 1;
                }
                else
                {
                    seat++;
                }
             }
                 System.Console.WriteLine(seat); 
                i++;
         }
         return seat;



    }
    }
}