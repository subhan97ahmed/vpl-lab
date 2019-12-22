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
    public partial class AddStudent : Form
    {
        List<Student> students;
        int i;
        public AddStudent(List<Student> students)
        {
            this.students = students;
            InitializeComponent();
        }
        public AddStudent(List<Student> students,int i)
        {
            this.i = i;
            this.students = students;
            InitializeComponent();
            this.name_box.Text = students.ElementAt(i).name;
            this.age_box.Text = students.ElementAt(i).age;
            this.Gender_combobox.Text = students.ElementAt(i).gender;
            this.gpa_box.Text = students.ElementAt(i).gpa;

            this.add_button.Text = "edit";
            this.add_button.Click -= new EventHandler(Add_button);
            this.add_button.Click += new EventHandler(Add_button_Click);
        }

       

        private void Add_button_Click(object sender, EventArgs e)
        {
            students.ElementAt(i).name = this.name_box.Text;
            students.ElementAt(i).gender = this.Gender_combobox.Text;
            students.ElementAt(i).age = this.age_box.Text;
            students.ElementAt(i).gpa = this.gpa_box.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_button(object sender, EventArgs e)
        {
            Student s = new Student();
            s.name = name_box.Text;
            s.age = age_box.Text;
            s.gpa = gpa_box.Text;
            s.gender = Gender_combobox.SelectedText;
            students.Add(s);

            this.Close();

        }
    }
}
