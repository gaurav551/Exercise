using System;

namespace Exercise
{
    public class LibraryFine
    {
        // Complete the libraryFine function below.
        //Fine Per Day is 15
        //d1 = returnDate d2 = dueDate
   public static int libraryFine() {

       DateTime returnDate = new DateTime(2014,7,15);
       DateTime dueDate = new DateTime(2015,7,1);

       var diff = (int)(returnDate - dueDate).TotalDays;
       if(diff<0)
       {
           return 0;
       }
       var a = diff * 15;
       System.Console.WriteLine(a);
       return a;


    }

    }
}