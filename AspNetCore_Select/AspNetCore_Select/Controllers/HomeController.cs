using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore_Select.Models;
using AspNetCore_Select.Services;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCore_Select.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Estados = EstadosServices.GetEstados().Select(c => new SelectListItem() { Text = c.EstadoNome, Value = c.EstadoSigla }).ToList();
            return View();
        }
    }
}
