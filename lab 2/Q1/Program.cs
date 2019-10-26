using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int[] ar = { 1, 23, 5, 3, 3, 5 };
            for (int i = 0; i < ar.Length; i++)
            {
                count = 0;
                for (int r = 0; r < ar.Length; r++)
                {
                    if (ar[i] == ar[r])
                    {
                        count++;
                    }
                }
                Console.WriteLine(ar[i]+" is "+count+" times");
            }
        }
    }
}
