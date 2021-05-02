using System;

namespace HackerRank
{
    public class AppendAndDelete
    {
        public static string appendAndDelete(string s, string t, int k)
    {
        var sLength = s.Length;
        var tLength = t.Length;
        
        if(sLength + tLength < k) return "Yes";

        var minLength = Math.Min(sLength, tLength);
        var maxLength = Math.Max(sLength, tLength);
        var commonCount = 0;

        for(var i = 0; i < minLength; i++)
        {
            if(!char.Equals(s[i], t[i]))
                break;

            commonCount++;
        }

        var minDiff = minLength - commonCount;
        var maxDiff = maxLength - commonCount;

        if(minDiff + maxDiff <= k && (k-(minDiff + maxDiff)) % 2 == 0)
            return "Yes";
        
        return "No";


    }
    }
}