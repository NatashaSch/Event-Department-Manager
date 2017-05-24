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
using System.IO;
using System.Xml.Serialization;





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
            Log.logging("Выполнен вход в систему" + " " + "Время: " + DateTime.Now);

        }





        private void CurrentProject_Click(object sender, RoutedEventArgs e)
        {
          
            MainPage.Content = new Projects_Page1();
        }

        private void CurrentClients_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Content = new Customer_Page2();
        }

    }
}

