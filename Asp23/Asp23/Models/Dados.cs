using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp23.Models
{
    public static class Dados
    {
        private static List<Cliente> Lista_Clientes = new List<Cliente>();

        //public static IEnumerable<Cliente> Todos_os_Dados
        //{
        //    get { return Lista_Clientes; }
        //}

        public static IEnumerable<Cliente> Todos_os_Dados()
        {
            return Lista_Clientes;
        }

        public static void AdicionarCliente(Cliente item)
        {
            Lista_Clientes.Add(item);
        }
    }
}
