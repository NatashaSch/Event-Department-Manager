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
using System.Xml.Serialization;
using System.IO;

namespace EventDepartmentManager
{
    /// <summary>
    /// Логика взаимодействия для Customer_Page2.xaml
    /// </summary>
    public partial class Customer_Page2 : Page
    {
        public bool exist_c = true;
        
        public ListOfCustomers lc = new ListOfCustomers();
        public ListOfProjects lp = new ListOfProjects();


        public Customer_Page2()
        {
            InitializeComponent();

            //десериализация для заказчиков
            lc.Cust = new List<Customer>();

            lc = Serialization.Deserialze(lc);
            foreach (var item in lc.Cust)
            {
                ClientsListBox.Items.Add(item.Name);

            }

            

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

        private void ClientsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var cs in lc.Cust)
            {
                if (ClientsListBox.SelectedItem.ToString() == cs.Name)
                {
                    NameCustomerText.Text = cs.Name;
                    SiteText.Text = cs.Site;
                    RepresentativeText.Text = cs.Representative;
                    PhoneNumberText.Text = cs.RepPhone.ToString();


                }


            }
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

    
    }
}
