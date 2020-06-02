using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Mensagem
    {
        //private String TextoMensagem;

        //public void ExibirMensagem()
        //{
        //    Console.WriteLine(this.TextoMensagem);
        //}

        ////efetuar leitura da propriedade
        //public String getTextoMensagem()
        //{
        //    //this -> interagindo com algo do objeto
        //    return this.TextoMensagem;
        //}

        ////void : nao retorna nada
        //public void setTextoMensagem(String valor)
        //{
        //    this.TextoMensagem = valor;
        //}


        //Propriedade
        
        //somente o objeto consegue interagir
        //objetivo: armazenar um dado
        private String textoMensagem;

        public String TextoMensagem
        {
            get
            {
                return this.textoMensagem;
            }

            set
            {
                this.textoMensagem = value.ToUpper();
            }
        }

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }
    }
}
