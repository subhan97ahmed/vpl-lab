using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        string name;
        string id;
        string pass;
        string email;
        string address;
        string gender;
        string dob;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Signup_button_Click(object sender, EventArgs e)
        {

            if (checkBox.Checked == false)
            {
                MessageBox.Show("Check license ", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (name_Box.Text == null || id_Box.Text == null || email_Box.Text == null || address_Box.Text == null || comboBox.SelectedItem == null || dateTimePicker1.Text == null || pass_Box.Text == null)
            {
                MessageBox.Show("All fields must be filled  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                name = this.name_Box.Text;
                id = this.id_Box.Text;
                pass = pass_Box.Text;
                email = email_Box.Text;
                address = address_Box.Text;
                gender = "" + comboBox.SelectedItem;
                dob = dateTimePicker1.Text;

                int byear = int.Parse( dob.Substring(dob.Length - 4));

                DateTime yeard = System.DateTime.Now;
                string yearS = yeard.ToString();
                string ys =yearS.Substring(6, 4);
                Console.WriteLine(ys);
                int year = int.Parse(ys);
                int age = year - byear;
                // for check the password
                bool pa = false;
                bool pd = false;
                char[] pas = pass.ToCharArray();
                for (int i = 0; i < pass.Length; i++)
                {
                    for (char a = 'a'; a <= 'z'; a++)
                    {
                        if (pas[i].Equals(a))
                        {
                            pa = true;
                        }
                    }
                    for (char A = 'A'; A <= 'Z'; A++)
                    {
                        if (pas[i].Equals(A))
                        {
                            pa = true;
                        }
                    }
                    for (int n = 0; n <= 9; n++)
                    {
                        if (pas[i].Equals(Char.Parse(n.ToString())))
                        {
                            pd = true;
                        }
                    }
                }

                if (pd == false || pa == false)
                {
                    MessageBox.Show("Password must contain one digit and a character ", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (email.Contains('@') == false || email.Contains('.') == false)
                {
                    MessageBox.Show("Email must contain @ and . ", "Email error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (age<18)
                {
                    MessageBox.Show("You have to be 18 or above to sign up","Age error",MessageBoxButtons.OK,MessageBoxIcon.Question);
                }
                else
                {
                    
                    MessageBox.Show("welcome");
                }
            }

        }

        private void Lic_button_Click(object sender, EventArgs e)
        {
            license_Form nw = new license_Form();
            nw.Show();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
