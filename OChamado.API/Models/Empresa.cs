using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OChamado.API.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        [Required]
        public String Nome { get; set; }
        public ICollection<EmpresaSolucao> EmpresaSolucao { get; set; }
        public ICollection<Atendimento> Atendimento{get; set;}
    }
}
