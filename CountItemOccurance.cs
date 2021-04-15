using System;  
public class CountItemOccureance  
{  
    public static void Test() 
{
	int[] arr1 = {1,1,1,1,1,1,1,1,1,2,2,3,4,1,4,5,5,6,8,4,6,3,1,6,72,6,73,1,1,5,6,7,1,2,2,1,1,5,1,6,1,7,1,6,1,6,1,5,1,1,1,1,1,1};
	int[] fr1 = new int[100];
    int i, j, ctr;
    for(i=0;i<arr1.Length;i++)
            {
	      
   	    		  
		  fr1[i] = -1;
	    }
	
	
       
    for(i=0; i<arr1.Length; i++)
    {
        ctr = 1;
        for(j=i+1; j<arr1.Length; j++)
        {
            if(arr1[i]==arr1[j])
            {
                ctr++;
                fr1[j] = 0;
            }
        }

        if(fr1[i]!=0)
        {
            fr1[i] = ctr;
        }
    }
  
    for(i=0; i<arr1.Length; i++)
    {
        if(fr1[i]!=0)
        {
            Console.Write("{0} occurs {1} times\n", arr1[i], fr1[i]);
        }
    }
  }	
}
