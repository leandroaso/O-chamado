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
    [Route("api/responsavel")]
    public class ResponsavelController : Controller
    {
        public ResponsavelDao _responsavelDao { get; }

        private readonly ChamadoContext _context;

        public ResponsavelController(ResponsavelDao dao, ChamadoContext context)
        {
            _responsavelDao = dao;
            _context = context;
        }

        [HttpGet]
        [Route("{id}")]
        public Responsavel RetornarResponsavel(params object[] args)
        {
            return _responsavelDao.Get(args);
        }

        [HttpGet]
        [Route("listar-responsaveis")]
        public IEnumerable<Responsavel> RetornarResponsaveis()
        {
            return _responsavelDao.List();
        }

    }
}