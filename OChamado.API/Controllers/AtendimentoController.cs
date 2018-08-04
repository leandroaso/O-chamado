using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OChamado.API.Class;
using OChamado.API.DAO;
using OChamado.API.Models;

namespace OChamado.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Atendimento")]
    public class AtendimentoController : Controller
    {
        public AtendimentoDao Dao { get; set; }
        public AtendimentoController(AtendimentoDao dao)
        {
            Dao = dao;
        }

        [HttpGet]
        [Route("lista")]
        public IActionResult Get()
        {
            var atendimentos = Dao.List();
            return Ok(atendimentos);
        }

        [HttpPost]
        [Route("Cadastro")]
        public IActionResult Post( [FromBody] AtendimentoVO atendimentoVo )
        {
            var atendimento = new Atendimento()
            {
                Cliente = new Cliente
                {
                    Nome = atendimentoVo.Cliente
                },
                DataCriacao = DateTime.Now,
                Descricao = atendimentoVo.Descricao,
                StatusAtendimento = EStatusAtendimento.Aberto,
                Aplicacao = atendimentoVo.Aplicacao,
                Motivo = atendimentoVo.Motivo
            };
            Dao.Save(atendimento);
            return Created(string.Empty, atendimento);
        }

        [HttpPost]
        [Route("Salvar")]
        public IActionResult Atualizar([FromBody] AtendimentoVO atendimentoVo)
        {
            var atendimento = Dao.Get(atendimentoVo.Id);
            atendimento.Solucao = atendimentoVo.Solucao;
            atendimento.StatusAtendimento = EStatusAtendimento.EmAndamento;

            Dao.Updade(atendimento);
            return Ok(atendimento);
        }


        [HttpPost]
        [Route("Finalizar")]
        public IActionResult Finalizar([FromBody] AtendimentoVO atendimentoVo)
        {
            var atendimento = Dao.Get(atendimentoVo.Id);
            atendimento.Solucao = atendimentoVo.Solucao;
            atendimento.StatusAtendimento = EStatusAtendimento.Concluido;

            Dao.Updade(atendimento);
            return Ok(atendimento);
        }

        //[HttpGet]
        //[Route("retornar-atendimento")]
        //public Atendimento RetornarAtendimentoPor(params object[] args)
        //{
            
        //}

    }
}