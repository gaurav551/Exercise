using System;

//Write your code here
public class Calculator
{
    public int power(int n, int p)
    {
        if(n<0 || p<0)
        {
           System.Console.WriteLine("n and p should be non-negative");
        }
       
       
       return (int)Math.Pow(n, p);
    }
    public int power2(int x, int y) {
    if(x < 0 || y < 0){
        throw new Exception("n and p should be non-negative");
    }
    else{
        return (int)Math.Pow(x,y);
    }
}
}

class Solution2{
    // static void Main(String[] args){
    //     Calculator myCalculator=new  Calculator();
    //     int T=Int32.Parse(Console.ReadLine());
    //     while(T-->0){
    //         string[] num = Console.ReadLine().Split();
    //         int n = int.Parse(num[0]);
    //         int p = int.Parse(num[1]); 
    //         try{
    //             int ans=myCalculator.power2(n,p);
    //             Console.WriteLine(ans);
    //         }
    //         catch(Exception e){
    //            Console.WriteLine(e.Message);

    //         }
    //     }}
}