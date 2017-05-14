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

        public List<Project> projects = new List<Project>();
        Project pr;

        public List<Customer> customers = new List<Customer>();
        Customer cs;

        public MainWindow()
        {
            InitializeComponent();




        }

    



        private void CurrentProject_Click(object sender, RoutedEventArgs e)
        {
            StartBlock.Visibility = Visibility.Hidden;
            CurrentClientsBlock.Visibility = Visibility.Hidden;
            CurrentProjectBlock.Visibility = Visibility.Visible;
        }

        private void CurrentClients_Click(object sender, RoutedEventArgs e)
        {
            StartBlock.Visibility = Visibility.Hidden;
            CurrentProjectBlock.Visibility = Visibility.Hidden;
            CurrentClientsBlock.Visibility = Visibility.Visible;
        }

        private void AddProject_Click(object sender, RoutedEventArgs e)
        {
            AddProject wnd = new AddProject(this);
            wnd.Show();
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer wndC = new AddCustomer(this);
            wndC.Show();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Project pr in projects)
            {
                if (pr.Name == SearchProject.Text)
                {
                    NameText.Text = pr.Name;
                    Info1.Text = pr.Description;
                    Info2.Text = pr.Employee;
                    Info3.Text = pr.Customer.Name ;
                    Info4.Text = pr.People.ToString();
                    Info5.Text = pr.Money.ToString();
                    Info6.Text = pr.Date.ToString();
                    break;
                }
                else
                    MessageBox.Show("Данный проект не найден");
            }
        }

        private void ChangeProject_Click(object sender, RoutedEventArgs e)
        {
            foreach(Project pr in projects )
            {

            }
            NameText.Text = pr.Name;
            Info1.Text = pr.Description;
            Info2.Text = pr.Employee;
            Info3.Text = pr.Customer.Name;
            Info4.Text = pr.People.ToString();
            Info5.Text = pr.Money.ToString();
            Info6.Text = pr.Date.ToString();

            AllPrListBox.Items.Remove(pr);
            AllPrListBox.Items.Add(pr.Name);

            projects.Remove((Project)pr);
            

        }

        private void DeleteProject_Click(object sender, RoutedEventArgs e)
        {
            Object st = AllPrListBox.SelectedItem;
            AllPrListBox.Items.Remove(pr);
            projects.Remove((Project)pr);

            NameText.Text = "";
            Info1.Text = "";
            Info2.Text = "";
            Info3.Text = "";
            Info4.Text = "";
            Info5.Text = "";
            Info6.Text = "";
        }

        private void SearchClientsBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (Customer cs in customers)
            {
                if (cs.Name == SearchClients.Text)
                {
                    NameCustomerText.Text = cs.Name;
                    SiteText.Text = cs.Site;
                    RepresentativeText.Text = cs.Representative;
                    PhoneNumberText.Text = cs.RepPhone.ToString();
                    
                    break;
                }
                else
                    MessageBox.Show("Данный заказчик не найден");
            }
        }

        private void DeleteClient_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

