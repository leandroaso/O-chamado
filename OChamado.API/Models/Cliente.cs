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
        [Required]
        public String Telefone { get; set; }
        public String Email { get; set; }
        [Required]
        public String VendedorCodigo {get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
