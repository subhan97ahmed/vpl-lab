using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    //Q4 write a program to find the length of the String without using length libaray 
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Enter any String to find its length");
            a= Console.ReadLine();
            Console.WriteLine("the length is "+count(a));
        }

        public static int count(String a) {
            int count = 0;
            foreach (char c in a)
            {
                count++;
            }

            return count;
        }
    }
}
