using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    //2.	Write a program to calculate whether an input number is even or odd.
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number to check if its even or odd");
            num =int.Parse(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine(num+" is even");
            }
            else
            {
                Console.WriteLine(num+" is odd");
            }
        }
    }
}
