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
    [Route("api/solucao")]
    public class SolucaoController : Controller
    {
        private readonly SolucaoDao _solucaoDao;
        private readonly ChamadoContext _context;

        public SolucaoController(SolucaoDao dao, ChamadoContext context)
        {
            _solucaoDao = dao;
            _context = context;
        }

        [HttpGet]
        [Route("solucoes")]
        public IEnumerable<Solucao> RetornarSolucoes()
        {
            return _solucaoDao.List();
        }

        [HttpGet]
        [Route("{id}")]
        public Solucao RetornarSolucao([FromBody] params object[] solucao)
        {
            Solucao SolucaoDoBanco = _solucaoDao.Get(solucao);
            return SolucaoDoBanco != null ? SolucaoDoBanco : null;
        }

        [HttpPost]
        [Route("cadastrar-solucao")]
        public IActionResult CadastrarSolucao([FromBody] Solucao solucao)
        {
            _solucaoDao.Save(solucao);
            return Json (
                new { 
                    Status = "ok",
                    Mensagem = "Empresa cadastrada com sucesso!"
                    });
        }

    }
}