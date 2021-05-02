using System;
using System.Collections.Generic;
using System.Linq;
using HackerRank;
using HackerRank.BasicExercises;

namespace Exercise
{
    class Program
    {
       static void Main(string[] args)
        {
	  String title=Console.ReadLine();
      String author=Console.ReadLine();
      int price=Int32.Parse(Console.ReadLine());
      Book new_novel=new MyBook(title,author,price);
      new_novel.display();
          
            

        }
        
      
    }
}
