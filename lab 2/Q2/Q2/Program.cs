using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    //2.	Write a program to find maximum and minimum element in an array.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Q2";
            int size = 5;
            Console.WriteLine("Enter the size of an array");
            size = int.Parse(Console.ReadLine());
            int[] num = new int[size];
            Console.WriteLine("Enter the elements of array");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            int max = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]>=max)
                {
                    max = num[i];
                }
               
            }
            int min = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]<min)
                {
                    min = num[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("the max value " + max + "\nthe min values " + min);
            // or u can do by bulit in methods
            Console.WriteLine("\n");
            Console.WriteLine("the max value is "+num.Max());
            Console.WriteLine("the min value is "+num.Min());
            Console.ReadLine();
        }
    }
}
