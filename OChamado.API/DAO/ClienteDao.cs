using OChamado.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OChamado.API.DAO
{
    public class ClienteDao : BaseDao<Cliente>
    {
        private readonly ChamadoContext _context;

        public ClienteDao(ChamadoContext chamadoContext){_context = chamadoContext;}

        public void Delete(int id)
        {
            Cliente cliente = Get(id);
            _context.Cliente.Remove(cliente);
            _context.SaveChanges();
        }

        public Cliente Get(params object[] id)
        {
            return _context.Cliente.Find(id);
        }

        public IEnumerable<Cliente> List()
        {
            return _context.Cliente.ToList();
        }

        public void Save(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
        }

        public void SaveAll(IEnumerable<Cliente> clientes)
        {
            _context.Cliente.AddRange(clientes);
            _context.SaveChanges();
        }

        public void Updade(Cliente cliente)
        {
            _context.Cliente.Update(cliente);
            _context.SaveChanges();
        }
    }
}
