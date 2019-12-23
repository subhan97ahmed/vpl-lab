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
    /// Interaction logic for add_Window.xaml
    /// </summary>
    public partial class add_Window : Window
    {
        public add_Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String data =this.id_box.Text;
            data = data + "," + this.name_box.Text;
            data = data + "," + this.age_box.Text;
            MainWindow mw = new MainWindow(data);
            this.Hide();
            mw.ShowDialog();
            this.Close();
        }
    }
}
