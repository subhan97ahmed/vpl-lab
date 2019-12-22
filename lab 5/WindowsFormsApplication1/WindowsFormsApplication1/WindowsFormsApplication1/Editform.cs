using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab_5
{
    public partial class Editform : Form
    {
        List<Student> s;
        public Editform(List<Student> s)
        {
            this.s = s;
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Editform_Load(object sender, EventArgs e)
        {
            listBox.DataSource = s;
            
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void select_edit()
        {
            this.button2.Text = "Edit";
            this.edit_radioButton.Checked = true;
        }
        public void select_del()
        {
            this.button2.Text = "Delete";
            this.del_radioButton.Checked = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int i = listBox.SelectedIndex;
            if (this.del_radioButton.Checked==true)
            {

                string name = this.listBox.SelectedItem.ToString();
                Student ss = new Student();
                ss.name = name;
                this.Refresh();
                if (i >=0)
                {
                    s.Remove(ss);
                    
                    this.listBox.DataSource = null;
                    this.listBox.DataSource = s;

                }

            }
            else
            {
            
                AddStudent ass= new AddStudent(s,i);
                ass.ShowDialog();

                
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox.DataSource = null;
            listBox.DataSource = s;
            listBox.Refresh();
        }
    }
}
