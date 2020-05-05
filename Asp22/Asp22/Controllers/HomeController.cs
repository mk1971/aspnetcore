using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp22.Models;

namespace Asp22.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // view de entrada que apresenta um titulo, a lista de clientes ou a mensagem indicando que nao existem cliente
            return View(Dados.Lista_Clientes);
        }

        public IActionResult novo_Cliente()
        {
            // apresenta o formulario para adicionar novo cliente
            return View();
        }

        [HttpPost]
        public IActionResult novo_Cliente(Cliente item)
        {
            // adicionar o novo cliente a colecao
            Dados.Lista_Clientes.Add(item);

            return RedirectToAction("index");
        }
    }
}