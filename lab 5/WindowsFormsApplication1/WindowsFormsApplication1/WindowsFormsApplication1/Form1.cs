using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace lab_5
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent add = new AddStudent(students);
            add.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student s1 = new Student();
            s1.name = "subhan";
            s1.age = "22";
            s1.gpa = "3.5";
            s1.gender = "male";
            students.Add(s1);

            s1 = new Student();
            s1.name = "ahmed";
            s1.age = "21";
            s1.gpa = "3";
            s1.gender = "male";
            students.Add(s1);
            Console.WriteLine(students[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Editform ee = new Editform(students);
            ee.select_edit();
            ee.Show();
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            Editform ee = new Editform(students);
            ee.select_del();
            ee.Show();

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            search sea = new search(students);
            sea.ShowDialog();
        }
    }
}
