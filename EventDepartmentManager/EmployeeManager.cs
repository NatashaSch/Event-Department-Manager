using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDepartmentManager
{
    class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();

        public void addNewEmployee(Employee emp)
        {
            employees.Add(emp);
        }

        public void removeEmployee(Employee emp)
        {
            employees.Remove(emp);
        }

        public List<Employee> getAllEmployees()
        {
            return employees;
        }

        public Employee getOneEmployee(string login)
        {
            Employee emp = new Employee();
            foreach (var item in employees)
            {
                if (item.Login == login)
                {
                    emp = item;
                }
            }
            return emp;
        }

        public void EditEmployee()
        {
            //this method will be implemented later 
        }

    }
}
