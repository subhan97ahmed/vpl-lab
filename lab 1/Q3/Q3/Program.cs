using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    //3.	Write a program that takes thee numbers from user as input. The program then prints the maximum and minimum of
    //      the input numbers.
    class Program
    {
        static void Main(string[] args)
        {
            int max=0, min=0;
            int a, b, c;
            Console.WriteLine("Enter three numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a>b&&a>c)
            {
                max = a;
                if (b>c)
                {
                    min = c;
                    Console.WriteLine("the max value is " + max + "\nthe min value is " + min);
                }
                else
                {
                    min = b;
                    Console.WriteLine("the max value is " + max + "\nthe min value is " + min);
                }

            }
            else if (b>a&&b>c)
            {
                max = b;
                if (a>c)
                {
                    min = c;
                    Console.WriteLine("the max value is " + max + "\nthe min value is " + min);
                }
                else
                {
                    min = a;
                    Console.WriteLine("the max value is " + max + "\nthe min value is " + min);
                }
            }
            else if (c>a&&c>b)
            {
                max = c;
                if (a>b)
                {
                    min = b;
                    Console.WriteLine("the max value is " + max + "\nthe min value is " + min);
                }
                else
                {
                    min = a;
                    Console.WriteLine("the max value is "+max + "\nthe min value is " + min);
                }
                
            }
            
        }
    }
}
