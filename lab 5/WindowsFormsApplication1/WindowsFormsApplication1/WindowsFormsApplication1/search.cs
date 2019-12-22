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
    public partial class search : Form
    {
        List<Student> st;
        public search()
        {
            InitializeComponent();
        }
        public search(List<Student> s)
        {
            InitializeComponent();
            st = s;
        }

        private void Sea_button_Click(object sender, EventArgs e)
        {
            Student s = new Student();


            var result = st.FirstOrDefault(x => x.ToString().Equals(this.search_textBox.Text));

            int i = st.IndexOf(result);
            s = st.ElementAt(i);
            this.name_label.Text = s.name;
            this.age_label.Text = s.age;
            this.gender_label.Text = s.gender;
            this.gpa_label.Text = s.gpa;
        }
    }
}
