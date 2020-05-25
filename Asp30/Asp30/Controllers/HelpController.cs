using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp30.Controllers
{
    public class HelpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Metodo1()
        {
            return "Estou no método 1 do help controller";
        }
    }
}
