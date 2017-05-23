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
            set {
                    if (!String.IsNullOrWhiteSpace(value))
                        _name = value;
                    else
                        throw new Exception();
                }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set {
                if (!String.IsNullOrWhiteSpace(value))
                    _description = value;
                else
                    throw new Exception();
                }
        }

        private string _employee;

        public string Employee
        {
            get { return _employee; }
            set {
                if (!String.IsNullOrWhiteSpace(value))
                    _employee = value;
                else
                    throw new Exception();
                }
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
            set {
                if (value >= 0)
                    _people = value;
                else
                    throw new Exception();
            }
        }

        private double _money;

        public double Money
        {
            get { return _money; }
            set { 
                    if (value >= 0)
                         _money = value;
                    else
                        throw new Exception();
                }
        }

        private string _date;

        public string Date
        {
            get { return _date; }
            set {
               
                if (!String.IsNullOrWhiteSpace(value))
                    _date = value;
                else
                    throw new Exception();
            }
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
