using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_6
{
    class Student
    {
        public string id { get; set; }
        public string name { set; get ; }
        public int age { set; get ; }
        public bool gender { set; get; }
        public decimal cgpa { set; get; }
                

       public Student (string id, string name , int age , bool g , decimal gpa) 
       {
           this.id = id;
           this.name = name;
           this.age = age;
           this.gender = g;
           this.cgpa = gpa;

       }
        public Student()
        {

        }
       
    }
}
