using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    //  5.	To determine whether a year is a leap year, follow these steps:
    //1.	If the year is evenly divisible by 4, go to step 2. Otherwise, go to step 5.
    //2.	If the year is evenly divisible by 100, go to step 3. Otherwise, go to step 4.
    //3.	If the year is evenly divisible by 400, go to step 4. Otherwise, go to step 5.
    //4.	The year is a leap year(it has 366 days).
    //5.	The year is not a leap year(it has 365 days).

    //Write a program to input an year as integer.Using if…else, determines whether the input is a leap year or not.

    class Program
    {
        static void Main(string[] args)
        {
            int y;
            y = int.Parse(Console.ReadLine());
            if (y % 4 == 0)
            {
                if (y % 100 == 0)
                {
                    if (y % 400 == 0)
                    {
                        Console.WriteLine("leap year");
                    }
                    else
                    {
                        Console.WriteLine("not a leap year");
                    }
                }
                else
                {
                    Console.WriteLine("leap year");
                }
            }
            else
            {
                Console.WriteLine("not a leap year");
            }
        }
    }
}
