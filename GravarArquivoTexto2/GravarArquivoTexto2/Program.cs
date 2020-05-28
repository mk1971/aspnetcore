using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GravarArquivoTexto2
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo = @"C:\NetCore\aspnetcore\GravarArquivoTexto2\GravarArquivoTexto2.txt";
            if (File.Exists(arquivo))
            {
                try
                {
                    using(StreamReader sr = new StreamReader(arquivo))
                    {
                        String linha;

                        //le linha por linha
                        while ((linha = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(linha);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("O arquivo " + arquivo + " não foi localizado!");
            }
            Console.ReadKey();
        }
    }
}
