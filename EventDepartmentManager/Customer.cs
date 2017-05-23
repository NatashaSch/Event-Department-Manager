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
            set {
                    if (!String.IsNullOrWhiteSpace(value))
                        _name = value;
                    else
                        throw new Exception();
                 }
        }

        private string _site;

        public string Site
        {
            get { return _site; }
            set { 
                if (!String.IsNullOrWhiteSpace(value))
                    _site = value;
                else
                    throw new Exception();
                 }
        }

        private string _representative;

        public string Representative
        {
            get { return _representative; }
            set { 
                if (!String.IsNullOrWhiteSpace(value))
                    _representative = value;
                else
                    throw new Exception();
                  }
        }

        private string _repPhone;

        public string RepPhone
        {
            get { return _repPhone; }
            set {
                if (!String.IsNullOrWhiteSpace(value))
                    _repPhone = value;
                else
                    throw new Exception();
                 }
        }
        

        public Customer(string n, string s, string r, string rP)
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
