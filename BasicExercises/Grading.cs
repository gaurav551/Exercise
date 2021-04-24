using System.Collections.Generic;

namespace Exercise
{
    public class Grading
    {
         public static List<int> gradingStudents(List<int> grades)
    {
        List<int> ans = new List<int>();
      foreach  (int marks in grades){
        if(marks < 38 || marks % 5 <= 2){
            ans.Add(marks);
        }else if(marks % 5 > 2){
            int add = 5 -(marks % 5);
            ans.Add(marks + add);
        }
    }
    return ans;

    }
    }
}