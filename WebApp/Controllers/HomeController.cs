using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            var model = new IndexViewModel();
            model.Titulo = "Meu modelo";
            model.Hoje = DateTime.Now;
            model.Soma = 10;
            return View(model);
        }

        public IActionResult Ola()
        {
            return View();
        } 

        public IActionResult Soma()
        {
            var obj = new { Id = 1, Nome = "lilo" };
            return Ok(obj);
        }
    }
}
