using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp2.ViewModels;

namespace Asp2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Cliente novo = new Cliente()
            {
                nome = "João",
                apelido = "Ribeiro",
                telefone = "123456789"
            };

            return View(novo);
        }
    }
}