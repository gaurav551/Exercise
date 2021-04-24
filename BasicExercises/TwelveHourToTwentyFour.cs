using System;
namespace Exercise
{
    public class TwelveHourToTwentyFour
    {
        //Sample Input 0
        // 07:05:45PM
        // Sample Output 0
        // 19:05:45
        public string timeConversion(string s)
        {
            string result = s.Substring(s.Length - 2);
            string time = s.Replace(result, "");
            //System.Console.WriteLine(time);
            var times = time.Split(':');
            int hour = Convert.ToInt32(times[0]);
            int min = Convert.ToInt32(times[1]);
            string min2 = min < 10 ? 0 + "" + min.ToString() : min.ToString();
            int sec = Convert.ToInt32(times[2]);
            string sec2 = sec < 10 ? 0 + "" + sec.ToString() : sec.ToString();
            if (result == "AM" && hour == 12)
            {
                return "00:" + min2 + ":" + sec2;
            }
            else if(result=="PM" && hour ==12)
            {
                 string hour2 = hour < 10 ? 0 + "" + hour.ToString() : hour.ToString();
                return hour2 + ":" + min2 + ":" + sec2;

            }
            // if(result=="PM" && hour==12)
           else if (result == "PM")
            {
                int result1 = hour + 12;
                string hour2 = result1 < 10 ? 0 + "" + result1.ToString() : result1.ToString();
                return hour2 + ":" + min2 + ":" + sec2;
            }
            else
            {
                System.Console.WriteLine("Ite tgusss");
                string final = hour < 10 ? 0 + "" + hour.ToString() : hour.ToString();
                return final + ":" + min2 + ":" + sec2;
            }

          
        }
    }
}