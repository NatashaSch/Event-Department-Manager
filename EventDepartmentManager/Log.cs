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
        public static List<string> loging = new List<string>();

        public static void Loging ()

        {
            using (FileStream fs = new FileStream("../../log.txt", FileMode.Open))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    foreach (var item in loging)
                    {
                        sw.WriteLine(item);
                    }
                   
                }
            }
        }  


    }
}
