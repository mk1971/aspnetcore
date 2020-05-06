using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp24.Models;

namespace Asp24.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Dados.Todos_os_Dados());
        }

        public IActionResult Novo_Cliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo_Cliente(Cliente item)
        {
            Dados.AdicionarCliente(item);

            return RedirectToAction("index");
        }

        public IActionResult Eliminar(int id)
        {
            // pedir ao model que elimine o registro desejado
            Dados.EliminarClientes(id);

            return RedirectToAction("index");
        }
    }
}