using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    //7.	Write a program to print Iqra University marks sheet using  if…else statement
    class Program
    {
        static void Main(string[] args)
        {
            float math, english, isl, pst, cs;

            Console.WriteLine("Enter your marks");

            math = float.Parse(Console.ReadLine());
            english = float.Parse(Console.ReadLine());
            isl = float.Parse(Console.ReadLine());
            pst = float.Parse(Console.ReadLine());
            cs = float.Parse(Console.ReadLine());

            float par = ((math + english + isl + pst + cs) / 500) * 100;
            if (par >= 60 && par <= 65)
            {
                Console.WriteLine("u passed gpa 2");
            }
            else if (par >= 66 && par <= 70)
            {
                Console.WriteLine("u passed gpa 2.5");
            }
            else if (par >= 71 && par <= 75)
            {
                Console.WriteLine("u passed gpa 3");
            }
            else if (par >= 76 && par <= 80)
            {
                Console.WriteLine("u passed gpa 3.5");
            }
            else if (par >= 81 && par <= 100)
            {
                Console.WriteLine("u passed gpa 4");
            }
            else if (par > 100)
            {
                Console.WriteLine("try again");
            }
            else
            {
                Console.WriteLine("u failed");
            }
        }
    }
}
