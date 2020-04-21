using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP6.ViewModels
{
    public class Humano
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
    }

    public class Automovel
    {
        public string Marca { get; set; }
        public string Cor { get; set; }
    }

    public class BAG
    {
        public Humano humano { get; set; }
        public Automovel automovel { get; set; }
    }
}
