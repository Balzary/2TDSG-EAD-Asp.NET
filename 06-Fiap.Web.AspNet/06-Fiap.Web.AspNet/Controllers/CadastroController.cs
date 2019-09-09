using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_Fiap.Web.AspNet.Models;
using _06_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class CadastroController : Controller
    {

        private AllCorridaContext _context;

        public CadastroController(AllCorridaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {
            return View(_context.Corridas.ToList());
        } 

        public IActionResult Buscar(int id)
        {
            var busca = _context.Corridas.Find(id);
            return View(busca);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Corrida corrida)
        {
            _context.Corridas.Add(corrida);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return View(corrida);
            
        }

    }
}