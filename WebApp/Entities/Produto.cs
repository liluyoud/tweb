using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entities
{
    public class Produto
    {
        public int Id { get; set; }

        [MaxLength(256)]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public int Quantidade { get; set; }

        public Categoria Categoria { get; set; }

        public string Foto { get; set; }
    }
}
