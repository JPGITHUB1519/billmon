using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utils
{
    public class Configuration
    {
        public static string system_name = "BillMon";
        public static string version = "V1.0";
        public static List<string> developers = new List<string>()
        {
            "Jean Ureña"
        };
        public static string success_message = "OK";
        public static string error_message = "Error";
        public static string db_ok = "ok";
        public static string insert_sucess = "Exito al Ingresar";
        public static string update_success = "Exito al Editar";
        public static string delete_success = "Exito al eliminar";
    }
}
