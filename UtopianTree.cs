namespace Exercise
{
    public class UtopianTree
    {
        public static int utopianTree(int n = 5) {
            int growth = 1;
            for(int i = 1; i<=n; i++)
            {
                //FirstCycle in Spring so Double
                if(i%2!=0)
                {
                    growth += growth;
                }
                else
                {
                    growth++;
                }
                
                //System.Console.WriteLine("Cycle " + i);
            }
            System.Console.WriteLine(growth);

            return growth;


    }
    }
}