using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OChamado.API.Models
{
    public class AtendimentoVO
    {
        public string Descricao { get; set; }
        public string Motivo { get; set; }
        public string Cliente { get; set; }
        public string Aplicacao { get; set; }
    }
}
