using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OChamado.API.DAO;
using OChamado.API.Models;
using StackExchange.Redis;

namespace OChamado.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Login")]
    public class LoginController : Controller
    {
        public UsuarioDao UsuarioDao { get; set; }
        public ChamadoContext ChamadoContext { get; set; }
        public LoginController(UsuarioDao dao, ChamadoContext context)
        {
            UsuarioDao = dao;
            ChamadoContext = context;
        }

        [HttpGet]
        [Route("Logar")]
        public IActionResult Logar(Usuario usuario)
        {
            var user = UsuarioDao.Find(usuario);
            if (user != null)
                return Ok(user);

            return BadRequest();
        }

    }
}