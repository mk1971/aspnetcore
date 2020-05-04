using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp21.Models;

namespace Asp21.Controllers
{
    public class HomeController : Controller
    {
        //definicao de lista de dados
        List<Cliente> lista_clientes;

        public HomeController()
        {
            //controlador da classe HomeController
            lista_clientes = new List<Cliente>()
            {
                new Cliente(){ id = 0, Nome = "João", Apelido = "Ribeiro"},
                new Cliente(){ id = 1, Nome = "Ana", Apelido = "Silva"},
                new Cliente(){ id = 2, Nome = "Carlos", Apelido = "Oliveira"}
            };
        }

        public IActionResult Index()
        {
            return View(lista_clientes);
        }

        public ViewResult detalhes(int id)
        {
            return View(lista_clientes[id]);
        }
    }
}