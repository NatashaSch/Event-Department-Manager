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
        //public static List<Project> pr = new List<Project>();
        public static XmlSerializer serializer = new XmlSerializer(typeof(ListOfCustomers));
        static string file = "../../data_customer.xml";



        public static void Serialize(ListOfCustomers lc)
        {
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, lc);

                
            };
        }

        public static ListOfCustomers Deserialze(ListOfCustomers lc)
        {
            ListOfCustomers data = null;
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                data = (ListOfCustomers)serializer.Deserialize(fs);
               
            };
            return data;
        }
    }

  


}
