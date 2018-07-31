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
    [Route("api/empresa-solucao")]
    public class EmpresaSolucaoController : Controller
    {
        private readonly EmpresaSolucaoDao _empsolDao;
        private readonly ChamadoContext _context;

        public EmpresaSolucaoController(EmpresaSolucaoDao dao, ChamadoContext context)
        {
            _empsolDao = dao;
            _context = context;
        }

        [HttpGet]
        [Route("empresa-solucoes")]
        public IEnumerable<EmpresaSolucao> ListarSolucaoPorEmpresa()
        {
            return _empsolDao.List();
        }

        [HttpPost]
        [Route("cadastrar-empresa-solucao")]
        public IActionResult CadastrarSolucaoPorEmpresa([FromBody] Empresa empresa, Solucao solucao)
        {
            EmpresaSolucao empresaSolucao = new EmpresaSolucao();
            empresaSolucao.Empresa = empresa;
            empresaSolucao.Solucao = solucao;
            
            _empsolDao.Save(empresaSolucao);

            return Json (
                new { Status = "Ok", Mensagem = "EmpresaSolucao cadastrada!"});
        }

        

    }
}