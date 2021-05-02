using System;
using System.Linq;

namespace HackerRank
{

    class Difference
    {
        private int[] elements;
        public int maximumDifference;
        public Difference(int[] diff)
        {
            elements = diff;
        }
        public void computeDifference()
        {
            int min = elements.Min();
            int max = elements.Max();
            maximumDifference = Math.Abs(min - max);
        }
    }
}
