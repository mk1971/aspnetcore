using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp19.Models;

namespace Asp19.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Cliente novo_Cliente = new Cliente();
            novo_Cliente.nome = "João";
            novo_Cliente.apelido = "Ribeiro";

            return View(novo_Cliente);
        }
    }
}