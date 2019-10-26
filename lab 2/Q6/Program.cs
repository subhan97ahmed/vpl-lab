using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    //Q6 Write a program to create a recursive function to calculate the Fibonacci number of a
    //   specific term.
    class Program
    {

        public static int t2 = 1;
        static int e = 10;
        static int t = 0;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the ending point of the Fibonacci series");
            e = int.Parse(Console.ReadLine());
             int t1 = 0;
            Console.WriteLine("Fibonacci number");
            fib(t1, e);
        }
        public static void fib(int t1,int e)
        {
            t++;
            if (t!=e)
            {
                Console.Write(t1 + ",");
                int sum = t1 + t2;
                t1 = t2;
                t2 = sum;
                fib(t1, e);
            }
            else
            {
                Console.ReadKey();
            }

        }
    }
}
