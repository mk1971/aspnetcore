using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da lista
            List<string> lista = new List<string>();

            string opcao = "1";

            while (opcao == "1")
            {
                Console.WriteLine("Digita um nome para inserir na lista:");
                string nome = Console.ReadLine();
                //Adiciona o item a lista
                lista.Add(nome);
                Console.WriteLine("Deseja inserir outro nome? 1-SIM | 2-NAO");
                opcao = Console.ReadLine();
            }

            //Ordena a lista
            lista.Sort();
            Console.WriteLine("A lista tem " + lista.Count() + " itens:");
            //Imprime cada item da lsita
            lista.ForEach(i => Console.WriteLine(i));
            Console.ReadLine();
        }
    }
}
