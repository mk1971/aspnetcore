using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp31.Controllers
{
    public class OutroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string processar()
        {
            return "Estou no processar. (OutroController)";
        }
    }
}
