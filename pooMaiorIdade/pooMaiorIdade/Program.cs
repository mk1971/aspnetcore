using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa();
            //Pessoa p3 = new Pessoa();

            Pessoa p1 ;
            Pessoa p2 ;
            Pessoa p3 ;
            Console.WriteLine("Determina qual a pessoa é a mais velha");
            //Leitura de dados da 1a pessoa
            Console.Write("Nome da 1a pessoa: ");
            p1 = new Pessoa();
            p1.Nome = Console.ReadLine();

            Console.Write("Idade da 1a pessoa: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            //Leitura de dados da 2a pessoa
            Console.Write("Nome da 2a pessoa: ");
            p2 = new Pessoa();
            p2.Nome = Console.ReadLine();

            Console.Write("Idade da 2a pessoa: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            //Leitura de dados da 3a pessoa
            Console.Write("Nome da 3a pessoa: ");
            //p1 = new Pessoa();
            //p1.Nome = Console.ReadLine();
            String nome = Console.ReadLine();
            //Console.WriteLine("Idade da 3a pessoa: ");
            Console.Write("Idade da 3a pessoa: ");
            //p1.Idade = Convert.ToInt32(Console.ReadLine());
            int idade = Convert.ToInt32(Console.ReadLine());
            p3 = new Pessoa(nome, idade);

            //Logica
            if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p1.ExibirDados();
            }
            else
            {
                if ((p2.Idade > p3.Idade) && (p2.Idade > p1.Idade))
                {
                    Console.WriteLine("A pessoa mais velha é: ");
                    p2.ExibirDados();
                }
                else
                {
                    if ((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
                    {
                        Console.WriteLine("A pessoa mais velha é: ");
                        p3.ExibirDados();
                    }
                    else
                    {
                        Console.WriteLine("Todas as pessoas possuem a mesma idade.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
