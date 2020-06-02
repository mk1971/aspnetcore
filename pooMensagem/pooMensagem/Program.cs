using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1, msg2;
            msg1 = new Mensagem();
            msg1.TextoMensagem = "Alô mundo!";
            msg1.ExibirMensagem();
            //msg1.setTextoMensagem("Alô mundo!");
            //Console.WriteLine(msg1.getTextoMensagem());
            //msg1.ExibirMensagem();

            //msg2 = new Mensagem();
            ////msg2.TextoMensagem = "Segundo objeto";
            //msg2.ExibirMensagem();
            Console.ReadKey();
        }
    }
}
