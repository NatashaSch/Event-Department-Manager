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
            set { _lastName = value; }
        }

        public string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Manager(string lN, string n)
        {
            LastName = lN;
            Name = n;
        }
    }
}
