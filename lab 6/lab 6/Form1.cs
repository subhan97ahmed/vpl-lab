using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;
namespace lab_6
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        private int current = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            /*
            for (int i = 0; i < students.Count; i++)
			{
                comboBox1.Items.Add(i.ToString());
                comboBox1
                comboBox1.Refresh();
			} */



            //students.Add(new Student("0", "subhan", 20, true, 3.5m));
            //students.Add(new Student("1", "asma", 19, false, 3.5m));
            Console.WriteLine(students.Count);

        }

        public void refresh_form(int i)
        {
            if (students.Count > 0)
            {
                Student s = students[i];

                ID_textBox.Text = s.id;
                name_textBox.Text = s.name;
                age_textBox.Text = s.age.ToString();
                male_radioButton.Checked = s.gender;
                female_radioButton.Checked = !s.gender;
                cgpa_textBox.Text = s.cgpa.ToString();
            }
            else
                MessageBox.Show("no record");

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void left_button_Click(object sender, EventArgs e)
        {
            if (current == 0)
            {
                return;
            }
            current--;
            refresh_form(current);
        }

        private void right_button_Click(object sender, EventArgs e)
        {
            if (current == students.Count - 1)
            {
                return;
            }
            current++;
            refresh_form(current);
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (!this.name_textBox.Text.Equals(""))
            {
                Student s = students[current];
                s.id = ID_textBox.Text;
                s.name = name_textBox.Text;
                s.age = int.Parse(age_textBox.Text);
                s.gender = male_radioButton.Checked;
                s.cgpa = decimal.Parse(cgpa_textBox.Text);
            }
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            if (!this.name_textBox.Text.Equals(""))
            {

                if (current == students.Count - 1)
                {
                    this.students.RemoveAt(current);
                    current = 0;

                }
                else
                {
                    this.students.RemoveAt(current);
                }
                MessageBox.Show("record was deleted");
                refresh_form(current);

            }
            else
            {
                MessageBox.Show("select something first to delete");
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true);
                foreach (Student s in students)
                {
                    sw.WriteLine(s.id + "," + s.name + "," + s.age + "," + s.gender + "," + s.cgpa);
                }
                sw.Close();
                MessageBox.Show("record saved successfully");
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamReader sr = new StreamReader(openFileDialog1.FileName, true);

                string line = sr.ReadLine();

                students = new List<Student>();

                while (line != null)
                {
                    string[] tokens = line.Split(',');
                    Student s = new Student();
                    s.id = tokens[0];
                    s.name = tokens[1];
                    s.age = int.Parse(tokens[2]);
                    s.gender = bool.Parse(tokens[3]);
                    s.cgpa = decimal.Parse(tokens[4]);
                    
                    students.Add(s);
                    line = sr.ReadLine();

                }
                current = 0;

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            if (!this.name_textBox.Text.Equals(""))
            {
                std.id = this.ID_textBox.Text;
                std.name = this.name_textBox.Text;
                std.age = int.Parse(this.age_textBox.Text);
                if (this.male_radioButton.Checked)
                {
                    std.gender = true;
                }
                else
                {
                    std.gender = false;
                }
                std.cgpa = decimal.Parse(this.cgpa_textBox.Text);
                students.Add(std);
                current = students.Count - 1;
                MessageBox.Show("Student added successfully");

                this.ID_textBox.Text = "";
                this.name_textBox.Text = "";
                this.age_textBox.Text = "";
                this.male_radioButton.Checked = false;
                this.cgpa_textBox.Text = "";
            }
            else
                MessageBox.Show("Enter something to add");

        }
    }
}
