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
using System.IO;

namespace EventDepartmentManager
{
    /// <summary>
    /// Логика взаимодействия для AddProject.xaml
    /// </summary>
    public partial class AddProject : Window
    {
        public List<Manager> managers = new List<Manager>();
        public List<Customer> customers = new List<Customer>();
        Customer cs;

        MainWindow wnd;
        public AddProject(MainWindow w)
        {
            wnd = w;
            InitializeComponent();


            using (FileStream fs = new FileStream(@"../../input_managers.txt", FileMode.Open, FileAccess.Read))
            {
                string[] data;
                Manager mg;
                StreamReader sr = new StreamReader(fs, Encoding.Default);

                while (!sr.EndOfStream)
                {
                    data = sr.ReadLine().Split(' ');
                    mg = new Manager(data[0], data[1]);
                    managers.Add(mg);
                }

             

                sr.Close();
                fs.Close();
            }



            foreach (Manager mg in managers)
            {
                string emp = mg._name + ' ' + mg._lastName;
                EmploeeListBox.Items.Add(emp);
            }


            CustomerListBox.Items.Add(cs.Name);
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {
           
            //Project pro = new Project(NameText.Text, Description.Text, EmploeeListBox.SelectedItem.ToString(), (Customer)CustomerListBox.SelectedItem, int.Parse(People.Text), int.Parse(MoneyFor.Text), Deadline.SelectedDate);
            //List<Project> pr = new List<Project>();
            //pr.Add(pro);
            //Serialization.Serialize(pr);
        }

        private void AddNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
