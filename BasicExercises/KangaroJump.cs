namespace Exercise
{
    public class KangaroJump
    {
        // 3 4 4 3
        public string kangaroo(int x1, int v1, int x2, int v2)
        {
            
         if((x1 - x2) % (v2 - v1) == 0)
         {
             return "YES";
         }
         return "NO";

        }
    }
}