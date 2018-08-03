using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OChamado.API.Models
{
    public class Solucao
    {
        public int Id { get; set; }
        [Required]
        public String Nome { get; set; }
        public String Descricao { get; set; }
    }
}
