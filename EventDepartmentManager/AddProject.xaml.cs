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

namespace EventDepartmentManager
{
    /// <summary>
    /// Логика взаимодействия для AddProject.xaml
    /// </summary>
    public partial class AddProject : Window
    {
        

        MainWindow wnd;
        public AddProject(MainWindow w)
        {
            wnd = w;
            InitializeComponent();

            
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer wnd = new AddCustomer(this);
            wnd.Show();
        }
    }
}
