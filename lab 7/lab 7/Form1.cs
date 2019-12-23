using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlDocument d = new XmlDocument();
                d.Load(openFileDialog1.FileName);
                XmlNodeList l = d.GetElementsByTagName("title");
                
                this.Text = l[0].InnerText;
                l = d.GetElementsByTagName("text");
                this.textBox1.Text = l[0].InnerText;
                Console.WriteLine(l[0].InnerText);
                l = d.GetElementsByTagName("width");
                Console.WriteLine(l[0].InnerText);
                this.Width = int.Parse(l[0].InnerText.Trim());
                l = d.GetElementsByTagName("height");
                this.Height = int.Parse(l[0].InnerText.Trim());
                l = d.GetElementsByTagName("background");
                this.BackColor = Color.FromName(l[0].InnerText);
                l = d.GetElementsByTagName("foreground");
                this.textBox1.ForeColor = Color.FromName(l[0].InnerText);
                this.label1.ForeColor = Color.FromName(l[0].InnerText);
            }

        }
    }
}
