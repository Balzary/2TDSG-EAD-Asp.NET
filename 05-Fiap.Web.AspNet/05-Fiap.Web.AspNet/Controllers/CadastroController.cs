using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class CadastroController : Controller
    {

        private static IList<Zoo> _lista = new List<Zoo>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {
            return View(_lista);
        }


        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Zoo zoo)
        {
            _lista.Add(zoo);
            TempData["msg"] = "Cadastrado!";
            return View(zoo);
        }
    }
}