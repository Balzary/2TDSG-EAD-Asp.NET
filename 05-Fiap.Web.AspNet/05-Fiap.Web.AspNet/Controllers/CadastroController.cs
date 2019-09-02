using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using _05_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class CadastroController : Controller
    {
        //o cara que acessa o banco
        private AllZooContext _context;

        public CadastroController(AllZooContext context)
        {
            _context = context;
        }
        //private static IList<Zoo> _lista = new List<Zoo>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {
            return View(_context.Zoos.ToList());
        }

        public IActionResult Buscar(int id)
        {
            var busca = _context.Zoos.Find(id);
            return View(busca);
        }


        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Zoo zoo)
        {
            _context.Zoos.Add(zoo);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return View(zoo);
        }

        [HttpDelete]
        public IActionResult Deletar(int id)
        {
            Zoo zoo = _context.Zoos.Find(id);
            _context.Zoos.Remove(zoo);
            _context.SaveChanges();
            TempData["msg"] = "Deletado!";
            return View();
        }
        [HttpPut]
        public IActionResult Editar(int id)
        {
            Zoo zoo = _context.Zoos.Find(id);            
            _context.Attach(zoo).State = EntityState.Modified;
            _context.SaveChanges();
            return View();
        }
    }
}