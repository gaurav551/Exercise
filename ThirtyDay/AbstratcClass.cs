using System;
using System.Collections.Generic;
using System.IO;
public abstract class Book
{
    
    protected String title;
    protected  String author;
    
    public Book(String t,String a){
        title=t;
        author=a;
    }
    public abstract void display();


}

//Write MyBook class

class MyBook : Book
{
    public int price;
    public MyBook(String t,String a, int pr) : base(t,a)
    {
        price = pr;
//         Title: The Alchemist
// Author: Paulo Coelho
// Price: 248
    }
    public override void display()
    {
        System.Console.WriteLine("Title: " + title);
        System.Console.WriteLine("Author: " + author);
          System.Console.WriteLine("Price: " + price);
    }
}