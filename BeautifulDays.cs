namespace Exercise
{
    public class BeautifulDays
    {
        // Complete the beautifulDays function below.
        public static int beautifulDays(int i, int j, int k)
        {
            int beautyDays=0;
            for (int num = i; num <=j; num++)
            {
                //System.Console.WriteLine(num);
               int rev =  ReverseNumber(num);
               if((num-rev)%k==0)
               {
                  beautyDays++;
               }
            }

            return beautyDays;


        }
        public static int ReverseNumber(int n)
        {
            int rem, reverse=0;
             while(n!=0)      
       {      
        rem=n%10;        
        reverse=reverse*10+rem;      
        n/=10;      
       }      
      // System.Console.WriteLine(reverse);
            return reverse;
        }

    }
}