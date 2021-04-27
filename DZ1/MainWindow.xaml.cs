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

namespace DZ1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MainPasswordBox.Password == "tuptup" && MainTextBox.Text == "login1")
            {
                Window2 Meneger = new Window2();
                Meneger.Show();

            }
            else
            {

                MessageBox.Show("User not fount");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (MainPasswordBox.Password == "tuptup" && MainTextBox.Text == "login1")
            {
                Window2 Meneger = new Window2();
                Meneger.Show();

            }
        }
    }
}
