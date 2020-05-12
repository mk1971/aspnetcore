using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp26.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp26.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //apresenta o menu inicial
            return View();
        }

        public IActionResult Lista_Clientes()
        {
            // apresenta a lista de clientes da aplicacao
            return View(Dados.Todos_os_Clientes());
        }

        public IActionResult Adicionar_Clientes()
        {
            // adicionar um novo cliente
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar_Cliente(Cliente cliente)
        {
            // guardar os dados do novo cliente
            Dados.Adicionar_Cliente(cliente);
            return RedirectToAction("Adicionar_Clientes");
        }

        public IActionResult Editar_Cliente(int id)
        {
            //editar os dados do cliente selecionado
            return View(Dados.Dados_Cliente(id));
        }

        [HttpPost]
        public IActionResult Editar_Cliente(Cliente c)
        {
            Dados.Editar_Cliente(c);
            return RedirectToAction("Lista_Clientes");
        }

        public IActionResult Eliminar_Cliente(int id)
        {
            //eliminar o cliente selecionado
            Dados.Eliminar_Cliente(id);
            return RedirectToAction("Lista_Clientes");
        }
    }
}