using System.Collections.Generic;

namespace Exercise
{
    public class CircularArrayRotation
    {
        public static void circularArrayRotation()
        {
            int[] a = { 1, 2, 3 }; int k = 2; int[] queries = { 0,1,2 };

              int[] arr = new int[a.Length];
                        
            for(int i=0 ; i<a.Length ; i++)
                arr[(i+k)%a.Length] = a[i];
                                
            for(int i=0 ; i<queries.Length ; i++)
                queries[i] = arr[queries[i]];
                                
            
              System.Console.WriteLine("Result " + string.Join(',',queries));
             // return result;



        }
        static int[] rotLeft(int[] a, int d)
        {
            System.Console.WriteLine(d);

            Queue<int> queue = new Queue<int>(a);
            Stack<int> stack = new Stack<int>();

            while (d > 0)
            {
                stack.Push(queue.Dequeue());
                queue.Enqueue(stack.Pop());
                d--;
            }

            return queue.ToArray();
        }
    }
}