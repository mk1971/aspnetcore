using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp26.Models
{
    public static class Dados
    {
        // dados da aplicacao
        private static List<Cliente> Lista_Clientes = new List<Cliente>();

        public static List<Cliente> Todos_os_Clientes()
        {
            // todos os clientes da aplicacao
            return Lista_Clientes;
        }

        public static void Adicionar_Cliente(Cliente clientetemp)
        {
            //buscar o id disponivel
            int id = 0;
            if (Lista_Clientes.Count != 0) id = Lista_Clientes.Last<Cliente>().id + 1;

            //guardar os dados do novo cliente
            clientetemp.id = id;
            Lista_Clientes.Add(clientetemp);
        }

        public static Cliente Dados_Cliente(int id)
        {
            //devolve os dados de cliente selecionado
            Cliente ClienteTemp = Lista_Clientes.Where(i => i.id == id).FirstOrDefault();
            return ClienteTemp;
        }

        public static void Editar_Cliente(Cliente c)
        {
            //editar os dados do cliente selecionado
            Lista_Clientes.First<Cliente>(i => i.id == c.id).Nome = c.Nome;
            Lista_Clientes.First<Cliente>(i => i.id == c.id).Telefone = c.Telefone;
        }

        public static void Eliminar_Cliente(int id)
        {
            //eliminar o cliente da lista de clientes
            var ClienteTemp = Lista_Clientes.First<Cliente>(i => i.id == id);
            Lista_Clientes.Remove(ClienteTemp);
        }
    }
}
