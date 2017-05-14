using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utils;

namespace utils
{
    public class Messages
    {
        public static void successMessage(string message)
        {
            /* para imprimir mensajes de Exito*/
            MessageBox.Show(message, Configuration.system_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void errorMessage(string message)
        {
            /* para imprimir mensajes de Exito*/
            MessageBox.Show(message, Configuration.system_name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void exclamationMessage(string message)
        {
            /* para imprimir mensajes de Exito*/
            MessageBox.Show(message, Configuration.system_name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
