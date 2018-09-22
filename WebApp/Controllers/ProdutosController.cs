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

        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(NovoViewModel novo)
        {
            var produto = new Produto()
            {
                Nome = novo.Nome,
                Descricao = novo.Descricao,
                Valor = novo.Valor,
                Quantidade = novo.Quantidade
            };

            db.Produtos.Add(produto);
            db.SaveChanges();

            return RedirectToAction("Visualizar", new { Id = produto.Id });
        }

        [HttpGet]
        public IActionResult Visualizar(int id)
        {
            var produto = db.Produtos.SingleOrDefault(p => p.Id == id);
            var model = new VisualizarViewModel() {
                Id = produto.Id,
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Valor = produto.Valor,
                Quantidade = produto.Quantidade
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var produto = db.Produtos.SingleOrDefault(p => p.Id == id);
            var model = new EditarViewModel()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Valor = produto.Valor,
                Quantidade = produto.Quantidade
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Editar(EditarViewModel model)
        {
            var produto = db.Produtos.SingleOrDefault(p => p.Id == model.Id);
            produto.Nome = model.Nome;
            produto.Descricao = model.Descricao;
            produto.Valor = model.Valor;
            produto.Quantidade = model.Quantidade;
            db.SaveChanges();
            model.Mensagem = "Alterado com sucesso";

            return View(model);
        }

        public IActionResult Excluir(int id)
        {
            var produto = db.Produtos.SingleOrDefault(p => p.Id == id);
            db.Produtos.Remove(produto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
