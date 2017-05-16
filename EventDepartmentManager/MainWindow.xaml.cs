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
        public ListOfCustomers lc = new ListOfCustomers();
        public List<Project> projects = new List<Project>();
        Project pr;

        
        Customer cs;

        public MainWindow()
        {
            InitializeComponent();
            lc.Cust = new List<Customer>();

            lc = Serialization.Deserialze(lc);
            foreach (var item in lc.Cust)
            {
                ClientsListBox.Items.Add(item.Name);
                //NameCustomerText.Items.Add(item.Site);

            }





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
            Customer cust = new Customer(NameCustomerText.Text, SiteText.Text, RepresentativeText.Text, int.Parse(PhoneNumberText.Text));

            lc.Cust.Add(cust);

            Serialization.Serialize(lc);

            MessageBox.Show("Сохранено!");

            ClientsListBox.Items.Clear();

            lc.Cust = new List<Customer>();

            lc = Serialization.Deserialze(lc);
            foreach (var item in lc.Cust)
            {
                ClientsListBox.Items.Add(item.Name);
               

            }
        }

        public void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (Project pr in projects)
            {

                if (pr.Name == SearchProject.Text)
                {
                    
                    NameText.Text = pr.Name;
                    Info1.Text = pr.Description;
                    Info2.Text = pr.Employee;
                    Info3.Text = pr.Customer.Name;
                    Info4.Text = pr.People.ToString();
                    Info5.Text = pr.Money.ToString();
                    Info6.Text = pr.Date.ToString();
                    exist_p = true;
                    break;
                }
                
                
                    
            }
            if (!exist_p)
            {
                MessageBox.Show("Такой заказчик не найден");
            }
            exist_p = false;

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
            foreach (Customer cs in lc.Cust)
            {
                if (cs.Name == SearchClients.Text)
                {
                    NameCustomerText.Text = cs.Name;
                    SiteText.Text = cs.Site;
                    RepresentativeText.Text = cs.Representative;
                    PhoneNumberText.Text = cs.RepPhone.ToString();
                    exist_c = true;
                    break;
                }
                
            }
            if (!exist_c)
            {
                MessageBox.Show("Такой заказчик не найден");
                
            }
            exist_c = false;
        }

        private void DeleteClient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClientsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

