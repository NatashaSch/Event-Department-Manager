using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace EventDepartmentManager
{
    class Serialization
    {
        static List<Project> projects = new List<Project>();
        static XmlSerializer serializer = new XmlSerializer(typeof(List<Project>));
        static string file = "../../data.xml";

        static void Main(string[] args)
        {
            projects.Add(new Project {n = In});

            Deserialze();
            Serialize();

            foreach (A a in As)
            {
                Console.WriteLine(a.Name + " " + a.Age);
            }

            Console.WriteLine("Success");
            Console.ReadKey();
        }

        private static void Serialize()
        {
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, As);
            };
        }

        private static void Deserialze()
        {
            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                object data = serializer.Deserialize(fs);
                if (data is List<A>)
                    As.AddRange(data as List<A>);
            }
        }
    }

    public class A
    {
        public B B { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class B
    {

    }


}
}
