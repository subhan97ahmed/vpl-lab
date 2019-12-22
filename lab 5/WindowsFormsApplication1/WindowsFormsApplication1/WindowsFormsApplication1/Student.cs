using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_5
{
    public class Student
    {
        public string name { set;get;}
        public string age { set; get; }
        public string gpa { set; get; }
        public string gender { set; get; }

        public override string ToString()
        {
            return name;
        }
    }
}
