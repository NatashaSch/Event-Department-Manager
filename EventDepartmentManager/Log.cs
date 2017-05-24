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
        public static void logging(string log)
        {
            using (var l = File.AppendText("../../log.txt"))
            {
                l.WriteLine(log);
            }
        }


    }
}
