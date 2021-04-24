using System.Linq;

namespace Exercise
{
    public class MinMaxScore
    {
        //12 24 10 24 =  2 3
         public int[] breakingRecords() 
        {
            int[] scores = {3, 4, 21, 36, 10, 28, 35, 5, 24, 42}; //4 ,0

            int[] result = new int[2];
            int countMax = 0, countMin = 0, max = scores[0], min = scores[0];
           
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > max) { 
                    //store max
                    max = scores[i]; 
                    countMax++; 
                    }
                if (scores[i] < min) { min = scores[i]; countMin++; }
            }
            result[0] = countMax; result[1] = countMin;
            return result;
            
        }
    }
}   