using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDepartmentManager
{
    class Project
    {

        public Project(string name, string description, DateTime endDate, Client client, List<Employee> team)
        {
            Name = name;
            Description = description;
            EndDate = endDate;
            Client = client;
            Team = team;
        }
    }
}
