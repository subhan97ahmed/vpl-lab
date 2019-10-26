using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    //Q5 write a program  to count the total number of words in String 
    class Program
    {
        static void Main(string[] args)
        {
            int words=0;
            String name = "subhan ahmed.";
            Console.WriteLine("The string is "+name);
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i]==' ' || name[i]=='.')
                {
                    words++;
                }
            }
            Console.WriteLine("The number of words are "+words);
        }
    }
}
