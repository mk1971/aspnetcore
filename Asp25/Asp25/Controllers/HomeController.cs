using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp25.Models;

namespace Asp25.Controllers
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
            Dados.EliminarClientes(id);
            return RedirectToAction("index");
        }

        public IActionResult Editar(int id)
        {
            // apresentar a view de edicao
            return View(Dados.Dados_Cliente(id));
        }

        [HttpPost]
        public IActionResult Editar(Cliente c)
        {
            // alterar os dados do cliente
            Dados.Editar_Cliente(c);
            return RedirectToAction("index");
        }
    }
}