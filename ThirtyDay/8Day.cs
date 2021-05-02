using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public class Day
    {
        public static void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
        var d = new Dictionary<string, string>();
        for(int i = 0; i < n; i++) {
            var s = Console.ReadLine().Split(' ');
            d.Add(s[0],s[1]);
        }
        for(int i = 0; i < n; i++) {
            var s = Console.ReadLine();
            if(d.ContainsKey(s)) {
                Console.WriteLine(s + "=" + d[s]);
            } else {
                Console.WriteLine("Not found");
            }
        }
       
        }
    }
}