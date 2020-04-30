using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp18.Models;

namespace Asp18.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Cliente> lista_clientes = new List<Cliente>();
            lista_clientes.Add(new Cliente() { nome = "João", apelido = "Ribeiro" });
            lista_clientes.Add(new Cliente() { nome = "Ana", apelido = "Silva" });
            lista_clientes.Add(new Cliente() { nome = "Carlos", apelido = "Oliveira" });

            return View(lista_clientes);
        }
    }
}