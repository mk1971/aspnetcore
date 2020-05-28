using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lettxt
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria um leitor e abre o arquivo
            TextReader tr = new StreamReader("textfilereader.txt");

            //le uma linha de texto
            Console.WriteLine(tr.ReadLine());
            Console.ReadKey();

            //fecha o stream
            tr.Close();
        }
    }
}
