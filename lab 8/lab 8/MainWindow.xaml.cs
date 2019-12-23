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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String data;
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(string data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            add_Window aw = new add_Window();
            this.Hide();
            aw.ShowDialog();
            this.Close();
        }

        private void View_button_Click(object sender, RoutedEventArgs e)
        {
            view_Window vw = new view_Window(data);
            vw.ShowDialog();
        }
    }
}
