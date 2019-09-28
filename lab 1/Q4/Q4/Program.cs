using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    //4.	Write a program that takes the month (1…12) as input. Print whether the season is summer, winter, spring or 
    //      autumn depending upon the input month.
    class Program
    {
        static void Main(string[] args)
        {
            int mon;
            Console.WriteLine("enter month ");
            mon = int.Parse(Console.ReadLine());

            if (mon>=1 && mon<=2)
            {
                Console.WriteLine("winter");
            }
            else if (mon>=3 && mon<=5)
            {
                Console.WriteLine("spring");
            }
            else if (mon>=6 && mon<=8)
            {
                Console.WriteLine("summer");
            }
            else if (mon<=9 && mon<=11)
            {
                Console.WriteLine("autumn");
            }
            else if (mon==12 && mon<13)
            {
                Console.WriteLine("winter");
            }
            else
            {
                Console.WriteLine("wrong input");
            }
        }
    }
}
