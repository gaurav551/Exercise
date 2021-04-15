namespace Exercise
{
    public class DivisibleSumPair
    {
        public static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int count = 0;
            int complement; // stores the complement value according to the current value with respect to k
            int[] buckets = new int[k];
            /* buckets: stores the number of elements for each bucket
              buckets[i] = n means ith bucket has n elements inside */

            for (int i = 0; i < ar.Length; i++)
            {
                int current = ar[i];
                current %= k; // find the corresponding bucket
                /* Find it's coresponding complement bucket */
                if (current == 0)
                {
                    complement = 0;
                }
                else
                {
                    complement = k - current;
                }

                count += buckets[complement]; // add all possible pairs between the current and every elements inside the complement bucket
                buckets[current]++; // add the current into its bucket
            }

            return count;
        }
    }



}
