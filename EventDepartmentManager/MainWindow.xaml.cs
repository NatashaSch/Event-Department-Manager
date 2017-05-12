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
using System.Drawing;


namespace EventDepartmentManager
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


        private void CurrentProject_Click(object sender, RoutedEventArgs e)
        {
            StartBlock.Visibility = Visibility.Hidden;
            CurrentProjectBlock.Visibility = Visibility.Visible;
        }

        private void CurrentClients_Click(object sender, RoutedEventArgs e)
        {
            StartBlock.Visibility = Visibility.Hidden;
            CurrentClientsBlock.Visibility = Visibility.Visible;
        }
    }
}
