using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace utils
{
    public class ConsoleUtils
    {
        public static void printDatatable(DataTable dt)
        {
            foreach(DataRow row in dt.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
