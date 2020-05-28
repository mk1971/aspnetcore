using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GravarArquivoTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria um escrito e abre o arquivo
            TextWriter tw = new StreamWriter("GravarArquivoTexto.txt");

            //escreve uma linha de texto no arquivo
            tw.WriteLine(DateTime.Now);

            //fecha o stream
            tw.Close();
        }
    }
}
