using OChamado.API.Class;
using OChamado.API.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace OChamado.API.Models
{
    public class Atendimento
    {
        public int Id { get; set; }
        public int EmpresaId { get; set; }
        public Solucao Solucao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataFinalizacao { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public String Descricao { get; set; }
        public Responsavel Responsavel { get; set; }
        public EStatusAtendimento StatusAtendimento { get; set; }
        public string Aplicacao { get; set; }
        public string Motivo { get; set; }
    }
}
