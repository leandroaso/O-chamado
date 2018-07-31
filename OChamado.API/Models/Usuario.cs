using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OChamado.API.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public String Login { get; set; }
        [Required]
        public String Senha { get; set; }
        
    }
}
