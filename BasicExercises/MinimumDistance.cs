using System.Collections.Generic;
using System.Linq;

namespace HackerRank.BasicExercises
{
    public class MinimumDistance
    {
         public static int minimumDistances()
    {
          List<int> a = new List<int>(){7, 1, 3,3, 4, 1, 7};
          
           var dict = new Dictionary<int, (int, bool)>();
        var pos = 0;
        foreach(var e in a){
            if(dict.ContainsKey(e)){
                dict[e] = (pos - dict[e].Item1, true);
            }else{
                dict.Add(e, (pos, false));
            }
            pos++;
        }
        var found = false;
        var res = int.MaxValue;
        foreach(var i in dict){
            if(i.Value.Item2 && i.Value.Item1 < res){
                res = i.Value.Item1;
                found = true;
            }
        }
        if(found){
            System.Console.WriteLine(res);
            return res;
        }else{
            return -1;
        }
    }

    }
}