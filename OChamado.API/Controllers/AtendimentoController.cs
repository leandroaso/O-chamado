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
    [Route("api/atendimento")]
    public class AtendimentoController : Controller
    {
        public readonly AtendimentoDao _atendimentoDao ;

        private readonly ChamadoContext _context;

        public AtendimentoController(AtendimentoDao dao, ChamadoContext chamadoContext)
        {
            _atendimentoDao = dao;
            _context = chamadoContext;
        }
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult CadastrarAtendimento(Atendimento atendimento)
        {
            _atendimentoDao.Save(atendimento);
            return Json (new { Status= "OK", Mensagem = "Cadastrado"});
        }

        [HttpGet]
        [Route("listar")]
        public IEnumerable<Atendimento> ListarAtendimentos()
        {
            return _atendimentoDao.List();
        }

        [HttpGet]
        [Route("buscar")]
        public Atendimento BuscarAtendimento(params object[] args)
        {
            return _atendimentoDao.Get(args);
        }


    }
}