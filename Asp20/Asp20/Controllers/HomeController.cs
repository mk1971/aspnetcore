using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp20.Models;

namespace Asp20.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Cliente> lista_Clientes = new List<Cliente>()
            {
                new Cliente()
                {
                    nome = "João",
                    apelido = "Ribeiro"
                },
                new Cliente()
                {
                    nome = "Ana",
                    apelido = "Silva"
                },
                new Cliente()
                {
                    nome = "Carlos",
                    apelido = "Oliveira"
                }
            };

            return View(lista_Clientes);
        }
    }
}