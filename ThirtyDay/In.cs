using System;
using System.Linq;
namespace HackerRank.ThirtyDay{

public class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

public class Student : Person{
    private int[] testScores;  
    public Student(string firstName, string lastName, int id, int[] scores) : base(firstName,lastName,id)
    {
        this.testScores = scores;
    }
    public char Calculate()
    {
        int len = testScores.Length;
        var avg = testScores.Sum(x=>x) / len;
        if(avg>=90 && avg<=100)
        {
            return 'O';
        }
         if(avg>=80 && avg<90)
        {
            return 'E';
        }
         if(avg>=70 && avg<80)
        {
            return 'A';
        }
         if(avg>=55 && avg<70)
        {
            return 'P';
        }
         if(avg>=40 && avg<55)
        {
            return 'D';
        }
        else
        {
            return 'T';
        }
    }
  
  
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
}
}
