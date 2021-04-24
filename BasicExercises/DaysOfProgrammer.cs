using System;
using System.Globalization;

namespace Exercise
{
    public class DaysOfProgrammer
    {
        public static string dayOfProgrammer(int year=1800) {
            JulianCalendar j = new JulianCalendar();
           
           if(year>-1700 && year<=1917)
           {
                   if(j.IsLeapYear(year))
                   {
                       return "12.09."+year;  
                   }
                   else
                   {
                         return "13.09."+year;
                   }
           }
            if(year==1918)
            {
             // 1918 is leap year
            //12 + 14 = 26
            return "26.09.1918";
            }
            
          
            if(DateTime.IsLeapYear(year))
            {
                System.Console.WriteLine(year + " is Leap");
                return "12.09."+year;
            }
            else
            {
                 System.Console.WriteLine(year + " is not Leap");
                return "13.09."+year;
            }


    }
    }
}