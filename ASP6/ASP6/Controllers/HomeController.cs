using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP6.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            //criar um homem
            Humano homem = new Humano()
            {
                Nome = "João",
                Apelido = "Riberiro"
            };

            //criar carro
            Automovel carro = new Automovel()
            {
                Marca = "Audi",
                Cor = "Metal"
            };


            //coloca os 2 viewmodels no mesmo BAG (um viewmodel geral)
            BAG saco = new BAG()
            {
                humano = homem,
                automovel = carro
            };

            return View(saco);
        }
    }
}