using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace OChamado.API.Models
{
    public class Responsavel
    {
        public int Id { get; set; }
        [Required]
        public String Nome { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

    }
}
