using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EventDepartmentManager
{
    class ProjectManager
    {
        private List<Project> projects = new List<Project>();

        public void addProject(Project project)
        {
            projects.Add(project);
        }

        public void removeProject(Project project)
        {
            projects.Remove(project);
        }

        public List<Project> getAllProjects()
        {
            return projects;
        }

        public Project showOneProject(string name)
        {
            Project prj = new Project();
            foreach (var item in projects)
            {
                if (item.Name == name)
                {
                    prj = item;
                }
            }
            return prj;
        }

        public void editProject()
        {
            //this method will be implemented later 
        }




    }
}  
           