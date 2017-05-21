using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EventDepartmentManager
{

    [Serializable]
    public class Project
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _employee;

        public string Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }

        private Customer _customer;

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }

        }


        private int _people;

        public int People
        {
            get { return _people; }
            set { _people = value; }
        }

        private double _money;

        public double Money
        {
            get { return _money; }
            set { _money = value; }
        }

        private string _date;

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Project(string n, string d, string e, Customer c, int p, double m, string dt )
        {
            Name = n;
            Description = d;
            Employee = e;
            Customer = c;
            People = p;
            Money = m;
            Date = dt;
        }

        public Project()
        {

        }

        
    }
}
