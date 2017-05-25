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
    /// Логика взаимодействия для Projects_Page1.xaml
    /// </summary>
    public partial class Projects_Page1 : Page
    {
        public ListOfProjects lp = new ListOfProjects();
        public ListOfCustomers lc = new ListOfCustomers();
        public List<Manager> managers = new List<Manager>();

        public bool exist_p = true;

        public Projects_Page1()
        {
            InitializeComponent();

            try
            {

                //десериализация для проектов
                //lp.Proj = new List<Project>();

                lp = Serialization.Deserialze_proj(lp);
                foreach (var item in lp.Proj)
                {
                    AllPrListBox.Items.Add(item.Name);

                }

                //чтение из текстового файла и вывод информации в поле "Руководитель"
                using (FileStream fs = new FileStream(@"../../input_managers.txt", FileMode.Open, FileAccess.Read))
                {
                    string[] data_txt;
                    Manager mg;
                    StreamReader sr = new StreamReader(fs, Encoding.Default);

                    while (!sr.EndOfStream)
                    {
                        data_txt = sr.ReadLine().Split(' ');
                        mg = new Manager(data_txt[0], data_txt[1]);
                        managers.Add(mg);
                    }



                    sr.Close();
                    fs.Close();
                }

                foreach (Manager mg in managers)
                {
                    string emp = mg._name + ' ' + mg._lastName;
                    ManagerComboBox.Items.Add(emp);
                }

                //вывод информации в поле "Заказчик"

                lc.Cust = new List<Customer>();

                lc = Serialization.Deserialze(lc);
                foreach (var item in lc.Cust)
                {
                    CustomerComboBox.Items.Add(item.Name);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.logging("Ошибка: " + ex);
            }
        }

        private void ChangeProject_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                foreach (var pr in lp.Proj)
                {
                    if (AllPrListBox.SelectedItem != null)
                    { 
                        if (AllPrListBox.SelectedItem.ToString() == pr.Name)
                        {
                            int k = lp.Proj.IndexOf(pr);
                            lp.Proj.RemoveAt(k);
                            break;
                        }
                     }
                }

                

                Customer customer = null;
                lc.Cust = new List<Customer>();

                lc = Serialization.Deserialze(lc);
                foreach (var item in lc.Cust)
                {
                    if (CustomerComboBox.SelectedItem.ToString() == item.Name)
                    {
                        customer = item;
                    }
                }


                Project proj = new Project(NameText.Text, Description.Text, ManagerComboBox.Text, customer, int.Parse(People.Text), int.Parse(Money.Text), Date.Text);

              
                lp.Proj.Add(proj);
          

                Log.logging("Изменен проект: " + proj.Name + " " + DateTime.Now);
                Serialization.Serialize_proj(lp);

               
                MessageBox.Show("Сохранено!");

                AllPrListBox.Items.Clear();
                foreach (var item in lp.Proj)
                {
                    AllPrListBox.Items.Add(item.Name);
                }



                NameText.Clear();
                Description.Clear();
                ManagerComboBox.SelectedIndex = -1;
                CustomerComboBox.SelectedIndex = -1;
                People.Clear();
                Money.Clear();
                Date.Clear();

                AllPrListBox.SelectedItem = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.logging("Ошибка: " + ex);
            }

        }

        private void AddProject_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AllPrListBox.SelectedItem.ToString() != NameText.Text)
                {
                    Customer customer = null;
                    lc.Cust = new List<Customer>();

                    lc = Serialization.Deserialze(lc);
                    foreach (var item in lc.Cust)
                    {
                        if (CustomerComboBox.SelectedItem.ToString() == item.Name)
                        {
                            customer = item;
                        }
                    }



                    Project proj = new Project(NameText.Text, Description.Text, ManagerComboBox.Text, customer, int.Parse(People.Text), int.Parse(Money.Text), Date.Text);

                    lp.Proj.Add(proj);
                    Log.logging("Добавлен проект: " + proj.Name + " " + DateTime.Now);

                    Serialization.Serialize_proj(lp);

                    lp = Serialization.Deserialze_proj(lp);

                    MessageBox.Show("Сохранено!");


                    AllPrListBox.Items.Clear();
                    foreach (var item in lp.Proj)
                    {
                        AllPrListBox.Items.Add(item.Name);
                    }
                }
                else
                {
                    MessageBox.Show("Такой проект уже существует");
               
                }

                AllPrListBox.SelectedItem = -1;
                NameText.Clear();
                Description.Clear();
                ManagerComboBox.SelectedIndex = -1;
                CustomerComboBox.SelectedIndex = -1;
                People.Clear();
                Money.Clear();
                Date.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.logging("Ошибка: " + ex);
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                foreach (Project pr in lp.Proj)
                {

                    if (pr.Name == SearchProject.Text)
                    {

                        NameText.Text = pr.Name;
                        Description.Text = pr.Description;
                        ManagerComboBox.Text = pr.Employee;
                        CustomerComboBox.Text = pr.Customer.Name;
                        People.Text = pr.People.ToString();
                        Money.Text = pr.Money.ToString();
                        Date.Text = pr.Date.ToString();
                        exist_p = true;

                        Log.logging("Выполнен поиск проекта: " + pr.Name + " " + DateTime.Now);
                        break;
                    }
                   


                }
                if (!exist_p)
                {
                    MessageBox.Show("Такой заказчик не найден");
                }
                exist_p = false;

                SearchProject.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.logging("Ошибка: " + ex);
            }

        }

        private void AllPrListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                foreach (var pr in lp.Proj)
                {
                    if (AllPrListBox.SelectedItem != null)
                    {
                        if (AllPrListBox.SelectedItem.ToString() == pr.Name)
                        {
                            NameText.Text = pr.Name;
                            Description.Text = pr.Description;
                            ManagerComboBox.Text = pr.Employee;
                            CustomerComboBox.Text = pr.Customer.Name;
                            People.Text = pr.People.ToString();
                            Money.Text = pr.Money.ToString();
                            Date.Text = pr.Date.ToString();
                            break;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.logging("Ошибка: " + ex);
            }

        }


        private void DeleteProject_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                foreach (Project pr in lp.Proj)
                {
                    if (AllPrListBox.SelectedItem != null)
                    {
                        if (pr.Name == AllPrListBox.SelectedItem.ToString())
                        {

                            NameText.Text = pr.Name;
                            Description.Text = pr.Description;
                            ManagerComboBox.Text = pr.Employee;
                            CustomerComboBox.Text = pr.Customer.Name;
                            People.Text = pr.People.ToString();
                            Money.Text = pr.Money.ToString();
                            Date.Text = pr.Date.ToString();

                            Log.logging("Удален проект: " + pr.Name + " " + DateTime.Now);


                            lp.Proj.Remove(pr);
                            break;
                        }
                    }
                }
                Serialization.Serialize_proj(lp);

                AllPrListBox.Items.Clear();

                foreach (var item in lp.Proj)
                {
                    AllPrListBox.Items.Add(item.Name);
                }

                NameText.Clear();
                Description.Clear();
                ManagerComboBox.SelectedIndex = -1;
                CustomerComboBox.SelectedIndex = -1;
                People.Clear();
                Money.Clear();
                Date.Clear();

             
                MessageBox.Show("Удалено!");
         

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.logging("Ошибка: " + ex);
            }

        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            Info_proj wnd = new Info_proj();
            wnd.Show();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            NameText.Clear();
            Description.Clear();
            ManagerComboBox.SelectedIndex = -1;
            CustomerComboBox.SelectedIndex = -1;
            People.Clear();
            Money.Clear();
            Date.Clear();
        }
    }
}