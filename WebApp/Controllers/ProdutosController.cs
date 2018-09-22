using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities;
using WebApp.Models.Produtos;

namespace WebApp.Controllers
{
    public class ProdutosController: Controller
    {
        private WebAppContext db;

        public ProdutosController(WebAppContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var model = new IndexViewModel();
            model.Titulo = "Todos os produtos";
            model.Mensagem = "Funcionou";
            model.TotalProdutos = 2;

            model.Produtos = db.Produtos.ToList();

            return View(model);
        }

        public IActionResult Novo()
        {
            return View();
        }
    }
}
