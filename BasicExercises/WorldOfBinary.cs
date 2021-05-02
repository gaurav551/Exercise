using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.BasicExercises
{
    public class WorldOfBinary
    {
        public static void worldOfBinary()
        {
            List<int> a = new List<int>(); 
            int i;


            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                a.Add(n % 2);
                n = n / 2;
            }
           // int repeatedOne = a.Where(x=>x==1).Count();
            System.Console.WriteLine(maxOnes(a.ToArray()));

        }
        public static int maxOnes(int[] arr){
		int count = 0;
		int max = 0;
		for(int i = 0; i < arr.Length; i++){
			if(arr[i] == 0)
				count = 0;
			else
				count++;
			max = count > max ? count : max;
		}
		return max;
	}

    }
}