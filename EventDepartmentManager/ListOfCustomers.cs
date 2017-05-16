using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDepartmentManager
{
    [Serializable]
    public class ListOfCustomers
    {
        public List<Customer> Cust { get; set; }
        public ListOfCustomers(List<Customer> cust)
        {
            Cust = cust;
        }
        public ListOfCustomers()
        {

        }
    }
}
