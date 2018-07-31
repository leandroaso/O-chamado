using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OChamado.API.Models
{
    public class EmpresaSolucao
    {
        public Empresa Empresa { get; set; }
        public Solucao Solucao { get; set; }
        public int EmpresaId { get; set; }
        public int SolucaoId { get; set; }
    }
}
