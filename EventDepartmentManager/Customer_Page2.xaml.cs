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
            try
            {

                Customer cust = new Customer(NameCustomerText.Text, SiteText.Text, RepresentativeText.Text, PhoneNumberText.Text);

                lc.Cust.Add(cust);
                Log.logging("Добавлен клиент: " + cust.Name + " " + DateTime.Now);
                Serialization.Serialize(lc);

                ClientsListBox.Items.Clear();


                lc = Serialization.Deserialze(lc);

                NameCustomerText.Clear();
                SiteText.Clear();
                RepresentativeText.Clear();
                PhoneNumberText.Clear();


                foreach (var item in lc.Cust)
                {
                    ClientsListBox.Items.Add(item.Name);


                }
                MessageBox.Show("Сохранено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.logging("Ошибка" + ex);
            }
          }

        private void ClientsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                foreach (var cs in lc.Cust)
                {
                    if (ClientsListBox.SelectedItem != null)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.logging("Ошибка" + ex);

            }
            

        }

        private void SearchClientsBtn_Click(object sender, RoutedEventArgs e)
        {
            try
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
                    Log.logging("Произведен поиск клиента: " + cs.Name + " " + DateTime.Now);
                }
                if (!exist_c)
                {
                    MessageBox.Show("Такой заказчик не найден");
                    Log.logging("Ошибка: искомого заказчика не существует");

                }
                exist_c = false;

                SearchClients.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.logging("Ошибка: " + ex);
            }
        }

        private void DeleteClient_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                foreach (Customer cs in lc.Cust)
                {
                    if (ClientsListBox.SelectedItem != null)
                    {
                        if (cs.Name == ClientsListBox.SelectedItem.ToString())
                        {

                            NameCustomerText.Text = cs.Name;
                            SiteText.Text = cs.Site;
                            RepresentativeText.Text = cs.Representative;
                            PhoneNumberText.Text = cs.RepPhone.ToString();

                            Log.logging("Удален клиент: " + cs.Name + " " + DateTime.Now);
                            lc.Cust.Remove(cs);

                            break;
                        }
                    }
                }
                Serialization.Serialize(lc);



                ClientsListBox.Items.Clear();

                foreach (var item in lc.Cust)
                {
                    ClientsListBox.Items.Add(item.Name);
                }



                NameCustomerText.Clear();
                SiteText.Clear();
                RepresentativeText.Clear();
                PhoneNumberText.Clear();

                MessageBox.Show("Удалено!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.logging("Ошибка: " + ex);
            }
         }

        private void HelpClients_Click(object sender, RoutedEventArgs e)
        {
            Info_customer wnd = new Info_customer();
            wnd.Show();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            NameCustomerText.Clear();
            SiteText.Clear();
            RepresentativeText.Clear();
            PhoneNumberText.Clear();
        }
    }
}
