using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp25.Models
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

        public static Cliente Dados_Cliente(int id)
        {
            var cliente = Lista_Clientes.Where(i => i.id == id).FirstOrDefault();
            return cliente;
        }

        public static void Editar_Cliente(Cliente c)
        {
            Lista_Clientes.Where(i => i.id == c.id).First().Nome = c.Nome;
            Lista_Clientes.Where(i => i.id == c.id).First().Telefone = c.Telefone;
        }
    }
}
