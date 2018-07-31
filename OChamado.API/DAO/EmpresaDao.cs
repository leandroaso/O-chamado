using OChamado.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OChamado.API.DAO
{
    public class EmpresaDao : BaseDao<Empresa>
    {
        private readonly ChamadoContext _context;

        public EmpresaDao(ChamadoContext chamadoContext)
        {
            _context = chamadoContext;
        }

        public void Delete(int id)
        {
            Empresa empresa = Get(id);
            _context.Empresa.Remove(empresa);
            _context.SaveChanges();
        }

        public Empresa Get(params object[] id)
        {
            return _context.Empresa.Find(id);
        }

        public IEnumerable<Empresa> List()
        {
            return _context.Empresa.ToList();
        }

        public void Save(Empresa empresa)
        {
            _context.Empresa.Add(empresa);
            _context.SaveChanges();
        }

        public void SaveAll(IEnumerable<Empresa> empresas)
        {
            _context.Empresa.AddRange(empresas);
            _context.SaveChanges();
        }

        public void Updade(Empresa empresa)
        {
            _context.Empresa.Update(empresa);
            _context.SaveChanges();
        }
    }
}
