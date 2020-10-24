using Aula03.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteController clienteController = new ClienteController();
            clienteController.InsertCliente();
            clienteController.SelectAllClientes();
            clienteController.SelectByIdCliente();
            clienteController.SelectByNameClientes();

            Console.ReadKey();
        }
    }
}
