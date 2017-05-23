using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EventDepartmentManager
{
    public class Log
    {
        public static void Logging (string log)

        {
            using (FileStream fs = new FileStream("../../log.txt", FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    sw.WriteLine(log);
                }
            }
        }  


    }
}
