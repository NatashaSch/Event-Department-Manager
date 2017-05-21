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
        public bool exist_p = true;
        public bool exist_c = true;
        public List<Manager> managers = new List<Manager>();
        public ListOfCustomers lc = new ListOfCustomers();
        public ListOfProjects lp = new ListOfProjects();



        public MainWindow()
        {
            InitializeComponent();
           
        
        }





        private void CurrentProject_Click(object sender, RoutedEventArgs e)
        {
            //StartButtons.Visibility = Visibility.Hidden;
            //CurrentClientsBlock.Visibility = Visibility.Hidden;
            //CurrentProjectBlock.Visibility = Visibility.Visible;

            MainPage.Content = new Projects_Page1();
        }

        private void CurrentClients_Click(object sender, RoutedEventArgs e)
        {
            //StartButtons.Visibility = Visibility.Hidden;
            //CurrentProjectBlock.Visibility = Visibility.Hidden;
            //CurrentClientsBlock.Visibility = Visibility.Visible;

            MainPage.Content = new Customer_Page2();
        }

    }
}

