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
    public partial class license_Form : Form
    {
        public license_Form()
        {
            InitializeComponent();
        }

        private void License_Form_Load(object sender, EventArgs e)
        {
            
            li_label.Text = "i have made this program to test how the signup of application works. And would never use your data without your permssion ";
        }
    }
}
