using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data;
using utils;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Idcliente = 1;
            cliente.Nombre = "Juan";
            cliente.Apellido = "Pedro";
            cliente.Direccion = "Tamboril";
            cliente.Telefono = "8094389815";
            cliente.Email = "juanpedro1519@gmail.com";
            cliente.Is_active = true;
            ConsoleUtils.printDatatable(cliente.searchClientesByName("j"));
            Console.ReadKey();
        }
    }
}
