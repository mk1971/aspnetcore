using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp10.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Estou no Index";
        }

        [Route("home/adicionar/{parcela1?}/{parcela2?}")]
        public string Adicionar(int parcela1, int parcela2)
        {
            return parcela1 + " + " + parcela2 + " = " + (parcela1 + parcela2).ToString();
        }
    }
}