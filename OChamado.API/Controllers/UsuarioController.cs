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
    [Route("api/usuario")]
    public class UsuarioController : Controller
    {
        private readonly UsuarioDao _usuarioDao;
        private readonly ChamadoContext _context;

        public UsuarioController(UsuarioDao dao, ChamadoContext context)
        {
            _usuarioDao = dao;
            _context = context;
        }


        [HttpPost]
        [Route("cadastar-usuario")]
        private IActionResult CadastrarUsuario([FromBody] Usuario usuario)
        {
            _usuarioDao.Save(usuario);
            return Json (new { Status = "Ok", Mensagem = "Usuario cadastrado com sucesso!" });

        }

        [HttpGet]
        [Route("{id}")]
        private Usuario RetornarUsuario(params object[] args)
        {
            Usuario usuario = _usuarioDao.Get(args);
            return usuario ?? null;
        }

        [HttpGet]
        [Route("listar-usuarios")]
        private IEnumerable<Usuario> RetornarUsuarios()
        {
            return _usuarioDao.List();
        }



    }
}