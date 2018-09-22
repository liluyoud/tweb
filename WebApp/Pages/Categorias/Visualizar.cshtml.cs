using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Entities;

namespace WebApp.Pages.Categorias
{
    public class VisualizarModel : PageModel
    {
        private WebAppContext db;

        public VisualizarModel(WebAppContext db)
        {
            this.db = db;
        }
       
        public int Id { get; set; }

        public string Descricao { get; set; }

        public void OnGet(int id)
        {
            var categoria = db.Categorias.SingleOrDefault(p => p.Id == id);
            Id = categoria.Id;
            Descricao = categoria.Descricao;
        }
    }
}