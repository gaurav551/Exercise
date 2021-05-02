using System;
using System.Collections.Generic;

namespace HackerRank.BasicExercises
{
    public class StringAndLoops
    {
        public static void Run()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            string[] strings = new string[T];

            for (int i = 0; i < T; i++)
            {
                strings[i] = Console.ReadLine();
            }
            foreach(var str in strings)
            {
            string s = str;
            int index = 0;
            int nextIndex = 1;
            var firs = new List<Char>();
            var sec = new List<Char>();
            foreach (var x in s.ToCharArray())
            {
                if (index > s.Length || nextIndex > s.Length)
                {
                    break;
                }
                firs.Add(s[index]);
                sec.Add(s[nextIndex]);
                index = index + 2;
                nextIndex = nextIndex + 2;
            }
            System.Console.WriteLine(new string(firs.ToArray()) + " " + new string(sec.ToArray()));
             index = 0;
            nextIndex =1;
            firs.Clear(); sec.Clear() ;
            }
        }
        public static void Check()
        {

          
        int cases = Convert.ToInt32(Console.ReadLine());
        for(int c=0;c<cases;c++) {
            String even, odd;
            even = odd = "";
            String myString = Console.ReadLine();
            char[] charArray = myString.ToCharArray();
            for (int i = 0; i < charArray.Length; i += 2) {
                even += charArray[i];
            }
            for (int j = 1; j < charArray.Length; j += 2) {
                odd += charArray[j];
            }
            System.Console.WriteLine(even + " " + odd);
        }

        }
    }
}
