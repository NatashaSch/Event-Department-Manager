using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDepartmentManager
{
    [Serializable]
    
    public class Customer
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _site;

        public string Site
        {
            get { return _site; }
            set { _site = value; }
        }

        private string _representative;

        public string Representative
        {
            get { return _representative; }
            set { _representative = value; }
        }

        private int _repPhone;

        public int RepPhone
        {
            get { return _repPhone; }
            set { _repPhone = value; }
        }

        public Customer(string n, string s, string r, int rP)
        {
            Name = n;
            Site = s;
            Representative = r;
            RepPhone = rP;

        }

        public Customer()
        {

        }
    }
}
