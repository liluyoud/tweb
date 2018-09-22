using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entities
{
    public class Categoria
    {
        public int Id { get; set; }

        [MaxLength(256)]
        public string Descricao { get; set; }
    }
}
