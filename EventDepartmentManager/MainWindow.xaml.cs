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
            ////десериализация для заказчиков
            //lc.Cust = new List<Customer>();

            //lc = Serialization.Deserialze(lc);
            //foreach (var item in lc.Cust)
            //{
            //    ClientsListBox.Items.Add(item.Name);

            //}

            //десериализация для проектов
            //lp.Proj = new List<Project>();

            //lp = Serialization.Deserialze_proj(lp);
            //foreach (var item in lp.Proj)
            //{
            //    AllPrListBox.Items.Add(item.Name);

            //}

            ////чтение из текстового файла и вывод информации в поле "Руководитель"
            //using (FileStream fs = new FileStream(@"../../input_managers.txt", FileMode.Open, FileAccess.Read))
            //{
            //    string[] data_txt;
            //    Manager mg;
            //    StreamReader sr = new StreamReader(fs, Encoding.Default);

            //    while (!sr.EndOfStream)
            //    {
            //        data_txt = sr.ReadLine().Split(' ');
            //        mg = new Manager(data_txt[0], data_txt[1]);
            //        managers.Add(mg);
            //    }



            //    sr.Close();
            //    fs.Close();
            //}

            //foreach (Manager mg in managers)
            //{
            //    string emp = mg._name + ' ' + mg._lastName;
            //    ManagerComboBox.Items.Add(emp);
            //}
            ////вывод информации в поле "Заказчик"
            //foreach (var item in lc.Cust)
            //{
            //    CustomerComboBox.Items.Add(item.Name);

            //}
        
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

        private void AddProject_Click(object sender, RoutedEventArgs e)
        {
           
            //Customer customer = null;
            //lc.Cust = new List<Customer>();

            //lc = Serialization.Deserialze(lc);
            //foreach (var item in lc.Cust)
            //{
            //    if (CustomerComboBox.SelectedItem.ToString() == item.Name)
            //    {
            //        customer = item;
            //    }
            //}
            //lp.Proj = new List<Project>();

            //lp = Serialization.Deserialze_proj(lp);
            
            //Project proj = new Project(NameText.Text, Description.Text, ManagerComboBox.Text, customer, int.Parse(People.Text), int.Parse(Money.Text), Date.Text);
            
            //lp.Proj.Add(proj);

            //Serialization.Serialize_proj(lp);

            //MessageBox.Show("Сохранено!");

            //NameText.Text = "";
            //Description.Text = "";
            //ManagerComboBox.Text = "";
            //CustomerComboBox.Text = "";
            //People.Text = "";
            //Money.Text = "";
            //Date.Text = "";

            //AllPrListBox.Items.Clear();
            //foreach (var item in lp.Proj)
            //{
            //    AllPrListBox.Items.Add(item.Name);
            //}





        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            //Customer cust = new Customer(NameCustomerText.Text, SiteText.Text, RepresentativeText.Text, int.Parse(PhoneNumberText.Text));

            //lc.Cust.Add(cust);

            //Serialization.Serialize(lc);

            //MessageBox.Show("Сохранено!");

            //ClientsListBox.Items.Clear();

            //lc.Cust = new List<Customer>();

            //lc = Serialization.Deserialze(lc);
            //foreach (var item in lc.Cust)
            //{
            //    ClientsListBox.Items.Add(item.Name);
               

            //}
        }

        public void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            
            //foreach (Project pr in lp.Proj)
            //{

            //    if (pr.Name == SearchProject.Text)
            //    {
                    
            //        NameText.Text = pr.Name;
            //        Description.Text = pr.Description;
            //        ManagerComboBox.Text = pr.Employee;
            //        CustomerComboBox.Text = pr.Customer.Name;
            //        People.Text = pr.People.ToString();
            //        Money.Text = pr.Money.ToString();
            //        Date.Text = pr.Date.ToString();
            //        exist_p = true;
            //        break;
            //    }
                
                
                    
            //}
            //if (!exist_p)
            //{
            //    MessageBox.Show("Такой заказчик не найден");
            //}
            //exist_p = false;

        }

        private void ChangeProject_Click(object sender, RoutedEventArgs e)
        {
            
            //foreach (var pr in lp.Proj)
            //{
            //    if (AllPrListBox.SelectedItem.ToString() == pr.Name)
            //    {
            //        int k = lp.Proj.IndexOf(pr);
            //        lp.Proj.RemoveAt(k);
            //        break;
            //    }


            //}
            //Customer customer = null;
            //lc.Cust = new List<Customer>();

            //lc = Serialization.Deserialze(lc);
            //foreach (var item in lc.Cust)
            //{
            //    if (CustomerComboBox.SelectedItem.ToString() == item.Name)
            //    {
            //        customer = item;
            //    }
            //}
            

            //Project proj = new Project(NameText.Text, Description.Text, ManagerComboBox.Text, customer, int.Parse(People.Text), int.Parse(Money.Text), Date.Text);

            //lp.Proj.Add(proj);
            //Serialization.Serialize_proj(lp);

            //MessageBox.Show("Сохранено!");

            ////NameText.Text = " ";
            ////Description.Text = " ";
            ////ManagerComboBox.Text = " ";
            ////CustomerComboBox.Text = " ";
            ////People.Text = " ";
            ////Money.Text = " ";
            ////Date.Text = " ";


            //AllPrListBox.SelectedItem = null;
            //AllPrListBox.Items.Clear();
            //foreach (var item in lp.Proj)
            //{
            //    AllPrListBox.Items.Add(item.Name);
            //}


            



        }

        private void DeleteProject_Click(object sender, RoutedEventArgs e)
        {
            //Object st = AllPrListBox.SelectedItem;
            //AllPrListBox.Items.Remove(lp.Proj);
            //lp.Proj.Remove((Project)lp);

            //NameText.Text = "";
            //Info1.Text = "";
            //Info2.Text = "";
            //Info3.Text = "";
            //Info4.Text = "";
            //Info5.Text = "";
            //Info6.Text = "";
        }

        private void SearchClientsBtn_Click(object sender, RoutedEventArgs e)
        {
            //foreach (Customer cs in lc.Cust)
            //{
            //    if (cs.Name == SearchClients.Text)
            //    {
            //        NameCustomerText.Text = cs.Name;
            //        SiteText.Text = cs.Site;
            //        RepresentativeText.Text = cs.Representative;
            //        PhoneNumberText.Text = cs.RepPhone.ToString();
            //        exist_c = true;
            //        break;
            //    }
                
            //}
            //if (!exist_c)
            //{
            //    MessageBox.Show("Такой заказчик не найден");
                
            //}
            //exist_c = false;
        }

        private void DeleteClient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClientsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //foreach (var cs in lc.Cust)
            //{
            //    if (ClientsListBox.SelectedItem.ToString() == cs.Name)
            //    {
            //        NameCustomerText.Text = cs.Name;
            //        SiteText.Text = cs.Site;
            //        RepresentativeText.Text = cs.Representative;
            //        PhoneNumberText.Text = cs.RepPhone.ToString();
                    

            //    }


            //}
        }

        private void AllPrListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //foreach (var pr in lp.Proj)
            //{
            //    if (AllPrListBox.SelectedItem.ToString() == pr.Name)
            //    {
            //        NameText.Text = pr.Name;
            //        Description.Text = pr.Description;
            //        ManagerComboBox.Text = pr.Employee;
            //        CustomerComboBox.Text = pr.Customer.Name;
            //        People.Text = pr.People.ToString();
            //        Money.Text = pr.Money.ToString();
            //        Date.Text = pr.Date.ToString();

            //    }


            //}


        }
    }
}

