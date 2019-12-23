using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            task2();
        }
        public static void task1()
        {
            int[] r = new int[100];
            Random ran = new Random();
            for (int i = 0; i < r.Length; i++)
            {
                r[i] = ran.Next(100);
            }
            var result = r.Where(n => n % 2 == 1);
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        
        }
        public static void task2()
        {
            List<Student> l = new List<Student>();
            Student s;
            l.Add(s = new Student());
            s.name = "ali";
            s.subject = "chemistry";
            s.marks=  50;

            l.Add(s = new Student());
            s.name = "ali";
            s.subject = "bio";
            s.marks = 60;
                
            l.Add(s = new Student());
            s.name = "asma";
            s.subject = "chemistry";
            s.marks = 80;

            l.Add(s = new Student());
            s.name = "asma";
            s.subject = "bio";
            s.marks = 88;

            var result = from st in l group st by st.name into g select new { name = g.Key,average =g.Average(c=> c.marks)};

            foreach (var a in result)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
            
    }
}
