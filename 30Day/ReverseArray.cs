using System;

namespace ExerciseDay
{
    public class ReverseArray
    {
        public static void Rev()
            {
                 int n = Convert.ToInt16(Console.ReadLine());
                 int[] arr = new int[n];
                for(int i=0; i<n;i++)
                {
                     arr[i] = Convert.ToInt16(Console.ReadLine());                
                }
                
               
                int[] res = new int[n];
                
                for (int k = arr.Length-1; k>=0; k--)
                {
                   
                    Console.Write(arr[k] + " ");
                }
                // 
               
      
             }    
        
        
    }
}