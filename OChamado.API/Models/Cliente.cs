using OChamado.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OChamado.API.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        public String Nome { get; set; }
    }
}
