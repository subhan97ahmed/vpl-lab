using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace lab_8
{
    /// <summary>
    /// Interaction logic for view_Window.xaml
    /// </summary>
    public partial class view_Window : Window
    {
        string data = "";
        public view_Window()
        {
            InitializeComponent();
        }
        public view_Window(string d)
        {
            InitializeComponent();
            this.data = d;
            if (!data.Equals(""))
            {
               
                String[] d2 = d.Split(',');
                var s = new Student { id = d2[0], name = d2[1], age = d2[2] };
                this.data_view.Items.Add(s);
                //this.data_view.ColumnWidth
                this.UpdateLayout();
            }

        }

        private void Data_view_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
