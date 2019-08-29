using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _03_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _03_Fiap.Web.AspNet.Controllers
{
    public class UsuarioController : Controller
    {   
        [HttpGet]
        public IActionResult Cadastrar()
        {
           return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Cliente cliente)
        {
            ViewBag.nome = cliente.nome;
            ViewBag.email = cliente.email;
            ViewBag.cliente = cliente.dataNascimento;
            ViewBag.sucesso = "Cadastrado com Sucesso";
            return View();
        }


    }
}