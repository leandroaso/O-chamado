using OChamado.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OChamado.API.DAO
{
    public class ResponsavelDao : BaseDao<Responsavel>
    {
        private readonly ChamadoContext _context;

        public ResponsavelDao(ChamadoContext chamadoContext)
        {
            _context = chamadoContext;
        }

        public void Delete(int id)
        {
            Responsavel responsavel = Get(id);
            _context.Responsavel.Remove(responsavel);
            _context.SaveChanges();
        }

        public Responsavel Get(params object[] id)
        {
            return _context.Responsavel.Find(id);
        }

        public IEnumerable<Responsavel> List()
        {
            return _context.Responsavel.ToList();
        }

        public void Save(Responsavel responsavel)
        {
            _context.Responsavel.Add(responsavel);
            _context.SaveChanges();
        }

        public void SaveAll(IEnumerable<Responsavel> responsaveis)
        {
            _context.Responsavel.AddRange(responsaveis);
            _context.SaveChanges();
        }

        public void Updade(Responsavel responsavel)
        {
            _context.Responsavel.Update(responsavel);
            _context.SaveChanges();
        }
    }
}
