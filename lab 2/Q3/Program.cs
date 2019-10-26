using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    //Q3 write a program to spearate out the odd and even numbers in and array in two different arrays
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];

            Console.WriteLine("enter numbers");
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            int evencount = 0;
            int oddcount = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    evencount++;
                }
                else
                {
                    oddcount++;
                }

            }

            int[] even = new int[evencount+1];
            int[] odd = new int[oddcount+1];
            int r = 0;
            for (int i = 0; i < ar.Length; i++)
            {

                if (ar[i] % 2 == 0)
                {
                    even[r] = ar[i];
                    r++;
                }
                

            }
            r = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if(ar[i]%2!=0)
                {
                    odd[r] = ar[i];
                    r++;
                }
            }
            

            Console.WriteLine("even\todd");
            for (int i = 0; i < evencount; i++)
            {
                Console.WriteLine(even[i]); ;
            }
            for (int i = 0; i < oddcount; i++)
            {
                Console.WriteLine("\t"+odd[i]);
            }
        }
    }
}
