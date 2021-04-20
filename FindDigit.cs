using System;

namespace Exercise
{
    public class FindDigit
    {
        public static int findDigits(int n)
        {
            int count = 0;
            int num = n;
            char[] c = n.ToString().ToCharArray();

            foreach (var x in c)
            {
                if(int.Parse(x.ToString())!=0)
                {
               

                if(num % int.Parse(x.ToString())==0)
                {
                    count++;
                }
                }

                // System.Console.WriteLine(x);
            }
            System.Console.WriteLine(count);

            return count;





        }
    }
}