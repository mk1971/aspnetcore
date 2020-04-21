using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp1.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string nome { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult pag1()
        {
            //utilizar o ViewBag
            //ViewBag.mensagem1 = "Esta é a mensagem 1 para a página 1.";
            //ViewBag.mensagem2 = "Esta é a mensagem 2 para a página 1.";
            
            return View();
        }

        public IActionResult pag2()
        {

            //usando ViewData
            //ViewData["nome"] = "João";
            //ViewData["apelido"] = "Ribeiro";

            return View();
        }

        public IActionResult pag3()
        {
            nome = "João";
            return View();
        }

    }
}