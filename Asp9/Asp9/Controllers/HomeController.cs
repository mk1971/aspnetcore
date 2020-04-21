using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp9.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        [Route("Home/aaa")]
        public string Index()
        {
            return "Estou no Index";
        }

        [Route("Home/acao1/{id?}")]
        public string acao1(int id)
        {
            return "Estou na acao1. ID = " + id;
        }

        [Route("home/post")]
        public string acao2()
        {
            return "Estou na acao2. Novo";
        }
    }
}