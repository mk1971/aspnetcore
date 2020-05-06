using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp24.Models
{
    public static class Dados
    {
        private static List<Cliente> Lista_Clientes = new List<Cliente>();

        public static IEnumerable<Cliente> Todos_os_Dados()
        {
            return Lista_Clientes;
        }

        public static void AdicionarCliente(Cliente item)
        {
            // atribuir o id ao item
            /*
             * item.id = 0
             * item.Nome
             * item.Telefone
             */
            item.id = 0;
            if(Lista_Clientes.Count != 0)
            {
                item.id = Lista_Clientes.Last<Cliente>().id + 1;
            }

            Lista_Clientes.Add(item);
        }

        public static void EliminarClientes(int id)
        {
            var item = Lista_Clientes.First<Cliente>(i => i.id == id);
            Lista_Clientes.Remove(item);
        }
    }
}
