using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp30.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Metodo1()
        {
            return "Estou no método 1 do home controller";
        }
        public string Metodo2(int id)
        {
            return "Estou no método 2 do home controller e o valor de ID = " + id;
        }

        [Route("Metodo3/{nome}")]
        public string Metodo3(string nome)
        {
            return "Estou no método 3 do home controller e o meu nome é " + nome;
        }
    }
}
