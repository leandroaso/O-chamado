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
    [Route("api/empresa")]
    public class EmpresaController : Controller
    {
        private readonly EmpresaDao _empresaDao;
        private readonly ChamadoContext _context;

        public EmpresaController(EmpresaDao dao, ChamadoContext chamadoContext)
        {
            _empresaDao = dao;
            _context = chamadoContext;
        }

        [HttpGet]
        [Route("lista")]
        public IActionResult Get()
        {
            IEnumerable<Empresa> empresas = _empresaDao.List();
            return Ok(empresas);
        }

        [HttpPost]
        [Route("cadastrar-empresa")]
        public IActionResult CadastrarEmpresa([FromBody] Empresa empresa)
        {
            
            _empresaDao.Save(empresa);
            return Json (new { 
                Status = "Ok",
                Mensagem = "Empresa cadastrada com sucesso!"
                });
        }

        [HttpGet]
        [Route("{id}")]
        public Empresa RetornarEmpresa([FromBody] string Nome)
        {
            Empresa EmpresaDoBanco = _empresaDao.Get(Nome);

            return EmpresaDoBanco != null ? EmpresaDoBanco : null;
        }

    }
}