using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp31.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("formulario");
        }

        public string processar()
        {
            return "Estou no processar";
        }

        public string processar2()
        {
            return "Estou no processar2";
        }

        [Route("Home/processar_Final", Name = "teste")]
        public string processar_Final()
        {
            return "Estou no processar Final!";
        }
    }
}
