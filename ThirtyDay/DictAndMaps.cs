using System;
using System.Collections.Generic;

namespace HackerRank.ThirtyDay
{
    public class DictAndMaps
    {
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var d = new Dictionary<string, Int64>();
            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine().Split(' ');
                d.Add(s[0], Convert.ToInt64(s[1]));
            }
            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine();
                if (d.ContainsKey(s))
                {
                    Console.WriteLine(s + "=" + d[s]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
        public void Run2()
        {
         Dictionary<String, String> PhoneBook = new Dictionary<String, String>();
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int i=0; i<n; i++)
        {
            var s = Console.ReadLine().Split(' ');
            PhoneBook.Add(s[0], s[1]);
        }
        
        String name = Console.ReadLine();
        
        while ( name != null)
        {
            try
            {
                Console.WriteLine(name + "=" + PhoneBook[name]);
               
            }
            catch
            {
                Console.WriteLine("Not found");
            }
        }
        }
    }
}