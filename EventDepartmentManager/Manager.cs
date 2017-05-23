using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDepartmentManager
{
   public  class Manager
    {
        
        public string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { 
                if (!String.IsNullOrWhiteSpace(value))
                    _lastName = value;
                else
                    throw new Exception();
                }
        }

        public string _name;

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

        public Manager(string lN, string n)
        {
            LastName = lN;
            Name = n;
        }
    }
}
