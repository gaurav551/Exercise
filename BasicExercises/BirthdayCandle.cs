using System.Collections.Generic;
using System.Linq;

namespace Practise
{
    public  class BirthdayCandle
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
           var result = candles.GroupBy(x => x) 
        .Select(x => new
        {
            Number = x.Key,
            Count = x.Count()
        }).OrderByDescending(x => x.Count) 
        .FirstOrDefault(); 
         return result.Count;
        }
    }
}