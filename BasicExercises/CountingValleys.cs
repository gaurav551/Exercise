namespace Exercise
{
    public class CountingValleys
    {
        /*
         
        */
        public static int countingValleys(int steps, string path)
    {
        int counter = 0;
        int updown=0;
        
        foreach (var item in path)
        {
         if( item=='U'){
             updown++;
         }
         if(item=='D')
         {
             updown--;
         }
         if(updown==0 && item=='U')
         {
             counter++;
         }
            
        }
        return counter;

    }
    }
}