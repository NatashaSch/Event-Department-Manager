using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDepartmentManager
{
        [Serializable]
        public class ListOfProjects
        {
            public List<Project> Proj { get; set; }
            public ListOfProjects(List<Project> proj)
            {
                Proj = proj;
            }
            public ListOfProjects()
            {

            }
        }
    
}
