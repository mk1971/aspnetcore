using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp7.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Asp7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //criar um homem
            Humano humano = new Humano()
            {
                Nome = "João",
                Apelido = "Ribeiro"
            };

            //cria um crro
            Automovel automovel = new Automovel()
            {
                Marca = "Audi",
                Cor = "Metal"
            };


            //coloca os 2 viewmodel dentro de um
            BAG data = new BAG()
            {
                Humano = humano,
                Automovel = automovel
            };

            return View(data);
        }
    }
}