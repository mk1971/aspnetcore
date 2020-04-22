using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp11.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("menu_inicial");
        }

        [HttpGet("home/novo_cliente")]
        public ViewResult Novo_Cliente_Frm()
        {
            return View();
        }

        [HttpPost("home/novo_cliente")]
        public string Novo_Cliente_Gravar()
        {
            //todo mecanismo de ghravacao dos dados do cliente no bd
            return "Novo cliente gravado com sucesso.";
        }
    }
}