using System;

namespace Exercise
{
    public class CatAndMouse
    {
        public static string catAndMouse(int x, int y, int z) {
           int catA = x, catB = y, mouse = z;
           int catADiff = Math.Abs(catA - mouse);
           int catBDiff =  Math.Abs(catB - mouse);
        
           if(Math.Abs(catADiff-catBDiff)==0)
           {
                return "Mouse C";
           }
           string res = catADiff>catBDiff? "Cat B" : "Cat A";


             return res;


    }
    }
}