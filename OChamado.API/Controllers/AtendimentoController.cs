using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Post( [FromBody] AtendimentoVO atendimento )
        {
            //Dao.Save(atendimento);
            return Created(string.Empty, atendimento);
        }
    }
}