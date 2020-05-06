using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp23.Models; 

namespace Asp23.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // view de entrada que apresenta um titulo, a lista de clientes ou a mensagem indicando que nao existem cliente
            return View(Dados.Todos_os_Dados());
        }

        public IActionResult Novo_Cliente()
        {
            // apresenta o formulario para adicionar novo cliente
            return View();
        }

        [HttpPost]
        public IActionResult Novo_Cliente(Cliente item)
        {
            // pede ao model que adicione o novo cliente caso seja possivel
            Dados.AdicionarCliente(item);

            return RedirectToAction("index");
        }
    }
}