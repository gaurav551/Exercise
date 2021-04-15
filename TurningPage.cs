using System;

namespace Exercise
{
    public class TurningPage
    {
        //n=5 p=4;
        public static int pageCount(int n, int p) {
        int front = (p/2);
        System.Console.WriteLine("Front "+ front);
           int last;
           last = (n/p+1) - front;
        if(n-p==1 || n-p==0)
        {
            last = 0;
        }
     
        System.Console.WriteLine("Last "+ last);
        return Math.Min(front,last);

        // int totalPageTurnCountFromFront = n / 2;
		// int targetPageTurnCountFromFront = p / 2;
		// int targetPageTurnCountFromBack = totalPageTurnCountFromFront - targetPageTurnCountFromFront;

		// return Math.min(targetPageTurnCountFromFront, targetPageTurnCountFromBack);


       

    }
    }
}