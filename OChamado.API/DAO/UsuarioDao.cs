using OChamado.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OChamado.API.DAO
{
    public class UsuarioDao : BaseDao<Usuario>
    {
        private readonly ChamadoContext _context;

        public UsuarioDao(ChamadoContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            Usuario usuario = Get(id);
            _context.Usuario.Remove(usuario);
            _context.SaveChanges();
        }

        public Usuario Get(params object[] id)
        {
            return _context.Usuario.Find(id);
        }

        public IEnumerable<Usuario> List()
        {
            return _context.Usuario.ToList();
        }

        public void Save(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
        }

        public void SaveAll(IEnumerable<Usuario> usuarios)
        {
            _context.Usuario.AddRange(usuarios);
            _context.SaveChanges();
        }

        public void Updade(Usuario usuario)
        {
            _context.Usuario.Update(usuario);
            _context.SaveChanges();
        }
    }
}
