using OChamado.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OChamado.API.DAO
{
    public class EmpresaSolucaoDao : BaseDao<EmpresaSolucao>
    {
        private readonly ChamadoContext _context;

        public EmpresaSolucaoDao(ChamadoContext chamadoContext)
        {
            _context = chamadoContext;
        }

        public void Delete(int id)
        {
            EmpresaSolucao empresaSolucao = Get(id);
            _context.EmpresaSolucao.Remove(empresaSolucao);
            _context.SaveChanges();
        }

        public EmpresaSolucao Get(params object[] id)
        {
            return _context.EmpresaSolucao.Find(id);
        }

        public IEnumerable<EmpresaSolucao> List()
        {
            return _context.EmpresaSolucao.ToList();
        }

        public void Save(EmpresaSolucao empresaSolucao)
        {
            _context.EmpresaSolucao.Add(empresaSolucao);
            _context.SaveChanges();
        }

        public void SaveAll(IEnumerable<EmpresaSolucao> empresaSolucoes)
        {
            _context.EmpresaSolucao.AddRange(empresaSolucoes);
            _context.SaveChanges();
        }

        public void Updade(EmpresaSolucao empresaSolucao)
        {
            _context.EmpresaSolucao.Update(empresaSolucao);
            _context.SaveChanges();
        }
    }
}
