using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities;

namespace WebApp.Models.Produtos
{
    public class IndexViewModel
    {
        public string Titulo { get; set; }
        public string Mensagem { get; set; }
        public int TotalProdutos { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }
    }
}
