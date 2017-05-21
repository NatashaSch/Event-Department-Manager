using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace EventDepartmentManager
{
    public class Serialization
    {
        public static XmlSerializer serializer = new XmlSerializer(typeof(ListOfCustomers));
        static string file = "../../data_customer.xml";

        public static XmlSerializer serializer_proj = new XmlSerializer(typeof(ListOfProjects));
        static string file_proj = "../../data_project.xml";

        public static void Serialize(ListOfCustomers lc)
        {
            using (FileStream fs = new FileStream(file, FileMode.Create))
            {
                serializer.Serialize(fs, lc);

                
            };
        }

        public static ListOfCustomers Deserialze(ListOfCustomers lc)
        {
            ListOfCustomers data = null;
            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                data = (ListOfCustomers)serializer.Deserialize(fs);

            };
            return data;
        }



        //сериализация и десериализация проектов
        public static void Serialize_proj(ListOfProjects lp)
        {
            using (FileStream fs = new FileStream(file_proj, FileMode.Create))
            {
                serializer_proj.Serialize(fs, lp);

            };
        }

        public static ListOfProjects Deserialze_proj(ListOfProjects lp)
        {
            ListOfProjects data_proj = null;
            using (FileStream fs = new FileStream(file_proj, FileMode.Open))
            {
                data_proj = (ListOfProjects)serializer_proj.Deserialize(fs);

            };
            return data_proj;
        }



    }

  


}
