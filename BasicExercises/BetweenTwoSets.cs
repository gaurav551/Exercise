using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    public class BetweenTwoSets
    {
        //Least Common Factor 12, 24 = 48
        public int FindLCM()
        {

            int[] a = { 6, 12 };
            a.OrderBy(x => x);
            for (int i = 2; i < 1000; i++)
            {
                if (i != a[1] && i != a[0])
                    if (i % a[0] == 0 && i % a[1] == 0)
                    {
                        // System.Console.WriteLine(a[0] % i);
                        return i;
                    }
            }


            return 0;
        }
        //Great Common Division 12, 24 = 6
        public int FindGDC()
        {
            int[] a = { 24, 36 };
            for (int i = 100; i > 1; i--)
            {
                if (i != a[1] && i != a[0])
                    if (a[0] % i == 0 && a[1] % i == 0)
                        return i;
            }
            return 12;

        }
        public int FindNumber(List<int> a, List<int> b)
        {
            var totalXs = 0;
            var maximumA = a.Max(); //Time-complexity O(n)
            var minimumB = b.Min(); //Time-complexity O(m)
            var counter = 1;
            var multipleOfMaxA = maximumA;

            while (multipleOfMaxA <= minimumB)
            {
                var factorOfAll = true;

                foreach (var item in a) //Time complexity O(n)
                {
                    if (multipleOfMaxA % item != 0)
                    {
                        factorOfAll = false;
                        break;
                    }
                }

                if (factorOfAll)
                {
                    foreach (var item in b) //Time complexity O(m)
                    {
                        if (item % multipleOfMaxA != 0)
                        {
                            factorOfAll = false;
                            break;
                        }
                    }
                }

                if (factorOfAll)
                    totalXs++;

                counter++;
                multipleOfMaxA = maximumA * counter; //Here counter is the x factor which contributes to O(x(n+m)) complexity.
            }
            return totalXs;
        }
    }



}
