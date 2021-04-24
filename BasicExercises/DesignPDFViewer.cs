using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public class DesignPDFViewer
    {
        public static int designerPdfViewer(int[] h, string word)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            Dictionary<char, int> dict = new Dictionary<char, int>();
            //Add  Required Data
            int i = 0;
            foreach (char a in alphabet.ToCharArray())
            {
                dict.Add(a, h[i]);
                i++;
            }
            char[] w = word.ToCharArray();
            List<int> items = new List<int>();
            foreach (var x in w)
            {
                int io = dict.Where(p => p.Key == x).FirstOrDefault().Value;
               items.Add(io);
            }

            int count = items.Count();
            int max = items.Max();
            return count * max;
        }
        public static int findIndex(int[] height)
        {
            //Find Index Of Element
            int index = 0;
            int itemToFind = 7;
            foreach (var x in height)
            {

                if (x == itemToFind)
                {
                    return index;
                }
                index++;


            }
            return index;

        }
    }
}



/*
INPUT  int[] arr = 1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 7, word = zaba
The tallest letter in zaba  is z  at 7 . The selection area for this word is  7 * 4. where 4 is word count
*/
